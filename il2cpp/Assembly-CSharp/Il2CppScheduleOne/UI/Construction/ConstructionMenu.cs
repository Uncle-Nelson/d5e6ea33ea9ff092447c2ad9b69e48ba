using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Construction
{
	// Token: 0x0200071F RID: 1823
	public class ConstructionMenu : Singleton<ConstructionMenu>
	{
		// Token: 0x0600A3E7 RID: 41959 RVA: 0x00291A3C File Offset: 0x0028FC3C
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructionMenu()
		{
			Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Construction", "ConstructionMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr);
			ConstructionMenu.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "<isOpen>k__BackingField");
			ConstructionMenu.NativeFieldInfoPtr_categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "categories");
			ConstructionMenu.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "canvas");
			ConstructionMenu.NativeFieldInfoPtr_raycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "raycaster");
			ConstructionMenu.NativeFieldInfoPtr_categoryButtonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "categoryButtonContainer");
			ConstructionMenu.NativeFieldInfoPtr_categoryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "categoryContainer");
			ConstructionMenu.NativeFieldInfoPtr_categoryNameDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "categoryNameDisplay");
			ConstructionMenu.NativeFieldInfoPtr_infoPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "infoPopup");
			ConstructionMenu.NativeFieldInfoPtr_infoPopup_ConstructableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "infoPopup_ConstructableName");
			ConstructionMenu.NativeFieldInfoPtr_eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "eventSystem");
			ConstructionMenu.NativeFieldInfoPtr_destroyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "destroyButton");
			ConstructionMenu.NativeFieldInfoPtr_customizeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "customizeButton");
			ConstructionMenu.NativeFieldInfoPtr_moveButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "moveButton");
			ConstructionMenu.NativeFieldInfoPtr_infoPopup_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "infoPopup_Description");
			ConstructionMenu.NativeFieldInfoPtr_categoryButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "categoryButtonPrefab");
			ConstructionMenu.NativeFieldInfoPtr_categoryContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "categoryContainerPrefab");
			ConstructionMenu.NativeFieldInfoPtr_listingPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "listingPrefab");
			ConstructionMenu.NativeFieldInfoPtr_iconColor_Unselected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "iconColor_Unselected");
			ConstructionMenu.NativeFieldInfoPtr_iconColor_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "iconColor_Selected");
			ConstructionMenu.NativeFieldInfoPtr_listingOutlineColor_Unselected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "listingOutlineColor_Unselected");
			ConstructionMenu.NativeFieldInfoPtr_listingOutlineColor_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "listingOutlineColor_Selected");
			ConstructionMenu.NativeFieldInfoPtr_selectedCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "selectedCategory");
			ConstructionMenu.NativeFieldInfoPtr_selectedListing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "selectedListing");
			ConstructionMenu.NativeFieldInfoPtr_selectedConstructable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "selectedConstructable");
			ConstructionMenu.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683331);
			ConstructionMenu.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683332);
			ConstructionMenu.NativeMethodInfoPtr_get_SelectedConstructable_Public_get_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683333);
			ConstructionMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683334);
			ConstructionMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683335);
			ConstructionMenu.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683336);
			ConstructionMenu.NativeMethodInfoPtr_SetupListings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683337);
			ConstructionMenu.NativeMethodInfoPtr_AddListing_Private_Void_String_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683338);
			ConstructionMenu.NativeMethodInfoPtr_SetIsOpen_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683339);
			ConstructionMenu.NativeMethodInfoPtr_OnConstructableBuilt_Private_Void_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683340);
			ConstructionMenu.NativeMethodInfoPtr_ClearSelectedListing_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683341);
			ConstructionMenu.NativeMethodInfoPtr_ListingClicked_Public_Void_ConstructionMenuListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683342);
			ConstructionMenu.NativeMethodInfoPtr_IsHoveringUI_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683343);
			ConstructionMenu.NativeMethodInfoPtr_MoveButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683344);
			ConstructionMenu.NativeMethodInfoPtr_CustomizeButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683345);
			ConstructionMenu.NativeMethodInfoPtr_BulldozeButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683346);
			ConstructionMenu.NativeMethodInfoPtr_CheckConstructableSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683347);
			ConstructionMenu.NativeMethodInfoPtr_SelectConstructable_Public_Void_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683348);
			ConstructionMenu.NativeMethodInfoPtr_SelectConstructable_Public_Void_Constructable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683349);
			ConstructionMenu.NativeMethodInfoPtr_SetButtonInteractable_Private_Void_Button_Boolean_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683350);
			ConstructionMenu.NativeMethodInfoPtr_DeselectConstructable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683351);
			ConstructionMenu.NativeMethodInfoPtr_GetHoveredConstructable_Private_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683352);
			ConstructionMenu.NativeMethodInfoPtr_GenerateCategories_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683353);
			ConstructionMenu.NativeMethodInfoPtr_SelectCategory_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683354);
			ConstructionMenu.NativeMethodInfoPtr_GetListingPrice_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683355);
			ConstructionMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683356);
			ConstructionMenu.NativeMethodInfoPtr__Start_b__31_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683357);
			ConstructionMenu.NativeMethodInfoPtr__Start_b__31_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, 100683358);
		}

		// Token: 0x170032A5 RID: 12965
		// (get) Token: 0x0600A3E8 RID: 41960 RVA: 0x00291E7C File Offset: 0x0029007C
		// (set) Token: 0x0600A3E9 RID: 41961 RVA: 0x00291EB8 File Offset: 0x002900B8
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170032A6 RID: 12966
		// (get) Token: 0x0600A3EA RID: 41962 RVA: 0x00291EF8 File Offset: 0x002900F8
		public unsafe Constructable SelectedConstructable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_get_SelectedConstructable_Public_get_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr3) : null;
			}
		}

		// Token: 0x0600A3EB RID: 41963 RVA: 0x00291F38 File Offset: 0x00290138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287030, XrefRangeEnd = 287127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3EC RID: 41964 RVA: 0x00291F74 File Offset: 0x00290174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287127, XrefRangeEnd = 287133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3ED RID: 41965 RVA: 0x00291FB8 File Offset: 0x002901B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287133, XrefRangeEnd = 287134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionMenu.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3EE RID: 41966 RVA: 0x00291FF4 File Offset: 0x002901F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287134, XrefRangeEnd = 287139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupListings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_SetupListings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3EF RID: 41967 RVA: 0x00292028 File Offset: 0x00290228
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287182, RefRangeEnd = 287184, XrefRangeStart = 287139, XrefRangeEnd = 287182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddListing(string ID, float price, string category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(category);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_AddListing_Private_Void_String_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3F0 RID: 41968 RVA: 0x0029208C File Offset: 0x0029028C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287201, RefRangeEnd = 287202, XrefRangeStart = 287184, XrefRangeEnd = 287201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_SetIsOpen_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3F1 RID: 41969 RVA: 0x002920CC File Offset: 0x002902CC
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnConstructableBuilt(Constructable c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_OnConstructableBuilt_Private_Void_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3F2 RID: 41970 RVA: 0x00292110 File Offset: 0x00290310
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 287209, RefRangeEnd = 287215, XrefRangeStart = 287202, XrefRangeEnd = 287209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSelectedListing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_ClearSelectedListing_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3F3 RID: 41971 RVA: 0x00292144 File Offset: 0x00290344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287215, XrefRangeEnd = 287224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ListingClicked(ConstructionMenu.ConstructionMenuListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_ListingClicked_Public_Void_ConstructionMenuListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3F4 RID: 41972 RVA: 0x00292188 File Offset: 0x00290388
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287236, RefRangeEnd = 287238, XrefRangeStart = 287224, XrefRangeEnd = 287236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsHoveringUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_IsHoveringUI_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A3F5 RID: 41973 RVA: 0x002921C4 File Offset: 0x002903C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287238, XrefRangeEnd = 287252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_MoveButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3F6 RID: 41974 RVA: 0x002921F8 File Offset: 0x002903F8
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CustomizeButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_CustomizeButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3F7 RID: 41975 RVA: 0x0029222C File Offset: 0x0029042C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287252, XrefRangeEnd = 287259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BulldozeButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_BulldozeButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3F8 RID: 41976 RVA: 0x00292260 File Offset: 0x00290460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287299, RefRangeEnd = 287300, XrefRangeStart = 287259, XrefRangeEnd = 287299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckConstructableSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_CheckConstructableSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3F9 RID: 41977 RVA: 0x00292294 File Offset: 0x00290494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287300, XrefRangeEnd = 287301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectConstructable(Constructable c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_SelectConstructable_Public_Void_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3FA RID: 41978 RVA: 0x002922D8 File Offset: 0x002904D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287376, RefRangeEnd = 287377, XrefRangeStart = 287301, XrefRangeEnd = 287376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectConstructable(Constructable c, bool focusCameraTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref focusCameraTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_SelectConstructable_Public_Void_Constructable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3FB RID: 41979 RVA: 0x00292328 File Offset: 0x00290528
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287385, RefRangeEnd = 287387, XrefRangeStart = 287377, XrefRangeEnd = 287385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetButtonInteractable(Button b, bool interactable, Color32 iconDefaultColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interactable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iconDefaultColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_SetButtonInteractable_Private_Void_Button_Boolean_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3FC RID: 41980 RVA: 0x00292388 File Offset: 0x00290588
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 287402, RefRangeEnd = 287410, XrefRangeStart = 287387, XrefRangeEnd = 287402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeselectConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_DeselectConstructable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3FD RID: 41981 RVA: 0x002923BC File Offset: 0x002905BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287410, XrefRangeEnd = 287420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Constructable GetHoveredConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_GetHoveredConstructable_Private_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr3) : null;
		}

		// Token: 0x0600A3FE RID: 41982 RVA: 0x002923FC File Offset: 0x002905FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287483, RefRangeEnd = 287484, XrefRangeStart = 287420, XrefRangeEnd = 287483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateCategories()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_GenerateCategories_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3FF RID: 41983 RVA: 0x00292430 File Offset: 0x00290630
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287519, RefRangeEnd = 287521, XrefRangeStart = 287484, XrefRangeEnd = 287519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectCategory(string categoryName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_SelectCategory_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A400 RID: 41984 RVA: 0x00292474 File Offset: 0x00290674
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 287540, RefRangeEnd = 287544, XrefRangeStart = 287521, XrefRangeEnd = 287540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetListingPrice(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr_GetListingPrice_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A401 RID: 41985 RVA: 0x002924C4 File Offset: 0x002906C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287544, XrefRangeEnd = 287554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A402 RID: 41986 RVA: 0x00292500 File Offset: 0x00290700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287554, XrefRangeEnd = 287555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__31_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr__Start_b__31_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A403 RID: 41987 RVA: 0x00292534 File Offset: 0x00290734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287555, XrefRangeEnd = 287566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__31_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.NativeMethodInfoPtr__Start_b__31_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A404 RID: 41988 RVA: 0x00050BD8 File Offset: 0x0004EDD8
		public ConstructionMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700328D RID: 12941
		// (get) Token: 0x0600A405 RID: 41989 RVA: 0x00292568 File Offset: 0x00290768
		// (set) Token: 0x0600A406 RID: 41990 RVA: 0x00050BE1 File Offset: 0x0004EDE1
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700328E RID: 12942
		// (get) Token: 0x0600A407 RID: 41991 RVA: 0x00292590 File Offset: 0x00290790
		// (set) Token: 0x0600A408 RID: 41992 RVA: 0x00050BFC File Offset: 0x0004EDFC
		public unsafe List<ConstructionMenu.ConstructionMenuCategory> categories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ConstructionMenu.ConstructionMenuCategory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700328F RID: 12943
		// (get) Token: 0x0600A409 RID: 41993 RVA: 0x002925C0 File Offset: 0x002907C0
		// (set) Token: 0x0600A40A RID: 41994 RVA: 0x00050C1B File Offset: 0x0004EE1B
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003290 RID: 12944
		// (get) Token: 0x0600A40B RID: 41995 RVA: 0x002925F0 File Offset: 0x002907F0
		// (set) Token: 0x0600A40C RID: 41996 RVA: 0x00050C3A File Offset: 0x0004EE3A
		public unsafe GraphicRaycaster raycaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_raycaster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRaycaster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_raycaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003291 RID: 12945
		// (get) Token: 0x0600A40D RID: 41997 RVA: 0x00292620 File Offset: 0x00290820
		// (set) Token: 0x0600A40E RID: 41998 RVA: 0x00050C59 File Offset: 0x0004EE59
		public unsafe Transform categoryButtonContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryButtonContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryButtonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003292 RID: 12946
		// (get) Token: 0x0600A40F RID: 41999 RVA: 0x00292650 File Offset: 0x00290850
		// (set) Token: 0x0600A410 RID: 42000 RVA: 0x00050C78 File Offset: 0x0004EE78
		public unsafe RectTransform categoryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003293 RID: 12947
		// (get) Token: 0x0600A411 RID: 42001 RVA: 0x00292680 File Offset: 0x00290880
		// (set) Token: 0x0600A412 RID: 42002 RVA: 0x00050C97 File Offset: 0x0004EE97
		public unsafe Text categoryNameDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryNameDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryNameDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003294 RID: 12948
		// (get) Token: 0x0600A413 RID: 42003 RVA: 0x002926B0 File Offset: 0x002908B0
		// (set) Token: 0x0600A414 RID: 42004 RVA: 0x00050CB6 File Offset: 0x0004EEB6
		public unsafe RectTransform infoPopup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_infoPopup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_infoPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003295 RID: 12949
		// (get) Token: 0x0600A415 RID: 42005 RVA: 0x002926E0 File Offset: 0x002908E0
		// (set) Token: 0x0600A416 RID: 42006 RVA: 0x00050CD5 File Offset: 0x0004EED5
		public unsafe TextMeshProUGUI infoPopup_ConstructableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_infoPopup_ConstructableName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_infoPopup_ConstructableName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003296 RID: 12950
		// (get) Token: 0x0600A417 RID: 42007 RVA: 0x00292710 File Offset: 0x00290910
		// (set) Token: 0x0600A418 RID: 42008 RVA: 0x00050CF4 File Offset: 0x0004EEF4
		public unsafe EventSystem eventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_eventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_eventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003297 RID: 12951
		// (get) Token: 0x0600A419 RID: 42009 RVA: 0x00292740 File Offset: 0x00290940
		// (set) Token: 0x0600A41A RID: 42010 RVA: 0x00050D13 File Offset: 0x0004EF13
		public unsafe Button destroyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_destroyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_destroyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003298 RID: 12952
		// (get) Token: 0x0600A41B RID: 42011 RVA: 0x00292770 File Offset: 0x00290970
		// (set) Token: 0x0600A41C RID: 42012 RVA: 0x00050D32 File Offset: 0x0004EF32
		public unsafe Button customizeButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_customizeButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_customizeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003299 RID: 12953
		// (get) Token: 0x0600A41D RID: 42013 RVA: 0x002927A0 File Offset: 0x002909A0
		// (set) Token: 0x0600A41E RID: 42014 RVA: 0x00050D51 File Offset: 0x0004EF51
		public unsafe Button moveButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_moveButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_moveButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700329A RID: 12954
		// (get) Token: 0x0600A41F RID: 42015 RVA: 0x002927D0 File Offset: 0x002909D0
		// (set) Token: 0x0600A420 RID: 42016 RVA: 0x00050D70 File Offset: 0x0004EF70
		public unsafe TextMeshProUGUI infoPopup_Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_infoPopup_Description);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_infoPopup_Description), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700329B RID: 12955
		// (get) Token: 0x0600A421 RID: 42017 RVA: 0x00292800 File Offset: 0x00290A00
		// (set) Token: 0x0600A422 RID: 42018 RVA: 0x00050D8F File Offset: 0x0004EF8F
		public unsafe GameObject categoryButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700329C RID: 12956
		// (get) Token: 0x0600A423 RID: 42019 RVA: 0x00292830 File Offset: 0x00290A30
		// (set) Token: 0x0600A424 RID: 42020 RVA: 0x00050DAE File Offset: 0x0004EFAE
		public unsafe GameObject categoryContainerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryContainerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_categoryContainerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700329D RID: 12957
		// (get) Token: 0x0600A425 RID: 42021 RVA: 0x00292860 File Offset: 0x00290A60
		// (set) Token: 0x0600A426 RID: 42022 RVA: 0x00050DCD File Offset: 0x0004EFCD
		public unsafe GameObject listingPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_listingPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_listingPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700329E RID: 12958
		// (get) Token: 0x0600A427 RID: 42023 RVA: 0x00292890 File Offset: 0x00290A90
		// (set) Token: 0x0600A428 RID: 42024 RVA: 0x00050DEC File Offset: 0x0004EFEC
		public unsafe Color iconColor_Unselected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_iconColor_Unselected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_iconColor_Unselected)) = value;
			}
		}

		// Token: 0x1700329F RID: 12959
		// (get) Token: 0x0600A429 RID: 42025 RVA: 0x002928B8 File Offset: 0x00290AB8
		// (set) Token: 0x0600A42A RID: 42026 RVA: 0x00050E07 File Offset: 0x0004F007
		public unsafe Color iconColor_Selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_iconColor_Selected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_iconColor_Selected)) = value;
			}
		}

		// Token: 0x170032A0 RID: 12960
		// (get) Token: 0x0600A42B RID: 42027 RVA: 0x002928E0 File Offset: 0x00290AE0
		// (set) Token: 0x0600A42C RID: 42028 RVA: 0x00050E22 File Offset: 0x0004F022
		public unsafe Color listingOutlineColor_Unselected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_listingOutlineColor_Unselected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_listingOutlineColor_Unselected)) = value;
			}
		}

		// Token: 0x170032A1 RID: 12961
		// (get) Token: 0x0600A42D RID: 42029 RVA: 0x00292908 File Offset: 0x00290B08
		// (set) Token: 0x0600A42E RID: 42030 RVA: 0x00050E3D File Offset: 0x0004F03D
		public unsafe Color listingOutlineColor_Selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_listingOutlineColor_Selected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_listingOutlineColor_Selected)) = value;
			}
		}

		// Token: 0x170032A2 RID: 12962
		// (get) Token: 0x0600A42F RID: 42031 RVA: 0x00292930 File Offset: 0x00290B30
		// (set) Token: 0x0600A430 RID: 42032 RVA: 0x00050E58 File Offset: 0x0004F058
		public unsafe ConstructionMenu.ConstructionMenuCategory selectedCategory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_selectedCategory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionMenu.ConstructionMenuCategory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_selectedCategory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A3 RID: 12963
		// (get) Token: 0x0600A431 RID: 42033 RVA: 0x00292960 File Offset: 0x00290B60
		// (set) Token: 0x0600A432 RID: 42034 RVA: 0x00050E77 File Offset: 0x0004F077
		public unsafe ConstructionMenu.ConstructionMenuListing selectedListing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_selectedListing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionMenu.ConstructionMenuListing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_selectedListing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A4 RID: 12964
		// (get) Token: 0x0600A433 RID: 42035 RVA: 0x00292990 File Offset: 0x00290B90
		// (set) Token: 0x0600A434 RID: 42036 RVA: 0x00050E96 File Offset: 0x0004F096
		public unsafe Constructable selectedConstructable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_selectedConstructable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.NativeFieldInfoPtr_selectedConstructable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006DE4 RID: 28132
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04006DE5 RID: 28133
		private static readonly IntPtr NativeFieldInfoPtr_categories;

		// Token: 0x04006DE6 RID: 28134
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04006DE7 RID: 28135
		private static readonly IntPtr NativeFieldInfoPtr_raycaster;

		// Token: 0x04006DE8 RID: 28136
		private static readonly IntPtr NativeFieldInfoPtr_categoryButtonContainer;

		// Token: 0x04006DE9 RID: 28137
		private static readonly IntPtr NativeFieldInfoPtr_categoryContainer;

		// Token: 0x04006DEA RID: 28138
		private static readonly IntPtr NativeFieldInfoPtr_categoryNameDisplay;

		// Token: 0x04006DEB RID: 28139
		private static readonly IntPtr NativeFieldInfoPtr_infoPopup;

		// Token: 0x04006DEC RID: 28140
		private static readonly IntPtr NativeFieldInfoPtr_infoPopup_ConstructableName;

		// Token: 0x04006DED RID: 28141
		private static readonly IntPtr NativeFieldInfoPtr_eventSystem;

		// Token: 0x04006DEE RID: 28142
		private static readonly IntPtr NativeFieldInfoPtr_destroyButton;

		// Token: 0x04006DEF RID: 28143
		private static readonly IntPtr NativeFieldInfoPtr_customizeButton;

		// Token: 0x04006DF0 RID: 28144
		private static readonly IntPtr NativeFieldInfoPtr_moveButton;

		// Token: 0x04006DF1 RID: 28145
		private static readonly IntPtr NativeFieldInfoPtr_infoPopup_Description;

		// Token: 0x04006DF2 RID: 28146
		private static readonly IntPtr NativeFieldInfoPtr_categoryButtonPrefab;

		// Token: 0x04006DF3 RID: 28147
		private static readonly IntPtr NativeFieldInfoPtr_categoryContainerPrefab;

		// Token: 0x04006DF4 RID: 28148
		private static readonly IntPtr NativeFieldInfoPtr_listingPrefab;

		// Token: 0x04006DF5 RID: 28149
		private static readonly IntPtr NativeFieldInfoPtr_iconColor_Unselected;

		// Token: 0x04006DF6 RID: 28150
		private static readonly IntPtr NativeFieldInfoPtr_iconColor_Selected;

		// Token: 0x04006DF7 RID: 28151
		private static readonly IntPtr NativeFieldInfoPtr_listingOutlineColor_Unselected;

		// Token: 0x04006DF8 RID: 28152
		private static readonly IntPtr NativeFieldInfoPtr_listingOutlineColor_Selected;

		// Token: 0x04006DF9 RID: 28153
		private static readonly IntPtr NativeFieldInfoPtr_selectedCategory;

		// Token: 0x04006DFA RID: 28154
		private static readonly IntPtr NativeFieldInfoPtr_selectedListing;

		// Token: 0x04006DFB RID: 28155
		private static readonly IntPtr NativeFieldInfoPtr_selectedConstructable;

		// Token: 0x04006DFC RID: 28156
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006DFD RID: 28157
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006DFE RID: 28158
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedConstructable_Public_get_Constructable_0;

		// Token: 0x04006DFF RID: 28159
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006E00 RID: 28160
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006E01 RID: 28161
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006E02 RID: 28162
		private static readonly IntPtr NativeMethodInfoPtr_SetupListings_Private_Void_0;

		// Token: 0x04006E03 RID: 28163
		private static readonly IntPtr NativeMethodInfoPtr_AddListing_Private_Void_String_Single_String_0;

		// Token: 0x04006E04 RID: 28164
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Private_Void_Boolean_0;

		// Token: 0x04006E05 RID: 28165
		private static readonly IntPtr NativeMethodInfoPtr_OnConstructableBuilt_Private_Void_Constructable_0;

		// Token: 0x04006E06 RID: 28166
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelectedListing_Public_Void_0;

		// Token: 0x04006E07 RID: 28167
		private static readonly IntPtr NativeMethodInfoPtr_ListingClicked_Public_Void_ConstructionMenuListing_0;

		// Token: 0x04006E08 RID: 28168
		private static readonly IntPtr NativeMethodInfoPtr_IsHoveringUI_Public_Boolean_0;

		// Token: 0x04006E09 RID: 28169
		private static readonly IntPtr NativeMethodInfoPtr_MoveButtonPressed_Public_Void_0;

		// Token: 0x04006E0A RID: 28170
		private static readonly IntPtr NativeMethodInfoPtr_CustomizeButtonPressed_Public_Void_0;

		// Token: 0x04006E0B RID: 28171
		private static readonly IntPtr NativeMethodInfoPtr_BulldozeButtonPressed_Public_Void_0;

		// Token: 0x04006E0C RID: 28172
		private static readonly IntPtr NativeMethodInfoPtr_CheckConstructableSelection_Private_Void_0;

		// Token: 0x04006E0D RID: 28173
		private static readonly IntPtr NativeMethodInfoPtr_SelectConstructable_Public_Void_Constructable_0;

		// Token: 0x04006E0E RID: 28174
		private static readonly IntPtr NativeMethodInfoPtr_SelectConstructable_Public_Void_Constructable_Boolean_0;

		// Token: 0x04006E0F RID: 28175
		private static readonly IntPtr NativeMethodInfoPtr_SetButtonInteractable_Private_Void_Button_Boolean_Color32_0;

		// Token: 0x04006E10 RID: 28176
		private static readonly IntPtr NativeMethodInfoPtr_DeselectConstructable_Public_Void_0;

		// Token: 0x04006E11 RID: 28177
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredConstructable_Private_Constructable_0;

		// Token: 0x04006E12 RID: 28178
		private static readonly IntPtr NativeMethodInfoPtr_GenerateCategories_Private_Void_0;

		// Token: 0x04006E13 RID: 28179
		private static readonly IntPtr NativeMethodInfoPtr_SelectCategory_Public_Void_String_0;

		// Token: 0x04006E14 RID: 28180
		private static readonly IntPtr NativeMethodInfoPtr_GetListingPrice_Public_Single_String_0;

		// Token: 0x04006E15 RID: 28181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006E16 RID: 28182
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__31_0_Private_Void_0;

		// Token: 0x04006E17 RID: 28183
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__31_1_Private_Void_0;

		// Token: 0x02000BC2 RID: 3010
		[Serializable]
		public class ConstructionMenuCategory : Il2CppSystem.Object
		{
			// Token: 0x0600DDAC RID: 56748 RVA: 0x003457C4 File Offset: 0x003439C4
			// Note: this type is marked as 'beforefieldinit'.
			static ConstructionMenuCategory()
			{
				Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "ConstructionMenuCategory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr);
				ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_categoryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr, "categoryName");
				ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_categoryIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr, "categoryIcon");
				ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr, "button");
				ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr, "container");
				ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_listings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr, "listings");
				ConstructionMenu.ConstructionMenuCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr, 100683359);
			}

			// Token: 0x0600DDAD RID: 56749 RVA: 0x00345868 File Offset: 0x00343A68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286877, XrefRangeEnd = 286889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConstructionMenuCategory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuCategory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.ConstructionMenuCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDAE RID: 56750 RVA: 0x0006C060 File Offset: 0x0006A260
			public ConstructionMenuCategory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044AE RID: 17582
			// (get) Token: 0x0600DDAF RID: 56751 RVA: 0x003458A4 File Offset: 0x00343AA4
			// (set) Token: 0x0600DDB0 RID: 56752 RVA: 0x0006C069 File Offset: 0x0006A269
			public unsafe string categoryName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_categoryName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_categoryName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170044AF RID: 17583
			// (get) Token: 0x0600DDB1 RID: 56753 RVA: 0x003458CC File Offset: 0x00343ACC
			// (set) Token: 0x0600DDB2 RID: 56754 RVA: 0x0006C088 File Offset: 0x0006A288
			public unsafe Sprite categoryIcon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_categoryIcon);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_categoryIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044B0 RID: 17584
			// (get) Token: 0x0600DDB3 RID: 56755 RVA: 0x003458FC File Offset: 0x00343AFC
			// (set) Token: 0x0600DDB4 RID: 56756 RVA: 0x0006C0A7 File Offset: 0x0006A2A7
			public unsafe Button button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044B1 RID: 17585
			// (get) Token: 0x0600DDB5 RID: 56757 RVA: 0x0034592C File Offset: 0x00343B2C
			// (set) Token: 0x0600DDB6 RID: 56758 RVA: 0x0006C0C6 File Offset: 0x0006A2C6
			public unsafe RectTransform container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044B2 RID: 17586
			// (get) Token: 0x0600DDB7 RID: 56759 RVA: 0x0034595C File Offset: 0x00343B5C
			// (set) Token: 0x0600DDB8 RID: 56760 RVA: 0x0006C0E5 File Offset: 0x0006A2E5
			public unsafe List<ConstructionMenu.ConstructionMenuListing> listings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_listings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ConstructionMenu.ConstructionMenuListing>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuCategory.NativeFieldInfoPtr_listings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400947D RID: 38013
			private static readonly IntPtr NativeFieldInfoPtr_categoryName;

			// Token: 0x0400947E RID: 38014
			private static readonly IntPtr NativeFieldInfoPtr_categoryIcon;

			// Token: 0x0400947F RID: 38015
			private static readonly IntPtr NativeFieldInfoPtr_button;

			// Token: 0x04009480 RID: 38016
			private static readonly IntPtr NativeFieldInfoPtr_container;

			// Token: 0x04009481 RID: 38017
			private static readonly IntPtr NativeFieldInfoPtr_listings;

			// Token: 0x04009482 RID: 38018
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BC3 RID: 3011
		public class ConstructionMenuListing : Il2CppSystem.Object
		{
			// Token: 0x0600DDB9 RID: 56761 RVA: 0x0034598C File Offset: 0x00343B8C
			// Note: this type is marked as 'beforefieldinit'.
			static ConstructionMenuListing()
			{
				Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "ConstructionMenuListing");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr);
				ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, "ID");
				ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, "price");
				ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, "category");
				ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, "entry");
				ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_isSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, "isSelected");
				ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr__ctor_Public_Void_String_Single_ConstructionMenuCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, 100683360);
				ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_CreateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, 100683361);
				ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_ListingClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, 100683362);
				ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_ListingUnselected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, 100683363);
				ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr, 100683364);
			}

			// Token: 0x0600DDBA RID: 56762 RVA: 0x00345A80 File Offset: 0x00343C80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286889, XrefRangeEnd = 286903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConstructionMenuListing(string id, float _price, ConstructionMenu.ConstructionMenuCategory _cat) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionMenu.ConstructionMenuListing>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _price;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_cat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr__ctor_Public_Void_String_Single_ConstructionMenuCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDBB RID: 56763 RVA: 0x00345AEC File Offset: 0x00343CEC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 286976, RefRangeEnd = 286979, XrefRangeStart = 286903, XrefRangeEnd = 286976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CreateUI()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_CreateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDBC RID: 56764 RVA: 0x00345B20 File Offset: 0x00343D20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286979, XrefRangeEnd = 286996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ListingClicked()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_ListingClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDBD RID: 56765 RVA: 0x00345B54 File Offset: 0x00343D54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286996, XrefRangeEnd = 286997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ListingUnselected()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_ListingUnselected_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDBE RID: 56766 RVA: 0x00345B88 File Offset: 0x00343D88
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287025, RefRangeEnd = 287028, XrefRangeStart = 286997, XrefRangeEnd = 287025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetSelected(bool selected)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.ConstructionMenuListing.NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDBF RID: 56767 RVA: 0x0006C104 File Offset: 0x0006A304
			public ConstructionMenuListing(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044B3 RID: 17587
			// (get) Token: 0x0600DDC0 RID: 56768 RVA: 0x00345BC8 File Offset: 0x00343DC8
			// (set) Token: 0x0600DDC1 RID: 56769 RVA: 0x0006C10D File Offset: 0x0006A30D
			public unsafe string ID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_ID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170044B4 RID: 17588
			// (get) Token: 0x0600DDC2 RID: 56770 RVA: 0x00345BF0 File Offset: 0x00343DF0
			// (set) Token: 0x0600DDC3 RID: 56771 RVA: 0x0006C12C File Offset: 0x0006A32C
			public unsafe float price
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_price)) = value;
				}
			}

			// Token: 0x170044B5 RID: 17589
			// (get) Token: 0x0600DDC4 RID: 56772 RVA: 0x00345C18 File Offset: 0x00343E18
			// (set) Token: 0x0600DDC5 RID: 56773 RVA: 0x0006C147 File Offset: 0x0006A347
			public unsafe ConstructionMenu.ConstructionMenuCategory category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_category);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionMenu.ConstructionMenuCategory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_category), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044B6 RID: 17590
			// (get) Token: 0x0600DDC6 RID: 56774 RVA: 0x00345C48 File Offset: 0x00343E48
			// (set) Token: 0x0600DDC7 RID: 56775 RVA: 0x0006C166 File Offset: 0x0006A366
			public unsafe RectTransform entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044B7 RID: 17591
			// (get) Token: 0x0600DDC8 RID: 56776 RVA: 0x00345C78 File Offset: 0x00343E78
			// (set) Token: 0x0600DDC9 RID: 56777 RVA: 0x0006C185 File Offset: 0x0006A385
			public unsafe bool isSelected
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_isSelected);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.ConstructionMenuListing.NativeFieldInfoPtr_isSelected)) = value;
				}
			}

			// Token: 0x04009483 RID: 38019
			private static readonly IntPtr NativeFieldInfoPtr_ID;

			// Token: 0x04009484 RID: 38020
			private static readonly IntPtr NativeFieldInfoPtr_price;

			// Token: 0x04009485 RID: 38021
			private static readonly IntPtr NativeFieldInfoPtr_category;

			// Token: 0x04009486 RID: 38022
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x04009487 RID: 38023
			private static readonly IntPtr NativeFieldInfoPtr_isSelected;

			// Token: 0x04009488 RID: 38024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_ConstructionMenuCategory_0;

			// Token: 0x04009489 RID: 38025
			private static readonly IntPtr NativeMethodInfoPtr_CreateUI_Private_Void_0;

			// Token: 0x0400948A RID: 38026
			private static readonly IntPtr NativeMethodInfoPtr_ListingClicked_Private_Void_0;

			// Token: 0x0400948B RID: 38027
			private static readonly IntPtr NativeMethodInfoPtr_ListingUnselected_Public_Void_0;

			// Token: 0x0400948C RID: 38028
			private static readonly IntPtr NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0;
		}

		// Token: 0x02000BC4 RID: 3012
		[ObfuscatedName("ScheduleOne.UI.Construction.ConstructionMenu+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DDCA RID: 56778 RVA: 0x00345CA0 File Offset: 0x00343EA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass35_0>.NativeClassPtr);
				ConstructionMenu.__c__DisplayClass35_0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass35_0>.NativeClassPtr, "category");
				ConstructionMenu.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass35_0>.NativeClassPtr, 100683365);
				ConstructionMenu.__c__DisplayClass35_0.NativeMethodInfoPtr__AddListing_b__0_Internal_Boolean_ConstructionMenuCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass35_0>.NativeClassPtr, 100683366);
			}

			// Token: 0x0600DDCB RID: 56779 RVA: 0x00345D08 File Offset: 0x00343F08
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDCC RID: 56780 RVA: 0x00345D44 File Offset: 0x00343F44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddListing_b__0(ConstructionMenu.ConstructionMenuCategory x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.__c__DisplayClass35_0.NativeMethodInfoPtr__AddListing_b__0_Internal_Boolean_ConstructionMenuCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DDCD RID: 56781 RVA: 0x0006C1A0 File Offset: 0x0006A3A0
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044B8 RID: 17592
			// (get) Token: 0x0600DDCE RID: 56782 RVA: 0x00345D94 File Offset: 0x00343F94
			// (set) Token: 0x0600DDCF RID: 56783 RVA: 0x0006C1A9 File Offset: 0x0006A3A9
			public unsafe string category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass35_0.NativeFieldInfoPtr_category);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass35_0.NativeFieldInfoPtr_category), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400948D RID: 38029
			private static readonly IntPtr NativeFieldInfoPtr_category;

			// Token: 0x0400948E RID: 38030
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400948F RID: 38031
			private static readonly IntPtr NativeMethodInfoPtr__AddListing_b__0_Internal_Boolean_ConstructionMenuCategory_0;
		}

		// Token: 0x02000BC5 RID: 3013
		[ObfuscatedName("ScheduleOne.UI.Construction.ConstructionMenu+<>c__DisplayClass50_0")]
		public sealed class __c__DisplayClass50_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DDD0 RID: 56784 RVA: 0x00345DBC File Offset: 0x00343FBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass50_0()
			{
				Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "<>c__DisplayClass50_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr);
				ConstructionMenu.__c__DisplayClass50_0.NativeFieldInfoPtr_catName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr, "catName");
				ConstructionMenu.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr, "<>4__this");
				ConstructionMenu.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr, 100683367);
				ConstructionMenu.__c__DisplayClass50_0.NativeMethodInfoPtr__GenerateCategories_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr, 100683368);
			}

			// Token: 0x0600DDD1 RID: 56785 RVA: 0x00345E38 File Offset: 0x00344038
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass50_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass50_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDD2 RID: 56786 RVA: 0x00345E74 File Offset: 0x00344074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287028, XrefRangeEnd = 287030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GenerateCategories_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.__c__DisplayClass50_0.NativeMethodInfoPtr__GenerateCategories_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDD3 RID: 56787 RVA: 0x0006C1C8 File Offset: 0x0006A3C8
			public __c__DisplayClass50_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044B9 RID: 17593
			// (get) Token: 0x0600DDD4 RID: 56788 RVA: 0x00345EA8 File Offset: 0x003440A8
			// (set) Token: 0x0600DDD5 RID: 56789 RVA: 0x0006C1D1 File Offset: 0x0006A3D1
			public unsafe string catName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass50_0.NativeFieldInfoPtr_catName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass50_0.NativeFieldInfoPtr_catName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170044BA RID: 17594
			// (get) Token: 0x0600DDD6 RID: 56790 RVA: 0x00345ED0 File Offset: 0x003440D0
			// (set) Token: 0x0600DDD7 RID: 56791 RVA: 0x0006C1F0 File Offset: 0x0006A3F0
			public unsafe ConstructionMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009490 RID: 38032
			private static readonly IntPtr NativeFieldInfoPtr_catName;

			// Token: 0x04009491 RID: 38033
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009492 RID: 38034
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009493 RID: 38035
			private static readonly IntPtr NativeMethodInfoPtr__GenerateCategories_b__0_Internal_Void_0;
		}

		// Token: 0x02000BC6 RID: 3014
		[ObfuscatedName("ScheduleOne.UI.Construction.ConstructionMenu+<>c__DisplayClass51_0")]
		public sealed class __c__DisplayClass51_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DDD8 RID: 56792 RVA: 0x00345F00 File Offset: 0x00344100
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_0()
			{
				Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstructionMenu>.NativeClassPtr, "<>c__DisplayClass51_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass51_0>.NativeClassPtr);
				ConstructionMenu.__c__DisplayClass51_0.NativeFieldInfoPtr_categoryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass51_0>.NativeClassPtr, "categoryName");
				ConstructionMenu.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass51_0>.NativeClassPtr, 100683369);
				ConstructionMenu.__c__DisplayClass51_0.NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_ConstructionMenuCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass51_0>.NativeClassPtr, 100683370);
			}

			// Token: 0x0600DDD9 RID: 56793 RVA: 0x00345F68 File Offset: 0x00344168
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionMenu.__c__DisplayClass51_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDDA RID: 56794 RVA: 0x00345FA4 File Offset: 0x003441A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectCategory_b__0(ConstructionMenu.ConstructionMenuCategory x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionMenu.__c__DisplayClass51_0.NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_ConstructionMenuCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DDDB RID: 56795 RVA: 0x0006C20F File Offset: 0x0006A40F
			public __c__DisplayClass51_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044BB RID: 17595
			// (get) Token: 0x0600DDDC RID: 56796 RVA: 0x00345FF4 File Offset: 0x003441F4
			// (set) Token: 0x0600DDDD RID: 56797 RVA: 0x0006C218 File Offset: 0x0006A418
			public unsafe string categoryName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass51_0.NativeFieldInfoPtr_categoryName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionMenu.__c__DisplayClass51_0.NativeFieldInfoPtr_categoryName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009494 RID: 38036
			private static readonly IntPtr NativeFieldInfoPtr_categoryName;

			// Token: 0x04009495 RID: 38037
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009496 RID: 38038
			private static readonly IntPtr NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_ConstructionMenuCategory_0;
		}
	}
}
