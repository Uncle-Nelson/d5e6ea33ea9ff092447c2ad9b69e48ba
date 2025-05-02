using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Math;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000504 RID: 1284
	public static class PathUtility : Il2CppSystem.Object
	{
		// Token: 0x0600710C RID: 28940 RVA: 0x001F04BC File Offset: 0x001EE6BC
		// Note: this type is marked as 'beforefieldinit'.
		static PathUtility()
		{
			Il2CppClassPointerStore<PathUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "PathUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathUtility>.NativeClassPtr);
			PathUtility.NativeMethodInfoPtr_GetAverageAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677516);
			PathUtility.NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677517);
			PathUtility.NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677518);
			PathUtility.NativeMethodInfoPtr_GetPointAheadOfPathPoint_Public_Static_Vector3_SmoothedPath_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677519);
			PathUtility.NativeMethodInfoPtr_CalculateAngleChangeOverPath_Public_Static_Single_SmoothedPath_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677520);
			PathUtility.NativeMethodInfoPtr_CalculateCTE_Public_Static_Single_Vector3_Transform_Vector3_Vector3_SmoothedPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677521);
			PathUtility.NativeMethodInfoPtr_GetClosestPointOnPath_Public_Static_Vector3_SmoothedPath_Vector3_byref_Int32_byref_Int32_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677522);
			PathUtility.NativeMethodInfoPtr_GetAheadPointDirection_Public_Static_Vector3_SmoothedPath_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677523);
			PathUtility.NativeMethodInfoPtr_GetClosestPointOnLine_Private_Static_Vector3_Vector3_Vector3_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677524);
		}

		// Token: 0x0600710D RID: 28941 RVA: 0x001F05A0 File Offset: 0x001EE7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222383, XrefRangeEnd = 222387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetAverageAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, int sampleCount, float stepSize)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref referencePoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sampleCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stepSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetAverageAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600710E RID: 28942 RVA: 0x001F060C File Offset: 0x001EE80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222387, XrefRangeEnd = 222389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distance)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref referencePoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600710F RID: 28943 RVA: 0x001F066C File Offset: 0x001EE86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222389, XrefRangeEnd = 222390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distance, int startPointIndex, float pointLerp)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref referencePoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPointIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointLerp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007110 RID: 28944 RVA: 0x001F06E8 File Offset: 0x001EE8E8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 222418, RefRangeEnd = 222429, XrefRangeStart = 222390, XrefRangeEnd = 222418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetPointAheadOfPathPoint(PathSmoothingUtility.SmoothedPath path, int startPointIndex, float pointLerp, float distanceAhead)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPointIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointLerp;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceAhead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetPointAheadOfPathPoint_Public_Static_Vector3_SmoothedPath_Int32_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007111 RID: 28945 RVA: 0x001F0754 File Offset: 0x001EE954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222429, XrefRangeEnd = 222446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CalculateAngleChangeOverPath(PathSmoothingUtility.SmoothedPath path, int startPointIndex, float pointLerp, float distanceAhead)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPointIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointLerp;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceAhead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_CalculateAngleChangeOverPath_Public_Static_Single_SmoothedPath_Int32_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007112 RID: 28946 RVA: 0x001F07C0 File Offset: 0x001EE9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222446, XrefRangeEnd = 222454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CalculateCTE(Vector3 flatCarPos, Transform vehicleTransform, Vector3 wp_from, Vector3 wp_to, PathSmoothingUtility.SmoothedPath path)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref flatCarPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicleTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wp_from;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wp_to;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_CalculateCTE_Public_Static_Single_Vector3_Transform_Vector3_Vector3_SmoothedPath_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007113 RID: 28947 RVA: 0x001F0840 File Offset: 0x001EEA40
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 222473, RefRangeEnd = 222486, XrefRangeStart = 222454, XrefRangeEnd = 222473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetClosestPointOnPath(PathSmoothingUtility.SmoothedPath path, Vector3 point, out int startPointIndex, out int endPointIndex, out float pointLerp)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &startPointIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &endPointIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pointLerp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetClosestPointOnPath_Public_Static_Vector3_SmoothedPath_Vector3_byref_Int32_byref_Int32_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007114 RID: 28948 RVA: 0x001F08BC File Offset: 0x001EEABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222486, XrefRangeEnd = 222490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetAheadPointDirection(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distanceAhead)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref referencePoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceAhead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetAheadPointDirection_Public_Static_Vector3_SmoothedPath_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007115 RID: 28949 RVA: 0x001F091C File Offset: 0x001EEB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222490, XrefRangeEnd = 222494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetClosestPointOnLine(Vector3 point, Vector3 line_start, Vector3 line_end, bool clamp = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line_start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line_end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clamp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetClosestPointOnLine_Private_Static_Vector3_Vector3_Vector3_Vector3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007116 RID: 28950 RVA: 0x00035B32 File Offset: 0x00033D32
		public PathUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004D34 RID: 19764
		private static readonly IntPtr NativeMethodInfoPtr_GetAverageAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Int32_Single_0;

		// Token: 0x04004D35 RID: 19765
		private static readonly IntPtr NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_0;

		// Token: 0x04004D36 RID: 19766
		private static readonly IntPtr NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_Int32_Single_0;

		// Token: 0x04004D37 RID: 19767
		private static readonly IntPtr NativeMethodInfoPtr_GetPointAheadOfPathPoint_Public_Static_Vector3_SmoothedPath_Int32_Single_Single_0;

		// Token: 0x04004D38 RID: 19768
		private static readonly IntPtr NativeMethodInfoPtr_CalculateAngleChangeOverPath_Public_Static_Single_SmoothedPath_Int32_Single_Single_0;

		// Token: 0x04004D39 RID: 19769
		private static readonly IntPtr NativeMethodInfoPtr_CalculateCTE_Public_Static_Single_Vector3_Transform_Vector3_Vector3_SmoothedPath_0;

		// Token: 0x04004D3A RID: 19770
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPointOnPath_Public_Static_Vector3_SmoothedPath_Vector3_byref_Int32_byref_Int32_byref_Single_0;

		// Token: 0x04004D3B RID: 19771
		private static readonly IntPtr NativeMethodInfoPtr_GetAheadPointDirection_Public_Static_Vector3_SmoothedPath_Vector3_Single_0;

		// Token: 0x04004D3C RID: 19772
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPointOnLine_Private_Static_Vector3_Vector3_Vector3_Vector3_Boolean_0;
	}
}
