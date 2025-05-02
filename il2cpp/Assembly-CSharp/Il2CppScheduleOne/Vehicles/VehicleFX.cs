using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004EC RID: 1260
	public class VehicleFX : MonoBehaviour
	{
		// Token: 0x06006F3D RID: 28477 RVA: 0x001EB08C File Offset: 0x001E928C
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleFX()
		{
			Il2CppClassPointerStore<VehicleFX>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleFX");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr);
			VehicleFX.NativeFieldInfoPtr_exhaustFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr, "exhaustFX");
			VehicleFX.NativeMethodInfoPtr_OnVehicleStart_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr, 100677337);
			VehicleFX.NativeMethodInfoPtr_OnVehicleStop_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr, 100677338);
			VehicleFX.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr, 100677339);
		}

		// Token: 0x06006F3E RID: 28478 RVA: 0x001EB10C File Offset: 0x001E930C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220961, XrefRangeEnd = 220963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnVehicleStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleFX.NativeMethodInfoPtr_OnVehicleStart_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F3F RID: 28479 RVA: 0x001EB148 File Offset: 0x001E9348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220963, XrefRangeEnd = 220965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnVehicleStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleFX.NativeMethodInfoPtr_OnVehicleStop_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F40 RID: 28480 RVA: 0x001EB184 File Offset: 0x001E9384
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleFX() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleFX.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F41 RID: 28481 RVA: 0x00034ABC File Offset: 0x00032CBC
		public VehicleFX(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002189 RID: 8585
		// (get) Token: 0x06006F42 RID: 28482 RVA: 0x001EB1C0 File Offset: 0x001E93C0
		// (set) Token: 0x06006F43 RID: 28483 RVA: 0x00034AC5 File Offset: 0x00032CC5
		public unsafe Il2CppReferenceArray<ParticleSystem> exhaustFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleFX.NativeFieldInfoPtr_exhaustFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleFX.NativeFieldInfoPtr_exhaustFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C0F RID: 19471
		private static readonly IntPtr NativeFieldInfoPtr_exhaustFX;

		// Token: 0x04004C10 RID: 19472
		private static readonly IntPtr NativeMethodInfoPtr_OnVehicleStart_Public_Virtual_New_Void_0;

		// Token: 0x04004C11 RID: 19473
		private static readonly IntPtr NativeMethodInfoPtr_OnVehicleStop_Public_Virtual_New_Void_0;

		// Token: 0x04004C12 RID: 19474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
