using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200057B RID: 1403
	public class StorageTile : MonoBehaviour
	{
		// Token: 0x06007B84 RID: 31620 RVA: 0x00213DDC File Offset: 0x00211FDC
		// Note: this type is marked as 'beforefieldinit'.
		static StorageTile()
		{
			Il2CppClassPointerStore<StorageTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageTile>.NativeClassPtr);
			StorageTile.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "x");
			StorageTile.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "y");
			StorageTile.NativeFieldInfoPtr_ownerGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "ownerGrid");
			StorageTile.NativeFieldInfoPtr_onOccupantChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "onOccupantChanged");
			StorageTile.NativeFieldInfoPtr__occupant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "<occupant>k__BackingField");
			StorageTile.NativeMethodInfoPtr_get__ownerGrid_Public_get_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100678785);
			StorageTile.NativeMethodInfoPtr_get_occupant_Public_get_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100678786);
			StorageTile.NativeMethodInfoPtr_set_occupant_Protected_set_Void_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100678787);
			StorageTile.NativeMethodInfoPtr_InitializeStorageTile_Public_Void_Int32_Int32_Single_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100678788);
			StorageTile.NativeMethodInfoPtr_SetOccupant_Public_Void_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100678789);
			StorageTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100678790);
		}

		// Token: 0x17002550 RID: 9552
		// (get) Token: 0x06007B85 RID: 31621 RVA: 0x00213EE8 File Offset: 0x002120E8
		public unsafe StorageGrid _ownerGrid
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_get__ownerGrid_Public_get_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorageGrid>(intPtr3) : null;
			}
		}

		// Token: 0x17002551 RID: 9553
		// (get) Token: 0x06007B86 RID: 31622 RVA: 0x00213F28 File Offset: 0x00212128
		// (set) Token: 0x06007B87 RID: 31623 RVA: 0x00213F68 File Offset: 0x00212168
		public unsafe StoredItem occupant
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19660, RefRangeEnd = 19667, XrefRangeStart = 19660, XrefRangeEnd = 19667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_get_occupant_Public_get_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_set_occupant_Protected_set_Void_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007B88 RID: 31624 RVA: 0x00213FAC File Offset: 0x002121AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236513, XrefRangeEnd = 236514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeStorageTile(int _x, int _y, float _available_Offset, StorageGrid _ownerGrid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _available_Offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_ownerGrid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_InitializeStorageTile_Public_Void_Int32_Int32_Single_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B89 RID: 31625 RVA: 0x0021401C File Offset: 0x0021221C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 236528, RefRangeEnd = 236531, XrefRangeStart = 236514, XrefRangeEnd = 236528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOccupant(StoredItem occ)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occ);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_SetOccupant_Public_Void_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B8A RID: 31626 RVA: 0x00214060 File Offset: 0x00212260
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageTile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B8B RID: 31627 RVA: 0x0003A9A2 File Offset: 0x00038BA2
		public StorageTile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700254B RID: 9547
		// (get) Token: 0x06007B8C RID: 31628 RVA: 0x0021409C File Offset: 0x0021229C
		// (set) Token: 0x06007B8D RID: 31629 RVA: 0x0003A9AB File Offset: 0x00038BAB
		public unsafe int x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x1700254C RID: 9548
		// (get) Token: 0x06007B8E RID: 31630 RVA: 0x002140C4 File Offset: 0x002122C4
		// (set) Token: 0x06007B8F RID: 31631 RVA: 0x0003A9C6 File Offset: 0x00038BC6
		public unsafe int y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x1700254D RID: 9549
		// (get) Token: 0x06007B90 RID: 31632 RVA: 0x002140EC File Offset: 0x002122EC
		// (set) Token: 0x06007B91 RID: 31633 RVA: 0x0003A9E1 File Offset: 0x00038BE1
		public unsafe StorageGrid ownerGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_ownerGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageGrid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_ownerGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700254E RID: 9550
		// (get) Token: 0x06007B92 RID: 31634 RVA: 0x0021411C File Offset: 0x0021231C
		// (set) Token: 0x06007B93 RID: 31635 RVA: 0x0003AA00 File Offset: 0x00038C00
		public unsafe Action onOccupantChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_onOccupantChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_onOccupantChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700254F RID: 9551
		// (get) Token: 0x06007B94 RID: 31636 RVA: 0x0021414C File Offset: 0x0021234C
		// (set) Token: 0x06007B95 RID: 31637 RVA: 0x0003AA1F File Offset: 0x00038C1F
		public unsafe StoredItem _occupant_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr__occupant_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr__occupant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400541E RID: 21534
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x0400541F RID: 21535
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04005420 RID: 21536
		private static readonly IntPtr NativeFieldInfoPtr_ownerGrid;

		// Token: 0x04005421 RID: 21537
		private static readonly IntPtr NativeFieldInfoPtr_onOccupantChanged;

		// Token: 0x04005422 RID: 21538
		private static readonly IntPtr NativeFieldInfoPtr__occupant_k__BackingField;

		// Token: 0x04005423 RID: 21539
		private static readonly IntPtr NativeMethodInfoPtr_get__ownerGrid_Public_get_StorageGrid_0;

		// Token: 0x04005424 RID: 21540
		private static readonly IntPtr NativeMethodInfoPtr_get_occupant_Public_get_StoredItem_0;

		// Token: 0x04005425 RID: 21541
		private static readonly IntPtr NativeMethodInfoPtr_set_occupant_Protected_set_Void_StoredItem_0;

		// Token: 0x04005426 RID: 21542
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStorageTile_Public_Void_Int32_Int32_Single_StorageGrid_0;

		// Token: 0x04005427 RID: 21543
		private static readonly IntPtr NativeMethodInfoPtr_SetOccupant_Public_Void_StoredItem_0;

		// Token: 0x04005428 RID: 21544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
