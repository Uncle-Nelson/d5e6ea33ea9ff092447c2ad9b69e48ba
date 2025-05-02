using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200035A RID: 858
	public class FootPatrolRoute : MonoBehaviour
	{
		// Token: 0x060041F1 RID: 16881 RVA: 0x00149EE8 File Offset: 0x001480E8
		// Note: this type is marked as 'beforefieldinit'.
		static FootPatrolRoute()
		{
			Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "FootPatrolRoute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr);
			FootPatrolRoute.NativeFieldInfoPtr_RouteName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, "RouteName");
			FootPatrolRoute.NativeFieldInfoPtr_PathColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, "PathColor");
			FootPatrolRoute.NativeFieldInfoPtr_Waypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, "Waypoints");
			FootPatrolRoute.NativeFieldInfoPtr_StartWaypointIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, "StartWaypointIndex");
			FootPatrolRoute.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, 100671321);
			FootPatrolRoute.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, 100671322);
			FootPatrolRoute.NativeMethodInfoPtr_UpdateWaypoints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, 100671323);
			FootPatrolRoute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, 100671324);
		}

		// Token: 0x060041F2 RID: 16882 RVA: 0x00149FB8 File Offset: 0x001481B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151987, XrefRangeEnd = 152015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolRoute.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x00149FEC File Offset: 0x001481EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152015, XrefRangeEnd = 152026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolRoute.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x0014A020 File Offset: 0x00148220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWaypoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolRoute.NativeMethodInfoPtr_UpdateWaypoints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041F5 RID: 16885 RVA: 0x0014A054 File Offset: 0x00148254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152026, XrefRangeEnd = 152031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootPatrolRoute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolRoute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041F6 RID: 16886 RVA: 0x00020672 File Offset: 0x0001E872
		public FootPatrolRoute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x060041F7 RID: 16887 RVA: 0x0014A090 File Offset: 0x00148290
		// (set) Token: 0x060041F8 RID: 16888 RVA: 0x0002067B File Offset: 0x0001E87B
		public unsafe string RouteName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_RouteName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_RouteName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x060041F9 RID: 16889 RVA: 0x0014A0B8 File Offset: 0x001482B8
		// (set) Token: 0x060041FA RID: 16890 RVA: 0x0002069A File Offset: 0x0001E89A
		public unsafe Color PathColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_PathColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_PathColor)) = value;
			}
		}

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x060041FB RID: 16891 RVA: 0x0014A0E0 File Offset: 0x001482E0
		// (set) Token: 0x060041FC RID: 16892 RVA: 0x000206B5 File Offset: 0x0001E8B5
		public unsafe Il2CppReferenceArray<Transform> Waypoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_Waypoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_Waypoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x060041FD RID: 16893 RVA: 0x0014A110 File Offset: 0x00148310
		// (set) Token: 0x060041FE RID: 16894 RVA: 0x000206D4 File Offset: 0x0001E8D4
		public unsafe int StartWaypointIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_StartWaypointIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_StartWaypointIndex)) = value;
			}
		}

		// Token: 0x04002C11 RID: 11281
		private static readonly IntPtr NativeFieldInfoPtr_RouteName;

		// Token: 0x04002C12 RID: 11282
		private static readonly IntPtr NativeFieldInfoPtr_PathColor;

		// Token: 0x04002C13 RID: 11283
		private static readonly IntPtr NativeFieldInfoPtr_Waypoints;

		// Token: 0x04002C14 RID: 11284
		private static readonly IntPtr NativeFieldInfoPtr_StartWaypointIndex;

		// Token: 0x04002C15 RID: 11285
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04002C16 RID: 11286
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04002C17 RID: 11287
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWaypoints_Private_Void_0;

		// Token: 0x04002C18 RID: 11288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
