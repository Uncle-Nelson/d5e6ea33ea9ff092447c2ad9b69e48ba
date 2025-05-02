using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004F1 RID: 1265
	public class VehicleObstacle : MonoBehaviour
	{
		// Token: 0x06006FDC RID: 28636 RVA: 0x001ED20C File Offset: 0x001EB40C
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleObstacle()
		{
			Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleObstacle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr);
			VehicleObstacle.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr, "col");
			VehicleObstacle.NativeFieldInfoPtr_twoSided = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr, "twoSided");
			VehicleObstacle.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr, "type");
			VehicleObstacle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr, 100677400);
		}

		// Token: 0x06006FDD RID: 28637 RVA: 0x001ED28C File Offset: 0x001EB48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221505, XrefRangeEnd = 221506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleObstacle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleObstacle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FDE RID: 28638 RVA: 0x00034FFD File Offset: 0x000331FD
		public VehicleObstacle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021BE RID: 8638
		// (get) Token: 0x06006FDF RID: 28639 RVA: 0x001ED2C8 File Offset: 0x001EB4C8
		// (set) Token: 0x06006FE0 RID: 28640 RVA: 0x00035006 File Offset: 0x00033206
		public unsafe Collider col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_col);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021BF RID: 8639
		// (get) Token: 0x06006FE1 RID: 28641 RVA: 0x001ED2F8 File Offset: 0x001EB4F8
		// (set) Token: 0x06006FE2 RID: 28642 RVA: 0x00035025 File Offset: 0x00033225
		public unsafe bool twoSided
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_twoSided);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_twoSided)) = value;
			}
		}

		// Token: 0x170021C0 RID: 8640
		// (get) Token: 0x06006FE3 RID: 28643 RVA: 0x001ED320 File Offset: 0x001EB520
		// (set) Token: 0x06006FE4 RID: 28644 RVA: 0x00035040 File Offset: 0x00033240
		public unsafe VehicleObstacle.EObstacleType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x04004C78 RID: 19576
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04004C79 RID: 19577
		private static readonly IntPtr NativeFieldInfoPtr_twoSided;

		// Token: 0x04004C7A RID: 19578
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04004C7B RID: 19579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A6C RID: 2668
		[OriginalName("Assembly-CSharp.dll", "", "EObstacleType")]
		public enum EObstacleType
		{
			// Token: 0x04008D29 RID: 36137
			Generic,
			// Token: 0x04008D2A RID: 36138
			TrafficLight
		}
	}
}
