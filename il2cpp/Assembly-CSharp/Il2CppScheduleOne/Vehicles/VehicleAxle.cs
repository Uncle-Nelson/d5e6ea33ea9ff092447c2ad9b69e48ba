using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004E9 RID: 1257
	public class VehicleAxle : MonoBehaviour
	{
		// Token: 0x06006EF9 RID: 28409 RVA: 0x001EA580 File Offset: 0x001E8780
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleAxle()
		{
			Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleAxle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr);
			VehicleAxle.NativeFieldInfoPtr_wheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr, "wheel");
			VehicleAxle.NativeFieldInfoPtr_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr, "model");
			VehicleAxle.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr, 100677321);
			VehicleAxle.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr, 100677322);
			VehicleAxle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr, 100677323);
		}

		// Token: 0x06006EFA RID: 28410 RVA: 0x001EA614 File Offset: 0x001E8814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220638, XrefRangeEnd = 220644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAxle.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EFB RID: 28411 RVA: 0x001EA650 File Offset: 0x001E8850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220644, XrefRangeEnd = 220662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAxle.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EFC RID: 28412 RVA: 0x001EA68C File Offset: 0x001E888C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleAxle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAxle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EFD RID: 28413 RVA: 0x00034873 File Offset: 0x00032A73
		public VehicleAxle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002171 RID: 8561
		// (get) Token: 0x06006EFE RID: 28414 RVA: 0x001EA6C8 File Offset: 0x001E88C8
		// (set) Token: 0x06006EFF RID: 28415 RVA: 0x0003487C File Offset: 0x00032A7C
		public unsafe Wheel wheel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAxle.NativeFieldInfoPtr_wheel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Wheel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAxle.NativeFieldInfoPtr_wheel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002172 RID: 8562
		// (get) Token: 0x06006F00 RID: 28416 RVA: 0x001EA6F8 File Offset: 0x001E88F8
		// (set) Token: 0x06006F01 RID: 28417 RVA: 0x0003489B File Offset: 0x00032A9B
		public unsafe Transform model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAxle.NativeFieldInfoPtr_model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAxle.NativeFieldInfoPtr_model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004BE8 RID: 19432
		private static readonly IntPtr NativeFieldInfoPtr_wheel;

		// Token: 0x04004BE9 RID: 19433
		private static readonly IntPtr NativeFieldInfoPtr_model;

		// Token: 0x04004BEA RID: 19434
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004BEB RID: 19435
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004BEC RID: 19436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
