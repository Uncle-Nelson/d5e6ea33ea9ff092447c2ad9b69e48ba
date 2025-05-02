using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Money;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.ATM
{
	// Token: 0x02000703 RID: 1795
	public class ATMInterface : MonoBehaviour
	{
		// Token: 0x0600A0E5 RID: 41189 RVA: 0x00287E34 File Offset: 0x00286034
		// Note: this type is marked as 'beforefieldinit'.
		static ATMInterface()
		{
			Il2CppClassPointerStore<ATMInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.ATM", "ATMInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr);
			ATMInterface.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "canvas");
			ATMInterface.NativeFieldInfoPtr_atm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "atm");
			ATMInterface.NativeFieldInfoPtr_CompleteSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "CompleteSound");
			ATMInterface.NativeFieldInfoPtr_menuScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "menuScreen");
			ATMInterface.NativeFieldInfoPtr_menu_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "menu_TitleText");
			ATMInterface.NativeFieldInfoPtr_menu_DepositButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "menu_DepositButton");
			ATMInterface.NativeFieldInfoPtr_menu_WithdrawButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "menu_WithdrawButton");
			ATMInterface.NativeFieldInfoPtr_depositLimitText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "depositLimitText");
			ATMInterface.NativeFieldInfoPtr_onlineBalanceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "onlineBalanceText");
			ATMInterface.NativeFieldInfoPtr_cleanCashText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "cleanCashText");
			ATMInterface.NativeFieldInfoPtr_depositLimitContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "depositLimitContainer");
			ATMInterface.NativeFieldInfoPtr_amountSelectorScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountSelectorScreen");
			ATMInterface.NativeFieldInfoPtr_amountSelectorTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountSelectorTitle");
			ATMInterface.NativeFieldInfoPtr_amountButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountButtons");
			ATMInterface.NativeFieldInfoPtr_amountLabelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountLabelText");
			ATMInterface.NativeFieldInfoPtr_amountBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountBackground");
			ATMInterface.NativeFieldInfoPtr_selectedButtonIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "selectedButtonIndicator");
			ATMInterface.NativeFieldInfoPtr_confirmAmountButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "confirmAmountButton");
			ATMInterface.NativeFieldInfoPtr_confirmButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "confirmButtonText");
			ATMInterface.NativeFieldInfoPtr_processingScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "processingScreen");
			ATMInterface.NativeFieldInfoPtr_processingScreenIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "processingScreenIndicator");
			ATMInterface.NativeFieldInfoPtr_successScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "successScreen");
			ATMInterface.NativeFieldInfoPtr_successScreenSubtitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "successScreenSubtitle");
			ATMInterface.NativeFieldInfoPtr_doneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "doneButton");
			ATMInterface.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "<isOpen>k__BackingField");
			ATMInterface.NativeFieldInfoPtr_activeScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "activeScreen");
			ATMInterface.NativeFieldInfoPtr_amounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amounts");
			ATMInterface.NativeFieldInfoPtr_depositing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "depositing");
			ATMInterface.NativeFieldInfoPtr_selectedAmountIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "selectedAmountIndex");
			ATMInterface.NativeFieldInfoPtr_selectedAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "selectedAmount");
			ATMInterface.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682975);
			ATMInterface.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682976);
			ATMInterface.NativeMethodInfoPtr_get_relevantBalance_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682977);
			ATMInterface.NativeMethodInfoPtr_get_remainingAllowedDeposit_Private_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682978);
			ATMInterface.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682979);
			ATMInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682980);
			ATMInterface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682981);
			ATMInterface.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682982);
			ATMInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682983);
			ATMInterface.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682984);
			ATMInterface.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682985);
			ATMInterface.NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682986);
			ATMInterface.NativeMethodInfoPtr_SetActiveScreen_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682987);
			ATMInterface.NativeMethodInfoPtr_DefaultAmountSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682988);
			ATMInterface.NativeMethodInfoPtr_DepositButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682989);
			ATMInterface.NativeMethodInfoPtr_WithdrawButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682990);
			ATMInterface.NativeMethodInfoPtr_CancelAmountSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682991);
			ATMInterface.NativeMethodInfoPtr_AmountSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682992);
			ATMInterface.NativeMethodInfoPtr_SetSelectedAmount_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682993);
			ATMInterface.NativeMethodInfoPtr_GetAmountFromIndex_Public_Static_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682994);
			ATMInterface.NativeMethodInfoPtr_UpdateAvailableAmounts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682995);
			ATMInterface.NativeMethodInfoPtr_AmountConfirmed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682996);
			ATMInterface.NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682997);
			ATMInterface.NativeMethodInfoPtr_ProcessTransaction_Protected_IEnumerator_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682998);
			ATMInterface.NativeMethodInfoPtr_DoneButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682999);
			ATMInterface.NativeMethodInfoPtr_ReturnToMenuButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683000);
			ATMInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683001);
		}

		// Token: 0x170031B1 RID: 12721
		// (get) Token: 0x0600A0E6 RID: 41190 RVA: 0x002882D8 File Offset: 0x002864D8
		// (set) Token: 0x0600A0E7 RID: 41191 RVA: 0x00288314 File Offset: 0x00286514
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170031B2 RID: 12722
		// (get) Token: 0x0600A0E8 RID: 41192 RVA: 0x00288354 File Offset: 0x00286554
		public unsafe float relevantBalance
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 283073, RefRangeEnd = 283079, XrefRangeStart = 283066, XrefRangeEnd = 283073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_get_relevantBalance_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170031B3 RID: 12723
		// (get) Token: 0x0600A0E9 RID: 41193 RVA: 0x00288390 File Offset: 0x00286590
		public unsafe static float remainingAllowedDeposit
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 283083, RefRangeEnd = 283086, XrefRangeStart = 283079, XrefRangeEnd = 283083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_get_remainingAllowedDeposit_Private_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600A0EA RID: 41194 RVA: 0x002883C0 File Offset: 0x002865C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283086, XrefRangeEnd = 283121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0EB RID: 41195 RVA: 0x002883F4 File Offset: 0x002865F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283121, XrefRangeEnd = 283141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0EC RID: 41196 RVA: 0x00288428 File Offset: 0x00286628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283141, XrefRangeEnd = 283195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATMInterface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0ED RID: 41197 RVA: 0x00288464 File Offset: 0x00286664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283195, XrefRangeEnd = 283201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0EE RID: 41198 RVA: 0x00288498 File Offset: 0x00286698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283201, XrefRangeEnd = 283285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATMInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0EF RID: 41199 RVA: 0x002884D4 File Offset: 0x002866D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283285, XrefRangeEnd = 283299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATMInterface.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F0 RID: 41200 RVA: 0x00288510 File Offset: 0x00286710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283299, XrefRangeEnd = 283318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsOpen(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATMInterface.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F1 RID: 41201 RVA: 0x0028855C File Offset: 0x0028675C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283318, XrefRangeEnd = 283330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATMInterface.NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F2 RID: 41202 RVA: 0x002885AC File Offset: 0x002867AC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 283353, RefRangeEnd = 283359, XrefRangeStart = 283330, XrefRangeEnd = 283353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveScreen(RectTransform screen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(screen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_SetActiveScreen_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F3 RID: 41203 RVA: 0x002885F0 File Offset: 0x002867F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283369, RefRangeEnd = 283370, XrefRangeStart = 283359, XrefRangeEnd = 283369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DefaultAmountSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_DefaultAmountSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F4 RID: 41204 RVA: 0x00288624 File Offset: 0x00286824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283370, XrefRangeEnd = 283374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DepositButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_DepositButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F5 RID: 41205 RVA: 0x00288658 File Offset: 0x00286858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283374, XrefRangeEnd = 283405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WithdrawButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_WithdrawButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F6 RID: 41206 RVA: 0x0028868C File Offset: 0x0028688C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283405, XrefRangeEnd = 283406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelAmountSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_CancelAmountSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F7 RID: 41207 RVA: 0x002886C0 File Offset: 0x002868C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283411, RefRangeEnd = 283413, XrefRangeStart = 283406, XrefRangeEnd = 283411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AmountSelected(int amountIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amountIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_AmountSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F8 RID: 41208 RVA: 0x00288700 File Offset: 0x00286900
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283431, RefRangeEnd = 283433, XrefRangeStart = 283413, XrefRangeEnd = 283431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_SetSelectedAmount_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F9 RID: 41209 RVA: 0x00288740 File Offset: 0x00286940
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283446, RefRangeEnd = 283448, XrefRangeStart = 283433, XrefRangeEnd = 283446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAmountFromIndex(int index, bool depositing)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depositing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_GetAmountFromIndex_Public_Static_Single_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A0FA RID: 41210 RVA: 0x0028878C File Offset: 0x0028698C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283487, RefRangeEnd = 283488, XrefRangeStart = 283448, XrefRangeEnd = 283487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAvailableAmounts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_UpdateAvailableAmounts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0FB RID: 41211 RVA: 0x002887C0 File Offset: 0x002869C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283488, XrefRangeEnd = 283494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AmountConfirmed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_AmountConfirmed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0FC RID: 41212 RVA: 0x002887F4 File Offset: 0x002869F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283494, XrefRangeEnd = 283495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0FD RID: 41213 RVA: 0x00288834 File Offset: 0x00286A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283495, XrefRangeEnd = 283500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ProcessTransaction(float amount, bool depositing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depositing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_ProcessTransaction_Protected_IEnumerator_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A0FE RID: 41214 RVA: 0x00288890 File Offset: 0x00286A90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 249035, RefRangeEnd = 249038, XrefRangeStart = 249035, XrefRangeEnd = 249038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoneButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_DoneButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0FF RID: 41215 RVA: 0x002888C4 File Offset: 0x00286AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnToMenuButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_ReturnToMenuButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A100 RID: 41216 RVA: 0x002888F8 File Offset: 0x00286AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283500, XrefRangeEnd = 283508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ATMInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A101 RID: 41217 RVA: 0x0004F24B File Offset: 0x0004D44B
		public ATMInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003193 RID: 12691
		// (get) Token: 0x0600A102 RID: 41218 RVA: 0x00288934 File Offset: 0x00286B34
		// (set) Token: 0x0600A103 RID: 41219 RVA: 0x0004F254 File Offset: 0x0004D454
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003194 RID: 12692
		// (get) Token: 0x0600A104 RID: 41220 RVA: 0x00288964 File Offset: 0x00286B64
		// (set) Token: 0x0600A105 RID: 41221 RVA: 0x0004F273 File Offset: 0x0004D473
		public unsafe ATM atm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_atm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ATM>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_atm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003195 RID: 12693
		// (get) Token: 0x0600A106 RID: 41222 RVA: 0x00288994 File Offset: 0x00286B94
		// (set) Token: 0x0600A107 RID: 41223 RVA: 0x0004F292 File Offset: 0x0004D492
		public unsafe AudioSourceController CompleteSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_CompleteSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_CompleteSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003196 RID: 12694
		// (get) Token: 0x0600A108 RID: 41224 RVA: 0x002889C4 File Offset: 0x00286BC4
		// (set) Token: 0x0600A109 RID: 41225 RVA: 0x0004F2B1 File Offset: 0x0004D4B1
		public unsafe RectTransform menuScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menuScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menuScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003197 RID: 12695
		// (get) Token: 0x0600A10A RID: 41226 RVA: 0x002889F4 File Offset: 0x00286BF4
		// (set) Token: 0x0600A10B RID: 41227 RVA: 0x0004F2D0 File Offset: 0x0004D4D0
		public unsafe Text menu_TitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_TitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_TitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003198 RID: 12696
		// (get) Token: 0x0600A10C RID: 41228 RVA: 0x00288A24 File Offset: 0x00286C24
		// (set) Token: 0x0600A10D RID: 41229 RVA: 0x0004F2EF File Offset: 0x0004D4EF
		public unsafe Button menu_DepositButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_DepositButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_DepositButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003199 RID: 12697
		// (get) Token: 0x0600A10E RID: 41230 RVA: 0x00288A54 File Offset: 0x00286C54
		// (set) Token: 0x0600A10F RID: 41231 RVA: 0x0004F30E File Offset: 0x0004D50E
		public unsafe Button menu_WithdrawButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_WithdrawButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_WithdrawButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700319A RID: 12698
		// (get) Token: 0x0600A110 RID: 41232 RVA: 0x00288A84 File Offset: 0x00286C84
		// (set) Token: 0x0600A111 RID: 41233 RVA: 0x0004F32D File Offset: 0x0004D52D
		public unsafe Text depositLimitText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositLimitText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositLimitText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700319B RID: 12699
		// (get) Token: 0x0600A112 RID: 41234 RVA: 0x00288AB4 File Offset: 0x00286CB4
		// (set) Token: 0x0600A113 RID: 41235 RVA: 0x0004F34C File Offset: 0x0004D54C
		public unsafe Text onlineBalanceText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_onlineBalanceText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_onlineBalanceText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700319C RID: 12700
		// (get) Token: 0x0600A114 RID: 41236 RVA: 0x00288AE4 File Offset: 0x00286CE4
		// (set) Token: 0x0600A115 RID: 41237 RVA: 0x0004F36B File Offset: 0x0004D56B
		public unsafe Text cleanCashText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_cleanCashText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_cleanCashText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700319D RID: 12701
		// (get) Token: 0x0600A116 RID: 41238 RVA: 0x00288B14 File Offset: 0x00286D14
		// (set) Token: 0x0600A117 RID: 41239 RVA: 0x0004F38A File Offset: 0x0004D58A
		public unsafe RectTransform depositLimitContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositLimitContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositLimitContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700319E RID: 12702
		// (get) Token: 0x0600A118 RID: 41240 RVA: 0x00288B44 File Offset: 0x00286D44
		// (set) Token: 0x0600A119 RID: 41241 RVA: 0x0004F3A9 File Offset: 0x0004D5A9
		public unsafe RectTransform amountSelectorScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountSelectorScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountSelectorScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700319F RID: 12703
		// (get) Token: 0x0600A11A RID: 41242 RVA: 0x00288B74 File Offset: 0x00286D74
		// (set) Token: 0x0600A11B RID: 41243 RVA: 0x0004F3C8 File Offset: 0x0004D5C8
		public unsafe Text amountSelectorTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountSelectorTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountSelectorTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A0 RID: 12704
		// (get) Token: 0x0600A11C RID: 41244 RVA: 0x00288BA4 File Offset: 0x00286DA4
		// (set) Token: 0x0600A11D RID: 41245 RVA: 0x0004F3E7 File Offset: 0x0004D5E7
		public unsafe List<Button> amountButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A1 RID: 12705
		// (get) Token: 0x0600A11E RID: 41246 RVA: 0x00288BD4 File Offset: 0x00286DD4
		// (set) Token: 0x0600A11F RID: 41247 RVA: 0x0004F406 File Offset: 0x0004D606
		public unsafe Text amountLabelText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountLabelText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountLabelText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A2 RID: 12706
		// (get) Token: 0x0600A120 RID: 41248 RVA: 0x00288C04 File Offset: 0x00286E04
		// (set) Token: 0x0600A121 RID: 41249 RVA: 0x0004F425 File Offset: 0x0004D625
		public unsafe RectTransform amountBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountBackground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A3 RID: 12707
		// (get) Token: 0x0600A122 RID: 41250 RVA: 0x00288C34 File Offset: 0x00286E34
		// (set) Token: 0x0600A123 RID: 41251 RVA: 0x0004F444 File Offset: 0x0004D644
		public unsafe RectTransform selectedButtonIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedButtonIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedButtonIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A4 RID: 12708
		// (get) Token: 0x0600A124 RID: 41252 RVA: 0x00288C64 File Offset: 0x00286E64
		// (set) Token: 0x0600A125 RID: 41253 RVA: 0x0004F463 File Offset: 0x0004D663
		public unsafe Button confirmAmountButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_confirmAmountButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_confirmAmountButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A5 RID: 12709
		// (get) Token: 0x0600A126 RID: 41254 RVA: 0x00288C94 File Offset: 0x00286E94
		// (set) Token: 0x0600A127 RID: 41255 RVA: 0x0004F482 File Offset: 0x0004D682
		public unsafe Text confirmButtonText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_confirmButtonText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_confirmButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A6 RID: 12710
		// (get) Token: 0x0600A128 RID: 41256 RVA: 0x00288CC4 File Offset: 0x00286EC4
		// (set) Token: 0x0600A129 RID: 41257 RVA: 0x0004F4A1 File Offset: 0x0004D6A1
		public unsafe RectTransform processingScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_processingScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_processingScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A7 RID: 12711
		// (get) Token: 0x0600A12A RID: 41258 RVA: 0x00288CF4 File Offset: 0x00286EF4
		// (set) Token: 0x0600A12B RID: 41259 RVA: 0x0004F4C0 File Offset: 0x0004D6C0
		public unsafe RectTransform processingScreenIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_processingScreenIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_processingScreenIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A8 RID: 12712
		// (get) Token: 0x0600A12C RID: 41260 RVA: 0x00288D24 File Offset: 0x00286F24
		// (set) Token: 0x0600A12D RID: 41261 RVA: 0x0004F4DF File Offset: 0x0004D6DF
		public unsafe RectTransform successScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_successScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_successScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A9 RID: 12713
		// (get) Token: 0x0600A12E RID: 41262 RVA: 0x00288D54 File Offset: 0x00286F54
		// (set) Token: 0x0600A12F RID: 41263 RVA: 0x0004F4FE File Offset: 0x0004D6FE
		public unsafe Text successScreenSubtitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_successScreenSubtitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_successScreenSubtitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031AA RID: 12714
		// (get) Token: 0x0600A130 RID: 41264 RVA: 0x00288D84 File Offset: 0x00286F84
		// (set) Token: 0x0600A131 RID: 41265 RVA: 0x0004F51D File Offset: 0x0004D71D
		public unsafe Button doneButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_doneButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_doneButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031AB RID: 12715
		// (get) Token: 0x0600A132 RID: 41266 RVA: 0x00288DB4 File Offset: 0x00286FB4
		// (set) Token: 0x0600A133 RID: 41267 RVA: 0x0004F53C File Offset: 0x0004D73C
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170031AC RID: 12716
		// (get) Token: 0x0600A134 RID: 41268 RVA: 0x00288DDC File Offset: 0x00286FDC
		// (set) Token: 0x0600A135 RID: 41269 RVA: 0x0004F557 File Offset: 0x0004D757
		public unsafe RectTransform activeScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_activeScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_activeScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031AD RID: 12717
		// (get) Token: 0x0600A136 RID: 41270 RVA: 0x00288E0C File Offset: 0x0028700C
		// (set) Token: 0x0600A137 RID: 41271 RVA: 0x0004F576 File Offset: 0x0004D776
		public unsafe static Il2CppStructArray<int> amounts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ATMInterface.NativeFieldInfoPtr_amounts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATMInterface.NativeFieldInfoPtr_amounts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031AE RID: 12718
		// (get) Token: 0x0600A138 RID: 41272 RVA: 0x00288E34 File Offset: 0x00287034
		// (set) Token: 0x0600A139 RID: 41273 RVA: 0x0004F588 File Offset: 0x0004D788
		public unsafe bool depositing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositing)) = value;
			}
		}

		// Token: 0x170031AF RID: 12719
		// (get) Token: 0x0600A13A RID: 41274 RVA: 0x00288E5C File Offset: 0x0028705C
		// (set) Token: 0x0600A13B RID: 41275 RVA: 0x0004F5A3 File Offset: 0x0004D7A3
		public unsafe int selectedAmountIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedAmountIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedAmountIndex)) = value;
			}
		}

		// Token: 0x170031B0 RID: 12720
		// (get) Token: 0x0600A13C RID: 41276 RVA: 0x00288E84 File Offset: 0x00287084
		// (set) Token: 0x0600A13D RID: 41277 RVA: 0x0004F5BE File Offset: 0x0004D7BE
		public unsafe float selectedAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedAmount)) = value;
			}
		}

		// Token: 0x04006BD9 RID: 27609
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04006BDA RID: 27610
		private static readonly IntPtr NativeFieldInfoPtr_atm;

		// Token: 0x04006BDB RID: 27611
		private static readonly IntPtr NativeFieldInfoPtr_CompleteSound;

		// Token: 0x04006BDC RID: 27612
		private static readonly IntPtr NativeFieldInfoPtr_menuScreen;

		// Token: 0x04006BDD RID: 27613
		private static readonly IntPtr NativeFieldInfoPtr_menu_TitleText;

		// Token: 0x04006BDE RID: 27614
		private static readonly IntPtr NativeFieldInfoPtr_menu_DepositButton;

		// Token: 0x04006BDF RID: 27615
		private static readonly IntPtr NativeFieldInfoPtr_menu_WithdrawButton;

		// Token: 0x04006BE0 RID: 27616
		private static readonly IntPtr NativeFieldInfoPtr_depositLimitText;

		// Token: 0x04006BE1 RID: 27617
		private static readonly IntPtr NativeFieldInfoPtr_onlineBalanceText;

		// Token: 0x04006BE2 RID: 27618
		private static readonly IntPtr NativeFieldInfoPtr_cleanCashText;

		// Token: 0x04006BE3 RID: 27619
		private static readonly IntPtr NativeFieldInfoPtr_depositLimitContainer;

		// Token: 0x04006BE4 RID: 27620
		private static readonly IntPtr NativeFieldInfoPtr_amountSelectorScreen;

		// Token: 0x04006BE5 RID: 27621
		private static readonly IntPtr NativeFieldInfoPtr_amountSelectorTitle;

		// Token: 0x04006BE6 RID: 27622
		private static readonly IntPtr NativeFieldInfoPtr_amountButtons;

		// Token: 0x04006BE7 RID: 27623
		private static readonly IntPtr NativeFieldInfoPtr_amountLabelText;

		// Token: 0x04006BE8 RID: 27624
		private static readonly IntPtr NativeFieldInfoPtr_amountBackground;

		// Token: 0x04006BE9 RID: 27625
		private static readonly IntPtr NativeFieldInfoPtr_selectedButtonIndicator;

		// Token: 0x04006BEA RID: 27626
		private static readonly IntPtr NativeFieldInfoPtr_confirmAmountButton;

		// Token: 0x04006BEB RID: 27627
		private static readonly IntPtr NativeFieldInfoPtr_confirmButtonText;

		// Token: 0x04006BEC RID: 27628
		private static readonly IntPtr NativeFieldInfoPtr_processingScreen;

		// Token: 0x04006BED RID: 27629
		private static readonly IntPtr NativeFieldInfoPtr_processingScreenIndicator;

		// Token: 0x04006BEE RID: 27630
		private static readonly IntPtr NativeFieldInfoPtr_successScreen;

		// Token: 0x04006BEF RID: 27631
		private static readonly IntPtr NativeFieldInfoPtr_successScreenSubtitle;

		// Token: 0x04006BF0 RID: 27632
		private static readonly IntPtr NativeFieldInfoPtr_doneButton;

		// Token: 0x04006BF1 RID: 27633
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04006BF2 RID: 27634
		private static readonly IntPtr NativeFieldInfoPtr_activeScreen;

		// Token: 0x04006BF3 RID: 27635
		private static readonly IntPtr NativeFieldInfoPtr_amounts;

		// Token: 0x04006BF4 RID: 27636
		private static readonly IntPtr NativeFieldInfoPtr_depositing;

		// Token: 0x04006BF5 RID: 27637
		private static readonly IntPtr NativeFieldInfoPtr_selectedAmountIndex;

		// Token: 0x04006BF6 RID: 27638
		private static readonly IntPtr NativeFieldInfoPtr_selectedAmount;

		// Token: 0x04006BF7 RID: 27639
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006BF8 RID: 27640
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006BF9 RID: 27641
		private static readonly IntPtr NativeMethodInfoPtr_get_relevantBalance_Private_get_Single_0;

		// Token: 0x04006BFA RID: 27642
		private static readonly IntPtr NativeMethodInfoPtr_get_remainingAllowedDeposit_Private_Static_get_Single_0;

		// Token: 0x04006BFB RID: 27643
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006BFC RID: 27644
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04006BFD RID: 27645
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006BFE RID: 27646
		private static readonly IntPtr NativeMethodInfoPtr_PlayerSpawned_Private_Void_0;

		// Token: 0x04006BFF RID: 27647
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006C00 RID: 27648
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04006C01 RID: 27649
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04006C02 RID: 27650
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0;

		// Token: 0x04006C03 RID: 27651
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveScreen_Public_Void_RectTransform_0;

		// Token: 0x04006C04 RID: 27652
		private static readonly IntPtr NativeMethodInfoPtr_DefaultAmountSelection_Private_Void_0;

		// Token: 0x04006C05 RID: 27653
		private static readonly IntPtr NativeMethodInfoPtr_DepositButtonPressed_Public_Void_0;

		// Token: 0x04006C06 RID: 27654
		private static readonly IntPtr NativeMethodInfoPtr_WithdrawButtonPressed_Public_Void_0;

		// Token: 0x04006C07 RID: 27655
		private static readonly IntPtr NativeMethodInfoPtr_CancelAmountSelection_Public_Void_0;

		// Token: 0x04006C08 RID: 27656
		private static readonly IntPtr NativeMethodInfoPtr_AmountSelected_Public_Void_Int32_0;

		// Token: 0x04006C09 RID: 27657
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedAmount_Private_Void_Single_0;

		// Token: 0x04006C0A RID: 27658
		private static readonly IntPtr NativeMethodInfoPtr_GetAmountFromIndex_Public_Static_Single_Int32_Boolean_0;

		// Token: 0x04006C0B RID: 27659
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAvailableAmounts_Private_Void_0;

		// Token: 0x04006C0C RID: 27660
		private static readonly IntPtr NativeMethodInfoPtr_AmountConfirmed_Public_Void_0;

		// Token: 0x04006C0D RID: 27661
		private static readonly IntPtr NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0;

		// Token: 0x04006C0E RID: 27662
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTransaction_Protected_IEnumerator_Single_Boolean_0;

		// Token: 0x04006C0F RID: 27663
		private static readonly IntPtr NativeMethodInfoPtr_DoneButtonPressed_Public_Void_0;

		// Token: 0x04006C10 RID: 27664
		private static readonly IntPtr NativeMethodInfoPtr_ReturnToMenuButtonPressed_Public_Void_0;

		// Token: 0x04006C11 RID: 27665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BB0 RID: 2992
		[ObfuscatedName("ScheduleOne.UI.ATM.ATMInterface+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD14 RID: 56596 RVA: 0x00343C64 File Offset: 0x00341E64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr);
				ATMInterface.__c__DisplayClass39_0.NativeFieldInfoPtr_fuckYou = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr, "fuckYou");
				ATMInterface.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
				ATMInterface.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr, 100683003);
				ATMInterface.__c__DisplayClass39_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr, 100683004);
			}

			// Token: 0x0600DD15 RID: 56597 RVA: 0x00343CE0 File Offset: 0x00341EE0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD16 RID: 56598 RVA: 0x00343D1C File Offset: 0x00341F1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283046, XrefRangeEnd = 283048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.__c__DisplayClass39_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD17 RID: 56599 RVA: 0x0006BBE0 File Offset: 0x00069DE0
			public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004484 RID: 17540
			// (get) Token: 0x0600DD18 RID: 56600 RVA: 0x00343D50 File Offset: 0x00341F50
			// (set) Token: 0x0600DD19 RID: 56601 RVA: 0x0006BBE9 File Offset: 0x00069DE9
			public unsafe int fuckYou
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.__c__DisplayClass39_0.NativeFieldInfoPtr_fuckYou);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.__c__DisplayClass39_0.NativeFieldInfoPtr_fuckYou)) = value;
				}
			}

			// Token: 0x17004485 RID: 17541
			// (get) Token: 0x0600DD1A RID: 56602 RVA: 0x00343D78 File Offset: 0x00341F78
			// (set) Token: 0x0600DD1B RID: 56603 RVA: 0x0006BC04 File Offset: 0x00069E04
			public unsafe ATMInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ATMInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009420 RID: 37920
			private static readonly IntPtr NativeFieldInfoPtr_fuckYou;

			// Token: 0x04009421 RID: 37921
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009422 RID: 37922
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009423 RID: 37923
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}

		// Token: 0x02000BB1 RID: 2993
		[ObfuscatedName("ScheduleOne.UI.ATM.ATMInterface+<ProcessTransaction>d__56")]
		public sealed class _ProcessTransaction_d__56 : Il2CppSystem.Object
		{
			// Token: 0x0600DD1C RID: 56604 RVA: 0x00343DA8 File Offset: 0x00341FA8
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessTransaction_d__56()
			{
				Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "<ProcessTransaction>d__56");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr);
				ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, "<>1__state");
				ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, "<>2__current");
				ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, "<>4__this");
				ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr_depositing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, "depositing");
				ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, "amount");
				ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, 100683005);
				ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, 100683006);
				ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, 100683007);
				ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, 100683008);
				ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, 100683009);
				ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, 100683010);
			}

			// Token: 0x0600DD1D RID: 56605 RVA: 0x00343EB0 File Offset: 0x003420B0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ProcessTransaction_d__56(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD1E RID: 56606 RVA: 0x00343EF8 File Offset: 0x003420F8
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD1F RID: 56607 RVA: 0x00343F2C File Offset: 0x0034212C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283048, XrefRangeEnd = 283061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700448B RID: 17547
			// (get) Token: 0x0600DD20 RID: 56608 RVA: 0x00343F68 File Offset: 0x00342168
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD21 RID: 56609 RVA: 0x00343FA8 File Offset: 0x003421A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283061, XrefRangeEnd = 283066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700448C RID: 17548
			// (get) Token: 0x0600DD22 RID: 56610 RVA: 0x00343FDC File Offset: 0x003421DC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD23 RID: 56611 RVA: 0x0006BC23 File Offset: 0x00069E23
			public _ProcessTransaction_d__56(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004486 RID: 17542
			// (get) Token: 0x0600DD24 RID: 56612 RVA: 0x0034401C File Offset: 0x0034221C
			// (set) Token: 0x0600DD25 RID: 56613 RVA: 0x0006BC2C File Offset: 0x00069E2C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004487 RID: 17543
			// (get) Token: 0x0600DD26 RID: 56614 RVA: 0x00344044 File Offset: 0x00342244
			// (set) Token: 0x0600DD27 RID: 56615 RVA: 0x0006BC47 File Offset: 0x00069E47
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004488 RID: 17544
			// (get) Token: 0x0600DD28 RID: 56616 RVA: 0x00344074 File Offset: 0x00342274
			// (set) Token: 0x0600DD29 RID: 56617 RVA: 0x0006BC66 File Offset: 0x00069E66
			public unsafe ATMInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ATMInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004489 RID: 17545
			// (get) Token: 0x0600DD2A RID: 56618 RVA: 0x003440A4 File Offset: 0x003422A4
			// (set) Token: 0x0600DD2B RID: 56619 RVA: 0x0006BC85 File Offset: 0x00069E85
			public unsafe bool depositing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr_depositing);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr_depositing)) = value;
				}
			}

			// Token: 0x1700448A RID: 17546
			// (get) Token: 0x0600DD2C RID: 56620 RVA: 0x003440CC File Offset: 0x003422CC
			// (set) Token: 0x0600DD2D RID: 56621 RVA: 0x0006BCA0 File Offset: 0x00069EA0
			public unsafe float amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x04009424 RID: 37924
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009425 RID: 37925
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009426 RID: 37926
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009427 RID: 37927
			private static readonly IntPtr NativeFieldInfoPtr_depositing;

			// Token: 0x04009428 RID: 37928
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x04009429 RID: 37929
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400942A RID: 37930
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400942B RID: 37931
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400942C RID: 37932
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400942D RID: 37933
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400942E RID: 37934
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
