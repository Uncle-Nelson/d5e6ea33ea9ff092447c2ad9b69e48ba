using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000368 RID: 872
	public class VehiclePatrolRoute : MonoBehaviour
	{
		// Token: 0x06004405 RID: 17413 RVA: 0x001511A8 File Offset: 0x0014F3A8
		// Note: this type is marked as 'beforefieldinit'.
		static VehiclePatrolRoute()
		{
			Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "VehiclePatrolRoute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr);
			VehiclePatrolRoute.NativeFieldInfoPtr_RouteName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, "RouteName");
			VehiclePatrolRoute.NativeFieldInfoPtr_Waypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, "Waypoints");
			VehiclePatrolRoute.NativeFieldInfoPtr_StartWaypointIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, "StartWaypointIndex");
			VehiclePatrolRoute.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, 100671611);
			VehiclePatrolRoute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, 100671612);
		}

		// Token: 0x06004406 RID: 17414 RVA: 0x0015123C File Offset: 0x0014F43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154684, XrefRangeEnd = 154712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolRoute.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004407 RID: 17415 RVA: 0x00151270 File Offset: 0x0014F470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154712, XrefRangeEnd = 154717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehiclePatrolRoute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolRoute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x000213B1 File Offset: 0x0001F5B1
		public VehiclePatrolRoute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06004409 RID: 17417 RVA: 0x001512AC File Offset: 0x0014F4AC
		// (set) Token: 0x0600440A RID: 17418 RVA: 0x000213BA File Offset: 0x0001F5BA
		public unsafe string RouteName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_RouteName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_RouteName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x0600440B RID: 17419 RVA: 0x001512D4 File Offset: 0x0014F4D4
		// (set) Token: 0x0600440C RID: 17420 RVA: 0x000213D9 File Offset: 0x0001F5D9
		public unsafe Il2CppReferenceArray<Transform> Waypoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_Waypoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_Waypoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x0600440D RID: 17421 RVA: 0x00151304 File Offset: 0x0014F504
		// (set) Token: 0x0600440E RID: 17422 RVA: 0x000213F8 File Offset: 0x0001F5F8
		public unsafe int StartWaypointIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_StartWaypointIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_StartWaypointIndex)) = value;
			}
		}

		// Token: 0x04002D8C RID: 11660
		private static readonly IntPtr NativeFieldInfoPtr_RouteName;

		// Token: 0x04002D8D RID: 11661
		private static readonly IntPtr NativeFieldInfoPtr_Waypoints;

		// Token: 0x04002D8E RID: 11662
		private static readonly IntPtr NativeFieldInfoPtr_StartWaypointIndex;

		// Token: 0x04002D8F RID: 11663
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04002D90 RID: 11664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
