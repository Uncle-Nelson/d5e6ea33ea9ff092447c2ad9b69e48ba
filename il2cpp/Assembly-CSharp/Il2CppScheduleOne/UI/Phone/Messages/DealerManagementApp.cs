using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006AE RID: 1710
	public class DealerManagementApp : App<DealerManagementApp>
	{
		// Token: 0x06009992 RID: 39314 RVA: 0x00271DFC File Offset: 0x0026FFFC
		// Note: this type is marked as 'beforefieldinit'.
		static DealerManagementApp()
		{
			Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "DealerManagementApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr);
			DealerManagementApp.NativeFieldInfoPtr__SelectedDealer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "<SelectedDealer>k__BackingField");
			DealerManagementApp.NativeFieldInfoPtr_NoDealersLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "NoDealersLabel");
			DealerManagementApp.NativeFieldInfoPtr_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "Content");
			DealerManagementApp.NativeFieldInfoPtr_CustomerSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CustomerSelector");
			DealerManagementApp.NativeFieldInfoPtr_SelectorImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "SelectorImage");
			DealerManagementApp.NativeFieldInfoPtr_SelectorTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "SelectorTitle");
			DealerManagementApp.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "BackButton");
			DealerManagementApp.NativeFieldInfoPtr_NextButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "NextButton");
			DealerManagementApp.NativeFieldInfoPtr_CashLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CashLabel");
			DealerManagementApp.NativeFieldInfoPtr_CutLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CutLabel");
			DealerManagementApp.NativeFieldInfoPtr_HomeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "HomeLabel");
			DealerManagementApp.NativeFieldInfoPtr_InventoryEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "InventoryEntries");
			DealerManagementApp.NativeFieldInfoPtr_CustomerTitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CustomerTitleLabel");
			DealerManagementApp.NativeFieldInfoPtr_CustomerEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CustomerEntries");
			DealerManagementApp.NativeFieldInfoPtr_AssignCustomerButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "AssignCustomerButton");
			DealerManagementApp.NativeFieldInfoPtr_dealers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "dealers");
			DealerManagementApp.NativeMethodInfoPtr_get_SelectedDealer_Public_get_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682235);
			DealerManagementApp.NativeMethodInfoPtr_set_SelectedDealer_Private_set_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682236);
			DealerManagementApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682237);
			DealerManagementApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682238);
			DealerManagementApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682239);
			DealerManagementApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682240);
			DealerManagementApp.NativeMethodInfoPtr_SetDisplayedDealer_Public_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682241);
			DealerManagementApp.NativeMethodInfoPtr_AddDealer_Private_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682242);
			DealerManagementApp.NativeMethodInfoPtr_AddCustomer_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682243);
			DealerManagementApp.NativeMethodInfoPtr_RemoveCustomer_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682244);
			DealerManagementApp.NativeMethodInfoPtr_BackPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682245);
			DealerManagementApp.NativeMethodInfoPtr_NextPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682246);
			DealerManagementApp.NativeMethodInfoPtr_AssignCustomer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682247);
			DealerManagementApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682248);
		}

		// Token: 0x17002F41 RID: 12097
		// (get) Token: 0x06009993 RID: 39315 RVA: 0x00272084 File Offset: 0x00270284
		// (set) Token: 0x06009994 RID: 39316 RVA: 0x002720C4 File Offset: 0x002702C4
		public unsafe Dealer SelectedDealer
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 22951, RefRangeEnd = 22968, XrefRangeStart = 22951, XrefRangeEnd = 22968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_get_SelectedDealer_Public_get_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_set_SelectedDealer_Private_set_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009995 RID: 39317 RVA: 0x00272108 File Offset: 0x00270308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273972, XrefRangeEnd = 274032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerManagementApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009996 RID: 39318 RVA: 0x00272144 File Offset: 0x00270344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274032, XrefRangeEnd = 274045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerManagementApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009997 RID: 39319 RVA: 0x00272180 File Offset: 0x00270380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274045, XrefRangeEnd = 274070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerManagementApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009998 RID: 39320 RVA: 0x002721BC File Offset: 0x002703BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274070, XrefRangeEnd = 274089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerManagementApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009999 RID: 39321 RVA: 0x00272208 File Offset: 0x00270408
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 274250, RefRangeEnd = 274256, XrefRangeStart = 274089, XrefRangeEnd = 274250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedDealer(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_SetDisplayedDealer_Public_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600999A RID: 39322 RVA: 0x0027224C File Offset: 0x0027044C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274286, RefRangeEnd = 274287, XrefRangeStart = 274256, XrefRangeEnd = 274286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDealer(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_AddDealer_Private_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600999B RID: 39323 RVA: 0x00272290 File Offset: 0x00270490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274287, XrefRangeEnd = 274296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_AddCustomer_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600999C RID: 39324 RVA: 0x002722D4 File Offset: 0x002704D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274296, XrefRangeEnd = 274299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_RemoveCustomer_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600999D RID: 39325 RVA: 0x00272318 File Offset: 0x00270518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274299, XrefRangeEnd = 274306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BackPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_BackPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600999E RID: 39326 RVA: 0x0027234C File Offset: 0x0027054C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274306, XrefRangeEnd = 274314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NextPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_NextPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600999F RID: 39327 RVA: 0x00272380 File Offset: 0x00270580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274314, XrefRangeEnd = 274316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignCustomer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_AssignCustomer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099A0 RID: 39328 RVA: 0x002723B4 File Offset: 0x002705B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274316, XrefRangeEnd = 274329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealerManagementApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099A1 RID: 39329 RVA: 0x0004AE71 File Offset: 0x00049071
		public DealerManagementApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F31 RID: 12081
		// (get) Token: 0x060099A2 RID: 39330 RVA: 0x002723F0 File Offset: 0x002705F0
		// (set) Token: 0x060099A3 RID: 39331 RVA: 0x0004AE7A File Offset: 0x0004907A
		public unsafe Dealer _SelectedDealer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__SelectedDealer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__SelectedDealer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F32 RID: 12082
		// (get) Token: 0x060099A4 RID: 39332 RVA: 0x00272420 File Offset: 0x00270620
		// (set) Token: 0x060099A5 RID: 39333 RVA: 0x0004AE99 File Offset: 0x00049099
		public unsafe Text NoDealersLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_NoDealersLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_NoDealersLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F33 RID: 12083
		// (get) Token: 0x060099A6 RID: 39334 RVA: 0x00272450 File Offset: 0x00270650
		// (set) Token: 0x060099A7 RID: 39335 RVA: 0x0004AEB8 File Offset: 0x000490B8
		public unsafe RectTransform Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F34 RID: 12084
		// (get) Token: 0x060099A8 RID: 39336 RVA: 0x00272480 File Offset: 0x00270680
		// (set) Token: 0x060099A9 RID: 39337 RVA: 0x0004AED7 File Offset: 0x000490D7
		public unsafe CustomerSelector CustomerSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F35 RID: 12085
		// (get) Token: 0x060099AA RID: 39338 RVA: 0x002724B0 File Offset: 0x002706B0
		// (set) Token: 0x060099AB RID: 39339 RVA: 0x0004AEF6 File Offset: 0x000490F6
		public unsafe Image SelectorImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_SelectorImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_SelectorImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F36 RID: 12086
		// (get) Token: 0x060099AC RID: 39340 RVA: 0x002724E0 File Offset: 0x002706E0
		// (set) Token: 0x060099AD RID: 39341 RVA: 0x0004AF15 File Offset: 0x00049115
		public unsafe Text SelectorTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_SelectorTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_SelectorTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F37 RID: 12087
		// (get) Token: 0x060099AE RID: 39342 RVA: 0x00272510 File Offset: 0x00270710
		// (set) Token: 0x060099AF RID: 39343 RVA: 0x0004AF34 File Offset: 0x00049134
		public unsafe Button BackButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_BackButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F38 RID: 12088
		// (get) Token: 0x060099B0 RID: 39344 RVA: 0x00272540 File Offset: 0x00270740
		// (set) Token: 0x060099B1 RID: 39345 RVA: 0x0004AF53 File Offset: 0x00049153
		public unsafe Button NextButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_NextButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_NextButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F39 RID: 12089
		// (get) Token: 0x060099B2 RID: 39346 RVA: 0x00272570 File Offset: 0x00270770
		// (set) Token: 0x060099B3 RID: 39347 RVA: 0x0004AF72 File Offset: 0x00049172
		public unsafe Text CashLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CashLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CashLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F3A RID: 12090
		// (get) Token: 0x060099B4 RID: 39348 RVA: 0x002725A0 File Offset: 0x002707A0
		// (set) Token: 0x060099B5 RID: 39349 RVA: 0x0004AF91 File Offset: 0x00049191
		public unsafe Text CutLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CutLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CutLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F3B RID: 12091
		// (get) Token: 0x060099B6 RID: 39350 RVA: 0x002725D0 File Offset: 0x002707D0
		// (set) Token: 0x060099B7 RID: 39351 RVA: 0x0004AFB0 File Offset: 0x000491B0
		public unsafe Text HomeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_HomeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_HomeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F3C RID: 12092
		// (get) Token: 0x060099B8 RID: 39352 RVA: 0x00272600 File Offset: 0x00270800
		// (set) Token: 0x060099B9 RID: 39353 RVA: 0x0004AFCF File Offset: 0x000491CF
		public unsafe Il2CppReferenceArray<RectTransform> InventoryEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_InventoryEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_InventoryEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F3D RID: 12093
		// (get) Token: 0x060099BA RID: 39354 RVA: 0x00272630 File Offset: 0x00270830
		// (set) Token: 0x060099BB RID: 39355 RVA: 0x0004AFEE File Offset: 0x000491EE
		public unsafe Text CustomerTitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerTitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerTitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F3E RID: 12094
		// (get) Token: 0x060099BC RID: 39356 RVA: 0x00272660 File Offset: 0x00270860
		// (set) Token: 0x060099BD RID: 39357 RVA: 0x0004B00D File Offset: 0x0004920D
		public unsafe Il2CppReferenceArray<RectTransform> CustomerEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F3F RID: 12095
		// (get) Token: 0x060099BE RID: 39358 RVA: 0x00272690 File Offset: 0x00270890
		// (set) Token: 0x060099BF RID: 39359 RVA: 0x0004B02C File Offset: 0x0004922C
		public unsafe Button AssignCustomerButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_AssignCustomerButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_AssignCustomerButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F40 RID: 12096
		// (get) Token: 0x060099C0 RID: 39360 RVA: 0x002726C0 File Offset: 0x002708C0
		// (set) Token: 0x060099C1 RID: 39361 RVA: 0x0004B04B File Offset: 0x0004924B
		public unsafe List<Dealer> dealers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_dealers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Dealer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_dealers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006763 RID: 26467
		private static readonly IntPtr NativeFieldInfoPtr__SelectedDealer_k__BackingField;

		// Token: 0x04006764 RID: 26468
		private static readonly IntPtr NativeFieldInfoPtr_NoDealersLabel;

		// Token: 0x04006765 RID: 26469
		private static readonly IntPtr NativeFieldInfoPtr_Content;

		// Token: 0x04006766 RID: 26470
		private static readonly IntPtr NativeFieldInfoPtr_CustomerSelector;

		// Token: 0x04006767 RID: 26471
		private static readonly IntPtr NativeFieldInfoPtr_SelectorImage;

		// Token: 0x04006768 RID: 26472
		private static readonly IntPtr NativeFieldInfoPtr_SelectorTitle;

		// Token: 0x04006769 RID: 26473
		private static readonly IntPtr NativeFieldInfoPtr_BackButton;

		// Token: 0x0400676A RID: 26474
		private static readonly IntPtr NativeFieldInfoPtr_NextButton;

		// Token: 0x0400676B RID: 26475
		private static readonly IntPtr NativeFieldInfoPtr_CashLabel;

		// Token: 0x0400676C RID: 26476
		private static readonly IntPtr NativeFieldInfoPtr_CutLabel;

		// Token: 0x0400676D RID: 26477
		private static readonly IntPtr NativeFieldInfoPtr_HomeLabel;

		// Token: 0x0400676E RID: 26478
		private static readonly IntPtr NativeFieldInfoPtr_InventoryEntries;

		// Token: 0x0400676F RID: 26479
		private static readonly IntPtr NativeFieldInfoPtr_CustomerTitleLabel;

		// Token: 0x04006770 RID: 26480
		private static readonly IntPtr NativeFieldInfoPtr_CustomerEntries;

		// Token: 0x04006771 RID: 26481
		private static readonly IntPtr NativeFieldInfoPtr_AssignCustomerButton;

		// Token: 0x04006772 RID: 26482
		private static readonly IntPtr NativeFieldInfoPtr_dealers;

		// Token: 0x04006773 RID: 26483
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedDealer_Public_get_Dealer_0;

		// Token: 0x04006774 RID: 26484
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedDealer_Private_set_Void_Dealer_0;

		// Token: 0x04006775 RID: 26485
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006776 RID: 26486
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006777 RID: 26487
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04006778 RID: 26488
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006779 RID: 26489
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedDealer_Public_Void_Dealer_0;

		// Token: 0x0400677A RID: 26490
		private static readonly IntPtr NativeMethodInfoPtr_AddDealer_Private_Void_Dealer_0;

		// Token: 0x0400677B RID: 26491
		private static readonly IntPtr NativeMethodInfoPtr_AddCustomer_Private_Void_Customer_0;

		// Token: 0x0400677C RID: 26492
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCustomer_Private_Void_Customer_0;

		// Token: 0x0400677D RID: 26493
		private static readonly IntPtr NativeMethodInfoPtr_BackPressed_Private_Void_0;

		// Token: 0x0400677E RID: 26494
		private static readonly IntPtr NativeMethodInfoPtr_NextPressed_Private_Void_0;

		// Token: 0x0400677F RID: 26495
		private static readonly IntPtr NativeMethodInfoPtr_AssignCustomer_Public_Void_0;

		// Token: 0x04006780 RID: 26496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B79 RID: 2937
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.DealerManagementApp+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DB50 RID: 56144 RVA: 0x0033EE84 File Offset: 0x0033D084
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr);
				DealerManagementApp.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, "<>9");
				DealerManagementApp.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, "<>9__24_0");
				DealerManagementApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, 100682250);
				DealerManagementApp.__c.NativeMethodInfoPtr__AddDealer_b__24_0_Internal_String_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, 100682251);
			}

			// Token: 0x0600DB51 RID: 56145 RVA: 0x0033EF00 File Offset: 0x0033D100
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB52 RID: 56146 RVA: 0x0033EF3C File Offset: 0x0033D13C
			[CallerCount(0)]
			public unsafe string _AddDealer_b__24_0(Dealer d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c.NativeMethodInfoPtr__AddDealer_b__24_0_Internal_String_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DB53 RID: 56147 RVA: 0x0006AD22 File Offset: 0x00068F22
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004406 RID: 17414
			// (get) Token: 0x0600DB54 RID: 56148 RVA: 0x0033EF84 File Offset: 0x0033D184
			// (set) Token: 0x0600DB55 RID: 56149 RVA: 0x0006AD2B File Offset: 0x00068F2B
			public unsafe static DealerManagementApp.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DealerManagementApp.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealerManagementApp.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DealerManagementApp.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004407 RID: 17415
			// (get) Token: 0x0600DB56 RID: 56150 RVA: 0x0033EFAC File Offset: 0x0033D1AC
			// (set) Token: 0x0600DB57 RID: 56151 RVA: 0x0006AD3D File Offset: 0x00068F3D
			public unsafe static Func<Dealer, string> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DealerManagementApp.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Dealer, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DealerManagementApp.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400931D RID: 37661
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400931E RID: 37662
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x0400931F RID: 37663
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009320 RID: 37664
			private static readonly IntPtr NativeMethodInfoPtr__AddDealer_b__24_0_Internal_String_Dealer_0;
		}

		// Token: 0x02000B7A RID: 2938
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.DealerManagementApp+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB58 RID: 56152 RVA: 0x0033EFD4 File Offset: 0x0033D1D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr);
				DealerManagementApp.__c__DisplayClass23_0.NativeFieldInfoPtr_customer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr, "customer");
				DealerManagementApp.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr, "<>4__this");
				DealerManagementApp.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr, 100682252);
				DealerManagementApp.__c__DisplayClass23_0.NativeMethodInfoPtr__SetDisplayedDealer_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr, 100682253);
			}

			// Token: 0x0600DB59 RID: 56153 RVA: 0x0033F050 File Offset: 0x0033D250
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB5A RID: 56154 RVA: 0x0033F08C File Offset: 0x0033D28C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273969, XrefRangeEnd = 273972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetDisplayedDealer_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c__DisplayClass23_0.NativeMethodInfoPtr__SetDisplayedDealer_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB5B RID: 56155 RVA: 0x0006AD4F File Offset: 0x00068F4F
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004408 RID: 17416
			// (get) Token: 0x0600DB5C RID: 56156 RVA: 0x0033F0C0 File Offset: 0x0033D2C0
			// (set) Token: 0x0600DB5D RID: 56157 RVA: 0x0006AD58 File Offset: 0x00068F58
			public unsafe Customer customer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass23_0.NativeFieldInfoPtr_customer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass23_0.NativeFieldInfoPtr_customer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004409 RID: 17417
			// (get) Token: 0x0600DB5E RID: 56158 RVA: 0x0033F0F0 File Offset: 0x0033D2F0
			// (set) Token: 0x0600DB5F RID: 56159 RVA: 0x0006AD77 File Offset: 0x00068F77
			public unsafe DealerManagementApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealerManagementApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009321 RID: 37665
			private static readonly IntPtr NativeFieldInfoPtr_customer;

			// Token: 0x04009322 RID: 37666
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009323 RID: 37667
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009324 RID: 37668
			private static readonly IntPtr NativeMethodInfoPtr__SetDisplayedDealer_b__0_Internal_Void_0;
		}
	}
}
