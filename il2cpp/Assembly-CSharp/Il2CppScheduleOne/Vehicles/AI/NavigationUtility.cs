using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppPathfinding;
using Il2CppScheduleOne.Math;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020004FF RID: 1279
	public class NavigationUtility : Il2CppSystem.Object
	{
		// Token: 0x060070E3 RID: 28899 RVA: 0x001EFC84 File Offset: 0x001EDE84
		// Note: this type is marked as 'beforefieldinit'.
		static NavigationUtility()
		{
			Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "NavigationUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr);
			NavigationUtility.NativeFieldInfoPtr_ROAD_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "ROAD_MULTIPLIER");
			NavigationUtility.NativeFieldInfoPtr_OFFROAD_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "OFFROAD_MULTIPLIER");
			NavigationUtility.NativeMethodInfoPtr_CalculatePath_Public_Static_Coroutine_Vector3_Vector3_NavigationSettings_DriveFlags_Seeker_Seeker_NavigationCalculationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677468);
			NavigationUtility.NativeMethodInfoPtr_AdjustExitPoint_Private_Static_Void_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677469);
			NavigationUtility.NativeMethodInfoPtr_AdjustEntryPoint_Private_Static_Void_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677470);
			NavigationUtility.NativeMethodInfoPtr_DoesCloseDistanceExist_Private_Static_Boolean_List_1_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677471);
			NavigationUtility.NativeMethodInfoPtr_GenerateNavigationGroup_Private_Static_IEnumerator_Vector3_Vector3_NodeLink_Vector3_Vector3_Seeker_Seeker_PathGroupEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677472);
			NavigationUtility.NativeMethodInfoPtr_DrawPath_Public_Static_Void_PathGroup_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677473);
			NavigationUtility.NativeMethodInfoPtr_GetSmoothedPath_Private_Static_SmoothedPath_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677474);
			NavigationUtility.NativeMethodInfoPtr_SampleVehicleGraph_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677475);
			NavigationUtility.NativeMethodInfoPtr_GetClosestPointOnFiniteLine_Public_Static_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677476);
			NavigationUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677477);
		}

		// Token: 0x060070E4 RID: 28900 RVA: 0x001EFDA4 File Offset: 0x001EDFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222202, XrefRangeEnd = 222222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coroutine CalculatePath(Vector3 startPosition, Vector3 destination, NavigationSettings navSettings, DriveFlags flags, Seeker generalSeeker, Seeker roadSeeker, NavigationUtility.NavigationCalculationCallback callback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(navSettings);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flags);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generalSeeker);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(roadSeeker);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_CalculatePath_Public_Static_Coroutine_Vector3_Vector3_NavigationSettings_DriveFlags_Seeker_Seeker_NavigationCalculationCallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x060070E5 RID: 28901 RVA: 0x001EFE50 File Offset: 0x001EE050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222222, XrefRangeEnd = 222258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AdjustExitPoint(PathGroup group)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_AdjustExitPoint_Private_Static_Void_PathGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070E6 RID: 28902 RVA: 0x001EFE88 File Offset: 0x001EE088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222258, XrefRangeEnd = 222277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AdjustEntryPoint(PathGroup group)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_AdjustEntryPoint_Private_Static_Void_PathGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070E7 RID: 28903 RVA: 0x001EFEC0 File Offset: 0x001EE0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222277, XrefRangeEnd = 222292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoesCloseDistanceExist(List<Vector3> vectorList, Vector3 point, float thresholdDistance)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vectorList);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref thresholdDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_DoesCloseDistanceExist_Private_Static_Boolean_List_1_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060070E8 RID: 28904 RVA: 0x001EFF20 File Offset: 0x001EE120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222292, XrefRangeEnd = 222300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator GenerateNavigationGroup(Vector3 startPoint, Vector3 entryPoint, NodeLink exitLink, Vector3 exitPoint, Vector3 destination, Seeker generalSeeker, Seeker roadSeeker, NavigationUtility.PathGroupEvent callback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitLink);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitPoint;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generalSeeker);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(roadSeeker);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_GenerateNavigationGroup_Private_Static_IEnumerator_Vector3_Vector3_NodeLink_Vector3_Vector3_Seeker_Seeker_PathGroupEvent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060070E9 RID: 28905 RVA: 0x001EFFD8 File Offset: 0x001EE1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222300, XrefRangeEnd = 222334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPath(PathGroup group, float duration = 10f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_DrawPath_Public_Static_Void_PathGroup_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070EA RID: 28906 RVA: 0x001F001C File Offset: 0x001EE21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222334, XrefRangeEnd = 222349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PathSmoothingUtility.SmoothedPath GetSmoothedPath(PathGroup group)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_GetSmoothedPath_Private_Static_SmoothedPath_PathGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PathSmoothingUtility.SmoothedPath>(intPtr3) : null;
		}

		// Token: 0x060070EB RID: 28907 RVA: 0x001F0060 File Offset: 0x001EE260
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 222361, RefRangeEnd = 222363, XrefRangeStart = 222349, XrefRangeEnd = 222361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SampleVehicleGraph(Vector3 destination)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref destination;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_SampleVehicleGraph_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060070EC RID: 28908 RVA: 0x001F00A0 File Offset: 0x001EE2A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222366, RefRangeEnd = 222367, XrefRangeStart = 222363, XrefRangeEnd = 222366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetClosestPointOnFiniteLine(Vector3 point, Vector3 line_start, Vector3 line_end)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line_start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line_end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_GetClosestPointOnFiniteLine_Public_Static_Vector3_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060070ED RID: 28909 RVA: 0x001F00FC File Offset: 0x001EE2FC
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigationUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070EE RID: 28910 RVA: 0x000359F3 File Offset: 0x00033BF3
		public NavigationUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002220 RID: 8736
		// (get) Token: 0x060070EF RID: 28911 RVA: 0x001F0138 File Offset: 0x001EE338
		// (set) Token: 0x060070F0 RID: 28912 RVA: 0x000359FC File Offset: 0x00033BFC
		public unsafe static float ROAD_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavigationUtility.NativeFieldInfoPtr_ROAD_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavigationUtility.NativeFieldInfoPtr_ROAD_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002221 RID: 8737
		// (get) Token: 0x060070F1 RID: 28913 RVA: 0x001F0154 File Offset: 0x001EE354
		// (set) Token: 0x060070F2 RID: 28914 RVA: 0x00035A0A File Offset: 0x00033C0A
		public unsafe static float OFFROAD_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavigationUtility.NativeFieldInfoPtr_OFFROAD_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavigationUtility.NativeFieldInfoPtr_OFFROAD_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x04004D1E RID: 19742
		private static readonly IntPtr NativeFieldInfoPtr_ROAD_MULTIPLIER;

		// Token: 0x04004D1F RID: 19743
		private static readonly IntPtr NativeFieldInfoPtr_OFFROAD_MULTIPLIER;

		// Token: 0x04004D20 RID: 19744
		private static readonly IntPtr NativeMethodInfoPtr_CalculatePath_Public_Static_Coroutine_Vector3_Vector3_NavigationSettings_DriveFlags_Seeker_Seeker_NavigationCalculationCallback_0;

		// Token: 0x04004D21 RID: 19745
		private static readonly IntPtr NativeMethodInfoPtr_AdjustExitPoint_Private_Static_Void_PathGroup_0;

		// Token: 0x04004D22 RID: 19746
		private static readonly IntPtr NativeMethodInfoPtr_AdjustEntryPoint_Private_Static_Void_PathGroup_0;

		// Token: 0x04004D23 RID: 19747
		private static readonly IntPtr NativeMethodInfoPtr_DoesCloseDistanceExist_Private_Static_Boolean_List_1_Vector3_Vector3_Single_0;

		// Token: 0x04004D24 RID: 19748
		private static readonly IntPtr NativeMethodInfoPtr_GenerateNavigationGroup_Private_Static_IEnumerator_Vector3_Vector3_NodeLink_Vector3_Vector3_Seeker_Seeker_PathGroupEvent_0;

		// Token: 0x04004D25 RID: 19749
		private static readonly IntPtr NativeMethodInfoPtr_DrawPath_Public_Static_Void_PathGroup_Single_0;

		// Token: 0x04004D26 RID: 19750
		private static readonly IntPtr NativeMethodInfoPtr_GetSmoothedPath_Private_Static_SmoothedPath_PathGroup_0;

		// Token: 0x04004D27 RID: 19751
		private static readonly IntPtr NativeMethodInfoPtr_SampleVehicleGraph_Public_Static_Vector3_Vector3_0;

		// Token: 0x04004D28 RID: 19752
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPointOnFiniteLine_Public_Static_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x04004D29 RID: 19753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A72 RID: 2674
		[OriginalName("Assembly-CSharp.dll", "", "ENavigationCalculationResult")]
		public enum ENavigationCalculationResult
		{
			// Token: 0x04008D3E RID: 36158
			Success,
			// Token: 0x04008D3F RID: 36159
			Failed
		}

		// Token: 0x02000A73 RID: 2675
		public sealed class NavigationCalculationCallback : MulticastDelegate
		{
			// Token: 0x0600D158 RID: 53592 RVA: 0x003225DC File Offset: 0x003207DC
			// Note: this type is marked as 'beforefieldinit'.
			static NavigationCalculationCallback()
			{
				Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "NavigationCalculationCallback");
				NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr, 100677478);
				NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationCalculationResult_SmoothedPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr, 100677479);
				NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationCalculationResult_SmoothedPath_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr, 100677480);
				NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr, 100677481);
			}

			// Token: 0x0600D159 RID: 53593 RVA: 0x00322650 File Offset: 0x00320850
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 222035, RefRangeEnd = 222054, XrefRangeStart = 222032, XrefRangeEnd = 222035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NavigationCalculationCallback(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D15A RID: 53594 RVA: 0x003226AC File Offset: 0x003208AC
			[CallerCount(0)]
			public unsafe void Invoke(NavigationUtility.ENavigationCalculationResult result, PathSmoothingUtility.SmoothedPath path)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationCalculationResult_SmoothedPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D15B RID: 53595 RVA: 0x003226FC File Offset: 0x003208FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222054, XrefRangeEnd = 222058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(NavigationUtility.ENavigationCalculationResult result, PathSmoothingUtility.SmoothedPath path, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationCalculationResult_SmoothedPath_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D15C RID: 53596 RVA: 0x00322780 File Offset: 0x00320980
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D15D RID: 53597 RVA: 0x00065EBB File Offset: 0x000640BB
			public NavigationCalculationCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D15E RID: 53598 RVA: 0x00065EC4 File Offset: 0x000640C4
			public static implicit operator NavigationUtility.NavigationCalculationCallback(Action<NavigationUtility.ENavigationCalculationResult, PathSmoothingUtility.SmoothedPath> A_0)
			{
				return DelegateSupport.ConvertDelegate<NavigationUtility.NavigationCalculationCallback>(A_0);
			}

			// Token: 0x0600D15F RID: 53599 RVA: 0x00065ECC File Offset: 0x000640CC
			public static NavigationUtility.NavigationCalculationCallback operator +(NavigationUtility.NavigationCalculationCallback A_0, NavigationUtility.NavigationCalculationCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<NavigationUtility.NavigationCalculationCallback>();
			}

			// Token: 0x0600D160 RID: 53600 RVA: 0x00065EDA File Offset: 0x000640DA
			public static NavigationUtility.NavigationCalculationCallback operator -(NavigationUtility.NavigationCalculationCallback A_0, NavigationUtility.NavigationCalculationCallback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<NavigationUtility.NavigationCalculationCallback>();
				}
				return result;
			}

			// Token: 0x04008D40 RID: 36160
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008D41 RID: 36161
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationCalculationResult_SmoothedPath_0;

			// Token: 0x04008D42 RID: 36162
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationCalculationResult_SmoothedPath_AsyncCallback_Object_0;

			// Token: 0x04008D43 RID: 36163
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000A74 RID: 2676
		public sealed class PathGroupEvent : MulticastDelegate
		{
			// Token: 0x0600D161 RID: 53601 RVA: 0x003227C4 File Offset: 0x003209C4
			// Note: this type is marked as 'beforefieldinit'.
			static PathGroupEvent()
			{
				Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "PathGroupEvent");
				NavigationUtility.PathGroupEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr, 100677482);
				NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr, 100677483);
				NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PathGroup_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr, 100677484);
				NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr, 100677485);
			}

			// Token: 0x0600D162 RID: 53602 RVA: 0x00322838 File Offset: 0x00320A38
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 106479, RefRangeEnd = 106558, XrefRangeStart = 106479, XrefRangeEnd = 106558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PathGroupEvent(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.PathGroupEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D163 RID: 53603 RVA: 0x00322894 File Offset: 0x00320A94
			[CallerCount(0)]
			public unsafe void Invoke(PathGroup calculatedGroup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(calculatedGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PathGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D164 RID: 53604 RVA: 0x003228D8 File Offset: 0x00320AD8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74827, RefRangeEnd = 74828, XrefRangeStart = 74827, XrefRangeEnd = 74828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(PathGroup calculatedGroup, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(calculatedGroup);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PathGroup_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D165 RID: 53605 RVA: 0x0032294C File Offset: 0x00320B4C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D166 RID: 53606 RVA: 0x00065EEB File Offset: 0x000640EB
			public PathGroupEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D167 RID: 53607 RVA: 0x00065EF4 File Offset: 0x000640F4
			public static implicit operator NavigationUtility.PathGroupEvent(Action<PathGroup> A_0)
			{
				return DelegateSupport.ConvertDelegate<NavigationUtility.PathGroupEvent>(A_0);
			}

			// Token: 0x0600D168 RID: 53608 RVA: 0x00065EFC File Offset: 0x000640FC
			public static NavigationUtility.PathGroupEvent operator +(NavigationUtility.PathGroupEvent A_0, NavigationUtility.PathGroupEvent A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<NavigationUtility.PathGroupEvent>();
			}

			// Token: 0x0600D169 RID: 53609 RVA: 0x00065F0A File Offset: 0x0006410A
			public static NavigationUtility.PathGroupEvent operator -(NavigationUtility.PathGroupEvent A_0, NavigationUtility.PathGroupEvent A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<NavigationUtility.PathGroupEvent>();
				}
				return result;
			}

			// Token: 0x04008D44 RID: 36164
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008D45 RID: 36165
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PathGroup_0;

			// Token: 0x04008D46 RID: 36166
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PathGroup_AsyncCallback_Object_0;

			// Token: 0x04008D47 RID: 36167
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000A75 RID: 2677
		[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D16A RID: 53610 RVA: 0x00322990 File Offset: 0x00320B90
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr);
				NavigationUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr, "<>9");
				NavigationUtility.__c.NativeFieldInfoPtr___9__5_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr, "<>9__5_5");
				NavigationUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr, 100677487);
				NavigationUtility.__c.NativeMethodInfoPtr__CalculatePath_b__5_5_Internal_Single_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr, 100677488);
			}

			// Token: 0x0600D16B RID: 53611 RVA: 0x00322A0C File Offset: 0x00320C0C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D16C RID: 53612 RVA: 0x00322A48 File Offset: 0x00320C48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222058, XrefRangeEnd = 222063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _CalculatePath_b__5_5(PathGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c.NativeMethodInfoPtr__CalculatePath_b__5_5_Internal_Single_PathGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D16D RID: 53613 RVA: 0x00065F1B File Offset: 0x0006411B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040FF RID: 16639
			// (get) Token: 0x0600D16E RID: 53614 RVA: 0x00322A98 File Offset: 0x00320C98
			// (set) Token: 0x0600D16F RID: 53615 RVA: 0x00065F24 File Offset: 0x00064124
			public unsafe static NavigationUtility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NavigationUtility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NavigationUtility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004100 RID: 16640
			// (get) Token: 0x0600D170 RID: 53616 RVA: 0x00322AC0 File Offset: 0x00320CC0
			// (set) Token: 0x0600D171 RID: 53617 RVA: 0x00065F36 File Offset: 0x00064136
			public unsafe static Func<PathGroup, float> __9__5_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NavigationUtility.__c.NativeFieldInfoPtr___9__5_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PathGroup, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NavigationUtility.__c.NativeFieldInfoPtr___9__5_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D48 RID: 36168
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008D49 RID: 36169
			private static readonly IntPtr NativeFieldInfoPtr___9__5_5;

			// Token: 0x04008D4A RID: 36170
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D4B RID: 36171
			private static readonly IntPtr NativeMethodInfoPtr__CalculatePath_b__5_5_Internal_Single_PathGroup_0;
		}

		// Token: 0x02000A76 RID: 2678
		[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D172 RID: 53618 RVA: 0x00322AE8 File Offset: 0x00320CE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr);
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastCalculatedPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "lastCalculatedPath");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastGeneratedPathGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "lastGeneratedPathGroup");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_pathGroupGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "pathGroupGenerated");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "flags");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "startPosition");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "destination");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_generalSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "generalSeeker");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_roadSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "roadSeeker");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_navSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "navSettings");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "callback");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "<>9__4");
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677489);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677490);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_PathGroup_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677491);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677492);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677493);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__6_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677494);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677495);
			}

			// Token: 0x0600D173 RID: 53619 RVA: 0x00322C7C File Offset: 0x00320E7C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D174 RID: 53620 RVA: 0x00322CB8 File Offset: 0x00320EB8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29995, RefRangeEnd = 29997, XrefRangeStart = 29995, XrefRangeEnd = 29997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Path_0(Path p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_Path_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D175 RID: 53621 RVA: 0x00322CFC File Offset: 0x00320EFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222132, XrefRangeEnd = 222133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PathGroup_PDM_0(PathGroup pg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_PathGroup_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D176 RID: 53622 RVA: 0x00322D40 File Offset: 0x00320F40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222133, XrefRangeEnd = 222138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D177 RID: 53623 RVA: 0x00322D80 File Offset: 0x00320F80
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculatePath_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D178 RID: 53624 RVA: 0x00322DBC File Offset: 0x00320FBC
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 222138, RefRangeEnd = 222155, XrefRangeStart = 222138, XrefRangeEnd = 222138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculatePath_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__6_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D179 RID: 53625 RVA: 0x00322DF8 File Offset: 0x00320FF8
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 222138, RefRangeEnd = 222155, XrefRangeStart = 222138, XrefRangeEnd = 222155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculatePath_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D17A RID: 53626 RVA: 0x00065F48 File Offset: 0x00064148
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004101 RID: 16641
			// (get) Token: 0x0600D17B RID: 53627 RVA: 0x00322E34 File Offset: 0x00321034
			// (set) Token: 0x0600D17C RID: 53628 RVA: 0x00065F51 File Offset: 0x00064151
			public unsafe Path lastCalculatedPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastCalculatedPath);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastCalculatedPath), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004102 RID: 16642
			// (get) Token: 0x0600D17D RID: 53629 RVA: 0x00322E64 File Offset: 0x00321064
			// (set) Token: 0x0600D17E RID: 53630 RVA: 0x00065F70 File Offset: 0x00064170
			public unsafe PathGroup lastGeneratedPathGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastGeneratedPathGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastGeneratedPathGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004103 RID: 16643
			// (get) Token: 0x0600D17F RID: 53631 RVA: 0x00322E94 File Offset: 0x00321094
			// (set) Token: 0x0600D180 RID: 53632 RVA: 0x00065F8F File Offset: 0x0006418F
			public unsafe bool pathGroupGenerated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_pathGroupGenerated);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_pathGroupGenerated)) = value;
				}
			}

			// Token: 0x17004104 RID: 16644
			// (get) Token: 0x0600D181 RID: 53633 RVA: 0x00322EBC File Offset: 0x003210BC
			// (set) Token: 0x0600D182 RID: 53634 RVA: 0x00065FAA File Offset: 0x000641AA
			public unsafe DriveFlags flags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_flags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DriveFlags>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_flags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004105 RID: 16645
			// (get) Token: 0x0600D183 RID: 53635 RVA: 0x00322EEC File Offset: 0x003210EC
			// (set) Token: 0x0600D184 RID: 53636 RVA: 0x00065FC9 File Offset: 0x000641C9
			public unsafe Vector3 startPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_startPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_startPosition)) = value;
				}
			}

			// Token: 0x17004106 RID: 16646
			// (get) Token: 0x0600D185 RID: 53637 RVA: 0x00322F14 File Offset: 0x00321114
			// (set) Token: 0x0600D186 RID: 53638 RVA: 0x00065FE4 File Offset: 0x000641E4
			public unsafe Vector3 destination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_destination);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_destination)) = value;
				}
			}

			// Token: 0x17004107 RID: 16647
			// (get) Token: 0x0600D187 RID: 53639 RVA: 0x00322F3C File Offset: 0x0032113C
			// (set) Token: 0x0600D188 RID: 53640 RVA: 0x00065FFF File Offset: 0x000641FF
			public unsafe Seeker generalSeeker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_generalSeeker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_generalSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004108 RID: 16648
			// (get) Token: 0x0600D189 RID: 53641 RVA: 0x00322F6C File Offset: 0x0032116C
			// (set) Token: 0x0600D18A RID: 53642 RVA: 0x0006601E File Offset: 0x0006421E
			public unsafe Seeker roadSeeker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_roadSeeker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_roadSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004109 RID: 16649
			// (get) Token: 0x0600D18B RID: 53643 RVA: 0x00322F9C File Offset: 0x0032119C
			// (set) Token: 0x0600D18C RID: 53644 RVA: 0x0006603D File Offset: 0x0006423D
			public unsafe NavigationSettings navSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_navSettings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_navSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700410A RID: 16650
			// (get) Token: 0x0600D18D RID: 53645 RVA: 0x00322FCC File Offset: 0x003211CC
			// (set) Token: 0x0600D18E RID: 53646 RVA: 0x0006605C File Offset: 0x0006425C
			public unsafe NavigationUtility.NavigationCalculationCallback callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.NavigationCalculationCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700410B RID: 16651
			// (get) Token: 0x0600D18F RID: 53647 RVA: 0x00322FFC File Offset: 0x003211FC
			// (set) Token: 0x0600D190 RID: 53648 RVA: 0x0006607B File Offset: 0x0006427B
			public unsafe Func<bool> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D4C RID: 36172
			private static readonly IntPtr NativeFieldInfoPtr_lastCalculatedPath;

			// Token: 0x04008D4D RID: 36173
			private static readonly IntPtr NativeFieldInfoPtr_lastGeneratedPathGroup;

			// Token: 0x04008D4E RID: 36174
			private static readonly IntPtr NativeFieldInfoPtr_pathGroupGenerated;

			// Token: 0x04008D4F RID: 36175
			private static readonly IntPtr NativeFieldInfoPtr_flags;

			// Token: 0x04008D50 RID: 36176
			private static readonly IntPtr NativeFieldInfoPtr_startPosition;

			// Token: 0x04008D51 RID: 36177
			private static readonly IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x04008D52 RID: 36178
			private static readonly IntPtr NativeFieldInfoPtr_generalSeeker;

			// Token: 0x04008D53 RID: 36179
			private static readonly IntPtr NativeFieldInfoPtr_roadSeeker;

			// Token: 0x04008D54 RID: 36180
			private static readonly IntPtr NativeFieldInfoPtr_navSettings;

			// Token: 0x04008D55 RID: 36181
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04008D56 RID: 36182
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x04008D57 RID: 36183
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D58 RID: 36184
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Path_0;

			// Token: 0x04008D59 RID: 36185
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PathGroup_PDM_0;

			// Token: 0x04008D5A RID: 36186
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008D5B RID: 36187
			private static readonly IntPtr NativeMethodInfoPtr__CalculatePath_b__4_Internal_Boolean_0;

			// Token: 0x04008D5C RID: 36188
			private static readonly IntPtr NativeMethodInfoPtr__CalculatePath_b__6_Internal_Boolean_0;

			// Token: 0x04008D5D RID: 36189
			private static readonly IntPtr NativeMethodInfoPtr__CalculatePath_b__3_Internal_Boolean_0;

			// Token: 0x02000C61 RID: 3169
			[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<>c__DisplayClass5_0+<<CalculatePath>g__Routine|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E415 RID: 58389 RVA: 0x00358198 File Offset: 0x00356398
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique()
				{
					Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "<<CalculatePath>g__Routine|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<>1__state");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<>2__current");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<>4__this");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__finalGroup_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<finalGroup>5__2");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__closestNodeLinks_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<closestNodeLinks>5__3");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__nodeLinksClosestToLocation_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<nodeLinksClosestToLocation>5__4");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__entryPointChecks_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<entryPointChecks>5__5");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__checkedEntryPoints_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<checkedEntryPoints>5__6");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__groups_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<groups>5__7");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__i_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<i>5__8");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__entryPoint_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<entryPoint>5__9");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__exitPointChecks_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<exitPointChecks>5__10");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__checkedExitPoints_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<checkedExitPoints>5__11");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__j_5__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<j>5__12");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, 100677496);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, 100677497);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, 100677498);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, 100677499);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, 100677500);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, 100677501);
				}

				// Token: 0x0600E416 RID: 58390 RVA: 0x00358354 File Offset: 0x00356554
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E417 RID: 58391 RVA: 0x0035839C File Offset: 0x0035659C
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E418 RID: 58392 RVA: 0x003583D0 File Offset: 0x003565D0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222063, XrefRangeEnd = 222127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046DB RID: 18139
				// (get) Token: 0x0600E419 RID: 58393 RVA: 0x0035840C File Offset: 0x0035660C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E41A RID: 58394 RVA: 0x0035844C File Offset: 0x0035664C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222127, XrefRangeEnd = 222132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046DC RID: 18140
				// (get) Token: 0x0600E41B RID: 58395 RVA: 0x00358480 File Offset: 0x00356680
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E41C RID: 58396 RVA: 0x0006F2CC File Offset: 0x0006D4CC
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046CD RID: 18125
				// (get) Token: 0x0600E41D RID: 58397 RVA: 0x003584C0 File Offset: 0x003566C0
				// (set) Token: 0x0600E41E RID: 58398 RVA: 0x0006F2D5 File Offset: 0x0006D4D5
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046CE RID: 18126
				// (get) Token: 0x0600E41F RID: 58399 RVA: 0x003584E8 File Offset: 0x003566E8
				// (set) Token: 0x0600E420 RID: 58400 RVA: 0x0006F2F0 File Offset: 0x0006D4F0
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046CF RID: 18127
				// (get) Token: 0x0600E421 RID: 58401 RVA: 0x00358518 File Offset: 0x00356718
				// (set) Token: 0x0600E422 RID: 58402 RVA: 0x0006F30F File Offset: 0x0006D50F
				public unsafe NavigationUtility.__c__DisplayClass5_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.__c__DisplayClass5_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046D0 RID: 18128
				// (get) Token: 0x0600E423 RID: 58403 RVA: 0x00358548 File Offset: 0x00356748
				// (set) Token: 0x0600E424 RID: 58404 RVA: 0x0006F32E File Offset: 0x0006D52E
				public unsafe PathGroup _finalGroup_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__finalGroup_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathGroup>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__finalGroup_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046D1 RID: 18129
				// (get) Token: 0x0600E425 RID: 58405 RVA: 0x00358578 File Offset: 0x00356778
				// (set) Token: 0x0600E426 RID: 58406 RVA: 0x0006F34D File Offset: 0x0006D54D
				public unsafe List<NodeLink> _closestNodeLinks_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__closestNodeLinks_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NodeLink>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__closestNodeLinks_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046D2 RID: 18130
				// (get) Token: 0x0600E427 RID: 58407 RVA: 0x003585A8 File Offset: 0x003567A8
				// (set) Token: 0x0600E428 RID: 58408 RVA: 0x0006F36C File Offset: 0x0006D56C
				public unsafe List<NodeLink> _nodeLinksClosestToLocation_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__nodeLinksClosestToLocation_5__4);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NodeLink>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__nodeLinksClosestToLocation_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046D3 RID: 18131
				// (get) Token: 0x0600E429 RID: 58409 RVA: 0x003585D8 File Offset: 0x003567D8
				// (set) Token: 0x0600E42A RID: 58410 RVA: 0x0006F38B File Offset: 0x0006D58B
				public unsafe int _entryPointChecks_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__entryPointChecks_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__entryPointChecks_5__5)) = value;
					}
				}

				// Token: 0x170046D4 RID: 18132
				// (get) Token: 0x0600E42B RID: 58411 RVA: 0x00358600 File Offset: 0x00356800
				// (set) Token: 0x0600E42C RID: 58412 RVA: 0x0006F3A6 File Offset: 0x0006D5A6
				public unsafe List<Vector3> _checkedEntryPoints_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__checkedEntryPoints_5__6);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__checkedEntryPoints_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046D5 RID: 18133
				// (get) Token: 0x0600E42D RID: 58413 RVA: 0x00358630 File Offset: 0x00356830
				// (set) Token: 0x0600E42E RID: 58414 RVA: 0x0006F3C5 File Offset: 0x0006D5C5
				public unsafe List<PathGroup> _groups_5__7
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__groups_5__7);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PathGroup>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__groups_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046D6 RID: 18134
				// (get) Token: 0x0600E42F RID: 58415 RVA: 0x00358660 File Offset: 0x00356860
				// (set) Token: 0x0600E430 RID: 58416 RVA: 0x0006F3E4 File Offset: 0x0006D5E4
				public unsafe int _i_5__8
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__i_5__8);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__i_5__8)) = value;
					}
				}

				// Token: 0x170046D7 RID: 18135
				// (get) Token: 0x0600E431 RID: 58417 RVA: 0x00358688 File Offset: 0x00356888
				// (set) Token: 0x0600E432 RID: 58418 RVA: 0x0006F3FF File Offset: 0x0006D5FF
				public unsafe Vector3 _entryPoint_5__9
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__entryPoint_5__9);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__entryPoint_5__9)) = value;
					}
				}

				// Token: 0x170046D8 RID: 18136
				// (get) Token: 0x0600E433 RID: 58419 RVA: 0x003586B0 File Offset: 0x003568B0
				// (set) Token: 0x0600E434 RID: 58420 RVA: 0x0006F41A File Offset: 0x0006D61A
				public unsafe int _exitPointChecks_5__10
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__exitPointChecks_5__10);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__exitPointChecks_5__10)) = value;
					}
				}

				// Token: 0x170046D9 RID: 18137
				// (get) Token: 0x0600E435 RID: 58421 RVA: 0x003586D8 File Offset: 0x003568D8
				// (set) Token: 0x0600E436 RID: 58422 RVA: 0x0006F435 File Offset: 0x0006D635
				public unsafe List<Vector3> _checkedExitPoints_5__11
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__checkedExitPoints_5__11);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__checkedExitPoints_5__11), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046DA RID: 18138
				// (get) Token: 0x0600E437 RID: 58423 RVA: 0x00358708 File Offset: 0x00356908
				// (set) Token: 0x0600E438 RID: 58424 RVA: 0x0006F454 File Offset: 0x0006D654
				public unsafe int _j_5__12
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__j_5__12);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__j_5__12)) = value;
					}
				}

				// Token: 0x04009898 RID: 39064
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009899 RID: 39065
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400989A RID: 39066
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400989B RID: 39067
				private static readonly IntPtr NativeFieldInfoPtr__finalGroup_5__2;

				// Token: 0x0400989C RID: 39068
				private static readonly IntPtr NativeFieldInfoPtr__closestNodeLinks_5__3;

				// Token: 0x0400989D RID: 39069
				private static readonly IntPtr NativeFieldInfoPtr__nodeLinksClosestToLocation_5__4;

				// Token: 0x0400989E RID: 39070
				private static readonly IntPtr NativeFieldInfoPtr__entryPointChecks_5__5;

				// Token: 0x0400989F RID: 39071
				private static readonly IntPtr NativeFieldInfoPtr__checkedEntryPoints_5__6;

				// Token: 0x040098A0 RID: 39072
				private static readonly IntPtr NativeFieldInfoPtr__groups_5__7;

				// Token: 0x040098A1 RID: 39073
				private static readonly IntPtr NativeFieldInfoPtr__i_5__8;

				// Token: 0x040098A2 RID: 39074
				private static readonly IntPtr NativeFieldInfoPtr__entryPoint_5__9;

				// Token: 0x040098A3 RID: 39075
				private static readonly IntPtr NativeFieldInfoPtr__exitPointChecks_5__10;

				// Token: 0x040098A4 RID: 39076
				private static readonly IntPtr NativeFieldInfoPtr__checkedExitPoints_5__11;

				// Token: 0x040098A5 RID: 39077
				private static readonly IntPtr NativeFieldInfoPtr__j_5__12;

				// Token: 0x040098A6 RID: 39078
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040098A7 RID: 39079
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098A8 RID: 39080
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040098A9 RID: 39081
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040098AA RID: 39082
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098AB RID: 39083
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A77 RID: 2679
		[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D191 RID: 53649 RVA: 0x0032302C File Offset: 0x0032122C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr);
				NavigationUtility.__c__DisplayClass9_0.NativeFieldInfoPtr_lastCalculatedPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, "lastCalculatedPath");
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100677502);
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100677503);
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100677504);
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100677505);
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100677506);
			}

			// Token: 0x0600D192 RID: 53650 RVA: 0x003230D0 File Offset: 0x003212D0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D193 RID: 53651 RVA: 0x0032310C File Offset: 0x0032130C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29995, RefRangeEnd = 29997, XrefRangeStart = 29995, XrefRangeEnd = 29997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Path_0(Path p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_Path_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D194 RID: 53652 RVA: 0x00323150 File Offset: 0x00321350
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 222138, RefRangeEnd = 222155, XrefRangeStart = 222138, XrefRangeEnd = 222155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateNavigationGroup_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D195 RID: 53653 RVA: 0x0032318C File Offset: 0x0032138C
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 222138, RefRangeEnd = 222155, XrefRangeStart = 222138, XrefRangeEnd = 222155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateNavigationGroup_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D196 RID: 53654 RVA: 0x003231C8 File Offset: 0x003213C8
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 222138, RefRangeEnd = 222155, XrefRangeStart = 222138, XrefRangeEnd = 222155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateNavigationGroup_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D197 RID: 53655 RVA: 0x0006609A File Offset: 0x0006429A
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700410C RID: 16652
			// (get) Token: 0x0600D198 RID: 53656 RVA: 0x00323204 File Offset: 0x00321404
			// (set) Token: 0x0600D199 RID: 53657 RVA: 0x000660A3 File Offset: 0x000642A3
			public unsafe Path lastCalculatedPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass9_0.NativeFieldInfoPtr_lastCalculatedPath);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass9_0.NativeFieldInfoPtr_lastCalculatedPath), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D5E RID: 36190
			private static readonly IntPtr NativeFieldInfoPtr_lastCalculatedPath;

			// Token: 0x04008D5F RID: 36191
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D60 RID: 36192
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Path_0;

			// Token: 0x04008D61 RID: 36193
			private static readonly IntPtr NativeMethodInfoPtr__GenerateNavigationGroup_b__1_Internal_Boolean_0;

			// Token: 0x04008D62 RID: 36194
			private static readonly IntPtr NativeMethodInfoPtr__GenerateNavigationGroup_b__2_Internal_Boolean_0;

			// Token: 0x04008D63 RID: 36195
			private static readonly IntPtr NativeMethodInfoPtr__GenerateNavigationGroup_b__3_Internal_Boolean_0;
		}

		// Token: 0x02000A78 RID: 2680
		[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<GenerateNavigationGroup>d__9")]
		public sealed class _GenerateNavigationGroup_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600D19A RID: 53658 RVA: 0x00323234 File Offset: 0x00321434
			// Note: this type is marked as 'beforefieldinit'.
			static _GenerateNavigationGroup_d__9()
			{
				Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "<GenerateNavigationGroup>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<>1__state");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<>2__current");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "startPoint");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "destination");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_generalSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "generalSeeker");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_entryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "entryPoint");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<>8__1");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "callback");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_roadSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "roadSeeker");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "exitLink");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "exitPoint");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__destinationOnGraph_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<destinationOnGraph>5__2");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_StartToEntry_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<path_StartToEntry>5__3");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_EntryToExit_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<path_EntryToExit>5__4");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100677507);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100677508);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100677509);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100677510);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100677511);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100677512);
			}

			// Token: 0x0600D19B RID: 53659 RVA: 0x003233F0 File Offset: 0x003215F0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GenerateNavigationGroup_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D19C RID: 53660 RVA: 0x00323438 File Offset: 0x00321638
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D19D RID: 53661 RVA: 0x0032346C File Offset: 0x0032166C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222155, XrefRangeEnd = 222197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700411B RID: 16667
			// (get) Token: 0x0600D19E RID: 53662 RVA: 0x003234A8 File Offset: 0x003216A8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D19F RID: 53663 RVA: 0x003234E8 File Offset: 0x003216E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222197, XrefRangeEnd = 222202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700411C RID: 16668
			// (get) Token: 0x0600D1A0 RID: 53664 RVA: 0x0032351C File Offset: 0x0032171C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D1A1 RID: 53665 RVA: 0x000660C2 File Offset: 0x000642C2
			public _GenerateNavigationGroup_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700410D RID: 16653
			// (get) Token: 0x0600D1A2 RID: 53666 RVA: 0x0032355C File Offset: 0x0032175C
			// (set) Token: 0x0600D1A3 RID: 53667 RVA: 0x000660CB File Offset: 0x000642CB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700410E RID: 16654
			// (get) Token: 0x0600D1A4 RID: 53668 RVA: 0x00323584 File Offset: 0x00321784
			// (set) Token: 0x0600D1A5 RID: 53669 RVA: 0x000660E6 File Offset: 0x000642E6
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700410F RID: 16655
			// (get) Token: 0x0600D1A6 RID: 53670 RVA: 0x003235B4 File Offset: 0x003217B4
			// (set) Token: 0x0600D1A7 RID: 53671 RVA: 0x00066105 File Offset: 0x00064305
			public unsafe Vector3 startPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_startPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_startPoint)) = value;
				}
			}

			// Token: 0x17004110 RID: 16656
			// (get) Token: 0x0600D1A8 RID: 53672 RVA: 0x003235DC File Offset: 0x003217DC
			// (set) Token: 0x0600D1A9 RID: 53673 RVA: 0x00066120 File Offset: 0x00064320
			public unsafe Vector3 destination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_destination);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_destination)) = value;
				}
			}

			// Token: 0x17004111 RID: 16657
			// (get) Token: 0x0600D1AA RID: 53674 RVA: 0x00323604 File Offset: 0x00321804
			// (set) Token: 0x0600D1AB RID: 53675 RVA: 0x0006613B File Offset: 0x0006433B
			public unsafe Seeker generalSeeker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_generalSeeker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_generalSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004112 RID: 16658
			// (get) Token: 0x0600D1AC RID: 53676 RVA: 0x00323634 File Offset: 0x00321834
			// (set) Token: 0x0600D1AD RID: 53677 RVA: 0x0006615A File Offset: 0x0006435A
			public unsafe Vector3 entryPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_entryPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_entryPoint)) = value;
				}
			}

			// Token: 0x17004113 RID: 16659
			// (get) Token: 0x0600D1AE RID: 53678 RVA: 0x0032365C File Offset: 0x0032185C
			// (set) Token: 0x0600D1AF RID: 53679 RVA: 0x00066175 File Offset: 0x00064375
			public unsafe NavigationUtility.__c__DisplayClass9_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.__c__DisplayClass9_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004114 RID: 16660
			// (get) Token: 0x0600D1B0 RID: 53680 RVA: 0x0032368C File Offset: 0x0032188C
			// (set) Token: 0x0600D1B1 RID: 53681 RVA: 0x00066194 File Offset: 0x00064394
			public unsafe NavigationUtility.PathGroupEvent callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.PathGroupEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004115 RID: 16661
			// (get) Token: 0x0600D1B2 RID: 53682 RVA: 0x003236BC File Offset: 0x003218BC
			// (set) Token: 0x0600D1B3 RID: 53683 RVA: 0x000661B3 File Offset: 0x000643B3
			public unsafe Seeker roadSeeker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_roadSeeker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_roadSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004116 RID: 16662
			// (get) Token: 0x0600D1B4 RID: 53684 RVA: 0x003236EC File Offset: 0x003218EC
			// (set) Token: 0x0600D1B5 RID: 53685 RVA: 0x000661D2 File Offset: 0x000643D2
			public unsafe NodeLink exitLink
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitLink);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NodeLink>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitLink), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004117 RID: 16663
			// (get) Token: 0x0600D1B6 RID: 53686 RVA: 0x0032371C File Offset: 0x0032191C
			// (set) Token: 0x0600D1B7 RID: 53687 RVA: 0x000661F1 File Offset: 0x000643F1
			public unsafe Vector3 exitPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitPoint)) = value;
				}
			}

			// Token: 0x17004118 RID: 16664
			// (get) Token: 0x0600D1B8 RID: 53688 RVA: 0x00323744 File Offset: 0x00321944
			// (set) Token: 0x0600D1B9 RID: 53689 RVA: 0x0006620C File Offset: 0x0006440C
			public unsafe Vector3 _destinationOnGraph_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__destinationOnGraph_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__destinationOnGraph_5__2)) = value;
				}
			}

			// Token: 0x17004119 RID: 16665
			// (get) Token: 0x0600D1BA RID: 53690 RVA: 0x0032376C File Offset: 0x0032196C
			// (set) Token: 0x0600D1BB RID: 53691 RVA: 0x00066227 File Offset: 0x00064427
			public unsafe Path _path_StartToEntry_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_StartToEntry_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_StartToEntry_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700411A RID: 16666
			// (get) Token: 0x0600D1BC RID: 53692 RVA: 0x0032379C File Offset: 0x0032199C
			// (set) Token: 0x0600D1BD RID: 53693 RVA: 0x00066246 File Offset: 0x00064446
			public unsafe Path _path_EntryToExit_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_EntryToExit_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_EntryToExit_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D64 RID: 36196
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008D65 RID: 36197
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D66 RID: 36198
			private static readonly IntPtr NativeFieldInfoPtr_startPoint;

			// Token: 0x04008D67 RID: 36199
			private static readonly IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x04008D68 RID: 36200
			private static readonly IntPtr NativeFieldInfoPtr_generalSeeker;

			// Token: 0x04008D69 RID: 36201
			private static readonly IntPtr NativeFieldInfoPtr_entryPoint;

			// Token: 0x04008D6A RID: 36202
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008D6B RID: 36203
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04008D6C RID: 36204
			private static readonly IntPtr NativeFieldInfoPtr_roadSeeker;

			// Token: 0x04008D6D RID: 36205
			private static readonly IntPtr NativeFieldInfoPtr_exitLink;

			// Token: 0x04008D6E RID: 36206
			private static readonly IntPtr NativeFieldInfoPtr_exitPoint;

			// Token: 0x04008D6F RID: 36207
			private static readonly IntPtr NativeFieldInfoPtr__destinationOnGraph_5__2;

			// Token: 0x04008D70 RID: 36208
			private static readonly IntPtr NativeFieldInfoPtr__path_StartToEntry_5__3;

			// Token: 0x04008D71 RID: 36209
			private static readonly IntPtr NativeFieldInfoPtr__path_EntryToExit_5__4;

			// Token: 0x04008D72 RID: 36210
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D73 RID: 36211
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D74 RID: 36212
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008D75 RID: 36213
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008D76 RID: 36214
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D77 RID: 36215
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
