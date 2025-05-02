using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200071A RID: 1818
	public class ItemUIManager : Singleton<ItemUIManager>
	{
		// Token: 0x0600A377 RID: 41847 RVA: 0x002904B0 File Offset: 0x0028E6B0
		// Note: this type is marked as 'beforefieldinit'.
		static ItemUIManager()
		{
			Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemUIManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr);
			ItemUIManager.NativeFieldInfoPtr__DraggingEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "<DraggingEnabled>k__BackingField");
			ItemUIManager.NativeFieldInfoPtr__HoveredSlot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "<HoveredSlot>k__BackingField");
			ItemUIManager.NativeFieldInfoPtr__QuickMoveEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "<QuickMoveEnabled>k__BackingField");
			ItemUIManager.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "Canvas");
			ItemUIManager.NativeFieldInfoPtr_Raycasters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "Raycasters");
			ItemUIManager.NativeFieldInfoPtr_CashDragAmountContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "CashDragAmountContainer");
			ItemUIManager.NativeFieldInfoPtr_InputsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "InputsContainer");
			ItemUIManager.NativeFieldInfoPtr_InfoPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "InfoPanel");
			ItemUIManager.NativeFieldInfoPtr_ItemQuantityPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "ItemQuantityPrompt");
			ItemUIManager.NativeFieldInfoPtr_CashSlotHintAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "CashSlotHintAnim");
			ItemUIManager.NativeFieldInfoPtr_CashSlotHintAnimCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "CashSlotHintAnimCanvasGroup");
			ItemUIManager.NativeFieldInfoPtr_ItemSlotUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "ItemSlotUIPrefab");
			ItemUIManager.NativeFieldInfoPtr_DefaultItemUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "DefaultItemUIPrefab");
			ItemUIManager.NativeFieldInfoPtr_HotbarSlotUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "HotbarSlotUIPrefab");
			ItemUIManager.NativeFieldInfoPtr_draggedSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "draggedSlot");
			ItemUIManager.NativeFieldInfoPtr_mouseOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "mouseOffset");
			ItemUIManager.NativeFieldInfoPtr_draggedAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "draggedAmount");
			ItemUIManager.NativeFieldInfoPtr_tempIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "tempIcon");
			ItemUIManager.NativeFieldInfoPtr_isDraggingCash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "isDraggingCash");
			ItemUIManager.NativeFieldInfoPtr_draggedCashAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "draggedCashAmount");
			ItemUIManager.NativeFieldInfoPtr_PrimarySlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "PrimarySlots");
			ItemUIManager.NativeFieldInfoPtr_SecondarySlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "SecondarySlots");
			ItemUIManager.NativeFieldInfoPtr_customDragAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "customDragAmount");
			ItemUIManager.NativeFieldInfoPtr_quantityChangePopRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "quantityChangePopRoutine");
			ItemUIManager.NativeFieldInfoPtr_onDragStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "onDragStart");
			ItemUIManager.NativeFieldInfoPtr_onItemMoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "onItemMoved");
			ItemUIManager.NativeMethodInfoPtr_get_DraggingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683287);
			ItemUIManager.NativeMethodInfoPtr_set_DraggingEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683288);
			ItemUIManager.NativeMethodInfoPtr_get_HoveredSlot_Public_get_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683289);
			ItemUIManager.NativeMethodInfoPtr_set_HoveredSlot_Protected_set_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683290);
			ItemUIManager.NativeMethodInfoPtr_get_QuickMoveEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683291);
			ItemUIManager.NativeMethodInfoPtr_set_QuickMoveEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683292);
			ItemUIManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683293);
			ItemUIManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683294);
			ItemUIManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683295);
			ItemUIManager.NativeMethodInfoPtr_UpdateCashDragSelectorUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683296);
			ItemUIManager.NativeMethodInfoPtr_UpdateCashDragAmount_Private_Void_CashInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683297);
			ItemUIManager.NativeMethodInfoPtr_SetDraggingEnabled_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683298);
			ItemUIManager.NativeMethodInfoPtr_EnableQuickMove_Public_Void_List_1_ItemSlot_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683299);
			ItemUIManager.NativeMethodInfoPtr_GetQuickMoveSlots_Private_List_1_ItemSlot_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683300);
			ItemUIManager.NativeMethodInfoPtr_DisableQuickMove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683301);
			ItemUIManager.NativeMethodInfoPtr_GetHoveredItemSlot_Private_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683302);
			ItemUIManager.NativeMethodInfoPtr_GetHoveredItemInfo_Private_ItemDefinitionInfoHoverable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683303);
			ItemUIManager.NativeMethodInfoPtr_SlotClicked_Private_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683304);
			ItemUIManager.NativeMethodInfoPtr_StartDragCash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683305);
			ItemUIManager.NativeMethodInfoPtr_EndDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683306);
			ItemUIManager.NativeMethodInfoPtr_SetDraggedAmount_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683307);
			ItemUIManager.NativeMethodInfoPtr_EndCashDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683308);
			ItemUIManager.NativeMethodInfoPtr_CanDragFromSlot_Public_Boolean_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683309);
			ItemUIManager.NativeMethodInfoPtr_CanCashBeDraggedIntoSlot_Public_Boolean_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683310);
			ItemUIManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683311);
		}

		// Token: 0x17003283 RID: 12931
		// (get) Token: 0x0600A378 RID: 41848 RVA: 0x002908DC File Offset: 0x0028EADC
		// (set) Token: 0x0600A379 RID: 41849 RVA: 0x00290918 File Offset: 0x0028EB18
		public unsafe bool DraggingEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_get_DraggingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_set_DraggingEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003284 RID: 12932
		// (get) Token: 0x0600A37A RID: 41850 RVA: 0x00290958 File Offset: 0x0028EB58
		// (set) Token: 0x0600A37B RID: 41851 RVA: 0x00290998 File Offset: 0x0028EB98
		public unsafe ItemSlotUI HoveredSlot
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_get_HoveredSlot_Public_get_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_set_HoveredSlot_Protected_set_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003285 RID: 12933
		// (get) Token: 0x0600A37C RID: 41852 RVA: 0x002909DC File Offset: 0x0028EBDC
		// (set) Token: 0x0600A37D RID: 41853 RVA: 0x00290A18 File Offset: 0x0028EC18
		public unsafe bool QuickMoveEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_get_QuickMoveEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_set_QuickMoveEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A37E RID: 41854 RVA: 0x00290A58 File Offset: 0x0028EC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286194, XrefRangeEnd = 286202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUIManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A37F RID: 41855 RVA: 0x00290A94 File Offset: 0x0028EC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286202, XrefRangeEnd = 286274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUIManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A380 RID: 41856 RVA: 0x00290AD0 File Offset: 0x0028ECD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286274, XrefRangeEnd = 286286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUIManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A381 RID: 41857 RVA: 0x00290B0C File Offset: 0x0028ED0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286307, RefRangeEnd = 286308, XrefRangeStart = 286286, XrefRangeEnd = 286307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCashDragSelectorUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_UpdateCashDragSelectorUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A382 RID: 41858 RVA: 0x00290B40 File Offset: 0x0028ED40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286308, XrefRangeEnd = 286330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCashDragAmount(CashInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_UpdateCashDragAmount_Private_Void_CashInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A383 RID: 41859 RVA: 0x00290B84 File Offset: 0x0028ED84
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 286345, RefRangeEnd = 286366, XrefRangeStart = 286330, XrefRangeEnd = 286345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDraggingEnabled(bool enabled, bool modifierPromptsVisible = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifierPromptsVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_SetDraggingEnabled_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A384 RID: 41860 RVA: 0x00290BD0 File Offset: 0x0028EDD0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 286386, RefRangeEnd = 286399, XrefRangeStart = 286366, XrefRangeEnd = 286386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableQuickMove(List<ItemSlot> primarySlots, List<ItemSlot> secondarySlots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(primarySlots);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondarySlots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_EnableQuickMove_Public_Void_List_1_ItemSlot_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A385 RID: 41861 RVA: 0x00290C24 File Offset: 0x0028EE24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286434, RefRangeEnd = 286436, XrefRangeStart = 286399, XrefRangeEnd = 286434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemSlot> GetQuickMoveSlots(ItemSlot sourceSlot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceSlot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_GetQuickMoveSlots_Private_List_1_ItemSlot_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
		}

		// Token: 0x0600A386 RID: 41862 RVA: 0x00290C74 File Offset: 0x0028EE74
		[CallerCount(0)]
		public unsafe void DisableQuickMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_DisableQuickMove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A387 RID: 41863 RVA: 0x00290CA8 File Offset: 0x0028EEA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286468, RefRangeEnd = 286469, XrefRangeStart = 286436, XrefRangeEnd = 286468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotUI GetHoveredItemSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_GetHoveredItemSlot_Private_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr3) : null;
		}

		// Token: 0x0600A388 RID: 41864 RVA: 0x00290CE8 File Offset: 0x0028EEE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286498, RefRangeEnd = 286499, XrefRangeStart = 286469, XrefRangeEnd = 286498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemDefinitionInfoHoverable GetHoveredItemInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_GetHoveredItemInfo_Private_ItemDefinitionInfoHoverable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemDefinitionInfoHoverable>(intPtr3) : null;
		}

		// Token: 0x0600A389 RID: 41865 RVA: 0x00290D28 File Offset: 0x0028EF28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286547, RefRangeEnd = 286548, XrefRangeStart = 286499, XrefRangeEnd = 286547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlotClicked(ItemSlotUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_SlotClicked_Private_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A38A RID: 41866 RVA: 0x00290D6C File Offset: 0x0028EF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286548, XrefRangeEnd = 286597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDragCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_StartDragCash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A38B RID: 41867 RVA: 0x00290DA0 File Offset: 0x0028EFA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286641, RefRangeEnd = 286643, XrefRangeStart = 286597, XrefRangeEnd = 286641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_EndDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A38C RID: 41868 RVA: 0x00290DD4 File Offset: 0x0028EFD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286684, RefRangeEnd = 286685, XrefRangeStart = 286643, XrefRangeEnd = 286684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDraggedAmount(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_SetDraggedAmount_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A38D RID: 41869 RVA: 0x00290E14 File Offset: 0x0028F014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286749, RefRangeEnd = 286750, XrefRangeStart = 286685, XrefRangeEnd = 286749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndCashDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_EndCashDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A38E RID: 41870 RVA: 0x00290E48 File Offset: 0x0028F048
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286755, RefRangeEnd = 286757, XrefRangeStart = 286750, XrefRangeEnd = 286755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanDragFromSlot(ItemSlotUI slotUI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slotUI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_CanDragFromSlot_Public_Boolean_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A38F RID: 41871 RVA: 0x00290E98 File Offset: 0x0028F098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286757, XrefRangeEnd = 286763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCashBeDraggedIntoSlot(ItemSlotUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_CanCashBeDraggedIntoSlot_Public_Boolean_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A390 RID: 41872 RVA: 0x00290EE8 File Offset: 0x0028F0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286763, XrefRangeEnd = 286780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemUIManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A391 RID: 41873 RVA: 0x000507C8 File Offset: 0x0004E9C8
		public ItemUIManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003269 RID: 12905
		// (get) Token: 0x0600A392 RID: 41874 RVA: 0x00290F24 File Offset: 0x0028F124
		// (set) Token: 0x0600A393 RID: 41875 RVA: 0x000507D1 File Offset: 0x0004E9D1
		public unsafe bool _DraggingEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__DraggingEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__DraggingEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700326A RID: 12906
		// (get) Token: 0x0600A394 RID: 41876 RVA: 0x00290F4C File Offset: 0x0028F14C
		// (set) Token: 0x0600A395 RID: 41877 RVA: 0x000507EC File Offset: 0x0004E9EC
		public unsafe ItemSlotUI _HoveredSlot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__HoveredSlot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__HoveredSlot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700326B RID: 12907
		// (get) Token: 0x0600A396 RID: 41878 RVA: 0x00290F7C File Offset: 0x0028F17C
		// (set) Token: 0x0600A397 RID: 41879 RVA: 0x0005080B File Offset: 0x0004EA0B
		public unsafe bool _QuickMoveEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__QuickMoveEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__QuickMoveEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700326C RID: 12908
		// (get) Token: 0x0600A398 RID: 41880 RVA: 0x00290FA4 File Offset: 0x0028F1A4
		// (set) Token: 0x0600A399 RID: 41881 RVA: 0x00050826 File Offset: 0x0004EA26
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700326D RID: 12909
		// (get) Token: 0x0600A39A RID: 41882 RVA: 0x00290FD4 File Offset: 0x0028F1D4
		// (set) Token: 0x0600A39B RID: 41883 RVA: 0x00050845 File Offset: 0x0004EA45
		public unsafe Il2CppReferenceArray<GraphicRaycaster> Raycasters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_Raycasters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GraphicRaycaster>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_Raycasters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700326E RID: 12910
		// (get) Token: 0x0600A39C RID: 41884 RVA: 0x00291004 File Offset: 0x0028F204
		// (set) Token: 0x0600A39D RID: 41885 RVA: 0x00050864 File Offset: 0x0004EA64
		public unsafe RectTransform CashDragAmountContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashDragAmountContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashDragAmountContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700326F RID: 12911
		// (get) Token: 0x0600A39E RID: 41886 RVA: 0x00291034 File Offset: 0x0028F234
		// (set) Token: 0x0600A39F RID: 41887 RVA: 0x00050883 File Offset: 0x0004EA83
		public unsafe RectTransform InputsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_InputsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_InputsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003270 RID: 12912
		// (get) Token: 0x0600A3A0 RID: 41888 RVA: 0x00291064 File Offset: 0x0028F264
		// (set) Token: 0x0600A3A1 RID: 41889 RVA: 0x000508A2 File Offset: 0x0004EAA2
		public unsafe ItemInfoPanel InfoPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_InfoPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInfoPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_InfoPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003271 RID: 12913
		// (get) Token: 0x0600A3A2 RID: 41890 RVA: 0x00291094 File Offset: 0x0028F294
		// (set) Token: 0x0600A3A3 RID: 41891 RVA: 0x000508C1 File Offset: 0x0004EAC1
		public unsafe RectTransform ItemQuantityPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_ItemQuantityPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_ItemQuantityPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003272 RID: 12914
		// (get) Token: 0x0600A3A4 RID: 41892 RVA: 0x002910C4 File Offset: 0x0028F2C4
		// (set) Token: 0x0600A3A5 RID: 41893 RVA: 0x000508E0 File Offset: 0x0004EAE0
		public unsafe Animation CashSlotHintAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashSlotHintAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashSlotHintAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003273 RID: 12915
		// (get) Token: 0x0600A3A6 RID: 41894 RVA: 0x002910F4 File Offset: 0x0028F2F4
		// (set) Token: 0x0600A3A7 RID: 41895 RVA: 0x000508FF File Offset: 0x0004EAFF
		public unsafe CanvasGroup CashSlotHintAnimCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashSlotHintAnimCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashSlotHintAnimCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003274 RID: 12916
		// (get) Token: 0x0600A3A8 RID: 41896 RVA: 0x00291124 File Offset: 0x0028F324
		// (set) Token: 0x0600A3A9 RID: 41897 RVA: 0x0005091E File Offset: 0x0004EB1E
		public unsafe ItemSlotUI ItemSlotUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_ItemSlotUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_ItemSlotUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003275 RID: 12917
		// (get) Token: 0x0600A3AA RID: 41898 RVA: 0x00291154 File Offset: 0x0028F354
		// (set) Token: 0x0600A3AB RID: 41899 RVA: 0x0005093D File Offset: 0x0004EB3D
		public unsafe ItemUI DefaultItemUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_DefaultItemUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_DefaultItemUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003276 RID: 12918
		// (get) Token: 0x0600A3AC RID: 41900 RVA: 0x00291184 File Offset: 0x0028F384
		// (set) Token: 0x0600A3AD RID: 41901 RVA: 0x0005095C File Offset: 0x0004EB5C
		public unsafe ItemSlotUI HotbarSlotUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_HotbarSlotUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_HotbarSlotUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003277 RID: 12919
		// (get) Token: 0x0600A3AE RID: 41902 RVA: 0x002911B4 File Offset: 0x0028F3B4
		// (set) Token: 0x0600A3AF RID: 41903 RVA: 0x0005097B File Offset: 0x0004EB7B
		public unsafe ItemSlotUI draggedSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003278 RID: 12920
		// (get) Token: 0x0600A3B0 RID: 41904 RVA: 0x002911E4 File Offset: 0x0028F3E4
		// (set) Token: 0x0600A3B1 RID: 41905 RVA: 0x0005099A File Offset: 0x0004EB9A
		public unsafe Vector2 mouseOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_mouseOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_mouseOffset)) = value;
			}
		}

		// Token: 0x17003279 RID: 12921
		// (get) Token: 0x0600A3B2 RID: 41906 RVA: 0x0029120C File Offset: 0x0028F40C
		// (set) Token: 0x0600A3B3 RID: 41907 RVA: 0x000509B5 File Offset: 0x0004EBB5
		public unsafe int draggedAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedAmount)) = value;
			}
		}

		// Token: 0x1700327A RID: 12922
		// (get) Token: 0x0600A3B4 RID: 41908 RVA: 0x00291234 File Offset: 0x0028F434
		// (set) Token: 0x0600A3B5 RID: 41909 RVA: 0x000509D0 File Offset: 0x0004EBD0
		public unsafe RectTransform tempIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_tempIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_tempIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700327B RID: 12923
		// (get) Token: 0x0600A3B6 RID: 41910 RVA: 0x00291264 File Offset: 0x0028F464
		// (set) Token: 0x0600A3B7 RID: 41911 RVA: 0x000509EF File Offset: 0x0004EBEF
		public unsafe bool isDraggingCash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_isDraggingCash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_isDraggingCash)) = value;
			}
		}

		// Token: 0x1700327C RID: 12924
		// (get) Token: 0x0600A3B8 RID: 41912 RVA: 0x0029128C File Offset: 0x0028F48C
		// (set) Token: 0x0600A3B9 RID: 41913 RVA: 0x00050A0A File Offset: 0x0004EC0A
		public unsafe float draggedCashAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedCashAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedCashAmount)) = value;
			}
		}

		// Token: 0x1700327D RID: 12925
		// (get) Token: 0x0600A3BA RID: 41914 RVA: 0x002912B4 File Offset: 0x0028F4B4
		// (set) Token: 0x0600A3BB RID: 41915 RVA: 0x00050A25 File Offset: 0x0004EC25
		public unsafe List<ItemSlot> PrimarySlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_PrimarySlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_PrimarySlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700327E RID: 12926
		// (get) Token: 0x0600A3BC RID: 41916 RVA: 0x002912E4 File Offset: 0x0028F4E4
		// (set) Token: 0x0600A3BD RID: 41917 RVA: 0x00050A44 File Offset: 0x0004EC44
		public unsafe List<ItemSlot> SecondarySlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_SecondarySlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_SecondarySlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700327F RID: 12927
		// (get) Token: 0x0600A3BE RID: 41918 RVA: 0x00291314 File Offset: 0x0028F514
		// (set) Token: 0x0600A3BF RID: 41919 RVA: 0x00050A63 File Offset: 0x0004EC63
		public unsafe bool customDragAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_customDragAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_customDragAmount)) = value;
			}
		}

		// Token: 0x17003280 RID: 12928
		// (get) Token: 0x0600A3C0 RID: 41920 RVA: 0x0029133C File Offset: 0x0028F53C
		// (set) Token: 0x0600A3C1 RID: 41921 RVA: 0x00050A7E File Offset: 0x0004EC7E
		public unsafe Coroutine quantityChangePopRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_quantityChangePopRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_quantityChangePopRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003281 RID: 12929
		// (get) Token: 0x0600A3C2 RID: 41922 RVA: 0x0029136C File Offset: 0x0028F56C
		// (set) Token: 0x0600A3C3 RID: 41923 RVA: 0x00050A9D File Offset: 0x0004EC9D
		public unsafe UnityEvent onDragStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_onDragStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_onDragStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003282 RID: 12930
		// (get) Token: 0x0600A3C4 RID: 41924 RVA: 0x0029139C File Offset: 0x0028F59C
		// (set) Token: 0x0600A3C5 RID: 41925 RVA: 0x00050ABC File Offset: 0x0004ECBC
		public unsafe UnityEvent onItemMoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_onItemMoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_onItemMoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D9F RID: 28063
		private static readonly IntPtr NativeFieldInfoPtr__DraggingEnabled_k__BackingField;

		// Token: 0x04006DA0 RID: 28064
		private static readonly IntPtr NativeFieldInfoPtr__HoveredSlot_k__BackingField;

		// Token: 0x04006DA1 RID: 28065
		private static readonly IntPtr NativeFieldInfoPtr__QuickMoveEnabled_k__BackingField;

		// Token: 0x04006DA2 RID: 28066
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006DA3 RID: 28067
		private static readonly IntPtr NativeFieldInfoPtr_Raycasters;

		// Token: 0x04006DA4 RID: 28068
		private static readonly IntPtr NativeFieldInfoPtr_CashDragAmountContainer;

		// Token: 0x04006DA5 RID: 28069
		private static readonly IntPtr NativeFieldInfoPtr_InputsContainer;

		// Token: 0x04006DA6 RID: 28070
		private static readonly IntPtr NativeFieldInfoPtr_InfoPanel;

		// Token: 0x04006DA7 RID: 28071
		private static readonly IntPtr NativeFieldInfoPtr_ItemQuantityPrompt;

		// Token: 0x04006DA8 RID: 28072
		private static readonly IntPtr NativeFieldInfoPtr_CashSlotHintAnim;

		// Token: 0x04006DA9 RID: 28073
		private static readonly IntPtr NativeFieldInfoPtr_CashSlotHintAnimCanvasGroup;

		// Token: 0x04006DAA RID: 28074
		private static readonly IntPtr NativeFieldInfoPtr_ItemSlotUIPrefab;

		// Token: 0x04006DAB RID: 28075
		private static readonly IntPtr NativeFieldInfoPtr_DefaultItemUIPrefab;

		// Token: 0x04006DAC RID: 28076
		private static readonly IntPtr NativeFieldInfoPtr_HotbarSlotUIPrefab;

		// Token: 0x04006DAD RID: 28077
		private static readonly IntPtr NativeFieldInfoPtr_draggedSlot;

		// Token: 0x04006DAE RID: 28078
		private static readonly IntPtr NativeFieldInfoPtr_mouseOffset;

		// Token: 0x04006DAF RID: 28079
		private static readonly IntPtr NativeFieldInfoPtr_draggedAmount;

		// Token: 0x04006DB0 RID: 28080
		private static readonly IntPtr NativeFieldInfoPtr_tempIcon;

		// Token: 0x04006DB1 RID: 28081
		private static readonly IntPtr NativeFieldInfoPtr_isDraggingCash;

		// Token: 0x04006DB2 RID: 28082
		private static readonly IntPtr NativeFieldInfoPtr_draggedCashAmount;

		// Token: 0x04006DB3 RID: 28083
		private static readonly IntPtr NativeFieldInfoPtr_PrimarySlots;

		// Token: 0x04006DB4 RID: 28084
		private static readonly IntPtr NativeFieldInfoPtr_SecondarySlots;

		// Token: 0x04006DB5 RID: 28085
		private static readonly IntPtr NativeFieldInfoPtr_customDragAmount;

		// Token: 0x04006DB6 RID: 28086
		private static readonly IntPtr NativeFieldInfoPtr_quantityChangePopRoutine;

		// Token: 0x04006DB7 RID: 28087
		private static readonly IntPtr NativeFieldInfoPtr_onDragStart;

		// Token: 0x04006DB8 RID: 28088
		private static readonly IntPtr NativeFieldInfoPtr_onItemMoved;

		// Token: 0x04006DB9 RID: 28089
		private static readonly IntPtr NativeMethodInfoPtr_get_DraggingEnabled_Public_get_Boolean_0;

		// Token: 0x04006DBA RID: 28090
		private static readonly IntPtr NativeMethodInfoPtr_set_DraggingEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04006DBB RID: 28091
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredSlot_Public_get_ItemSlotUI_0;

		// Token: 0x04006DBC RID: 28092
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredSlot_Protected_set_Void_ItemSlotUI_0;

		// Token: 0x04006DBD RID: 28093
		private static readonly IntPtr NativeMethodInfoPtr_get_QuickMoveEnabled_Public_get_Boolean_0;

		// Token: 0x04006DBE RID: 28094
		private static readonly IntPtr NativeMethodInfoPtr_set_QuickMoveEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04006DBF RID: 28095
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006DC0 RID: 28096
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006DC1 RID: 28097
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04006DC2 RID: 28098
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCashDragSelectorUI_Private_Void_0;

		// Token: 0x04006DC3 RID: 28099
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCashDragAmount_Private_Void_CashInstance_0;

		// Token: 0x04006DC4 RID: 28100
		private static readonly IntPtr NativeMethodInfoPtr_SetDraggingEnabled_Public_Void_Boolean_Boolean_0;

		// Token: 0x04006DC5 RID: 28101
		private static readonly IntPtr NativeMethodInfoPtr_EnableQuickMove_Public_Void_List_1_ItemSlot_List_1_ItemSlot_0;

		// Token: 0x04006DC6 RID: 28102
		private static readonly IntPtr NativeMethodInfoPtr_GetQuickMoveSlots_Private_List_1_ItemSlot_ItemSlot_0;

		// Token: 0x04006DC7 RID: 28103
		private static readonly IntPtr NativeMethodInfoPtr_DisableQuickMove_Public_Void_0;

		// Token: 0x04006DC8 RID: 28104
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredItemSlot_Private_ItemSlotUI_0;

		// Token: 0x04006DC9 RID: 28105
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredItemInfo_Private_ItemDefinitionInfoHoverable_0;

		// Token: 0x04006DCA RID: 28106
		private static readonly IntPtr NativeMethodInfoPtr_SlotClicked_Private_Void_ItemSlotUI_0;

		// Token: 0x04006DCB RID: 28107
		private static readonly IntPtr NativeMethodInfoPtr_StartDragCash_Private_Void_0;

		// Token: 0x04006DCC RID: 28108
		private static readonly IntPtr NativeMethodInfoPtr_EndDrag_Private_Void_0;

		// Token: 0x04006DCD RID: 28109
		private static readonly IntPtr NativeMethodInfoPtr_SetDraggedAmount_Private_Void_Int32_0;

		// Token: 0x04006DCE RID: 28110
		private static readonly IntPtr NativeMethodInfoPtr_EndCashDrag_Private_Void_0;

		// Token: 0x04006DCF RID: 28111
		private static readonly IntPtr NativeMethodInfoPtr_CanDragFromSlot_Public_Boolean_ItemSlotUI_0;

		// Token: 0x04006DD0 RID: 28112
		private static readonly IntPtr NativeMethodInfoPtr_CanCashBeDraggedIntoSlot_Public_Boolean_ItemSlotUI_0;

		// Token: 0x04006DD1 RID: 28113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BC1 RID: 3009
		[ObfuscatedName("ScheduleOne.UI.Items.ItemUIManager+<>c__DisplayClass49_0")]
		public sealed class __c__DisplayClass49_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DDA4 RID: 56740 RVA: 0x0034566C File Offset: 0x0034386C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass49_0()
			{
				Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "<>c__DisplayClass49_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0>.NativeClassPtr);
				ItemUIManager.__c__DisplayClass49_0.NativeFieldInfoPtr_quantityText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0>.NativeClassPtr, "quantityText");
				ItemUIManager.__c__DisplayClass49_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0>.NativeClassPtr, "<>4__this");
				ItemUIManager.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0>.NativeClassPtr, 100683312);
				ItemUIManager.__c__DisplayClass49_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0>.NativeClassPtr, 100683313);
			}

			// Token: 0x0600DDA5 RID: 56741 RVA: 0x003456E8 File Offset: 0x003438E8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass49_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDA6 RID: 56742 RVA: 0x00345724 File Offset: 0x00343924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286189, XrefRangeEnd = 286194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass49_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DDA7 RID: 56743 RVA: 0x0006C019 File Offset: 0x0006A219
			public __c__DisplayClass49_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044AC RID: 17580
			// (get) Token: 0x0600DDA8 RID: 56744 RVA: 0x00345764 File Offset: 0x00343964
			// (set) Token: 0x0600DDA9 RID: 56745 RVA: 0x0006C022 File Offset: 0x0006A222
			public unsafe TextMeshProUGUI quantityText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.NativeFieldInfoPtr_quantityText);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.NativeFieldInfoPtr_quantityText), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044AD RID: 17581
			// (get) Token: 0x0600DDAA RID: 56746 RVA: 0x00345794 File Offset: 0x00343994
			// (set) Token: 0x0600DDAB RID: 56747 RVA: 0x0006C041 File Offset: 0x0006A241
			public unsafe ItemUIManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009479 RID: 38009
			private static readonly IntPtr NativeFieldInfoPtr_quantityText;

			// Token: 0x0400947A RID: 38010
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400947B RID: 38011
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400947C RID: 38012
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C84 RID: 3204
			[ObfuscatedName("ScheduleOne.UI.Items.ItemUIManager+<>c__DisplayClass49_0+<<SetDraggedAmount>g__LerpQuantityTextSize|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E6C0 RID: 59072 RVA: 0x0035FBB4 File Offset: 0x0035DDB4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique()
				{
					Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0>.NativeClassPtr, "<<SetDraggedAmount>g__LerpQuantityTextSize|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr);
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>1__state");
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>2__current");
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>4__this");
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr__quantityTransform_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<quantityTransform>5__2");
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100683314);
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100683315);
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100683316);
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100683317);
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100683318);
					ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100683319);
				}

				// Token: 0x0600E6C1 RID: 59073 RVA: 0x0035FCA8 File Offset: 0x0035DEA8
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E6C2 RID: 59074 RVA: 0x0035FCF0 File Offset: 0x0035DEF0
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E6C3 RID: 59075 RVA: 0x0035FD24 File Offset: 0x0035DF24
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286168, XrefRangeEnd = 286184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170047E0 RID: 18400
				// (get) Token: 0x0600E6C4 RID: 59076 RVA: 0x0035FD60 File Offset: 0x0035DF60
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E6C5 RID: 59077 RVA: 0x0035FDA0 File Offset: 0x0035DFA0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286184, XrefRangeEnd = 286189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170047E1 RID: 18401
				// (get) Token: 0x0600E6C6 RID: 59078 RVA: 0x0035FDD4 File Offset: 0x0035DFD4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E6C7 RID: 59079 RVA: 0x00070A91 File Offset: 0x0006EC91
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047DC RID: 18396
				// (get) Token: 0x0600E6C8 RID: 59080 RVA: 0x0035FE14 File Offset: 0x0035E014
				// (set) Token: 0x0600E6C9 RID: 59081 RVA: 0x00070A9A File Offset: 0x0006EC9A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047DD RID: 18397
				// (get) Token: 0x0600E6CA RID: 59082 RVA: 0x0035FE3C File Offset: 0x0035E03C
				// (set) Token: 0x0600E6CB RID: 59083 RVA: 0x00070AB5 File Offset: 0x0006ECB5
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047DE RID: 18398
				// (get) Token: 0x0600E6CC RID: 59084 RVA: 0x0035FE6C File Offset: 0x0035E06C
				// (set) Token: 0x0600E6CD RID: 59085 RVA: 0x00070AD4 File Offset: 0x0006ECD4
				public unsafe ItemUIManager.__c__DisplayClass49_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUIManager.__c__DisplayClass49_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047DF RID: 18399
				// (get) Token: 0x0600E6CE RID: 59086 RVA: 0x0035FE9C File Offset: 0x0035E09C
				// (set) Token: 0x0600E6CF RID: 59087 RVA: 0x00070AF3 File Offset: 0x0006ECF3
				public unsafe RectTransform _quantityTransform_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr__quantityTransform_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass49_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr__quantityTransform_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009A34 RID: 39476
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009A35 RID: 39477
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009A36 RID: 39478
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009A37 RID: 39479
				private static readonly IntPtr NativeFieldInfoPtr__quantityTransform_5__2;

				// Token: 0x04009A38 RID: 39480
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009A39 RID: 39481
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A3A RID: 39482
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009A3B RID: 39483
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009A3C RID: 39484
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A3D RID: 39485
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
