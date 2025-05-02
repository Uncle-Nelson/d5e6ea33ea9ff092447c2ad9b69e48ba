using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x0200070C RID: 1804
	public class ListingUI : MonoBehaviour
	{
		// Token: 0x0600A1E9 RID: 41449 RVA: 0x0028B650 File Offset: 0x00289850
		// Note: this type is marked as 'beforefieldinit'.
		static ListingUI()
		{
			Il2CppClassPointerStore<ListingUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ListingUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListingUI>.NativeClassPtr);
			ListingUI.NativeFieldInfoPtr_PriceLabelColor_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "PriceLabelColor_Normal");
			ListingUI.NativeFieldInfoPtr_PriceLabelColor_NoStock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "PriceLabelColor_NoStock");
			ListingUI.NativeFieldInfoPtr__Listing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "<Listing>k__BackingField");
			ListingUI.NativeFieldInfoPtr_StockLabelDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "StockLabelDefault");
			ListingUI.NativeFieldInfoPtr_StockLabelNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "StockLabelNone");
			ListingUI.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "Icon");
			ListingUI.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "NameLabel");
			ListingUI.NativeFieldInfoPtr_PriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "PriceLabel");
			ListingUI.NativeFieldInfoPtr_StockLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "StockLabel");
			ListingUI.NativeFieldInfoPtr_LockedContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "LockedContainer");
			ListingUI.NativeFieldInfoPtr_BuyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "BuyButton");
			ListingUI.NativeFieldInfoPtr_DropdownButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "DropdownButton");
			ListingUI.NativeFieldInfoPtr_Trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "Trigger");
			ListingUI.NativeFieldInfoPtr_DetailPanelAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "DetailPanelAnchor");
			ListingUI.NativeFieldInfoPtr_DropdownAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "DropdownAnchor");
			ListingUI.NativeFieldInfoPtr_TopDropdownAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "TopDropdownAnchor");
			ListingUI.NativeFieldInfoPtr_hoverStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "hoverStart");
			ListingUI.NativeFieldInfoPtr_hoverEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "hoverEnd");
			ListingUI.NativeFieldInfoPtr_onClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "onClicked");
			ListingUI.NativeFieldInfoPtr_onDropdownClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "onDropdownClicked");
			ListingUI.NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683106);
			ListingUI.NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683107);
			ListingUI.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683108);
			ListingUI.NativeMethodInfoPtr_GetIconCopy_Public_Virtual_New_RectTransform_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683109);
			ListingUI.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683110);
			ListingUI.NativeMethodInfoPtr_Clicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683111);
			ListingUI.NativeMethodInfoPtr_DropdownClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683112);
			ListingUI.NativeMethodInfoPtr_HoverStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683113);
			ListingUI.NativeMethodInfoPtr_HoverEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683114);
			ListingUI.NativeMethodInfoPtr_StockChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683115);
			ListingUI.NativeMethodInfoPtr_UpdatePrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683116);
			ListingUI.NativeMethodInfoPtr_UpdateStock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683117);
			ListingUI.NativeMethodInfoPtr_UpdateButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683118);
			ListingUI.NativeMethodInfoPtr_CanAddToCart_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683119);
			ListingUI.NativeMethodInfoPtr_UpdateLockStatus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683120);
			ListingUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683121);
			ListingUI.NativeMethodInfoPtr__Initialize_b__23_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683123);
			ListingUI.NativeMethodInfoPtr__Initialize_b__23_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683124);
		}

		// Token: 0x170031F7 RID: 12791
		// (get) Token: 0x0600A1EA RID: 41450 RVA: 0x0028B978 File Offset: 0x00289B78
		// (set) Token: 0x0600A1EB RID: 41451 RVA: 0x0028B9B8 File Offset: 0x00289BB8
		public unsafe ShopListing Listing
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A1EC RID: 41452 RVA: 0x0028B9FC File Offset: 0x00289BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284496, XrefRangeEnd = 284566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListingUI.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ShopListing_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1ED RID: 41453 RVA: 0x0028BA4C File Offset: 0x00289C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284566, XrefRangeEnd = 284577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RectTransform GetIconCopy(RectTransform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListingUI.NativeMethodInfoPtr_GetIconCopy_Public_Virtual_New_RectTransform_RectTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x0600A1EE RID: 41454 RVA: 0x0028BAA8 File Offset: 0x00289CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284577, XrefRangeEnd = 284581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1EF RID: 41455 RVA: 0x0028BADC File Offset: 0x00289CDC
		[CallerCount(0)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_Clicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1F0 RID: 41456 RVA: 0x0028BB10 File Offset: 0x00289D10
		[CallerCount(0)]
		public unsafe void DropdownClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_DropdownClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1F1 RID: 41457 RVA: 0x0028BB44 File Offset: 0x00289D44
		[CallerCount(0)]
		public unsafe void HoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_HoverStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1F2 RID: 41458 RVA: 0x0028BB78 File Offset: 0x00289D78
		[CallerCount(0)]
		public unsafe void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_HoverEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1F3 RID: 41459 RVA: 0x0028BBAC File Offset: 0x00289DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284581, XrefRangeEnd = 284584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StockChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_StockChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1F4 RID: 41460 RVA: 0x0028BBE0 File Offset: 0x00289DE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284590, RefRangeEnd = 284592, XrefRangeStart = 284584, XrefRangeEnd = 284590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_UpdatePrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1F5 RID: 41461 RVA: 0x0028BC14 File Offset: 0x00289E14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284609, RefRangeEnd = 284611, XrefRangeStart = 284592, XrefRangeEnd = 284609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_UpdateStock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1F6 RID: 41462 RVA: 0x0028BC48 File Offset: 0x00289E48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284617, RefRangeEnd = 284619, XrefRangeStart = 284611, XrefRangeEnd = 284617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_UpdateButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1F7 RID: 41463 RVA: 0x0028BC7C File Offset: 0x00289E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284619, XrefRangeEnd = 284620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanAddToCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_CanAddToCart_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A1F8 RID: 41464 RVA: 0x0028BCB8 File Offset: 0x00289EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284620, XrefRangeEnd = 284624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLockStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_UpdateLockStatus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1F9 RID: 41465 RVA: 0x0028BCEC File Offset: 0x00289EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284624, XrefRangeEnd = 284625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListingUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListingUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1FA RID: 41466 RVA: 0x0028BD28 File Offset: 0x00289F28
		[CallerCount(0)]
		public unsafe void _Initialize_b__23_0(BaseEventData <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr__Initialize_b__23_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1FB RID: 41467 RVA: 0x0028BD6C File Offset: 0x00289F6C
		[CallerCount(0)]
		public unsafe void _Initialize_b__23_1(BaseEventData <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr__Initialize_b__23_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1FC RID: 41468 RVA: 0x0004FA58 File Offset: 0x0004DC58
		public ListingUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031E3 RID: 12771
		// (get) Token: 0x0600A1FD RID: 41469 RVA: 0x0028BDB0 File Offset: 0x00289FB0
		// (set) Token: 0x0600A1FE RID: 41470 RVA: 0x0004FA61 File Offset: 0x0004DC61
		public unsafe static Color32 PriceLabelColor_Normal
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(ListingUI.NativeFieldInfoPtr_PriceLabelColor_Normal, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ListingUI.NativeFieldInfoPtr_PriceLabelColor_Normal, (void*)(&value));
			}
		}

		// Token: 0x170031E4 RID: 12772
		// (get) Token: 0x0600A1FF RID: 41471 RVA: 0x0028BDCC File Offset: 0x00289FCC
		// (set) Token: 0x0600A200 RID: 41472 RVA: 0x0004FA6F File Offset: 0x0004DC6F
		public unsafe static Color32 PriceLabelColor_NoStock
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(ListingUI.NativeFieldInfoPtr_PriceLabelColor_NoStock, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ListingUI.NativeFieldInfoPtr_PriceLabelColor_NoStock, (void*)(&value));
			}
		}

		// Token: 0x170031E5 RID: 12773
		// (get) Token: 0x0600A201 RID: 41473 RVA: 0x0028BDE8 File Offset: 0x00289FE8
		// (set) Token: 0x0600A202 RID: 41474 RVA: 0x0004FA7D File Offset: 0x0004DC7D
		public unsafe ShopListing _Listing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr__Listing_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr__Listing_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031E6 RID: 12774
		// (get) Token: 0x0600A203 RID: 41475 RVA: 0x0028BE18 File Offset: 0x0028A018
		// (set) Token: 0x0600A204 RID: 41476 RVA: 0x0004FA9C File Offset: 0x0004DC9C
		public unsafe Color32 StockLabelDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabelDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabelDefault)) = value;
			}
		}

		// Token: 0x170031E7 RID: 12775
		// (get) Token: 0x0600A205 RID: 41477 RVA: 0x0028BE40 File Offset: 0x0028A040
		// (set) Token: 0x0600A206 RID: 41478 RVA: 0x0004FAB7 File Offset: 0x0004DCB7
		public unsafe Color32 StockLabelNone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabelNone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabelNone)) = value;
			}
		}

		// Token: 0x170031E8 RID: 12776
		// (get) Token: 0x0600A207 RID: 41479 RVA: 0x0028BE68 File Offset: 0x0028A068
		// (set) Token: 0x0600A208 RID: 41480 RVA: 0x0004FAD2 File Offset: 0x0004DCD2
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031E9 RID: 12777
		// (get) Token: 0x0600A209 RID: 41481 RVA: 0x0028BE98 File Offset: 0x0028A098
		// (set) Token: 0x0600A20A RID: 41482 RVA: 0x0004FAF1 File Offset: 0x0004DCF1
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031EA RID: 12778
		// (get) Token: 0x0600A20B RID: 41483 RVA: 0x0028BEC8 File Offset: 0x0028A0C8
		// (set) Token: 0x0600A20C RID: 41484 RVA: 0x0004FB10 File Offset: 0x0004DD10
		public unsafe TextMeshProUGUI PriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_PriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_PriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031EB RID: 12779
		// (get) Token: 0x0600A20D RID: 41485 RVA: 0x0028BEF8 File Offset: 0x0028A0F8
		// (set) Token: 0x0600A20E RID: 41486 RVA: 0x0004FB2F File Offset: 0x0004DD2F
		public unsafe TextMeshProUGUI StockLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031EC RID: 12780
		// (get) Token: 0x0600A20F RID: 41487 RVA: 0x0028BF28 File Offset: 0x0028A128
		// (set) Token: 0x0600A210 RID: 41488 RVA: 0x0004FB4E File Offset: 0x0004DD4E
		public unsafe GameObject LockedContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_LockedContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_LockedContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031ED RID: 12781
		// (get) Token: 0x0600A211 RID: 41489 RVA: 0x0028BF58 File Offset: 0x0028A158
		// (set) Token: 0x0600A212 RID: 41490 RVA: 0x0004FB6D File Offset: 0x0004DD6D
		public unsafe Button BuyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_BuyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_BuyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031EE RID: 12782
		// (get) Token: 0x0600A213 RID: 41491 RVA: 0x0028BF88 File Offset: 0x0028A188
		// (set) Token: 0x0600A214 RID: 41492 RVA: 0x0004FB8C File Offset: 0x0004DD8C
		public unsafe Button DropdownButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DropdownButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DropdownButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031EF RID: 12783
		// (get) Token: 0x0600A215 RID: 41493 RVA: 0x0028BFB8 File Offset: 0x0028A1B8
		// (set) Token: 0x0600A216 RID: 41494 RVA: 0x0004FBAB File Offset: 0x0004DDAB
		public unsafe EventTrigger Trigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_Trigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_Trigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031F0 RID: 12784
		// (get) Token: 0x0600A217 RID: 41495 RVA: 0x0028BFE8 File Offset: 0x0028A1E8
		// (set) Token: 0x0600A218 RID: 41496 RVA: 0x0004FBCA File Offset: 0x0004DDCA
		public unsafe RectTransform DetailPanelAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DetailPanelAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DetailPanelAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031F1 RID: 12785
		// (get) Token: 0x0600A219 RID: 41497 RVA: 0x0028C018 File Offset: 0x0028A218
		// (set) Token: 0x0600A21A RID: 41498 RVA: 0x0004FBE9 File Offset: 0x0004DDE9
		public unsafe RectTransform DropdownAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DropdownAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DropdownAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031F2 RID: 12786
		// (get) Token: 0x0600A21B RID: 41499 RVA: 0x0028C048 File Offset: 0x0028A248
		// (set) Token: 0x0600A21C RID: 41500 RVA: 0x0004FC08 File Offset: 0x0004DE08
		public unsafe RectTransform TopDropdownAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_TopDropdownAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_TopDropdownAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031F3 RID: 12787
		// (get) Token: 0x0600A21D RID: 41501 RVA: 0x0028C078 File Offset: 0x0028A278
		// (set) Token: 0x0600A21E RID: 41502 RVA: 0x0004FC27 File Offset: 0x0004DE27
		public unsafe Action hoverStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_hoverStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_hoverStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031F4 RID: 12788
		// (get) Token: 0x0600A21F RID: 41503 RVA: 0x0028C0A8 File Offset: 0x0028A2A8
		// (set) Token: 0x0600A220 RID: 41504 RVA: 0x0004FC46 File Offset: 0x0004DE46
		public unsafe Action hoverEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_hoverEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_hoverEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031F5 RID: 12789
		// (get) Token: 0x0600A221 RID: 41505 RVA: 0x0028C0D8 File Offset: 0x0028A2D8
		// (set) Token: 0x0600A222 RID: 41506 RVA: 0x0004FC65 File Offset: 0x0004DE65
		public unsafe Action onClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onClicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031F6 RID: 12790
		// (get) Token: 0x0600A223 RID: 41507 RVA: 0x0028C108 File Offset: 0x0028A308
		// (set) Token: 0x0600A224 RID: 41508 RVA: 0x0004FC84 File Offset: 0x0004DE84
		public unsafe Action onDropdownClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onDropdownClicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onDropdownClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006C9E RID: 27806
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabelColor_Normal;

		// Token: 0x04006C9F RID: 27807
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabelColor_NoStock;

		// Token: 0x04006CA0 RID: 27808
		private static readonly IntPtr NativeFieldInfoPtr__Listing_k__BackingField;

		// Token: 0x04006CA1 RID: 27809
		private static readonly IntPtr NativeFieldInfoPtr_StockLabelDefault;

		// Token: 0x04006CA2 RID: 27810
		private static readonly IntPtr NativeFieldInfoPtr_StockLabelNone;

		// Token: 0x04006CA3 RID: 27811
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04006CA4 RID: 27812
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04006CA5 RID: 27813
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabel;

		// Token: 0x04006CA6 RID: 27814
		private static readonly IntPtr NativeFieldInfoPtr_StockLabel;

		// Token: 0x04006CA7 RID: 27815
		private static readonly IntPtr NativeFieldInfoPtr_LockedContainer;

		// Token: 0x04006CA8 RID: 27816
		private static readonly IntPtr NativeFieldInfoPtr_BuyButton;

		// Token: 0x04006CA9 RID: 27817
		private static readonly IntPtr NativeFieldInfoPtr_DropdownButton;

		// Token: 0x04006CAA RID: 27818
		private static readonly IntPtr NativeFieldInfoPtr_Trigger;

		// Token: 0x04006CAB RID: 27819
		private static readonly IntPtr NativeFieldInfoPtr_DetailPanelAnchor;

		// Token: 0x04006CAC RID: 27820
		private static readonly IntPtr NativeFieldInfoPtr_DropdownAnchor;

		// Token: 0x04006CAD RID: 27821
		private static readonly IntPtr NativeFieldInfoPtr_TopDropdownAnchor;

		// Token: 0x04006CAE RID: 27822
		private static readonly IntPtr NativeFieldInfoPtr_hoverStart;

		// Token: 0x04006CAF RID: 27823
		private static readonly IntPtr NativeFieldInfoPtr_hoverEnd;

		// Token: 0x04006CB0 RID: 27824
		private static readonly IntPtr NativeFieldInfoPtr_onClicked;

		// Token: 0x04006CB1 RID: 27825
		private static readonly IntPtr NativeFieldInfoPtr_onDropdownClicked;

		// Token: 0x04006CB2 RID: 27826
		private static readonly IntPtr NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0;

		// Token: 0x04006CB3 RID: 27827
		private static readonly IntPtr NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0;

		// Token: 0x04006CB4 RID: 27828
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ShopListing_0;

		// Token: 0x04006CB5 RID: 27829
		private static readonly IntPtr NativeMethodInfoPtr_GetIconCopy_Public_Virtual_New_RectTransform_RectTransform_0;

		// Token: 0x04006CB6 RID: 27830
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04006CB7 RID: 27831
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Private_Void_0;

		// Token: 0x04006CB8 RID: 27832
		private static readonly IntPtr NativeMethodInfoPtr_DropdownClicked_Private_Void_0;

		// Token: 0x04006CB9 RID: 27833
		private static readonly IntPtr NativeMethodInfoPtr_HoverStart_Private_Void_0;

		// Token: 0x04006CBA RID: 27834
		private static readonly IntPtr NativeMethodInfoPtr_HoverEnd_Private_Void_0;

		// Token: 0x04006CBB RID: 27835
		private static readonly IntPtr NativeMethodInfoPtr_StockChanged_Private_Void_0;

		// Token: 0x04006CBC RID: 27836
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePrice_Private_Void_0;

		// Token: 0x04006CBD RID: 27837
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStock_Private_Void_0;

		// Token: 0x04006CBE RID: 27838
		private static readonly IntPtr NativeMethodInfoPtr_UpdateButtons_Private_Void_0;

		// Token: 0x04006CBF RID: 27839
		private static readonly IntPtr NativeMethodInfoPtr_CanAddToCart_Public_Boolean_0;

		// Token: 0x04006CC0 RID: 27840
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLockStatus_Public_Void_0;

		// Token: 0x04006CC1 RID: 27841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006CC2 RID: 27842
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__23_0_Private_Void_BaseEventData_0;

		// Token: 0x04006CC3 RID: 27843
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__23_1_Private_Void_BaseEventData_0;
	}
}
