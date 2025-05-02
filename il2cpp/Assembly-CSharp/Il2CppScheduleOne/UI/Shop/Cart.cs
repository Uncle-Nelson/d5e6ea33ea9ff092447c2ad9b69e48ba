using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000705 RID: 1797
	public class Cart : MonoBehaviour
	{
		// Token: 0x0600A169 RID: 41321 RVA: 0x00289B54 File Offset: 0x00287D54
		// Note: this type is marked as 'beforefieldinit'.
		static Cart()
		{
			Il2CppClassPointerStore<Cart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "Cart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cart>.NativeClassPtr);
			Cart.NativeFieldInfoPtr_Shop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "Shop");
			Cart.NativeFieldInfoPtr_CartIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "CartIcon");
			Cart.NativeFieldInfoPtr_ViewCartText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "ViewCartText");
			Cart.NativeFieldInfoPtr_CartEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "CartEntryContainer");
			Cart.NativeFieldInfoPtr_ProblemText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "ProblemText");
			Cart.NativeFieldInfoPtr_WarningText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "WarningText");
			Cart.NativeFieldInfoPtr_BuyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "BuyButton");
			Cart.NativeFieldInfoPtr_CartContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "CartContainer");
			Cart.NativeFieldInfoPtr_CartArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "CartArea");
			Cart.NativeFieldInfoPtr_TotalText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "TotalText");
			Cart.NativeFieldInfoPtr_LoadVehicleToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "LoadVehicleToggle");
			Cart.NativeFieldInfoPtr_EntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "EntryPrefab");
			Cart.NativeFieldInfoPtr_cartDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "cartDictionary");
			Cart.NativeFieldInfoPtr_cartIconBop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "cartIconBop");
			Cart.NativeFieldInfoPtr_cartEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "cartEntries");
			Cart.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683042);
			Cart.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683043);
			Cart.NativeMethodInfoPtr_AddItem_Public_Void_ShopListing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683044);
			Cart.NativeMethodInfoPtr_RemoveItem_Public_Void_ShopListing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683045);
			Cart.NativeMethodInfoPtr_ClearCart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683046);
			Cart.NativeMethodInfoPtr_GetCartCount_Public_Int32_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683047);
			Cart.NativeMethodInfoPtr_BopCartIcon_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683048);
			Cart.NativeMethodInfoPtr_CanPlayerAffordCart_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683049);
			Cart.NativeMethodInfoPtr_Buy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683050);
			Cart.NativeMethodInfoPtr_UpdateEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683051);
			Cart.NativeMethodInfoPtr_UpdateTotal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683052);
			Cart.NativeMethodInfoPtr_UpdateProblem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683053);
			Cart.NativeMethodInfoPtr_CanCheckout_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683054);
			Cart.NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683055);
			Cart.NativeMethodInfoPtr_UpdateViewCartText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683056);
			Cart.NativeMethodInfoPtr_UpdateLoadVehicleToggle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683057);
			Cart.NativeMethodInfoPtr_GetItemSum_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683058);
			Cart.NativeMethodInfoPtr_GetPriceSum_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683059);
			Cart.NativeMethodInfoPtr_GetEntry_Private_CartEntry_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683060);
			Cart.NativeMethodInfoPtr_IsMouseOverMenuArea_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683061);
			Cart.NativeMethodInfoPtr_GetTotalSlotRequirement_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683062);
			Cart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683063);
			Cart.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683064);
		}

		// Token: 0x0600A16A RID: 41322 RVA: 0x00289E7C File Offset: 0x0028807C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283803, XrefRangeEnd = 283812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cart.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A16B RID: 41323 RVA: 0x00289EB8 File Offset: 0x002880B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283812, XrefRangeEnd = 283822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cart.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A16C RID: 41324 RVA: 0x00289EF4 File Offset: 0x002880F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 283859, RefRangeEnd = 283864, XrefRangeStart = 283822, XrefRangeEnd = 283859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(ShopListing listing, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_AddItem_Public_Void_ShopListing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A16D RID: 41325 RVA: 0x00289F44 File Offset: 0x00288144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283864, XrefRangeEnd = 283887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem(ShopListing listing, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_RemoveItem_Public_Void_ShopListing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A16E RID: 41326 RVA: 0x00289F94 File Offset: 0x00288194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283909, RefRangeEnd = 283910, XrefRangeStart = 283887, XrefRangeEnd = 283909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_ClearCart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A16F RID: 41327 RVA: 0x00289FC8 File Offset: 0x002881C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283910, XrefRangeEnd = 283914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCartCount(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetCartCount_Public_Int32_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A170 RID: 41328 RVA: 0x0028A018 File Offset: 0x00288218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283922, RefRangeEnd = 283923, XrefRangeStart = 283914, XrefRangeEnd = 283922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BopCartIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_BopCartIcon_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A171 RID: 41329 RVA: 0x0028A04C File Offset: 0x0028824C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283923, XrefRangeEnd = 283925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanPlayerAffordCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_CanPlayerAffordCart_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A172 RID: 41330 RVA: 0x0028A088 File Offset: 0x00288288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283925, XrefRangeEnd = 283982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Buy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_Buy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A173 RID: 41331 RVA: 0x0028A0BC File Offset: 0x002882BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 284054, RefRangeEnd = 284059, XrefRangeStart = 283982, XrefRangeEnd = 284054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UpdateEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A174 RID: 41332 RVA: 0x0028A0F0 File Offset: 0x002882F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 284083, RefRangeEnd = 284087, XrefRangeStart = 284059, XrefRangeEnd = 284083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTotal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UpdateTotal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A175 RID: 41333 RVA: 0x0028A124 File Offset: 0x00288324
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 284097, RefRangeEnd = 284100, XrefRangeStart = 284087, XrefRangeEnd = 284097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateProblem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UpdateProblem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A176 RID: 41334 RVA: 0x0028A158 File Offset: 0x00288358
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284117, RefRangeEnd = 284119, XrefRangeStart = 284100, XrefRangeEnd = 284117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCheckout(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_CanCheckout_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600A177 RID: 41335 RVA: 0x0028A1B0 File Offset: 0x002883B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284137, RefRangeEnd = 284138, XrefRangeStart = 284119, XrefRangeEnd = 284137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetWarning(out string warning)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			warning = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600A178 RID: 41336 RVA: 0x0028A208 File Offset: 0x00288408
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 284160, RefRangeEnd = 284165, XrefRangeStart = 284138, XrefRangeEnd = 284160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateViewCartText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UpdateViewCartText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A179 RID: 41337 RVA: 0x0028A23C File Offset: 0x0028843C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284165, XrefRangeEnd = 284173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLoadVehicleToggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UpdateLoadVehicleToggle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A17A RID: 41338 RVA: 0x0028A270 File Offset: 0x00288470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284173, XrefRangeEnd = 284187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetItemSum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetItemSum_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A17B RID: 41339 RVA: 0x0028A2AC File Offset: 0x002884AC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 284204, RefRangeEnd = 284212, XrefRangeStart = 284187, XrefRangeEnd = 284204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPriceSum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetPriceSum_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A17C RID: 41340 RVA: 0x0028A2E8 File Offset: 0x002884E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284212, XrefRangeEnd = 284227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartEntry GetEntry(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetEntry_Private_CartEntry_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CartEntry>(intPtr3) : null;
		}

		// Token: 0x0600A17D RID: 41341 RVA: 0x0028A338 File Offset: 0x00288538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284227, XrefRangeEnd = 284234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMouseOverMenuArea()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_IsMouseOverMenuArea_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A17E RID: 41342 RVA: 0x0028A374 File Offset: 0x00288574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284234, XrefRangeEnd = 284248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalSlotRequirement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetTotalSlotRequirement_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A17F RID: 41343 RVA: 0x0028A3B0 File Offset: 0x002885B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284248, XrefRangeEnd = 284263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cart() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cart>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A180 RID: 41344 RVA: 0x0028A3EC File Offset: 0x002885EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284263, XrefRangeEnd = 284268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A181 RID: 41345 RVA: 0x0004F690 File Offset: 0x0004D890
		public Cart(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031C1 RID: 12737
		// (get) Token: 0x0600A182 RID: 41346 RVA: 0x0028A42C File Offset: 0x0028862C
		// (set) Token: 0x0600A183 RID: 41347 RVA: 0x0004F699 File Offset: 0x0004D899
		public unsafe ShopInterface Shop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_Shop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_Shop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C2 RID: 12738
		// (get) Token: 0x0600A184 RID: 41348 RVA: 0x0028A45C File Offset: 0x0028865C
		// (set) Token: 0x0600A185 RID: 41349 RVA: 0x0004F6B8 File Offset: 0x0004D8B8
		public unsafe Image CartIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C3 RID: 12739
		// (get) Token: 0x0600A186 RID: 41350 RVA: 0x0028A48C File Offset: 0x0028868C
		// (set) Token: 0x0600A187 RID: 41351 RVA: 0x0004F6D7 File Offset: 0x0004D8D7
		public unsafe TextMeshProUGUI ViewCartText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_ViewCartText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_ViewCartText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C4 RID: 12740
		// (get) Token: 0x0600A188 RID: 41352 RVA: 0x0028A4BC File Offset: 0x002886BC
		// (set) Token: 0x0600A189 RID: 41353 RVA: 0x0004F6F6 File Offset: 0x0004D8F6
		public unsafe RectTransform CartEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C5 RID: 12741
		// (get) Token: 0x0600A18A RID: 41354 RVA: 0x0028A4EC File Offset: 0x002886EC
		// (set) Token: 0x0600A18B RID: 41355 RVA: 0x0004F715 File Offset: 0x0004D915
		public unsafe TextMeshProUGUI ProblemText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_ProblemText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_ProblemText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C6 RID: 12742
		// (get) Token: 0x0600A18C RID: 41356 RVA: 0x0028A51C File Offset: 0x0028871C
		// (set) Token: 0x0600A18D RID: 41357 RVA: 0x0004F734 File Offset: 0x0004D934
		public unsafe TextMeshProUGUI WarningText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_WarningText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_WarningText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C7 RID: 12743
		// (get) Token: 0x0600A18E RID: 41358 RVA: 0x0028A54C File Offset: 0x0028874C
		// (set) Token: 0x0600A18F RID: 41359 RVA: 0x0004F753 File Offset: 0x0004D953
		public unsafe Button BuyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_BuyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_BuyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C8 RID: 12744
		// (get) Token: 0x0600A190 RID: 41360 RVA: 0x0028A57C File Offset: 0x0028877C
		// (set) Token: 0x0600A191 RID: 41361 RVA: 0x0004F772 File Offset: 0x0004D972
		public unsafe RectTransform CartContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C9 RID: 12745
		// (get) Token: 0x0600A192 RID: 41362 RVA: 0x0028A5AC File Offset: 0x002887AC
		// (set) Token: 0x0600A193 RID: 41363 RVA: 0x0004F791 File Offset: 0x0004D991
		public unsafe Image CartArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031CA RID: 12746
		// (get) Token: 0x0600A194 RID: 41364 RVA: 0x0028A5DC File Offset: 0x002887DC
		// (set) Token: 0x0600A195 RID: 41365 RVA: 0x0004F7B0 File Offset: 0x0004D9B0
		public unsafe TextMeshProUGUI TotalText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_TotalText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_TotalText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031CB RID: 12747
		// (get) Token: 0x0600A196 RID: 41366 RVA: 0x0028A60C File Offset: 0x0028880C
		// (set) Token: 0x0600A197 RID: 41367 RVA: 0x0004F7CF File Offset: 0x0004D9CF
		public unsafe Toggle LoadVehicleToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_LoadVehicleToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_LoadVehicleToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031CC RID: 12748
		// (get) Token: 0x0600A198 RID: 41368 RVA: 0x0028A63C File Offset: 0x0028883C
		// (set) Token: 0x0600A199 RID: 41369 RVA: 0x0004F7EE File Offset: 0x0004D9EE
		public unsafe CartEntry EntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_EntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_EntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031CD RID: 12749
		// (get) Token: 0x0600A19A RID: 41370 RVA: 0x0028A66C File Offset: 0x0028886C
		// (set) Token: 0x0600A19B RID: 41371 RVA: 0x0004F80D File Offset: 0x0004DA0D
		public unsafe Dictionary<ShopListing, int> cartDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ShopListing, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031CE RID: 12750
		// (get) Token: 0x0600A19C RID: 41372 RVA: 0x0028A69C File Offset: 0x0028889C
		// (set) Token: 0x0600A19D RID: 41373 RVA: 0x0004F82C File Offset: 0x0004DA2C
		public unsafe Coroutine cartIconBop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartIconBop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartIconBop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031CF RID: 12751
		// (get) Token: 0x0600A19E RID: 41374 RVA: 0x0028A6CC File Offset: 0x002888CC
		// (set) Token: 0x0600A19F RID: 41375 RVA: 0x0004F84B File Offset: 0x0004DA4B
		public unsafe List<CartEntry> cartEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CartEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006C35 RID: 27701
		private static readonly IntPtr NativeFieldInfoPtr_Shop;

		// Token: 0x04006C36 RID: 27702
		private static readonly IntPtr NativeFieldInfoPtr_CartIcon;

		// Token: 0x04006C37 RID: 27703
		private static readonly IntPtr NativeFieldInfoPtr_ViewCartText;

		// Token: 0x04006C38 RID: 27704
		private static readonly IntPtr NativeFieldInfoPtr_CartEntryContainer;

		// Token: 0x04006C39 RID: 27705
		private static readonly IntPtr NativeFieldInfoPtr_ProblemText;

		// Token: 0x04006C3A RID: 27706
		private static readonly IntPtr NativeFieldInfoPtr_WarningText;

		// Token: 0x04006C3B RID: 27707
		private static readonly IntPtr NativeFieldInfoPtr_BuyButton;

		// Token: 0x04006C3C RID: 27708
		private static readonly IntPtr NativeFieldInfoPtr_CartContainer;

		// Token: 0x04006C3D RID: 27709
		private static readonly IntPtr NativeFieldInfoPtr_CartArea;

		// Token: 0x04006C3E RID: 27710
		private static readonly IntPtr NativeFieldInfoPtr_TotalText;

		// Token: 0x04006C3F RID: 27711
		private static readonly IntPtr NativeFieldInfoPtr_LoadVehicleToggle;

		// Token: 0x04006C40 RID: 27712
		private static readonly IntPtr NativeFieldInfoPtr_EntryPrefab;

		// Token: 0x04006C41 RID: 27713
		private static readonly IntPtr NativeFieldInfoPtr_cartDictionary;

		// Token: 0x04006C42 RID: 27714
		private static readonly IntPtr NativeFieldInfoPtr_cartIconBop;

		// Token: 0x04006C43 RID: 27715
		private static readonly IntPtr NativeFieldInfoPtr_cartEntries;

		// Token: 0x04006C44 RID: 27716
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006C45 RID: 27717
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006C46 RID: 27718
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Void_ShopListing_Int32_0;

		// Token: 0x04006C47 RID: 27719
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_ShopListing_Int32_0;

		// Token: 0x04006C48 RID: 27720
		private static readonly IntPtr NativeMethodInfoPtr_ClearCart_Public_Void_0;

		// Token: 0x04006C49 RID: 27721
		private static readonly IntPtr NativeMethodInfoPtr_GetCartCount_Public_Int32_ShopListing_0;

		// Token: 0x04006C4A RID: 27722
		private static readonly IntPtr NativeMethodInfoPtr_BopCartIcon_Public_Void_0;

		// Token: 0x04006C4B RID: 27723
		private static readonly IntPtr NativeMethodInfoPtr_CanPlayerAffordCart_Public_Boolean_0;

		// Token: 0x04006C4C RID: 27724
		private static readonly IntPtr NativeMethodInfoPtr_Buy_Public_Void_0;

		// Token: 0x04006C4D RID: 27725
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEntries_Private_Void_0;

		// Token: 0x04006C4E RID: 27726
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTotal_Private_Void_0;

		// Token: 0x04006C4F RID: 27727
		private static readonly IntPtr NativeMethodInfoPtr_UpdateProblem_Private_Void_0;

		// Token: 0x04006C50 RID: 27728
		private static readonly IntPtr NativeMethodInfoPtr_CanCheckout_Private_Boolean_byref_String_0;

		// Token: 0x04006C51 RID: 27729
		private static readonly IntPtr NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0;

		// Token: 0x04006C52 RID: 27730
		private static readonly IntPtr NativeMethodInfoPtr_UpdateViewCartText_Private_Void_0;

		// Token: 0x04006C53 RID: 27731
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLoadVehicleToggle_Private_Void_0;

		// Token: 0x04006C54 RID: 27732
		private static readonly IntPtr NativeMethodInfoPtr_GetItemSum_Private_Int32_0;

		// Token: 0x04006C55 RID: 27733
		private static readonly IntPtr NativeMethodInfoPtr_GetPriceSum_Private_Single_0;

		// Token: 0x04006C56 RID: 27734
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Private_CartEntry_ShopListing_0;

		// Token: 0x04006C57 RID: 27735
		private static readonly IntPtr NativeMethodInfoPtr_IsMouseOverMenuArea_Private_Boolean_0;

		// Token: 0x04006C58 RID: 27736
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalSlotRequirement_Public_Int32_0;

		// Token: 0x04006C59 RID: 27737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006C5A RID: 27738
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000BB3 RID: 2995
		[ObfuscatedName("ScheduleOne.UI.Shop.Cart+<<BopCartIcon>g__Routine|21_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DD34 RID: 56628 RVA: 0x00344210 File Offset: 0x00342410
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique()
			{
				Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Cart>.NativeClassPtr, "<<BopCartIcon>g__Routine|21_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr);
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<>1__state");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<>2__current");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<>4__this");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__startScale_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<startScale>5__2");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__endScale_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<endScale>5__3");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__lerpTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<lerpTime>5__4");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<i>5__5");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, 100683065);
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, 100683066);
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, 100683067);
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, 100683068);
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, 100683069);
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, 100683070);
			}

			// Token: 0x0600DD35 RID: 56629 RVA: 0x00344340 File Offset: 0x00342540
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD36 RID: 56630 RVA: 0x00344388 File Offset: 0x00342588
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD37 RID: 56631 RVA: 0x003443BC File Offset: 0x003425BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283782, XrefRangeEnd = 283798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004495 RID: 17557
			// (get) Token: 0x0600DD38 RID: 56632 RVA: 0x003443F8 File Offset: 0x003425F8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD39 RID: 56633 RVA: 0x00344438 File Offset: 0x00342638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283798, XrefRangeEnd = 283803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004496 RID: 17558
			// (get) Token: 0x0600DD3A RID: 56634 RVA: 0x0034446C File Offset: 0x0034266C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD3B RID: 56635 RVA: 0x0006BCE3 File Offset: 0x00069EE3
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700448E RID: 17550
			// (get) Token: 0x0600DD3C RID: 56636 RVA: 0x003444AC File Offset: 0x003426AC
			// (set) Token: 0x0600DD3D RID: 56637 RVA: 0x0006BCEC File Offset: 0x00069EEC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700448F RID: 17551
			// (get) Token: 0x0600DD3E RID: 56638 RVA: 0x003444D4 File Offset: 0x003426D4
			// (set) Token: 0x0600DD3F RID: 56639 RVA: 0x0006BD07 File Offset: 0x00069F07
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004490 RID: 17552
			// (get) Token: 0x0600DD40 RID: 56640 RVA: 0x00344504 File Offset: 0x00342704
			// (set) Token: 0x0600DD41 RID: 56641 RVA: 0x0006BD26 File Offset: 0x00069F26
			public unsafe Cart __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cart>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004491 RID: 17553
			// (get) Token: 0x0600DD42 RID: 56642 RVA: 0x00344534 File Offset: 0x00342734
			// (set) Token: 0x0600DD43 RID: 56643 RVA: 0x0006BD45 File Offset: 0x00069F45
			public unsafe Vector3 _startScale_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__startScale_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__startScale_5__2)) = value;
				}
			}

			// Token: 0x17004492 RID: 17554
			// (get) Token: 0x0600DD44 RID: 56644 RVA: 0x0034455C File Offset: 0x0034275C
			// (set) Token: 0x0600DD45 RID: 56645 RVA: 0x0006BD60 File Offset: 0x00069F60
			public unsafe Vector3 _endScale_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__endScale_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__endScale_5__3)) = value;
				}
			}

			// Token: 0x17004493 RID: 17555
			// (get) Token: 0x0600DD46 RID: 56646 RVA: 0x00344584 File Offset: 0x00342784
			// (set) Token: 0x0600DD47 RID: 56647 RVA: 0x0006BD7B File Offset: 0x00069F7B
			public unsafe float _lerpTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__lerpTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__lerpTime_5__4)) = value;
				}
			}

			// Token: 0x17004494 RID: 17556
			// (get) Token: 0x0600DD48 RID: 56648 RVA: 0x003445AC File Offset: 0x003427AC
			// (set) Token: 0x0600DD49 RID: 56649 RVA: 0x0006BD96 File Offset: 0x00069F96
			public unsafe float _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x04009432 RID: 37938
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009433 RID: 37939
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009434 RID: 37940
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009435 RID: 37941
			private static readonly IntPtr NativeFieldInfoPtr__startScale_5__2;

			// Token: 0x04009436 RID: 37942
			private static readonly IntPtr NativeFieldInfoPtr__endScale_5__3;

			// Token: 0x04009437 RID: 37943
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__4;

			// Token: 0x04009438 RID: 37944
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x04009439 RID: 37945
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400943A RID: 37946
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400943B RID: 37947
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400943C RID: 37948
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400943D RID: 37949
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400943E RID: 37950
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BB4 RID: 2996
		[ObfuscatedName("ScheduleOne.UI.Shop.Cart+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD4A RID: 56650 RVA: 0x003445D4 File Offset: 0x003427D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<Cart.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Cart>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cart.__c__DisplayClass33_0>.NativeClassPtr);
				Cart.__c__DisplayClass33_0.NativeFieldInfoPtr_listing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.__c__DisplayClass33_0>.NativeClassPtr, "listing");
				Cart.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.__c__DisplayClass33_0>.NativeClassPtr, 100683071);
				Cart.__c__DisplayClass33_0.NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_CartEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.__c__DisplayClass33_0>.NativeClassPtr, 100683072);
			}

			// Token: 0x0600DD4B RID: 56651 RVA: 0x0034463C File Offset: 0x0034283C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cart.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD4C RID: 56652 RVA: 0x00344678 File Offset: 0x00342878
			[CallerCount(0)]
			public unsafe bool _GetEntry_b__0(CartEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.__c__DisplayClass33_0.NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_CartEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD4D RID: 56653 RVA: 0x0006BDB1 File Offset: 0x00069FB1
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004497 RID: 17559
			// (get) Token: 0x0600DD4E RID: 56654 RVA: 0x003446C8 File Offset: 0x003428C8
			// (set) Token: 0x0600DD4F RID: 56655 RVA: 0x0006BDBA File Offset: 0x00069FBA
			public unsafe ShopListing listing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.__c__DisplayClass33_0.NativeFieldInfoPtr_listing);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.__c__DisplayClass33_0.NativeFieldInfoPtr_listing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400943F RID: 37951
			private static readonly IntPtr NativeFieldInfoPtr_listing;

			// Token: 0x04009440 RID: 37952
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009441 RID: 37953
			private static readonly IntPtr NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_CartEntry_0;
		}
	}
}
