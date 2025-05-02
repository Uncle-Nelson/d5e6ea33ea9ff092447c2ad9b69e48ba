using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Handover
{
	// Token: 0x020006F3 RID: 1779
	public class HandoverScreen : Singleton<HandoverScreen>
	{
		// Token: 0x06009F0D RID: 40717 RVA: 0x0028255C File Offset: 0x0028075C
		// Note: this type is marked as 'beforefieldinit'.
		static HandoverScreen()
		{
			Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Handover", "HandoverScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr);
			HandoverScreen.NativeFieldInfoPtr_CUSTOMER_SLOT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CUSTOMER_SLOT_COUNT");
			HandoverScreen.NativeFieldInfoPtr_VEHICLE_MAX_DIST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "VEHICLE_MAX_DIST");
			HandoverScreen.NativeFieldInfoPtr__CurrentContract_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "<CurrentContract>k__BackingField");
			HandoverScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			HandoverScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "<TutorialOpen>k__BackingField");
			HandoverScreen.NativeFieldInfoPtr__Mode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "<Mode>k__BackingField");
			HandoverScreen.NativeFieldInfoPtr_SuccessColorMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "SuccessColorMap");
			HandoverScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "Canvas");
			HandoverScreen.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "Container");
			HandoverScreen.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CanvasGroup");
			HandoverScreen.NativeFieldInfoPtr_DescriptionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "DescriptionLabel");
			HandoverScreen.NativeFieldInfoPtr_CustomerSubtitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CustomerSubtitle");
			HandoverScreen.NativeFieldInfoPtr_FavouriteDrugLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "FavouriteDrugLabel");
			HandoverScreen.NativeFieldInfoPtr_FavouritePropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "FavouritePropertiesLabel");
			HandoverScreen.NativeFieldInfoPtr_PropertiesEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "PropertiesEntries");
			HandoverScreen.NativeFieldInfoPtr_ExpectationEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "ExpectationEntries");
			HandoverScreen.NativeFieldInfoPtr_NoVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "NoVehicle");
			HandoverScreen.NativeFieldInfoPtr_VehicleSlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "VehicleSlotContainer");
			HandoverScreen.NativeFieldInfoPtr_CustomerSlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CustomerSlotContainer");
			HandoverScreen.NativeFieldInfoPtr_VehicleSubtitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "VehicleSubtitle");
			HandoverScreen.NativeFieldInfoPtr_SuccessLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "SuccessLabel");
			HandoverScreen.NativeFieldInfoPtr_ErrorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "ErrorLabel");
			HandoverScreen.NativeFieldInfoPtr_WarningLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "WarningLabel");
			HandoverScreen.NativeFieldInfoPtr_DoneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "DoneButton");
			HandoverScreen.NativeFieldInfoPtr_VehicleContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "VehicleContainer");
			HandoverScreen.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "TitleLabel");
			HandoverScreen.NativeFieldInfoPtr_PriceSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "PriceSelector");
			HandoverScreen.NativeFieldInfoPtr_FairPriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "FairPriceLabel");
			HandoverScreen.NativeFieldInfoPtr_TutorialAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "TutorialAnimation");
			HandoverScreen.NativeFieldInfoPtr_TutorialContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "TutorialContainer");
			HandoverScreen.NativeFieldInfoPtr_DetailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "DetailPanel");
			HandoverScreen.NativeFieldInfoPtr_onHandoverComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "onHandoverComplete");
			HandoverScreen.NativeFieldInfoPtr_SuccessChanceMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "SuccessChanceMethod");
			HandoverScreen.NativeFieldInfoPtr_VehicleSlotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "VehicleSlotUIs");
			HandoverScreen.NativeFieldInfoPtr_CustomerSlotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CustomerSlotUIs");
			HandoverScreen.NativeFieldInfoPtr_CustomerSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CustomerSlots");
			HandoverScreen.NativeFieldInfoPtr_OriginalItemLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "OriginalItemLocations");
			HandoverScreen.NativeFieldInfoPtr_ignoreCustomerChangedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "ignoreCustomerChangedEvents");
			HandoverScreen.NativeFieldInfoPtr__CurrentCustomer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "<CurrentCustomer>k__BackingField");
			HandoverScreen.NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682796);
			HandoverScreen.NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682797);
			HandoverScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682798);
			HandoverScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682799);
			HandoverScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682800);
			HandoverScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682801);
			HandoverScreen.NativeMethodInfoPtr_get_Mode_Public_get_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682802);
			HandoverScreen.NativeMethodInfoPtr_set_Mode_Protected_set_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682803);
			HandoverScreen.NativeMethodInfoPtr_get_CurrentCustomer_Public_get_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682804);
			HandoverScreen.NativeMethodInfoPtr_set_CurrentCustomer_Private_set_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682805);
			HandoverScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682806);
			HandoverScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682807);
			HandoverScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682808);
			HandoverScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682809);
			HandoverScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Contract_Customer_EMode_Action_3_EHandoverOutcome_List_1_ItemInstance_Single_Func_3_List_1_ItemInstance_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682810);
			HandoverScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_EHandoverOutcome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682811);
			HandoverScreen.NativeMethodInfoPtr_DonePressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682812);
			HandoverScreen.NativeMethodInfoPtr_RecordOriginalLocations_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682813);
			HandoverScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682814);
			HandoverScreen.NativeMethodInfoPtr_ClearCustomerSlots_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682815);
			HandoverScreen.NativeMethodInfoPtr_CustomerItemsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682816);
			HandoverScreen.NativeMethodInfoPtr_UpdateDoneButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682817);
			HandoverScreen.NativeMethodInfoPtr_UpdateSuccessChance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682818);
			HandoverScreen.NativeMethodInfoPtr_GetError_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682819);
			HandoverScreen.NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682820);
			HandoverScreen.NativeMethodInfoPtr_GetCustomerItems_Private_List_1_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682821);
			HandoverScreen.NativeMethodInfoPtr_GetCustomerItemsValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682822);
			HandoverScreen.NativeMethodInfoPtr_GetCustomerItemsCount_Private_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682823);
			HandoverScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682824);
		}

		// Token: 0x17003119 RID: 12569
		// (get) Token: 0x06009F0E RID: 40718 RVA: 0x00282ADC File Offset: 0x00280CDC
		// (set) Token: 0x06009F0F RID: 40719 RVA: 0x00282B1C File Offset: 0x00280D1C
		public unsafe Contract CurrentContract
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700311A RID: 12570
		// (get) Token: 0x06009F10 RID: 40720 RVA: 0x00282B60 File Offset: 0x00280D60
		// (set) Token: 0x06009F11 RID: 40721 RVA: 0x00282B9C File Offset: 0x00280D9C
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700311B RID: 12571
		// (get) Token: 0x06009F12 RID: 40722 RVA: 0x00282BDC File Offset: 0x00280DDC
		// (set) Token: 0x06009F13 RID: 40723 RVA: 0x00282C18 File Offset: 0x00280E18
		public unsafe bool TutorialOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57506, RefRangeEnd = 57507, XrefRangeStart = 57506, XrefRangeEnd = 57507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700311C RID: 12572
		// (get) Token: 0x06009F14 RID: 40724 RVA: 0x00282C58 File Offset: 0x00280E58
		// (set) Token: 0x06009F15 RID: 40725 RVA: 0x00282C94 File Offset: 0x00280E94
		public unsafe HandoverScreen.EMode Mode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45639, RefRangeEnd = 45640, XrefRangeStart = 45639, XrefRangeEnd = 45640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_get_Mode_Public_get_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_set_Mode_Protected_set_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700311D RID: 12573
		// (get) Token: 0x06009F16 RID: 40726 RVA: 0x00282CD4 File Offset: 0x00280ED4
		// (set) Token: 0x06009F17 RID: 40727 RVA: 0x00282D14 File Offset: 0x00280F14
		public unsafe Customer CurrentCustomer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_get_CurrentCustomer_Public_get_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_set_CurrentCustomer_Private_set_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009F18 RID: 40728 RVA: 0x00282D58 File Offset: 0x00280F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281291, XrefRangeEnd = 281359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HandoverScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F19 RID: 40729 RVA: 0x00282D94 File Offset: 0x00280F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281359, XrefRangeEnd = 281369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F1A RID: 40730 RVA: 0x00282DC8 File Offset: 0x00280FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281369, XrefRangeEnd = 281374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F1B RID: 40731 RVA: 0x00282DFC File Offset: 0x00280FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281374, XrefRangeEnd = 281378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F1C RID: 40732 RVA: 0x00282E30 File Offset: 0x00281030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281378, XrefRangeEnd = 281435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(Contract contract, Customer customer, HandoverScreen.EMode mode, Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float> callback, Func<List<ItemInstance>, float, float> successChanceMethod)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(successChanceMethod);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HandoverScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Contract_Customer_EMode_Action_3_EHandoverOutcome_List_1_ItemInstance_Single_Func_3_List_1_ItemInstance_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F1D RID: 40733 RVA: 0x00282EC4 File Offset: 0x002810C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281435, XrefRangeEnd = 281506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close(HandoverScreen.EHandoverOutcome outcome)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HandoverScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_EHandoverOutcome_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F1E RID: 40734 RVA: 0x00282F10 File Offset: 0x00281110
		[CallerCount(0)]
		public unsafe void DonePressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_DonePressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F1F RID: 40735 RVA: 0x00282F44 File Offset: 0x00281144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281506, XrefRangeEnd = 281537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordOriginalLocations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_RecordOriginalLocations_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F20 RID: 40736 RVA: 0x00282F78 File Offset: 0x00281178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281537, XrefRangeEnd = 281538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F21 RID: 40737 RVA: 0x00282FBC File Offset: 0x002811BC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 281549, RefRangeEnd = 281557, XrefRangeStart = 281538, XrefRangeEnd = 281549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCustomerSlots(bool returnToOriginals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref returnToOriginals;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_ClearCustomerSlots_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F22 RID: 40738 RVA: 0x00282FFC File Offset: 0x002811FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281573, RefRangeEnd = 281575, XrefRangeStart = 281557, XrefRangeEnd = 281573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CustomerItemsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_CustomerItemsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F23 RID: 40739 RVA: 0x00283030 File Offset: 0x00281230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281575, XrefRangeEnd = 281583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDoneButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_UpdateDoneButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F24 RID: 40740 RVA: 0x00283064 File Offset: 0x00281264
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281598, RefRangeEnd = 281599, XrefRangeStart = 281583, XrefRangeEnd = 281598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSuccessChance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_UpdateSuccessChance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F25 RID: 40741 RVA: 0x00283098 File Offset: 0x00281298
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281620, RefRangeEnd = 281622, XrefRangeStart = 281599, XrefRangeEnd = 281620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetError(out string err)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetError_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			err = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06009F26 RID: 40742 RVA: 0x002830F0 File Offset: 0x002812F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281635, RefRangeEnd = 281637, XrefRangeStart = 281622, XrefRangeEnd = 281635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetWarning(out string warning)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			warning = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06009F27 RID: 40743 RVA: 0x00283148 File Offset: 0x00281348
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281655, RefRangeEnd = 281658, XrefRangeStart = 281637, XrefRangeEnd = 281655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemInstance> GetCustomerItems(bool onlyPackagedProduct = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref onlyPackagedProduct;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetCustomerItems_Private_List_1_ItemInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemInstance>>(intPtr3) : null;
		}

		// Token: 0x06009F28 RID: 40744 RVA: 0x00283194 File Offset: 0x00281394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281680, RefRangeEnd = 281681, XrefRangeStart = 281658, XrefRangeEnd = 281680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCustomerItemsValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetCustomerItemsValue_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009F29 RID: 40745 RVA: 0x002831D0 File Offset: 0x002813D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281692, RefRangeEnd = 281695, XrefRangeStart = 281681, XrefRangeEnd = 281692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCustomerItemsCount(bool onlyPackagedProduct = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref onlyPackagedProduct;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetCustomerItemsCount_Private_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009F2A RID: 40746 RVA: 0x0028321C File Offset: 0x0028141C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281695, XrefRangeEnd = 281709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandoverScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F2B RID: 40747 RVA: 0x0004E095 File Offset: 0x0004C295
		public HandoverScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030F2 RID: 12530
		// (get) Token: 0x06009F2C RID: 40748 RVA: 0x00283258 File Offset: 0x00281458
		// (set) Token: 0x06009F2D RID: 40749 RVA: 0x0004E09E File Offset: 0x0004C29E
		public unsafe static int CUSTOMER_SLOT_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(HandoverScreen.NativeFieldInfoPtr_CUSTOMER_SLOT_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HandoverScreen.NativeFieldInfoPtr_CUSTOMER_SLOT_COUNT, (void*)(&value));
			}
		}

		// Token: 0x170030F3 RID: 12531
		// (get) Token: 0x06009F2E RID: 40750 RVA: 0x00283274 File Offset: 0x00281474
		// (set) Token: 0x06009F2F RID: 40751 RVA: 0x0004E0AC File Offset: 0x0004C2AC
		public unsafe static float VEHICLE_MAX_DIST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(HandoverScreen.NativeFieldInfoPtr_VEHICLE_MAX_DIST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HandoverScreen.NativeFieldInfoPtr_VEHICLE_MAX_DIST, (void*)(&value));
			}
		}

		// Token: 0x170030F4 RID: 12532
		// (get) Token: 0x06009F30 RID: 40752 RVA: 0x00283290 File Offset: 0x00281490
		// (set) Token: 0x06009F31 RID: 40753 RVA: 0x0004E0BA File Offset: 0x0004C2BA
		public unsafe Contract _CurrentContract_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__CurrentContract_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__CurrentContract_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030F5 RID: 12533
		// (get) Token: 0x06009F32 RID: 40754 RVA: 0x002832C0 File Offset: 0x002814C0
		// (set) Token: 0x06009F33 RID: 40755 RVA: 0x0004E0D9 File Offset: 0x0004C2D9
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170030F6 RID: 12534
		// (get) Token: 0x06009F34 RID: 40756 RVA: 0x002832E8 File Offset: 0x002814E8
		// (set) Token: 0x06009F35 RID: 40757 RVA: 0x0004E0F4 File Offset: 0x0004C2F4
		public unsafe bool _TutorialOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170030F7 RID: 12535
		// (get) Token: 0x06009F36 RID: 40758 RVA: 0x00283310 File Offset: 0x00281510
		// (set) Token: 0x06009F37 RID: 40759 RVA: 0x0004E10F File Offset: 0x0004C30F
		public unsafe HandoverScreen.EMode _Mode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__Mode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__Mode_k__BackingField)) = value;
			}
		}

		// Token: 0x170030F8 RID: 12536
		// (get) Token: 0x06009F38 RID: 40760 RVA: 0x00283338 File Offset: 0x00281538
		// (set) Token: 0x06009F39 RID: 40761 RVA: 0x0004E12A File Offset: 0x0004C32A
		public unsafe Gradient SuccessColorMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessColorMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessColorMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030F9 RID: 12537
		// (get) Token: 0x06009F3A RID: 40762 RVA: 0x00283368 File Offset: 0x00281568
		// (set) Token: 0x06009F3B RID: 40763 RVA: 0x0004E149 File Offset: 0x0004C349
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030FA RID: 12538
		// (get) Token: 0x06009F3C RID: 40764 RVA: 0x00283398 File Offset: 0x00281598
		// (set) Token: 0x06009F3D RID: 40765 RVA: 0x0004E168 File Offset: 0x0004C368
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030FB RID: 12539
		// (get) Token: 0x06009F3E RID: 40766 RVA: 0x002833C8 File Offset: 0x002815C8
		// (set) Token: 0x06009F3F RID: 40767 RVA: 0x0004E187 File Offset: 0x0004C387
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030FC RID: 12540
		// (get) Token: 0x06009F40 RID: 40768 RVA: 0x002833F8 File Offset: 0x002815F8
		// (set) Token: 0x06009F41 RID: 40769 RVA: 0x0004E1A6 File Offset: 0x0004C3A6
		public unsafe TextMeshProUGUI DescriptionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DescriptionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DescriptionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030FD RID: 12541
		// (get) Token: 0x06009F42 RID: 40770 RVA: 0x00283428 File Offset: 0x00281628
		// (set) Token: 0x06009F43 RID: 40771 RVA: 0x0004E1C5 File Offset: 0x0004C3C5
		public unsafe TextMeshProUGUI CustomerSubtitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSubtitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSubtitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030FE RID: 12542
		// (get) Token: 0x06009F44 RID: 40772 RVA: 0x00283458 File Offset: 0x00281658
		// (set) Token: 0x06009F45 RID: 40773 RVA: 0x0004E1E4 File Offset: 0x0004C3E4
		public unsafe TextMeshProUGUI FavouriteDrugLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FavouriteDrugLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FavouriteDrugLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030FF RID: 12543
		// (get) Token: 0x06009F46 RID: 40774 RVA: 0x00283488 File Offset: 0x00281688
		// (set) Token: 0x06009F47 RID: 40775 RVA: 0x0004E203 File Offset: 0x0004C403
		public unsafe TextMeshProUGUI FavouritePropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FavouritePropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FavouritePropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003100 RID: 12544
		// (get) Token: 0x06009F48 RID: 40776 RVA: 0x002834B8 File Offset: 0x002816B8
		// (set) Token: 0x06009F49 RID: 40777 RVA: 0x0004E222 File Offset: 0x0004C422
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> PropertiesEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_PropertiesEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_PropertiesEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003101 RID: 12545
		// (get) Token: 0x06009F4A RID: 40778 RVA: 0x002834E8 File Offset: 0x002816E8
		// (set) Token: 0x06009F4B RID: 40779 RVA: 0x0004E241 File Offset: 0x0004C441
		public unsafe Il2CppReferenceArray<RectTransform> ExpectationEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ExpectationEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ExpectationEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003102 RID: 12546
		// (get) Token: 0x06009F4C RID: 40780 RVA: 0x00283518 File Offset: 0x00281718
		// (set) Token: 0x06009F4D RID: 40781 RVA: 0x0004E260 File Offset: 0x0004C460
		public unsafe GameObject NoVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_NoVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_NoVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003103 RID: 12547
		// (get) Token: 0x06009F4E RID: 40782 RVA: 0x00283548 File Offset: 0x00281748
		// (set) Token: 0x06009F4F RID: 40783 RVA: 0x0004E27F File Offset: 0x0004C47F
		public unsafe RectTransform VehicleSlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003104 RID: 12548
		// (get) Token: 0x06009F50 RID: 40784 RVA: 0x00283578 File Offset: 0x00281778
		// (set) Token: 0x06009F51 RID: 40785 RVA: 0x0004E29E File Offset: 0x0004C49E
		public unsafe RectTransform CustomerSlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003105 RID: 12549
		// (get) Token: 0x06009F52 RID: 40786 RVA: 0x002835A8 File Offset: 0x002817A8
		// (set) Token: 0x06009F53 RID: 40787 RVA: 0x0004E2BD File Offset: 0x0004C4BD
		public unsafe TextMeshProUGUI VehicleSubtitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSubtitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSubtitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003106 RID: 12550
		// (get) Token: 0x06009F54 RID: 40788 RVA: 0x002835D8 File Offset: 0x002817D8
		// (set) Token: 0x06009F55 RID: 40789 RVA: 0x0004E2DC File Offset: 0x0004C4DC
		public unsafe TextMeshProUGUI SuccessLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003107 RID: 12551
		// (get) Token: 0x06009F56 RID: 40790 RVA: 0x00283608 File Offset: 0x00281808
		// (set) Token: 0x06009F57 RID: 40791 RVA: 0x0004E2FB File Offset: 0x0004C4FB
		public unsafe TextMeshProUGUI ErrorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ErrorLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ErrorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003108 RID: 12552
		// (get) Token: 0x06009F58 RID: 40792 RVA: 0x00283638 File Offset: 0x00281838
		// (set) Token: 0x06009F59 RID: 40793 RVA: 0x0004E31A File Offset: 0x0004C51A
		public unsafe TextMeshProUGUI WarningLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_WarningLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_WarningLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003109 RID: 12553
		// (get) Token: 0x06009F5A RID: 40794 RVA: 0x00283668 File Offset: 0x00281868
		// (set) Token: 0x06009F5B RID: 40795 RVA: 0x0004E339 File Offset: 0x0004C539
		public unsafe Button DoneButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DoneButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DoneButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700310A RID: 12554
		// (get) Token: 0x06009F5C RID: 40796 RVA: 0x00283698 File Offset: 0x00281898
		// (set) Token: 0x06009F5D RID: 40797 RVA: 0x0004E358 File Offset: 0x0004C558
		public unsafe RectTransform VehicleContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700310B RID: 12555
		// (get) Token: 0x06009F5E RID: 40798 RVA: 0x002836C8 File Offset: 0x002818C8
		// (set) Token: 0x06009F5F RID: 40799 RVA: 0x0004E377 File Offset: 0x0004C577
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700310C RID: 12556
		// (get) Token: 0x06009F60 RID: 40800 RVA: 0x002836F8 File Offset: 0x002818F8
		// (set) Token: 0x06009F61 RID: 40801 RVA: 0x0004E396 File Offset: 0x0004C596
		public unsafe HandoverScreenPriceSelector PriceSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_PriceSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HandoverScreenPriceSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_PriceSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700310D RID: 12557
		// (get) Token: 0x06009F62 RID: 40802 RVA: 0x00283728 File Offset: 0x00281928
		// (set) Token: 0x06009F63 RID: 40803 RVA: 0x0004E3B5 File Offset: 0x0004C5B5
		public unsafe TextMeshProUGUI FairPriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FairPriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FairPriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700310E RID: 12558
		// (get) Token: 0x06009F64 RID: 40804 RVA: 0x00283758 File Offset: 0x00281958
		// (set) Token: 0x06009F65 RID: 40805 RVA: 0x0004E3D4 File Offset: 0x0004C5D4
		public unsafe Animation TutorialAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TutorialAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TutorialAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700310F RID: 12559
		// (get) Token: 0x06009F66 RID: 40806 RVA: 0x00283788 File Offset: 0x00281988
		// (set) Token: 0x06009F67 RID: 40807 RVA: 0x0004E3F3 File Offset: 0x0004C5F3
		public unsafe RectTransform TutorialContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TutorialContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TutorialContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003110 RID: 12560
		// (get) Token: 0x06009F68 RID: 40808 RVA: 0x002837B8 File Offset: 0x002819B8
		// (set) Token: 0x06009F69 RID: 40809 RVA: 0x0004E412 File Offset: 0x0004C612
		public unsafe HandoverScreenDetailPanel DetailPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DetailPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HandoverScreenDetailPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DetailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003111 RID: 12561
		// (get) Token: 0x06009F6A RID: 40810 RVA: 0x002837E8 File Offset: 0x002819E8
		// (set) Token: 0x06009F6B RID: 40811 RVA: 0x0004E431 File Offset: 0x0004C631
		public unsafe Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float> onHandoverComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_onHandoverComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_onHandoverComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003112 RID: 12562
		// (get) Token: 0x06009F6C RID: 40812 RVA: 0x00283818 File Offset: 0x00281A18
		// (set) Token: 0x06009F6D RID: 40813 RVA: 0x0004E450 File Offset: 0x0004C650
		public unsafe Func<List<ItemInstance>, float, float> SuccessChanceMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessChanceMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<List<ItemInstance>, float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessChanceMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003113 RID: 12563
		// (get) Token: 0x06009F6E RID: 40814 RVA: 0x00283848 File Offset: 0x00281A48
		// (set) Token: 0x06009F6F RID: 40815 RVA: 0x0004E46F File Offset: 0x0004C66F
		public unsafe Il2CppReferenceArray<ItemSlotUI> VehicleSlotUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSlotUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSlotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003114 RID: 12564
		// (get) Token: 0x06009F70 RID: 40816 RVA: 0x00283878 File Offset: 0x00281A78
		// (set) Token: 0x06009F71 RID: 40817 RVA: 0x0004E48E File Offset: 0x0004C68E
		public unsafe Il2CppReferenceArray<ItemSlotUI> CustomerSlotUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlotUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003115 RID: 12565
		// (get) Token: 0x06009F72 RID: 40818 RVA: 0x002838A8 File Offset: 0x00281AA8
		// (set) Token: 0x06009F73 RID: 40819 RVA: 0x0004E4AD File Offset: 0x0004C6AD
		public unsafe Il2CppReferenceArray<ItemSlot> CustomerSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003116 RID: 12566
		// (get) Token: 0x06009F74 RID: 40820 RVA: 0x002838D8 File Offset: 0x00281AD8
		// (set) Token: 0x06009F75 RID: 40821 RVA: 0x0004E4CC File Offset: 0x0004C6CC
		public unsafe Dictionary<ItemInstance, HandoverScreen.EItemSource> OriginalItemLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_OriginalItemLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ItemInstance, HandoverScreen.EItemSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_OriginalItemLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003117 RID: 12567
		// (get) Token: 0x06009F76 RID: 40822 RVA: 0x00283908 File Offset: 0x00281B08
		// (set) Token: 0x06009F77 RID: 40823 RVA: 0x0004E4EB File Offset: 0x0004C6EB
		public unsafe bool ignoreCustomerChangedEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ignoreCustomerChangedEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ignoreCustomerChangedEvents)) = value;
			}
		}

		// Token: 0x17003118 RID: 12568
		// (get) Token: 0x06009F78 RID: 40824 RVA: 0x00283930 File Offset: 0x00281B30
		// (set) Token: 0x06009F79 RID: 40825 RVA: 0x0004E506 File Offset: 0x0004C706
		public unsafe Customer _CurrentCustomer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__CurrentCustomer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__CurrentCustomer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006AB6 RID: 27318
		private static readonly IntPtr NativeFieldInfoPtr_CUSTOMER_SLOT_COUNT;

		// Token: 0x04006AB7 RID: 27319
		private static readonly IntPtr NativeFieldInfoPtr_VEHICLE_MAX_DIST;

		// Token: 0x04006AB8 RID: 27320
		private static readonly IntPtr NativeFieldInfoPtr__CurrentContract_k__BackingField;

		// Token: 0x04006AB9 RID: 27321
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006ABA RID: 27322
		private static readonly IntPtr NativeFieldInfoPtr__TutorialOpen_k__BackingField;

		// Token: 0x04006ABB RID: 27323
		private static readonly IntPtr NativeFieldInfoPtr__Mode_k__BackingField;

		// Token: 0x04006ABC RID: 27324
		private static readonly IntPtr NativeFieldInfoPtr_SuccessColorMap;

		// Token: 0x04006ABD RID: 27325
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006ABE RID: 27326
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006ABF RID: 27327
		private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x04006AC0 RID: 27328
		private static readonly IntPtr NativeFieldInfoPtr_DescriptionLabel;

		// Token: 0x04006AC1 RID: 27329
		private static readonly IntPtr NativeFieldInfoPtr_CustomerSubtitle;

		// Token: 0x04006AC2 RID: 27330
		private static readonly IntPtr NativeFieldInfoPtr_FavouriteDrugLabel;

		// Token: 0x04006AC3 RID: 27331
		private static readonly IntPtr NativeFieldInfoPtr_FavouritePropertiesLabel;

		// Token: 0x04006AC4 RID: 27332
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesEntries;

		// Token: 0x04006AC5 RID: 27333
		private static readonly IntPtr NativeFieldInfoPtr_ExpectationEntries;

		// Token: 0x04006AC6 RID: 27334
		private static readonly IntPtr NativeFieldInfoPtr_NoVehicle;

		// Token: 0x04006AC7 RID: 27335
		private static readonly IntPtr NativeFieldInfoPtr_VehicleSlotContainer;

		// Token: 0x04006AC8 RID: 27336
		private static readonly IntPtr NativeFieldInfoPtr_CustomerSlotContainer;

		// Token: 0x04006AC9 RID: 27337
		private static readonly IntPtr NativeFieldInfoPtr_VehicleSubtitle;

		// Token: 0x04006ACA RID: 27338
		private static readonly IntPtr NativeFieldInfoPtr_SuccessLabel;

		// Token: 0x04006ACB RID: 27339
		private static readonly IntPtr NativeFieldInfoPtr_ErrorLabel;

		// Token: 0x04006ACC RID: 27340
		private static readonly IntPtr NativeFieldInfoPtr_WarningLabel;

		// Token: 0x04006ACD RID: 27341
		private static readonly IntPtr NativeFieldInfoPtr_DoneButton;

		// Token: 0x04006ACE RID: 27342
		private static readonly IntPtr NativeFieldInfoPtr_VehicleContainer;

		// Token: 0x04006ACF RID: 27343
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04006AD0 RID: 27344
		private static readonly IntPtr NativeFieldInfoPtr_PriceSelector;

		// Token: 0x04006AD1 RID: 27345
		private static readonly IntPtr NativeFieldInfoPtr_FairPriceLabel;

		// Token: 0x04006AD2 RID: 27346
		private static readonly IntPtr NativeFieldInfoPtr_TutorialAnimation;

		// Token: 0x04006AD3 RID: 27347
		private static readonly IntPtr NativeFieldInfoPtr_TutorialContainer;

		// Token: 0x04006AD4 RID: 27348
		private static readonly IntPtr NativeFieldInfoPtr_DetailPanel;

		// Token: 0x04006AD5 RID: 27349
		private static readonly IntPtr NativeFieldInfoPtr_onHandoverComplete;

		// Token: 0x04006AD6 RID: 27350
		private static readonly IntPtr NativeFieldInfoPtr_SuccessChanceMethod;

		// Token: 0x04006AD7 RID: 27351
		private static readonly IntPtr NativeFieldInfoPtr_VehicleSlotUIs;

		// Token: 0x04006AD8 RID: 27352
		private static readonly IntPtr NativeFieldInfoPtr_CustomerSlotUIs;

		// Token: 0x04006AD9 RID: 27353
		private static readonly IntPtr NativeFieldInfoPtr_CustomerSlots;

		// Token: 0x04006ADA RID: 27354
		private static readonly IntPtr NativeFieldInfoPtr_OriginalItemLocations;

		// Token: 0x04006ADB RID: 27355
		private static readonly IntPtr NativeFieldInfoPtr_ignoreCustomerChangedEvents;

		// Token: 0x04006ADC RID: 27356
		private static readonly IntPtr NativeFieldInfoPtr__CurrentCustomer_k__BackingField;

		// Token: 0x04006ADD RID: 27357
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0;

		// Token: 0x04006ADE RID: 27358
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0;

		// Token: 0x04006ADF RID: 27359
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006AE0 RID: 27360
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006AE1 RID: 27361
		private static readonly IntPtr NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0;

		// Token: 0x04006AE2 RID: 27362
		private static readonly IntPtr NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006AE3 RID: 27363
		private static readonly IntPtr NativeMethodInfoPtr_get_Mode_Public_get_EMode_0;

		// Token: 0x04006AE4 RID: 27364
		private static readonly IntPtr NativeMethodInfoPtr_set_Mode_Protected_set_Void_EMode_0;

		// Token: 0x04006AE5 RID: 27365
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCustomer_Public_get_Customer_0;

		// Token: 0x04006AE6 RID: 27366
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentCustomer_Private_set_Void_Customer_0;

		// Token: 0x04006AE7 RID: 27367
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006AE8 RID: 27368
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006AE9 RID: 27369
		private static readonly IntPtr NativeMethodInfoPtr_OpenTutorial_Private_Void_0;

		// Token: 0x04006AEA RID: 27370
		private static readonly IntPtr NativeMethodInfoPtr_CloseTutorial_Public_Void_0;

		// Token: 0x04006AEB RID: 27371
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Contract_Customer_EMode_Action_3_EHandoverOutcome_List_1_ItemInstance_Single_Func_3_List_1_ItemInstance_Single_Single_0;

		// Token: 0x04006AEC RID: 27372
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_EHandoverOutcome_0;

		// Token: 0x04006AED RID: 27373
		private static readonly IntPtr NativeMethodInfoPtr_DonePressed_Public_Void_0;

		// Token: 0x04006AEE RID: 27374
		private static readonly IntPtr NativeMethodInfoPtr_RecordOriginalLocations_Private_Void_0;

		// Token: 0x04006AEF RID: 27375
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006AF0 RID: 27376
		private static readonly IntPtr NativeMethodInfoPtr_ClearCustomerSlots_Public_Void_Boolean_0;

		// Token: 0x04006AF1 RID: 27377
		private static readonly IntPtr NativeMethodInfoPtr_CustomerItemsChanged_Private_Void_0;

		// Token: 0x04006AF2 RID: 27378
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDoneButton_Private_Void_0;

		// Token: 0x04006AF3 RID: 27379
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSuccessChance_Private_Void_0;

		// Token: 0x04006AF4 RID: 27380
		private static readonly IntPtr NativeMethodInfoPtr_GetError_Private_Boolean_byref_String_0;

		// Token: 0x04006AF5 RID: 27381
		private static readonly IntPtr NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0;

		// Token: 0x04006AF6 RID: 27382
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomerItems_Private_List_1_ItemInstance_Boolean_0;

		// Token: 0x04006AF7 RID: 27383
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomerItemsValue_Private_Single_0;

		// Token: 0x04006AF8 RID: 27384
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomerItemsCount_Private_Int32_Boolean_0;

		// Token: 0x04006AF9 RID: 27385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BA1 RID: 2977
		[OriginalName("Assembly-CSharp.dll", "", "EMode")]
		public enum EMode
		{
			// Token: 0x040093D0 RID: 37840
			Contract,
			// Token: 0x040093D1 RID: 37841
			Sample,
			// Token: 0x040093D2 RID: 37842
			Offer
		}

		// Token: 0x02000BA2 RID: 2978
		[OriginalName("Assembly-CSharp.dll", "", "EHandoverOutcome")]
		public enum EHandoverOutcome
		{
			// Token: 0x040093D4 RID: 37844
			Cancelled,
			// Token: 0x040093D5 RID: 37845
			Finalize
		}

		// Token: 0x02000BA3 RID: 2979
		[OriginalName("Assembly-CSharp.dll", "", "EItemSource")]
		public enum EItemSource
		{
			// Token: 0x040093D7 RID: 37847
			Player,
			// Token: 0x040093D8 RID: 37848
			Vehicle
		}
	}
}
