using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ObjectScripts.Cash;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000648 RID: 1608
	public class LaunderingInterface : MonoBehaviour
	{
		// Token: 0x06008E42 RID: 36418 RVA: 0x00250154 File Offset: 0x0024E354
		// Note: this type is marked as 'beforefieldinit'.
		static LaunderingInterface()
		{
			Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "LaunderingInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr);
			LaunderingInterface.NativeFieldInfoPtr_fovOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "fovOverride");
			LaunderingInterface.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "lerpTime");
			LaunderingInterface.NativeFieldInfoPtr_minLaunderAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "minLaunderAmount");
			LaunderingInterface.NativeFieldInfoPtr__business_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "<business>k__BackingField");
			LaunderingInterface.NativeFieldInfoPtr_cameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "cameraPosition");
			LaunderingInterface.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "intObj");
			LaunderingInterface.NativeFieldInfoPtr_launderButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "launderButton");
			LaunderingInterface.NativeFieldInfoPtr_amountSelectorScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "amountSelectorScreen");
			LaunderingInterface.NativeFieldInfoPtr_amountSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "amountSlider");
			LaunderingInterface.NativeFieldInfoPtr_amountInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "amountInputField");
			LaunderingInterface.NativeFieldInfoPtr_notchContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "notchContainer");
			LaunderingInterface.NativeFieldInfoPtr_currentTotalAmountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "currentTotalAmountLabel");
			LaunderingInterface.NativeFieldInfoPtr_launderCapacityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "launderCapacityLabel");
			LaunderingInterface.NativeFieldInfoPtr_insufficientCashLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "insufficientCashLabel");
			LaunderingInterface.NativeFieldInfoPtr_entryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "entryContainer");
			LaunderingInterface.NativeFieldInfoPtr_noEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "noEntries");
			LaunderingInterface.NativeFieldInfoPtr_CashStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "CashStacks");
			LaunderingInterface.NativeFieldInfoPtr_timelineNotchPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "timelineNotchPrefab");
			LaunderingInterface.NativeFieldInfoPtr_entryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "entryPrefab");
			LaunderingInterface.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "canvas");
			LaunderingInterface.NativeFieldInfoPtr_selectedAmountToLaunder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "selectedAmountToLaunder");
			LaunderingInterface.NativeFieldInfoPtr_operationToNotch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "operationToNotch");
			LaunderingInterface.NativeFieldInfoPtr_notches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "notches");
			LaunderingInterface.NativeFieldInfoPtr_ignoreSliderChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "ignoreSliderChange");
			LaunderingInterface.NativeFieldInfoPtr_operationToEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "operationToEntry");
			LaunderingInterface.NativeMethodInfoPtr_get_maxLaunderAmount_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680958);
			LaunderingInterface.NativeMethodInfoPtr_get_business_Public_get_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680959);
			LaunderingInterface.NativeMethodInfoPtr_set_business_Private_set_Void_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680960);
			LaunderingInterface.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680961);
			LaunderingInterface.NativeMethodInfoPtr_Initialize_Public_Void_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680962);
			LaunderingInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680963);
			LaunderingInterface.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680964);
			LaunderingInterface.NativeMethodInfoPtr_Exit_Protected_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680965);
			LaunderingInterface.NativeMethodInfoPtr_UpdateTimeline_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680966);
			LaunderingInterface.NativeMethodInfoPtr_UpdateCurrentTotal_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680967);
			LaunderingInterface.NativeMethodInfoPtr_CreateEntry_Private_Void_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680968);
			LaunderingInterface.NativeMethodInfoPtr_RemoveEntry_Private_Void_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680969);
			LaunderingInterface.NativeMethodInfoPtr_UpdateEntryTimes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680970);
			LaunderingInterface.NativeMethodInfoPtr_UpdateCashStacks_Private_Void_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680971);
			LaunderingInterface.NativeMethodInfoPtr_RefreshLaunderButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680972);
			LaunderingInterface.NativeMethodInfoPtr_OpenAmountSelector_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680973);
			LaunderingInterface.NativeMethodInfoPtr_CloseAmountSelector_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680974);
			LaunderingInterface.NativeMethodInfoPtr_ConfirmAmount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680975);
			LaunderingInterface.NativeMethodInfoPtr_SliderValueChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680976);
			LaunderingInterface.NativeMethodInfoPtr_InputValueChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680977);
			LaunderingInterface.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680978);
			LaunderingInterface.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680979);
			LaunderingInterface.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680980);
			LaunderingInterface.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680981);
			LaunderingInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680982);
			LaunderingInterface.NativeMethodInfoPtr__Initialize_b__32_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680983);
			LaunderingInterface.NativeMethodInfoPtr__UpdateTimeline_b__36_0_Private_Boolean_KeyValuePair_2_LaunderingOperation_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680984);
		}

		// Token: 0x17002B89 RID: 11145
		// (get) Token: 0x06008E43 RID: 36419 RVA: 0x00250594 File Offset: 0x0024E794
		public unsafe int maxLaunderAmount
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 258913, RefRangeEnd = 258917, XrefRangeStart = 258907, XrefRangeEnd = 258913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_get_maxLaunderAmount_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002B8A RID: 11146
		// (get) Token: 0x06008E44 RID: 36420 RVA: 0x002505D0 File Offset: 0x0024E7D0
		// (set) Token: 0x06008E45 RID: 36421 RVA: 0x00250610 File Offset: 0x0024E810
		public unsafe Business business
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_get_business_Public_get_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Business>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_set_business_Private_set_Void_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002B8B RID: 11147
		// (get) Token: 0x06008E46 RID: 36422 RVA: 0x00250654 File Offset: 0x0024E854
		public unsafe bool isOpen
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 258921, RefRangeEnd = 258926, XrefRangeStart = 258917, XrefRangeEnd = 258921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06008E47 RID: 36423 RVA: 0x00250690 File Offset: 0x0024E890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259072, RefRangeEnd = 259073, XrefRangeStart = 258926, XrefRangeEnd = 259072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Business bus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bus);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_Initialize_Public_Void_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E48 RID: 36424 RVA: 0x002506D4 File Offset: 0x0024E8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259073, XrefRangeEnd = 259148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E49 RID: 36425 RVA: 0x00250708 File Offset: 0x0024E908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259148, XrefRangeEnd = 259154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LaunderingInterface.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E4A RID: 36426 RVA: 0x00250744 File Offset: 0x0024E944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259154, XrefRangeEnd = 259158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_Exit_Protected_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E4B RID: 36427 RVA: 0x00250788 File Offset: 0x0024E988
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 259262, RefRangeEnd = 259265, XrefRangeStart = 259158, XrefRangeEnd = 259262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_UpdateTimeline_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E4C RID: 36428 RVA: 0x002507BC File Offset: 0x0024E9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259265, XrefRangeEnd = 259268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentTotal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_UpdateCurrentTotal_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E4D RID: 36429 RVA: 0x002507F0 File Offset: 0x0024E9F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259303, RefRangeEnd = 259304, XrefRangeStart = 259268, XrefRangeEnd = 259303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEntry(LaunderingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_CreateEntry_Private_Void_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E4E RID: 36430 RVA: 0x00250834 File Offset: 0x0024EA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259304, XrefRangeEnd = 259326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEntry(LaunderingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_RemoveEntry_Private_Void_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E4F RID: 36431 RVA: 0x00250878 File Offset: 0x0024EA78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259388, RefRangeEnd = 259390, XrefRangeStart = 259326, XrefRangeEnd = 259388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEntryTimes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_UpdateEntryTimes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E50 RID: 36432 RVA: 0x002508AC File Offset: 0x0024EAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259390, XrefRangeEnd = 259395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCashStacks(LaunderingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_UpdateCashStacks_Private_Void_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E51 RID: 36433 RVA: 0x002508F0 File Offset: 0x0024EAF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 259422, RefRangeEnd = 259425, XrefRangeStart = 259395, XrefRangeEnd = 259422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshLaunderButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_RefreshLaunderButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E52 RID: 36434 RVA: 0x00250924 File Offset: 0x0024EB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259425, XrefRangeEnd = 259433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenAmountSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_OpenAmountSelector_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E53 RID: 36435 RVA: 0x00250958 File Offset: 0x0024EB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259433, XrefRangeEnd = 259436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseAmountSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_CloseAmountSelector_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E54 RID: 36436 RVA: 0x0025098C File Offset: 0x0024EB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259436, XrefRangeEnd = 259465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmAmount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_ConfirmAmount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E55 RID: 36437 RVA: 0x002509C0 File Offset: 0x0024EBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259465, XrefRangeEnd = 259467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SliderValueChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_SliderValueChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E56 RID: 36438 RVA: 0x002509F4 File Offset: 0x0024EBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259467, XrefRangeEnd = 259473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InputValueChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_InputValueChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E57 RID: 36439 RVA: 0x00250A28 File Offset: 0x0024EC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259473, XrefRangeEnd = 259478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E58 RID: 36440 RVA: 0x00250A5C File Offset: 0x0024EC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259478, XrefRangeEnd = 259479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E59 RID: 36441 RVA: 0x00250A90 File Offset: 0x0024EC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259479, XrefRangeEnd = 259523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LaunderingInterface.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E5A RID: 36442 RVA: 0x00250ACC File Offset: 0x0024ECCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259523, XrefRangeEnd = 259558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LaunderingInterface.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E5B RID: 36443 RVA: 0x00250B08 File Offset: 0x0024ED08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259558, XrefRangeEnd = 259578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LaunderingInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E5C RID: 36444 RVA: 0x00250B44 File Offset: 0x0024ED44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259578, XrefRangeEnd = 259584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__32_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr__Initialize_b__32_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E5D RID: 36445 RVA: 0x00250B78 File Offset: 0x0024ED78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259584, XrefRangeEnd = 259589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _UpdateTimeline_b__36_0(KeyValuePair<LaunderingOperation, RectTransform> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr__UpdateTimeline_b__36_0_Private_Boolean_KeyValuePair_2_LaunderingOperation_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008E5E RID: 36446 RVA: 0x0004466F File Offset: 0x0004286F
		public LaunderingInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B70 RID: 11120
		// (get) Token: 0x06008E5F RID: 36447 RVA: 0x00250BCC File Offset: 0x0024EDCC
		// (set) Token: 0x06008E60 RID: 36448 RVA: 0x00044678 File Offset: 0x00042878
		public unsafe static float fovOverride
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.NativeFieldInfoPtr_fovOverride, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.NativeFieldInfoPtr_fovOverride, (void*)(&value));
			}
		}

		// Token: 0x17002B71 RID: 11121
		// (get) Token: 0x06008E61 RID: 36449 RVA: 0x00250BE8 File Offset: 0x0024EDE8
		// (set) Token: 0x06008E62 RID: 36450 RVA: 0x00044686 File Offset: 0x00042886
		public unsafe static float lerpTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.NativeFieldInfoPtr_lerpTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.NativeFieldInfoPtr_lerpTime, (void*)(&value));
			}
		}

		// Token: 0x17002B72 RID: 11122
		// (get) Token: 0x06008E63 RID: 36451 RVA: 0x00250C04 File Offset: 0x0024EE04
		// (set) Token: 0x06008E64 RID: 36452 RVA: 0x00044694 File Offset: 0x00042894
		public unsafe static int minLaunderAmount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.NativeFieldInfoPtr_minLaunderAmount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.NativeFieldInfoPtr_minLaunderAmount, (void*)(&value));
			}
		}

		// Token: 0x17002B73 RID: 11123
		// (get) Token: 0x06008E65 RID: 36453 RVA: 0x00250C20 File Offset: 0x0024EE20
		// (set) Token: 0x06008E66 RID: 36454 RVA: 0x000446A2 File Offset: 0x000428A2
		public unsafe Business _business_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr__business_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Business>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr__business_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B74 RID: 11124
		// (get) Token: 0x06008E67 RID: 36455 RVA: 0x00250C50 File Offset: 0x0024EE50
		// (set) Token: 0x06008E68 RID: 36456 RVA: 0x000446C1 File Offset: 0x000428C1
		public unsafe Transform cameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_cameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_cameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B75 RID: 11125
		// (get) Token: 0x06008E69 RID: 36457 RVA: 0x00250C80 File Offset: 0x0024EE80
		// (set) Token: 0x06008E6A RID: 36458 RVA: 0x000446E0 File Offset: 0x000428E0
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B76 RID: 11126
		// (get) Token: 0x06008E6B RID: 36459 RVA: 0x00250CB0 File Offset: 0x0024EEB0
		// (set) Token: 0x06008E6C RID: 36460 RVA: 0x000446FF File Offset: 0x000428FF
		public unsafe Button launderButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_launderButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_launderButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B77 RID: 11127
		// (get) Token: 0x06008E6D RID: 36461 RVA: 0x00250CE0 File Offset: 0x0024EEE0
		// (set) Token: 0x06008E6E RID: 36462 RVA: 0x0004471E File Offset: 0x0004291E
		public unsafe GameObject amountSelectorScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountSelectorScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountSelectorScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B78 RID: 11128
		// (get) Token: 0x06008E6F RID: 36463 RVA: 0x00250D10 File Offset: 0x0024EF10
		// (set) Token: 0x06008E70 RID: 36464 RVA: 0x0004473D File Offset: 0x0004293D
		public unsafe Slider amountSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B79 RID: 11129
		// (get) Token: 0x06008E71 RID: 36465 RVA: 0x00250D40 File Offset: 0x0024EF40
		// (set) Token: 0x06008E72 RID: 36466 RVA: 0x0004475C File Offset: 0x0004295C
		public unsafe TMP_InputField amountInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B7A RID: 11130
		// (get) Token: 0x06008E73 RID: 36467 RVA: 0x00250D70 File Offset: 0x0024EF70
		// (set) Token: 0x06008E74 RID: 36468 RVA: 0x0004477B File Offset: 0x0004297B
		public unsafe RectTransform notchContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_notchContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_notchContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B7B RID: 11131
		// (get) Token: 0x06008E75 RID: 36469 RVA: 0x00250DA0 File Offset: 0x0024EFA0
		// (set) Token: 0x06008E76 RID: 36470 RVA: 0x0004479A File Offset: 0x0004299A
		public unsafe TextMeshProUGUI currentTotalAmountLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_currentTotalAmountLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_currentTotalAmountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B7C RID: 11132
		// (get) Token: 0x06008E77 RID: 36471 RVA: 0x00250DD0 File Offset: 0x0024EFD0
		// (set) Token: 0x06008E78 RID: 36472 RVA: 0x000447B9 File Offset: 0x000429B9
		public unsafe TextMeshProUGUI launderCapacityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_launderCapacityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_launderCapacityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B7D RID: 11133
		// (get) Token: 0x06008E79 RID: 36473 RVA: 0x00250E00 File Offset: 0x0024F000
		// (set) Token: 0x06008E7A RID: 36474 RVA: 0x000447D8 File Offset: 0x000429D8
		public unsafe TextMeshProUGUI insufficientCashLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_insufficientCashLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_insufficientCashLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B7E RID: 11134
		// (get) Token: 0x06008E7B RID: 36475 RVA: 0x00250E30 File Offset: 0x0024F030
		// (set) Token: 0x06008E7C RID: 36476 RVA: 0x000447F7 File Offset: 0x000429F7
		public unsafe RectTransform entryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_entryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_entryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B7F RID: 11135
		// (get) Token: 0x06008E7D RID: 36477 RVA: 0x00250E60 File Offset: 0x0024F060
		// (set) Token: 0x06008E7E RID: 36478 RVA: 0x00044816 File Offset: 0x00042A16
		public unsafe RectTransform noEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_noEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_noEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B80 RID: 11136
		// (get) Token: 0x06008E7F RID: 36479 RVA: 0x00250E90 File Offset: 0x0024F090
		// (set) Token: 0x06008E80 RID: 36480 RVA: 0x00044835 File Offset: 0x00042A35
		public unsafe Il2CppReferenceArray<CashStackVisuals> CashStacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_CashStacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CashStackVisuals>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_CashStacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B81 RID: 11137
		// (get) Token: 0x06008E81 RID: 36481 RVA: 0x00250EC0 File Offset: 0x0024F0C0
		// (set) Token: 0x06008E82 RID: 36482 RVA: 0x00044854 File Offset: 0x00042A54
		public unsafe GameObject timelineNotchPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_timelineNotchPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_timelineNotchPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B82 RID: 11138
		// (get) Token: 0x06008E83 RID: 36483 RVA: 0x00250EF0 File Offset: 0x0024F0F0
		// (set) Token: 0x06008E84 RID: 36484 RVA: 0x00044873 File Offset: 0x00042A73
		public unsafe GameObject entryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_entryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_entryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B83 RID: 11139
		// (get) Token: 0x06008E85 RID: 36485 RVA: 0x00250F20 File Offset: 0x0024F120
		// (set) Token: 0x06008E86 RID: 36486 RVA: 0x00044892 File Offset: 0x00042A92
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B84 RID: 11140
		// (get) Token: 0x06008E87 RID: 36487 RVA: 0x00250F50 File Offset: 0x0024F150
		// (set) Token: 0x06008E88 RID: 36488 RVA: 0x000448B1 File Offset: 0x00042AB1
		public unsafe int selectedAmountToLaunder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_selectedAmountToLaunder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_selectedAmountToLaunder)) = value;
			}
		}

		// Token: 0x17002B85 RID: 11141
		// (get) Token: 0x06008E89 RID: 36489 RVA: 0x00250F78 File Offset: 0x0024F178
		// (set) Token: 0x06008E8A RID: 36490 RVA: 0x000448CC File Offset: 0x00042ACC
		public unsafe Dictionary<LaunderingOperation, RectTransform> operationToNotch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_operationToNotch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<LaunderingOperation, RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_operationToNotch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B86 RID: 11142
		// (get) Token: 0x06008E8B RID: 36491 RVA: 0x00250FA8 File Offset: 0x0024F1A8
		// (set) Token: 0x06008E8C RID: 36492 RVA: 0x000448EB File Offset: 0x00042AEB
		public unsafe List<RectTransform> notches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_notches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_notches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B87 RID: 11143
		// (get) Token: 0x06008E8D RID: 36493 RVA: 0x00250FD8 File Offset: 0x0024F1D8
		// (set) Token: 0x06008E8E RID: 36494 RVA: 0x0004490A File Offset: 0x00042B0A
		public unsafe bool ignoreSliderChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_ignoreSliderChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_ignoreSliderChange)) = value;
			}
		}

		// Token: 0x17002B88 RID: 11144
		// (get) Token: 0x06008E8F RID: 36495 RVA: 0x00251000 File Offset: 0x0024F200
		// (set) Token: 0x06008E90 RID: 36496 RVA: 0x00044925 File Offset: 0x00042B25
		public unsafe Dictionary<LaunderingOperation, RectTransform> operationToEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_operationToEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<LaunderingOperation, RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_operationToEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006051 RID: 24657
		private static readonly IntPtr NativeFieldInfoPtr_fovOverride;

		// Token: 0x04006052 RID: 24658
		private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

		// Token: 0x04006053 RID: 24659
		private static readonly IntPtr NativeFieldInfoPtr_minLaunderAmount;

		// Token: 0x04006054 RID: 24660
		private static readonly IntPtr NativeFieldInfoPtr__business_k__BackingField;

		// Token: 0x04006055 RID: 24661
		private static readonly IntPtr NativeFieldInfoPtr_cameraPosition;

		// Token: 0x04006056 RID: 24662
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x04006057 RID: 24663
		private static readonly IntPtr NativeFieldInfoPtr_launderButton;

		// Token: 0x04006058 RID: 24664
		private static readonly IntPtr NativeFieldInfoPtr_amountSelectorScreen;

		// Token: 0x04006059 RID: 24665
		private static readonly IntPtr NativeFieldInfoPtr_amountSlider;

		// Token: 0x0400605A RID: 24666
		private static readonly IntPtr NativeFieldInfoPtr_amountInputField;

		// Token: 0x0400605B RID: 24667
		private static readonly IntPtr NativeFieldInfoPtr_notchContainer;

		// Token: 0x0400605C RID: 24668
		private static readonly IntPtr NativeFieldInfoPtr_currentTotalAmountLabel;

		// Token: 0x0400605D RID: 24669
		private static readonly IntPtr NativeFieldInfoPtr_launderCapacityLabel;

		// Token: 0x0400605E RID: 24670
		private static readonly IntPtr NativeFieldInfoPtr_insufficientCashLabel;

		// Token: 0x0400605F RID: 24671
		private static readonly IntPtr NativeFieldInfoPtr_entryContainer;

		// Token: 0x04006060 RID: 24672
		private static readonly IntPtr NativeFieldInfoPtr_noEntries;

		// Token: 0x04006061 RID: 24673
		private static readonly IntPtr NativeFieldInfoPtr_CashStacks;

		// Token: 0x04006062 RID: 24674
		private static readonly IntPtr NativeFieldInfoPtr_timelineNotchPrefab;

		// Token: 0x04006063 RID: 24675
		private static readonly IntPtr NativeFieldInfoPtr_entryPrefab;

		// Token: 0x04006064 RID: 24676
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04006065 RID: 24677
		private static readonly IntPtr NativeFieldInfoPtr_selectedAmountToLaunder;

		// Token: 0x04006066 RID: 24678
		private static readonly IntPtr NativeFieldInfoPtr_operationToNotch;

		// Token: 0x04006067 RID: 24679
		private static readonly IntPtr NativeFieldInfoPtr_notches;

		// Token: 0x04006068 RID: 24680
		private static readonly IntPtr NativeFieldInfoPtr_ignoreSliderChange;

		// Token: 0x04006069 RID: 24681
		private static readonly IntPtr NativeFieldInfoPtr_operationToEntry;

		// Token: 0x0400606A RID: 24682
		private static readonly IntPtr NativeMethodInfoPtr_get_maxLaunderAmount_Protected_get_Int32_0;

		// Token: 0x0400606B RID: 24683
		private static readonly IntPtr NativeMethodInfoPtr_get_business_Public_get_Business_0;

		// Token: 0x0400606C RID: 24684
		private static readonly IntPtr NativeMethodInfoPtr_set_business_Private_set_Void_Business_0;

		// Token: 0x0400606D RID: 24685
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x0400606E RID: 24686
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Business_0;

		// Token: 0x0400606F RID: 24687
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04006070 RID: 24688
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04006071 RID: 24689
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Void_ExitAction_0;

		// Token: 0x04006072 RID: 24690
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeline_Protected_Void_0;

		// Token: 0x04006073 RID: 24691
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentTotal_Protected_Void_0;

		// Token: 0x04006074 RID: 24692
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntry_Private_Void_LaunderingOperation_0;

		// Token: 0x04006075 RID: 24693
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEntry_Private_Void_LaunderingOperation_0;

		// Token: 0x04006076 RID: 24694
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEntryTimes_Private_Void_0;

		// Token: 0x04006077 RID: 24695
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCashStacks_Private_Void_LaunderingOperation_0;

		// Token: 0x04006078 RID: 24696
		private static readonly IntPtr NativeMethodInfoPtr_RefreshLaunderButton_Private_Void_0;

		// Token: 0x04006079 RID: 24697
		private static readonly IntPtr NativeMethodInfoPtr_OpenAmountSelector_Public_Void_0;

		// Token: 0x0400607A RID: 24698
		private static readonly IntPtr NativeMethodInfoPtr_CloseAmountSelector_Public_Void_0;

		// Token: 0x0400607B RID: 24699
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmAmount_Public_Void_0;

		// Token: 0x0400607C RID: 24700
		private static readonly IntPtr NativeMethodInfoPtr_SliderValueChanged_Public_Void_0;

		// Token: 0x0400607D RID: 24701
		private static readonly IntPtr NativeMethodInfoPtr_InputValueChanged_Public_Void_0;

		// Token: 0x0400607E RID: 24702
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x0400607F RID: 24703
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04006080 RID: 24704
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0;

		// Token: 0x04006081 RID: 24705
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04006082 RID: 24706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006083 RID: 24707
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__32_0_Private_Void_0;

		// Token: 0x04006084 RID: 24708
		private static readonly IntPtr NativeMethodInfoPtr__UpdateTimeline_b__36_0_Private_Boolean_KeyValuePair_2_LaunderingOperation_RectTransform_0;

		// Token: 0x02000B2C RID: 2860
		[ObfuscatedName("ScheduleOne.UI.LaunderingInterface+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D7E6 RID: 55270 RVA: 0x00334F40 File Offset: 0x00333140
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr);
				LaunderingInterface.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr, "<>9");
				LaunderingInterface.__c.NativeFieldInfoPtr___9__36_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr, "<>9__36_1");
				LaunderingInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr, 100680986);
				LaunderingInterface.__c.NativeMethodInfoPtr__UpdateTimeline_b__36_1_Internal_RectTransform_KeyValuePair_2_LaunderingOperation_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr, 100680987);
			}

			// Token: 0x0600D7E7 RID: 55271 RVA: 0x00334FBC File Offset: 0x003331BC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7E8 RID: 55272 RVA: 0x00334FF8 File Offset: 0x003331F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258906, XrefRangeEnd = 258907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RectTransform _UpdateTimeline_b__36_1(KeyValuePair<LaunderingOperation, RectTransform> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.__c.NativeMethodInfoPtr__UpdateTimeline_b__36_1_Internal_RectTransform_KeyValuePair_2_LaunderingOperation_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}

			// Token: 0x0600D7E9 RID: 55273 RVA: 0x0006921F File Offset: 0x0006741F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042EB RID: 17131
			// (get) Token: 0x0600D7EA RID: 55274 RVA: 0x00335050 File Offset: 0x00333250
			// (set) Token: 0x0600D7EB RID: 55275 RVA: 0x00069228 File Offset: 0x00067428
			public unsafe static LaunderingInterface.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LaunderingInterface.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042EC RID: 17132
			// (get) Token: 0x0600D7EC RID: 55276 RVA: 0x00335078 File Offset: 0x00333278
			// (set) Token: 0x0600D7ED RID: 55277 RVA: 0x0006923A File Offset: 0x0006743A
			public unsafe static Func<KeyValuePair<LaunderingOperation, RectTransform>, RectTransform> __9__36_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.__c.NativeFieldInfoPtr___9__36_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<LaunderingOperation, RectTransform>, RectTransform>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.__c.NativeFieldInfoPtr___9__36_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009117 RID: 37143
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009118 RID: 37144
			private static readonly IntPtr NativeFieldInfoPtr___9__36_1;

			// Token: 0x04009119 RID: 37145
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400911A RID: 37146
			private static readonly IntPtr NativeMethodInfoPtr__UpdateTimeline_b__36_1_Internal_RectTransform_KeyValuePair_2_LaunderingOperation_RectTransform_0;
		}
	}
}
