using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004DC RID: 1244
	public class Zone : MonoBehaviour
	{
		// Token: 0x06006CAD RID: 27821 RVA: 0x001E22DC File Offset: 0x001E04DC
		// Note: this type is marked as 'beforefieldinit'.
		static Zone()
		{
			Il2CppClassPointerStore<Zone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "Zone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Zone>.NativeClassPtr);
			Zone.NativeFieldInfoPtr_UPDATE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "UPDATE_INTERVAL");
			Zone.NativeFieldInfoPtr_PointContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "PointContainer");
			Zone.NativeFieldInfoPtr_IsClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "IsClosed");
			Zone.NativeFieldInfoPtr_VerticalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "VerticalSize");
			Zone.NativeFieldInfoPtr__LocalPlayerDistance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "<LocalPlayerDistance>k__BackingField");
			Zone.NativeFieldInfoPtr_ZoneColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "ZoneColor");
			Zone.NativeFieldInfoPtr_points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "points");
			Zone.NativeMethodInfoPtr_get_LocalPlayerDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677028);
			Zone.NativeMethodInfoPtr_set_LocalPlayerDistance_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677029);
			Zone.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677030);
			Zone.NativeMethodInfoPtr_Recalculate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677031);
			Zone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677032);
			Zone.NativeMethodInfoPtr_GetPoints_Private_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677033);
			Zone.NativeMethodInfoPtr_DoBoundsContainPoint_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677034);
			Zone.NativeMethodInfoPtr_GetBoundingPoints_Private_Tuple_2_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677035);
			Zone.NativeMethodInfoPtr_IsPointInsidePolygon_Private_Boolean_Il2CppStructArray_1_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677036);
			Zone.NativeMethodInfoPtr_CalculateWindingNumber_Private_Int32_Il2CppStructArray_1_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677037);
			Zone.NativeMethodInfoPtr_GetClosestPointOnPolygon_Private_Vector3_Il2CppStructArray_1_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677038);
			Zone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677039);
			Zone.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Vector2_Vector2_Vector2_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677040);
			Zone.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677041);
			Zone.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677042);
			Zone.NativeMethodInfoPtr_Method_Internal_Static_Int32_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677043);
			Zone.NativeMethodInfoPtr_Method_Internal_Static_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677044);
		}

		// Token: 0x170020B1 RID: 8369
		// (get) Token: 0x06006CAE RID: 27822 RVA: 0x001E24EC File Offset: 0x001E06EC
		// (set) Token: 0x06006CAF RID: 27823 RVA: 0x001E2528 File Offset: 0x001E0728
		public unsafe float LocalPlayerDistance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30021, RefRangeEnd = 30022, XrefRangeStart = 30021, XrefRangeEnd = 30022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_get_LocalPlayerDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30022, RefRangeEnd = 30024, XrefRangeStart = 30022, XrefRangeEnd = 30024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_set_LocalPlayerDistance_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006CB0 RID: 27824 RVA: 0x001E2568 File Offset: 0x001E0768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217326, XrefRangeEnd = 217331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CB1 RID: 27825 RVA: 0x001E259C File Offset: 0x001E079C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217331, XrefRangeEnd = 217362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Recalculate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Recalculate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CB2 RID: 27826 RVA: 0x001E25D0 File Offset: 0x001E07D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217362, XrefRangeEnd = 217384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CB3 RID: 27827 RVA: 0x001E2604 File Offset: 0x001E0804
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 217396, RefRangeEnd = 217399, XrefRangeStart = 217384, XrefRangeEnd = 217396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Vector3> GetPoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_GetPoints_Private_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06006CB4 RID: 27828 RVA: 0x001E2644 File Offset: 0x001E0844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217399, XrefRangeEnd = 217402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoBoundsContainPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_DoBoundsContainPoint_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x001E2690 File Offset: 0x001E0890
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217476, RefRangeEnd = 217478, XrefRangeStart = 217402, XrefRangeEnd = 217476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tuple<Vector3, Vector3> GetBoundingPoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_GetBoundingPoints_Private_Tuple_2_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tuple<Vector3, Vector3>>(intPtr3) : null;
		}

		// Token: 0x06006CB6 RID: 27830 RVA: 0x001E26D0 File Offset: 0x001E08D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217478, XrefRangeEnd = 217483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointInsidePolygon(Il2CppStructArray<Vector3> polyPoints, Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(polyPoints);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_IsPointInsidePolygon_Private_Boolean_Il2CppStructArray_1_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CB7 RID: 27831 RVA: 0x001E272C File Offset: 0x001E092C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217487, RefRangeEnd = 217489, XrefRangeStart = 217483, XrefRangeEnd = 217487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CalculateWindingNumber(Il2CppStructArray<Vector2> polygon, Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(polygon);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_CalculateWindingNumber_Private_Int32_Il2CppStructArray_1_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CB8 RID: 27832 RVA: 0x001E2788 File Offset: 0x001E0988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217504, RefRangeEnd = 217505, XrefRangeStart = 217489, XrefRangeEnd = 217504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetClosestPointOnPolygon(Il2CppStructArray<Vector3> polyPoints, Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(polyPoints);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_GetClosestPointOnPolygon_Private_Vector3_Il2CppStructArray_1_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CB9 RID: 27833 RVA: 0x001E27E4 File Offset: 0x001E09E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217505, XrefRangeEnd = 217508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Zone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Zone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CBA RID: 27834 RVA: 0x001E2820 File Offset: 0x001E0A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217508, XrefRangeEnd = 217509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_Vector2_Vector2_Vector2_PDM_0(Vector2 start, Vector2 end, Vector2 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Vector2_Vector2_Vector2_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CBB RID: 27835 RVA: 0x001E287C File Offset: 0x001E0A7C
		[CallerCount(0)]
		public unsafe static float Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_0(Vector2 start, Vector2 end, Vector2 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CBC RID: 27836 RVA: 0x001E28D8 File Offset: 0x001E0AD8
		[CallerCount(0)]
		public unsafe static float Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_1(Vector2 start, Vector2 end, Vector2 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_1, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CBD RID: 27837 RVA: 0x001E2934 File Offset: 0x001E0B34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217509, RefRangeEnd = 217511, XrefRangeStart = 217509, XrefRangeEnd = 217509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Method_Internal_Static_Int32_Vector2_Vector2_Vector2_0(Vector2 start, Vector2 end, Vector2 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Method_Internal_Static_Int32_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CBE RID: 27838 RVA: 0x001E2990 File Offset: 0x001E0B90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217521, RefRangeEnd = 217523, XrefRangeStart = 217511, XrefRangeEnd = 217521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Method_Internal_Static_Vector3_Vector3_Vector3_Vector3_0(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lineStart;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineEnd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Method_Internal_Static_Vector3_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CBF RID: 27839 RVA: 0x00033760 File Offset: 0x00031960
		public Zone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x06006CC0 RID: 27840 RVA: 0x001E29EC File Offset: 0x001E0BEC
		// (set) Token: 0x06006CC1 RID: 27841 RVA: 0x00033769 File Offset: 0x00031969
		public unsafe static float UPDATE_INTERVAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Zone.NativeFieldInfoPtr_UPDATE_INTERVAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Zone.NativeFieldInfoPtr_UPDATE_INTERVAL, (void*)(&value));
			}
		}

		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x06006CC2 RID: 27842 RVA: 0x001E2A08 File Offset: 0x001E0C08
		// (set) Token: 0x06006CC3 RID: 27843 RVA: 0x00033777 File Offset: 0x00031977
		public unsafe Transform PointContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_PointContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_PointContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x06006CC4 RID: 27844 RVA: 0x001E2A38 File Offset: 0x001E0C38
		// (set) Token: 0x06006CC5 RID: 27845 RVA: 0x00033796 File Offset: 0x00031996
		public unsafe bool IsClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_IsClosed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_IsClosed)) = value;
			}
		}

		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x06006CC6 RID: 27846 RVA: 0x001E2A60 File Offset: 0x001E0C60
		// (set) Token: 0x06006CC7 RID: 27847 RVA: 0x000337B1 File Offset: 0x000319B1
		public unsafe float VerticalSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_VerticalSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_VerticalSize)) = value;
			}
		}

		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x06006CC8 RID: 27848 RVA: 0x001E2A88 File Offset: 0x001E0C88
		// (set) Token: 0x06006CC9 RID: 27849 RVA: 0x000337CC File Offset: 0x000319CC
		public unsafe float _LocalPlayerDistance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr__LocalPlayerDistance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr__LocalPlayerDistance_k__BackingField)) = value;
			}
		}

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x06006CCA RID: 27850 RVA: 0x001E2AB0 File Offset: 0x001E0CB0
		// (set) Token: 0x06006CCB RID: 27851 RVA: 0x000337E7 File Offset: 0x000319E7
		public unsafe Color ZoneColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_ZoneColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_ZoneColor)) = value;
			}
		}

		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x06006CCC RID: 27852 RVA: 0x001E2AD8 File Offset: 0x001E0CD8
		// (set) Token: 0x06006CCD RID: 27853 RVA: 0x00033802 File Offset: 0x00031A02
		public unsafe Il2CppStructArray<Vector3> points
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_points);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_points), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A47 RID: 19015
		private static readonly IntPtr NativeFieldInfoPtr_UPDATE_INTERVAL;

		// Token: 0x04004A48 RID: 19016
		private static readonly IntPtr NativeFieldInfoPtr_PointContainer;

		// Token: 0x04004A49 RID: 19017
		private static readonly IntPtr NativeFieldInfoPtr_IsClosed;

		// Token: 0x04004A4A RID: 19018
		private static readonly IntPtr NativeFieldInfoPtr_VerticalSize;

		// Token: 0x04004A4B RID: 19019
		private static readonly IntPtr NativeFieldInfoPtr__LocalPlayerDistance_k__BackingField;

		// Token: 0x04004A4C RID: 19020
		private static readonly IntPtr NativeFieldInfoPtr_ZoneColor;

		// Token: 0x04004A4D RID: 19021
		private static readonly IntPtr NativeFieldInfoPtr_points;

		// Token: 0x04004A4E RID: 19022
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerDistance_Public_get_Single_0;

		// Token: 0x04004A4F RID: 19023
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPlayerDistance_Protected_set_Void_Single_0;

		// Token: 0x04004A50 RID: 19024
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004A51 RID: 19025
		private static readonly IntPtr NativeMethodInfoPtr_Recalculate_Public_Void_0;

		// Token: 0x04004A52 RID: 19026
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04004A53 RID: 19027
		private static readonly IntPtr NativeMethodInfoPtr_GetPoints_Private_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04004A54 RID: 19028
		private static readonly IntPtr NativeMethodInfoPtr_DoBoundsContainPoint_Private_Boolean_Vector3_0;

		// Token: 0x04004A55 RID: 19029
		private static readonly IntPtr NativeMethodInfoPtr_GetBoundingPoints_Private_Tuple_2_Vector3_Vector3_0;

		// Token: 0x04004A56 RID: 19030
		private static readonly IntPtr NativeMethodInfoPtr_IsPointInsidePolygon_Private_Boolean_Il2CppStructArray_1_Vector3_Vector3_0;

		// Token: 0x04004A57 RID: 19031
		private static readonly IntPtr NativeMethodInfoPtr_CalculateWindingNumber_Private_Int32_Il2CppStructArray_1_Vector2_Vector2_0;

		// Token: 0x04004A58 RID: 19032
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPointOnPolygon_Private_Vector3_Il2CppStructArray_1_Vector3_Vector3_0;

		// Token: 0x04004A59 RID: 19033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004A5A RID: 19034
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_Vector2_Vector2_Vector2_PDM_0;

		// Token: 0x04004A5B RID: 19035
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_0;

		// Token: 0x04004A5C RID: 19036
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_1;

		// Token: 0x04004A5D RID: 19037
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Int32_Vector2_Vector2_Vector2_0;

		// Token: 0x04004A5E RID: 19038
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x02000A65 RID: 2661
		[ObfuscatedName("ScheduleOne.Audio.Zone+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D0ED RID: 53485 RVA: 0x00321374 File Offset: 0x0031F574
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Zone.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Zone>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr);
				Zone.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, "<>9");
				Zone.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, "<>9__15_0");
				Zone.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, "<>9__15_1");
				Zone.__c.NativeFieldInfoPtr___9__15_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, "<>9__15_2");
				Zone.__c.NativeFieldInfoPtr___9__15_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, "<>9__15_3");
				Zone.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, 100677046);
				Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_0_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, 100677047);
				Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_1_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, 100677048);
				Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_2_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, 100677049);
				Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_3_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, 100677050);
			}

			// Token: 0x0600D0EE RID: 53486 RVA: 0x00321468 File Offset: 0x0031F668
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0EF RID: 53487 RVA: 0x003214A4 File Offset: 0x0031F6A4
			[CallerCount(0)]
			public unsafe float _GetBoundingPoints_b__15_0(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_0_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0F0 RID: 53488 RVA: 0x003214F0 File Offset: 0x0031F6F0
			[CallerCount(0)]
			public unsafe float _GetBoundingPoints_b__15_1(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_1_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0F1 RID: 53489 RVA: 0x0032153C File Offset: 0x0031F73C
			[CallerCount(0)]
			public unsafe float _GetBoundingPoints_b__15_2(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_2_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0F2 RID: 53490 RVA: 0x00321588 File Offset: 0x0031F788
			[CallerCount(0)]
			public unsafe float _GetBoundingPoints_b__15_3(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_3_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0F3 RID: 53491 RVA: 0x00065BB0 File Offset: 0x00063DB0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040E4 RID: 16612
			// (get) Token: 0x0600D0F4 RID: 53492 RVA: 0x003215D4 File Offset: 0x0031F7D4
			// (set) Token: 0x0600D0F5 RID: 53493 RVA: 0x00065BB9 File Offset: 0x00063DB9
			public unsafe static Zone.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Zone.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Zone.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Zone.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040E5 RID: 16613
			// (get) Token: 0x0600D0F6 RID: 53494 RVA: 0x003215FC File Offset: 0x0031F7FC
			// (set) Token: 0x0600D0F7 RID: 53495 RVA: 0x00065BCB File Offset: 0x00063DCB
			public unsafe static Func<Vector3, float> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Zone.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Zone.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040E6 RID: 16614
			// (get) Token: 0x0600D0F8 RID: 53496 RVA: 0x00321624 File Offset: 0x0031F824
			// (set) Token: 0x0600D0F9 RID: 53497 RVA: 0x00065BDD File Offset: 0x00063DDD
			public unsafe static Func<Vector3, float> __9__15_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Zone.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Zone.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040E7 RID: 16615
			// (get) Token: 0x0600D0FA RID: 53498 RVA: 0x0032164C File Offset: 0x0031F84C
			// (set) Token: 0x0600D0FB RID: 53499 RVA: 0x00065BEF File Offset: 0x00063DEF
			public unsafe static Func<Vector3, float> __9__15_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Zone.__c.NativeFieldInfoPtr___9__15_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Zone.__c.NativeFieldInfoPtr___9__15_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040E8 RID: 16616
			// (get) Token: 0x0600D0FC RID: 53500 RVA: 0x00321674 File Offset: 0x0031F874
			// (set) Token: 0x0600D0FD RID: 53501 RVA: 0x00065C01 File Offset: 0x00063E01
			public unsafe static Func<Vector3, float> __9__15_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Zone.__c.NativeFieldInfoPtr___9__15_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Zone.__c.NativeFieldInfoPtr___9__15_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CFF RID: 36095
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008D00 RID: 36096
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x04008D01 RID: 36097
			private static readonly IntPtr NativeFieldInfoPtr___9__15_1;

			// Token: 0x04008D02 RID: 36098
			private static readonly IntPtr NativeFieldInfoPtr___9__15_2;

			// Token: 0x04008D03 RID: 36099
			private static readonly IntPtr NativeFieldInfoPtr___9__15_3;

			// Token: 0x04008D04 RID: 36100
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D05 RID: 36101
			private static readonly IntPtr NativeMethodInfoPtr__GetBoundingPoints_b__15_0_Internal_Single_Vector3_0;

			// Token: 0x04008D06 RID: 36102
			private static readonly IntPtr NativeMethodInfoPtr__GetBoundingPoints_b__15_1_Internal_Single_Vector3_0;

			// Token: 0x04008D07 RID: 36103
			private static readonly IntPtr NativeMethodInfoPtr__GetBoundingPoints_b__15_2_Internal_Single_Vector3_0;

			// Token: 0x04008D08 RID: 36104
			private static readonly IntPtr NativeMethodInfoPtr__GetBoundingPoints_b__15_3_Internal_Single_Vector3_0;
		}
	}
}
