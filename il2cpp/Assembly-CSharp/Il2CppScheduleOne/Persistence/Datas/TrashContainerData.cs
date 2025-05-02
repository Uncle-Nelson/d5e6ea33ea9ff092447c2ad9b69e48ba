using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002A5 RID: 677
	public class TrashContainerData : GridItemData
	{
		// Token: 0x0600311A RID: 12570 RVA: 0x0010C7D0 File Offset: 0x0010A9D0
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContainerData()
		{
			Il2CppClassPointerStore<TrashContainerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashContainerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContainerData>.NativeClassPtr);
			TrashContainerData.NativeFieldInfoPtr_ContentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerData>.NativeClassPtr, "ContentData");
			TrashContainerData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerData>.NativeClassPtr, 100668829);
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x0010C828 File Offset: 0x0010AA28
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 130972, RefRangeEnd = 130977, XrefRangeStart = 130972, XrefRangeEnd = 130977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainerData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, TrashContentData contentData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContainerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contentData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x0001A329 File Offset: 0x00018529
		public TrashContainerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x0600311D RID: 12573 RVA: 0x0010C8D4 File Offset: 0x0010AAD4
		// (set) Token: 0x0600311E RID: 12574 RVA: 0x0001A332 File Offset: 0x00018532
		public unsafe TrashContentData ContentData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerData.NativeFieldInfoPtr_ContentData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContentData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerData.NativeFieldInfoPtr_ContentData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002000 RID: 8192
		private static readonly IntPtr NativeFieldInfoPtr_ContentData;

		// Token: 0x04002001 RID: 8193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_TrashContentData_0;
	}
}
