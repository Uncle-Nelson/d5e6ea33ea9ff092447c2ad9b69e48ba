using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000298 RID: 664
	[Serializable]
	public class GridItemData : BuildableItemData
	{
		// Token: 0x060030B1 RID: 12465 RVA: 0x0010B2DC File Offset: 0x001094DC
		// Note: this type is marked as 'beforefieldinit'.
		static GridItemData()
		{
			Il2CppClassPointerStore<GridItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GridItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridItemData>.NativeClassPtr);
			GridItemData.NativeFieldInfoPtr_GridGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItemData>.NativeClassPtr, "GridGUID");
			GridItemData.NativeFieldInfoPtr_OriginCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItemData>.NativeClassPtr, "OriginCoordinate");
			GridItemData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItemData>.NativeClassPtr, "Rotation");
			GridItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItemData>.NativeClassPtr, 100668816);
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x0010B35C File Offset: 0x0010955C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131019, RefRangeEnd = 131020, XrefRangeStart = 131013, XrefRangeEnd = 131019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GridItemData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x00019EED File Offset: 0x000180ED
		public GridItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x060030B4 RID: 12468 RVA: 0x0010B3F4 File Offset: 0x001095F4
		// (set) Token: 0x060030B5 RID: 12469 RVA: 0x00019EF6 File Offset: 0x000180F6
		public unsafe string GridGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_GridGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_GridGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x060030B6 RID: 12470 RVA: 0x0010B41C File Offset: 0x0010961C
		// (set) Token: 0x060030B7 RID: 12471 RVA: 0x00019F15 File Offset: 0x00018115
		public unsafe Vector2 OriginCoordinate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_OriginCoordinate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_OriginCoordinate)) = value;
			}
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x060030B8 RID: 12472 RVA: 0x0010B444 File Offset: 0x00109644
		// (set) Token: 0x060030B9 RID: 12473 RVA: 0x00019F30 File Offset: 0x00018130
		public unsafe int Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x04001FD2 RID: 8146
		private static readonly IntPtr NativeFieldInfoPtr_GridGUID;

		// Token: 0x04001FD3 RID: 8147
		private static readonly IntPtr NativeFieldInfoPtr_OriginCoordinate;

		// Token: 0x04001FD4 RID: 8148
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04001FD5 RID: 8149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_0;
	}
}
