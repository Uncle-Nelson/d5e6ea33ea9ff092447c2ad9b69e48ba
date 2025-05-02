using System;
using Il2CppFluffyUnderware.Curvy;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Math
{
	// Token: 0x02000379 RID: 889
	public class PathSmoothingUtility : MonoBehaviour
	{
		// Token: 0x060045CC RID: 17868 RVA: 0x001579D4 File Offset: 0x00155BD4
		// Note: this type is marked as 'beforefieldinit'.
		static PathSmoothingUtility()
		{
			Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Math", "PathSmoothingUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr);
			PathSmoothingUtility.NativeFieldInfoPtr_MinControlPointDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, "MinControlPointDistance");
			PathSmoothingUtility.NativeFieldInfoPtr_spline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, "spline");
			PathSmoothingUtility.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, 100671878);
			PathSmoothingUtility.NativeMethodInfoPtr_CalculateSmoothedPath_Public_Static_SmoothedPath_List_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, 100671879);
			PathSmoothingUtility.NativeMethodInfoPtr_DrawPath_Public_Static_Void_SmoothedPath_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, 100671880);
			PathSmoothingUtility.NativeMethodInfoPtr_InsertIntermediatePoints_Private_Static_List_1_Vector3_List_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, 100671881);
			PathSmoothingUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, 100671882);
		}

		// Token: 0x060045CD RID: 17869 RVA: 0x00157A90 File Offset: 0x00155C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157754, XrefRangeEnd = 157772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045CE RID: 17870 RVA: 0x00157AC4 File Offset: 0x00155CC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157821, RefRangeEnd = 157822, XrefRangeStart = 157772, XrefRangeEnd = 157821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PathSmoothingUtility.SmoothedPath CalculateSmoothedPath(List<Vector3> controlPoints, float maxCPDistance = 5f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controlPoints);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCPDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.NativeMethodInfoPtr_CalculateSmoothedPath_Public_Static_SmoothedPath_List_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PathSmoothingUtility.SmoothedPath>(intPtr3) : null;
		}

		// Token: 0x060045CF RID: 17871 RVA: 0x00157B18 File Offset: 0x00155D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157822, XrefRangeEnd = 157833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPath(PathSmoothingUtility.SmoothedPath path, Color col, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.NativeMethodInfoPtr_DrawPath_Public_Static_Void_SmoothedPath_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D0 RID: 17872 RVA: 0x00157B6C File Offset: 0x00155D6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157850, RefRangeEnd = 157851, XrefRangeStart = 157833, XrefRangeEnd = 157850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> InsertIntermediatePoints(List<Vector3> points, float maxDistance)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.NativeMethodInfoPtr_InsertIntermediatePoints_Private_Static_List_1_Vector3_List_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x060045D1 RID: 17873 RVA: 0x00157BC0 File Offset: 0x00155DC0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathSmoothingUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D2 RID: 17874 RVA: 0x00021FF8 File Offset: 0x000201F8
		public PathSmoothingUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x060045D3 RID: 17875 RVA: 0x00157BFC File Offset: 0x00155DFC
		// (set) Token: 0x060045D4 RID: 17876 RVA: 0x00022001 File Offset: 0x00020201
		public unsafe static float MinControlPointDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PathSmoothingUtility.NativeFieldInfoPtr_MinControlPointDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PathSmoothingUtility.NativeFieldInfoPtr_MinControlPointDistance, (void*)(&value));
			}
		}

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x060045D5 RID: 17877 RVA: 0x00157C18 File Offset: 0x00155E18
		// (set) Token: 0x060045D6 RID: 17878 RVA: 0x0002200F File Offset: 0x0002020F
		public unsafe static CurvySpline spline
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PathSmoothingUtility.NativeFieldInfoPtr_spline, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CurvySpline>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PathSmoothingUtility.NativeFieldInfoPtr_spline, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002ED0 RID: 11984
		private static readonly IntPtr NativeFieldInfoPtr_MinControlPointDistance;

		// Token: 0x04002ED1 RID: 11985
		private static readonly IntPtr NativeFieldInfoPtr_spline;

		// Token: 0x04002ED2 RID: 11986
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002ED3 RID: 11987
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSmoothedPath_Public_Static_SmoothedPath_List_1_Vector3_Single_0;

		// Token: 0x04002ED4 RID: 11988
		private static readonly IntPtr NativeMethodInfoPtr_DrawPath_Public_Static_Void_SmoothedPath_Color_Single_0;

		// Token: 0x04002ED5 RID: 11989
		private static readonly IntPtr NativeMethodInfoPtr_InsertIntermediatePoints_Private_Static_List_1_Vector3_List_1_Vector3_Single_0;

		// Token: 0x04002ED6 RID: 11990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000975 RID: 2421
		public class SmoothedPath : Il2CppSystem.Object
		{
			// Token: 0x0600C9B8 RID: 51640 RVA: 0x0030D360 File Offset: 0x0030B560
			// Note: this type is marked as 'beforefieldinit'.
			static SmoothedPath()
			{
				Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, "SmoothedPath");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr);
				PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_MARGIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, "MARGIN");
				PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_vectorPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, "vectorPath");
				PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_segmentBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, "segmentBounds");
				PathSmoothingUtility.SmoothedPath.NativeMethodInfoPtr_InitializePath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, 100671883);
				PathSmoothingUtility.SmoothedPath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, 100671884);
			}

			// Token: 0x0600C9B9 RID: 51641 RVA: 0x0030D3F0 File Offset: 0x0030B5F0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 157736, RefRangeEnd = 157737, XrefRangeStart = 157717, XrefRangeEnd = 157736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void InitializePath()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.SmoothedPath.NativeMethodInfoPtr_InitializePath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9BA RID: 51642 RVA: 0x0030D424 File Offset: 0x0030B624
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 157752, RefRangeEnd = 157754, XrefRangeStart = 157737, XrefRangeEnd = 157752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SmoothedPath() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.SmoothedPath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9BB RID: 51643 RVA: 0x00062185 File Offset: 0x00060385
			public SmoothedPath(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EE4 RID: 16100
			// (get) Token: 0x0600C9BC RID: 51644 RVA: 0x0030D460 File Offset: 0x0030B660
			// (set) Token: 0x0600C9BD RID: 51645 RVA: 0x0006218E File Offset: 0x0006038E
			public unsafe static float MARGIN
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_MARGIN, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_MARGIN, (void*)(&value));
				}
			}

			// Token: 0x17003EE5 RID: 16101
			// (get) Token: 0x0600C9BE RID: 51646 RVA: 0x0030D47C File Offset: 0x0030B67C
			// (set) Token: 0x0600C9BF RID: 51647 RVA: 0x0006219C File Offset: 0x0006039C
			public unsafe List<Vector3> vectorPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_vectorPath);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_vectorPath), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EE6 RID: 16102
			// (get) Token: 0x0600C9C0 RID: 51648 RVA: 0x0030D4AC File Offset: 0x0030B6AC
			// (set) Token: 0x0600C9C1 RID: 51649 RVA: 0x000621BB File Offset: 0x000603BB
			public unsafe List<Bounds> segmentBounds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_segmentBounds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Bounds>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_segmentBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008882 RID: 34946
			private static readonly IntPtr NativeFieldInfoPtr_MARGIN;

			// Token: 0x04008883 RID: 34947
			private static readonly IntPtr NativeFieldInfoPtr_vectorPath;

			// Token: 0x04008884 RID: 34948
			private static readonly IntPtr NativeFieldInfoPtr_segmentBounds;

			// Token: 0x04008885 RID: 34949
			private static readonly IntPtr NativeMethodInfoPtr_InitializePath_Public_Void_0;

			// Token: 0x04008886 RID: 34950
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
