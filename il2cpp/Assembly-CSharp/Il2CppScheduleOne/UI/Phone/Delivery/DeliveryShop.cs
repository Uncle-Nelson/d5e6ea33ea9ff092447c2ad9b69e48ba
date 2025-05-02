using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Delivery
{
	// Token: 0x020006AB RID: 1707
	public class DeliveryShop : MonoBehaviour
	{
		// Token: 0x060098F6 RID: 39158 RVA: 0x00270110 File Offset: 0x0026E310
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryShop()
		{
			Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Delivery", "DeliveryShop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr);
			DeliveryShop.NativeFieldInfoPtr_DELIVERY_VEHICLE_SLOT_CAPACITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DELIVERY_VEHICLE_SLOT_CAPACITY");
			DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DELIVERY_TIME_MIN");
			DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DELIVERY_TIME_MAX");
			DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_ITEM_COUNT_DIVISOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DELIVERY_TIME_ITEM_COUNT_DIVISOR");
			DeliveryShop.NativeFieldInfoPtr__MatchingShop_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "<MatchingShop>k__BackingField");
			DeliveryShop.NativeFieldInfoPtr__IsExpanded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "<IsExpanded>k__BackingField");
			DeliveryShop.NativeFieldInfoPtr__IsAvailable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "<IsAvailable>k__BackingField");
			DeliveryShop.NativeFieldInfoPtr_HeaderImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "HeaderImage");
			DeliveryShop.NativeFieldInfoPtr_HeaderButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "HeaderButton");
			DeliveryShop.NativeFieldInfoPtr_ContentsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "ContentsContainer");
			DeliveryShop.NativeFieldInfoPtr_ListingContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "ListingContainer");
			DeliveryShop.NativeFieldInfoPtr_DeliveryFeeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DeliveryFeeLabel");
			DeliveryShop.NativeFieldInfoPtr_ItemTotalLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "ItemTotalLabel");
			DeliveryShop.NativeFieldInfoPtr_OrderTotalLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "OrderTotalLabel");
			DeliveryShop.NativeFieldInfoPtr_OrderButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "OrderButton");
			DeliveryShop.NativeFieldInfoPtr_OrderButtonNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "OrderButtonNote");
			DeliveryShop.NativeFieldInfoPtr_DestinationDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DestinationDropdown");
			DeliveryShop.NativeFieldInfoPtr_LoadingDockDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "LoadingDockDropdown");
			DeliveryShop.NativeFieldInfoPtr_MatchingShopInterfaceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "MatchingShopInterfaceName");
			DeliveryShop.NativeFieldInfoPtr_DeliveryFee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DeliveryFee");
			DeliveryShop.NativeFieldInfoPtr_AvailableByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "AvailableByDefault");
			DeliveryShop.NativeFieldInfoPtr_ListingEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "ListingEntryPrefab");
			DeliveryShop.NativeFieldInfoPtr_HeaderImage_Hidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "HeaderImage_Hidden");
			DeliveryShop.NativeFieldInfoPtr_HeaderImage_Expanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "HeaderImage_Expanded");
			DeliveryShop.NativeFieldInfoPtr_HeaderArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "HeaderArrow");
			DeliveryShop.NativeFieldInfoPtr_listingEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "listingEntries");
			DeliveryShop.NativeFieldInfoPtr_destinationProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "destinationProperty");
			DeliveryShop.NativeFieldInfoPtr_loadingDockIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "loadingDockIndex");
			DeliveryShop.NativeMethodInfoPtr_get_MatchingShop_Public_get_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682185);
			DeliveryShop.NativeMethodInfoPtr_set_MatchingShop_Private_set_Void_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682186);
			DeliveryShop.NativeMethodInfoPtr_get_IsExpanded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682187);
			DeliveryShop.NativeMethodInfoPtr_set_IsExpanded_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682188);
			DeliveryShop.NativeMethodInfoPtr_get_IsAvailable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682189);
			DeliveryShop.NativeMethodInfoPtr_set_IsAvailable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682190);
			DeliveryShop.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682191);
			DeliveryShop.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682192);
			DeliveryShop.NativeMethodInfoPtr_SetIsExpanded_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682193);
			DeliveryShop.NativeMethodInfoPtr_SetIsAvailable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682194);
			DeliveryShop.NativeMethodInfoPtr_OrderPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682195);
			DeliveryShop.NativeMethodInfoPtr_RefreshShop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682196);
			DeliveryShop.NativeMethodInfoPtr_ResetCart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682197);
			DeliveryShop.NativeMethodInfoPtr_RefreshCart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682198);
			DeliveryShop.NativeMethodInfoPtr_RefreshOrderButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682199);
			DeliveryShop.NativeMethodInfoPtr_CanOrder_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682200);
			DeliveryShop.NativeMethodInfoPtr_HasActiveDelivery_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682201);
			DeliveryShop.NativeMethodInfoPtr_WillCartFitInVehicle_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682202);
			DeliveryShop.NativeMethodInfoPtr_RefreshDestinationUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682203);
			DeliveryShop.NativeMethodInfoPtr_DestinationDropdownSelected_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682204);
			DeliveryShop.NativeMethodInfoPtr_GetPotentialDestinations_Private_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682205);
			DeliveryShop.NativeMethodInfoPtr_RefreshLoadingDockUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682206);
			DeliveryShop.NativeMethodInfoPtr_LoadingDockDropdownSelected_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682207);
			DeliveryShop.NativeMethodInfoPtr_GetCartCost_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682208);
			DeliveryShop.NativeMethodInfoPtr_GetOrderTotal_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682209);
			DeliveryShop.NativeMethodInfoPtr_GetOrderItemCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682210);
			DeliveryShop.NativeMethodInfoPtr_RefreshEntryOrder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682211);
			DeliveryShop.NativeMethodInfoPtr_RefreshEntriesLocked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682212);
			DeliveryShop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682213);
			DeliveryShop.NativeMethodInfoPtr__Start_b__37_0_Private_Boolean_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682214);
			DeliveryShop.NativeMethodInfoPtr__Start_b__37_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682215);
		}

		// Token: 0x17002F15 RID: 12053
		// (get) Token: 0x060098F7 RID: 39159 RVA: 0x002705DC File Offset: 0x0026E7DC
		// (set) Token: 0x060098F8 RID: 39160 RVA: 0x0027061C File Offset: 0x0026E81C
		public unsafe ShopInterface MatchingShop
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_get_MatchingShop_Public_get_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_set_MatchingShop_Private_set_Void_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002F16 RID: 12054
		// (get) Token: 0x060098F9 RID: 39161 RVA: 0x00270660 File Offset: 0x0026E860
		// (set) Token: 0x060098FA RID: 39162 RVA: 0x0027069C File Offset: 0x0026E89C
		public unsafe bool IsExpanded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_get_IsExpanded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37992, RefRangeEnd = 38015, XrefRangeStart = 37992, XrefRangeEnd = 38015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_set_IsExpanded_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002F17 RID: 12055
		// (get) Token: 0x060098FB RID: 39163 RVA: 0x002706DC File Offset: 0x0026E8DC
		// (set) Token: 0x060098FC RID: 39164 RVA: 0x00270718 File Offset: 0x0026E918
		public unsafe bool IsAvailable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_get_IsAvailable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_set_IsAvailable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060098FD RID: 39165 RVA: 0x00270758 File Offset: 0x0026E958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273310, XrefRangeEnd = 273408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098FE RID: 39166 RVA: 0x0027078C File Offset: 0x0026E98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273408, XrefRangeEnd = 273414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098FF RID: 39167 RVA: 0x002707C0 File Offset: 0x0026E9C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273427, RefRangeEnd = 273429, XrefRangeStart = 273414, XrefRangeEnd = 273427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsExpanded(bool expanded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref expanded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_SetIsExpanded_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009900 RID: 39168 RVA: 0x00270800 File Offset: 0x0026EA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273429, XrefRangeEnd = 273437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsAvailable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_SetIsAvailable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009901 RID: 39169 RVA: 0x00270834 File Offset: 0x0026EA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273437, XrefRangeEnd = 273511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OrderPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_OrderPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009902 RID: 39170 RVA: 0x00270868 File Offset: 0x0026EA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273511, XrefRangeEnd = 273517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshShop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshShop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009903 RID: 39171 RVA: 0x0027089C File Offset: 0x0026EA9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273536, RefRangeEnd = 273537, XrefRangeStart = 273517, XrefRangeEnd = 273536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_ResetCart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009904 RID: 39172 RVA: 0x002708D0 File Offset: 0x0026EAD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 273542, RefRangeEnd = 273545, XrefRangeStart = 273537, XrefRangeEnd = 273542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshCart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009905 RID: 39173 RVA: 0x00270904 File Offset: 0x0026EB04
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 273548, RefRangeEnd = 273552, XrefRangeStart = 273545, XrefRangeEnd = 273548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshOrderButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshOrderButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009906 RID: 39174 RVA: 0x00270938 File Offset: 0x0026EB38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273575, RefRangeEnd = 273577, XrefRangeStart = 273552, XrefRangeEnd = 273575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanOrder(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_CanOrder_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06009907 RID: 39175 RVA: 0x00270990 File Offset: 0x0026EB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273577, XrefRangeEnd = 273586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasActiveDelivery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_HasActiveDelivery_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009908 RID: 39176 RVA: 0x002709CC File Offset: 0x0026EBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273586, XrefRangeEnd = 273600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WillCartFitInVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_WillCartFitInVehicle_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009909 RID: 39177 RVA: 0x00270A08 File Offset: 0x0026EC08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273653, RefRangeEnd = 273655, XrefRangeStart = 273600, XrefRangeEnd = 273653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDestinationUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshDestinationUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600990A RID: 39178 RVA: 0x00270A3C File Offset: 0x0026EC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273655, XrefRangeEnd = 273667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestinationDropdownSelected(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_DestinationDropdownSelected_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600990B RID: 39179 RVA: 0x00270A7C File Offset: 0x0026EC7C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 273677, RefRangeEnd = 273682, XrefRangeStart = 273667, XrefRangeEnd = 273677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Property> GetPotentialDestinations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_GetPotentialDestinations_Private_List_1_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr3) : null;
		}

		// Token: 0x0600990C RID: 39180 RVA: 0x00270ABC File Offset: 0x0026ECBC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 273718, RefRangeEnd = 273722, XrefRangeStart = 273682, XrefRangeEnd = 273718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshLoadingDockUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshLoadingDockUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600990D RID: 39181 RVA: 0x00270AF0 File Offset: 0x0026ECF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 49919, RefRangeEnd = 49923, XrefRangeStart = 49919, XrefRangeEnd = 49923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadingDockDropdownSelected(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_LoadingDockDropdownSelected_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600990E RID: 39182 RVA: 0x00270B30 File Offset: 0x0026ED30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 273737, RefRangeEnd = 273741, XrefRangeStart = 273722, XrefRangeEnd = 273737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCartCost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_GetCartCost_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600990F RID: 39183 RVA: 0x00270B6C File Offset: 0x0026ED6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273741, XrefRangeEnd = 273742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetOrderTotal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_GetOrderTotal_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009910 RID: 39184 RVA: 0x00270BA8 File Offset: 0x0026EDA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273756, RefRangeEnd = 273757, XrefRangeStart = 273742, XrefRangeEnd = 273756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetOrderItemCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_GetOrderItemCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009911 RID: 39185 RVA: 0x00270BE4 File Offset: 0x0026EDE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273798, RefRangeEnd = 273800, XrefRangeStart = 273757, XrefRangeEnd = 273798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshEntryOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshEntryOrder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009912 RID: 39186 RVA: 0x00270C18 File Offset: 0x0026EE18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273820, RefRangeEnd = 273822, XrefRangeStart = 273800, XrefRangeEnd = 273820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshEntriesLocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshEntriesLocked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009913 RID: 39187 RVA: 0x00270C4C File Offset: 0x0026EE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273822, XrefRangeEnd = 273834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryShop() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009914 RID: 39188 RVA: 0x00270C88 File Offset: 0x0026EE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Start_b__37_0(ShopInterface x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr__Start_b__37_0_Private_Boolean_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009915 RID: 39189 RVA: 0x00270CD8 File Offset: 0x0026EED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273834, XrefRangeEnd = 273835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__37_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr__Start_b__37_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009916 RID: 39190 RVA: 0x0004A8B0 File Offset: 0x00048AB0
		public DeliveryShop(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002EF9 RID: 12025
		// (get) Token: 0x06009917 RID: 39191 RVA: 0x00270D0C File Offset: 0x0026EF0C
		// (set) Token: 0x06009918 RID: 39192 RVA: 0x0004A8B9 File Offset: 0x00048AB9
		public unsafe static int DELIVERY_VEHICLE_SLOT_CAPACITY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_VEHICLE_SLOT_CAPACITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_VEHICLE_SLOT_CAPACITY, (void*)(&value));
			}
		}

		// Token: 0x17002EFA RID: 12026
		// (get) Token: 0x06009919 RID: 39193 RVA: 0x00270D28 File Offset: 0x0026EF28
		// (set) Token: 0x0600991A RID: 39194 RVA: 0x0004A8C7 File Offset: 0x00048AC7
		public unsafe static int DELIVERY_TIME_MIN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_MIN, (void*)(&value));
			}
		}

		// Token: 0x17002EFB RID: 12027
		// (get) Token: 0x0600991B RID: 39195 RVA: 0x00270D44 File Offset: 0x0026EF44
		// (set) Token: 0x0600991C RID: 39196 RVA: 0x0004A8D5 File Offset: 0x00048AD5
		public unsafe static int DELIVERY_TIME_MAX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_MAX, (void*)(&value));
			}
		}

		// Token: 0x17002EFC RID: 12028
		// (get) Token: 0x0600991D RID: 39197 RVA: 0x00270D60 File Offset: 0x0026EF60
		// (set) Token: 0x0600991E RID: 39198 RVA: 0x0004A8E3 File Offset: 0x00048AE3
		public unsafe static int DELIVERY_TIME_ITEM_COUNT_DIVISOR
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_ITEM_COUNT_DIVISOR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_ITEM_COUNT_DIVISOR, (void*)(&value));
			}
		}

		// Token: 0x17002EFD RID: 12029
		// (get) Token: 0x0600991F RID: 39199 RVA: 0x00270D7C File Offset: 0x0026EF7C
		// (set) Token: 0x06009920 RID: 39200 RVA: 0x0004A8F1 File Offset: 0x00048AF1
		public unsafe ShopInterface _MatchingShop_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__MatchingShop_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__MatchingShop_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EFE RID: 12030
		// (get) Token: 0x06009921 RID: 39201 RVA: 0x00270DAC File Offset: 0x0026EFAC
		// (set) Token: 0x06009922 RID: 39202 RVA: 0x0004A910 File Offset: 0x00048B10
		public unsafe bool _IsExpanded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__IsExpanded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__IsExpanded_k__BackingField)) = value;
			}
		}

		// Token: 0x17002EFF RID: 12031
		// (get) Token: 0x06009923 RID: 39203 RVA: 0x00270DD4 File Offset: 0x0026EFD4
		// (set) Token: 0x06009924 RID: 39204 RVA: 0x0004A92B File Offset: 0x00048B2B
		public unsafe bool _IsAvailable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__IsAvailable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__IsAvailable_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F00 RID: 12032
		// (get) Token: 0x06009925 RID: 39205 RVA: 0x00270DFC File Offset: 0x0026EFFC
		// (set) Token: 0x06009926 RID: 39206 RVA: 0x0004A946 File Offset: 0x00048B46
		public unsafe Image HeaderImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F01 RID: 12033
		// (get) Token: 0x06009927 RID: 39207 RVA: 0x00270E2C File Offset: 0x0026F02C
		// (set) Token: 0x06009928 RID: 39208 RVA: 0x0004A965 File Offset: 0x00048B65
		public unsafe Button HeaderButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F02 RID: 12034
		// (get) Token: 0x06009929 RID: 39209 RVA: 0x00270E5C File Offset: 0x0026F05C
		// (set) Token: 0x0600992A RID: 39210 RVA: 0x0004A984 File Offset: 0x00048B84
		public unsafe RectTransform ContentsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ContentsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ContentsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F03 RID: 12035
		// (get) Token: 0x0600992B RID: 39211 RVA: 0x00270E8C File Offset: 0x0026F08C
		// (set) Token: 0x0600992C RID: 39212 RVA: 0x0004A9A3 File Offset: 0x00048BA3
		public unsafe RectTransform ListingContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ListingContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ListingContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F04 RID: 12036
		// (get) Token: 0x0600992D RID: 39213 RVA: 0x00270EBC File Offset: 0x0026F0BC
		// (set) Token: 0x0600992E RID: 39214 RVA: 0x0004A9C2 File Offset: 0x00048BC2
		public unsafe Text DeliveryFeeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DeliveryFeeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DeliveryFeeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F05 RID: 12037
		// (get) Token: 0x0600992F RID: 39215 RVA: 0x00270EEC File Offset: 0x0026F0EC
		// (set) Token: 0x06009930 RID: 39216 RVA: 0x0004A9E1 File Offset: 0x00048BE1
		public unsafe Text ItemTotalLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ItemTotalLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ItemTotalLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F06 RID: 12038
		// (get) Token: 0x06009931 RID: 39217 RVA: 0x00270F1C File Offset: 0x0026F11C
		// (set) Token: 0x06009932 RID: 39218 RVA: 0x0004AA00 File Offset: 0x00048C00
		public unsafe Text OrderTotalLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderTotalLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderTotalLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F07 RID: 12039
		// (get) Token: 0x06009933 RID: 39219 RVA: 0x00270F4C File Offset: 0x0026F14C
		// (set) Token: 0x06009934 RID: 39220 RVA: 0x0004AA1F File Offset: 0x00048C1F
		public unsafe Button OrderButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F08 RID: 12040
		// (get) Token: 0x06009935 RID: 39221 RVA: 0x00270F7C File Offset: 0x0026F17C
		// (set) Token: 0x06009936 RID: 39222 RVA: 0x0004AA3E File Offset: 0x00048C3E
		public unsafe Text OrderButtonNote
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderButtonNote);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderButtonNote), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F09 RID: 12041
		// (get) Token: 0x06009937 RID: 39223 RVA: 0x00270FAC File Offset: 0x0026F1AC
		// (set) Token: 0x06009938 RID: 39224 RVA: 0x0004AA5D File Offset: 0x00048C5D
		public unsafe Dropdown DestinationDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DestinationDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DestinationDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F0A RID: 12042
		// (get) Token: 0x06009939 RID: 39225 RVA: 0x00270FDC File Offset: 0x0026F1DC
		// (set) Token: 0x0600993A RID: 39226 RVA: 0x0004AA7C File Offset: 0x00048C7C
		public unsafe Dropdown LoadingDockDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_LoadingDockDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_LoadingDockDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F0B RID: 12043
		// (get) Token: 0x0600993B RID: 39227 RVA: 0x0027100C File Offset: 0x0026F20C
		// (set) Token: 0x0600993C RID: 39228 RVA: 0x0004AA9B File Offset: 0x00048C9B
		public unsafe string MatchingShopInterfaceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_MatchingShopInterfaceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_MatchingShopInterfaceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002F0C RID: 12044
		// (get) Token: 0x0600993D RID: 39229 RVA: 0x00271034 File Offset: 0x0026F234
		// (set) Token: 0x0600993E RID: 39230 RVA: 0x0004AABA File Offset: 0x00048CBA
		public unsafe float DeliveryFee
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DeliveryFee);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DeliveryFee)) = value;
			}
		}

		// Token: 0x17002F0D RID: 12045
		// (get) Token: 0x0600993F RID: 39231 RVA: 0x0027105C File Offset: 0x0026F25C
		// (set) Token: 0x06009940 RID: 39232 RVA: 0x0004AAD5 File Offset: 0x00048CD5
		public unsafe bool AvailableByDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_AvailableByDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_AvailableByDefault)) = value;
			}
		}

		// Token: 0x17002F0E RID: 12046
		// (get) Token: 0x06009941 RID: 39233 RVA: 0x00271084 File Offset: 0x0026F284
		// (set) Token: 0x06009942 RID: 39234 RVA: 0x0004AAF0 File Offset: 0x00048CF0
		public unsafe ListingEntry ListingEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ListingEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ListingEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F0F RID: 12047
		// (get) Token: 0x06009943 RID: 39235 RVA: 0x002710B4 File Offset: 0x0026F2B4
		// (set) Token: 0x06009944 RID: 39236 RVA: 0x0004AB0F File Offset: 0x00048D0F
		public unsafe Sprite HeaderImage_Hidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderImage_Hidden);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderImage_Hidden), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F10 RID: 12048
		// (get) Token: 0x06009945 RID: 39237 RVA: 0x002710E4 File Offset: 0x0026F2E4
		// (set) Token: 0x06009946 RID: 39238 RVA: 0x0004AB2E File Offset: 0x00048D2E
		public unsafe Sprite HeaderImage_Expanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderImage_Expanded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderImage_Expanded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F11 RID: 12049
		// (get) Token: 0x06009947 RID: 39239 RVA: 0x00271114 File Offset: 0x0026F314
		// (set) Token: 0x06009948 RID: 39240 RVA: 0x0004AB4D File Offset: 0x00048D4D
		public unsafe RectTransform HeaderArrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderArrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderArrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F12 RID: 12050
		// (get) Token: 0x06009949 RID: 39241 RVA: 0x00271144 File Offset: 0x0026F344
		// (set) Token: 0x0600994A RID: 39242 RVA: 0x0004AB6C File Offset: 0x00048D6C
		public unsafe List<ListingEntry> listingEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_listingEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ListingEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_listingEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F13 RID: 12051
		// (get) Token: 0x0600994B RID: 39243 RVA: 0x00271174 File Offset: 0x0026F374
		// (set) Token: 0x0600994C RID: 39244 RVA: 0x0004AB8B File Offset: 0x00048D8B
		public unsafe Property destinationProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_destinationProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_destinationProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F14 RID: 12052
		// (get) Token: 0x0600994D RID: 39245 RVA: 0x002711A4 File Offset: 0x0026F3A4
		// (set) Token: 0x0600994E RID: 39246 RVA: 0x0004ABAA File Offset: 0x00048DAA
		public unsafe int loadingDockIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_loadingDockIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_loadingDockIndex)) = value;
			}
		}

		// Token: 0x040066FF RID: 26367
		private static readonly IntPtr NativeFieldInfoPtr_DELIVERY_VEHICLE_SLOT_CAPACITY;

		// Token: 0x04006700 RID: 26368
		private static readonly IntPtr NativeFieldInfoPtr_DELIVERY_TIME_MIN;

		// Token: 0x04006701 RID: 26369
		private static readonly IntPtr NativeFieldInfoPtr_DELIVERY_TIME_MAX;

		// Token: 0x04006702 RID: 26370
		private static readonly IntPtr NativeFieldInfoPtr_DELIVERY_TIME_ITEM_COUNT_DIVISOR;

		// Token: 0x04006703 RID: 26371
		private static readonly IntPtr NativeFieldInfoPtr__MatchingShop_k__BackingField;

		// Token: 0x04006704 RID: 26372
		private static readonly IntPtr NativeFieldInfoPtr__IsExpanded_k__BackingField;

		// Token: 0x04006705 RID: 26373
		private static readonly IntPtr NativeFieldInfoPtr__IsAvailable_k__BackingField;

		// Token: 0x04006706 RID: 26374
		private static readonly IntPtr NativeFieldInfoPtr_HeaderImage;

		// Token: 0x04006707 RID: 26375
		private static readonly IntPtr NativeFieldInfoPtr_HeaderButton;

		// Token: 0x04006708 RID: 26376
		private static readonly IntPtr NativeFieldInfoPtr_ContentsContainer;

		// Token: 0x04006709 RID: 26377
		private static readonly IntPtr NativeFieldInfoPtr_ListingContainer;

		// Token: 0x0400670A RID: 26378
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryFeeLabel;

		// Token: 0x0400670B RID: 26379
		private static readonly IntPtr NativeFieldInfoPtr_ItemTotalLabel;

		// Token: 0x0400670C RID: 26380
		private static readonly IntPtr NativeFieldInfoPtr_OrderTotalLabel;

		// Token: 0x0400670D RID: 26381
		private static readonly IntPtr NativeFieldInfoPtr_OrderButton;

		// Token: 0x0400670E RID: 26382
		private static readonly IntPtr NativeFieldInfoPtr_OrderButtonNote;

		// Token: 0x0400670F RID: 26383
		private static readonly IntPtr NativeFieldInfoPtr_DestinationDropdown;

		// Token: 0x04006710 RID: 26384
		private static readonly IntPtr NativeFieldInfoPtr_LoadingDockDropdown;

		// Token: 0x04006711 RID: 26385
		private static readonly IntPtr NativeFieldInfoPtr_MatchingShopInterfaceName;

		// Token: 0x04006712 RID: 26386
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryFee;

		// Token: 0x04006713 RID: 26387
		private static readonly IntPtr NativeFieldInfoPtr_AvailableByDefault;

		// Token: 0x04006714 RID: 26388
		private static readonly IntPtr NativeFieldInfoPtr_ListingEntryPrefab;

		// Token: 0x04006715 RID: 26389
		private static readonly IntPtr NativeFieldInfoPtr_HeaderImage_Hidden;

		// Token: 0x04006716 RID: 26390
		private static readonly IntPtr NativeFieldInfoPtr_HeaderImage_Expanded;

		// Token: 0x04006717 RID: 26391
		private static readonly IntPtr NativeFieldInfoPtr_HeaderArrow;

		// Token: 0x04006718 RID: 26392
		private static readonly IntPtr NativeFieldInfoPtr_listingEntries;

		// Token: 0x04006719 RID: 26393
		private static readonly IntPtr NativeFieldInfoPtr_destinationProperty;

		// Token: 0x0400671A RID: 26394
		private static readonly IntPtr NativeFieldInfoPtr_loadingDockIndex;

		// Token: 0x0400671B RID: 26395
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchingShop_Public_get_ShopInterface_0;

		// Token: 0x0400671C RID: 26396
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchingShop_Private_set_Void_ShopInterface_0;

		// Token: 0x0400671D RID: 26397
		private static readonly IntPtr NativeMethodInfoPtr_get_IsExpanded_Public_get_Boolean_0;

		// Token: 0x0400671E RID: 26398
		private static readonly IntPtr NativeMethodInfoPtr_set_IsExpanded_Private_set_Void_Boolean_0;

		// Token: 0x0400671F RID: 26399
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAvailable_Public_get_Boolean_0;

		// Token: 0x04006720 RID: 26400
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAvailable_Private_set_Void_Boolean_0;

		// Token: 0x04006721 RID: 26401
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006722 RID: 26402
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04006723 RID: 26403
		private static readonly IntPtr NativeMethodInfoPtr_SetIsExpanded_Public_Void_Boolean_0;

		// Token: 0x04006724 RID: 26404
		private static readonly IntPtr NativeMethodInfoPtr_SetIsAvailable_Public_Void_0;

		// Token: 0x04006725 RID: 26405
		private static readonly IntPtr NativeMethodInfoPtr_OrderPressed_Public_Void_0;

		// Token: 0x04006726 RID: 26406
		private static readonly IntPtr NativeMethodInfoPtr_RefreshShop_Public_Void_0;

		// Token: 0x04006727 RID: 26407
		private static readonly IntPtr NativeMethodInfoPtr_ResetCart_Public_Void_0;

		// Token: 0x04006728 RID: 26408
		private static readonly IntPtr NativeMethodInfoPtr_RefreshCart_Private_Void_0;

		// Token: 0x04006729 RID: 26409
		private static readonly IntPtr NativeMethodInfoPtr_RefreshOrderButton_Private_Void_0;

		// Token: 0x0400672A RID: 26410
		private static readonly IntPtr NativeMethodInfoPtr_CanOrder_Public_Boolean_byref_String_0;

		// Token: 0x0400672B RID: 26411
		private static readonly IntPtr NativeMethodInfoPtr_HasActiveDelivery_Public_Boolean_0;

		// Token: 0x0400672C RID: 26412
		private static readonly IntPtr NativeMethodInfoPtr_WillCartFitInVehicle_Public_Boolean_0;

		// Token: 0x0400672D RID: 26413
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDestinationUI_Public_Void_0;

		// Token: 0x0400672E RID: 26414
		private static readonly IntPtr NativeMethodInfoPtr_DestinationDropdownSelected_Private_Void_Int32_0;

		// Token: 0x0400672F RID: 26415
		private static readonly IntPtr NativeMethodInfoPtr_GetPotentialDestinations_Private_List_1_Property_0;

		// Token: 0x04006730 RID: 26416
		private static readonly IntPtr NativeMethodInfoPtr_RefreshLoadingDockUI_Public_Void_0;

		// Token: 0x04006731 RID: 26417
		private static readonly IntPtr NativeMethodInfoPtr_LoadingDockDropdownSelected_Private_Void_Int32_0;

		// Token: 0x04006732 RID: 26418
		private static readonly IntPtr NativeMethodInfoPtr_GetCartCost_Private_Single_0;

		// Token: 0x04006733 RID: 26419
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderTotal_Private_Single_0;

		// Token: 0x04006734 RID: 26420
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderItemCount_Private_Int32_0;

		// Token: 0x04006735 RID: 26421
		private static readonly IntPtr NativeMethodInfoPtr_RefreshEntryOrder_Private_Void_0;

		// Token: 0x04006736 RID: 26422
		private static readonly IntPtr NativeMethodInfoPtr_RefreshEntriesLocked_Private_Void_0;

		// Token: 0x04006737 RID: 26423
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006738 RID: 26424
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__37_0_Private_Boolean_ShopInterface_0;

		// Token: 0x04006739 RID: 26425
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__37_1_Private_Void_0;
	}
}
