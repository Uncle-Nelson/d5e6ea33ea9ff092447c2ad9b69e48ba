using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000562 RID: 1378
	public class FilledPackaging_StoredItem : StoredItem
	{
		// Token: 0x060078F2 RID: 30962 RVA: 0x0020A668 File Offset: 0x00208868
		// Note: this type is marked as 'beforefieldinit'.
		static FilledPackaging_StoredItem()
		{
			Il2CppClassPointerStore<FilledPackaging_StoredItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FilledPackaging_StoredItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackaging_StoredItem>.NativeClassPtr);
			FilledPackaging_StoredItem.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackaging_StoredItem>.NativeClassPtr, "Visuals");
			FilledPackaging_StoredItem.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackaging_StoredItem>.NativeClassPtr, 100678460);
			FilledPackaging_StoredItem.NativeMethodInfoPtr_CreateGhostModel_Public_Virtual_GameObject_ItemInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackaging_StoredItem>.NativeClassPtr, 100678461);
			FilledPackaging_StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackaging_StoredItem>.NativeClassPtr, 100678462);
		}

		// Token: 0x060078F3 RID: 30963 RVA: 0x0020A6E8 File Offset: 0x002088E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232902, XrefRangeEnd = 232906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilledPackaging_StoredItem.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078F4 RID: 30964 RVA: 0x0020A764 File Offset: 0x00208964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232906, XrefRangeEnd = 232912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameObject CreateGhostModel(ItemInstance _item, Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilledPackaging_StoredItem.NativeMethodInfoPtr_CreateGhostModel_Public_Virtual_GameObject_ItemInstance_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060078F5 RID: 30965 RVA: 0x0020A7D4 File Offset: 0x002089D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232912, XrefRangeEnd = 232913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilledPackaging_StoredItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackaging_StoredItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackaging_StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078F6 RID: 30966 RVA: 0x00039691 File Offset: 0x00037891
		public FilledPackaging_StoredItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002492 RID: 9362
		// (get) Token: 0x060078F7 RID: 30967 RVA: 0x0020A810 File Offset: 0x00208A10
		// (set) Token: 0x060078F8 RID: 30968 RVA: 0x0003969A File Offset: 0x0003789A
		public unsafe FilledPackagingVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackaging_StoredItem.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackaging_StoredItem.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400525C RID: 21084
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x0400525D RID: 21085
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0;

		// Token: 0x0400525E RID: 21086
		private static readonly IntPtr NativeMethodInfoPtr_CreateGhostModel_Public_Virtual_GameObject_ItemInstance_Transform_0;

		// Token: 0x0400525F RID: 21087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
