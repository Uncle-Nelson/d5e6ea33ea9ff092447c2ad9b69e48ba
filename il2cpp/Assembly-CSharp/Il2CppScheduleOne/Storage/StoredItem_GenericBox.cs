using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000581 RID: 1409
	public class StoredItem_GenericBox : StoredItem
	{
		// Token: 0x06007C07 RID: 31751 RVA: 0x00215980 File Offset: 0x00213B80
		// Note: this type is marked as 'beforefieldinit'.
		static StoredItem_GenericBox()
		{
			Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StoredItem_GenericBox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr);
			StoredItem_GenericBox.NativeFieldInfoPtr_ReferenceIconWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, "ReferenceIconWidth");
			StoredItem_GenericBox.NativeFieldInfoPtr_icon1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, "icon1");
			StoredItem_GenericBox.NativeFieldInfoPtr_icon2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, "icon2");
			StoredItem_GenericBox.NativeFieldInfoPtr_IconScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, "IconScale");
			StoredItem_GenericBox.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, 100678847);
			StoredItem_GenericBox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, 100678848);
		}

		// Token: 0x06007C08 RID: 31752 RVA: 0x00215A28 File Offset: 0x00213C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237293, XrefRangeEnd = 237301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem_GenericBox.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C09 RID: 31753 RVA: 0x00215AA4 File Offset: 0x00213CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237301, XrefRangeEnd = 237302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItem_GenericBox() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem_GenericBox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C0A RID: 31754 RVA: 0x0003ADB0 File Offset: 0x00038FB0
		public StoredItem_GenericBox(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002578 RID: 9592
		// (get) Token: 0x06007C0B RID: 31755 RVA: 0x00215AE0 File Offset: 0x00213CE0
		// (set) Token: 0x06007C0C RID: 31756 RVA: 0x0003ADB9 File Offset: 0x00038FB9
		public unsafe static float ReferenceIconWidth
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StoredItem_GenericBox.NativeFieldInfoPtr_ReferenceIconWidth, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StoredItem_GenericBox.NativeFieldInfoPtr_ReferenceIconWidth, (void*)(&value));
			}
		}

		// Token: 0x17002579 RID: 9593
		// (get) Token: 0x06007C0D RID: 31757 RVA: 0x00215AFC File Offset: 0x00213CFC
		// (set) Token: 0x06007C0E RID: 31758 RVA: 0x0003ADC7 File Offset: 0x00038FC7
		public unsafe SpriteRenderer icon1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_icon1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_icon1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700257A RID: 9594
		// (get) Token: 0x06007C0F RID: 31759 RVA: 0x00215B2C File Offset: 0x00213D2C
		// (set) Token: 0x06007C10 RID: 31760 RVA: 0x0003ADE6 File Offset: 0x00038FE6
		public unsafe SpriteRenderer icon2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_icon2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_icon2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700257B RID: 9595
		// (get) Token: 0x06007C11 RID: 31761 RVA: 0x00215B5C File Offset: 0x00213D5C
		// (set) Token: 0x06007C12 RID: 31762 RVA: 0x0003AE05 File Offset: 0x00039005
		public unsafe float IconScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_IconScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_IconScale)) = value;
			}
		}

		// Token: 0x04005475 RID: 21621
		private static readonly IntPtr NativeFieldInfoPtr_ReferenceIconWidth;

		// Token: 0x04005476 RID: 21622
		private static readonly IntPtr NativeFieldInfoPtr_icon1;

		// Token: 0x04005477 RID: 21623
		private static readonly IntPtr NativeFieldInfoPtr_icon2;

		// Token: 0x04005478 RID: 21624
		private static readonly IntPtr NativeFieldInfoPtr_IconScale;

		// Token: 0x04005479 RID: 21625
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0;

		// Token: 0x0400547A RID: 21626
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
