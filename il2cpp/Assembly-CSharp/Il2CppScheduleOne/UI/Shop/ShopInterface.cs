using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Delivery;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x0200070F RID: 1807
	public class ShopInterface : MonoBehaviour
	{
		// Token: 0x0600A24E RID: 41550 RVA: 0x0028C980 File Offset: 0x0028AB80
		// Note: this type is marked as 'beforefieldinit'.
		static ShopInterface()
		{
			Il2CppClassPointerStore<ShopInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ShopInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr);
			ShopInterface.NativeFieldInfoPtr_AllShops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "AllShops");
			ShopInterface.NativeFieldInfoPtr_MAX_ITEM_QUANTITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "MAX_ITEM_QUANTITY");
			ShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			ShopInterface.NativeFieldInfoPtr_ShopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ShopName");
			ShopInterface.NativeFieldInfoPtr_ShopCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ShopCode");
			ShopInterface.NativeFieldInfoPtr_PaymentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "PaymentType");
			ShopInterface.NativeFieldInfoPtr_ShowCurrencyHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ShowCurrencyHint");
			ShopInterface.NativeFieldInfoPtr_Listings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "Listings");
			ShopInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "Canvas");
			ShopInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "Container");
			ShopInterface.NativeFieldInfoPtr_ListingContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ListingContainer");
			ShopInterface.NativeFieldInfoPtr_StoreNameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "StoreNameLabel");
			ShopInterface.NativeFieldInfoPtr_Cart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "Cart");
			ShopInterface.NativeFieldInfoPtr_DeliveryBays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "DeliveryBays");
			ShopInterface.NativeFieldInfoPtr_LoadingBayDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "LoadingBayDetector");
			ShopInterface.NativeFieldInfoPtr_DetailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "DetailPanel");
			ShopInterface.NativeFieldInfoPtr_ListingScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ListingScrollRect");
			ShopInterface.NativeFieldInfoPtr_AmountSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "AmountSelector");
			ShopInterface.NativeFieldInfoPtr_DeliveryVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "DeliveryVehicle");
			ShopInterface.NativeFieldInfoPtr_AddItemSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "AddItemSound");
			ShopInterface.NativeFieldInfoPtr_RemoveItemSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "RemoveItemSound");
			ShopInterface.NativeFieldInfoPtr_CheckoutSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "CheckoutSound");
			ShopInterface.NativeFieldInfoPtr_ListingUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ListingUIPrefab");
			ShopInterface.NativeFieldInfoPtr_onOrderCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "onOrderCompleted");
			ShopInterface.NativeFieldInfoPtr_categoryButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "categoryButtons");
			ShopInterface.NativeFieldInfoPtr_categoryFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "categoryFilter");
			ShopInterface.NativeFieldInfoPtr_searchTerm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "searchTerm");
			ShopInterface.NativeFieldInfoPtr_listingUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "listingUI");
			ShopInterface.NativeFieldInfoPtr_selectedListing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "selectedListing");
			ShopInterface.NativeFieldInfoPtr_dropdownMouseUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "dropdownMouseUp");
			ShopInterface.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "loader");
			ShopInterface.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			ShopInterface.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			ShopInterface.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<HasChanged>k__BackingField");
			ShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683145);
			ShopInterface.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683146);
			ShopInterface.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683147);
			ShopInterface.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683148);
			ShopInterface.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683149);
			ShopInterface.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683150);
			ShopInterface.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683151);
			ShopInterface.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683152);
			ShopInterface.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683153);
			ShopInterface.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683154);
			ShopInterface.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683155);
			ShopInterface.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683156);
			ShopInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683157);
			ShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683158);
			ShopInterface.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683159);
			ShopInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683160);
			ShopInterface.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683161);
			ShopInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683162);
			ShopInterface.NativeMethodInfoPtr_OnDayPass_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683163);
			ShopInterface.NativeMethodInfoPtr_OnWeekPass_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683164);
			ShopInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683165);
			ShopInterface.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683166);
			ShopInterface.NativeMethodInfoPtr_Hint_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683167);
			ShopInterface.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683168);
			ShopInterface.NativeMethodInfoPtr_CreateListingUI_Private_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683169);
			ShopInterface.NativeMethodInfoPtr_SelectCategory_Public_Void_EShopCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683170);
			ShopInterface.NativeMethodInfoPtr_ListingClicked_Public_Virtual_New_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683171);
			ShopInterface.NativeMethodInfoPtr_ShowCartAnimation_Private_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683172);
			ShopInterface.NativeMethodInfoPtr_CategorySelected_Public_Void_EShopCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683173);
			ShopInterface.NativeMethodInfoPtr_DeselectCurrentCategory_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683174);
			ShopInterface.NativeMethodInfoPtr_RefreshShownItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683175);
			ShopInterface.NativeMethodInfoPtr_RefreshUnlockStatus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683176);
			ShopInterface.NativeMethodInfoPtr_RestockAllListings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683177);
			ShopInterface.NativeMethodInfoPtr_CanCartFitItem_Public_Boolean_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683178);
			ShopInterface.NativeMethodInfoPtr_WillCartFit_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683179);
			ShopInterface.NativeMethodInfoPtr_WillCartFit_Public_Boolean_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683180);
			ShopInterface.NativeMethodInfoPtr_HandoverItems_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683181);
			ShopInterface.NativeMethodInfoPtr_GetAvailableSlots_Public_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683182);
			ShopInterface.NativeMethodInfoPtr_GetLoadingBayVehicle_Public_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683183);
			ShopInterface.NativeMethodInfoPtr_PlaceItemInDeliveryBay_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683184);
			ShopInterface.NativeMethodInfoPtr_QuantitySelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683185);
			ShopInterface.NativeMethodInfoPtr_OpenAmountSelector_Public_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683186);
			ShopInterface.NativeMethodInfoPtr_DropdownClicked_Private_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683187);
			ShopInterface.NativeMethodInfoPtr_EntryHovered_Private_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683188);
			ShopInterface.NativeMethodInfoPtr_EntryUnhovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683189);
			ShopInterface.NativeMethodInfoPtr_Load_Public_Void_ShopData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683190);
			ShopInterface.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683191);
			ShopInterface.NativeMethodInfoPtr_GetListing_Public_ShopListing_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683192);
			ShopInterface.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683193);
			ShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683194);
			ShopInterface.NativeMethodInfoPtr__DeselectCurrentCategory_b__72_0_Private_Boolean_CategoryButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683196);
		}

		// Token: 0x17003227 RID: 12839
		// (get) Token: 0x0600A24F RID: 41551 RVA: 0x0028D054 File Offset: 0x0028B254
		// (set) Token: 0x0600A250 RID: 41552 RVA: 0x0028D090 File Offset: 0x0028B290
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003228 RID: 12840
		// (get) Token: 0x0600A251 RID: 41553 RVA: 0x0028D0D0 File Offset: 0x0028B2D0
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284844, XrefRangeEnd = 284845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17003229 RID: 12841
		// (get) Token: 0x0600A252 RID: 41554 RVA: 0x0028D108 File Offset: 0x0028B308
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700322A RID: 12842
		// (get) Token: 0x0600A253 RID: 41555 RVA: 0x0028D140 File Offset: 0x0028B340
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x1700322B RID: 12843
		// (get) Token: 0x0600A254 RID: 41556 RVA: 0x0028D180 File Offset: 0x0028B380
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35953, RefRangeEnd = 36136, XrefRangeStart = 35953, XrefRangeEnd = 36136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700322C RID: 12844
		// (get) Token: 0x0600A255 RID: 41557 RVA: 0x0028D1BC File Offset: 0x0028B3BC
		// (set) Token: 0x0600A256 RID: 41558 RVA: 0x0028D1FC File Offset: 0x0028B3FC
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700322D RID: 12845
		// (get) Token: 0x0600A257 RID: 41559 RVA: 0x0028D240 File Offset: 0x0028B440
		// (set) Token: 0x0600A258 RID: 41560 RVA: 0x0028D280 File Offset: 0x0028B480
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700322E RID: 12846
		// (get) Token: 0x0600A259 RID: 41561 RVA: 0x0028D2C4 File Offset: 0x0028B4C4
		// (set) Token: 0x0600A25A RID: 41562 RVA: 0x0028D300 File Offset: 0x0028B500
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A25B RID: 41563 RVA: 0x0028D340 File Offset: 0x0028B540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284845, XrefRangeEnd = 284909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A25C RID: 41564 RVA: 0x0028D37C File Offset: 0x0028B57C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284990, RefRangeEnd = 284991, XrefRangeStart = 284909, XrefRangeEnd = 284990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A25D RID: 41565 RVA: 0x0028D3B8 File Offset: 0x0028B5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284991, XrefRangeEnd = 284997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A25E RID: 41566 RVA: 0x0028D3F4 File Offset: 0x0028B5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284997, XrefRangeEnd = 285005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A25F RID: 41567 RVA: 0x0028D428 File Offset: 0x0028B628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285005, XrefRangeEnd = 285069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A260 RID: 41568 RVA: 0x0028D45C File Offset: 0x0028B65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285069, XrefRangeEnd = 285070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A261 RID: 41569 RVA: 0x0028D498 File Offset: 0x0028B698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285070, XrefRangeEnd = 285082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OnDayPass_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A262 RID: 41570 RVA: 0x0028D4CC File Offset: 0x0028B6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285082, XrefRangeEnd = 285094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWeekPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OnWeekPass_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A263 RID: 41571 RVA: 0x0028D500 File Offset: 0x0028B700
		[CallerCount(0)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A264 RID: 41572 RVA: 0x0028D534 File Offset: 0x0028B734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285094, XrefRangeEnd = 285208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsOpen(bool isOpen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A265 RID: 41573 RVA: 0x0028D580 File Offset: 0x0028B780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285208, XrefRangeEnd = 285216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_Hint_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A266 RID: 41574 RVA: 0x0028D5B4 File Offset: 0x0028B7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285216, XrefRangeEnd = 285217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A267 RID: 41575 RVA: 0x0028D604 File Offset: 0x0028B804
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285277, RefRangeEnd = 285278, XrefRangeStart = 285217, XrefRangeEnd = 285277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateListingUI(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_CreateListingUI_Private_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A268 RID: 41576 RVA: 0x0028D648 File Offset: 0x0028B848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285278, XrefRangeEnd = 285306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectCategory(EShopCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_SelectCategory_Public_Void_EShopCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A269 RID: 41577 RVA: 0x0028D688 File Offset: 0x0028B888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285306, XrefRangeEnd = 285310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ListingClicked(ListingUI listingUI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listingUI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_ListingClicked_Public_Virtual_New_Void_ListingUI_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A26A RID: 41578 RVA: 0x0028D6D8 File Offset: 0x0028B8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285310, XrefRangeEnd = 285319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowCartAnimation(ListingUI listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_ShowCartAnimation_Private_Void_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A26B RID: 41579 RVA: 0x0028D71C File Offset: 0x0028B91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285319, XrefRangeEnd = 285330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CategorySelected(EShopCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_CategorySelected_Public_Void_EShopCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A26C RID: 41580 RVA: 0x0028D75C File Offset: 0x0028B95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285330, XrefRangeEnd = 285341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeselectCurrentCategory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_DeselectCurrentCategory_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A26D RID: 41581 RVA: 0x0028D790 File Offset: 0x0028B990
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 285407, RefRangeEnd = 285411, XrefRangeStart = 285341, XrefRangeEnd = 285407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshShownItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_RefreshShownItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A26E RID: 41582 RVA: 0x0028D7C4 File Offset: 0x0028B9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285411, XrefRangeEnd = 285419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshUnlockStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_RefreshUnlockStatus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A26F RID: 41583 RVA: 0x0028D7F8 File Offset: 0x0028B9F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285434, RefRangeEnd = 285435, XrefRangeStart = 285419, XrefRangeEnd = 285434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestockAllListings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_RestockAllListings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A270 RID: 41584 RVA: 0x0028D82C File Offset: 0x0028BA2C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCartFitItem(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_CanCartFitItem_Public_Boolean_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A271 RID: 41585 RVA: 0x0028D87C File Offset: 0x0028BA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285435, XrefRangeEnd = 285447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WillCartFit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_WillCartFit_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A272 RID: 41586 RVA: 0x0028D8B8 File Offset: 0x0028BAB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285484, RefRangeEnd = 285487, XrefRangeStart = 285447, XrefRangeEnd = 285484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WillCartFit(List<ItemSlot> availableSlots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(availableSlots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_WillCartFit_Public_Boolean_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A273 RID: 41587 RVA: 0x0028D908 File Offset: 0x0028BB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285487, XrefRangeEnd = 285530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HandoverItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_HandoverItems_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A274 RID: 41588 RVA: 0x0028D950 File Offset: 0x0028BB50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 285552, RefRangeEnd = 285556, XrefRangeStart = 285530, XrefRangeEnd = 285552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemSlot> GetAvailableSlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_GetAvailableSlots_Public_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
		}

		// Token: 0x0600A275 RID: 41589 RVA: 0x0028D990 File Offset: 0x0028BB90
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 285563, RefRangeEnd = 285568, XrefRangeStart = 285556, XrefRangeEnd = 285563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle GetLoadingBayVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_GetLoadingBayVehicle_Public_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
		}

		// Token: 0x0600A276 RID: 41590 RVA: 0x0028D9D0 File Offset: 0x0028BBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285568, XrefRangeEnd = 285577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceItemInDeliveryBay(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_PlaceItemInDeliveryBay_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A277 RID: 41591 RVA: 0x0028DA14 File Offset: 0x0028BC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285577, XrefRangeEnd = 285590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuantitySelected(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_QuantitySelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A278 RID: 41592 RVA: 0x0028DA54 File Offset: 0x0028BC54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285603, RefRangeEnd = 285604, XrefRangeStart = 285590, XrefRangeEnd = 285603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenAmountSelector(ListingUI listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OpenAmountSelector_Public_Void_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A279 RID: 41593 RVA: 0x0028DA98 File Offset: 0x0028BC98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285613, RefRangeEnd = 285614, XrefRangeStart = 285604, XrefRangeEnd = 285613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropdownClicked(ListingUI listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_DropdownClicked_Private_Void_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A27A RID: 41594 RVA: 0x0028DADC File Offset: 0x0028BCDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285616, RefRangeEnd = 285617, XrefRangeStart = 285614, XrefRangeEnd = 285616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryHovered(ListingUI listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_EntryHovered_Private_Void_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A27B RID: 41595 RVA: 0x0028DB20 File Offset: 0x0028BD20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285617, XrefRangeEnd = 285619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryUnhovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_EntryUnhovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A27C RID: 41596 RVA: 0x0028DB54 File Offset: 0x0028BD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285619, XrefRangeEnd = 285649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(ShopData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_Load_Public_Void_ShopData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A27D RID: 41597 RVA: 0x0028DB98 File Offset: 0x0028BD98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285666, RefRangeEnd = 285667, XrefRangeStart = 285649, XrefRangeEnd = 285666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A27E RID: 41598 RVA: 0x0028DBD4 File Offset: 0x0028BDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285667, XrefRangeEnd = 285682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopListing GetListing(string itemID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_GetListing_Public_ShopListing_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr3) : null;
		}

		// Token: 0x0600A27F RID: 41599 RVA: 0x0028DC24 File Offset: 0x0028BE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285682, XrefRangeEnd = 285724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600A280 RID: 41600 RVA: 0x0028DC68 File Offset: 0x0028BE68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285774, RefRangeEnd = 285775, XrefRangeStart = 285724, XrefRangeEnd = 285774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A281 RID: 41601 RVA: 0x0028DCA4 File Offset: 0x0028BEA4
		[CallerCount(0)]
		public unsafe bool _DeselectCurrentCategory_b__72_0(CategoryButton x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr__DeselectCurrentCategory_b__72_0_Private_Boolean_CategoryButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A282 RID: 41602 RVA: 0x0004FDE3 File Offset: 0x0004DFE3
		public ShopInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003205 RID: 12805
		// (get) Token: 0x0600A283 RID: 41603 RVA: 0x0028DCF4 File Offset: 0x0028BEF4
		// (set) Token: 0x0600A284 RID: 41604 RVA: 0x0004FDEC File Offset: 0x0004DFEC
		public unsafe static List<ShopInterface> AllShops
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShopInterface.NativeFieldInfoPtr_AllShops, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShopInterface>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShopInterface.NativeFieldInfoPtr_AllShops, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003206 RID: 12806
		// (get) Token: 0x0600A285 RID: 41605 RVA: 0x0028DD1C File Offset: 0x0028BF1C
		// (set) Token: 0x0600A286 RID: 41606 RVA: 0x0004FDFE File Offset: 0x0004DFFE
		public unsafe static int MAX_ITEM_QUANTITY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShopInterface.NativeFieldInfoPtr_MAX_ITEM_QUANTITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShopInterface.NativeFieldInfoPtr_MAX_ITEM_QUANTITY, (void*)(&value));
			}
		}

		// Token: 0x17003207 RID: 12807
		// (get) Token: 0x0600A287 RID: 41607 RVA: 0x0028DD38 File Offset: 0x0028BF38
		// (set) Token: 0x0600A288 RID: 41608 RVA: 0x0004FE0C File Offset: 0x0004E00C
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003208 RID: 12808
		// (get) Token: 0x0600A289 RID: 41609 RVA: 0x0028DD60 File Offset: 0x0028BF60
		// (set) Token: 0x0600A28A RID: 41610 RVA: 0x0004FE27 File Offset: 0x0004E027
		public unsafe string ShopName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShopName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShopName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003209 RID: 12809
		// (get) Token: 0x0600A28B RID: 41611 RVA: 0x0028DD88 File Offset: 0x0028BF88
		// (set) Token: 0x0600A28C RID: 41612 RVA: 0x0004FE46 File Offset: 0x0004E046
		public unsafe string ShopCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShopCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShopCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700320A RID: 12810
		// (get) Token: 0x0600A28D RID: 41613 RVA: 0x0028DDB0 File Offset: 0x0028BFB0
		// (set) Token: 0x0600A28E RID: 41614 RVA: 0x0004FE65 File Offset: 0x0004E065
		public unsafe ShopInterface.EPaymentType PaymentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_PaymentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_PaymentType)) = value;
			}
		}

		// Token: 0x1700320B RID: 12811
		// (get) Token: 0x0600A28F RID: 41615 RVA: 0x0028DDD8 File Offset: 0x0028BFD8
		// (set) Token: 0x0600A290 RID: 41616 RVA: 0x0004FE80 File Offset: 0x0004E080
		public unsafe bool ShowCurrencyHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShowCurrencyHint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShowCurrencyHint)) = value;
			}
		}

		// Token: 0x1700320C RID: 12812
		// (get) Token: 0x0600A291 RID: 41617 RVA: 0x0028DE00 File Offset: 0x0028C000
		// (set) Token: 0x0600A292 RID: 41618 RVA: 0x0004FE9B File Offset: 0x0004E09B
		public unsafe List<ShopListing> Listings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Listings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShopListing>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Listings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700320D RID: 12813
		// (get) Token: 0x0600A293 RID: 41619 RVA: 0x0028DE30 File Offset: 0x0028C030
		// (set) Token: 0x0600A294 RID: 41620 RVA: 0x0004FEBA File Offset: 0x0004E0BA
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700320E RID: 12814
		// (get) Token: 0x0600A295 RID: 41621 RVA: 0x0028DE60 File Offset: 0x0028C060
		// (set) Token: 0x0600A296 RID: 41622 RVA: 0x0004FED9 File Offset: 0x0004E0D9
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700320F RID: 12815
		// (get) Token: 0x0600A297 RID: 41623 RVA: 0x0028DE90 File Offset: 0x0028C090
		// (set) Token: 0x0600A298 RID: 41624 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
		public unsafe RectTransform ListingContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003210 RID: 12816
		// (get) Token: 0x0600A299 RID: 41625 RVA: 0x0028DEC0 File Offset: 0x0028C0C0
		// (set) Token: 0x0600A29A RID: 41626 RVA: 0x0004FF17 File Offset: 0x0004E117
		public unsafe TextMeshProUGUI StoreNameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_StoreNameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_StoreNameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003211 RID: 12817
		// (get) Token: 0x0600A29B RID: 41627 RVA: 0x0028DEF0 File Offset: 0x0028C0F0
		// (set) Token: 0x0600A29C RID: 41628 RVA: 0x0004FF36 File Offset: 0x0004E136
		public unsafe Cart Cart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Cart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cart>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Cart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003212 RID: 12818
		// (get) Token: 0x0600A29D RID: 41629 RVA: 0x0028DF20 File Offset: 0x0028C120
		// (set) Token: 0x0600A29E RID: 41630 RVA: 0x0004FF55 File Offset: 0x0004E155
		public unsafe Il2CppReferenceArray<StorageEntity> DeliveryBays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DeliveryBays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StorageEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DeliveryBays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003213 RID: 12819
		// (get) Token: 0x0600A29F RID: 41631 RVA: 0x0028DF50 File Offset: 0x0028C150
		// (set) Token: 0x0600A2A0 RID: 41632 RVA: 0x0004FF74 File Offset: 0x0004E174
		public unsafe VehicleDetector LoadingBayDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_LoadingBayDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_LoadingBayDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003214 RID: 12820
		// (get) Token: 0x0600A2A1 RID: 41633 RVA: 0x0028DF80 File Offset: 0x0028C180
		// (set) Token: 0x0600A2A2 RID: 41634 RVA: 0x0004FF93 File Offset: 0x0004E193
		public unsafe ShopInterfaceDetailPanel DetailPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DetailPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterfaceDetailPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DetailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003215 RID: 12821
		// (get) Token: 0x0600A2A3 RID: 41635 RVA: 0x0028DFB0 File Offset: 0x0028C1B0
		// (set) Token: 0x0600A2A4 RID: 41636 RVA: 0x0004FFB2 File Offset: 0x0004E1B2
		public unsafe ScrollRect ListingScrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingScrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003216 RID: 12822
		// (get) Token: 0x0600A2A5 RID: 41637 RVA: 0x0028DFE0 File Offset: 0x0028C1E0
		// (set) Token: 0x0600A2A6 RID: 41638 RVA: 0x0004FFD1 File Offset: 0x0004E1D1
		public unsafe ShopAmountSelector AmountSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_AmountSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopAmountSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_AmountSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003217 RID: 12823
		// (get) Token: 0x0600A2A7 RID: 41639 RVA: 0x0028E010 File Offset: 0x0028C210
		// (set) Token: 0x0600A2A8 RID: 41640 RVA: 0x0004FFF0 File Offset: 0x0004E1F0
		public unsafe DeliveryVehicle DeliveryVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DeliveryVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DeliveryVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003218 RID: 12824
		// (get) Token: 0x0600A2A9 RID: 41641 RVA: 0x0028E040 File Offset: 0x0028C240
		// (set) Token: 0x0600A2AA RID: 41642 RVA: 0x0005000F File Offset: 0x0004E20F
		public unsafe AudioSourceController AddItemSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_AddItemSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_AddItemSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003219 RID: 12825
		// (get) Token: 0x0600A2AB RID: 41643 RVA: 0x0028E070 File Offset: 0x0028C270
		// (set) Token: 0x0600A2AC RID: 41644 RVA: 0x0005002E File Offset: 0x0004E22E
		public unsafe AudioSourceController RemoveItemSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_RemoveItemSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_RemoveItemSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700321A RID: 12826
		// (get) Token: 0x0600A2AD RID: 41645 RVA: 0x0028E0A0 File Offset: 0x0028C2A0
		// (set) Token: 0x0600A2AE RID: 41646 RVA: 0x0005004D File Offset: 0x0004E24D
		public unsafe AudioSourceController CheckoutSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_CheckoutSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_CheckoutSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700321B RID: 12827
		// (get) Token: 0x0600A2AF RID: 41647 RVA: 0x0028E0D0 File Offset: 0x0028C2D0
		// (set) Token: 0x0600A2B0 RID: 41648 RVA: 0x0005006C File Offset: 0x0004E26C
		public unsafe ListingUI ListingUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700321C RID: 12828
		// (get) Token: 0x0600A2B1 RID: 41649 RVA: 0x0028E100 File Offset: 0x0028C300
		// (set) Token: 0x0600A2B2 RID: 41650 RVA: 0x0005008B File Offset: 0x0004E28B
		public unsafe UnityEvent onOrderCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_onOrderCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_onOrderCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700321D RID: 12829
		// (get) Token: 0x0600A2B3 RID: 41651 RVA: 0x0028E130 File Offset: 0x0028C330
		// (set) Token: 0x0600A2B4 RID: 41652 RVA: 0x000500AA File Offset: 0x0004E2AA
		public unsafe List<CategoryButton> categoryButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_categoryButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CategoryButton>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_categoryButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700321E RID: 12830
		// (get) Token: 0x0600A2B5 RID: 41653 RVA: 0x0028E160 File Offset: 0x0028C360
		// (set) Token: 0x0600A2B6 RID: 41654 RVA: 0x000500C9 File Offset: 0x0004E2C9
		public unsafe EShopCategory categoryFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_categoryFilter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_categoryFilter)) = value;
			}
		}

		// Token: 0x1700321F RID: 12831
		// (get) Token: 0x0600A2B7 RID: 41655 RVA: 0x0028E188 File Offset: 0x0028C388
		// (set) Token: 0x0600A2B8 RID: 41656 RVA: 0x000500E4 File Offset: 0x0004E2E4
		public unsafe string searchTerm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_searchTerm);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_searchTerm), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003220 RID: 12832
		// (get) Token: 0x0600A2B9 RID: 41657 RVA: 0x0028E1B0 File Offset: 0x0028C3B0
		// (set) Token: 0x0600A2BA RID: 41658 RVA: 0x00050103 File Offset: 0x0004E303
		public unsafe List<ListingUI> listingUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_listingUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ListingUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_listingUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003221 RID: 12833
		// (get) Token: 0x0600A2BB RID: 41659 RVA: 0x0028E1E0 File Offset: 0x0028C3E0
		// (set) Token: 0x0600A2BC RID: 41660 RVA: 0x00050122 File Offset: 0x0004E322
		public unsafe ListingUI selectedListing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_selectedListing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_selectedListing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003222 RID: 12834
		// (get) Token: 0x0600A2BD RID: 41661 RVA: 0x0028E210 File Offset: 0x0028C410
		// (set) Token: 0x0600A2BE RID: 41662 RVA: 0x00050141 File Offset: 0x0004E341
		public unsafe bool dropdownMouseUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_dropdownMouseUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_dropdownMouseUp)) = value;
			}
		}

		// Token: 0x17003223 RID: 12835
		// (get) Token: 0x0600A2BF RID: 41663 RVA: 0x0028E238 File Offset: 0x0028C438
		// (set) Token: 0x0600A2C0 RID: 41664 RVA: 0x0005015C File Offset: 0x0004E35C
		public unsafe ShopLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003224 RID: 12836
		// (get) Token: 0x0600A2C1 RID: 41665 RVA: 0x0028E268 File Offset: 0x0028C468
		// (set) Token: 0x0600A2C2 RID: 41666 RVA: 0x0005017B File Offset: 0x0004E37B
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003225 RID: 12837
		// (get) Token: 0x0600A2C3 RID: 41667 RVA: 0x0028E298 File Offset: 0x0028C498
		// (set) Token: 0x0600A2C4 RID: 41668 RVA: 0x0005019A File Offset: 0x0004E39A
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003226 RID: 12838
		// (get) Token: 0x0600A2C5 RID: 41669 RVA: 0x0028E2C8 File Offset: 0x0028C4C8
		// (set) Token: 0x0600A2C6 RID: 41670 RVA: 0x000501B9 File Offset: 0x0004E3B9
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04006CDF RID: 27871
		private static readonly IntPtr NativeFieldInfoPtr_AllShops;

		// Token: 0x04006CE0 RID: 27872
		private static readonly IntPtr NativeFieldInfoPtr_MAX_ITEM_QUANTITY;

		// Token: 0x04006CE1 RID: 27873
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006CE2 RID: 27874
		private static readonly IntPtr NativeFieldInfoPtr_ShopName;

		// Token: 0x04006CE3 RID: 27875
		private static readonly IntPtr NativeFieldInfoPtr_ShopCode;

		// Token: 0x04006CE4 RID: 27876
		private static readonly IntPtr NativeFieldInfoPtr_PaymentType;

		// Token: 0x04006CE5 RID: 27877
		private static readonly IntPtr NativeFieldInfoPtr_ShowCurrencyHint;

		// Token: 0x04006CE6 RID: 27878
		private static readonly IntPtr NativeFieldInfoPtr_Listings;

		// Token: 0x04006CE7 RID: 27879
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006CE8 RID: 27880
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006CE9 RID: 27881
		private static readonly IntPtr NativeFieldInfoPtr_ListingContainer;

		// Token: 0x04006CEA RID: 27882
		private static readonly IntPtr NativeFieldInfoPtr_StoreNameLabel;

		// Token: 0x04006CEB RID: 27883
		private static readonly IntPtr NativeFieldInfoPtr_Cart;

		// Token: 0x04006CEC RID: 27884
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryBays;

		// Token: 0x04006CED RID: 27885
		private static readonly IntPtr NativeFieldInfoPtr_LoadingBayDetector;

		// Token: 0x04006CEE RID: 27886
		private static readonly IntPtr NativeFieldInfoPtr_DetailPanel;

		// Token: 0x04006CEF RID: 27887
		private static readonly IntPtr NativeFieldInfoPtr_ListingScrollRect;

		// Token: 0x04006CF0 RID: 27888
		private static readonly IntPtr NativeFieldInfoPtr_AmountSelector;

		// Token: 0x04006CF1 RID: 27889
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryVehicle;

		// Token: 0x04006CF2 RID: 27890
		private static readonly IntPtr NativeFieldInfoPtr_AddItemSound;

		// Token: 0x04006CF3 RID: 27891
		private static readonly IntPtr NativeFieldInfoPtr_RemoveItemSound;

		// Token: 0x04006CF4 RID: 27892
		private static readonly IntPtr NativeFieldInfoPtr_CheckoutSound;

		// Token: 0x04006CF5 RID: 27893
		private static readonly IntPtr NativeFieldInfoPtr_ListingUIPrefab;

		// Token: 0x04006CF6 RID: 27894
		private static readonly IntPtr NativeFieldInfoPtr_onOrderCompleted;

		// Token: 0x04006CF7 RID: 27895
		private static readonly IntPtr NativeFieldInfoPtr_categoryButtons;

		// Token: 0x04006CF8 RID: 27896
		private static readonly IntPtr NativeFieldInfoPtr_categoryFilter;

		// Token: 0x04006CF9 RID: 27897
		private static readonly IntPtr NativeFieldInfoPtr_searchTerm;

		// Token: 0x04006CFA RID: 27898
		private static readonly IntPtr NativeFieldInfoPtr_listingUI;

		// Token: 0x04006CFB RID: 27899
		private static readonly IntPtr NativeFieldInfoPtr_selectedListing;

		// Token: 0x04006CFC RID: 27900
		private static readonly IntPtr NativeFieldInfoPtr_dropdownMouseUp;

		// Token: 0x04006CFD RID: 27901
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04006CFE RID: 27902
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04006CFF RID: 27903
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04006D00 RID: 27904
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04006D01 RID: 27905
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006D02 RID: 27906
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006D03 RID: 27907
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04006D04 RID: 27908
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04006D05 RID: 27909
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04006D06 RID: 27910
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04006D07 RID: 27911
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04006D08 RID: 27912
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04006D09 RID: 27913
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04006D0A RID: 27914
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04006D0B RID: 27915
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04006D0C RID: 27916
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04006D0D RID: 27917
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04006D0E RID: 27918
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006D0F RID: 27919
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04006D10 RID: 27920
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04006D11 RID: 27921
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04006D12 RID: 27922
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006D13 RID: 27923
		private static readonly IntPtr NativeMethodInfoPtr_OnDayPass_Protected_Void_0;

		// Token: 0x04006D14 RID: 27924
		private static readonly IntPtr NativeMethodInfoPtr_OnWeekPass_Protected_Void_0;

		// Token: 0x04006D15 RID: 27925
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04006D16 RID: 27926
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04006D17 RID: 27927
		private static readonly IntPtr NativeMethodInfoPtr_Hint_Private_Void_0;

		// Token: 0x04006D18 RID: 27928
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0;

		// Token: 0x04006D19 RID: 27929
		private static readonly IntPtr NativeMethodInfoPtr_CreateListingUI_Private_Void_ShopListing_0;

		// Token: 0x04006D1A RID: 27930
		private static readonly IntPtr NativeMethodInfoPtr_SelectCategory_Public_Void_EShopCategory_0;

		// Token: 0x04006D1B RID: 27931
		private static readonly IntPtr NativeMethodInfoPtr_ListingClicked_Public_Virtual_New_Void_ListingUI_0;

		// Token: 0x04006D1C RID: 27932
		private static readonly IntPtr NativeMethodInfoPtr_ShowCartAnimation_Private_Void_ListingUI_0;

		// Token: 0x04006D1D RID: 27933
		private static readonly IntPtr NativeMethodInfoPtr_CategorySelected_Public_Void_EShopCategory_0;

		// Token: 0x04006D1E RID: 27934
		private static readonly IntPtr NativeMethodInfoPtr_DeselectCurrentCategory_Private_Void_0;

		// Token: 0x04006D1F RID: 27935
		private static readonly IntPtr NativeMethodInfoPtr_RefreshShownItems_Private_Void_0;

		// Token: 0x04006D20 RID: 27936
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUnlockStatus_Private_Void_0;

		// Token: 0x04006D21 RID: 27937
		private static readonly IntPtr NativeMethodInfoPtr_RestockAllListings_Private_Void_0;

		// Token: 0x04006D22 RID: 27938
		private static readonly IntPtr NativeMethodInfoPtr_CanCartFitItem_Public_Boolean_ShopListing_0;

		// Token: 0x04006D23 RID: 27939
		private static readonly IntPtr NativeMethodInfoPtr_WillCartFit_Public_Boolean_0;

		// Token: 0x04006D24 RID: 27940
		private static readonly IntPtr NativeMethodInfoPtr_WillCartFit_Public_Boolean_List_1_ItemSlot_0;

		// Token: 0x04006D25 RID: 27941
		private static readonly IntPtr NativeMethodInfoPtr_HandoverItems_Public_Virtual_New_Boolean_0;

		// Token: 0x04006D26 RID: 27942
		private static readonly IntPtr NativeMethodInfoPtr_GetAvailableSlots_Public_List_1_ItemSlot_0;

		// Token: 0x04006D27 RID: 27943
		private static readonly IntPtr NativeMethodInfoPtr_GetLoadingBayVehicle_Public_LandVehicle_0;

		// Token: 0x04006D28 RID: 27944
		private static readonly IntPtr NativeMethodInfoPtr_PlaceItemInDeliveryBay_Public_Void_ItemInstance_0;

		// Token: 0x04006D29 RID: 27945
		private static readonly IntPtr NativeMethodInfoPtr_QuantitySelected_Public_Void_Int32_0;

		// Token: 0x04006D2A RID: 27946
		private static readonly IntPtr NativeMethodInfoPtr_OpenAmountSelector_Public_Void_ListingUI_0;

		// Token: 0x04006D2B RID: 27947
		private static readonly IntPtr NativeMethodInfoPtr_DropdownClicked_Private_Void_ListingUI_0;

		// Token: 0x04006D2C RID: 27948
		private static readonly IntPtr NativeMethodInfoPtr_EntryHovered_Private_Void_ListingUI_0;

		// Token: 0x04006D2D RID: 27949
		private static readonly IntPtr NativeMethodInfoPtr_EntryUnhovered_Private_Void_0;

		// Token: 0x04006D2E RID: 27950
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_ShopData_0;

		// Token: 0x04006D2F RID: 27951
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Boolean_0;

		// Token: 0x04006D30 RID: 27952
		private static readonly IntPtr NativeMethodInfoPtr_GetListing_Public_ShopListing_String_0;

		// Token: 0x04006D31 RID: 27953
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04006D32 RID: 27954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006D33 RID: 27955
		private static readonly IntPtr NativeMethodInfoPtr__DeselectCurrentCategory_b__72_0_Private_Boolean_CategoryButton_0;

		// Token: 0x02000BB6 RID: 2998
		[OriginalName("Assembly-CSharp.dll", "", "EPaymentType")]
		public enum EPaymentType
		{
			// Token: 0x04009448 RID: 37960
			Cash,
			// Token: 0x04009449 RID: 37961
			Online,
			// Token: 0x0400944A RID: 37962
			PreferCash,
			// Token: 0x0400944B RID: 37963
			PreferOnline
		}

		// Token: 0x02000BB7 RID: 2999
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DD59 RID: 56665 RVA: 0x00344894 File Offset: 0x00342A94
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr);
				ShopInterface.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, "<>9");
				ShopInterface.__c.NativeFieldInfoPtr___9__55_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, "<>9__55_0");
				ShopInterface.__c.NativeFieldInfoPtr___9__73_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, "<>9__73_0");
				ShopInterface.__c.NativeFieldInfoPtr___9__73_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, "<>9__73_1");
				ShopInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, 100683198);
				ShopInterface.__c.NativeMethodInfoPtr__Awake_b__55_0_Internal_String_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, 100683199);
				ShopInterface.__c.NativeMethodInfoPtr__RefreshShownItems_b__73_0_Internal_Boolean_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, 100683200);
				ShopInterface.__c.NativeMethodInfoPtr__RefreshShownItems_b__73_1_Internal_Int32_ListingUI_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, 100683201);
			}

			// Token: 0x0600DD5A RID: 56666 RVA: 0x00344960 File Offset: 0x00342B60
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD5B RID: 56667 RVA: 0x0034499C File Offset: 0x00342B9C
			[CallerCount(0)]
			public unsafe string _Awake_b__55_0(ShopListing x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c.NativeMethodInfoPtr__Awake_b__55_0_Internal_String_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DD5C RID: 56668 RVA: 0x003449E4 File Offset: 0x00342BE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284783, XrefRangeEnd = 284784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefreshShownItems_b__73_0(ListingUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c.NativeMethodInfoPtr__RefreshShownItems_b__73_0_Internal_Boolean_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD5D RID: 56669 RVA: 0x00344A34 File Offset: 0x00342C34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284784, XrefRangeEnd = 284786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RefreshShownItems_b__73_1(ListingUI x, ListingUI y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c.NativeMethodInfoPtr__RefreshShownItems_b__73_1_Internal_Int32_ListingUI_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD5E RID: 56670 RVA: 0x0006BE1C File Offset: 0x0006A01C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700449A RID: 17562
			// (get) Token: 0x0600DD5F RID: 56671 RVA: 0x00344A94 File Offset: 0x00342C94
			// (set) Token: 0x0600DD60 RID: 56672 RVA: 0x0006BE25 File Offset: 0x0006A025
			public unsafe static ShopInterface.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShopInterface.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShopInterface.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700449B RID: 17563
			// (get) Token: 0x0600DD61 RID: 56673 RVA: 0x00344ABC File Offset: 0x00342CBC
			// (set) Token: 0x0600DD62 RID: 56674 RVA: 0x0006BE37 File Offset: 0x0006A037
			public unsafe static Func<ShopListing, string> __9__55_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShopInterface.__c.NativeFieldInfoPtr___9__55_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ShopListing, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShopInterface.__c.NativeFieldInfoPtr___9__55_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700449C RID: 17564
			// (get) Token: 0x0600DD63 RID: 56675 RVA: 0x00344AE4 File Offset: 0x00342CE4
			// (set) Token: 0x0600DD64 RID: 56676 RVA: 0x0006BE49 File Offset: 0x0006A049
			public unsafe static Predicate<ListingUI> __9__73_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShopInterface.__c.NativeFieldInfoPtr___9__73_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ListingUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShopInterface.__c.NativeFieldInfoPtr___9__73_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700449D RID: 17565
			// (get) Token: 0x0600DD65 RID: 56677 RVA: 0x00344B0C File Offset: 0x00342D0C
			// (set) Token: 0x0600DD66 RID: 56678 RVA: 0x0006BE5B File Offset: 0x0006A05B
			public unsafe static Comparison<ListingUI> __9__73_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShopInterface.__c.NativeFieldInfoPtr___9__73_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ListingUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShopInterface.__c.NativeFieldInfoPtr___9__73_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400944C RID: 37964
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400944D RID: 37965
			private static readonly IntPtr NativeFieldInfoPtr___9__55_0;

			// Token: 0x0400944E RID: 37966
			private static readonly IntPtr NativeFieldInfoPtr___9__73_0;

			// Token: 0x0400944F RID: 37967
			private static readonly IntPtr NativeFieldInfoPtr___9__73_1;

			// Token: 0x04009450 RID: 37968
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009451 RID: 37969
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__55_0_Internal_String_ShopListing_0;

			// Token: 0x04009452 RID: 37970
			private static readonly IntPtr NativeMethodInfoPtr__RefreshShownItems_b__73_0_Internal_Boolean_ListingUI_0;

			// Token: 0x04009453 RID: 37971
			private static readonly IntPtr NativeMethodInfoPtr__RefreshShownItems_b__73_1_Internal_Int32_ListingUI_ListingUI_0;
		}

		// Token: 0x02000BB8 RID: 3000
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass67_0")]
		public sealed class __c__DisplayClass67_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD67 RID: 56679 RVA: 0x00344B34 File Offset: 0x00342D34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass67_0()
			{
				Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c__DisplayClass67_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr);
				ShopInterface.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr, "<>4__this");
				ShopInterface.__c__DisplayClass67_0.NativeFieldInfoPtr_ui = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr, "ui");
				ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr, 100683202);
				ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateListingUI_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr, 100683203);
				ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateListingUI_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr, 100683204);
				ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateListingUI_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr, 100683205);
			}

			// Token: 0x0600DD68 RID: 56680 RVA: 0x00344BD8 File Offset: 0x00342DD8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass67_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD69 RID: 56681 RVA: 0x00344C14 File Offset: 0x00342E14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284786, XrefRangeEnd = 284787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateListingUI_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateListingUI_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD6A RID: 56682 RVA: 0x00344C48 File Offset: 0x00342E48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284787, XrefRangeEnd = 284789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateListingUI_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateListingUI_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD6B RID: 56683 RVA: 0x00344C7C File Offset: 0x00342E7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284789, XrefRangeEnd = 284791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateListingUI_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateListingUI_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD6C RID: 56684 RVA: 0x0006BE6D File Offset: 0x0006A06D
			public __c__DisplayClass67_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700449E RID: 17566
			// (get) Token: 0x0600DD6D RID: 56685 RVA: 0x00344CB0 File Offset: 0x00342EB0
			// (set) Token: 0x0600DD6E RID: 56686 RVA: 0x0006BE76 File Offset: 0x0006A076
			public unsafe ShopInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700449F RID: 17567
			// (get) Token: 0x0600DD6F RID: 56687 RVA: 0x00344CE0 File Offset: 0x00342EE0
			// (set) Token: 0x0600DD70 RID: 56688 RVA: 0x0006BE95 File Offset: 0x0006A095
			public unsafe ListingUI ui
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass67_0.NativeFieldInfoPtr_ui);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass67_0.NativeFieldInfoPtr_ui), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009454 RID: 37972
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009455 RID: 37973
			private static readonly IntPtr NativeFieldInfoPtr_ui;

			// Token: 0x04009456 RID: 37974
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009457 RID: 37975
			private static readonly IntPtr NativeMethodInfoPtr__CreateListingUI_b__0_Internal_Void_0;

			// Token: 0x04009458 RID: 37976
			private static readonly IntPtr NativeMethodInfoPtr__CreateListingUI_b__1_Internal_Void_0;

			// Token: 0x04009459 RID: 37977
			private static readonly IntPtr NativeMethodInfoPtr__CreateListingUI_b__2_Internal_Void_0;
		}

		// Token: 0x02000BB9 RID: 3001
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass68_0")]
		public sealed class __c__DisplayClass68_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD71 RID: 56689 RVA: 0x00344D10 File Offset: 0x00342F10
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass68_0()
			{
				Il2CppClassPointerStore<ShopInterface.__c__DisplayClass68_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c__DisplayClass68_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass68_0>.NativeClassPtr);
				ShopInterface.__c__DisplayClass68_0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass68_0>.NativeClassPtr, "category");
				ShopInterface.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass68_0>.NativeClassPtr, 100683206);
				ShopInterface.__c__DisplayClass68_0.NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_CategoryButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass68_0>.NativeClassPtr, 100683207);
			}

			// Token: 0x0600DD72 RID: 56690 RVA: 0x00344D78 File Offset: 0x00342F78
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass68_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass68_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD73 RID: 56691 RVA: 0x00344DB4 File Offset: 0x00342FB4
			[CallerCount(0)]
			public unsafe bool _SelectCategory_b__0(CategoryButton x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass68_0.NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_CategoryButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD74 RID: 56692 RVA: 0x0006BEB4 File Offset: 0x0006A0B4
			public __c__DisplayClass68_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044A0 RID: 17568
			// (get) Token: 0x0600DD75 RID: 56693 RVA: 0x00344E04 File Offset: 0x00343004
			// (set) Token: 0x0600DD76 RID: 56694 RVA: 0x0006BEBD File Offset: 0x0006A0BD
			public unsafe EShopCategory category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass68_0.NativeFieldInfoPtr_category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass68_0.NativeFieldInfoPtr_category)) = value;
				}
			}

			// Token: 0x0400945A RID: 37978
			private static readonly IntPtr NativeFieldInfoPtr_category;

			// Token: 0x0400945B RID: 37979
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400945C RID: 37980
			private static readonly IntPtr NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_CategoryButton_0;
		}

		// Token: 0x02000BBA RID: 3002
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass70_0")]
		public sealed class __c__DisplayClass70_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD77 RID: 56695 RVA: 0x00344E2C File Offset: 0x0034302C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_0()
			{
				Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c__DisplayClass70_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr);
				ShopInterface.__c__DisplayClass70_0.NativeFieldInfoPtr_listing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr, "listing");
				ShopInterface.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr, "<>4__this");
				ShopInterface.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr, 100683208);
				ShopInterface.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr, 100683209);
			}

			// Token: 0x0600DD78 RID: 56696 RVA: 0x00344EA8 File Offset: 0x003430A8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD79 RID: 56697 RVA: 0x00344EE4 File Offset: 0x003430E4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 284832, RefRangeEnd = 284833, XrefRangeStart = 284827, XrefRangeEnd = 284832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DD7A RID: 56698 RVA: 0x0006BED8 File Offset: 0x0006A0D8
			public __c__DisplayClass70_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044A1 RID: 17569
			// (get) Token: 0x0600DD7B RID: 56699 RVA: 0x00344F24 File Offset: 0x00343124
			// (set) Token: 0x0600DD7C RID: 56700 RVA: 0x0006BEE1 File Offset: 0x0006A0E1
			public unsafe ListingUI listing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.NativeFieldInfoPtr_listing);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.NativeFieldInfoPtr_listing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044A2 RID: 17570
			// (get) Token: 0x0600DD7D RID: 56701 RVA: 0x00344F54 File Offset: 0x00343154
			// (set) Token: 0x0600DD7E RID: 56702 RVA: 0x0006BF00 File Offset: 0x0006A100
			public unsafe ShopInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400945D RID: 37981
			private static readonly IntPtr NativeFieldInfoPtr_listing;

			// Token: 0x0400945E RID: 37982
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400945F RID: 37983
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009460 RID: 37984
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000C83 RID: 3203
			[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass70_0+<<ShowCartAnimation>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E6A4 RID: 59044 RVA: 0x0035F734 File Offset: 0x0035D934
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique()
				{
					Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr, "<<ShowCartAnimation>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr);
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<>1__state");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<>2__current");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<>4__this");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__iconRect_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<iconRect>5__2");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__startPos_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<startPos>5__3");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__endPos_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<endPos>5__4");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__startScale_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<startScale>5__5");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__endScale_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<endScale>5__6");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__lerpTime_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<lerpTime>5__7");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__i_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<i>5__8");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, 100683210);
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, 100683211);
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, 100683212);
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, 100683213);
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, 100683214);
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, 100683215);
				}

				// Token: 0x0600E6A5 RID: 59045 RVA: 0x0035F8A0 File Offset: 0x0035DAA0
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E6A6 RID: 59046 RVA: 0x0035F8E8 File Offset: 0x0035DAE8
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E6A7 RID: 59047 RVA: 0x0035F91C File Offset: 0x0035DB1C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284791, XrefRangeEnd = 284822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170047DA RID: 18394
				// (get) Token: 0x0600E6A8 RID: 59048 RVA: 0x0035F958 File Offset: 0x0035DB58
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E6A9 RID: 59049 RVA: 0x0035F998 File Offset: 0x0035DB98
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284822, XrefRangeEnd = 284827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170047DB RID: 18395
				// (get) Token: 0x0600E6AA RID: 59050 RVA: 0x0035F9CC File Offset: 0x0035DBCC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E6AB RID: 59051 RVA: 0x0007096E File Offset: 0x0006EB6E
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047D0 RID: 18384
				// (get) Token: 0x0600E6AC RID: 59052 RVA: 0x0035FA0C File Offset: 0x0035DC0C
				// (set) Token: 0x0600E6AD RID: 59053 RVA: 0x00070977 File Offset: 0x0006EB77
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047D1 RID: 18385
				// (get) Token: 0x0600E6AE RID: 59054 RVA: 0x0035FA34 File Offset: 0x0035DC34
				// (set) Token: 0x0600E6AF RID: 59055 RVA: 0x00070992 File Offset: 0x0006EB92
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047D2 RID: 18386
				// (get) Token: 0x0600E6B0 RID: 59056 RVA: 0x0035FA64 File Offset: 0x0035DC64
				// (set) Token: 0x0600E6B1 RID: 59057 RVA: 0x000709B1 File Offset: 0x0006EBB1
				public unsafe ShopInterface.__c__DisplayClass70_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface.__c__DisplayClass70_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047D3 RID: 18387
				// (get) Token: 0x0600E6B2 RID: 59058 RVA: 0x0035FA94 File Offset: 0x0035DC94
				// (set) Token: 0x0600E6B3 RID: 59059 RVA: 0x000709D0 File Offset: 0x0006EBD0
				public unsafe RectTransform _iconRect_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__iconRect_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__iconRect_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047D4 RID: 18388
				// (get) Token: 0x0600E6B4 RID: 59060 RVA: 0x0035FAC4 File Offset: 0x0035DCC4
				// (set) Token: 0x0600E6B5 RID: 59061 RVA: 0x000709EF File Offset: 0x0006EBEF
				public unsafe Vector3 _startPos_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__startPos_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__startPos_5__3)) = value;
					}
				}

				// Token: 0x170047D5 RID: 18389
				// (get) Token: 0x0600E6B6 RID: 59062 RVA: 0x0035FAEC File Offset: 0x0035DCEC
				// (set) Token: 0x0600E6B7 RID: 59063 RVA: 0x00070A0A File Offset: 0x0006EC0A
				public unsafe Vector2 _endPos_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__endPos_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__endPos_5__4)) = value;
					}
				}

				// Token: 0x170047D6 RID: 18390
				// (get) Token: 0x0600E6B8 RID: 59064 RVA: 0x0035FB14 File Offset: 0x0035DD14
				// (set) Token: 0x0600E6B9 RID: 59065 RVA: 0x00070A25 File Offset: 0x0006EC25
				public unsafe Vector3 _startScale_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__startScale_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__startScale_5__5)) = value;
					}
				}

				// Token: 0x170047D7 RID: 18391
				// (get) Token: 0x0600E6BA RID: 59066 RVA: 0x0035FB3C File Offset: 0x0035DD3C
				// (set) Token: 0x0600E6BB RID: 59067 RVA: 0x00070A40 File Offset: 0x0006EC40
				public unsafe Vector3 _endScale_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__endScale_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__endScale_5__6)) = value;
					}
				}

				// Token: 0x170047D8 RID: 18392
				// (get) Token: 0x0600E6BC RID: 59068 RVA: 0x0035FB64 File Offset: 0x0035DD64
				// (set) Token: 0x0600E6BD RID: 59069 RVA: 0x00070A5B File Offset: 0x0006EC5B
				public unsafe float _lerpTime_5__7
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__lerpTime_5__7);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__lerpTime_5__7)) = value;
					}
				}

				// Token: 0x170047D9 RID: 18393
				// (get) Token: 0x0600E6BE RID: 59070 RVA: 0x0035FB8C File Offset: 0x0035DD8C
				// (set) Token: 0x0600E6BF RID: 59071 RVA: 0x00070A76 File Offset: 0x0006EC76
				public unsafe float _i_5__8
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__i_5__8);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__i_5__8)) = value;
					}
				}

				// Token: 0x04009A24 RID: 39460
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009A25 RID: 39461
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009A26 RID: 39462
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009A27 RID: 39463
				private static readonly IntPtr NativeFieldInfoPtr__iconRect_5__2;

				// Token: 0x04009A28 RID: 39464
				private static readonly IntPtr NativeFieldInfoPtr__startPos_5__3;

				// Token: 0x04009A29 RID: 39465
				private static readonly IntPtr NativeFieldInfoPtr__endPos_5__4;

				// Token: 0x04009A2A RID: 39466
				private static readonly IntPtr NativeFieldInfoPtr__startScale_5__5;

				// Token: 0x04009A2B RID: 39467
				private static readonly IntPtr NativeFieldInfoPtr__endScale_5__6;

				// Token: 0x04009A2C RID: 39468
				private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__7;

				// Token: 0x04009A2D RID: 39469
				private static readonly IntPtr NativeFieldInfoPtr__i_5__8;

				// Token: 0x04009A2E RID: 39470
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009A2F RID: 39471
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A30 RID: 39472
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009A31 RID: 39473
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009A32 RID: 39474
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A33 RID: 39475
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000BBB RID: 3003
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass88_0")]
		public sealed class __c__DisplayClass88_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD7F RID: 56703 RVA: 0x00344F84 File Offset: 0x00343184
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass88_0()
			{
				Il2CppClassPointerStore<ShopInterface.__c__DisplayClass88_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c__DisplayClass88_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass88_0>.NativeClassPtr);
				ShopInterface.__c__DisplayClass88_0.NativeFieldInfoPtr_stockQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass88_0>.NativeClassPtr, "stockQuantity");
				ShopInterface.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass88_0>.NativeClassPtr, 100683216);
				ShopInterface.__c__DisplayClass88_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass88_0>.NativeClassPtr, 100683217);
			}

			// Token: 0x0600DD80 RID: 56704 RVA: 0x00344FEC File Offset: 0x003431EC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass88_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass88_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD81 RID: 56705 RVA: 0x00345028 File Offset: 0x00343228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284833, XrefRangeEnd = 284835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Load_b__0(ShopListing x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass88_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD82 RID: 56706 RVA: 0x0006BF1F File Offset: 0x0006A11F
			public __c__DisplayClass88_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044A3 RID: 17571
			// (get) Token: 0x0600DD83 RID: 56707 RVA: 0x00345078 File Offset: 0x00343278
			// (set) Token: 0x0600DD84 RID: 56708 RVA: 0x0006BF28 File Offset: 0x0006A128
			public unsafe StringIntPair stockQuantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass88_0.NativeFieldInfoPtr_stockQuantity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringIntPair>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass88_0.NativeFieldInfoPtr_stockQuantity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009461 RID: 37985
			private static readonly IntPtr NativeFieldInfoPtr_stockQuantity;

			// Token: 0x04009462 RID: 37986
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009463 RID: 37987
			private static readonly IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopListing_0;
		}

		// Token: 0x02000BBC RID: 3004
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass90_0")]
		public sealed class __c__DisplayClass90_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD85 RID: 56709 RVA: 0x003450A8 File Offset: 0x003432A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass90_0()
			{
				Il2CppClassPointerStore<ShopInterface.__c__DisplayClass90_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c__DisplayClass90_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass90_0>.NativeClassPtr);
				ShopInterface.__c__DisplayClass90_0.NativeFieldInfoPtr_itemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass90_0>.NativeClassPtr, "itemID");
				ShopInterface.__c__DisplayClass90_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass90_0>.NativeClassPtr, 100683218);
				ShopInterface.__c__DisplayClass90_0.NativeMethodInfoPtr__GetListing_b__0_Internal_Boolean_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass90_0>.NativeClassPtr, 100683219);
			}

			// Token: 0x0600DD86 RID: 56710 RVA: 0x00345110 File Offset: 0x00343310
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass90_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass90_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass90_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD87 RID: 56711 RVA: 0x0034514C File Offset: 0x0034334C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284835, XrefRangeEnd = 284844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetListing_b__0(ShopListing x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass90_0.NativeMethodInfoPtr__GetListing_b__0_Internal_Boolean_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD88 RID: 56712 RVA: 0x0006BF47 File Offset: 0x0006A147
			public __c__DisplayClass90_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044A4 RID: 17572
			// (get) Token: 0x0600DD89 RID: 56713 RVA: 0x0034519C File Offset: 0x0034339C
			// (set) Token: 0x0600DD8A RID: 56714 RVA: 0x0006BF50 File Offset: 0x0006A150
			public unsafe string itemID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass90_0.NativeFieldInfoPtr_itemID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass90_0.NativeFieldInfoPtr_itemID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009464 RID: 37988
			private static readonly IntPtr NativeFieldInfoPtr_itemID;

			// Token: 0x04009465 RID: 37989
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009466 RID: 37990
			private static readonly IntPtr NativeMethodInfoPtr__GetListing_b__0_Internal_Boolean_ShopListing_0;
		}
	}
}
