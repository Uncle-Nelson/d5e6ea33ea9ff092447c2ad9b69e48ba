using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200057D RID: 1405
	public class StorageVisualizer : MonoBehaviour
	{
		// Token: 0x06007B99 RID: 31641 RVA: 0x002141D0 File Offset: 0x002123D0
		// Note: this type is marked as 'beforefieldinit'.
		static StorageVisualizer()
		{
			Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageVisualizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr);
			StorageVisualizer.NativeFieldInfoPtr_StorageGrids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "StorageGrids");
			StorageVisualizer.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "ItemContainer");
			StorageVisualizer.NativeFieldInfoPtr_FullRefreshOnItemRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "FullRefreshOnItemRemoved");
			StorageVisualizer.NativeFieldInfoPtr_itemSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "itemSlots");
			StorageVisualizer.NativeFieldInfoPtr_totalFootprintCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "totalFootprintCapacity");
			StorageVisualizer.NativeFieldInfoPtr_activeStoredItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "activeStoredItems");
			StorageVisualizer.NativeFieldInfoPtr_BlockRefreshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "BlockRefreshes");
			StorageVisualizer.NativeFieldInfoPtr_updateVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "updateVisuals");
			StorageVisualizer.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678792);
			StorageVisualizer.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678793);
			StorageVisualizer.NativeMethodInfoPtr_AddSlot_Public_Void_ItemSlot_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678794);
			StorageVisualizer.NativeMethodInfoPtr_GetVisualRepresentation_Public_Dictionary_2_StorableItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678795);
			StorageVisualizer.NativeMethodInfoPtr_RefreshVisuals_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678796);
			StorageVisualizer.NativeMethodInfoPtr_EnsureSufficientStoredItems_Private_List_1_StoredItem_StorableItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678797);
			StorageVisualizer.NativeMethodInfoPtr_DestroyExcessStoredItems_Private_Void_StorableItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678798);
			StorageVisualizer.NativeMethodInfoPtr_GetContentsDictionary_Public_Dictionary_2_StorableItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678799);
			StorageVisualizer.NativeMethodInfoPtr_QueueRefresh_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678800);
			StorageVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678801);
			StorageVisualizer.NativeMethodInfoPtr__AddSlot_b__10_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678802);
		}

		// Token: 0x06007B9A RID: 31642 RVA: 0x0021437C File Offset: 0x0021257C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236597, XrefRangeEnd = 236601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageVisualizer.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B9B RID: 31643 RVA: 0x002143B8 File Offset: 0x002125B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236601, XrefRangeEnd = 236608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageVisualizer.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B9C RID: 31644 RVA: 0x002143F4 File Offset: 0x002125F4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 236627, RefRangeEnd = 236644, XrefRangeStart = 236608, XrefRangeEnd = 236627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSlot(ItemSlot slot, bool update = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref update;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_AddSlot_Public_Void_ItemSlot_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B9D RID: 31645 RVA: 0x00214444 File Offset: 0x00212644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236644, XrefRangeEnd = 236646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<StorableItemInstance, int> GetVisualRepresentation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_GetVisualRepresentation_Public_Dictionary_2_StorableItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<StorableItemInstance, int>>(intPtr3) : null;
		}

		// Token: 0x06007B9E RID: 31646 RVA: 0x00214484 File Offset: 0x00212684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236646, XrefRangeEnd = 236796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageVisualizer.NativeMethodInfoPtr_RefreshVisuals_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B9F RID: 31647 RVA: 0x002144C0 File Offset: 0x002126C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236848, RefRangeEnd = 236849, XrefRangeStart = 236796, XrefRangeEnd = 236848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<StoredItem> EnsureSufficientStoredItems(StorableItemInstance item, int quantityRequirement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantityRequirement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_EnsureSufficientStoredItems_Private_List_1_StoredItem_StorableItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr3) : null;
		}

		// Token: 0x06007BA0 RID: 31648 RVA: 0x00214520 File Offset: 0x00212720
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236871, RefRangeEnd = 236872, XrefRangeStart = 236849, XrefRangeEnd = 236871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyExcessStoredItems(StorableItemInstance item, int quantityRequirement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantityRequirement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_DestroyExcessStoredItems_Private_Void_StorableItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BA1 RID: 31649 RVA: 0x00214570 File Offset: 0x00212770
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 236909, RefRangeEnd = 236911, XrefRangeStart = 236872, XrefRangeEnd = 236909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<StorableItemInstance, int> GetContentsDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_GetContentsDictionary_Public_Dictionary_2_StorableItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<StorableItemInstance, int>>(intPtr3) : null;
		}

		// Token: 0x06007BA2 RID: 31650 RVA: 0x002145B0 File Offset: 0x002127B0
		[CallerCount(0)]
		public unsafe void QueueRefresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_QueueRefresh_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BA3 RID: 31651 RVA: 0x002145E4 File Offset: 0x002127E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageVisualizer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BA4 RID: 31652 RVA: 0x00214620 File Offset: 0x00212820
		[CallerCount(0)]
		public unsafe void _AddSlot_b__10_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr__AddSlot_b__10_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BA5 RID: 31653 RVA: 0x0003AA80 File Offset: 0x00038C80
		public StorageVisualizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002552 RID: 9554
		// (get) Token: 0x06007BA6 RID: 31654 RVA: 0x00214654 File Offset: 0x00212854
		// (set) Token: 0x06007BA7 RID: 31655 RVA: 0x0003AA89 File Offset: 0x00038C89
		public unsafe Il2CppReferenceArray<StorageGrid> StorageGrids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_StorageGrids);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StorageGrid>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_StorageGrids), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002553 RID: 9555
		// (get) Token: 0x06007BA8 RID: 31656 RVA: 0x00214684 File Offset: 0x00212884
		// (set) Token: 0x06007BA9 RID: 31657 RVA: 0x0003AAA8 File Offset: 0x00038CA8
		public unsafe Transform ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002554 RID: 9556
		// (get) Token: 0x06007BAA RID: 31658 RVA: 0x002146B4 File Offset: 0x002128B4
		// (set) Token: 0x06007BAB RID: 31659 RVA: 0x0003AAC7 File Offset: 0x00038CC7
		public unsafe bool FullRefreshOnItemRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_FullRefreshOnItemRemoved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_FullRefreshOnItemRemoved)) = value;
			}
		}

		// Token: 0x17002555 RID: 9557
		// (get) Token: 0x06007BAC RID: 31660 RVA: 0x002146DC File Offset: 0x002128DC
		// (set) Token: 0x06007BAD RID: 31661 RVA: 0x0003AAE2 File Offset: 0x00038CE2
		public unsafe List<ItemSlot> itemSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_itemSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_itemSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002556 RID: 9558
		// (get) Token: 0x06007BAE RID: 31662 RVA: 0x0021470C File Offset: 0x0021290C
		// (set) Token: 0x06007BAF RID: 31663 RVA: 0x0003AB01 File Offset: 0x00038D01
		public unsafe int totalFootprintCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_totalFootprintCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_totalFootprintCapacity)) = value;
			}
		}

		// Token: 0x17002557 RID: 9559
		// (get) Token: 0x06007BB0 RID: 31664 RVA: 0x00214734 File Offset: 0x00212934
		// (set) Token: 0x06007BB1 RID: 31665 RVA: 0x0003AB1C File Offset: 0x00038D1C
		public unsafe Dictionary<StorableItemInstance, List<StoredItem>> activeStoredItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_activeStoredItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StorableItemInstance, List<StoredItem>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_activeStoredItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002558 RID: 9560
		// (get) Token: 0x06007BB2 RID: 31666 RVA: 0x00214764 File Offset: 0x00212964
		// (set) Token: 0x06007BB3 RID: 31667 RVA: 0x0003AB3B File Offset: 0x00038D3B
		public unsafe bool BlockRefreshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_BlockRefreshes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_BlockRefreshes)) = value;
			}
		}

		// Token: 0x17002559 RID: 9561
		// (get) Token: 0x06007BB4 RID: 31668 RVA: 0x0021478C File Offset: 0x0021298C
		// (set) Token: 0x06007BB5 RID: 31669 RVA: 0x0003AB56 File Offset: 0x00038D56
		public unsafe bool updateVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_updateVisuals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_updateVisuals)) = value;
			}
		}

		// Token: 0x0400542A RID: 21546
		private static readonly IntPtr NativeFieldInfoPtr_StorageGrids;

		// Token: 0x0400542B RID: 21547
		private static readonly IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x0400542C RID: 21548
		private static readonly IntPtr NativeFieldInfoPtr_FullRefreshOnItemRemoved;

		// Token: 0x0400542D RID: 21549
		private static readonly IntPtr NativeFieldInfoPtr_itemSlots;

		// Token: 0x0400542E RID: 21550
		private static readonly IntPtr NativeFieldInfoPtr_totalFootprintCapacity;

		// Token: 0x0400542F RID: 21551
		private static readonly IntPtr NativeFieldInfoPtr_activeStoredItems;

		// Token: 0x04005430 RID: 21552
		private static readonly IntPtr NativeFieldInfoPtr_BlockRefreshes;

		// Token: 0x04005431 RID: 21553
		private static readonly IntPtr NativeFieldInfoPtr_updateVisuals;

		// Token: 0x04005432 RID: 21554
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005433 RID: 21555
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04005434 RID: 21556
		private static readonly IntPtr NativeMethodInfoPtr_AddSlot_Public_Void_ItemSlot_Boolean_0;

		// Token: 0x04005435 RID: 21557
		private static readonly IntPtr NativeMethodInfoPtr_GetVisualRepresentation_Public_Dictionary_2_StorableItemInstance_Int32_0;

		// Token: 0x04005436 RID: 21558
		private static readonly IntPtr NativeMethodInfoPtr_RefreshVisuals_Public_Virtual_New_Void_0;

		// Token: 0x04005437 RID: 21559
		private static readonly IntPtr NativeMethodInfoPtr_EnsureSufficientStoredItems_Private_List_1_StoredItem_StorableItemInstance_Int32_0;

		// Token: 0x04005438 RID: 21560
		private static readonly IntPtr NativeMethodInfoPtr_DestroyExcessStoredItems_Private_Void_StorableItemInstance_Int32_0;

		// Token: 0x04005439 RID: 21561
		private static readonly IntPtr NativeMethodInfoPtr_GetContentsDictionary_Public_Dictionary_2_StorableItemInstance_Int32_0;

		// Token: 0x0400543A RID: 21562
		private static readonly IntPtr NativeMethodInfoPtr_QueueRefresh_Protected_Void_0;

		// Token: 0x0400543B RID: 21563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400543C RID: 21564
		private static readonly IntPtr NativeMethodInfoPtr__AddSlot_b__10_0_Private_Void_0;
	}
}
