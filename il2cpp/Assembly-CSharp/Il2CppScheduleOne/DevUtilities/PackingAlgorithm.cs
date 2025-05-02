using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000462 RID: 1122
	public class PackingAlgorithm : Singleton<PackingAlgorithm>
	{
		// Token: 0x06006184 RID: 24964 RVA: 0x001BC9CC File Offset: 0x001BABCC
		// Note: this type is marked as 'beforefieldinit'.
		static PackingAlgorithm()
		{
			Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PackingAlgorithm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr);
			PackingAlgorithm.NativeFieldInfoPtr_rectsToPack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, "rectsToPack");
			PackingAlgorithm.NativeMethodInfoPtr_PackItems_Public_List_1_StoredItemData_List_1_ItemInstance_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100675679);
			PackingAlgorithm.NativeMethodInfoPtr_AttemptPack_Public_List_1_StoredItemData_List_1_StoredItemData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100675680);
			PackingAlgorithm.NativeMethodInfoPtr_DoesCoordinateHaveOccupiedAdjacent_Private_Boolean_Il2CppObjectBase_Coordinate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100675681);
			PackingAlgorithm.NativeMethodInfoPtr_IsCoordinateInBounds_Private_Boolean_Coordinate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100675682);
			PackingAlgorithm.NativeMethodInfoPtr_PrintGrid_Private_Void_Il2CppObjectBase_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100675683);
			PackingAlgorithm.NativeMethodInfoPtr_GetRegionSize_Private_Int32_Il2CppObjectBase_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100675684);
			PackingAlgorithm.NativeMethodInfoPtr_TransformCoordinatePoint_Private_Coordinate_Il2CppObjectBase_Coordinate_Coordinate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100675685);
			PackingAlgorithm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, 100675686);
		}

		// Token: 0x06006185 RID: 24965 RVA: 0x001BCAB0 File Offset: 0x001BACB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200841, XrefRangeEnd = 200871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<PackingAlgorithm.StoredItemData> PackItems(List<ItemInstance> datas, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(datas);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_PackItems_Public_List_1_StoredItemData_List_1_ItemInstance_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PackingAlgorithm.StoredItemData>>(intPtr3) : null;
		}

		// Token: 0x06006186 RID: 24966 RVA: 0x001BCB1C File Offset: 0x001BAD1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201058, RefRangeEnd = 201059, XrefRangeStart = 200871, XrefRangeEnd = 201058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<PackingAlgorithm.StoredItemData> AttemptPack(List<PackingAlgorithm.StoredItemData> rects, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rects);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_AttemptPack_Public_List_1_StoredItemData_List_1_StoredItemData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PackingAlgorithm.StoredItemData>>(intPtr3) : null;
		}

		// Token: 0x06006187 RID: 24967 RVA: 0x001BCB88 File Offset: 0x001BAD88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201072, RefRangeEnd = 201073, XrefRangeStart = 201059, XrefRangeEnd = 201072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesCoordinateHaveOccupiedAdjacent(Il2CppObjectBase grid, PackingAlgorithm.Coordinate coord, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridX;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_DoesCoordinateHaveOccupiedAdjacent_Private_Boolean_Il2CppObjectBase_Coordinate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006188 RID: 24968 RVA: 0x001BCC04 File Offset: 0x001BAE04
		[CallerCount(0)]
		public unsafe bool IsCoordinateInBounds(PackingAlgorithm.Coordinate coord, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_IsCoordinateInBounds_Private_Boolean_Coordinate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006189 RID: 24969 RVA: 0x001BCC70 File Offset: 0x001BAE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201073, XrefRangeEnd = 201091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintGrid(Il2CppObjectBase grid, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_PrintGrid_Private_Void_Il2CppObjectBase_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600618A RID: 24970 RVA: 0x001BCCD0 File Offset: 0x001BAED0
		[CallerCount(0)]
		public unsafe int GetRegionSize(Il2CppObjectBase grid, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_GetRegionSize_Private_Int32_Il2CppObjectBase_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600618B RID: 24971 RVA: 0x001BCD3C File Offset: 0x001BAF3C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 201095, RefRangeEnd = 201102, XrefRangeStart = 201091, XrefRangeEnd = 201095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackingAlgorithm.Coordinate TransformCoordinatePoint(Il2CppObjectBase grid, PackingAlgorithm.Coordinate baseCoordinate, PackingAlgorithm.Coordinate offset, int gridX, int gridY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseCoordinate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(offset);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridX;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr_TransformCoordinatePoint_Private_Coordinate_Il2CppObjectBase_Coordinate_Coordinate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PackingAlgorithm.Coordinate>(intPtr3) : null;
		}

		// Token: 0x0600618C RID: 24972 RVA: 0x001BCDCC File Offset: 0x001BAFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201102, XrefRangeEnd = 201112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackingAlgorithm() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600618D RID: 24973 RVA: 0x0002E1C9 File Offset: 0x0002C3C9
		public PackingAlgorithm(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x0600618E RID: 24974 RVA: 0x001BCE08 File Offset: 0x001BB008
		// (set) Token: 0x0600618F RID: 24975 RVA: 0x0002E1D2 File Offset: 0x0002C3D2
		public unsafe List<PackingAlgorithm.Rectangle> rectsToPack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.NativeFieldInfoPtr_rectsToPack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PackingAlgorithm.Rectangle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.NativeFieldInfoPtr_rectsToPack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004287 RID: 17031
		private static readonly IntPtr NativeFieldInfoPtr_rectsToPack;

		// Token: 0x04004288 RID: 17032
		private static readonly IntPtr NativeMethodInfoPtr_PackItems_Public_List_1_StoredItemData_List_1_ItemInstance_Int32_Int32_0;

		// Token: 0x04004289 RID: 17033
		private static readonly IntPtr NativeMethodInfoPtr_AttemptPack_Public_List_1_StoredItemData_List_1_StoredItemData_Int32_Int32_0;

		// Token: 0x0400428A RID: 17034
		private static readonly IntPtr NativeMethodInfoPtr_DoesCoordinateHaveOccupiedAdjacent_Private_Boolean_Il2CppObjectBase_Coordinate_Int32_Int32_0;

		// Token: 0x0400428B RID: 17035
		private static readonly IntPtr NativeMethodInfoPtr_IsCoordinateInBounds_Private_Boolean_Coordinate_Int32_Int32_0;

		// Token: 0x0400428C RID: 17036
		private static readonly IntPtr NativeMethodInfoPtr_PrintGrid_Private_Void_Il2CppObjectBase_Int32_Int32_0;

		// Token: 0x0400428D RID: 17037
		private static readonly IntPtr NativeMethodInfoPtr_GetRegionSize_Private_Int32_Il2CppObjectBase_Int32_Int32_0;

		// Token: 0x0400428E RID: 17038
		private static readonly IntPtr NativeMethodInfoPtr_TransformCoordinatePoint_Private_Coordinate_Il2CppObjectBase_Coordinate_Coordinate_Int32_Int32_0;

		// Token: 0x0400428F RID: 17039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A16 RID: 2582
		[Serializable]
		public class Rectangle : Object
		{
			// Token: 0x0600CEDA RID: 52954 RVA: 0x0031BC44 File Offset: 0x00319E44
			// Note: this type is marked as 'beforefieldinit'.
			static Rectangle()
			{
				Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, "Rectangle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr);
				PackingAlgorithm.Rectangle.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, "name");
				PackingAlgorithm.Rectangle.NativeFieldInfoPtr_sizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, "sizeX");
				PackingAlgorithm.Rectangle.NativeFieldInfoPtr_sizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, "sizeY");
				PackingAlgorithm.Rectangle.NativeFieldInfoPtr_flipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, "flipped");
				PackingAlgorithm.Rectangle.NativeMethodInfoPtr_get_actualSizeX_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, 100675687);
				PackingAlgorithm.Rectangle.NativeMethodInfoPtr_get_actualSizeY_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, 100675688);
				PackingAlgorithm.Rectangle.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr, 100675689);
			}

			// Token: 0x17004054 RID: 16468
			// (get) Token: 0x0600CEDB RID: 52955 RVA: 0x0031BCFC File Offset: 0x00319EFC
			public unsafe int actualSizeX
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.Rectangle.NativeMethodInfoPtr_get_actualSizeX_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004055 RID: 16469
			// (get) Token: 0x0600CEDC RID: 52956 RVA: 0x0031BD38 File Offset: 0x00319F38
			public unsafe int actualSizeY
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.Rectangle.NativeMethodInfoPtr_get_actualSizeY_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600CEDD RID: 52957 RVA: 0x0031BD74 File Offset: 0x00319F74
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 200836, RefRangeEnd = 200837, XrefRangeStart = 200834, XrefRangeEnd = 200836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Rectangle(string _name, int x, int y) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackingAlgorithm.Rectangle>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_name);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.Rectangle.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEDE RID: 52958 RVA: 0x000649A2 File Offset: 0x00062BA2
			public Rectangle(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004050 RID: 16464
			// (get) Token: 0x0600CEDF RID: 52959 RVA: 0x0031BDDC File Offset: 0x00319FDC
			// (set) Token: 0x0600CEE0 RID: 52960 RVA: 0x000649AB File Offset: 0x00062BAB
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004051 RID: 16465
			// (get) Token: 0x0600CEE1 RID: 52961 RVA: 0x0031BE04 File Offset: 0x0031A004
			// (set) Token: 0x0600CEE2 RID: 52962 RVA: 0x000649CA File Offset: 0x00062BCA
			public unsafe int sizeX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_sizeX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_sizeX)) = value;
				}
			}

			// Token: 0x17004052 RID: 16466
			// (get) Token: 0x0600CEE3 RID: 52963 RVA: 0x0031BE2C File Offset: 0x0031A02C
			// (set) Token: 0x0600CEE4 RID: 52964 RVA: 0x000649E5 File Offset: 0x00062BE5
			public unsafe int sizeY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_sizeY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_sizeY)) = value;
				}
			}

			// Token: 0x17004053 RID: 16467
			// (get) Token: 0x0600CEE5 RID: 52965 RVA: 0x0031BE54 File Offset: 0x0031A054
			// (set) Token: 0x0600CEE6 RID: 52966 RVA: 0x00064A00 File Offset: 0x00062C00
			public unsafe bool flipped
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_flipped);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Rectangle.NativeFieldInfoPtr_flipped)) = value;
				}
			}

			// Token: 0x04008B92 RID: 35730
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04008B93 RID: 35731
			private static readonly IntPtr NativeFieldInfoPtr_sizeX;

			// Token: 0x04008B94 RID: 35732
			private static readonly IntPtr NativeFieldInfoPtr_sizeY;

			// Token: 0x04008B95 RID: 35733
			private static readonly IntPtr NativeFieldInfoPtr_flipped;

			// Token: 0x04008B96 RID: 35734
			private static readonly IntPtr NativeMethodInfoPtr_get_actualSizeX_Public_get_Int32_0;

			// Token: 0x04008B97 RID: 35735
			private static readonly IntPtr NativeMethodInfoPtr_get_actualSizeY_Public_get_Int32_0;

			// Token: 0x04008B98 RID: 35736
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0;
		}

		// Token: 0x02000A17 RID: 2583
		public class StoredItemData : PackingAlgorithm.Rectangle
		{
			// Token: 0x0600CEE7 RID: 52967 RVA: 0x0031BE7C File Offset: 0x0031A07C
			// Note: this type is marked as 'beforefieldinit'.
			static StoredItemData()
			{
				Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, "StoredItemData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr);
				PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr, "item");
				PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_xPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr, "xPos");
				PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_yPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr, "yPos");
				PackingAlgorithm.StoredItemData.NativeMethodInfoPtr_get_rotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr, 100675690);
				PackingAlgorithm.StoredItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr, 100675691);
			}

			// Token: 0x17004059 RID: 16473
			// (get) Token: 0x0600CEE8 RID: 52968 RVA: 0x0031BF0C File Offset: 0x0031A10C
			public unsafe float rotation
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.StoredItemData.NativeMethodInfoPtr_get_rotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600CEE9 RID: 52969 RVA: 0x0031BF48 File Offset: 0x0031A148
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 200840, RefRangeEnd = 200841, XrefRangeStart = 200837, XrefRangeEnd = 200840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StoredItemData(string _name, int x, int y, ItemInstance _item) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackingAlgorithm.StoredItemData>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_name);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.StoredItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEEA RID: 52970 RVA: 0x00064A1B File Offset: 0x00062C1B
			public StoredItemData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004056 RID: 16470
			// (get) Token: 0x0600CEEB RID: 52971 RVA: 0x0031BFC4 File Offset: 0x0031A1C4
			// (set) Token: 0x0600CEEC RID: 52972 RVA: 0x00064A24 File Offset: 0x00062C24
			public unsafe ItemInstance item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004057 RID: 16471
			// (get) Token: 0x0600CEED RID: 52973 RVA: 0x0031BFF4 File Offset: 0x0031A1F4
			// (set) Token: 0x0600CEEE RID: 52974 RVA: 0x00064A43 File Offset: 0x00062C43
			public unsafe int xPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_xPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_xPos)) = value;
				}
			}

			// Token: 0x17004058 RID: 16472
			// (get) Token: 0x0600CEEF RID: 52975 RVA: 0x0031C01C File Offset: 0x0031A21C
			// (set) Token: 0x0600CEF0 RID: 52976 RVA: 0x00064A5E File Offset: 0x00062C5E
			public unsafe int yPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_yPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.StoredItemData.NativeFieldInfoPtr_yPos)) = value;
				}
			}

			// Token: 0x04008B99 RID: 35737
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04008B9A RID: 35738
			private static readonly IntPtr NativeFieldInfoPtr_xPos;

			// Token: 0x04008B9B RID: 35739
			private static readonly IntPtr NativeFieldInfoPtr_yPos;

			// Token: 0x04008B9C RID: 35740
			private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Single_0;

			// Token: 0x04008B9D RID: 35741
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_ItemInstance_0;
		}

		// Token: 0x02000A18 RID: 2584
		public class Coordinate : Object
		{
			// Token: 0x0600CEF1 RID: 52977 RVA: 0x0031C044 File Offset: 0x0031A244
			// Note: this type is marked as 'beforefieldinit'.
			static Coordinate()
			{
				Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, "Coordinate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr);
				PackingAlgorithm.Coordinate.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr, "x");
				PackingAlgorithm.Coordinate.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr, "y");
				PackingAlgorithm.Coordinate.NativeFieldInfoPtr_occupant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr, "occupant");
				PackingAlgorithm.Coordinate.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr, 100675692);
			}

			// Token: 0x0600CEF2 RID: 52978 RVA: 0x0031C0C0 File Offset: 0x0031A2C0
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 110590, RefRangeEnd = 110607, XrefRangeStart = 110590, XrefRangeEnd = 110607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Coordinate(int _x, int _y) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackingAlgorithm.Coordinate>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref _x;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.Coordinate.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEF3 RID: 52979 RVA: 0x00064A79 File Offset: 0x00062C79
			public Coordinate(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700405A RID: 16474
			// (get) Token: 0x0600CEF4 RID: 52980 RVA: 0x0031C118 File Offset: 0x0031A318
			// (set) Token: 0x0600CEF5 RID: 52981 RVA: 0x00064A82 File Offset: 0x00062C82
			public unsafe int x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Coordinate.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Coordinate.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x1700405B RID: 16475
			// (get) Token: 0x0600CEF6 RID: 52982 RVA: 0x0031C140 File Offset: 0x0031A340
			// (set) Token: 0x0600CEF7 RID: 52983 RVA: 0x00064A9D File Offset: 0x00062C9D
			public unsafe int y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Coordinate.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Coordinate.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x1700405C RID: 16476
			// (get) Token: 0x0600CEF8 RID: 52984 RVA: 0x0031C168 File Offset: 0x0031A368
			// (set) Token: 0x0600CEF9 RID: 52985 RVA: 0x00064AB8 File Offset: 0x00062CB8
			public unsafe PackingAlgorithm.Rectangle occupant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Coordinate.NativeFieldInfoPtr_occupant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackingAlgorithm.Rectangle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAlgorithm.Coordinate.NativeFieldInfoPtr_occupant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B9E RID: 35742
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04008B9F RID: 35743
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04008BA0 RID: 35744
			private static readonly IntPtr NativeFieldInfoPtr_occupant;

			// Token: 0x04008BA1 RID: 35745
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
		}

		// Token: 0x02000A19 RID: 2585
		[ObfuscatedName("ScheduleOne.DevUtilities.PackingAlgorithm+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600CEFA RID: 52986 RVA: 0x0031C198 File Offset: 0x0031A398
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackingAlgorithm>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr);
				PackingAlgorithm.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr, "<>9");
				PackingAlgorithm.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr, "<>9__5_0");
				PackingAlgorithm.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr, 100675694);
				PackingAlgorithm.__c.NativeMethodInfoPtr__AttemptPack_b__5_0_Internal_Int32_StoredItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr, 100675695);
			}

			// Token: 0x0600CEFB RID: 52987 RVA: 0x0031C214 File Offset: 0x0031A414
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackingAlgorithm.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEFC RID: 52988 RVA: 0x0031C250 File Offset: 0x0031A450
			[CallerCount(0)]
			public unsafe int _AttemptPack_b__5_0(PackingAlgorithm.StoredItemData o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAlgorithm.__c.NativeMethodInfoPtr__AttemptPack_b__5_0_Internal_Int32_StoredItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CEFD RID: 52989 RVA: 0x00064AD7 File Offset: 0x00062CD7
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700405D RID: 16477
			// (get) Token: 0x0600CEFE RID: 52990 RVA: 0x0031C2A0 File Offset: 0x0031A4A0
			// (set) Token: 0x0600CEFF RID: 52991 RVA: 0x00064AE0 File Offset: 0x00062CE0
			public unsafe static PackingAlgorithm.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PackingAlgorithm.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackingAlgorithm.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PackingAlgorithm.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700405E RID: 16478
			// (get) Token: 0x0600CF00 RID: 52992 RVA: 0x0031C2C8 File Offset: 0x0031A4C8
			// (set) Token: 0x0600CF01 RID: 52993 RVA: 0x00064AF2 File Offset: 0x00062CF2
			public unsafe static Func<PackingAlgorithm.StoredItemData, int> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PackingAlgorithm.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PackingAlgorithm.StoredItemData, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PackingAlgorithm.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BA2 RID: 35746
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008BA3 RID: 35747
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04008BA4 RID: 35748
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BA5 RID: 35749
			private static readonly IntPtr NativeMethodInfoPtr__AttemptPack_b__5_0_Internal_Int32_StoredItemData_0;
		}
	}
}
