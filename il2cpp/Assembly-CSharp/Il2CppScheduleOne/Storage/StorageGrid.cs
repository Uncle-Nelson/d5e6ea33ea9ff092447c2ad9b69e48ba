using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000579 RID: 1401
	public class StorageGrid : MonoBehaviour
	{
		// Token: 0x06007B47 RID: 31559 RVA: 0x00212EEC File Offset: 0x002110EC
		// Note: this type is marked as 'beforefieldinit'.
		static StorageGrid()
		{
			Il2CppClassPointerStore<StorageGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr);
			StorageGrid.NativeFieldInfoPtr_gridSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "gridSize");
			StorageGrid.NativeFieldInfoPtr_storageTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "storageTiles");
			StorageGrid.NativeFieldInfoPtr_freeTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "freeTiles");
			StorageGrid.NativeFieldInfoPtr_coordinateStorageTilePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "coordinateStorageTilePairs");
			StorageGrid.NativeFieldInfoPtr_coordinateToTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "coordinateToTile");
			StorageGrid.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678751);
			StorageGrid.NativeMethodInfoPtr_ProcessCoordinateTilePairs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678752);
			StorageGrid.NativeMethodInfoPtr_RegisterTile_Public_Void_StorageTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678753);
			StorageGrid.NativeMethodInfoPtr_DeregisterTile_Public_Void_StorageTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678754);
			StorageGrid.NativeMethodInfoPtr_IsItemPositionValid_Public_Boolean_StorageTile_FootprintTile_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678755);
			StorageGrid.NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678756);
			StorageGrid.NativeMethodInfoPtr_IsGridPositionValid_Public_Boolean_Coordinate_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678757);
			StorageGrid.NativeMethodInfoPtr_GetTile_Public_StorageTile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678758);
			StorageGrid.NativeMethodInfoPtr_GetUserEndCapacity_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678759);
			StorageGrid.NativeMethodInfoPtr_GetActualY_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678760);
			StorageGrid.NativeMethodInfoPtr_GetActualX_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678761);
			StorageGrid.NativeMethodInfoPtr_GetTotalFootprintSize_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678762);
			StorageGrid.NativeMethodInfoPtr_TryFitItem_Public_Boolean_Int32_Int32_List_1_Coordinate_byref_Coordinate_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678763);
			StorageGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678764);
		}

		// Token: 0x06007B48 RID: 31560 RVA: 0x00213098 File Offset: 0x00211298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236181, XrefRangeEnd = 236186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageGrid.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B49 RID: 31561 RVA: 0x002130D4 File Offset: 0x002112D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236203, RefRangeEnd = 236204, XrefRangeStart = 236186, XrefRangeEnd = 236203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessCoordinateTilePairs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_ProcessCoordinateTilePairs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B4A RID: 31562 RVA: 0x00213108 File Offset: 0x00211308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236204, XrefRangeEnd = 236218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterTile(StorageTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_RegisterTile_Public_Void_StorageTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B4B RID: 31563 RVA: 0x0021314C File Offset: 0x0021134C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236218, XrefRangeEnd = 236233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterTile(StorageTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_DeregisterTile_Public_Void_StorageTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B4C RID: 31564 RVA: 0x00213190 File Offset: 0x00211390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236268, RefRangeEnd = 236269, XrefRangeStart = 236233, XrefRangeEnd = 236268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsItemPositionValid(StorageTile primaryTile, FootprintTile primaryFootprintTile, StoredItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(primaryTile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(primaryFootprintTile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_IsItemPositionValid_Public_Boolean_StorageTile_FootprintTile_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007B4D RID: 31565 RVA: 0x00213204 File Offset: 0x00211404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236284, RefRangeEnd = 236285, XrefRangeStart = 236269, XrefRangeEnd = 236284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coordinate GetMatchedCoordinate(FootprintTile tileToMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tileToMatch);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr3) : null;
		}

		// Token: 0x06007B4E RID: 31566 RVA: 0x00213254 File Offset: 0x00211454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236295, RefRangeEnd = 236296, XrefRangeStart = 236285, XrefRangeEnd = 236295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGridPositionValid(Coordinate gridCoord, FootprintTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gridCoord);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_IsGridPositionValid_Public_Boolean_Coordinate_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007B4F RID: 31567 RVA: 0x002132B4 File Offset: 0x002114B4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 236303, RefRangeEnd = 236315, XrefRangeStart = 236296, XrefRangeEnd = 236303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageTile GetTile(Coordinate coord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetTile_Public_StorageTile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorageTile>(intPtr3) : null;
		}

		// Token: 0x06007B50 RID: 31568 RVA: 0x00213304 File Offset: 0x00211504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236315, XrefRangeEnd = 236317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUserEndCapacity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetUserEndCapacity_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007B51 RID: 31569 RVA: 0x00213340 File Offset: 0x00211540
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 236322, RefRangeEnd = 236324, XrefRangeStart = 236317, XrefRangeEnd = 236322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetActualY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetActualY_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007B52 RID: 31570 RVA: 0x0021337C File Offset: 0x0021157C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236324, XrefRangeEnd = 236326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetActualX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetActualX_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007B53 RID: 31571 RVA: 0x002133B8 File Offset: 0x002115B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236326, XrefRangeEnd = 236327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalFootprintSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetTotalFootprintSize_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007B54 RID: 31572 RVA: 0x002133F4 File Offset: 0x002115F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 236378, RefRangeEnd = 236381, XrefRangeStart = 236327, XrefRangeEnd = 236378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryFitItem(int sizeX, int sizeY, List<Coordinate> lockedCoordinates, out Coordinate originCoordinate, out float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sizeX;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeY;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockedCoordinates);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotation;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_TryFitItem_Public_Boolean_Int32_Int32_List_1_Coordinate_byref_Coordinate_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			originCoordinate = ((intPtr4 == 0) ? null : new Coordinate(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06007B55 RID: 31573 RVA: 0x00213490 File Offset: 0x00211690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236381, XrefRangeEnd = 236408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageGrid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B56 RID: 31574 RVA: 0x0003A839 File Offset: 0x00038A39
		public StorageGrid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002538 RID: 9528
		// (get) Token: 0x06007B57 RID: 31575 RVA: 0x002134CC File Offset: 0x002116CC
		// (set) Token: 0x06007B58 RID: 31576 RVA: 0x0003A842 File Offset: 0x00038A42
		public unsafe static float gridSize
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StorageGrid.NativeFieldInfoPtr_gridSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StorageGrid.NativeFieldInfoPtr_gridSize, (void*)(&value));
			}
		}

		// Token: 0x17002539 RID: 9529
		// (get) Token: 0x06007B59 RID: 31577 RVA: 0x002134E8 File Offset: 0x002116E8
		// (set) Token: 0x06007B5A RID: 31578 RVA: 0x0003A850 File Offset: 0x00038A50
		public unsafe List<StorageTile> storageTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_storageTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StorageTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_storageTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700253A RID: 9530
		// (get) Token: 0x06007B5B RID: 31579 RVA: 0x00213518 File Offset: 0x00211718
		// (set) Token: 0x06007B5C RID: 31580 RVA: 0x0003A86F File Offset: 0x00038A6F
		public unsafe List<StorageTile> freeTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_freeTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StorageTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_freeTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700253B RID: 9531
		// (get) Token: 0x06007B5D RID: 31581 RVA: 0x00213548 File Offset: 0x00211748
		// (set) Token: 0x06007B5E RID: 31582 RVA: 0x0003A88E File Offset: 0x00038A8E
		public unsafe List<CoordinateStorageTilePair> coordinateStorageTilePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_coordinateStorageTilePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateStorageTilePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_coordinateStorageTilePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700253C RID: 9532
		// (get) Token: 0x06007B5F RID: 31583 RVA: 0x00213578 File Offset: 0x00211778
		// (set) Token: 0x06007B60 RID: 31584 RVA: 0x0003A8AD File Offset: 0x00038AAD
		public unsafe Dictionary<Coordinate, StorageTile> coordinateToTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_coordinateToTile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Coordinate, StorageTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_coordinateToTile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040053F1 RID: 21489
		private static readonly IntPtr NativeFieldInfoPtr_gridSize;

		// Token: 0x040053F2 RID: 21490
		private static readonly IntPtr NativeFieldInfoPtr_storageTiles;

		// Token: 0x040053F3 RID: 21491
		private static readonly IntPtr NativeFieldInfoPtr_freeTiles;

		// Token: 0x040053F4 RID: 21492
		private static readonly IntPtr NativeFieldInfoPtr_coordinateStorageTilePairs;

		// Token: 0x040053F5 RID: 21493
		private static readonly IntPtr NativeFieldInfoPtr_coordinateToTile;

		// Token: 0x040053F6 RID: 21494
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040053F7 RID: 21495
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCoordinateTilePairs_Private_Void_0;

		// Token: 0x040053F8 RID: 21496
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTile_Public_Void_StorageTile_0;

		// Token: 0x040053F9 RID: 21497
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterTile_Public_Void_StorageTile_0;

		// Token: 0x040053FA RID: 21498
		private static readonly IntPtr NativeMethodInfoPtr_IsItemPositionValid_Public_Boolean_StorageTile_FootprintTile_StoredItem_0;

		// Token: 0x040053FB RID: 21499
		private static readonly IntPtr NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0;

		// Token: 0x040053FC RID: 21500
		private static readonly IntPtr NativeMethodInfoPtr_IsGridPositionValid_Public_Boolean_Coordinate_FootprintTile_0;

		// Token: 0x040053FD RID: 21501
		private static readonly IntPtr NativeMethodInfoPtr_GetTile_Public_StorageTile_Coordinate_0;

		// Token: 0x040053FE RID: 21502
		private static readonly IntPtr NativeMethodInfoPtr_GetUserEndCapacity_Public_Int32_0;

		// Token: 0x040053FF RID: 21503
		private static readonly IntPtr NativeMethodInfoPtr_GetActualY_Public_Int32_0;

		// Token: 0x04005400 RID: 21504
		private static readonly IntPtr NativeMethodInfoPtr_GetActualX_Public_Int32_0;

		// Token: 0x04005401 RID: 21505
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalFootprintSize_Public_Int32_0;

		// Token: 0x04005402 RID: 21506
		private static readonly IntPtr NativeMethodInfoPtr_TryFitItem_Public_Boolean_Int32_Int32_List_1_Coordinate_byref_Coordinate_byref_Single_0;

		// Token: 0x04005403 RID: 21507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
