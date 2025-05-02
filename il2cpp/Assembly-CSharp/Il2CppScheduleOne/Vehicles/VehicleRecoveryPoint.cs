using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004F2 RID: 1266
	public class VehicleRecoveryPoint : MonoBehaviour
	{
		// Token: 0x06006FE5 RID: 28645 RVA: 0x001ED348 File Offset: 0x001EB548
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleRecoveryPoint()
		{
			Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleRecoveryPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr);
			VehicleRecoveryPoint.NativeFieldInfoPtr_recoveryPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr, "recoveryPoints");
			VehicleRecoveryPoint.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr, 100677401);
			VehicleRecoveryPoint.NativeMethodInfoPtr_GetClosestRecoveryPoint_Public_Static_VehicleRecoveryPoint_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr, 100677402);
			VehicleRecoveryPoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr, 100677403);
		}

		// Token: 0x06006FE6 RID: 28646 RVA: 0x001ED3C8 File Offset: 0x001EB5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221506, XrefRangeEnd = 221516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleRecoveryPoint.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FE7 RID: 28647 RVA: 0x001ED404 File Offset: 0x001EB604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221543, RefRangeEnd = 221544, XrefRangeStart = 221516, XrefRangeEnd = 221543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VehicleRecoveryPoint GetClosestRecoveryPoint(Vector3 pos)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleRecoveryPoint.NativeMethodInfoPtr_GetClosestRecoveryPoint_Public_Static_VehicleRecoveryPoint_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VehicleRecoveryPoint>(intPtr3) : null;
		}

		// Token: 0x06006FE8 RID: 28648 RVA: 0x001ED444 File Offset: 0x001EB644
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleRecoveryPoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleRecoveryPoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FE9 RID: 28649 RVA: 0x0003505B File Offset: 0x0003325B
		public VehicleRecoveryPoint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021C1 RID: 8641
		// (get) Token: 0x06006FEA RID: 28650 RVA: 0x001ED480 File Offset: 0x001EB680
		// (set) Token: 0x06006FEB RID: 28651 RVA: 0x00035064 File Offset: 0x00033264
		public unsafe static List<VehicleRecoveryPoint> recoveryPoints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VehicleRecoveryPoint.NativeFieldInfoPtr_recoveryPoints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleRecoveryPoint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleRecoveryPoint.NativeFieldInfoPtr_recoveryPoints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C7C RID: 19580
		private static readonly IntPtr NativeFieldInfoPtr_recoveryPoints;

		// Token: 0x04004C7D RID: 19581
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004C7E RID: 19582
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestRecoveryPoint_Public_Static_VehicleRecoveryPoint_Vector3_0;

		// Token: 0x04004C7F RID: 19583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
