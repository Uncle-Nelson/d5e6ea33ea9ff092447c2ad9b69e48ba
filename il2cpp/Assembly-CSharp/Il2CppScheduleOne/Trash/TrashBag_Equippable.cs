using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x0200051C RID: 1308
	public class TrashBag_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06007468 RID: 29800 RVA: 0x001FB73C File Offset: 0x001F993C
		// Note: this type is marked as 'beforefieldinit'.
		static TrashBag_Equippable()
		{
			Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashBag_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr);
			TrashBag_Equippable.NativeFieldInfoPtr_TRASH_CONTAINER_INTERACT_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "TRASH_CONTAINER_INTERACT_DISTANCE");
			TrashBag_Equippable.NativeFieldInfoPtr_BAG_TRASH_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "BAG_TRASH_TIME");
			TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "PICKUP_RANGE");
			TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_AREA_RADIUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "PICKUP_AREA_RADIUS");
			TrashBag_Equippable.NativeFieldInfoPtr__IsBaggingTrash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "<IsBaggingTrash>k__BackingField");
			TrashBag_Equippable.NativeFieldInfoPtr__IsPickingUpTrash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "<IsPickingUpTrash>k__BackingField");
			TrashBag_Equippable.NativeFieldInfoPtr_PickupLookMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "PickupLookMask");
			TrashBag_Equippable.NativeFieldInfoPtr_PickupAreaProjector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "PickupAreaProjector");
			TrashBag_Equippable.NativeFieldInfoPtr_RustleSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "RustleSound");
			TrashBag_Equippable.NativeFieldInfoPtr_BagSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "BagSound");
			TrashBag_Equippable.NativeFieldInfoPtr__bagTrashTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "_bagTrashTime");
			TrashBag_Equippable.NativeFieldInfoPtr__baggedContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "_baggedContainer");
			TrashBag_Equippable.NativeFieldInfoPtr__pickupTrashTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "_pickupTrashTime");
			TrashBag_Equippable.NativeMethodInfoPtr_get_IsHoveringTrash_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677928);
			TrashBag_Equippable.NativeMethodInfoPtr_get_IsBaggingTrash_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677929);
			TrashBag_Equippable.NativeMethodInfoPtr_set_IsBaggingTrash_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677930);
			TrashBag_Equippable.NativeMethodInfoPtr_get_IsPickingUpTrash_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677931);
			TrashBag_Equippable.NativeMethodInfoPtr_set_IsPickingUpTrash_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677932);
			TrashBag_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677933);
			TrashBag_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677934);
			TrashBag_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677935);
			TrashBag_Equippable.NativeMethodInfoPtr_GetHoveredTrashContainer_Private_TrashContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677936);
			TrashBag_Equippable.NativeMethodInfoPtr_RaycastLook_Private_Boolean_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677937);
			TrashBag_Equippable.NativeMethodInfoPtr_IsPickupLocationValid_Private_Boolean_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677938);
			TrashBag_Equippable.NativeMethodInfoPtr_GetTrashItemsAtPoint_Private_List_1_TrashItem_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677939);
			TrashBag_Equippable.NativeMethodInfoPtr_StartBagTrash_Private_Void_TrashContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677940);
			TrashBag_Equippable.NativeMethodInfoPtr_StopBagTrash_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677941);
			TrashBag_Equippable.NativeMethodInfoPtr_StartPickup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677942);
			TrashBag_Equippable.NativeMethodInfoPtr_StopPickup_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677943);
			TrashBag_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100677944);
		}

		// Token: 0x17002354 RID: 9044
		// (get) Token: 0x06007469 RID: 29801 RVA: 0x001FB9C4 File Offset: 0x001F9BC4
		public unsafe static bool IsHoveringTrash
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 227629, RefRangeEnd = 227630, XrefRangeStart = 227622, XrefRangeEnd = 227629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_get_IsHoveringTrash_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002355 RID: 9045
		// (get) Token: 0x0600746A RID: 29802 RVA: 0x001FB9F4 File Offset: 0x001F9BF4
		// (set) Token: 0x0600746B RID: 29803 RVA: 0x001FBA30 File Offset: 0x001F9C30
		public unsafe bool IsBaggingTrash
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_get_IsBaggingTrash_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_set_IsBaggingTrash_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002356 RID: 9046
		// (get) Token: 0x0600746C RID: 29804 RVA: 0x001FBA70 File Offset: 0x001F9C70
		// (set) Token: 0x0600746D RID: 29805 RVA: 0x001FBAAC File Offset: 0x001F9CAC
		public unsafe bool IsPickingUpTrash
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_get_IsPickingUpTrash_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_set_IsPickingUpTrash_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600746E RID: 29806 RVA: 0x001FBAEC File Offset: 0x001F9CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227630, XrefRangeEnd = 227658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashBag_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600746F RID: 29807 RVA: 0x001FBB3C File Offset: 0x001F9D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227658, XrefRangeEnd = 227670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashBag_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007470 RID: 29808 RVA: 0x001FBB78 File Offset: 0x001F9D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227670, XrefRangeEnd = 227765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashBag_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007471 RID: 29809 RVA: 0x001FBBB4 File Offset: 0x001F9DB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227782, RefRangeEnd = 227783, XrefRangeStart = 227765, XrefRangeEnd = 227782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainer GetHoveredTrashContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_GetHoveredTrashContainer_Private_TrashContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashContainer>(intPtr3) : null;
		}

		// Token: 0x06007472 RID: 29810 RVA: 0x001FBBF4 File Offset: 0x001F9DF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227788, RefRangeEnd = 227790, XrefRangeStart = 227783, XrefRangeEnd = 227788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RaycastLook(out RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_RaycastLook_Private_Boolean_byref_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007473 RID: 29811 RVA: 0x001FBC40 File Offset: 0x001F9E40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227794, RefRangeEnd = 227796, XrefRangeStart = 227790, XrefRangeEnd = 227794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPickupLocationValid(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_IsPickupLocationValid_Private_Boolean_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007474 RID: 29812 RVA: 0x001FBC8C File Offset: 0x001F9E8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227822, RefRangeEnd = 227825, XrefRangeStart = 227796, XrefRangeEnd = 227822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<TrashItem> GetTrashItemsAtPoint(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_GetTrashItemsAtPoint_Private_List_1_TrashItem_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TrashItem>>(intPtr3) : null;
		}

		// Token: 0x06007475 RID: 29813 RVA: 0x001FBCD8 File Offset: 0x001F9ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227825, XrefRangeEnd = 227827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartBagTrash(TrashContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_StartBagTrash_Private_Void_TrashContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007476 RID: 29814 RVA: 0x001FBD1C File Offset: 0x001F9F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227827, XrefRangeEnd = 227832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopBagTrash(bool complete)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref complete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_StopBagTrash_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007477 RID: 29815 RVA: 0x001FBD5C File Offset: 0x001F9F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227832, XrefRangeEnd = 227833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPickup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_StartPickup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007478 RID: 29816 RVA: 0x001FBD90 File Offset: 0x001F9F90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227879, RefRangeEnd = 227880, XrefRangeStart = 227833, XrefRangeEnd = 227879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopPickup(bool complete)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref complete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_StopPickup_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007479 RID: 29817 RVA: 0x001FBDD0 File Offset: 0x001F9FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashBag_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600747A RID: 29818 RVA: 0x000374B6 File Offset: 0x000356B6
		public TrashBag_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002347 RID: 9031
		// (get) Token: 0x0600747B RID: 29819 RVA: 0x001FBE0C File Offset: 0x001FA00C
		// (set) Token: 0x0600747C RID: 29820 RVA: 0x000374BF File Offset: 0x000356BF
		public unsafe static float TRASH_CONTAINER_INTERACT_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashBag_Equippable.NativeFieldInfoPtr_TRASH_CONTAINER_INTERACT_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashBag_Equippable.NativeFieldInfoPtr_TRASH_CONTAINER_INTERACT_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17002348 RID: 9032
		// (get) Token: 0x0600747D RID: 29821 RVA: 0x001FBE28 File Offset: 0x001FA028
		// (set) Token: 0x0600747E RID: 29822 RVA: 0x000374CD File Offset: 0x000356CD
		public unsafe static float BAG_TRASH_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashBag_Equippable.NativeFieldInfoPtr_BAG_TRASH_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashBag_Equippable.NativeFieldInfoPtr_BAG_TRASH_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002349 RID: 9033
		// (get) Token: 0x0600747F RID: 29823 RVA: 0x001FBE44 File Offset: 0x001FA044
		// (set) Token: 0x06007480 RID: 29824 RVA: 0x000374DB File Offset: 0x000356DB
		public unsafe static float PICKUP_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_RANGE, (void*)(&value));
			}
		}

		// Token: 0x1700234A RID: 9034
		// (get) Token: 0x06007481 RID: 29825 RVA: 0x001FBE60 File Offset: 0x001FA060
		// (set) Token: 0x06007482 RID: 29826 RVA: 0x000374E9 File Offset: 0x000356E9
		public unsafe static float PICKUP_AREA_RADIUS
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_AREA_RADIUS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_AREA_RADIUS, (void*)(&value));
			}
		}

		// Token: 0x1700234B RID: 9035
		// (get) Token: 0x06007483 RID: 29827 RVA: 0x001FBE7C File Offset: 0x001FA07C
		// (set) Token: 0x06007484 RID: 29828 RVA: 0x000374F7 File Offset: 0x000356F7
		public unsafe bool _IsBaggingTrash_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__IsBaggingTrash_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__IsBaggingTrash_k__BackingField)) = value;
			}
		}

		// Token: 0x1700234C RID: 9036
		// (get) Token: 0x06007485 RID: 29829 RVA: 0x001FBEA4 File Offset: 0x001FA0A4
		// (set) Token: 0x06007486 RID: 29830 RVA: 0x00037512 File Offset: 0x00035712
		public unsafe bool _IsPickingUpTrash_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__IsPickingUpTrash_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__IsPickingUpTrash_k__BackingField)) = value;
			}
		}

		// Token: 0x1700234D RID: 9037
		// (get) Token: 0x06007487 RID: 29831 RVA: 0x001FBECC File Offset: 0x001FA0CC
		// (set) Token: 0x06007488 RID: 29832 RVA: 0x0003752D File Offset: 0x0003572D
		public unsafe LayerMask PickupLookMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_PickupLookMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_PickupLookMask)) = value;
			}
		}

		// Token: 0x1700234E RID: 9038
		// (get) Token: 0x06007489 RID: 29833 RVA: 0x001FBEF4 File Offset: 0x001FA0F4
		// (set) Token: 0x0600748A RID: 29834 RVA: 0x00037548 File Offset: 0x00035748
		public unsafe DecalProjector PickupAreaProjector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_PickupAreaProjector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalProjector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_PickupAreaProjector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700234F RID: 9039
		// (get) Token: 0x0600748B RID: 29835 RVA: 0x001FBF24 File Offset: 0x001FA124
		// (set) Token: 0x0600748C RID: 29836 RVA: 0x00037567 File Offset: 0x00035767
		public unsafe AudioSourceController RustleSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_RustleSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_RustleSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002350 RID: 9040
		// (get) Token: 0x0600748D RID: 29837 RVA: 0x001FBF54 File Offset: 0x001FA154
		// (set) Token: 0x0600748E RID: 29838 RVA: 0x00037586 File Offset: 0x00035786
		public unsafe AudioSourceController BagSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_BagSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_BagSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002351 RID: 9041
		// (get) Token: 0x0600748F RID: 29839 RVA: 0x001FBF84 File Offset: 0x001FA184
		// (set) Token: 0x06007490 RID: 29840 RVA: 0x000375A5 File Offset: 0x000357A5
		public unsafe float _bagTrashTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__bagTrashTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__bagTrashTime)) = value;
			}
		}

		// Token: 0x17002352 RID: 9042
		// (get) Token: 0x06007491 RID: 29841 RVA: 0x001FBFAC File Offset: 0x001FA1AC
		// (set) Token: 0x06007492 RID: 29842 RVA: 0x000375C0 File Offset: 0x000357C0
		public unsafe TrashContainer _baggedContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__baggedContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__baggedContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002353 RID: 9043
		// (get) Token: 0x06007493 RID: 29843 RVA: 0x001FBFDC File Offset: 0x001FA1DC
		// (set) Token: 0x06007494 RID: 29844 RVA: 0x000375DF File Offset: 0x000357DF
		public unsafe float _pickupTrashTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__pickupTrashTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__pickupTrashTime)) = value;
			}
		}

		// Token: 0x04004F7A RID: 20346
		private static readonly IntPtr NativeFieldInfoPtr_TRASH_CONTAINER_INTERACT_DISTANCE;

		// Token: 0x04004F7B RID: 20347
		private static readonly IntPtr NativeFieldInfoPtr_BAG_TRASH_TIME;

		// Token: 0x04004F7C RID: 20348
		private static readonly IntPtr NativeFieldInfoPtr_PICKUP_RANGE;

		// Token: 0x04004F7D RID: 20349
		private static readonly IntPtr NativeFieldInfoPtr_PICKUP_AREA_RADIUS;

		// Token: 0x04004F7E RID: 20350
		private static readonly IntPtr NativeFieldInfoPtr__IsBaggingTrash_k__BackingField;

		// Token: 0x04004F7F RID: 20351
		private static readonly IntPtr NativeFieldInfoPtr__IsPickingUpTrash_k__BackingField;

		// Token: 0x04004F80 RID: 20352
		private static readonly IntPtr NativeFieldInfoPtr_PickupLookMask;

		// Token: 0x04004F81 RID: 20353
		private static readonly IntPtr NativeFieldInfoPtr_PickupAreaProjector;

		// Token: 0x04004F82 RID: 20354
		private static readonly IntPtr NativeFieldInfoPtr_RustleSound;

		// Token: 0x04004F83 RID: 20355
		private static readonly IntPtr NativeFieldInfoPtr_BagSound;

		// Token: 0x04004F84 RID: 20356
		private static readonly IntPtr NativeFieldInfoPtr__bagTrashTime;

		// Token: 0x04004F85 RID: 20357
		private static readonly IntPtr NativeFieldInfoPtr__baggedContainer;

		// Token: 0x04004F86 RID: 20358
		private static readonly IntPtr NativeFieldInfoPtr__pickupTrashTime;

		// Token: 0x04004F87 RID: 20359
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHoveringTrash_Public_Static_get_Boolean_0;

		// Token: 0x04004F88 RID: 20360
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBaggingTrash_Public_get_Boolean_0;

		// Token: 0x04004F89 RID: 20361
		private static readonly IntPtr NativeMethodInfoPtr_set_IsBaggingTrash_Private_set_Void_Boolean_0;

		// Token: 0x04004F8A RID: 20362
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPickingUpTrash_Public_get_Boolean_0;

		// Token: 0x04004F8B RID: 20363
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPickingUpTrash_Private_set_Void_Boolean_0;

		// Token: 0x04004F8C RID: 20364
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04004F8D RID: 20365
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04004F8E RID: 20366
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04004F8F RID: 20367
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredTrashContainer_Private_TrashContainer_0;

		// Token: 0x04004F90 RID: 20368
		private static readonly IntPtr NativeMethodInfoPtr_RaycastLook_Private_Boolean_byref_RaycastHit_0;

		// Token: 0x04004F91 RID: 20369
		private static readonly IntPtr NativeMethodInfoPtr_IsPickupLocationValid_Private_Boolean_RaycastHit_0;

		// Token: 0x04004F92 RID: 20370
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashItemsAtPoint_Private_List_1_TrashItem_Vector3_0;

		// Token: 0x04004F93 RID: 20371
		private static readonly IntPtr NativeMethodInfoPtr_StartBagTrash_Private_Void_TrashContainer_0;

		// Token: 0x04004F94 RID: 20372
		private static readonly IntPtr NativeMethodInfoPtr_StopBagTrash_Private_Void_Boolean_0;

		// Token: 0x04004F95 RID: 20373
		private static readonly IntPtr NativeMethodInfoPtr_StartPickup_Private_Void_0;

		// Token: 0x04004F96 RID: 20374
		private static readonly IntPtr NativeMethodInfoPtr_StopPickup_Private_Void_Boolean_0;

		// Token: 0x04004F97 RID: 20375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
