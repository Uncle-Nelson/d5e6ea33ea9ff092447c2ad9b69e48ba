using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001AB RID: 427
	public class Contract : Quest
	{
		// Token: 0x06002454 RID: 9300 RVA: 0x000E11C4 File Offset: 0x000DF3C4
		// Note: this type is marked as 'beforefieldinit'.
		static Contract()
		{
			Il2CppClassPointerStore<Contract>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Contract");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Contract>.NativeClassPtr);
			Contract.NativeFieldInfoPtr_DefaultExpiryTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "DefaultExpiryTime");
			Contract.NativeFieldInfoPtr_Contracts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "Contracts");
			Contract.NativeFieldInfoPtr__Customer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<Customer>k__BackingField");
			Contract.NativeFieldInfoPtr__Dealer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<Dealer>k__BackingField");
			Contract.NativeFieldInfoPtr__Payment_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<Payment>k__BackingField");
			Contract.NativeFieldInfoPtr_ProductList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "ProductList");
			Contract.NativeFieldInfoPtr_DeliveryLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "DeliveryLocation");
			Contract.NativeFieldInfoPtr_DeliveryWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "DeliveryWindow");
			Contract.NativeFieldInfoPtr__PickupScheduleIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<PickupScheduleIndex>k__BackingField");
			Contract.NativeFieldInfoPtr__AcceptTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<AcceptTime>k__BackingField");
			Contract.NativeFieldInfoPtr_completedContractsIncremented = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "completedContractsIncremented");
			Contract.NativeMethodInfoPtr_get_Customer_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667310);
			Contract.NativeMethodInfoPtr_set_Customer_Protected_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667311);
			Contract.NativeMethodInfoPtr_get_Dealer_Public_get_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667312);
			Contract.NativeMethodInfoPtr_set_Dealer_Protected_set_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667313);
			Contract.NativeMethodInfoPtr_get_Payment_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667314);
			Contract.NativeMethodInfoPtr_set_Payment_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667315);
			Contract.NativeMethodInfoPtr_get_PickupScheduleIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667316);
			Contract.NativeMethodInfoPtr_set_PickupScheduleIndex_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667317);
			Contract.NativeMethodInfoPtr_get_AcceptTime_Public_get_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667318);
			Contract.NativeMethodInfoPtr_set_AcceptTime_Protected_set_Void_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667319);
			Contract.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667320);
			Contract.NativeMethodInfoPtr_InitializeContract_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_NetworkObject_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667321);
			Contract.NativeMethodInfoPtr_SilentlyInitializeContract_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_NetworkObject_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667322);
			Contract.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667323);
			Contract.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667324);
			Contract.NativeMethodInfoPtr_UpdateTiming_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667325);
			Contract.NativeMethodInfoPtr_End_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667326);
			Contract.NativeMethodInfoPtr_Complete_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667327);
			Contract.NativeMethodInfoPtr_SetDealer_Public_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667328);
			Contract.NativeMethodInfoPtr_SubmitPayment_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667329);
			Contract.NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667330);
			Contract.NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667331);
			Contract.NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667332);
			Contract.NativeMethodInfoPtr_CanExpire_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667333);
			Contract.NativeMethodInfoPtr_DoesProductListMatchSpecified_Public_Boolean_List_1_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667334);
			Contract.NativeMethodInfoPtr_GetProductListMatch_Public_Single_List_1_ItemInstance_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667335);
			Contract.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667336);
			Contract.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667337);
			Contract.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667338);
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06002455 RID: 9301 RVA: 0x000E1514 File Offset: 0x000DF714
		// (set) Token: 0x06002456 RID: 9302 RVA: 0x000E1554 File Offset: 0x000DF754
		public unsafe NetworkObject Customer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_get_Customer_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113197, XrefRangeEnd = 113198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_set_Customer_Protected_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x000E1598 File Offset: 0x000DF798
		// (set) Token: 0x06002458 RID: 9304 RVA: 0x000E15D8 File Offset: 0x000DF7D8
		public unsafe Dealer Dealer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_get_Dealer_Public_get_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113198, XrefRangeEnd = 113199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_set_Dealer_Protected_set_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x000E161C File Offset: 0x000DF81C
		// (set) Token: 0x0600245A RID: 9306 RVA: 0x000E1658 File Offset: 0x000DF858
		public unsafe float Payment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_get_Payment_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_set_Payment_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x000E1698 File Offset: 0x000DF898
		// (set) Token: 0x0600245C RID: 9308 RVA: 0x000E16D4 File Offset: 0x000DF8D4
		public unsafe int PickupScheduleIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_get_PickupScheduleIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_set_PickupScheduleIndex_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x0600245D RID: 9309 RVA: 0x000E1714 File Offset: 0x000DF914
		// (set) Token: 0x0600245E RID: 9310 RVA: 0x000E1750 File Offset: 0x000DF950
		public unsafe GameDateTime AcceptTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_get_AcceptTime_Public_get_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_set_AcceptTime_Protected_set_Void_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x000E1790 File Offset: 0x000DF990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113199, XrefRangeEnd = 113200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x000E17CC File Offset: 0x000DF9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113200, XrefRangeEnd = 113229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeContract(string title, string description, Il2CppReferenceArray<QuestEntryData> entries, string guid, NetworkObject customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTime acceptTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref payment;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(products);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deliveryLocationGUID);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deliveryWindow);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pickupScheduleIndex;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acceptTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_InitializeContract_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_NetworkObject_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x000E18CC File Offset: 0x000DFACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113229, XrefRangeEnd = 113244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SilentlyInitializeContract(string title, string description, Il2CppReferenceArray<QuestEntryData> entries, string guid, NetworkObject customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTime acceptTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref payment;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(products);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deliveryLocationGUID);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deliveryWindow);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pickupScheduleIndex;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acceptTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_SilentlyInitializeContract_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_NetworkObject_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x000E19CC File Offset: 0x000DFBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113244, XrefRangeEnd = 113257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x000E1A08 File Offset: 0x000DFC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113257, XrefRangeEnd = 113265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x000E1A3C File Offset: 0x000DFC3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113318, RefRangeEnd = 113319, XrefRangeStart = 113265, XrefRangeEnd = 113318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTiming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_UpdateTiming_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x000E1A70 File Offset: 0x000DFC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113319, XrefRangeEnd = 113334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_End_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x000E1AAC File Offset: 0x000DFCAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113334, XrefRangeEnd = 113349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Complete(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_Complete_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x000E1AF8 File Offset: 0x000DFCF8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 113356, RefRangeEnd = 113361, XrefRangeStart = 113349, XrefRangeEnd = 113356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDealer(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_SetDealer_Public_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x000E1B3C File Offset: 0x000DFD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113361, XrefRangeEnd = 113366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SubmitPayment(float bonusTotal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bonusTotal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_SubmitPayment_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x000E1B88 File Offset: 0x000DFD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113366, XrefRangeEnd = 113377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendExpiryReminder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x000E1BC4 File Offset: 0x000DFDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113377, XrefRangeEnd = 113388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendExpiredNotification()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x000E1C00 File Offset: 0x000DFE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113388, XrefRangeEnd = 113392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldShowJournalEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x000E1C48 File Offset: 0x000DFE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113392, XrefRangeEnd = 113403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanExpire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_CanExpire_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x000E1C90 File Offset: 0x000DFE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113403, XrefRangeEnd = 113476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesProductListMatchSpecified(List<ItemInstance> items, bool enforceQuality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enforceQuality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_DoesProductListMatchSpecified_Public_Boolean_List_1_ItemInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x000E1CEC File Offset: 0x000DFEEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113580, RefRangeEnd = 113582, XrefRangeStart = 113476, XrefRangeEnd = 113580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetProductListMatch(List<ItemInstance> items, out int matchedProductCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &matchedProductCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_GetProductListMatch_Public_Single_List_1_ItemInstance_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x000E1D48 File Offset: 0x000DFF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113582, XrefRangeEnd = 113622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x000E1D8C File Offset: 0x000DFF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113622, XrefRangeEnd = 113627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x000E1DC8 File Offset: 0x000DFFC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113659, RefRangeEnd = 113661, XrefRangeStart = 113627, XrefRangeEnd = 113659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contract() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Contract>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x000146BC File Offset: 0x000128BC
		public Contract(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x000E1E04 File Offset: 0x000E0004
		// (set) Token: 0x06002474 RID: 9332 RVA: 0x000146C5 File Offset: 0x000128C5
		public unsafe static int DefaultExpiryTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Contract.NativeFieldInfoPtr_DefaultExpiryTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Contract.NativeFieldInfoPtr_DefaultExpiryTime, (void*)(&value));
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06002475 RID: 9333 RVA: 0x000E1E20 File Offset: 0x000E0020
		// (set) Token: 0x06002476 RID: 9334 RVA: 0x000146D3 File Offset: 0x000128D3
		public unsafe static List<Contract> Contracts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Contract.NativeFieldInfoPtr_Contracts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Contract>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Contract.NativeFieldInfoPtr_Contracts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06002477 RID: 9335 RVA: 0x000E1E48 File Offset: 0x000E0048
		// (set) Token: 0x06002478 RID: 9336 RVA: 0x000146E5 File Offset: 0x000128E5
		public unsafe NetworkObject _Customer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__Customer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__Customer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06002479 RID: 9337 RVA: 0x000E1E78 File Offset: 0x000E0078
		// (set) Token: 0x0600247A RID: 9338 RVA: 0x00014704 File Offset: 0x00012904
		public unsafe Dealer _Dealer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__Dealer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__Dealer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x0600247B RID: 9339 RVA: 0x000E1EA8 File Offset: 0x000E00A8
		// (set) Token: 0x0600247C RID: 9340 RVA: 0x00014723 File Offset: 0x00012923
		public unsafe float _Payment_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__Payment_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__Payment_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x0600247D RID: 9341 RVA: 0x000E1ED0 File Offset: 0x000E00D0
		// (set) Token: 0x0600247E RID: 9342 RVA: 0x0001473E File Offset: 0x0001293E
		public unsafe ProductList ProductList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_ProductList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_ProductList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x0600247F RID: 9343 RVA: 0x000E1F00 File Offset: 0x000E0100
		// (set) Token: 0x06002480 RID: 9344 RVA: 0x0001475D File Offset: 0x0001295D
		public unsafe DeliveryLocation DeliveryLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_DeliveryLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_DeliveryLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06002481 RID: 9345 RVA: 0x000E1F30 File Offset: 0x000E0130
		// (set) Token: 0x06002482 RID: 9346 RVA: 0x0001477C File Offset: 0x0001297C
		public unsafe QuestWindowConfig DeliveryWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_DeliveryWindow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestWindowConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_DeliveryWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06002483 RID: 9347 RVA: 0x000E1F60 File Offset: 0x000E0160
		// (set) Token: 0x06002484 RID: 9348 RVA: 0x0001479B File Offset: 0x0001299B
		public unsafe int _PickupScheduleIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__PickupScheduleIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__PickupScheduleIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06002485 RID: 9349 RVA: 0x000E1F88 File Offset: 0x000E0188
		// (set) Token: 0x06002486 RID: 9350 RVA: 0x000147B6 File Offset: 0x000129B6
		public unsafe GameDateTime _AcceptTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__AcceptTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__AcceptTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06002487 RID: 9351 RVA: 0x000E1FB0 File Offset: 0x000E01B0
		// (set) Token: 0x06002488 RID: 9352 RVA: 0x000147D1 File Offset: 0x000129D1
		public unsafe bool completedContractsIncremented
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_completedContractsIncremented);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_completedContractsIncremented)) = value;
			}
		}

		// Token: 0x0400180E RID: 6158
		private static readonly IntPtr NativeFieldInfoPtr_DefaultExpiryTime;

		// Token: 0x0400180F RID: 6159
		private static readonly IntPtr NativeFieldInfoPtr_Contracts;

		// Token: 0x04001810 RID: 6160
		private static readonly IntPtr NativeFieldInfoPtr__Customer_k__BackingField;

		// Token: 0x04001811 RID: 6161
		private static readonly IntPtr NativeFieldInfoPtr__Dealer_k__BackingField;

		// Token: 0x04001812 RID: 6162
		private static readonly IntPtr NativeFieldInfoPtr__Payment_k__BackingField;

		// Token: 0x04001813 RID: 6163
		private static readonly IntPtr NativeFieldInfoPtr_ProductList;

		// Token: 0x04001814 RID: 6164
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryLocation;

		// Token: 0x04001815 RID: 6165
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryWindow;

		// Token: 0x04001816 RID: 6166
		private static readonly IntPtr NativeFieldInfoPtr__PickupScheduleIndex_k__BackingField;

		// Token: 0x04001817 RID: 6167
		private static readonly IntPtr NativeFieldInfoPtr__AcceptTime_k__BackingField;

		// Token: 0x04001818 RID: 6168
		private static readonly IntPtr NativeFieldInfoPtr_completedContractsIncremented;

		// Token: 0x04001819 RID: 6169
		private static readonly IntPtr NativeMethodInfoPtr_get_Customer_Public_get_NetworkObject_0;

		// Token: 0x0400181A RID: 6170
		private static readonly IntPtr NativeMethodInfoPtr_set_Customer_Protected_set_Void_NetworkObject_0;

		// Token: 0x0400181B RID: 6171
		private static readonly IntPtr NativeMethodInfoPtr_get_Dealer_Public_get_Dealer_0;

		// Token: 0x0400181C RID: 6172
		private static readonly IntPtr NativeMethodInfoPtr_set_Dealer_Protected_set_Void_Dealer_0;

		// Token: 0x0400181D RID: 6173
		private static readonly IntPtr NativeMethodInfoPtr_get_Payment_Public_get_Single_0;

		// Token: 0x0400181E RID: 6174
		private static readonly IntPtr NativeMethodInfoPtr_set_Payment_Protected_set_Void_Single_0;

		// Token: 0x0400181F RID: 6175
		private static readonly IntPtr NativeMethodInfoPtr_get_PickupScheduleIndex_Public_get_Int32_0;

		// Token: 0x04001820 RID: 6176
		private static readonly IntPtr NativeMethodInfoPtr_set_PickupScheduleIndex_Protected_set_Void_Int32_0;

		// Token: 0x04001821 RID: 6177
		private static readonly IntPtr NativeMethodInfoPtr_get_AcceptTime_Public_get_GameDateTime_0;

		// Token: 0x04001822 RID: 6178
		private static readonly IntPtr NativeMethodInfoPtr_set_AcceptTime_Protected_set_Void_GameDateTime_0;

		// Token: 0x04001823 RID: 6179
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001824 RID: 6180
		private static readonly IntPtr NativeMethodInfoPtr_InitializeContract_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_NetworkObject_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTime_0;

		// Token: 0x04001825 RID: 6181
		private static readonly IntPtr NativeMethodInfoPtr_SilentlyInitializeContract_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_NetworkObject_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTime_0;

		// Token: 0x04001826 RID: 6182
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04001827 RID: 6183
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001828 RID: 6184
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTiming_Private_Void_0;

		// Token: 0x04001829 RID: 6185
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_Void_0;

		// Token: 0x0400182A RID: 6186
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400182B RID: 6187
		private static readonly IntPtr NativeMethodInfoPtr_SetDealer_Public_Void_Dealer_0;

		// Token: 0x0400182C RID: 6188
		private static readonly IntPtr NativeMethodInfoPtr_SubmitPayment_Public_Virtual_New_Void_Single_0;

		// Token: 0x0400182D RID: 6189
		private static readonly IntPtr NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_Void_0;

		// Token: 0x0400182E RID: 6190
		private static readonly IntPtr NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_Void_0;

		// Token: 0x0400182F RID: 6191
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_Boolean_0;

		// Token: 0x04001830 RID: 6192
		private static readonly IntPtr NativeMethodInfoPtr_CanExpire_Protected_Virtual_Boolean_0;

		// Token: 0x04001831 RID: 6193
		private static readonly IntPtr NativeMethodInfoPtr_DoesProductListMatchSpecified_Public_Boolean_List_1_ItemInstance_Boolean_0;

		// Token: 0x04001832 RID: 6194
		private static readonly IntPtr NativeMethodInfoPtr_GetProductListMatch_Public_Single_List_1_ItemInstance_byref_Int32_0;

		// Token: 0x04001833 RID: 6195
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04001834 RID: 6196
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Boolean_0;

		// Token: 0x04001835 RID: 6197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008CB RID: 2251
		public class BonusPayment : Object
		{
			// Token: 0x0600C3F9 RID: 50169 RVA: 0x002FC484 File Offset: 0x002FA684
			// Note: this type is marked as 'beforefieldinit'.
			static BonusPayment()
			{
				Il2CppClassPointerStore<Contract.BonusPayment>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Contract>.NativeClassPtr, "BonusPayment");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Contract.BonusPayment>.NativeClassPtr);
				Contract.BonusPayment.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract.BonusPayment>.NativeClassPtr, "Title");
				Contract.BonusPayment.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract.BonusPayment>.NativeClassPtr, "Amount");
				Contract.BonusPayment.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract.BonusPayment>.NativeClassPtr, 100667340);
			}

			// Token: 0x0600C3FA RID: 50170 RVA: 0x002FC4EC File Offset: 0x002FA6EC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 113186, RefRangeEnd = 113189, XrefRangeStart = 113184, XrefRangeEnd = 113186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BonusPayment(string title, float amount) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Contract.BonusPayment>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.BonusPayment.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3FB RID: 50171 RVA: 0x0005F65E File Offset: 0x0005D85E
			public BonusPayment(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D2F RID: 15663
			// (get) Token: 0x0600C3FC RID: 50172 RVA: 0x002FC548 File Offset: 0x002FA748
			// (set) Token: 0x0600C3FD RID: 50173 RVA: 0x0005F667 File Offset: 0x0005D867
			public unsafe string Title
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.BonusPayment.NativeFieldInfoPtr_Title);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.BonusPayment.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003D30 RID: 15664
			// (get) Token: 0x0600C3FE RID: 50174 RVA: 0x002FC570 File Offset: 0x002FA770
			// (set) Token: 0x0600C3FF RID: 50175 RVA: 0x0005F686 File Offset: 0x0005D886
			public unsafe float Amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.BonusPayment.NativeFieldInfoPtr_Amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.BonusPayment.NativeFieldInfoPtr_Amount)) = value;
				}
			}

			// Token: 0x040084D5 RID: 34005
			private static readonly IntPtr NativeFieldInfoPtr_Title;

			// Token: 0x040084D6 RID: 34006
			private static readonly IntPtr NativeFieldInfoPtr_Amount;

			// Token: 0x040084D7 RID: 34007
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_0;
		}

		// Token: 0x020008CC RID: 2252
		[ObfuscatedName("ScheduleOne.Quests.Contract+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Object
		{
			// Token: 0x0600C400 RID: 50176 RVA: 0x002FC598 File Offset: 0x002FA798
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<Contract.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Contract.__c__DisplayClass41_0>.NativeClassPtr);
				Contract.__c__DisplayClass41_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract.__c__DisplayClass41_0>.NativeClassPtr, "entry");
				Contract.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract.__c__DisplayClass41_0>.NativeClassPtr, 100667341);
				Contract.__c__DisplayClass41_0.NativeMethodInfoPtr__DoesProductListMatchSpecified_b__0_Internal_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract.__c__DisplayClass41_0>.NativeClassPtr, 100667342);
			}

			// Token: 0x0600C401 RID: 50177 RVA: 0x002FC600 File Offset: 0x002FA800
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Contract.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C402 RID: 50178 RVA: 0x002FC63C File Offset: 0x002FA83C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113189, XrefRangeEnd = 113191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DoesProductListMatchSpecified_b__0(ItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.__c__DisplayClass41_0.NativeMethodInfoPtr__DoesProductListMatchSpecified_b__0_Internal_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C403 RID: 50179 RVA: 0x0005F6A1 File Offset: 0x0005D8A1
			public __c__DisplayClass41_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D31 RID: 15665
			// (get) Token: 0x0600C404 RID: 50180 RVA: 0x002FC68C File Offset: 0x002FA88C
			// (set) Token: 0x0600C405 RID: 50181 RVA: 0x0005F6AA File Offset: 0x0005D8AA
			public unsafe ProductList.Entry entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.__c__DisplayClass41_0.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList.Entry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.__c__DisplayClass41_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084D8 RID: 34008
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x040084D9 RID: 34009
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084DA RID: 34010
			private static readonly IntPtr NativeMethodInfoPtr__DoesProductListMatchSpecified_b__0_Internal_Boolean_ItemInstance_0;
		}

		// Token: 0x020008CD RID: 2253
		[ObfuscatedName("ScheduleOne.Quests.Contract+<>c__DisplayClass42_0")]
		public sealed class __c__DisplayClass42_0 : Object
		{
			// Token: 0x0600C406 RID: 50182 RVA: 0x002FC6BC File Offset: 0x002FA8BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass42_0()
			{
				Il2CppClassPointerStore<Contract.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<>c__DisplayClass42_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Contract.__c__DisplayClass42_0>.NativeClassPtr);
				Contract.__c__DisplayClass42_0.NativeFieldInfoPtr_matchRatings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract.__c__DisplayClass42_0>.NativeClassPtr, "matchRatings");
				Contract.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract.__c__DisplayClass42_0>.NativeClassPtr, 100667343);
				Contract.__c__DisplayClass42_0.NativeMethodInfoPtr__GetProductListMatch_b__0_Internal_Int32_ProductItemInstance_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract.__c__DisplayClass42_0>.NativeClassPtr, 100667344);
			}

			// Token: 0x0600C407 RID: 50183 RVA: 0x002FC724 File Offset: 0x002FA924
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass42_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Contract.__c__DisplayClass42_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C408 RID: 50184 RVA: 0x002FC760 File Offset: 0x002FA960
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113191, XrefRangeEnd = 113197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetProductListMatch_b__0(ProductItemInstance x, ProductItemInstance y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.__c__DisplayClass42_0.NativeMethodInfoPtr__GetProductListMatch_b__0_Internal_Int32_ProductItemInstance_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C409 RID: 50185 RVA: 0x0005F6C9 File Offset: 0x0005D8C9
			public __c__DisplayClass42_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D32 RID: 15666
			// (get) Token: 0x0600C40A RID: 50186 RVA: 0x002FC7C0 File Offset: 0x002FA9C0
			// (set) Token: 0x0600C40B RID: 50187 RVA: 0x0005F6D2 File Offset: 0x0005D8D2
			public unsafe Dictionary<ProductItemInstance, float> matchRatings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.__c__DisplayClass42_0.NativeFieldInfoPtr_matchRatings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ProductItemInstance, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.__c__DisplayClass42_0.NativeFieldInfoPtr_matchRatings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084DB RID: 34011
			private static readonly IntPtr NativeFieldInfoPtr_matchRatings;

			// Token: 0x040084DC RID: 34012
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084DD RID: 34013
			private static readonly IntPtr NativeMethodInfoPtr__GetProductListMatch_b__0_Internal_Int32_ProductItemInstance_ProductItemInstance_0;
		}
	}
}
