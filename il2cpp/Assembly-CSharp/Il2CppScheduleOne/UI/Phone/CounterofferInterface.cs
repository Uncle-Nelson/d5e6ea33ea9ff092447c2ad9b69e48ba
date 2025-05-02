using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Messaging;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x0200069D RID: 1693
	public class CounterofferInterface : MonoBehaviour
	{
		// Token: 0x060096B7 RID: 38583 RVA: 0x00269564 File Offset: 0x00267764
		// Note: this type is marked as 'beforefieldinit'.
		static CounterofferInterface()
		{
			Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "CounterofferInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr);
			CounterofferInterface.NativeFieldInfoPtr_COUNTEROFFER_SUCCESS_XP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "COUNTEROFFER_SUCCESS_XP");
			CounterofferInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			CounterofferInterface.NativeFieldInfoPtr_MinQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "MinQuantity");
			CounterofferInterface.NativeFieldInfoPtr_MaxQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "MaxQuantity");
			CounterofferInterface.NativeFieldInfoPtr_MinPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "MinPrice");
			CounterofferInterface.NativeFieldInfoPtr_MaxPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "MaxPrice");
			CounterofferInterface.NativeFieldInfoPtr_IconAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "IconAlignment");
			CounterofferInterface.NativeFieldInfoPtr_ProductEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductEntryPrefab");
			CounterofferInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "Container");
			CounterofferInterface.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "TitleLabel");
			CounterofferInterface.NativeFieldInfoPtr_ConfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ConfirmButton");
			CounterofferInterface.NativeFieldInfoPtr_ProductIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductIcon");
			CounterofferInterface.NativeFieldInfoPtr_ProductLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductLabel");
			CounterofferInterface.NativeFieldInfoPtr_ProductLabelRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductLabelRect");
			CounterofferInterface.NativeFieldInfoPtr_PriceInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "PriceInput");
			CounterofferInterface.NativeFieldInfoPtr_FairPriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "FairPriceLabel");
			CounterofferInterface.NativeFieldInfoPtr_ProductSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductSelector");
			CounterofferInterface.NativeFieldInfoPtr_orderConfirmedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "orderConfirmedCallback");
			CounterofferInterface.NativeFieldInfoPtr_selectedProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "selectedProduct");
			CounterofferInterface.NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "quantity");
			CounterofferInterface.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "price");
			CounterofferInterface.NativeFieldInfoPtr_productEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "productEntries");
			CounterofferInterface.NativeFieldInfoPtr_mouseUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "mouseUp");
			CounterofferInterface.NativeFieldInfoPtr_conversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "conversation");
			CounterofferInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681918);
			CounterofferInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681919);
			CounterofferInterface.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681920);
			CounterofferInterface.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681921);
			CounterofferInterface.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681922);
			CounterofferInterface.NativeMethodInfoPtr_Open_Public_Void_ProductDefinition_Int32_Single_MSGConversation_Action_3_ProductDefinition_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681923);
			CounterofferInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681924);
			CounterofferInterface.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681925);
			CounterofferInterface.NativeMethodInfoPtr_Send_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681926);
			CounterofferInterface.NativeMethodInfoPtr_UpdateFairPrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681927);
			CounterofferInterface.NativeMethodInfoPtr_SetProduct_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681928);
			CounterofferInterface.NativeMethodInfoPtr_DisplayProduct_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681929);
			CounterofferInterface.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681930);
			CounterofferInterface.NativeMethodInfoPtr_UpdatePriceQuantityLabel_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681931);
			CounterofferInterface.NativeMethodInfoPtr_ChangePrice_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681932);
			CounterofferInterface.NativeMethodInfoPtr_PriceSubmitted_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681933);
			CounterofferInterface.NativeMethodInfoPtr_OpenProductSelector_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681934);
			CounterofferInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681935);
		}

		// Token: 0x17002E48 RID: 11848
		// (get) Token: 0x060096B8 RID: 38584 RVA: 0x002698DC File Offset: 0x00267ADC
		// (set) Token: 0x060096B9 RID: 38585 RVA: 0x00269918 File Offset: 0x00267B18
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060096BA RID: 38586 RVA: 0x00269958 File Offset: 0x00267B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270262, XrefRangeEnd = 270292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096BB RID: 38587 RVA: 0x0026998C File Offset: 0x00267B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270292, XrefRangeEnd = 270303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096BC RID: 38588 RVA: 0x002699C0 File Offset: 0x00267BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270303, XrefRangeEnd = 270334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096BD RID: 38589 RVA: 0x002699F4 File Offset: 0x00267BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270359, RefRangeEnd = 270360, XrefRangeStart = 270334, XrefRangeEnd = 270359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ProductDefinition product, int quantity, float price, MSGConversation _conversation, Action<ProductDefinition, int, float> _orderConfirmedCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_conversation);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_orderConfirmedCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Open_Public_Void_ProductDefinition_Int32_Single_MSGConversation_Action_3_ProductDefinition_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096BE RID: 38590 RVA: 0x00269A78 File Offset: 0x00267C78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 270378, RefRangeEnd = 270381, XrefRangeStart = 270360, XrefRangeEnd = 270378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096BF RID: 38591 RVA: 0x00269AAC File Offset: 0x00267CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270381, XrefRangeEnd = 270383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096C0 RID: 38592 RVA: 0x00269AF0 File Offset: 0x00267CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270383, XrefRangeEnd = 270387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Send()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Send_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096C1 RID: 38593 RVA: 0x00269B24 File Offset: 0x00267D24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 270392, RefRangeEnd = 270395, XrefRangeStart = 270387, XrefRangeEnd = 270392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFairPrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_UpdateFairPrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096C2 RID: 38594 RVA: 0x00269B58 File Offset: 0x00267D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270395, XrefRangeEnd = 270402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProduct(ProductDefinition newProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newProduct);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_SetProduct_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096C3 RID: 38595 RVA: 0x00269B9C File Offset: 0x00267D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270402, XrefRangeEnd = 270405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayProduct(ProductDefinition tempProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tempProduct);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_DisplayProduct_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096C4 RID: 38596 RVA: 0x00269BE0 File Offset: 0x00267DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270405, XrefRangeEnd = 270409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeQuantity(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096C5 RID: 38597 RVA: 0x00269C20 File Offset: 0x00267E20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 270416, RefRangeEnd = 270420, XrefRangeStart = 270409, XrefRangeEnd = 270416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePriceQuantityLabel(string productName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_UpdatePriceQuantityLabel_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096C6 RID: 38598 RVA: 0x00269C64 File Offset: 0x00267E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270420, XrefRangeEnd = 270423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangePrice(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_ChangePrice_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096C7 RID: 38599 RVA: 0x00269CA4 File Offset: 0x00267EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270423, XrefRangeEnd = 270427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PriceSubmitted(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_PriceSubmitted_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096C8 RID: 38600 RVA: 0x00269CE8 File Offset: 0x00267EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270427, XrefRangeEnd = 270445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenProductSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_OpenProductSelector_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096C9 RID: 38601 RVA: 0x00269D1C File Offset: 0x00267F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270445, XrefRangeEnd = 270453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CounterofferInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096CA RID: 38602 RVA: 0x000492CD File Offset: 0x000474CD
		public CounterofferInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E30 RID: 11824
		// (get) Token: 0x060096CB RID: 38603 RVA: 0x00269D58 File Offset: 0x00267F58
		// (set) Token: 0x060096CC RID: 38604 RVA: 0x000492D6 File Offset: 0x000474D6
		public unsafe static int COUNTEROFFER_SUCCESS_XP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CounterofferInterface.NativeFieldInfoPtr_COUNTEROFFER_SUCCESS_XP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterofferInterface.NativeFieldInfoPtr_COUNTEROFFER_SUCCESS_XP, (void*)(&value));
			}
		}

		// Token: 0x17002E31 RID: 11825
		// (get) Token: 0x060096CD RID: 38605 RVA: 0x00269D74 File Offset: 0x00267F74
		// (set) Token: 0x060096CE RID: 38606 RVA: 0x000492E4 File Offset: 0x000474E4
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002E32 RID: 11826
		// (get) Token: 0x060096CF RID: 38607 RVA: 0x00269D9C File Offset: 0x00267F9C
		// (set) Token: 0x060096D0 RID: 38608 RVA: 0x000492FF File Offset: 0x000474FF
		public unsafe static int MinQuantity
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CounterofferInterface.NativeFieldInfoPtr_MinQuantity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterofferInterface.NativeFieldInfoPtr_MinQuantity, (void*)(&value));
			}
		}

		// Token: 0x17002E33 RID: 11827
		// (get) Token: 0x060096D1 RID: 38609 RVA: 0x00269DB8 File Offset: 0x00267FB8
		// (set) Token: 0x060096D2 RID: 38610 RVA: 0x0004930D File Offset: 0x0004750D
		public unsafe int MaxQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_MaxQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_MaxQuantity)) = value;
			}
		}

		// Token: 0x17002E34 RID: 11828
		// (get) Token: 0x060096D3 RID: 38611 RVA: 0x00269DE0 File Offset: 0x00267FE0
		// (set) Token: 0x060096D4 RID: 38612 RVA: 0x00049328 File Offset: 0x00047528
		public unsafe static float MinPrice
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CounterofferInterface.NativeFieldInfoPtr_MinPrice, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterofferInterface.NativeFieldInfoPtr_MinPrice, (void*)(&value));
			}
		}

		// Token: 0x17002E35 RID: 11829
		// (get) Token: 0x060096D5 RID: 38613 RVA: 0x00269DFC File Offset: 0x00267FFC
		// (set) Token: 0x060096D6 RID: 38614 RVA: 0x00049336 File Offset: 0x00047536
		public unsafe static float MaxPrice
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CounterofferInterface.NativeFieldInfoPtr_MaxPrice, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterofferInterface.NativeFieldInfoPtr_MaxPrice, (void*)(&value));
			}
		}

		// Token: 0x17002E36 RID: 11830
		// (get) Token: 0x060096D7 RID: 38615 RVA: 0x00269E18 File Offset: 0x00268018
		// (set) Token: 0x060096D8 RID: 38616 RVA: 0x00049344 File Offset: 0x00047544
		public unsafe float IconAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_IconAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_IconAlignment)) = value;
			}
		}

		// Token: 0x17002E37 RID: 11831
		// (get) Token: 0x060096D9 RID: 38617 RVA: 0x00269E40 File Offset: 0x00268040
		// (set) Token: 0x060096DA RID: 38618 RVA: 0x0004935F File Offset: 0x0004755F
		public unsafe GameObject ProductEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E38 RID: 11832
		// (get) Token: 0x060096DB RID: 38619 RVA: 0x00269E70 File Offset: 0x00268070
		// (set) Token: 0x060096DC RID: 38620 RVA: 0x0004937E File Offset: 0x0004757E
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E39 RID: 11833
		// (get) Token: 0x060096DD RID: 38621 RVA: 0x00269EA0 File Offset: 0x002680A0
		// (set) Token: 0x060096DE RID: 38622 RVA: 0x0004939D File Offset: 0x0004759D
		public unsafe Text TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E3A RID: 11834
		// (get) Token: 0x060096DF RID: 38623 RVA: 0x00269ED0 File Offset: 0x002680D0
		// (set) Token: 0x060096E0 RID: 38624 RVA: 0x000493BC File Offset: 0x000475BC
		public unsafe Button ConfirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ConfirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ConfirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E3B RID: 11835
		// (get) Token: 0x060096E1 RID: 38625 RVA: 0x00269F00 File Offset: 0x00268100
		// (set) Token: 0x060096E2 RID: 38626 RVA: 0x000493DB File Offset: 0x000475DB
		public unsafe Image ProductIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E3C RID: 11836
		// (get) Token: 0x060096E3 RID: 38627 RVA: 0x00269F30 File Offset: 0x00268130
		// (set) Token: 0x060096E4 RID: 38628 RVA: 0x000493FA File Offset: 0x000475FA
		public unsafe Text ProductLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E3D RID: 11837
		// (get) Token: 0x060096E5 RID: 38629 RVA: 0x00269F60 File Offset: 0x00268160
		// (set) Token: 0x060096E6 RID: 38630 RVA: 0x00049419 File Offset: 0x00047619
		public unsafe RectTransform ProductLabelRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductLabelRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductLabelRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E3E RID: 11838
		// (get) Token: 0x060096E7 RID: 38631 RVA: 0x00269F90 File Offset: 0x00268190
		// (set) Token: 0x060096E8 RID: 38632 RVA: 0x00049438 File Offset: 0x00047638
		public unsafe InputField PriceInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_PriceInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_PriceInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E3F RID: 11839
		// (get) Token: 0x060096E9 RID: 38633 RVA: 0x00269FC0 File Offset: 0x002681C0
		// (set) Token: 0x060096EA RID: 38634 RVA: 0x00049457 File Offset: 0x00047657
		public unsafe Text FairPriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_FairPriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_FairPriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E40 RID: 11840
		// (get) Token: 0x060096EB RID: 38635 RVA: 0x00269FF0 File Offset: 0x002681F0
		// (set) Token: 0x060096EC RID: 38636 RVA: 0x00049476 File Offset: 0x00047676
		public unsafe CounterOfferProductSelector ProductSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CounterOfferProductSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E41 RID: 11841
		// (get) Token: 0x060096ED RID: 38637 RVA: 0x0026A020 File Offset: 0x00268220
		// (set) Token: 0x060096EE RID: 38638 RVA: 0x00049495 File Offset: 0x00047695
		public unsafe Action<ProductDefinition, int, float> orderConfirmedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_orderConfirmedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ProductDefinition, int, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_orderConfirmedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E42 RID: 11842
		// (get) Token: 0x060096EF RID: 38639 RVA: 0x0026A050 File Offset: 0x00268250
		// (set) Token: 0x060096F0 RID: 38640 RVA: 0x000494B4 File Offset: 0x000476B4
		public unsafe ProductDefinition selectedProduct
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_selectedProduct);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_selectedProduct), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E43 RID: 11843
		// (get) Token: 0x060096F1 RID: 38641 RVA: 0x0026A080 File Offset: 0x00268280
		// (set) Token: 0x060096F2 RID: 38642 RVA: 0x000494D3 File Offset: 0x000476D3
		public unsafe int quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_quantity)) = value;
			}
		}

		// Token: 0x17002E44 RID: 11844
		// (get) Token: 0x060096F3 RID: 38643 RVA: 0x0026A0A8 File Offset: 0x002682A8
		// (set) Token: 0x060096F4 RID: 38644 RVA: 0x000494EE File Offset: 0x000476EE
		public unsafe float price
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_price);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_price)) = value;
			}
		}

		// Token: 0x17002E45 RID: 11845
		// (get) Token: 0x060096F5 RID: 38645 RVA: 0x0026A0D0 File Offset: 0x002682D0
		// (set) Token: 0x060096F6 RID: 38646 RVA: 0x00049509 File Offset: 0x00047709
		public unsafe Dictionary<ProductDefinition, RectTransform> productEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_productEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ProductDefinition, RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_productEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E46 RID: 11846
		// (get) Token: 0x060096F7 RID: 38647 RVA: 0x0026A100 File Offset: 0x00268300
		// (set) Token: 0x060096F8 RID: 38648 RVA: 0x00049528 File Offset: 0x00047728
		public unsafe bool mouseUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_mouseUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_mouseUp)) = value;
			}
		}

		// Token: 0x17002E47 RID: 11847
		// (get) Token: 0x060096F9 RID: 38649 RVA: 0x0026A128 File Offset: 0x00268328
		// (set) Token: 0x060096FA RID: 38650 RVA: 0x00049543 File Offset: 0x00047743
		public unsafe MSGConversation conversation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_conversation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_conversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006596 RID: 26006
		private static readonly IntPtr NativeFieldInfoPtr_COUNTEROFFER_SUCCESS_XP;

		// Token: 0x04006597 RID: 26007
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006598 RID: 26008
		private static readonly IntPtr NativeFieldInfoPtr_MinQuantity;

		// Token: 0x04006599 RID: 26009
		private static readonly IntPtr NativeFieldInfoPtr_MaxQuantity;

		// Token: 0x0400659A RID: 26010
		private static readonly IntPtr NativeFieldInfoPtr_MinPrice;

		// Token: 0x0400659B RID: 26011
		private static readonly IntPtr NativeFieldInfoPtr_MaxPrice;

		// Token: 0x0400659C RID: 26012
		private static readonly IntPtr NativeFieldInfoPtr_IconAlignment;

		// Token: 0x0400659D RID: 26013
		private static readonly IntPtr NativeFieldInfoPtr_ProductEntryPrefab;

		// Token: 0x0400659E RID: 26014
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400659F RID: 26015
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x040065A0 RID: 26016
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmButton;

		// Token: 0x040065A1 RID: 26017
		private static readonly IntPtr NativeFieldInfoPtr_ProductIcon;

		// Token: 0x040065A2 RID: 26018
		private static readonly IntPtr NativeFieldInfoPtr_ProductLabel;

		// Token: 0x040065A3 RID: 26019
		private static readonly IntPtr NativeFieldInfoPtr_ProductLabelRect;

		// Token: 0x040065A4 RID: 26020
		private static readonly IntPtr NativeFieldInfoPtr_PriceInput;

		// Token: 0x040065A5 RID: 26021
		private static readonly IntPtr NativeFieldInfoPtr_FairPriceLabel;

		// Token: 0x040065A6 RID: 26022
		private static readonly IntPtr NativeFieldInfoPtr_ProductSelector;

		// Token: 0x040065A7 RID: 26023
		private static readonly IntPtr NativeFieldInfoPtr_orderConfirmedCallback;

		// Token: 0x040065A8 RID: 26024
		private static readonly IntPtr NativeFieldInfoPtr_selectedProduct;

		// Token: 0x040065A9 RID: 26025
		private static readonly IntPtr NativeFieldInfoPtr_quantity;

		// Token: 0x040065AA RID: 26026
		private static readonly IntPtr NativeFieldInfoPtr_price;

		// Token: 0x040065AB RID: 26027
		private static readonly IntPtr NativeFieldInfoPtr_productEntries;

		// Token: 0x040065AC RID: 26028
		private static readonly IntPtr NativeFieldInfoPtr_mouseUp;

		// Token: 0x040065AD RID: 26029
		private static readonly IntPtr NativeFieldInfoPtr_conversation;

		// Token: 0x040065AE RID: 26030
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040065AF RID: 26031
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x040065B0 RID: 26032
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040065B1 RID: 26033
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040065B2 RID: 26034
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040065B3 RID: 26035
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ProductDefinition_Int32_Single_MSGConversation_Action_3_ProductDefinition_Int32_Single_0;

		// Token: 0x040065B4 RID: 26036
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040065B5 RID: 26037
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x040065B6 RID: 26038
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Void_0;

		// Token: 0x040065B7 RID: 26039
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFairPrice_Private_Void_0;

		// Token: 0x040065B8 RID: 26040
		private static readonly IntPtr NativeMethodInfoPtr_SetProduct_Private_Void_ProductDefinition_0;

		// Token: 0x040065B9 RID: 26041
		private static readonly IntPtr NativeMethodInfoPtr_DisplayProduct_Private_Void_ProductDefinition_0;

		// Token: 0x040065BA RID: 26042
		private static readonly IntPtr NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_0;

		// Token: 0x040065BB RID: 26043
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePriceQuantityLabel_Private_Void_String_0;

		// Token: 0x040065BC RID: 26044
		private static readonly IntPtr NativeMethodInfoPtr_ChangePrice_Public_Void_Single_0;

		// Token: 0x040065BD RID: 26045
		private static readonly IntPtr NativeMethodInfoPtr_PriceSubmitted_Public_Void_String_0;

		// Token: 0x040065BE RID: 26046
		private static readonly IntPtr NativeMethodInfoPtr_OpenProductSelector_Public_Void_0;

		// Token: 0x040065BF RID: 26047
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
