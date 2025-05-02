using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.UI.Items;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000645 RID: 1605
	public class ItemSlotUI : MonoBehaviour
	{
		// Token: 0x06008E16 RID: 36374 RVA: 0x0024F870 File Offset: 0x0024DA70
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSlotUI()
		{
			Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ItemSlotUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr);
			ItemSlotUI.NativeFieldInfoPtr_normalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "normalColor");
			ItemSlotUI.NativeFieldInfoPtr_highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "highlightColor");
			ItemSlotUI.NativeFieldInfoPtr__assignedSlot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "<assignedSlot>k__BackingField");
			ItemSlotUI.NativeFieldInfoPtr_IsBeingDragged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "IsBeingDragged");
			ItemSlotUI.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "Rect");
			ItemSlotUI.NativeFieldInfoPtr_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "Background");
			ItemSlotUI.NativeFieldInfoPtr_LockContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "LockContainer");
			ItemSlotUI.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "ItemContainer");
			ItemSlotUI.NativeFieldInfoPtr__ItemUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "<ItemUI>k__BackingField");
			ItemSlotUI.NativeMethodInfoPtr_get_assignedSlot_Public_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680938);
			ItemSlotUI.NativeMethodInfoPtr_set_assignedSlot_Protected_set_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680939);
			ItemSlotUI.NativeMethodInfoPtr_get_ItemUI_Public_get_ItemUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680940);
			ItemSlotUI.NativeMethodInfoPtr_set_ItemUI_Protected_set_Void_ItemUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680941);
			ItemSlotUI.NativeMethodInfoPtr_AssignSlot_Public_Virtual_New_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680942);
			ItemSlotUI.NativeMethodInfoPtr_ClearSlot_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680943);
			ItemSlotUI.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680944);
			ItemSlotUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680945);
			ItemSlotUI.NativeMethodInfoPtr_SetHighlighted_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680946);
			ItemSlotUI.NativeMethodInfoPtr_SetNormalColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680947);
			ItemSlotUI.NativeMethodInfoPtr_SetHighlightColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680948);
			ItemSlotUI.NativeMethodInfoPtr_Lock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680949);
			ItemSlotUI.NativeMethodInfoPtr_Unlock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680950);
			ItemSlotUI.NativeMethodInfoPtr_SetLockVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680951);
			ItemSlotUI.NativeMethodInfoPtr_DuplicateIcon_Public_RectTransform_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680952);
			ItemSlotUI.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680953);
			ItemSlotUI.NativeMethodInfoPtr_OverrideDisplayedQuantity_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680954);
			ItemSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100680955);
		}

		// Token: 0x17002B6E RID: 11118
		// (get) Token: 0x06008E17 RID: 36375 RVA: 0x0024FABC File Offset: 0x0024DCBC
		// (set) Token: 0x06008E18 RID: 36376 RVA: 0x0024FAFC File Offset: 0x0024DCFC
		public unsafe ItemSlot assignedSlot
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_get_assignedSlot_Public_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_set_assignedSlot_Protected_set_Void_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002B6F RID: 11119
		// (get) Token: 0x06008E19 RID: 36377 RVA: 0x0024FB40 File Offset: 0x0024DD40
		// (set) Token: 0x06008E1A RID: 36378 RVA: 0x0024FB80 File Offset: 0x0024DD80
		public unsafe ItemUI ItemUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_get_ItemUI_Public_get_ItemUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemUI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_set_ItemUI_Protected_set_Void_ItemUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008E1B RID: 36379 RVA: 0x0024FBC4 File Offset: 0x0024DDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258730, XrefRangeEnd = 258791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignSlot(ItemSlot s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlotUI.NativeMethodInfoPtr_AssignSlot_Public_Virtual_New_Void_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E1C RID: 36380 RVA: 0x0024FC14 File Offset: 0x0024DE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258791, XrefRangeEnd = 258836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlotUI.NativeMethodInfoPtr_ClearSlot_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E1D RID: 36381 RVA: 0x0024FC50 File Offset: 0x0024DE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258836, XrefRangeEnd = 258845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E1E RID: 36382 RVA: 0x0024FC84 File Offset: 0x0024DE84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258845, XrefRangeEnd = 258869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlotUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E1F RID: 36383 RVA: 0x0024FCC0 File Offset: 0x0024DEC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258870, RefRangeEnd = 258872, XrefRangeStart = 258869, XrefRangeEnd = 258870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHighlighted(bool h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetHighlighted_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E20 RID: 36384 RVA: 0x0024FD00 File Offset: 0x0024DF00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258873, RefRangeEnd = 258875, XrefRangeStart = 258872, XrefRangeEnd = 258873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormalColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetNormalColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E21 RID: 36385 RVA: 0x0024FD40 File Offset: 0x0024DF40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258876, RefRangeEnd = 258877, XrefRangeStart = 258875, XrefRangeEnd = 258876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHighlightColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetHighlightColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E22 RID: 36386 RVA: 0x0024FD80 File Offset: 0x0024DF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258877, XrefRangeEnd = 258880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Lock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_Lock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E23 RID: 36387 RVA: 0x0024FDB4 File Offset: 0x0024DFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258880, XrefRangeEnd = 258883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_Unlock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E24 RID: 36388 RVA: 0x0024FDE8 File Offset: 0x0024DFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258883, XrefRangeEnd = 258886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLockVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetLockVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E25 RID: 36389 RVA: 0x0024FE28 File Offset: 0x0024E028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258886, XrefRangeEnd = 258891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransform DuplicateIcon(Transform parent, int overriddenQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overriddenQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_DuplicateIcon_Public_RectTransform_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x06008E26 RID: 36390 RVA: 0x0024FE88 File Offset: 0x0024E088
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 258895, RefRangeEnd = 258898, XrefRangeStart = 258891, XrefRangeEnd = 258895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool shown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E27 RID: 36391 RVA: 0x0024FEC8 File Offset: 0x0024E0C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258902, RefRangeEnd = 258903, XrefRangeStart = 258898, XrefRangeEnd = 258902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideDisplayedQuantity(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_OverrideDisplayedQuantity_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E28 RID: 36392 RVA: 0x0024FF08 File Offset: 0x0024E108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E29 RID: 36393 RVA: 0x000444D7 File Offset: 0x000426D7
		public ItemSlotUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B65 RID: 11109
		// (get) Token: 0x06008E2A RID: 36394 RVA: 0x0024FF44 File Offset: 0x0024E144
		// (set) Token: 0x06008E2B RID: 36395 RVA: 0x000444E0 File Offset: 0x000426E0
		public unsafe Color32 normalColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_normalColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_normalColor)) = value;
			}
		}

		// Token: 0x17002B66 RID: 11110
		// (get) Token: 0x06008E2C RID: 36396 RVA: 0x0024FF6C File Offset: 0x0024E16C
		// (set) Token: 0x06008E2D RID: 36397 RVA: 0x000444FB File Offset: 0x000426FB
		public unsafe Color32 highlightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_highlightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_highlightColor)) = value;
			}
		}

		// Token: 0x17002B67 RID: 11111
		// (get) Token: 0x06008E2E RID: 36398 RVA: 0x0024FF94 File Offset: 0x0024E194
		// (set) Token: 0x06008E2F RID: 36399 RVA: 0x00044516 File Offset: 0x00042716
		public unsafe ItemSlot _assignedSlot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__assignedSlot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__assignedSlot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B68 RID: 11112
		// (get) Token: 0x06008E30 RID: 36400 RVA: 0x0024FFC4 File Offset: 0x0024E1C4
		// (set) Token: 0x06008E31 RID: 36401 RVA: 0x00044535 File Offset: 0x00042735
		public unsafe bool IsBeingDragged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_IsBeingDragged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_IsBeingDragged)) = value;
			}
		}

		// Token: 0x17002B69 RID: 11113
		// (get) Token: 0x06008E32 RID: 36402 RVA: 0x0024FFEC File Offset: 0x0024E1EC
		// (set) Token: 0x06008E33 RID: 36403 RVA: 0x00044550 File Offset: 0x00042750
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B6A RID: 11114
		// (get) Token: 0x06008E34 RID: 36404 RVA: 0x0025001C File Offset: 0x0024E21C
		// (set) Token: 0x06008E35 RID: 36405 RVA: 0x0004456F File Offset: 0x0004276F
		public unsafe Image Background
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_Background);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_Background), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B6B RID: 11115
		// (get) Token: 0x06008E36 RID: 36406 RVA: 0x0025004C File Offset: 0x0024E24C
		// (set) Token: 0x06008E37 RID: 36407 RVA: 0x0004458E File Offset: 0x0004278E
		public unsafe GameObject LockContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_LockContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_LockContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B6C RID: 11116
		// (get) Token: 0x06008E38 RID: 36408 RVA: 0x0025007C File Offset: 0x0024E27C
		// (set) Token: 0x06008E39 RID: 36409 RVA: 0x000445AD File Offset: 0x000427AD
		public unsafe RectTransform ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B6D RID: 11117
		// (get) Token: 0x06008E3A RID: 36410 RVA: 0x002500AC File Offset: 0x0024E2AC
		// (set) Token: 0x06008E3B RID: 36411 RVA: 0x000445CC File Offset: 0x000427CC
		public unsafe ItemUI _ItemUI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__ItemUI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__ItemUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006034 RID: 24628
		private static readonly IntPtr NativeFieldInfoPtr_normalColor;

		// Token: 0x04006035 RID: 24629
		private static readonly IntPtr NativeFieldInfoPtr_highlightColor;

		// Token: 0x04006036 RID: 24630
		private static readonly IntPtr NativeFieldInfoPtr__assignedSlot_k__BackingField;

		// Token: 0x04006037 RID: 24631
		private static readonly IntPtr NativeFieldInfoPtr_IsBeingDragged;

		// Token: 0x04006038 RID: 24632
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04006039 RID: 24633
		private static readonly IntPtr NativeFieldInfoPtr_Background;

		// Token: 0x0400603A RID: 24634
		private static readonly IntPtr NativeFieldInfoPtr_LockContainer;

		// Token: 0x0400603B RID: 24635
		private static readonly IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x0400603C RID: 24636
		private static readonly IntPtr NativeFieldInfoPtr__ItemUI_k__BackingField;

		// Token: 0x0400603D RID: 24637
		private static readonly IntPtr NativeMethodInfoPtr_get_assignedSlot_Public_get_ItemSlot_0;

		// Token: 0x0400603E RID: 24638
		private static readonly IntPtr NativeMethodInfoPtr_set_assignedSlot_Protected_set_Void_ItemSlot_0;

		// Token: 0x0400603F RID: 24639
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemUI_Public_get_ItemUI_0;

		// Token: 0x04006040 RID: 24640
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemUI_Protected_set_Void_ItemUI_0;

		// Token: 0x04006041 RID: 24641
		private static readonly IntPtr NativeMethodInfoPtr_AssignSlot_Public_Virtual_New_Void_ItemSlot_0;

		// Token: 0x04006042 RID: 24642
		private static readonly IntPtr NativeMethodInfoPtr_ClearSlot_Public_Virtual_New_Void_0;

		// Token: 0x04006043 RID: 24643
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x04006044 RID: 24644
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0;

		// Token: 0x04006045 RID: 24645
		private static readonly IntPtr NativeMethodInfoPtr_SetHighlighted_Public_Void_Boolean_0;

		// Token: 0x04006046 RID: 24646
		private static readonly IntPtr NativeMethodInfoPtr_SetNormalColor_Public_Void_Color_0;

		// Token: 0x04006047 RID: 24647
		private static readonly IntPtr NativeMethodInfoPtr_SetHighlightColor_Public_Void_Color_0;

		// Token: 0x04006048 RID: 24648
		private static readonly IntPtr NativeMethodInfoPtr_Lock_Private_Void_0;

		// Token: 0x04006049 RID: 24649
		private static readonly IntPtr NativeMethodInfoPtr_Unlock_Private_Void_0;

		// Token: 0x0400604A RID: 24650
		private static readonly IntPtr NativeMethodInfoPtr_SetLockVisible_Public_Void_Boolean_0;

		// Token: 0x0400604B RID: 24651
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateIcon_Public_RectTransform_Transform_Int32_0;

		// Token: 0x0400604C RID: 24652
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x0400604D RID: 24653
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDisplayedQuantity_Public_Void_Int32_0;

		// Token: 0x0400604E RID: 24654
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
