using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.EntityFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x0200019B RID: 411
	public class Grid : MonoBehaviour
	{
		// Token: 0x060021D9 RID: 8665 RVA: 0x000DA534 File Offset: 0x000D8734
		// Note: this type is marked as 'beforefieldinit'.
		static Grid()
		{
			Il2CppClassPointerStore<Grid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "Grid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Grid>.NativeClassPtr);
			Grid.NativeFieldInfoPtr_GridSideLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "GridSideLength");
			Grid.NativeFieldInfoPtr_Tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "Tiles");
			Grid.NativeFieldInfoPtr_CoordinateTilePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "CoordinateTilePairs");
			Grid.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "Container");
			Grid.NativeFieldInfoPtr_IsStatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "IsStatic");
			Grid.NativeFieldInfoPtr_StaticGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "StaticGUID");
			Grid.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "<GUID>k__BackingField");
			Grid.NativeFieldInfoPtr__coordinateToTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "_coordinateToTile");
			Grid.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667117);
			Grid.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667118);
			Grid.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667119);
			Grid.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667120);
			Grid.NativeMethodInfoPtr_DestroyGrid_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667121);
			Grid.NativeMethodInfoPtr_ProcessCoordinateDataPairs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667122);
			Grid.NativeMethodInfoPtr_RegisterTile_Public_Void_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667123);
			Grid.NativeMethodInfoPtr_DeregisterTile_Public_Void_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667124);
			Grid.NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667125);
			Grid.NativeMethodInfoPtr_IsTileValidAtCoordinate_Public_Boolean_Coordinate_FootprintTile_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667126);
			Grid.NativeMethodInfoPtr_IsTileValidAtCoordinate_Public_Boolean_Coordinate_FootprintTile_Constructable_GridBased_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667127);
			Grid.NativeMethodInfoPtr_GetTile_Public_Tile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667128);
			Grid.NativeMethodInfoPtr_SetVisible_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667129);
			Grid.NativeMethodInfoPtr_SetInvisible_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667130);
			Grid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667131);
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x000DA730 File Offset: 0x000D8930
		// (set) Token: 0x060021DB RID: 8667 RVA: 0x000DA76C File Offset: 0x000D896C
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x000DA7AC File Offset: 0x000D89AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110868, XrefRangeEnd = 110872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x000DA7EC File Offset: 0x000D89EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110872, XrefRangeEnd = 110912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Grid.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x000DA828 File Offset: 0x000D8A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110912, XrefRangeEnd = 110916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyGrid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Grid.NativeMethodInfoPtr_DestroyGrid_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x000DA864 File Offset: 0x000D8A64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110933, RefRangeEnd = 110934, XrefRangeStart = 110916, XrefRangeEnd = 110933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessCoordinateDataPairs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_ProcessCoordinateDataPairs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x000DA898 File Offset: 0x000D8A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110934, XrefRangeEnd = 110948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterTile(Tile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_RegisterTile_Public_Void_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x000DA8DC File Offset: 0x000D8ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110948, XrefRangeEnd = 110974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterTile(Tile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_DeregisterTile_Public_Void_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x000DA920 File Offset: 0x000D8B20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110989, RefRangeEnd = 110992, XrefRangeStart = 110974, XrefRangeEnd = 110989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coordinate GetMatchedCoordinate(FootprintTile tileToMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tileToMatch);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr3) : null;
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x000DA970 File Offset: 0x000D8B70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111004, RefRangeEnd = 111005, XrefRangeStart = 110992, XrefRangeEnd = 111004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileValidAtCoordinate(Coordinate gridCoord, FootprintTile tile, GridItem tileOwner = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gridCoord);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tileOwner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_IsTileValidAtCoordinate_Public_Boolean_Coordinate_FootprintTile_GridItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x000DA9E4 File Offset: 0x000D8BE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111021, RefRangeEnd = 111022, XrefRangeStart = 111005, XrefRangeEnd = 111021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileValidAtCoordinate(Coordinate gridCoord, FootprintTile tile, Constructable_GridBased ignoreConstructable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gridCoord);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreConstructable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_IsTileValidAtCoordinate_Public_Boolean_Coordinate_FootprintTile_Constructable_GridBased_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x000DAA58 File Offset: 0x000D8C58
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 111036, RefRangeEnd = 111067, XrefRangeStart = 111022, XrefRangeEnd = 111036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tile GetTile(Coordinate coord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_GetTile_Public_Tile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr3) : null;
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x000DAAA8 File Offset: 0x000D8CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111067, XrefRangeEnd = 111078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_SetVisible_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x000DAADC File Offset: 0x000D8CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111078, XrefRangeEnd = 111089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInvisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_SetInvisible_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x000DAB10 File Offset: 0x000D8D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111089, XrefRangeEnd = 111114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Grid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Grid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x00012E3F File Offset: 0x0001103F
		public Grid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x060021EA RID: 8682 RVA: 0x000DAB4C File Offset: 0x000D8D4C
		// (set) Token: 0x060021EB RID: 8683 RVA: 0x00012E48 File Offset: 0x00011048
		public unsafe static float GridSideLength
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Grid.NativeFieldInfoPtr_GridSideLength, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Grid.NativeFieldInfoPtr_GridSideLength, (void*)(&value));
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x060021EC RID: 8684 RVA: 0x000DAB68 File Offset: 0x000D8D68
		// (set) Token: 0x060021ED RID: 8685 RVA: 0x00012E56 File Offset: 0x00011056
		public unsafe List<Tile> Tiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_Tiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_Tiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x000DAB98 File Offset: 0x000D8D98
		// (set) Token: 0x060021EF RID: 8687 RVA: 0x00012E75 File Offset: 0x00011075
		public unsafe List<CoordinateTilePair> CoordinateTilePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_CoordinateTilePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateTilePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_CoordinateTilePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x060021F0 RID: 8688 RVA: 0x000DABC8 File Offset: 0x000D8DC8
		// (set) Token: 0x060021F1 RID: 8689 RVA: 0x00012E94 File Offset: 0x00011094
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x060021F2 RID: 8690 RVA: 0x000DABF8 File Offset: 0x000D8DF8
		// (set) Token: 0x060021F3 RID: 8691 RVA: 0x00012EB3 File Offset: 0x000110B3
		public unsafe bool IsStatic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_IsStatic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_IsStatic)) = value;
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x060021F4 RID: 8692 RVA: 0x000DAC20 File Offset: 0x000D8E20
		// (set) Token: 0x060021F5 RID: 8693 RVA: 0x00012ECE File Offset: 0x000110CE
		public unsafe string StaticGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_StaticGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_StaticGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x060021F6 RID: 8694 RVA: 0x000DAC48 File Offset: 0x000D8E48
		// (set) Token: 0x060021F7 RID: 8695 RVA: 0x00012EED File Offset: 0x000110ED
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x060021F8 RID: 8696 RVA: 0x000DAC70 File Offset: 0x000D8E70
		// (set) Token: 0x060021F9 RID: 8697 RVA: 0x00012F08 File Offset: 0x00011108
		public unsafe Dictionary<Coordinate, Tile> _coordinateToTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__coordinateToTile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Coordinate, Tile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__coordinateToTile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001685 RID: 5765
		private static readonly IntPtr NativeFieldInfoPtr_GridSideLength;

		// Token: 0x04001686 RID: 5766
		private static readonly IntPtr NativeFieldInfoPtr_Tiles;

		// Token: 0x04001687 RID: 5767
		private static readonly IntPtr NativeFieldInfoPtr_CoordinateTilePairs;

		// Token: 0x04001688 RID: 5768
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04001689 RID: 5769
		private static readonly IntPtr NativeFieldInfoPtr_IsStatic;

		// Token: 0x0400168A RID: 5770
		private static readonly IntPtr NativeFieldInfoPtr_StaticGUID;

		// Token: 0x0400168B RID: 5771
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x0400168C RID: 5772
		private static readonly IntPtr NativeFieldInfoPtr__coordinateToTile;

		// Token: 0x0400168D RID: 5773
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x0400168E RID: 5774
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x0400168F RID: 5775
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04001690 RID: 5776
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04001691 RID: 5777
		private static readonly IntPtr NativeMethodInfoPtr_DestroyGrid_Public_Virtual_New_Void_0;

		// Token: 0x04001692 RID: 5778
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCoordinateDataPairs_Private_Void_0;

		// Token: 0x04001693 RID: 5779
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTile_Public_Void_Tile_0;

		// Token: 0x04001694 RID: 5780
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterTile_Public_Void_Tile_0;

		// Token: 0x04001695 RID: 5781
		private static readonly IntPtr NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0;

		// Token: 0x04001696 RID: 5782
		private static readonly IntPtr NativeMethodInfoPtr_IsTileValidAtCoordinate_Public_Boolean_Coordinate_FootprintTile_GridItem_0;

		// Token: 0x04001697 RID: 5783
		private static readonly IntPtr NativeMethodInfoPtr_IsTileValidAtCoordinate_Public_Boolean_Coordinate_FootprintTile_Constructable_GridBased_0;

		// Token: 0x04001698 RID: 5784
		private static readonly IntPtr NativeMethodInfoPtr_GetTile_Public_Tile_Coordinate_0;

		// Token: 0x04001699 RID: 5785
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_0;

		// Token: 0x0400169A RID: 5786
		private static readonly IntPtr NativeMethodInfoPtr_SetInvisible_Public_Void_0;

		// Token: 0x0400169B RID: 5787
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008C0 RID: 2240
		[ObfuscatedName("ScheduleOne.Tiles.Grid+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C3A7 RID: 50087 RVA: 0x002FB538 File Offset: 0x002F9738
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<Grid.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Grid>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Grid.__c__DisplayClass20_0>.NativeClassPtr);
				Grid.__c__DisplayClass20_0.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid.__c__DisplayClass20_0>.NativeClassPtr, "coord");
				Grid.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid.__c__DisplayClass20_0>.NativeClassPtr, 100667133);
				Grid.__c__DisplayClass20_0.NativeMethodInfoPtr__GetTile_b__0_Internal_Boolean_CoordinateTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid.__c__DisplayClass20_0>.NativeClassPtr, 100667134);
			}

			// Token: 0x0600C3A8 RID: 50088 RVA: 0x002FB5A0 File Offset: 0x002F97A0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Grid.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3A9 RID: 50089 RVA: 0x002FB5DC File Offset: 0x002F97DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110867, XrefRangeEnd = 110868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTile_b__0(CoordinateTilePair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.__c__DisplayClass20_0.NativeMethodInfoPtr__GetTile_b__0_Internal_Boolean_CoordinateTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C3AA RID: 50090 RVA: 0x0005F41B File Offset: 0x0005D61B
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D1B RID: 15643
			// (get) Token: 0x0600C3AB RID: 50091 RVA: 0x002FB630 File Offset: 0x002F9830
			// (set) Token: 0x0600C3AC RID: 50092 RVA: 0x0005F424 File Offset: 0x0005D624
			public unsafe Coordinate coord
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.__c__DisplayClass20_0.NativeFieldInfoPtr_coord);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.__c__DisplayClass20_0.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084A6 RID: 33958
			private static readonly IntPtr NativeFieldInfoPtr_coord;

			// Token: 0x040084A7 RID: 33959
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084A8 RID: 33960
			private static readonly IntPtr NativeMethodInfoPtr__GetTile_b__0_Internal_Boolean_CoordinateTilePair_0;
		}
	}
}
