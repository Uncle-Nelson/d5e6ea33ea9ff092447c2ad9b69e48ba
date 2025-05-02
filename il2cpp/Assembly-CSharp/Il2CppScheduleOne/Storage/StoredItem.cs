using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200057F RID: 1407
	public class StoredItem : MonoBehaviour
	{
		// Token: 0x06007BBD RID: 31677 RVA: 0x0021486C File Offset: 0x00212A6C
		// Note: this type is marked as 'beforefieldinit'.
		static StoredItem()
		{
			Il2CppClassPointerStore<StoredItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StoredItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem>.NativeClassPtr);
			StoredItem.NativeFieldInfoPtr__item_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<item>k__BackingField");
			StoredItem.NativeFieldInfoPtr__Destroyed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<Destroyed>k__BackingField");
			StoredItem.NativeFieldInfoPtr_buildPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "buildPoint");
			StoredItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "CoordinateFootprintTilePairs");
			StoredItem.NativeFieldInfoPtr_footprintX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "footprintX");
			StoredItem.NativeFieldInfoPtr_footprintY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "footprintY");
			StoredItem.NativeFieldInfoPtr__parentStorageEntity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<parentStorageEntity>k__BackingField");
			StoredItem.NativeFieldInfoPtr__parentGrid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<parentGrid>k__BackingField");
			StoredItem.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "intObj");
			StoredItem.NativeFieldInfoPtr_coordinatePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "coordinatePairs");
			StoredItem.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "rotation");
			StoredItem.NativeFieldInfoPtr_xSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "xSize");
			StoredItem.NativeFieldInfoPtr_ySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "ySize");
			StoredItem.NativeFieldInfoPtr__canBePickedUp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<canBePickedUp>k__BackingField");
			StoredItem.NativeFieldInfoPtr__noPickupReason_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<noPickupReason>k__BackingField");
			StoredItem.NativeMethodInfoPtr_get_item_Public_get_StorableItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678803);
			StoredItem.NativeMethodInfoPtr_set_item_Protected_set_Void_StorableItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678804);
			StoredItem.NativeMethodInfoPtr_get_Destroyed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678805);
			StoredItem.NativeMethodInfoPtr_set_Destroyed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678806);
			StoredItem.NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678807);
			StoredItem.NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678808);
			StoredItem.NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678809);
			StoredItem.NativeMethodInfoPtr_get_parentStorageEntity_Public_get_IStorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678810);
			StoredItem.NativeMethodInfoPtr_set_parentStorageEntity_Protected_set_Void_IStorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678811);
			StoredItem.NativeMethodInfoPtr_get_parentGrid_Public_get_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678812);
			StoredItem.NativeMethodInfoPtr_set_parentGrid_Protected_set_Void_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678813);
			StoredItem.NativeMethodInfoPtr_get_CoordinatePairs_Public_get_List_1_CoordinatePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678814);
			StoredItem.NativeMethodInfoPtr_get_Rotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678815);
			StoredItem.NativeMethodInfoPtr_get_totalArea_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678816);
			StoredItem.NativeMethodInfoPtr_get_canBePickedUp_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678817);
			StoredItem.NativeMethodInfoPtr_set_canBePickedUp_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678818);
			StoredItem.NativeMethodInfoPtr_get_noPickupReason_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678819);
			StoredItem.NativeMethodInfoPtr_set_noPickupReason_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678820);
			StoredItem.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678821);
			StoredItem.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678822);
			StoredItem.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_New_Void_StorableItemInstance_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678823);
			StoredItem.NativeMethodInfoPtr_RefreshTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678824);
			StoredItem.NativeMethodInfoPtr_InitializeIntObj_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678825);
			StoredItem.NativeMethodInfoPtr_Destroy_Internal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678826);
			StoredItem.NativeMethodInfoPtr_DestroyStoredItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678827);
			StoredItem.NativeMethodInfoPtr_ClearFootprintOccupancy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678828);
			StoredItem.NativeMethodInfoPtr_SetCanBePickedUp_Public_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678829);
			StoredItem.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678830);
			StoredItem.NativeMethodInfoPtr_RemoveReservedItems_Public_Static_List_1_StoredItem_List_1_StoredItem_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678831);
			StoredItem.NativeMethodInfoPtr_CreateGhostModel_Public_Virtual_New_GameObject_ItemInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678832);
			StoredItem.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678833);
			StoredItem.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678834);
			StoredItem.NativeMethodInfoPtr_GetTile_Public_FootprintTile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678835);
			StoredItem.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678836);
			StoredItem.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678837);
			StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678838);
		}

		// Token: 0x1700256B RID: 9579
		// (get) Token: 0x06007BBE RID: 31678 RVA: 0x00214C98 File Offset: 0x00212E98
		// (set) Token: 0x06007BBF RID: 31679 RVA: 0x00214CD8 File Offset: 0x00212ED8
		public unsafe StorableItemInstance item
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_item_Public_get_StorableItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_item_Protected_set_Void_StorableItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700256C RID: 9580
		// (get) Token: 0x06007BC0 RID: 31680 RVA: 0x00214D1C File Offset: 0x00212F1C
		// (set) Token: 0x06007BC1 RID: 31681 RVA: 0x00214D58 File Offset: 0x00212F58
		public unsafe bool Destroyed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_Destroyed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_Destroyed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700256D RID: 9581
		// (get) Token: 0x06007BC2 RID: 31682 RVA: 0x00214D98 File Offset: 0x00212F98
		public unsafe FootprintTile OriginFootprint
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 236921, RefRangeEnd = 236924, XrefRangeStart = 236918, XrefRangeEnd = 236921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr3) : null;
			}
		}

		// Token: 0x1700256E RID: 9582
		// (get) Token: 0x06007BC3 RID: 31683 RVA: 0x00214DD8 File Offset: 0x00212FD8
		public unsafe int FootprintX
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 236945, RefRangeEnd = 236949, XrefRangeStart = 236924, XrefRangeEnd = 236945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700256F RID: 9583
		// (get) Token: 0x06007BC4 RID: 31684 RVA: 0x00214E14 File Offset: 0x00213014
		public unsafe int FootprintY
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 236970, RefRangeEnd = 236974, XrefRangeStart = 236949, XrefRangeEnd = 236970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002570 RID: 9584
		// (get) Token: 0x06007BC5 RID: 31685 RVA: 0x00214E50 File Offset: 0x00213050
		// (set) Token: 0x06007BC6 RID: 31686 RVA: 0x00214E90 File Offset: 0x00213090
		public unsafe IStorageEntity parentStorageEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_parentStorageEntity_Public_get_IStorageEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IStorageEntity>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_parentStorageEntity_Protected_set_Void_IStorageEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002571 RID: 9585
		// (get) Token: 0x06007BC7 RID: 31687 RVA: 0x00214ED4 File Offset: 0x002130D4
		// (set) Token: 0x06007BC8 RID: 31688 RVA: 0x00214F14 File Offset: 0x00213114
		public unsafe StorageGrid parentGrid
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16593, RefRangeEnd = 16594, XrefRangeStart = 16593, XrefRangeEnd = 16594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_parentGrid_Public_get_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorageGrid>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38376, RefRangeEnd = 38379, XrefRangeStart = 38376, XrefRangeEnd = 38379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_parentGrid_Protected_set_Void_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002572 RID: 9586
		// (get) Token: 0x06007BC9 RID: 31689 RVA: 0x00214F58 File Offset: 0x00213158
		public unsafe List<CoordinatePair> CoordinatePairs
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 47274, RefRangeEnd = 47314, XrefRangeStart = 47274, XrefRangeEnd = 47314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_CoordinatePairs_Public_get_List_1_CoordinatePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CoordinatePair>>(intPtr3) : null;
			}
		}

		// Token: 0x17002573 RID: 9587
		// (get) Token: 0x06007BCA RID: 31690 RVA: 0x00214F98 File Offset: 0x00213198
		public unsafe float Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_Rotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002574 RID: 9588
		// (get) Token: 0x06007BCB RID: 31691 RVA: 0x00214FD4 File Offset: 0x002131D4
		public unsafe int totalArea
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236974, XrefRangeEnd = 236975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_totalArea_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002575 RID: 9589
		// (get) Token: 0x06007BCC RID: 31692 RVA: 0x00215010 File Offset: 0x00213210
		// (set) Token: 0x06007BCD RID: 31693 RVA: 0x0021504C File Offset: 0x0021324C
		public unsafe bool canBePickedUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_canBePickedUp_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_canBePickedUp_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002576 RID: 9590
		// (get) Token: 0x06007BCE RID: 31694 RVA: 0x0021508C File Offset: 0x0021328C
		// (set) Token: 0x06007BCF RID: 31695 RVA: 0x002150C4 File Offset: 0x002132C4
		public unsafe string noPickupReason
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45803, RefRangeEnd = 45804, XrefRangeStart = 45803, XrefRangeEnd = 45804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_noPickupReason_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_noPickupReason_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007BD0 RID: 31696 RVA: 0x00215108 File Offset: 0x00213308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236975, XrefRangeEnd = 236983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BD1 RID: 31697 RVA: 0x00215144 File Offset: 0x00213344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236983, XrefRangeEnd = 237004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BD2 RID: 31698 RVA: 0x00215180 File Offset: 0x00213380
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 237061, RefRangeEnd = 237068, XrefRangeStart = 237004, XrefRangeEnd = 237061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_New_Void_StorableItemInstance_StorageGrid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BD3 RID: 31699 RVA: 0x002151FC File Offset: 0x002133FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237101, RefRangeEnd = 237102, XrefRangeStart = 237068, XrefRangeEnd = 237101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_RefreshTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BD4 RID: 31700 RVA: 0x00215230 File Offset: 0x00213430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237102, XrefRangeEnd = 237125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeIntObj()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_InitializeIntObj_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BD5 RID: 31701 RVA: 0x0021526C File Offset: 0x0021346C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237125, XrefRangeEnd = 237146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_Destroy_Internal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BD6 RID: 31702 RVA: 0x002152A8 File Offset: 0x002134A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 237159, RefRangeEnd = 237162, XrefRangeStart = 237146, XrefRangeEnd = 237159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyStoredItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_DestroyStoredItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BD7 RID: 31703 RVA: 0x002152DC File Offset: 0x002134DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 237179, RefRangeEnd = 237181, XrefRangeStart = 237162, XrefRangeEnd = 237179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFootprintOccupancy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_ClearFootprintOccupancy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BD8 RID: 31704 RVA: 0x00215310 File Offset: 0x00213510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237181, XrefRangeEnd = 237182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanBePickedUp(bool _canBePickedUp, string _noPickupReason = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _canBePickedUp;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_noPickupReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_SetCanBePickedUp_Public_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BD9 RID: 31705 RVA: 0x00215360 File Offset: 0x00213560
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 237193, RefRangeEnd = 237195, XrefRangeStart = 237182, XrefRangeEnd = 237193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLayerRecursively(GameObject go, int layerNumber)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BDA RID: 31706 RVA: 0x002153A4 File Offset: 0x002135A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237195, XrefRangeEnd = 237213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<StoredItem> RemoveReservedItems(List<StoredItem> itemList, Employee allowedReservant)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemList);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allowedReservant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_RemoveReservedItems_Public_Static_List_1_StoredItem_List_1_StoredItem_Employee_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr3) : null;
		}

		// Token: 0x06007BDB RID: 31707 RVA: 0x002153FC File Offset: 0x002135FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237220, RefRangeEnd = 237221, XrefRangeStart = 237213, XrefRangeEnd = 237220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject CreateGhostModel(ItemInstance _item, Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_CreateGhostModel_Public_Virtual_New_GameObject_ItemInstance_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06007BDC RID: 31708 RVA: 0x0021546C File Offset: 0x0021366C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 237227, RefRangeEnd = 237230, XrefRangeStart = 237221, XrefRangeEnd = 237227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFootprintTileVisiblity(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BDD RID: 31709 RVA: 0x002154AC File Offset: 0x002136AC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 237235, RefRangeEnd = 237241, XrefRangeStart = 237230, XrefRangeEnd = 237235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateFootprintTileIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BDE RID: 31710 RVA: 0x002154E0 File Offset: 0x002136E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237241, XrefRangeEnd = 237248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintTile GetTile(Coordinate coord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_GetTile_Public_FootprintTile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr3) : null;
		}

		// Token: 0x06007BDF RID: 31711 RVA: 0x00215530 File Offset: 0x00213730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237248, XrefRangeEnd = 237257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BE0 RID: 31712 RVA: 0x0021556C File Offset: 0x0021376C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237257, XrefRangeEnd = 237263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BE1 RID: 31713 RVA: 0x002155A8 File Offset: 0x002137A8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 237281, RefRangeEnd = 237289, XrefRangeStart = 237263, XrefRangeEnd = 237281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BE2 RID: 31714 RVA: 0x0003ABCA File Offset: 0x00038DCA
		public StoredItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700255C RID: 9564
		// (get) Token: 0x06007BE3 RID: 31715 RVA: 0x002155E4 File Offset: 0x002137E4
		// (set) Token: 0x06007BE4 RID: 31716 RVA: 0x0003ABD3 File Offset: 0x00038DD3
		public unsafe StorableItemInstance _item_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__item_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__item_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700255D RID: 9565
		// (get) Token: 0x06007BE5 RID: 31717 RVA: 0x00215614 File Offset: 0x00213814
		// (set) Token: 0x06007BE6 RID: 31718 RVA: 0x0003ABF2 File Offset: 0x00038DF2
		public unsafe bool _Destroyed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__Destroyed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__Destroyed_k__BackingField)) = value;
			}
		}

		// Token: 0x1700255E RID: 9566
		// (get) Token: 0x06007BE7 RID: 31719 RVA: 0x0021563C File Offset: 0x0021383C
		// (set) Token: 0x06007BE8 RID: 31720 RVA: 0x0003AC0D File Offset: 0x00038E0D
		public unsafe Transform buildPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_buildPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_buildPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700255F RID: 9567
		// (get) Token: 0x06007BE9 RID: 31721 RVA: 0x0021566C File Offset: 0x0021386C
		// (set) Token: 0x06007BEA RID: 31722 RVA: 0x0003AC2C File Offset: 0x00038E2C
		public unsafe List<CoordinateStorageFootprintTilePair> CoordinateFootprintTilePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateStorageFootprintTilePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002560 RID: 9568
		// (get) Token: 0x06007BEB RID: 31723 RVA: 0x0021569C File Offset: 0x0021389C
		// (set) Token: 0x06007BEC RID: 31724 RVA: 0x0003AC4B File Offset: 0x00038E4B
		public unsafe int footprintX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_footprintX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_footprintX)) = value;
			}
		}

		// Token: 0x17002561 RID: 9569
		// (get) Token: 0x06007BED RID: 31725 RVA: 0x002156C4 File Offset: 0x002138C4
		// (set) Token: 0x06007BEE RID: 31726 RVA: 0x0003AC66 File Offset: 0x00038E66
		public unsafe int footprintY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_footprintY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_footprintY)) = value;
			}
		}

		// Token: 0x17002562 RID: 9570
		// (get) Token: 0x06007BEF RID: 31727 RVA: 0x002156EC File Offset: 0x002138EC
		// (set) Token: 0x06007BF0 RID: 31728 RVA: 0x0003AC81 File Offset: 0x00038E81
		public unsafe IStorageEntity _parentStorageEntity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__parentStorageEntity_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__parentStorageEntity_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002563 RID: 9571
		// (get) Token: 0x06007BF1 RID: 31729 RVA: 0x0021571C File Offset: 0x0021391C
		// (set) Token: 0x06007BF2 RID: 31730 RVA: 0x0003ACA0 File Offset: 0x00038EA0
		public unsafe StorageGrid _parentGrid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__parentGrid_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageGrid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__parentGrid_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002564 RID: 9572
		// (get) Token: 0x06007BF3 RID: 31731 RVA: 0x0021574C File Offset: 0x0021394C
		// (set) Token: 0x06007BF4 RID: 31732 RVA: 0x0003ACBF File Offset: 0x00038EBF
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002565 RID: 9573
		// (get) Token: 0x06007BF5 RID: 31733 RVA: 0x0021577C File Offset: 0x0021397C
		// (set) Token: 0x06007BF6 RID: 31734 RVA: 0x0003ACDE File Offset: 0x00038EDE
		public unsafe List<CoordinatePair> coordinatePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_coordinatePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinatePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_coordinatePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002566 RID: 9574
		// (get) Token: 0x06007BF7 RID: 31735 RVA: 0x002157AC File Offset: 0x002139AC
		// (set) Token: 0x06007BF8 RID: 31736 RVA: 0x0003ACFD File Offset: 0x00038EFD
		public unsafe float rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x17002567 RID: 9575
		// (get) Token: 0x06007BF9 RID: 31737 RVA: 0x002157D4 File Offset: 0x002139D4
		// (set) Token: 0x06007BFA RID: 31738 RVA: 0x0003AD18 File Offset: 0x00038F18
		public unsafe int xSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_xSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_xSize)) = value;
			}
		}

		// Token: 0x17002568 RID: 9576
		// (get) Token: 0x06007BFB RID: 31739 RVA: 0x002157FC File Offset: 0x002139FC
		// (set) Token: 0x06007BFC RID: 31740 RVA: 0x0003AD33 File Offset: 0x00038F33
		public unsafe int ySize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_ySize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_ySize)) = value;
			}
		}

		// Token: 0x17002569 RID: 9577
		// (get) Token: 0x06007BFD RID: 31741 RVA: 0x00215824 File Offset: 0x00213A24
		// (set) Token: 0x06007BFE RID: 31742 RVA: 0x0003AD4E File Offset: 0x00038F4E
		public unsafe bool _canBePickedUp_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__canBePickedUp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__canBePickedUp_k__BackingField)) = value;
			}
		}

		// Token: 0x1700256A RID: 9578
		// (get) Token: 0x06007BFF RID: 31743 RVA: 0x0021584C File Offset: 0x00213A4C
		// (set) Token: 0x06007C00 RID: 31744 RVA: 0x0003AD69 File Offset: 0x00038F69
		public unsafe string _noPickupReason_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__noPickupReason_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__noPickupReason_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400543F RID: 21567
		private static readonly IntPtr NativeFieldInfoPtr__item_k__BackingField;

		// Token: 0x04005440 RID: 21568
		private static readonly IntPtr NativeFieldInfoPtr__Destroyed_k__BackingField;

		// Token: 0x04005441 RID: 21569
		private static readonly IntPtr NativeFieldInfoPtr_buildPoint;

		// Token: 0x04005442 RID: 21570
		private static readonly IntPtr NativeFieldInfoPtr_CoordinateFootprintTilePairs;

		// Token: 0x04005443 RID: 21571
		private static readonly IntPtr NativeFieldInfoPtr_footprintX;

		// Token: 0x04005444 RID: 21572
		private static readonly IntPtr NativeFieldInfoPtr_footprintY;

		// Token: 0x04005445 RID: 21573
		private static readonly IntPtr NativeFieldInfoPtr__parentStorageEntity_k__BackingField;

		// Token: 0x04005446 RID: 21574
		private static readonly IntPtr NativeFieldInfoPtr__parentGrid_k__BackingField;

		// Token: 0x04005447 RID: 21575
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x04005448 RID: 21576
		private static readonly IntPtr NativeFieldInfoPtr_coordinatePairs;

		// Token: 0x04005449 RID: 21577
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x0400544A RID: 21578
		private static readonly IntPtr NativeFieldInfoPtr_xSize;

		// Token: 0x0400544B RID: 21579
		private static readonly IntPtr NativeFieldInfoPtr_ySize;

		// Token: 0x0400544C RID: 21580
		private static readonly IntPtr NativeFieldInfoPtr__canBePickedUp_k__BackingField;

		// Token: 0x0400544D RID: 21581
		private static readonly IntPtr NativeFieldInfoPtr__noPickupReason_k__BackingField;

		// Token: 0x0400544E RID: 21582
		private static readonly IntPtr NativeMethodInfoPtr_get_item_Public_get_StorableItemInstance_0;

		// Token: 0x0400544F RID: 21583
		private static readonly IntPtr NativeMethodInfoPtr_set_item_Protected_set_Void_StorableItemInstance_0;

		// Token: 0x04005450 RID: 21584
		private static readonly IntPtr NativeMethodInfoPtr_get_Destroyed_Public_get_Boolean_0;

		// Token: 0x04005451 RID: 21585
		private static readonly IntPtr NativeMethodInfoPtr_set_Destroyed_Private_set_Void_Boolean_0;

		// Token: 0x04005452 RID: 21586
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0;

		// Token: 0x04005453 RID: 21587
		private static readonly IntPtr NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0;

		// Token: 0x04005454 RID: 21588
		private static readonly IntPtr NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0;

		// Token: 0x04005455 RID: 21589
		private static readonly IntPtr NativeMethodInfoPtr_get_parentStorageEntity_Public_get_IStorageEntity_0;

		// Token: 0x04005456 RID: 21590
		private static readonly IntPtr NativeMethodInfoPtr_set_parentStorageEntity_Protected_set_Void_IStorageEntity_0;

		// Token: 0x04005457 RID: 21591
		private static readonly IntPtr NativeMethodInfoPtr_get_parentGrid_Public_get_StorageGrid_0;

		// Token: 0x04005458 RID: 21592
		private static readonly IntPtr NativeMethodInfoPtr_set_parentGrid_Protected_set_Void_StorageGrid_0;

		// Token: 0x04005459 RID: 21593
		private static readonly IntPtr NativeMethodInfoPtr_get_CoordinatePairs_Public_get_List_1_CoordinatePair_0;

		// Token: 0x0400545A RID: 21594
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Single_0;

		// Token: 0x0400545B RID: 21595
		private static readonly IntPtr NativeMethodInfoPtr_get_totalArea_Public_get_Int32_0;

		// Token: 0x0400545C RID: 21596
		private static readonly IntPtr NativeMethodInfoPtr_get_canBePickedUp_Public_get_Boolean_0;

		// Token: 0x0400545D RID: 21597
		private static readonly IntPtr NativeMethodInfoPtr_set_canBePickedUp_Protected_set_Void_Boolean_0;

		// Token: 0x0400545E RID: 21598
		private static readonly IntPtr NativeMethodInfoPtr_get_noPickupReason_Public_get_String_0;

		// Token: 0x0400545F RID: 21599
		private static readonly IntPtr NativeMethodInfoPtr_set_noPickupReason_Protected_set_Void_String_0;

		// Token: 0x04005460 RID: 21600
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005461 RID: 21601
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0;

		// Token: 0x04005462 RID: 21602
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_New_Void_StorableItemInstance_StorageGrid_Vector2_Single_0;

		// Token: 0x04005463 RID: 21603
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTransform_Private_Void_0;

		// Token: 0x04005464 RID: 21604
		private static readonly IntPtr NativeMethodInfoPtr_InitializeIntObj_Protected_Virtual_New_Void_0;

		// Token: 0x04005465 RID: 21605
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Internal_Public_Virtual_New_Void_0;

		// Token: 0x04005466 RID: 21606
		private static readonly IntPtr NativeMethodInfoPtr_DestroyStoredItem_Public_Void_0;

		// Token: 0x04005467 RID: 21607
		private static readonly IntPtr NativeMethodInfoPtr_ClearFootprintOccupancy_Public_Void_0;

		// Token: 0x04005468 RID: 21608
		private static readonly IntPtr NativeMethodInfoPtr_SetCanBePickedUp_Public_Void_Boolean_String_0;

		// Token: 0x04005469 RID: 21609
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0;

		// Token: 0x0400546A RID: 21610
		private static readonly IntPtr NativeMethodInfoPtr_RemoveReservedItems_Public_Static_List_1_StoredItem_List_1_StoredItem_Employee_0;

		// Token: 0x0400546B RID: 21611
		private static readonly IntPtr NativeMethodInfoPtr_CreateGhostModel_Public_Virtual_New_GameObject_ItemInstance_Transform_0;

		// Token: 0x0400546C RID: 21612
		private static readonly IntPtr NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0;

		// Token: 0x0400546D RID: 21613
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Void_0;

		// Token: 0x0400546E RID: 21614
		private static readonly IntPtr NativeMethodInfoPtr_GetTile_Public_FootprintTile_Coordinate_0;

		// Token: 0x0400546F RID: 21615
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0;

		// Token: 0x04005470 RID: 21616
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0;

		// Token: 0x04005471 RID: 21617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AB3 RID: 2739
		[ObfuscatedName("ScheduleOne.Storage.StoredItem+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D3B2 RID: 54194 RVA: 0x0032902C File Offset: 0x0032722C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr);
				StoredItem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, "<>9");
				StoredItem.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, "<>9__14_0");
				StoredItem.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, "<>9__17_0");
				StoredItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, 100678840);
				StoredItem.__c.NativeMethodInfoPtr__get_FootprintX_b__14_0_Internal_Int32_CoordinateStorageFootprintTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, 100678841);
				StoredItem.__c.NativeMethodInfoPtr__get_FootprintY_b__17_0_Internal_Int32_CoordinateStorageFootprintTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, 100678842);
			}

			// Token: 0x0600D3B3 RID: 54195 RVA: 0x003290D0 File Offset: 0x003272D0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3B4 RID: 54196 RVA: 0x0032910C File Offset: 0x0032730C
			[CallerCount(0)]
			public unsafe int _get_FootprintX_b__14_0(CoordinateStorageFootprintTilePair c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.__c.NativeMethodInfoPtr__get_FootprintX_b__14_0_Internal_Int32_CoordinateStorageFootprintTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3B5 RID: 54197 RVA: 0x00329160 File Offset: 0x00327360
			[CallerCount(0)]
			public unsafe int _get_FootprintY_b__17_0(CoordinateStorageFootprintTilePair c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.__c.NativeMethodInfoPtr__get_FootprintY_b__17_0_Internal_Int32_CoordinateStorageFootprintTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3B6 RID: 54198 RVA: 0x00067122 File Offset: 0x00065322
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041A7 RID: 16807
			// (get) Token: 0x0600D3B7 RID: 54199 RVA: 0x003291B4 File Offset: 0x003273B4
			// (set) Token: 0x0600D3B8 RID: 54200 RVA: 0x0006712B File Offset: 0x0006532B
			public unsafe static StoredItem.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StoredItem.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StoredItem.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041A8 RID: 16808
			// (get) Token: 0x0600D3B9 RID: 54201 RVA: 0x003291DC File Offset: 0x003273DC
			// (set) Token: 0x0600D3BA RID: 54202 RVA: 0x0006713D File Offset: 0x0006533D
			public unsafe static Func<CoordinateStorageFootprintTilePair, int> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StoredItem.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CoordinateStorageFootprintTilePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StoredItem.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041A9 RID: 16809
			// (get) Token: 0x0600D3BB RID: 54203 RVA: 0x00329204 File Offset: 0x00327404
			// (set) Token: 0x0600D3BC RID: 54204 RVA: 0x0006714F File Offset: 0x0006534F
			public unsafe static Func<CoordinateStorageFootprintTilePair, int> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StoredItem.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CoordinateStorageFootprintTilePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StoredItem.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E99 RID: 36505
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008E9A RID: 36506
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04008E9B RID: 36507
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04008E9C RID: 36508
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E9D RID: 36509
			private static readonly IntPtr NativeMethodInfoPtr__get_FootprintX_b__14_0_Internal_Int32_CoordinateStorageFootprintTilePair_0;

			// Token: 0x04008E9E RID: 36510
			private static readonly IntPtr NativeMethodInfoPtr__get_FootprintY_b__17_0_Internal_Int32_CoordinateStorageFootprintTilePair_0;
		}

		// Token: 0x02000AB4 RID: 2740
		[ObfuscatedName("ScheduleOne.Storage.StoredItem+<>c__DisplayClass55_0")]
		public sealed class __c__DisplayClass55_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D3BD RID: 54205 RVA: 0x0032922C File Offset: 0x0032742C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass55_0()
			{
				Il2CppClassPointerStore<StoredItem.__c__DisplayClass55_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<>c__DisplayClass55_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem.__c__DisplayClass55_0>.NativeClassPtr);
				StoredItem.__c__DisplayClass55_0.NativeFieldInfoPtr_allowedReservant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem.__c__DisplayClass55_0>.NativeClassPtr, "allowedReservant");
				StoredItem.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem.__c__DisplayClass55_0>.NativeClassPtr, 100678843);
				StoredItem.__c__DisplayClass55_0.NativeMethodInfoPtr__RemoveReservedItems_b__0_Internal_Boolean_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem.__c__DisplayClass55_0>.NativeClassPtr, 100678844);
			}

			// Token: 0x0600D3BE RID: 54206 RVA: 0x00329294 File Offset: 0x00327494
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass55_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem.__c__DisplayClass55_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3BF RID: 54207 RVA: 0x003292D0 File Offset: 0x003274D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236911, XrefRangeEnd = 236918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveReservedItems_b__0(StoredItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.__c__DisplayClass55_0.NativeMethodInfoPtr__RemoveReservedItems_b__0_Internal_Boolean_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3C0 RID: 54208 RVA: 0x00067161 File Offset: 0x00065361
			public __c__DisplayClass55_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041AA RID: 16810
			// (get) Token: 0x0600D3C1 RID: 54209 RVA: 0x00329320 File Offset: 0x00327520
			// (set) Token: 0x0600D3C2 RID: 54210 RVA: 0x0006716A File Offset: 0x0006536A
			public unsafe Employee allowedReservant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.__c__DisplayClass55_0.NativeFieldInfoPtr_allowedReservant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.__c__DisplayClass55_0.NativeFieldInfoPtr_allowedReservant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E9F RID: 36511
			private static readonly IntPtr NativeFieldInfoPtr_allowedReservant;

			// Token: 0x04008EA0 RID: 36512
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EA1 RID: 36513
			private static readonly IntPtr NativeMethodInfoPtr__RemoveReservedItems_b__0_Internal_Boolean_StoredItem_0;
		}
	}
}
