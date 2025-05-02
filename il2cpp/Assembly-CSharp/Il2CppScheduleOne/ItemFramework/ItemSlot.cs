using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005EB RID: 1515
	[Serializable]
	public class ItemSlot : Object
	{
		// Token: 0x06008448 RID: 33864 RVA: 0x00232040 File Offset: 0x00230240
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSlot()
		{
			Il2CppClassPointerStore<ItemSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr);
			ItemSlot.NativeFieldInfoPtr__ItemInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<ItemInstance>k__BackingField");
			ItemSlot.NativeFieldInfoPtr__SlotOwner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<SlotOwner>k__BackingField");
			ItemSlot.NativeFieldInfoPtr_onItemDataChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "onItemDataChanged");
			ItemSlot.NativeFieldInfoPtr_onItemInstanceChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "onItemInstanceChanged");
			ItemSlot.NativeFieldInfoPtr__ActiveLock_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<ActiveLock>k__BackingField");
			ItemSlot.NativeFieldInfoPtr_onLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "onLocked");
			ItemSlot.NativeFieldInfoPtr_onUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "onUnlocked");
			ItemSlot.NativeFieldInfoPtr__IsRemovalLocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<IsRemovalLocked>k__BackingField");
			ItemSlot.NativeFieldInfoPtr__IsAddLocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<IsAddLocked>k__BackingField");
			ItemSlot.NativeFieldInfoPtr__Filters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<Filters>k__BackingField");
			ItemSlot.NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679849);
			ItemSlot.NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679850);
			ItemSlot.NativeMethodInfoPtr_get_SlotOwner_Public_get_IItemSlotOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679851);
			ItemSlot.NativeMethodInfoPtr_set_SlotOwner_Protected_set_Void_IItemSlotOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679852);
			ItemSlot.NativeMethodInfoPtr_get_SlotIndex_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679853);
			ItemSlot.NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679854);
			ItemSlot.NativeMethodInfoPtr_get_IsAtCapacity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679855);
			ItemSlot.NativeMethodInfoPtr_get_IsLocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679856);
			ItemSlot.NativeMethodInfoPtr_get_ActiveLock_Public_get_ItemSlotLock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679857);
			ItemSlot.NativeMethodInfoPtr_set_ActiveLock_Protected_set_Void_ItemSlotLock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679858);
			ItemSlot.NativeMethodInfoPtr_get_IsRemovalLocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679859);
			ItemSlot.NativeMethodInfoPtr_set_IsRemovalLocked_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679860);
			ItemSlot.NativeMethodInfoPtr_get_IsAddLocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679861);
			ItemSlot.NativeMethodInfoPtr_set_IsAddLocked_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679862);
			ItemSlot.NativeMethodInfoPtr_get_Filters_Protected_get_List_1_ItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679863);
			ItemSlot.NativeMethodInfoPtr_set_Filters_Protected_set_Void_List_1_ItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679864);
			ItemSlot.NativeMethodInfoPtr_SetSlotOwner_Public_Void_IItemSlotOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679865);
			ItemSlot.NativeMethodInfoPtr_ReplicateStoredInstance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679866);
			ItemSlot.NativeMethodInfoPtr_SetStoredItem_Public_Virtual_New_Void_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679867);
			ItemSlot.NativeMethodInfoPtr_InsertItem_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679868);
			ItemSlot.NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679869);
			ItemSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679870);
			ItemSlot.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679871);
			ItemSlot.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679872);
			ItemSlot.NativeMethodInfoPtr_ItemDataChanged_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679873);
			ItemSlot.NativeMethodInfoPtr_ClearItemInstanceRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679874);
			ItemSlot.NativeMethodInfoPtr_AddFilter_Public_Void_ItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679875);
			ItemSlot.NativeMethodInfoPtr_ApplyLock_Public_Void_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679876);
			ItemSlot.NativeMethodInfoPtr_RemoveLock_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679877);
			ItemSlot.NativeMethodInfoPtr_SetIsRemovalLocked_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679878);
			ItemSlot.NativeMethodInfoPtr_SetIsAddLocked_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679879);
			ItemSlot.NativeMethodInfoPtr_DoesItemMatchFilters_Public_Virtual_New_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679880);
			ItemSlot.NativeMethodInfoPtr_GetCapacityForItem_Public_Virtual_New_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679881);
			ItemSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679882);
			ItemSlot.NativeMethodInfoPtr_TryInsertItemIntoSet_Public_Static_Boolean_List_1_ItemSlot_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679883);
			ItemSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679884);
		}

		// Token: 0x17002801 RID: 10241
		// (get) Token: 0x06008449 RID: 33865 RVA: 0x00232408 File Offset: 0x00230608
		// (set) Token: 0x0600844A RID: 33866 RVA: 0x00232448 File Offset: 0x00230648
		public unsafe ItemInstance ItemInstance
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17380, RefRangeEnd = 17390, XrefRangeStart = 17380, XrefRangeEnd = 17390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29995, RefRangeEnd = 29997, XrefRangeStart = 29995, XrefRangeEnd = 29997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002802 RID: 10242
		// (get) Token: 0x0600844B RID: 33867 RVA: 0x0023248C File Offset: 0x0023068C
		// (set) Token: 0x0600844C RID: 33868 RVA: 0x002324CC File Offset: 0x002306CC
		public unsafe IItemSlotOwner SlotOwner
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_SlotOwner_Public_get_IItemSlotOwner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IItemSlotOwner>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_SlotOwner_Protected_set_Void_IItemSlotOwner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002803 RID: 10243
		// (get) Token: 0x0600844D RID: 33869 RVA: 0x00232510 File Offset: 0x00230710
		public unsafe int SlotIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248743, XrefRangeEnd = 248750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_SlotIndex_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002804 RID: 10244
		// (get) Token: 0x0600844E RID: 33870 RVA: 0x0023254C File Offset: 0x0023074C
		public unsafe int Quantity
		{
			[CallerCount(87)]
			[CachedScanResults(RefRangeStart = 248750, RefRangeEnd = 248837, XrefRangeStart = 248750, XrefRangeEnd = 248750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002805 RID: 10245
		// (get) Token: 0x0600844F RID: 33871 RVA: 0x00232588 File Offset: 0x00230788
		public unsafe bool IsAtCapacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_IsAtCapacity_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002806 RID: 10246
		// (get) Token: 0x06008450 RID: 33872 RVA: 0x002325C4 File Offset: 0x002307C4
		public unsafe bool IsLocked
		{
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 155124, RefRangeEnd = 155157, XrefRangeStart = 155124, XrefRangeEnd = 155157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_IsLocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002807 RID: 10247
		// (get) Token: 0x06008451 RID: 33873 RVA: 0x00232600 File Offset: 0x00230800
		// (set) Token: 0x06008452 RID: 33874 RVA: 0x00232640 File Offset: 0x00230840
		public unsafe ItemSlotLock ActiveLock
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_ActiveLock_Public_get_ItemSlotLock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlotLock>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_ActiveLock_Protected_set_Void_ItemSlotLock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002808 RID: 10248
		// (get) Token: 0x06008453 RID: 33875 RVA: 0x00232684 File Offset: 0x00230884
		// (set) Token: 0x06008454 RID: 33876 RVA: 0x002326C0 File Offset: 0x002308C0
		public unsafe bool IsRemovalLocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_IsRemovalLocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 50985, RefRangeEnd = 50988, XrefRangeStart = 50985, XrefRangeEnd = 50988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_IsRemovalLocked_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002809 RID: 10249
		// (get) Token: 0x06008455 RID: 33877 RVA: 0x00232700 File Offset: 0x00230900
		// (set) Token: 0x06008456 RID: 33878 RVA: 0x0023273C File Offset: 0x0023093C
		public unsafe bool IsAddLocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_IsAddLocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 50972, RefRangeEnd = 50982, XrefRangeStart = 50972, XrefRangeEnd = 50982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_IsAddLocked_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700280A RID: 10250
		// (get) Token: 0x06008457 RID: 33879 RVA: 0x0023277C File Offset: 0x0023097C
		// (set) Token: 0x06008458 RID: 33880 RVA: 0x002327BC File Offset: 0x002309BC
		public unsafe List<ItemFilter> Filters
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16593, RefRangeEnd = 16594, XrefRangeStart = 16593, XrefRangeEnd = 16594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_Filters_Protected_get_List_1_ItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemFilter>>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38376, RefRangeEnd = 38379, XrefRangeStart = 38376, XrefRangeEnd = 38379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_Filters_Protected_set_Void_List_1_ItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008459 RID: 33881 RVA: 0x00232800 File Offset: 0x00230A00
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 248847, RefRangeEnd = 248872, XrefRangeStart = 248837, XrefRangeEnd = 248847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSlotOwner(IItemSlotOwner owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetSlotOwner_Public_Void_IItemSlotOwner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600845A RID: 33882 RVA: 0x00232844 File Offset: 0x00230A44
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 248881, RefRangeEnd = 248886, XrefRangeStart = 248872, XrefRangeEnd = 248881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateStoredInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_ReplicateStoredInstance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600845B RID: 33883 RVA: 0x00232878 File Offset: 0x00230A78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248903, RefRangeEnd = 248904, XrefRangeStart = 248886, XrefRangeEnd = 248903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStoredItem(ItemInstance instance, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_SetStoredItem_Public_Virtual_New_Void_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600845C RID: 33884 RVA: 0x002328D4 File Offset: 0x00230AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248904, XrefRangeEnd = 248912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InsertItem(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_InsertItem_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600845D RID: 33885 RVA: 0x00232924 File Offset: 0x00230B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248912, XrefRangeEnd = 248920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddItem(ItemInstance item, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600845E RID: 33886 RVA: 0x00232980 File Offset: 0x00230B80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248933, RefRangeEnd = 248934, XrefRangeStart = 248920, XrefRangeEnd = 248933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearStoredInstance(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600845F RID: 33887 RVA: 0x002329CC File Offset: 0x00230BCC
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 248951, RefRangeEnd = 248976, XrefRangeStart = 248934, XrefRangeEnd = 248951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuantity(int amount, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008460 RID: 33888 RVA: 0x00232A18 File Offset: 0x00230C18
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 248994, RefRangeEnd = 249035, XrefRangeStart = 248976, XrefRangeEnd = 248994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeQuantity(int change, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008461 RID: 33889 RVA: 0x00232A64 File Offset: 0x00230C64
		[CallerCount(0)]
		public unsafe virtual void ItemDataChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_ItemDataChanged_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008462 RID: 33890 RVA: 0x00232AA0 File Offset: 0x00230CA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 249035, RefRangeEnd = 249038, XrefRangeStart = 249035, XrefRangeEnd = 249035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearItemInstanceRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_ClearItemInstanceRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008463 RID: 33891 RVA: 0x00232ADC File Offset: 0x00230CDC
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 249044, RefRangeEnd = 249063, XrefRangeStart = 249038, XrefRangeEnd = 249044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFilter(ItemFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_AddFilter_Public_Void_ItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008464 RID: 33892 RVA: 0x00232B20 File Offset: 0x00230D20
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 249085, RefRangeEnd = 249098, XrefRangeStart = 249063, XrefRangeEnd = 249085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyLock(NetworkObject lockOwner, string lockReason, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_ApplyLock_Public_Void_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008465 RID: 33893 RVA: 0x00232B84 File Offset: 0x00230D84
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 249109, RefRangeEnd = 249122, XrefRangeStart = 249098, XrefRangeEnd = 249109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLock(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_RemoveLock_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008466 RID: 33894 RVA: 0x00232BC4 File Offset: 0x00230DC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 50985, RefRangeEnd = 50988, XrefRangeStart = 50985, XrefRangeEnd = 50988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsRemovalLocked(bool locked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref locked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetIsRemovalLocked_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008467 RID: 33895 RVA: 0x00232C04 File Offset: 0x00230E04
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 50972, RefRangeEnd = 50982, XrefRangeStart = 50972, XrefRangeEnd = 50982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsAddLocked(bool locked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref locked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetIsAddLocked_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008468 RID: 33896 RVA: 0x00232C44 File Offset: 0x00230E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249122, XrefRangeEnd = 249133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesItemMatchFilters(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_DoesItemMatchFilters_Public_Virtual_New_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008469 RID: 33897 RVA: 0x00232C9C File Offset: 0x00230E9C
		[CallerCount(0)]
		public unsafe virtual int GetCapacityForItem(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_GetCapacityForItem_Public_Virtual_New_Int32_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600846A RID: 33898 RVA: 0x00232CF4 File Offset: 0x00230EF4
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanSlotAcceptCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600846B RID: 33899 RVA: 0x00232D3C File Offset: 0x00230F3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249158, RefRangeEnd = 249159, XrefRangeStart = 249133, XrefRangeEnd = 249158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryInsertItemIntoSet(List<ItemSlot> ItemSlots, ItemInstance item)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ItemSlots);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_TryInsertItemIntoSet_Public_Static_Boolean_List_1_ItemSlot_ItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600846C RID: 33900 RVA: 0x00232D90 File Offset: 0x00230F90
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 249167, RefRangeEnd = 249187, XrefRangeStart = 249159, XrefRangeEnd = 249167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600846D RID: 33901 RVA: 0x0003EBE2 File Offset: 0x0003CDE2
		public ItemSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027F7 RID: 10231
		// (get) Token: 0x0600846E RID: 33902 RVA: 0x00232DCC File Offset: 0x00230FCC
		// (set) Token: 0x0600846F RID: 33903 RVA: 0x0003EBEB File Offset: 0x0003CDEB
		public unsafe ItemInstance _ItemInstance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__ItemInstance_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__ItemInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F8 RID: 10232
		// (get) Token: 0x06008470 RID: 33904 RVA: 0x00232DFC File Offset: 0x00230FFC
		// (set) Token: 0x06008471 RID: 33905 RVA: 0x0003EC0A File Offset: 0x0003CE0A
		public unsafe IItemSlotOwner _SlotOwner_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__SlotOwner_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IItemSlotOwner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__SlotOwner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F9 RID: 10233
		// (get) Token: 0x06008472 RID: 33906 RVA: 0x00232E2C File Offset: 0x0023102C
		// (set) Token: 0x06008473 RID: 33907 RVA: 0x0003EC29 File Offset: 0x0003CE29
		public unsafe Action onItemDataChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onItemDataChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onItemDataChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027FA RID: 10234
		// (get) Token: 0x06008474 RID: 33908 RVA: 0x00232E5C File Offset: 0x0023105C
		// (set) Token: 0x06008475 RID: 33909 RVA: 0x0003EC48 File Offset: 0x0003CE48
		public unsafe Action onItemInstanceChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onItemInstanceChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onItemInstanceChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027FB RID: 10235
		// (get) Token: 0x06008476 RID: 33910 RVA: 0x00232E8C File Offset: 0x0023108C
		// (set) Token: 0x06008477 RID: 33911 RVA: 0x0003EC67 File Offset: 0x0003CE67
		public unsafe ItemSlotLock _ActiveLock_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__ActiveLock_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotLock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__ActiveLock_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027FC RID: 10236
		// (get) Token: 0x06008478 RID: 33912 RVA: 0x00232EBC File Offset: 0x002310BC
		// (set) Token: 0x06008479 RID: 33913 RVA: 0x0003EC86 File Offset: 0x0003CE86
		public unsafe Action onLocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onLocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onLocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027FD RID: 10237
		// (get) Token: 0x0600847A RID: 33914 RVA: 0x00232EEC File Offset: 0x002310EC
		// (set) Token: 0x0600847B RID: 33915 RVA: 0x0003ECA5 File Offset: 0x0003CEA5
		public unsafe Action onUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onUnlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027FE RID: 10238
		// (get) Token: 0x0600847C RID: 33916 RVA: 0x00232F1C File Offset: 0x0023111C
		// (set) Token: 0x0600847D RID: 33917 RVA: 0x0003ECC4 File Offset: 0x0003CEC4
		public unsafe bool _IsRemovalLocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__IsRemovalLocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__IsRemovalLocked_k__BackingField)) = value;
			}
		}

		// Token: 0x170027FF RID: 10239
		// (get) Token: 0x0600847E RID: 33918 RVA: 0x00232F44 File Offset: 0x00231144
		// (set) Token: 0x0600847F RID: 33919 RVA: 0x0003ECDF File Offset: 0x0003CEDF
		public unsafe bool _IsAddLocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__IsAddLocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__IsAddLocked_k__BackingField)) = value;
			}
		}

		// Token: 0x17002800 RID: 10240
		// (get) Token: 0x06008480 RID: 33920 RVA: 0x00232F6C File Offset: 0x0023116C
		// (set) Token: 0x06008481 RID: 33921 RVA: 0x0003ECFA File Offset: 0x0003CEFA
		public unsafe List<ItemFilter> _Filters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__Filters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__Filters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005A13 RID: 23059
		private static readonly IntPtr NativeFieldInfoPtr__ItemInstance_k__BackingField;

		// Token: 0x04005A14 RID: 23060
		private static readonly IntPtr NativeFieldInfoPtr__SlotOwner_k__BackingField;

		// Token: 0x04005A15 RID: 23061
		private static readonly IntPtr NativeFieldInfoPtr_onItemDataChanged;

		// Token: 0x04005A16 RID: 23062
		private static readonly IntPtr NativeFieldInfoPtr_onItemInstanceChanged;

		// Token: 0x04005A17 RID: 23063
		private static readonly IntPtr NativeFieldInfoPtr__ActiveLock_k__BackingField;

		// Token: 0x04005A18 RID: 23064
		private static readonly IntPtr NativeFieldInfoPtr_onLocked;

		// Token: 0x04005A19 RID: 23065
		private static readonly IntPtr NativeFieldInfoPtr_onUnlocked;

		// Token: 0x04005A1A RID: 23066
		private static readonly IntPtr NativeFieldInfoPtr__IsRemovalLocked_k__BackingField;

		// Token: 0x04005A1B RID: 23067
		private static readonly IntPtr NativeFieldInfoPtr__IsAddLocked_k__BackingField;

		// Token: 0x04005A1C RID: 23068
		private static readonly IntPtr NativeFieldInfoPtr__Filters_k__BackingField;

		// Token: 0x04005A1D RID: 23069
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0;

		// Token: 0x04005A1E RID: 23070
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0;

		// Token: 0x04005A1F RID: 23071
		private static readonly IntPtr NativeMethodInfoPtr_get_SlotOwner_Public_get_IItemSlotOwner_0;

		// Token: 0x04005A20 RID: 23072
		private static readonly IntPtr NativeMethodInfoPtr_set_SlotOwner_Protected_set_Void_IItemSlotOwner_0;

		// Token: 0x04005A21 RID: 23073
		private static readonly IntPtr NativeMethodInfoPtr_get_SlotIndex_Private_get_Int32_0;

		// Token: 0x04005A22 RID: 23074
		private static readonly IntPtr NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0;

		// Token: 0x04005A23 RID: 23075
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAtCapacity_Public_get_Boolean_0;

		// Token: 0x04005A24 RID: 23076
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocked_Public_get_Boolean_0;

		// Token: 0x04005A25 RID: 23077
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveLock_Public_get_ItemSlotLock_0;

		// Token: 0x04005A26 RID: 23078
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveLock_Protected_set_Void_ItemSlotLock_0;

		// Token: 0x04005A27 RID: 23079
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRemovalLocked_Public_get_Boolean_0;

		// Token: 0x04005A28 RID: 23080
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRemovalLocked_Protected_set_Void_Boolean_0;

		// Token: 0x04005A29 RID: 23081
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAddLocked_Public_get_Boolean_0;

		// Token: 0x04005A2A RID: 23082
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAddLocked_Protected_set_Void_Boolean_0;

		// Token: 0x04005A2B RID: 23083
		private static readonly IntPtr NativeMethodInfoPtr_get_Filters_Protected_get_List_1_ItemFilter_0;

		// Token: 0x04005A2C RID: 23084
		private static readonly IntPtr NativeMethodInfoPtr_set_Filters_Protected_set_Void_List_1_ItemFilter_0;

		// Token: 0x04005A2D RID: 23085
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotOwner_Public_Void_IItemSlotOwner_0;

		// Token: 0x04005A2E RID: 23086
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateStoredInstance_Public_Void_0;

		// Token: 0x04005A2F RID: 23087
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredItem_Public_Virtual_New_Void_ItemInstance_Boolean_0;

		// Token: 0x04005A30 RID: 23088
		private static readonly IntPtr NativeMethodInfoPtr_InsertItem_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04005A31 RID: 23089
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_ItemInstance_Boolean_0;

		// Token: 0x04005A32 RID: 23090
		private static readonly IntPtr NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04005A33 RID: 23091
		private static readonly IntPtr NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0;

		// Token: 0x04005A34 RID: 23092
		private static readonly IntPtr NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_Boolean_0;

		// Token: 0x04005A35 RID: 23093
		private static readonly IntPtr NativeMethodInfoPtr_ItemDataChanged_Protected_Virtual_New_Void_0;

		// Token: 0x04005A36 RID: 23094
		private static readonly IntPtr NativeMethodInfoPtr_ClearItemInstanceRequested_Protected_Virtual_New_Void_0;

		// Token: 0x04005A37 RID: 23095
		private static readonly IntPtr NativeMethodInfoPtr_AddFilter_Public_Void_ItemFilter_0;

		// Token: 0x04005A38 RID: 23096
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLock_Public_Void_NetworkObject_String_Boolean_0;

		// Token: 0x04005A39 RID: 23097
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLock_Public_Void_Boolean_0;

		// Token: 0x04005A3A RID: 23098
		private static readonly IntPtr NativeMethodInfoPtr_SetIsRemovalLocked_Public_Void_Boolean_0;

		// Token: 0x04005A3B RID: 23099
		private static readonly IntPtr NativeMethodInfoPtr_SetIsAddLocked_Public_Void_Boolean_0;

		// Token: 0x04005A3C RID: 23100
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilters_Public_Virtual_New_Boolean_ItemInstance_0;

		// Token: 0x04005A3D RID: 23101
		private static readonly IntPtr NativeMethodInfoPtr_GetCapacityForItem_Public_Virtual_New_Int32_ItemInstance_0;

		// Token: 0x04005A3E RID: 23102
		private static readonly IntPtr NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_New_Boolean_0;

		// Token: 0x04005A3F RID: 23103
		private static readonly IntPtr NativeMethodInfoPtr_TryInsertItemIntoSet_Public_Static_Boolean_List_1_ItemSlot_ItemInstance_0;

		// Token: 0x04005A40 RID: 23104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
