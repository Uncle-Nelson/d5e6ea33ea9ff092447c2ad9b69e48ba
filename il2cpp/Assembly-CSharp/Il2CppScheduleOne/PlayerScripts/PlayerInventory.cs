using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.UI;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003E7 RID: 999
	public class PlayerInventory : PlayerSingleton<PlayerInventory>
	{
		// Token: 0x060050E2 RID: 20706 RVA: 0x00181568 File Offset: 0x0017F768
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerInventory()
		{
			Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerInventory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr);
			PlayerInventory.NativeFieldInfoPtr_LABEL_DISPLAY_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "LABEL_DISPLAY_TIME");
			PlayerInventory.NativeFieldInfoPtr_LABEL_FADE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "LABEL_FADE_TIME");
			PlayerInventory.NativeFieldInfoPtr_DISCARD_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "DISCARD_TIME");
			PlayerInventory.NativeFieldInfoPtr_INVENTORY_SLOT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "INVENTORY_SLOT_COUNT");
			PlayerInventory.NativeFieldInfoPtr_giveStartupItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "giveStartupItems");
			PlayerInventory.NativeFieldInfoPtr_startupItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "startupItems");
			PlayerInventory.NativeFieldInfoPtr_equipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "equipContainer");
			PlayerInventory.NativeFieldInfoPtr_hotbarSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "hotbarSlots");
			PlayerInventory.NativeFieldInfoPtr__cashSlot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<cashSlot>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr__cashInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<cashInstance>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr_clipboardSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "clipboardSlot");
			PlayerInventory.NativeFieldInfoPtr_slotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "slotUIs");
			PlayerInventory.NativeFieldInfoPtr_discardSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "discardSlot");
			PlayerInventory.NativeFieldInfoPtr_ItemVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "ItemVariables");
			PlayerInventory.NativeFieldInfoPtr__EquippedSlotIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<EquippedSlotIndex>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr__HotbarEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<HotbarEnabled>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr__EquippingEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<EquippingEnabled>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr__equippable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<equippable>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr_onInventoryStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "onInventoryStateChanged");
			PlayerInventory.NativeFieldInfoPtr_PriorEquippedSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "PriorEquippedSlotIndex");
			PlayerInventory.NativeFieldInfoPtr_PreviousEquippedSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "PreviousEquippedSlotIndex");
			PlayerInventory.NativeFieldInfoPtr_onPreItemEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "onPreItemEquipped");
			PlayerInventory.NativeFieldInfoPtr_onItemEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "onItemEquipped");
			PlayerInventory.NativeFieldInfoPtr_ManagementSlotEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "ManagementSlotEnabled");
			PlayerInventory.NativeFieldInfoPtr_currentEquipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "currentEquipTime");
			PlayerInventory.NativeFieldInfoPtr_currentDiscardTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "currentDiscardTime");
			PlayerInventory.NativeMethodInfoPtr_get_TOTAL_SLOT_COUNT_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673444);
			PlayerInventory.NativeMethodInfoPtr_get_cashSlot_Public_get_CashSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673445);
			PlayerInventory.NativeMethodInfoPtr_set_cashSlot_Private_set_Void_CashSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673446);
			PlayerInventory.NativeMethodInfoPtr_get_cashInstance_Public_get_CashInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673447);
			PlayerInventory.NativeMethodInfoPtr_set_cashInstance_Protected_set_Void_CashInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673448);
			PlayerInventory.NativeMethodInfoPtr_get_EquippedSlotIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673449);
			PlayerInventory.NativeMethodInfoPtr_set_EquippedSlotIndex_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673450);
			PlayerInventory.NativeMethodInfoPtr_get_HotbarEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673451);
			PlayerInventory.NativeMethodInfoPtr_set_HotbarEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673452);
			PlayerInventory.NativeMethodInfoPtr_get_EquippingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673453);
			PlayerInventory.NativeMethodInfoPtr_set_EquippingEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673454);
			PlayerInventory.NativeMethodInfoPtr_get_equippable_Public_get_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673455);
			PlayerInventory.NativeMethodInfoPtr_set_equippable_Protected_set_Void_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673456);
			PlayerInventory.NativeMethodInfoPtr_get_equippedSlot_Public_get_HotbarSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673457);
			PlayerInventory.NativeMethodInfoPtr_get_isAnythingEquipped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673458);
			PlayerInventory.NativeMethodInfoPtr_IndexAllSlots_Public_HotbarSlot_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673459);
			PlayerInventory.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673460);
			PlayerInventory.NativeMethodInfoPtr_SetupInventoryUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673461);
			PlayerInventory.NativeMethodInfoPtr_RepositionUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673462);
			PlayerInventory.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673463);
			PlayerInventory.NativeMethodInfoPtr_GiveStartupItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673464);
			PlayerInventory.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673465);
			PlayerInventory.NativeMethodInfoPtr_UpdateHotbarSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673466);
			PlayerInventory.NativeMethodInfoPtr_Equip_Public_Void_HotbarSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673467);
			PlayerInventory.NativeMethodInfoPtr_SetInventoryEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673468);
			PlayerInventory.NativeMethodInfoPtr_SetEquippingEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673469);
			PlayerInventory.NativeMethodInfoPtr_ClipboardAcquiredVarChange_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673470);
			PlayerInventory.NativeMethodInfoPtr_SetManagementClipboardEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673471);
			PlayerInventory.NativeMethodInfoPtr_SetViewmodelVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673472);
			PlayerInventory.NativeMethodInfoPtr_CanItemFitInInventory_Public_Boolean_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673473);
			PlayerInventory.NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673474);
			PlayerInventory.NativeMethodInfoPtr_GetAmountOfItem_Public_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673475);
			PlayerInventory.NativeMethodInfoPtr_RemoveAmountOfItem_Public_Void_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673476);
			PlayerInventory.NativeMethodInfoPtr_ClearInventory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673477);
			PlayerInventory.NativeMethodInfoPtr_RemoveProductFromInventory_Public_Void_EStealthLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673478);
			PlayerInventory.NativeMethodInfoPtr_RemoveRandomItemsFromInventory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673479);
			PlayerInventory.NativeMethodInfoPtr_SetEquippable_Public_Void_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673480);
			PlayerInventory.NativeMethodInfoPtr_Reequip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673481);
			PlayerInventory.NativeMethodInfoPtr_GetAllInventorySlots_Public_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673482);
			PlayerInventory.NativeMethodInfoPtr_UpdateInventoryVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673483);
			PlayerInventory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673484);
			PlayerInventory.NativeMethodInfoPtr__Start_b__56_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673485);
		}

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x060050E3 RID: 20707 RVA: 0x00181AE8 File Offset: 0x0017FCE8
		public unsafe int TOTAL_SLOT_COUNT
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_TOTAL_SLOT_COUNT_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x060050E4 RID: 20708 RVA: 0x00181B24 File Offset: 0x0017FD24
		// (set) Token: 0x060050E5 RID: 20709 RVA: 0x00181B64 File Offset: 0x0017FD64
		public unsafe CashSlot cashSlot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35358, RefRangeEnd = 35359, XrefRangeStart = 35358, XrefRangeEnd = 35359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_cashSlot_Public_get_CashSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CashSlot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_cashSlot_Private_set_Void_CashSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x060050E6 RID: 20710 RVA: 0x00181BA8 File Offset: 0x0017FDA8
		// (set) Token: 0x060050E7 RID: 20711 RVA: 0x00181BE8 File Offset: 0x0017FDE8
		public unsafe CashInstance cashInstance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_cashInstance_Public_get_CashInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_cashInstance_Protected_set_Void_CashInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x060050E8 RID: 20712 RVA: 0x00181C2C File Offset: 0x0017FE2C
		// (set) Token: 0x060050E9 RID: 20713 RVA: 0x00181C68 File Offset: 0x0017FE68
		public unsafe int EquippedSlotIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 55721, RefRangeEnd = 55722, XrefRangeStart = 55721, XrefRangeEnd = 55722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_EquippedSlotIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_EquippedSlotIndex_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x060050EA RID: 20714 RVA: 0x00181CA8 File Offset: 0x0017FEA8
		// (set) Token: 0x060050EB RID: 20715 RVA: 0x00181CE4 File Offset: 0x0017FEE4
		public unsafe bool HotbarEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_HotbarEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_HotbarEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x060050EC RID: 20716 RVA: 0x00181D24 File Offset: 0x0017FF24
		// (set) Token: 0x060050ED RID: 20717 RVA: 0x00181D60 File Offset: 0x0017FF60
		public unsafe bool EquippingEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_EquippingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_EquippingEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x060050EE RID: 20718 RVA: 0x00181DA0 File Offset: 0x0017FFA0
		// (set) Token: 0x060050EF RID: 20719 RVA: 0x00181DE0 File Offset: 0x0017FFE0
		public unsafe Equippable equippable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45803, RefRangeEnd = 45804, XrefRangeStart = 45803, XrefRangeEnd = 45804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_equippable_Public_get_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_equippable_Protected_set_Void_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x060050F0 RID: 20720 RVA: 0x00181E24 File Offset: 0x00180024
		public unsafe HotbarSlot equippedSlot
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 175479, RefRangeEnd = 175494, XrefRangeStart = 175478, XrefRangeEnd = 175479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_equippedSlot_Public_get_HotbarSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HotbarSlot>(intPtr3) : null;
			}
		}

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x060050F1 RID: 20721 RVA: 0x00181E64 File Offset: 0x00180064
		public unsafe bool isAnythingEquipped
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 175496, RefRangeEnd = 175504, XrefRangeStart = 175494, XrefRangeEnd = 175496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_isAnythingEquipped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x00181EA0 File Offset: 0x001800A0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 175506, RefRangeEnd = 175525, XrefRangeStart = 175504, XrefRangeEnd = 175506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HotbarSlot IndexAllSlots(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_IndexAllSlots_Public_HotbarSlot_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HotbarSlot>(intPtr3) : null;
		}

		// Token: 0x060050F3 RID: 20723 RVA: 0x00181EEC File Offset: 0x001800EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175525, XrefRangeEnd = 175529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerInventory.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F4 RID: 20724 RVA: 0x00181F28 File Offset: 0x00180128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175655, RefRangeEnd = 175656, XrefRangeStart = 175529, XrefRangeEnd = 175655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupInventoryUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetupInventoryUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F5 RID: 20725 RVA: 0x00181F5C File Offset: 0x0018015C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 175737, RefRangeEnd = 175740, XrefRangeStart = 175656, XrefRangeEnd = 175737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepositionUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_RepositionUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F6 RID: 20726 RVA: 0x00181F90 File Offset: 0x00180190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175740, XrefRangeEnd = 175805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerInventory.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F7 RID: 20727 RVA: 0x00181FCC File Offset: 0x001801CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175828, RefRangeEnd = 175829, XrefRangeStart = 175805, XrefRangeEnd = 175828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GiveStartupItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_GiveStartupItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F8 RID: 20728 RVA: 0x00182000 File Offset: 0x00180200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175829, XrefRangeEnd = 175876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerInventory.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F9 RID: 20729 RVA: 0x0018203C File Offset: 0x0018023C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175919, RefRangeEnd = 175920, XrefRangeStart = 175876, XrefRangeEnd = 175919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHotbarSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_UpdateHotbarSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050FA RID: 20730 RVA: 0x00182070 File Offset: 0x00180270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175920, XrefRangeEnd = 175921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Equip(HotbarSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_Equip_Public_Void_HotbarSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050FB RID: 20731 RVA: 0x001820B4 File Offset: 0x001802B4
		[CallerCount(81)]
		[CachedScanResults(RefRangeStart = 175929, RefRangeEnd = 176010, XrefRangeStart = 175921, XrefRangeEnd = 175929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInventoryEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetInventoryEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050FC RID: 20732 RVA: 0x001820F4 File Offset: 0x001802F4
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 176034, RefRangeEnd = 176081, XrefRangeStart = 176010, XrefRangeEnd = 176034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEquippingEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetEquippingEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050FD RID: 20733 RVA: 0x00182134 File Offset: 0x00180334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176081, XrefRangeEnd = 176083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClipboardAcquiredVarChange(bool newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_ClipboardAcquiredVarChange_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050FE RID: 20734 RVA: 0x00182174 File Offset: 0x00180374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetManagementClipboardEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetManagementClipboardEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050FF RID: 20735 RVA: 0x001821B4 File Offset: 0x001803B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 176103, RefRangeEnd = 176105, XrefRangeStart = 176083, XrefRangeEnd = 176103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetViewmodelVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetViewmodelVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005100 RID: 20736 RVA: 0x001821F4 File Offset: 0x001803F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 176117, RefRangeEnd = 176120, XrefRangeStart = 176105, XrefRangeEnd = 176117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanItemFitInInventory(ItemInstance item, int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_CanItemFitInInventory_Public_Boolean_ItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005101 RID: 20737 RVA: 0x00182250 File Offset: 0x00180450
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 176153, RefRangeEnd = 176169, XrefRangeStart = 176120, XrefRangeEnd = 176153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItemToInventory(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005102 RID: 20738 RVA: 0x00182294 File Offset: 0x00180494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176169, XrefRangeEnd = 176182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetAmountOfItem(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_GetAmountOfItem_Public_UInt32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005103 RID: 20739 RVA: 0x001822E4 File Offset: 0x001804E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 176211, RefRangeEnd = 176214, XrefRangeStart = 176182, XrefRangeEnd = 176211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAmountOfItem(string ID, uint amount = 1U)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_RemoveAmountOfItem_Public_Void_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005104 RID: 20740 RVA: 0x00182334 File Offset: 0x00180534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176221, RefRangeEnd = 176222, XrefRangeStart = 176214, XrefRangeEnd = 176221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearInventory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_ClearInventory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005105 RID: 20741 RVA: 0x00182368 File Offset: 0x00180568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176222, XrefRangeEnd = 176243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveProductFromInventory(EStealthLevel maxStealth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref maxStealth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_RemoveProductFromInventory_Public_Void_EStealthLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005106 RID: 20742 RVA: 0x001823A8 File Offset: 0x001805A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176243, XrefRangeEnd = 176255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveRandomItemsFromInventory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_RemoveRandomItemsFromInventory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005107 RID: 20743 RVA: 0x001823DC File Offset: 0x001805DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 176261, RefRangeEnd = 176265, XrefRangeStart = 176255, XrefRangeEnd = 176261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEquippable(Equippable eq)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eq);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetEquippable_Public_Void_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005108 RID: 20744 RVA: 0x00182420 File Offset: 0x00180620
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176266, RefRangeEnd = 176267, XrefRangeStart = 176265, XrefRangeEnd = 176266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_Reequip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005109 RID: 20745 RVA: 0x00182454 File Offset: 0x00180654
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 176285, RefRangeEnd = 176302, XrefRangeStart = 176267, XrefRangeEnd = 176285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemSlot> GetAllInventorySlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_GetAllInventorySlots_Public_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
		}

		// Token: 0x0600510A RID: 20746 RVA: 0x00182494 File Offset: 0x00180694
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 176393, RefRangeEnd = 176395, XrefRangeStart = 176302, XrefRangeEnd = 176393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInventoryVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_UpdateInventoryVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600510B RID: 20747 RVA: 0x001824C8 File Offset: 0x001806C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176395, XrefRangeEnd = 176426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerInventory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600510C RID: 20748 RVA: 0x00182504 File Offset: 0x00180704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176426, XrefRangeEnd = 176433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__56_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr__Start_b__56_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x00026766 File Offset: 0x00024966
		public PlayerInventory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x0600510E RID: 20750 RVA: 0x00182538 File Offset: 0x00180738
		// (set) Token: 0x0600510F RID: 20751 RVA: 0x0002676F File Offset: 0x0002496F
		public unsafe static float LABEL_DISPLAY_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerInventory.NativeFieldInfoPtr_LABEL_DISPLAY_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerInventory.NativeFieldInfoPtr_LABEL_DISPLAY_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x06005110 RID: 20752 RVA: 0x00182554 File Offset: 0x00180754
		// (set) Token: 0x06005111 RID: 20753 RVA: 0x0002677D File Offset: 0x0002497D
		public unsafe static float LABEL_FADE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerInventory.NativeFieldInfoPtr_LABEL_FADE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerInventory.NativeFieldInfoPtr_LABEL_FADE_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x06005112 RID: 20754 RVA: 0x00182570 File Offset: 0x00180770
		// (set) Token: 0x06005113 RID: 20755 RVA: 0x0002678B File Offset: 0x0002498B
		public unsafe static float DISCARD_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerInventory.NativeFieldInfoPtr_DISCARD_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerInventory.NativeFieldInfoPtr_DISCARD_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x06005114 RID: 20756 RVA: 0x0018258C File Offset: 0x0018078C
		// (set) Token: 0x06005115 RID: 20757 RVA: 0x00026799 File Offset: 0x00024999
		public unsafe static int INVENTORY_SLOT_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PlayerInventory.NativeFieldInfoPtr_INVENTORY_SLOT_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerInventory.NativeFieldInfoPtr_INVENTORY_SLOT_COUNT, (void*)(&value));
			}
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x06005116 RID: 20758 RVA: 0x001825A8 File Offset: 0x001807A8
		// (set) Token: 0x06005117 RID: 20759 RVA: 0x000267A7 File Offset: 0x000249A7
		public unsafe bool giveStartupItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_giveStartupItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_giveStartupItems)) = value;
			}
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x06005118 RID: 20760 RVA: 0x001825D0 File Offset: 0x001807D0
		// (set) Token: 0x06005119 RID: 20761 RVA: 0x000267C2 File Offset: 0x000249C2
		public unsafe List<PlayerInventory.ItemAmount> startupItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_startupItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerInventory.ItemAmount>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_startupItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x0600511A RID: 20762 RVA: 0x00182600 File Offset: 0x00180800
		// (set) Token: 0x0600511B RID: 20763 RVA: 0x000267E1 File Offset: 0x000249E1
		public unsafe Transform equipContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_equipContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_equipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x0600511C RID: 20764 RVA: 0x00182630 File Offset: 0x00180830
		// (set) Token: 0x0600511D RID: 20765 RVA: 0x00026800 File Offset: 0x00024A00
		public unsafe List<HotbarSlot> hotbarSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_hotbarSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HotbarSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_hotbarSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x0600511E RID: 20766 RVA: 0x00182660 File Offset: 0x00180860
		// (set) Token: 0x0600511F RID: 20767 RVA: 0x0002681F File Offset: 0x00024A1F
		public unsafe CashSlot _cashSlot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__cashSlot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__cashSlot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x06005120 RID: 20768 RVA: 0x00182690 File Offset: 0x00180890
		// (set) Token: 0x06005121 RID: 20769 RVA: 0x0002683E File Offset: 0x00024A3E
		public unsafe CashInstance _cashInstance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__cashInstance_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__cashInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x06005122 RID: 20770 RVA: 0x001826C0 File Offset: 0x001808C0
		// (set) Token: 0x06005123 RID: 20771 RVA: 0x0002685D File Offset: 0x00024A5D
		public unsafe ClipboardSlot clipboardSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_clipboardSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClipboardSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_clipboardSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x06005124 RID: 20772 RVA: 0x001826F0 File Offset: 0x001808F0
		// (set) Token: 0x06005125 RID: 20773 RVA: 0x0002687C File Offset: 0x00024A7C
		public unsafe List<ItemSlotUI> slotUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_slotUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_slotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x06005126 RID: 20774 RVA: 0x00182720 File Offset: 0x00180920
		// (set) Token: 0x06005127 RID: 20775 RVA: 0x0002689B File Offset: 0x00024A9B
		public unsafe ItemSlot discardSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_discardSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_discardSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x06005128 RID: 20776 RVA: 0x00182750 File Offset: 0x00180950
		// (set) Token: 0x06005129 RID: 20777 RVA: 0x000268BA File Offset: 0x00024ABA
		public unsafe List<PlayerInventory.ItemVariable> ItemVariables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_ItemVariables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerInventory.ItemVariable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_ItemVariables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x0600512A RID: 20778 RVA: 0x00182780 File Offset: 0x00180980
		// (set) Token: 0x0600512B RID: 20779 RVA: 0x000268D9 File Offset: 0x00024AD9
		public unsafe int _EquippedSlotIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__EquippedSlotIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__EquippedSlotIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x0600512C RID: 20780 RVA: 0x001827A8 File Offset: 0x001809A8
		// (set) Token: 0x0600512D RID: 20781 RVA: 0x000268F4 File Offset: 0x00024AF4
		public unsafe bool _HotbarEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__HotbarEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__HotbarEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x0600512E RID: 20782 RVA: 0x001827D0 File Offset: 0x001809D0
		// (set) Token: 0x0600512F RID: 20783 RVA: 0x0002690F File Offset: 0x00024B0F
		public unsafe bool _EquippingEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__EquippingEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__EquippingEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x06005130 RID: 20784 RVA: 0x001827F8 File Offset: 0x001809F8
		// (set) Token: 0x06005131 RID: 20785 RVA: 0x0002692A File Offset: 0x00024B2A
		public unsafe Equippable _equippable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__equippable_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__equippable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x06005132 RID: 20786 RVA: 0x00182828 File Offset: 0x00180A28
		// (set) Token: 0x06005133 RID: 20787 RVA: 0x00026949 File Offset: 0x00024B49
		public unsafe Action<bool> onInventoryStateChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onInventoryStateChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onInventoryStateChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x06005134 RID: 20788 RVA: 0x00182858 File Offset: 0x00180A58
		// (set) Token: 0x06005135 RID: 20789 RVA: 0x00026968 File Offset: 0x00024B68
		public unsafe int PriorEquippedSlotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_PriorEquippedSlotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_PriorEquippedSlotIndex)) = value;
			}
		}

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x06005136 RID: 20790 RVA: 0x00182880 File Offset: 0x00180A80
		// (set) Token: 0x06005137 RID: 20791 RVA: 0x00026983 File Offset: 0x00024B83
		public unsafe int PreviousEquippedSlotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_PreviousEquippedSlotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_PreviousEquippedSlotIndex)) = value;
			}
		}

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x06005138 RID: 20792 RVA: 0x001828A8 File Offset: 0x00180AA8
		// (set) Token: 0x06005139 RID: 20793 RVA: 0x0002699E File Offset: 0x00024B9E
		public unsafe UnityEvent onPreItemEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onPreItemEquipped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onPreItemEquipped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x0600513A RID: 20794 RVA: 0x001828D8 File Offset: 0x00180AD8
		// (set) Token: 0x0600513B RID: 20795 RVA: 0x000269BD File Offset: 0x00024BBD
		public unsafe UnityEvent onItemEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onItemEquipped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onItemEquipped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x0600513C RID: 20796 RVA: 0x00182908 File Offset: 0x00180B08
		// (set) Token: 0x0600513D RID: 20797 RVA: 0x000269DC File Offset: 0x00024BDC
		public unsafe bool ManagementSlotEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_ManagementSlotEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_ManagementSlotEnabled)) = value;
			}
		}

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x0600513E RID: 20798 RVA: 0x00182930 File Offset: 0x00180B30
		// (set) Token: 0x0600513F RID: 20799 RVA: 0x000269F7 File Offset: 0x00024BF7
		public unsafe float currentEquipTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_currentEquipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_currentEquipTime)) = value;
			}
		}

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x06005140 RID: 20800 RVA: 0x00182958 File Offset: 0x00180B58
		// (set) Token: 0x06005141 RID: 20801 RVA: 0x00026A12 File Offset: 0x00024C12
		public unsafe float currentDiscardTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_currentDiscardTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_currentDiscardTime)) = value;
			}
		}

		// Token: 0x040036E2 RID: 14050
		private static readonly IntPtr NativeFieldInfoPtr_LABEL_DISPLAY_TIME;

		// Token: 0x040036E3 RID: 14051
		private static readonly IntPtr NativeFieldInfoPtr_LABEL_FADE_TIME;

		// Token: 0x040036E4 RID: 14052
		private static readonly IntPtr NativeFieldInfoPtr_DISCARD_TIME;

		// Token: 0x040036E5 RID: 14053
		private static readonly IntPtr NativeFieldInfoPtr_INVENTORY_SLOT_COUNT;

		// Token: 0x040036E6 RID: 14054
		private static readonly IntPtr NativeFieldInfoPtr_giveStartupItems;

		// Token: 0x040036E7 RID: 14055
		private static readonly IntPtr NativeFieldInfoPtr_startupItems;

		// Token: 0x040036E8 RID: 14056
		private static readonly IntPtr NativeFieldInfoPtr_equipContainer;

		// Token: 0x040036E9 RID: 14057
		private static readonly IntPtr NativeFieldInfoPtr_hotbarSlots;

		// Token: 0x040036EA RID: 14058
		private static readonly IntPtr NativeFieldInfoPtr__cashSlot_k__BackingField;

		// Token: 0x040036EB RID: 14059
		private static readonly IntPtr NativeFieldInfoPtr__cashInstance_k__BackingField;

		// Token: 0x040036EC RID: 14060
		private static readonly IntPtr NativeFieldInfoPtr_clipboardSlot;

		// Token: 0x040036ED RID: 14061
		private static readonly IntPtr NativeFieldInfoPtr_slotUIs;

		// Token: 0x040036EE RID: 14062
		private static readonly IntPtr NativeFieldInfoPtr_discardSlot;

		// Token: 0x040036EF RID: 14063
		private static readonly IntPtr NativeFieldInfoPtr_ItemVariables;

		// Token: 0x040036F0 RID: 14064
		private static readonly IntPtr NativeFieldInfoPtr__EquippedSlotIndex_k__BackingField;

		// Token: 0x040036F1 RID: 14065
		private static readonly IntPtr NativeFieldInfoPtr__HotbarEnabled_k__BackingField;

		// Token: 0x040036F2 RID: 14066
		private static readonly IntPtr NativeFieldInfoPtr__EquippingEnabled_k__BackingField;

		// Token: 0x040036F3 RID: 14067
		private static readonly IntPtr NativeFieldInfoPtr__equippable_k__BackingField;

		// Token: 0x040036F4 RID: 14068
		private static readonly IntPtr NativeFieldInfoPtr_onInventoryStateChanged;

		// Token: 0x040036F5 RID: 14069
		private static readonly IntPtr NativeFieldInfoPtr_PriorEquippedSlotIndex;

		// Token: 0x040036F6 RID: 14070
		private static readonly IntPtr NativeFieldInfoPtr_PreviousEquippedSlotIndex;

		// Token: 0x040036F7 RID: 14071
		private static readonly IntPtr NativeFieldInfoPtr_onPreItemEquipped;

		// Token: 0x040036F8 RID: 14072
		private static readonly IntPtr NativeFieldInfoPtr_onItemEquipped;

		// Token: 0x040036F9 RID: 14073
		private static readonly IntPtr NativeFieldInfoPtr_ManagementSlotEnabled;

		// Token: 0x040036FA RID: 14074
		private static readonly IntPtr NativeFieldInfoPtr_currentEquipTime;

		// Token: 0x040036FB RID: 14075
		private static readonly IntPtr NativeFieldInfoPtr_currentDiscardTime;

		// Token: 0x040036FC RID: 14076
		private static readonly IntPtr NativeMethodInfoPtr_get_TOTAL_SLOT_COUNT_Public_get_Int32_0;

		// Token: 0x040036FD RID: 14077
		private static readonly IntPtr NativeMethodInfoPtr_get_cashSlot_Public_get_CashSlot_0;

		// Token: 0x040036FE RID: 14078
		private static readonly IntPtr NativeMethodInfoPtr_set_cashSlot_Private_set_Void_CashSlot_0;

		// Token: 0x040036FF RID: 14079
		private static readonly IntPtr NativeMethodInfoPtr_get_cashInstance_Public_get_CashInstance_0;

		// Token: 0x04003700 RID: 14080
		private static readonly IntPtr NativeMethodInfoPtr_set_cashInstance_Protected_set_Void_CashInstance_0;

		// Token: 0x04003701 RID: 14081
		private static readonly IntPtr NativeMethodInfoPtr_get_EquippedSlotIndex_Public_get_Int32_0;

		// Token: 0x04003702 RID: 14082
		private static readonly IntPtr NativeMethodInfoPtr_set_EquippedSlotIndex_Protected_set_Void_Int32_0;

		// Token: 0x04003703 RID: 14083
		private static readonly IntPtr NativeMethodInfoPtr_get_HotbarEnabled_Public_get_Boolean_0;

		// Token: 0x04003704 RID: 14084
		private static readonly IntPtr NativeMethodInfoPtr_set_HotbarEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04003705 RID: 14085
		private static readonly IntPtr NativeMethodInfoPtr_get_EquippingEnabled_Public_get_Boolean_0;

		// Token: 0x04003706 RID: 14086
		private static readonly IntPtr NativeMethodInfoPtr_set_EquippingEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04003707 RID: 14087
		private static readonly IntPtr NativeMethodInfoPtr_get_equippable_Public_get_Equippable_0;

		// Token: 0x04003708 RID: 14088
		private static readonly IntPtr NativeMethodInfoPtr_set_equippable_Protected_set_Void_Equippable_0;

		// Token: 0x04003709 RID: 14089
		private static readonly IntPtr NativeMethodInfoPtr_get_equippedSlot_Public_get_HotbarSlot_0;

		// Token: 0x0400370A RID: 14090
		private static readonly IntPtr NativeMethodInfoPtr_get_isAnythingEquipped_Public_get_Boolean_0;

		// Token: 0x0400370B RID: 14091
		private static readonly IntPtr NativeMethodInfoPtr_IndexAllSlots_Public_HotbarSlot_Int32_0;

		// Token: 0x0400370C RID: 14092
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400370D RID: 14093
		private static readonly IntPtr NativeMethodInfoPtr_SetupInventoryUI_Private_Void_0;

		// Token: 0x0400370E RID: 14094
		private static readonly IntPtr NativeMethodInfoPtr_RepositionUI_Private_Void_0;

		// Token: 0x0400370F RID: 14095
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003710 RID: 14096
		private static readonly IntPtr NativeMethodInfoPtr_GiveStartupItems_Private_Void_0;

		// Token: 0x04003711 RID: 14097
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04003712 RID: 14098
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHotbarSelection_Private_Void_0;

		// Token: 0x04003713 RID: 14099
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Void_HotbarSlot_0;

		// Token: 0x04003714 RID: 14100
		private static readonly IntPtr NativeMethodInfoPtr_SetInventoryEnabled_Public_Void_Boolean_0;

		// Token: 0x04003715 RID: 14101
		private static readonly IntPtr NativeMethodInfoPtr_SetEquippingEnabled_Public_Void_Boolean_0;

		// Token: 0x04003716 RID: 14102
		private static readonly IntPtr NativeMethodInfoPtr_ClipboardAcquiredVarChange_Private_Void_Boolean_0;

		// Token: 0x04003717 RID: 14103
		private static readonly IntPtr NativeMethodInfoPtr_SetManagementClipboardEnabled_Public_Void_Boolean_0;

		// Token: 0x04003718 RID: 14104
		private static readonly IntPtr NativeMethodInfoPtr_SetViewmodelVisible_Public_Void_Boolean_0;

		// Token: 0x04003719 RID: 14105
		private static readonly IntPtr NativeMethodInfoPtr_CanItemFitInInventory_Public_Boolean_ItemInstance_Int32_0;

		// Token: 0x0400371A RID: 14106
		private static readonly IntPtr NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0;

		// Token: 0x0400371B RID: 14107
		private static readonly IntPtr NativeMethodInfoPtr_GetAmountOfItem_Public_UInt32_String_0;

		// Token: 0x0400371C RID: 14108
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAmountOfItem_Public_Void_String_UInt32_0;

		// Token: 0x0400371D RID: 14109
		private static readonly IntPtr NativeMethodInfoPtr_ClearInventory_Public_Void_0;

		// Token: 0x0400371E RID: 14110
		private static readonly IntPtr NativeMethodInfoPtr_RemoveProductFromInventory_Public_Void_EStealthLevel_0;

		// Token: 0x0400371F RID: 14111
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRandomItemsFromInventory_Public_Void_0;

		// Token: 0x04003720 RID: 14112
		private static readonly IntPtr NativeMethodInfoPtr_SetEquippable_Public_Void_Equippable_0;

		// Token: 0x04003721 RID: 14113
		private static readonly IntPtr NativeMethodInfoPtr_Reequip_Public_Void_0;

		// Token: 0x04003722 RID: 14114
		private static readonly IntPtr NativeMethodInfoPtr_GetAllInventorySlots_Public_List_1_ItemSlot_0;

		// Token: 0x04003723 RID: 14115
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInventoryVariables_Private_Void_0;

		// Token: 0x04003724 RID: 14116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003725 RID: 14117
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__56_1_Private_Void_0;

		// Token: 0x020009A1 RID: 2465
		[Serializable]
		public class ItemVariable : Il2CppSystem.Object
		{
			// Token: 0x0600CB43 RID: 52035 RVA: 0x003118F0 File Offset: 0x0030FAF0
			// Note: this type is marked as 'beforefieldinit'.
			static ItemVariable()
			{
				Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "ItemVariable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr);
				PlayerInventory.ItemVariable.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr, "Definition");
				PlayerInventory.ItemVariable.NativeFieldInfoPtr_VariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr, "VariableName");
				PlayerInventory.ItemVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr, 100673486);
			}

			// Token: 0x0600CB44 RID: 52036 RVA: 0x00311958 File Offset: 0x0030FB58
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemVariable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.ItemVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB45 RID: 52037 RVA: 0x00062DAC File Offset: 0x00060FAC
			public ItemVariable(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F54 RID: 16212
			// (get) Token: 0x0600CB46 RID: 52038 RVA: 0x00311994 File Offset: 0x0030FB94
			// (set) Token: 0x0600CB47 RID: 52039 RVA: 0x00062DB5 File Offset: 0x00060FB5
			public unsafe ItemDefinition Definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemVariable.NativeFieldInfoPtr_Definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemVariable.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F55 RID: 16213
			// (get) Token: 0x0600CB48 RID: 52040 RVA: 0x003119C4 File Offset: 0x0030FBC4
			// (set) Token: 0x0600CB49 RID: 52041 RVA: 0x00062DD4 File Offset: 0x00060FD4
			public unsafe string VariableName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemVariable.NativeFieldInfoPtr_VariableName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemVariable.NativeFieldInfoPtr_VariableName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008972 RID: 35186
			private static readonly IntPtr NativeFieldInfoPtr_Definition;

			// Token: 0x04008973 RID: 35187
			private static readonly IntPtr NativeFieldInfoPtr_VariableName;

			// Token: 0x04008974 RID: 35188
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009A2 RID: 2466
		[Serializable]
		public class ItemAmount : Il2CppSystem.Object
		{
			// Token: 0x0600CB4A RID: 52042 RVA: 0x003119EC File Offset: 0x0030FBEC
			// Note: this type is marked as 'beforefieldinit'.
			static ItemAmount()
			{
				Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "ItemAmount");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr);
				PlayerInventory.ItemAmount.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr, "Definition");
				PlayerInventory.ItemAmount.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr, "Amount");
				PlayerInventory.ItemAmount.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr, 100673487);
			}

			// Token: 0x0600CB4B RID: 52043 RVA: 0x00311A54 File Offset: 0x0030FC54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175470, XrefRangeEnd = 175471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemAmount() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.ItemAmount.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB4C RID: 52044 RVA: 0x00062DF3 File Offset: 0x00060FF3
			public ItemAmount(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F56 RID: 16214
			// (get) Token: 0x0600CB4D RID: 52045 RVA: 0x00311A90 File Offset: 0x0030FC90
			// (set) Token: 0x0600CB4E RID: 52046 RVA: 0x00062DFC File Offset: 0x00060FFC
			public unsafe ItemDefinition Definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemAmount.NativeFieldInfoPtr_Definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemAmount.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F57 RID: 16215
			// (get) Token: 0x0600CB4F RID: 52047 RVA: 0x00311AC0 File Offset: 0x0030FCC0
			// (set) Token: 0x0600CB50 RID: 52048 RVA: 0x00062E1B File Offset: 0x0006101B
			public unsafe int Amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemAmount.NativeFieldInfoPtr_Amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemAmount.NativeFieldInfoPtr_Amount)) = value;
				}
			}

			// Token: 0x04008975 RID: 35189
			private static readonly IntPtr NativeFieldInfoPtr_Definition;

			// Token: 0x04008976 RID: 35190
			private static readonly IntPtr NativeFieldInfoPtr_Amount;

			// Token: 0x04008977 RID: 35191
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009A3 RID: 2467
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerInventory+<>c__DisplayClass56_0")]
		public sealed class __c__DisplayClass56_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CB51 RID: 52049 RVA: 0x00311AE8 File Offset: 0x0030FCE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_0()
			{
				Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<>c__DisplayClass56_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr);
				PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr, "index");
				PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr, "slot");
				PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr, "<>4__this");
				PlayerInventory.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr, 100673488);
				PlayerInventory.__c__DisplayClass56_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr, 100673489);
			}

			// Token: 0x0600CB52 RID: 52050 RVA: 0x00311B78 File Offset: 0x0030FD78
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB53 RID: 52051 RVA: 0x00311BB4 File Offset: 0x0030FDB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175471, XrefRangeEnd = 175478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.__c__DisplayClass56_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB54 RID: 52052 RVA: 0x00062E36 File Offset: 0x00061036
			public __c__DisplayClass56_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F58 RID: 16216
			// (get) Token: 0x0600CB55 RID: 52053 RVA: 0x00311BE8 File Offset: 0x0030FDE8
			// (set) Token: 0x0600CB56 RID: 52054 RVA: 0x00062E3F File Offset: 0x0006103F
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17003F59 RID: 16217
			// (get) Token: 0x0600CB57 RID: 52055 RVA: 0x00311C10 File Offset: 0x0030FE10
			// (set) Token: 0x0600CB58 RID: 52056 RVA: 0x00062E5A File Offset: 0x0006105A
			public unsafe HotbarSlot slot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr_slot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HotbarSlot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr_slot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F5A RID: 16218
			// (get) Token: 0x0600CB59 RID: 52057 RVA: 0x00311C40 File Offset: 0x0030FE40
			// (set) Token: 0x0600CB5A RID: 52058 RVA: 0x00062E79 File Offset: 0x00061079
			public unsafe PlayerInventory __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerInventory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008978 RID: 35192
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04008979 RID: 35193
			private static readonly IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x0400897A RID: 35194
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400897B RID: 35195
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400897C RID: 35196
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}
	}
}
