using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002A2 RID: 674
	[Serializable]
	public class SurfaceItemData : BuildableItemData
	{
		// Token: 0x06003107 RID: 12551 RVA: 0x0010C3F8 File Offset: 0x0010A5F8
		// Note: this type is marked as 'beforefieldinit'.
		static SurfaceItemData()
		{
			Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "SurfaceItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr);
			SurfaceItemData.NativeFieldInfoPtr_ParentSurfaceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr, "ParentSurfaceGUID");
			SurfaceItemData.NativeFieldInfoPtr_RelativePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr, "RelativePosition");
			SurfaceItemData.NativeFieldInfoPtr_RelativeRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr, "RelativeRotation");
			SurfaceItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr, 100668826);
		}

		// Token: 0x06003108 RID: 12552 RVA: 0x0010C478 File Offset: 0x0010A678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131074, RefRangeEnd = 131075, XrefRangeStart = 131069, XrefRangeEnd = 131074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SurfaceItemData(Guid guid, ItemInstance item, int loadOrder, string parentSurfaceGUID, Vector3 pos, Quaternion rot) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003109 RID: 12553 RVA: 0x0001A283 File Offset: 0x00018483
		public SurfaceItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x0600310A RID: 12554 RVA: 0x0010C510 File Offset: 0x0010A710
		// (set) Token: 0x0600310B RID: 12555 RVA: 0x0001A28C File Offset: 0x0001848C
		public unsafe string ParentSurfaceGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_ParentSurfaceGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_ParentSurfaceGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x0600310C RID: 12556 RVA: 0x0010C538 File Offset: 0x0010A738
		// (set) Token: 0x0600310D RID: 12557 RVA: 0x0001A2AB File Offset: 0x000184AB
		public unsafe Vector3 RelativePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_RelativePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_RelativePosition)) = value;
			}
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x0600310E RID: 12558 RVA: 0x0010C560 File Offset: 0x0010A760
		// (set) Token: 0x0600310F RID: 12559 RVA: 0x0001A2C6 File Offset: 0x000184C6
		public unsafe Quaternion RelativeRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_RelativeRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_RelativeRotation)) = value;
			}
		}

		// Token: 0x04001FF8 RID: 8184
		private static readonly IntPtr NativeFieldInfoPtr_ParentSurfaceGUID;

		// Token: 0x04001FF9 RID: 8185
		private static readonly IntPtr NativeFieldInfoPtr_RelativePosition;

		// Token: 0x04001FFA RID: 8186
		private static readonly IntPtr NativeFieldInfoPtr_RelativeRotation;

		// Token: 0x04001FFB RID: 8187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_0;
	}
}
