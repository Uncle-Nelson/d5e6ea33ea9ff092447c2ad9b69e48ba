using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000627 RID: 1575
	public class BodySearchScreen : Singleton<BodySearchScreen>
	{
		// Token: 0x06008AC0 RID: 35520 RVA: 0x0024596C File Offset: 0x00243B6C
		// Note: this type is marked as 'beforefieldinit'.
		static BodySearchScreen()
		{
			Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "BodySearchScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr);
			BodySearchScreen.NativeFieldInfoPtr_MAX_SPEED_BOOST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "MAX_SPEED_BOOST");
			BodySearchScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			BodySearchScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "<TutorialOpen>k__BackingField");
			BodySearchScreen.NativeFieldInfoPtr_SlotRedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SlotRedColor");
			BodySearchScreen.NativeFieldInfoPtr_SlotHighlightRedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SlotHighlightRedColor");
			BodySearchScreen.NativeFieldInfoPtr_GapTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "GapTime");
			BodySearchScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "Canvas");
			BodySearchScreen.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "Container");
			BodySearchScreen.NativeFieldInfoPtr_MinigameController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "MinigameController");
			BodySearchScreen.NativeFieldInfoPtr_SlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SlotContainer");
			BodySearchScreen.NativeFieldInfoPtr_ItemSlotPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "ItemSlotPrefab");
			BodySearchScreen.NativeFieldInfoPtr_SearchIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SearchIndicator");
			BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SearchIndicatorStart");
			BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SearchIndicatorEnd");
			BodySearchScreen.NativeFieldInfoPtr_IndicatorAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "IndicatorAnimation");
			BodySearchScreen.NativeFieldInfoPtr_TutorialAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "TutorialAnimation");
			BodySearchScreen.NativeFieldInfoPtr_TutorialContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "TutorialContainer");
			BodySearchScreen.NativeFieldInfoPtr_ResetAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "ResetAnimation");
			BodySearchScreen.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "slots");
			BodySearchScreen.NativeFieldInfoPtr_onSearchClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "onSearchClear");
			BodySearchScreen.NativeFieldInfoPtr_onSearchFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "onSearchFail");
			BodySearchScreen.NativeFieldInfoPtr_defaultSlotColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "defaultSlotColor");
			BodySearchScreen.NativeFieldInfoPtr_defaultSlotHighlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "defaultSlotHighlightColor");
			BodySearchScreen.NativeFieldInfoPtr_concealedSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "concealedSlot");
			BodySearchScreen.NativeFieldInfoPtr_hoveredSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "hoveredSlot");
			BodySearchScreen.NativeFieldInfoPtr_defaultItemIconColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "defaultItemIconColors");
			BodySearchScreen.NativeFieldInfoPtr_speedBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "speedBoost");
			BodySearchScreen.NativeFieldInfoPtr_searcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "searcher");
			BodySearchScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680538);
			BodySearchScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680539);
			BodySearchScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680540);
			BodySearchScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680541);
			BodySearchScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680542);
			BodySearchScreen.NativeMethodInfoPtr_SetupSlots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680543);
			BodySearchScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680544);
			BodySearchScreen.NativeMethodInfoPtr_Open_Public_Void_NPC_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680545);
			BodySearchScreen.NativeMethodInfoPtr_IsSlotConcealed_Private_Boolean_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680546);
			BodySearchScreen.NativeMethodInfoPtr_ItemDetected_Private_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680547);
			BodySearchScreen.NativeMethodInfoPtr_SlotHeld_Public_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680548);
			BodySearchScreen.NativeMethodInfoPtr_SlotReleased_Public_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680549);
			BodySearchScreen.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680550);
			BodySearchScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680551);
			BodySearchScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680552);
			BodySearchScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100680553);
		}

		// Token: 0x17002A61 RID: 10849
		// (get) Token: 0x06008AC1 RID: 35521 RVA: 0x00245D0C File Offset: 0x00243F0C
		// (set) Token: 0x06008AC2 RID: 35522 RVA: 0x00245D48 File Offset: 0x00243F48
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002A62 RID: 10850
		// (get) Token: 0x06008AC3 RID: 35523 RVA: 0x00245D88 File Offset: 0x00243F88
		// (set) Token: 0x06008AC4 RID: 35524 RVA: 0x00245DC4 File Offset: 0x00243FC4
		public unsafe bool TutorialOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008AC5 RID: 35525 RVA: 0x00245E04 File Offset: 0x00244004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254708, XrefRangeEnd = 254744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AC6 RID: 35526 RVA: 0x00245E40 File Offset: 0x00244040
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254836, RefRangeEnd = 254837, XrefRangeStart = 254744, XrefRangeEnd = 254836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_SetupSlots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AC7 RID: 35527 RVA: 0x00245E74 File Offset: 0x00244074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254837, XrefRangeEnd = 254866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AC8 RID: 35528 RVA: 0x00245EA8 File Offset: 0x002440A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254945, RefRangeEnd = 254946, XrefRangeStart = 254866, XrefRangeEnd = 254945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(NPC _searcher, float searchTime = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_searcher);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_Open_Public_Void_NPC_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AC9 RID: 35529 RVA: 0x00245EF8 File Offset: 0x002440F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254946, XrefRangeEnd = 254950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSlotConcealed(ItemSlotUI slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_IsSlotConcealed_Private_Boolean_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008ACA RID: 35530 RVA: 0x00245F48 File Offset: 0x00244148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254950, XrefRangeEnd = 254954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ItemDetected(ItemSlotUI slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_ItemDetected_Private_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008ACB RID: 35531 RVA: 0x00245F8C File Offset: 0x0024418C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254954, XrefRangeEnd = 254963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlotHeld(ItemSlotUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_SlotHeld_Public_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008ACC RID: 35532 RVA: 0x00245FD0 File Offset: 0x002441D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254963, XrefRangeEnd = 254968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlotReleased(ItemSlotUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_SlotReleased_Public_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008ACD RID: 35533 RVA: 0x00246014 File Offset: 0x00244214
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255004, RefRangeEnd = 255006, XrefRangeStart = 254968, XrefRangeEnd = 255004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool clear)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008ACE RID: 35534 RVA: 0x00246054 File Offset: 0x00244254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255006, XrefRangeEnd = 255010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008ACF RID: 35535 RVA: 0x00246088 File Offset: 0x00244288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255010, XrefRangeEnd = 255013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AD0 RID: 35536 RVA: 0x002460BC File Offset: 0x002442BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255013, XrefRangeEnd = 255023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BodySearchScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AD1 RID: 35537 RVA: 0x000425B0 File Offset: 0x000407B0
		public BodySearchScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A45 RID: 10821
		// (get) Token: 0x06008AD2 RID: 35538 RVA: 0x002460F8 File Offset: 0x002442F8
		// (set) Token: 0x06008AD3 RID: 35539 RVA: 0x000425B9 File Offset: 0x000407B9
		public unsafe static float MAX_SPEED_BOOST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchScreen.NativeFieldInfoPtr_MAX_SPEED_BOOST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchScreen.NativeFieldInfoPtr_MAX_SPEED_BOOST, (void*)(&value));
			}
		}

		// Token: 0x17002A46 RID: 10822
		// (get) Token: 0x06008AD4 RID: 35540 RVA: 0x00246114 File Offset: 0x00244314
		// (set) Token: 0x06008AD5 RID: 35541 RVA: 0x000425C7 File Offset: 0x000407C7
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A47 RID: 10823
		// (get) Token: 0x06008AD6 RID: 35542 RVA: 0x0024613C File Offset: 0x0024433C
		// (set) Token: 0x06008AD7 RID: 35543 RVA: 0x000425E2 File Offset: 0x000407E2
		public unsafe bool _TutorialOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A48 RID: 10824
		// (get) Token: 0x06008AD8 RID: 35544 RVA: 0x00246164 File Offset: 0x00244364
		// (set) Token: 0x06008AD9 RID: 35545 RVA: 0x000425FD File Offset: 0x000407FD
		public unsafe Color SlotRedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotRedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotRedColor)) = value;
			}
		}

		// Token: 0x17002A49 RID: 10825
		// (get) Token: 0x06008ADA RID: 35546 RVA: 0x0024618C File Offset: 0x0024438C
		// (set) Token: 0x06008ADB RID: 35547 RVA: 0x00042618 File Offset: 0x00040818
		public unsafe Color SlotHighlightRedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotHighlightRedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotHighlightRedColor)) = value;
			}
		}

		// Token: 0x17002A4A RID: 10826
		// (get) Token: 0x06008ADC RID: 35548 RVA: 0x002461B4 File Offset: 0x002443B4
		// (set) Token: 0x06008ADD RID: 35549 RVA: 0x00042633 File Offset: 0x00040833
		public unsafe float GapTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_GapTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_GapTime)) = value;
			}
		}

		// Token: 0x17002A4B RID: 10827
		// (get) Token: 0x06008ADE RID: 35550 RVA: 0x002461DC File Offset: 0x002443DC
		// (set) Token: 0x06008ADF RID: 35551 RVA: 0x0004264E File Offset: 0x0004084E
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A4C RID: 10828
		// (get) Token: 0x06008AE0 RID: 35552 RVA: 0x0024620C File Offset: 0x0024440C
		// (set) Token: 0x06008AE1 RID: 35553 RVA: 0x0004266D File Offset: 0x0004086D
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A4D RID: 10829
		// (get) Token: 0x06008AE2 RID: 35554 RVA: 0x0024623C File Offset: 0x0024443C
		// (set) Token: 0x06008AE3 RID: 35555 RVA: 0x0004268C File Offset: 0x0004088C
		public unsafe RectTransform MinigameController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_MinigameController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_MinigameController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A4E RID: 10830
		// (get) Token: 0x06008AE4 RID: 35556 RVA: 0x0024626C File Offset: 0x0024446C
		// (set) Token: 0x06008AE5 RID: 35557 RVA: 0x000426AB File Offset: 0x000408AB
		public unsafe RectTransform SlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A4F RID: 10831
		// (get) Token: 0x06008AE6 RID: 35558 RVA: 0x0024629C File Offset: 0x0024449C
		// (set) Token: 0x06008AE7 RID: 35559 RVA: 0x000426CA File Offset: 0x000408CA
		public unsafe ItemSlotUI ItemSlotPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_ItemSlotPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_ItemSlotPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A50 RID: 10832
		// (get) Token: 0x06008AE8 RID: 35560 RVA: 0x002462CC File Offset: 0x002444CC
		// (set) Token: 0x06008AE9 RID: 35561 RVA: 0x000426E9 File Offset: 0x000408E9
		public unsafe RectTransform SearchIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A51 RID: 10833
		// (get) Token: 0x06008AEA RID: 35562 RVA: 0x002462FC File Offset: 0x002444FC
		// (set) Token: 0x06008AEB RID: 35563 RVA: 0x00042708 File Offset: 0x00040908
		public unsafe RectTransform SearchIndicatorStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A52 RID: 10834
		// (get) Token: 0x06008AEC RID: 35564 RVA: 0x0024632C File Offset: 0x0024452C
		// (set) Token: 0x06008AED RID: 35565 RVA: 0x00042727 File Offset: 0x00040927
		public unsafe RectTransform SearchIndicatorEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A53 RID: 10835
		// (get) Token: 0x06008AEE RID: 35566 RVA: 0x0024635C File Offset: 0x0024455C
		// (set) Token: 0x06008AEF RID: 35567 RVA: 0x00042746 File Offset: 0x00040946
		public unsafe Animation IndicatorAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_IndicatorAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_IndicatorAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A54 RID: 10836
		// (get) Token: 0x06008AF0 RID: 35568 RVA: 0x0024638C File Offset: 0x0024458C
		// (set) Token: 0x06008AF1 RID: 35569 RVA: 0x00042765 File Offset: 0x00040965
		public unsafe Animation TutorialAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_TutorialAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_TutorialAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A55 RID: 10837
		// (get) Token: 0x06008AF2 RID: 35570 RVA: 0x002463BC File Offset: 0x002445BC
		// (set) Token: 0x06008AF3 RID: 35571 RVA: 0x00042784 File Offset: 0x00040984
		public unsafe RectTransform TutorialContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_TutorialContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_TutorialContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A56 RID: 10838
		// (get) Token: 0x06008AF4 RID: 35572 RVA: 0x002463EC File Offset: 0x002445EC
		// (set) Token: 0x06008AF5 RID: 35573 RVA: 0x000427A3 File Offset: 0x000409A3
		public unsafe Animation ResetAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_ResetAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_ResetAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A57 RID: 10839
		// (get) Token: 0x06008AF6 RID: 35574 RVA: 0x0024641C File Offset: 0x0024461C
		// (set) Token: 0x06008AF7 RID: 35575 RVA: 0x000427C2 File Offset: 0x000409C2
		public unsafe List<ItemSlotUI> slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A58 RID: 10840
		// (get) Token: 0x06008AF8 RID: 35576 RVA: 0x0024644C File Offset: 0x0024464C
		// (set) Token: 0x06008AF9 RID: 35577 RVA: 0x000427E1 File Offset: 0x000409E1
		public unsafe UnityEvent onSearchClear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_onSearchClear);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_onSearchClear), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A59 RID: 10841
		// (get) Token: 0x06008AFA RID: 35578 RVA: 0x0024647C File Offset: 0x0024467C
		// (set) Token: 0x06008AFB RID: 35579 RVA: 0x00042800 File Offset: 0x00040A00
		public unsafe UnityEvent onSearchFail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_onSearchFail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_onSearchFail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A5A RID: 10842
		// (get) Token: 0x06008AFC RID: 35580 RVA: 0x002464AC File Offset: 0x002446AC
		// (set) Token: 0x06008AFD RID: 35581 RVA: 0x0004281F File Offset: 0x00040A1F
		public unsafe Color defaultSlotColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultSlotColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultSlotColor)) = value;
			}
		}

		// Token: 0x17002A5B RID: 10843
		// (get) Token: 0x06008AFE RID: 35582 RVA: 0x002464D4 File Offset: 0x002446D4
		// (set) Token: 0x06008AFF RID: 35583 RVA: 0x0004283A File Offset: 0x00040A3A
		public unsafe Color defaultSlotHighlightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultSlotHighlightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultSlotHighlightColor)) = value;
			}
		}

		// Token: 0x17002A5C RID: 10844
		// (get) Token: 0x06008B00 RID: 35584 RVA: 0x002464FC File Offset: 0x002446FC
		// (set) Token: 0x06008B01 RID: 35585 RVA: 0x00042855 File Offset: 0x00040A55
		public unsafe ItemSlotUI concealedSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_concealedSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_concealedSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A5D RID: 10845
		// (get) Token: 0x06008B02 RID: 35586 RVA: 0x0024652C File Offset: 0x0024472C
		// (set) Token: 0x06008B03 RID: 35587 RVA: 0x00042874 File Offset: 0x00040A74
		public unsafe ItemSlotUI hoveredSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_hoveredSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_hoveredSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A5E RID: 10846
		// (get) Token: 0x06008B04 RID: 35588 RVA: 0x0024655C File Offset: 0x0024475C
		// (set) Token: 0x06008B05 RID: 35589 RVA: 0x00042893 File Offset: 0x00040A93
		public unsafe Il2CppStructArray<Color> defaultItemIconColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultItemIconColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultItemIconColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A5F RID: 10847
		// (get) Token: 0x06008B06 RID: 35590 RVA: 0x0024658C File Offset: 0x0024478C
		// (set) Token: 0x06008B07 RID: 35591 RVA: 0x000428B2 File Offset: 0x00040AB2
		public unsafe float speedBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_speedBoost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_speedBoost)) = value;
			}
		}

		// Token: 0x17002A60 RID: 10848
		// (get) Token: 0x06008B08 RID: 35592 RVA: 0x002465B4 File Offset: 0x002447B4
		// (set) Token: 0x06008B09 RID: 35593 RVA: 0x000428CD File Offset: 0x00040ACD
		public unsafe NPC searcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_searcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_searcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005E1F RID: 24095
		private static readonly IntPtr NativeFieldInfoPtr_MAX_SPEED_BOOST;

		// Token: 0x04005E20 RID: 24096
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005E21 RID: 24097
		private static readonly IntPtr NativeFieldInfoPtr__TutorialOpen_k__BackingField;

		// Token: 0x04005E22 RID: 24098
		private static readonly IntPtr NativeFieldInfoPtr_SlotRedColor;

		// Token: 0x04005E23 RID: 24099
		private static readonly IntPtr NativeFieldInfoPtr_SlotHighlightRedColor;

		// Token: 0x04005E24 RID: 24100
		private static readonly IntPtr NativeFieldInfoPtr_GapTime;

		// Token: 0x04005E25 RID: 24101
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04005E26 RID: 24102
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005E27 RID: 24103
		private static readonly IntPtr NativeFieldInfoPtr_MinigameController;

		// Token: 0x04005E28 RID: 24104
		private static readonly IntPtr NativeFieldInfoPtr_SlotContainer;

		// Token: 0x04005E29 RID: 24105
		private static readonly IntPtr NativeFieldInfoPtr_ItemSlotPrefab;

		// Token: 0x04005E2A RID: 24106
		private static readonly IntPtr NativeFieldInfoPtr_SearchIndicator;

		// Token: 0x04005E2B RID: 24107
		private static readonly IntPtr NativeFieldInfoPtr_SearchIndicatorStart;

		// Token: 0x04005E2C RID: 24108
		private static readonly IntPtr NativeFieldInfoPtr_SearchIndicatorEnd;

		// Token: 0x04005E2D RID: 24109
		private static readonly IntPtr NativeFieldInfoPtr_IndicatorAnimation;

		// Token: 0x04005E2E RID: 24110
		private static readonly IntPtr NativeFieldInfoPtr_TutorialAnimation;

		// Token: 0x04005E2F RID: 24111
		private static readonly IntPtr NativeFieldInfoPtr_TutorialContainer;

		// Token: 0x04005E30 RID: 24112
		private static readonly IntPtr NativeFieldInfoPtr_ResetAnimation;

		// Token: 0x04005E31 RID: 24113
		private static readonly IntPtr NativeFieldInfoPtr_slots;

		// Token: 0x04005E32 RID: 24114
		private static readonly IntPtr NativeFieldInfoPtr_onSearchClear;

		// Token: 0x04005E33 RID: 24115
		private static readonly IntPtr NativeFieldInfoPtr_onSearchFail;

		// Token: 0x04005E34 RID: 24116
		private static readonly IntPtr NativeFieldInfoPtr_defaultSlotColor;

		// Token: 0x04005E35 RID: 24117
		private static readonly IntPtr NativeFieldInfoPtr_defaultSlotHighlightColor;

		// Token: 0x04005E36 RID: 24118
		private static readonly IntPtr NativeFieldInfoPtr_concealedSlot;

		// Token: 0x04005E37 RID: 24119
		private static readonly IntPtr NativeFieldInfoPtr_hoveredSlot;

		// Token: 0x04005E38 RID: 24120
		private static readonly IntPtr NativeFieldInfoPtr_defaultItemIconColors;

		// Token: 0x04005E39 RID: 24121
		private static readonly IntPtr NativeFieldInfoPtr_speedBoost;

		// Token: 0x04005E3A RID: 24122
		private static readonly IntPtr NativeFieldInfoPtr_searcher;

		// Token: 0x04005E3B RID: 24123
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005E3C RID: 24124
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04005E3D RID: 24125
		private static readonly IntPtr NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0;

		// Token: 0x04005E3E RID: 24126
		private static readonly IntPtr NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0;

		// Token: 0x04005E3F RID: 24127
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005E40 RID: 24128
		private static readonly IntPtr NativeMethodInfoPtr_SetupSlots_Private_Void_0;

		// Token: 0x04005E41 RID: 24129
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005E42 RID: 24130
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_NPC_Single_0;

		// Token: 0x04005E43 RID: 24131
		private static readonly IntPtr NativeMethodInfoPtr_IsSlotConcealed_Private_Boolean_ItemSlotUI_0;

		// Token: 0x04005E44 RID: 24132
		private static readonly IntPtr NativeMethodInfoPtr_ItemDetected_Private_Void_ItemSlotUI_0;

		// Token: 0x04005E45 RID: 24133
		private static readonly IntPtr NativeMethodInfoPtr_SlotHeld_Public_Void_ItemSlotUI_0;

		// Token: 0x04005E46 RID: 24134
		private static readonly IntPtr NativeMethodInfoPtr_SlotReleased_Public_Void_ItemSlotUI_0;

		// Token: 0x04005E47 RID: 24135
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x04005E48 RID: 24136
		private static readonly IntPtr NativeMethodInfoPtr_OpenTutorial_Private_Void_0;

		// Token: 0x04005E49 RID: 24137
		private static readonly IntPtr NativeMethodInfoPtr_CloseTutorial_Public_Void_0;

		// Token: 0x04005E4A RID: 24138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B13 RID: 2835
		[ObfuscatedName("ScheduleOne.UI.BodySearchScreen+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D6C2 RID: 54978 RVA: 0x00331C5C File Offset: 0x0032FE5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr);
				BodySearchScreen.__c__DisplayClass35_0.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr, "slot");
				BodySearchScreen.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				BodySearchScreen.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr, 100680554);
				BodySearchScreen.__c__DisplayClass35_0.NativeMethodInfoPtr__SetupSlots_b__0_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr, 100680555);
				BodySearchScreen.__c__DisplayClass35_0.NativeMethodInfoPtr__SetupSlots_b__1_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr, 100680556);
			}

			// Token: 0x0600D6C3 RID: 54979 RVA: 0x00331CEC File Offset: 0x0032FEEC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6C4 RID: 54980 RVA: 0x00331D28 File Offset: 0x0032FF28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254616, XrefRangeEnd = 254625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetupSlots_b__0(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass35_0.NativeMethodInfoPtr__SetupSlots_b__0_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6C5 RID: 54981 RVA: 0x00331D6C File Offset: 0x0032FF6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254625, XrefRangeEnd = 254630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetupSlots_b__1(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass35_0.NativeMethodInfoPtr__SetupSlots_b__1_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6C6 RID: 54982 RVA: 0x00068845 File Offset: 0x00066A45
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004289 RID: 17033
			// (get) Token: 0x0600D6C7 RID: 54983 RVA: 0x00331DB0 File Offset: 0x0032FFB0
			// (set) Token: 0x0600D6C8 RID: 54984 RVA: 0x0006884E File Offset: 0x00066A4E
			public unsafe ItemSlotUI slot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass35_0.NativeFieldInfoPtr_slot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass35_0.NativeFieldInfoPtr_slot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700428A RID: 17034
			// (get) Token: 0x0600D6C9 RID: 54985 RVA: 0x00331DE0 File Offset: 0x0032FFE0
			// (set) Token: 0x0600D6CA RID: 54986 RVA: 0x0006886D File Offset: 0x00066A6D
			public unsafe BodySearchScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BodySearchScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009070 RID: 36976
			private static readonly IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x04009071 RID: 36977
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009072 RID: 36978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009073 RID: 36979
			private static readonly IntPtr NativeMethodInfoPtr__SetupSlots_b__0_Internal_Void_BaseEventData_0;

			// Token: 0x04009074 RID: 36980
			private static readonly IntPtr NativeMethodInfoPtr__SetupSlots_b__1_Internal_Void_BaseEventData_0;
		}

		// Token: 0x02000B14 RID: 2836
		[ObfuscatedName("ScheduleOne.UI.BodySearchScreen+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D6CB RID: 54987 RVA: 0x00331E10 File Offset: 0x00330010
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr);
				BodySearchScreen.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr, "<>4__this");
				BodySearchScreen.__c__DisplayClass37_0.NativeFieldInfoPtr_searchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr, "searchTime");
				BodySearchScreen.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr, 100680557);
				BodySearchScreen.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr, 100680558);
				BodySearchScreen.__c__DisplayClass37_0.NativeMethodInfoPtr__Open_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr, 100680559);
			}

			// Token: 0x0600D6CC RID: 54988 RVA: 0x00331EA0 File Offset: 0x003300A0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6CD RID: 54989 RVA: 0x00331EDC File Offset: 0x003300DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254703, XrefRangeEnd = 254708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D6CE RID: 54990 RVA: 0x00331F1C File Offset: 0x0033011C
			[CallerCount(0)]
			public unsafe bool _Open_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.NativeMethodInfoPtr__Open_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D6CF RID: 54991 RVA: 0x0006888C File Offset: 0x00066A8C
			public __c__DisplayClass37_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700428B RID: 17035
			// (get) Token: 0x0600D6D0 RID: 54992 RVA: 0x00331F58 File Offset: 0x00330158
			// (set) Token: 0x0600D6D1 RID: 54993 RVA: 0x00068895 File Offset: 0x00066A95
			public unsafe BodySearchScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BodySearchScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700428C RID: 17036
			// (get) Token: 0x0600D6D2 RID: 54994 RVA: 0x00331F88 File Offset: 0x00330188
			// (set) Token: 0x0600D6D3 RID: 54995 RVA: 0x000688B4 File Offset: 0x00066AB4
			public unsafe float searchTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.NativeFieldInfoPtr_searchTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.NativeFieldInfoPtr_searchTime)) = value;
				}
			}

			// Token: 0x04009075 RID: 36981
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009076 RID: 36982
			private static readonly IntPtr NativeFieldInfoPtr_searchTime;

			// Token: 0x04009077 RID: 36983
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009078 RID: 36984
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009079 RID: 36985
			private static readonly IntPtr NativeMethodInfoPtr__Open_b__1_Internal_Boolean_0;

			// Token: 0x02000C6E RID: 3182
			[ObfuscatedName("ScheduleOne.UI.BodySearchScreen+<>c__DisplayClass37_0+<<Open>g__Search|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E4FD RID: 58621 RVA: 0x0035AC70 File Offset: 0x00358E70
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique()
				{
					Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0>.NativeClassPtr, "<<Open>g__Search|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr);
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>1__state");
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>2__current");
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>4__this");
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perGap_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<perGap>5__2");
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perBlock_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<perBlock>5__3");
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<i>5__4");
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680560);
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680561);
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680562);
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680563);
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680564);
					BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680565);
				}

				// Token: 0x0600E4FE RID: 58622 RVA: 0x0035AD8C File Offset: 0x00358F8C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4FF RID: 58623 RVA: 0x0035ADD4 File Offset: 0x00358FD4
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E500 RID: 58624 RVA: 0x0035AE08 File Offset: 0x00359008
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254630, XrefRangeEnd = 254698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700472D RID: 18221
				// (get) Token: 0x0600E501 RID: 58625 RVA: 0x0035AE44 File Offset: 0x00359044
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E502 RID: 58626 RVA: 0x0035AE84 File Offset: 0x00359084
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254698, XrefRangeEnd = 254703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700472E RID: 18222
				// (get) Token: 0x0600E503 RID: 58627 RVA: 0x0035AEB8 File Offset: 0x003590B8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E504 RID: 58628 RVA: 0x0006FA85 File Offset: 0x0006DC85
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004727 RID: 18215
				// (get) Token: 0x0600E505 RID: 58629 RVA: 0x0035AEF8 File Offset: 0x003590F8
				// (set) Token: 0x0600E506 RID: 58630 RVA: 0x0006FA8E File Offset: 0x0006DC8E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004728 RID: 18216
				// (get) Token: 0x0600E507 RID: 58631 RVA: 0x0035AF20 File Offset: 0x00359120
				// (set) Token: 0x0600E508 RID: 58632 RVA: 0x0006FAA9 File Offset: 0x0006DCA9
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004729 RID: 18217
				// (get) Token: 0x0600E509 RID: 58633 RVA: 0x0035AF50 File Offset: 0x00359150
				// (set) Token: 0x0600E50A RID: 58634 RVA: 0x0006FAC8 File Offset: 0x0006DCC8
				public unsafe BodySearchScreen.__c__DisplayClass37_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BodySearchScreen.__c__DisplayClass37_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700472A RID: 18218
				// (get) Token: 0x0600E50B RID: 58635 RVA: 0x0035AF80 File Offset: 0x00359180
				// (set) Token: 0x0600E50C RID: 58636 RVA: 0x0006FAE7 File Offset: 0x0006DCE7
				public unsafe float _perGap_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perGap_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perGap_5__2)) = value;
					}
				}

				// Token: 0x1700472B RID: 18219
				// (get) Token: 0x0600E50D RID: 58637 RVA: 0x0035AFA8 File Offset: 0x003591A8
				// (set) Token: 0x0600E50E RID: 58638 RVA: 0x0006FB02 File Offset: 0x0006DD02
				public unsafe float _perBlock_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perBlock_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perBlock_5__3)) = value;
					}
				}

				// Token: 0x1700472C RID: 18220
				// (get) Token: 0x0600E50F RID: 58639 RVA: 0x0035AFD0 File Offset: 0x003591D0
				// (set) Token: 0x0600E510 RID: 58640 RVA: 0x0006FB1D File Offset: 0x0006DD1D
				public unsafe float _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x04009926 RID: 39206
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009927 RID: 39207
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009928 RID: 39208
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009929 RID: 39209
				private static readonly IntPtr NativeFieldInfoPtr__perGap_5__2;

				// Token: 0x0400992A RID: 39210
				private static readonly IntPtr NativeFieldInfoPtr__perBlock_5__3;

				// Token: 0x0400992B RID: 39211
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x0400992C RID: 39212
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400992D RID: 39213
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400992E RID: 39214
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400992F RID: 39215
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009930 RID: 39216
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009931 RID: 39217
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
