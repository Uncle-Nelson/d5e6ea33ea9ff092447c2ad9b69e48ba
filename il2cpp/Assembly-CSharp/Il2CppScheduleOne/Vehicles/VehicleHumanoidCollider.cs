using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004ED RID: 1261
	public class VehicleHumanoidCollider : MonoBehaviour
	{
		// Token: 0x06006F44 RID: 28484 RVA: 0x001EB1F0 File Offset: 0x001E93F0
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleHumanoidCollider()
		{
			Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleHumanoidCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr);
			VehicleHumanoidCollider.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr, "vehicle");
			VehicleHumanoidCollider.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr, 100677340);
			VehicleHumanoidCollider.NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr, 100677341);
			VehicleHumanoidCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr, 100677342);
		}

		// Token: 0x06006F45 RID: 28485 RVA: 0x001EB270 File Offset: 0x001E9470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220965, XrefRangeEnd = 220970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleHumanoidCollider.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F46 RID: 28486 RVA: 0x001EB2A4 File Offset: 0x001E94A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220970, XrefRangeEnd = 220981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionStay(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleHumanoidCollider.NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F47 RID: 28487 RVA: 0x001EB2E8 File Offset: 0x001E94E8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleHumanoidCollider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleHumanoidCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F48 RID: 28488 RVA: 0x00034AE4 File Offset: 0x00032CE4
		public VehicleHumanoidCollider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700218A RID: 8586
		// (get) Token: 0x06006F49 RID: 28489 RVA: 0x001EB324 File Offset: 0x001E9524
		// (set) Token: 0x06006F4A RID: 28490 RVA: 0x00034AED File Offset: 0x00032CED
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleHumanoidCollider.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleHumanoidCollider.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C13 RID: 19475
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004C14 RID: 19476
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004C15 RID: 19477
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0;

		// Token: 0x04004C16 RID: 19478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
