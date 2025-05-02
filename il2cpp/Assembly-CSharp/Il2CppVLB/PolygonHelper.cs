using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000A6 RID: 166
	public class PolygonHelper : MonoBehaviour
	{
		// Token: 0x06000B50 RID: 2896 RVA: 0x00007BA5 File Offset: 0x00005DA5
		// Note: this type is marked as 'beforefieldinit'.
		static PolygonHelper()
		{
			Il2CppClassPointerStore<PolygonHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "PolygonHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolygonHelper>.NativeClassPtr);
			PolygonHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper>.NativeClassPtr, 100664638);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x000946CC File Offset: 0x000928CC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PolygonHelper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PolygonHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00007BDE File Offset: 0x00005DDE
		public PolygonHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200082E RID: 2094
		[StructLayout(2)]
		public struct Plane2D
		{
			// Token: 0x0600BED1 RID: 48849 RVA: 0x002ED1F0 File Offset: 0x002EB3F0
			// Note: this type is marked as 'beforefieldinit'.
			static Plane2D()
			{
				Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PolygonHelper>.NativeClassPtr, "Plane2D");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr);
				PolygonHelper.Plane2D.NativeFieldInfoPtr_normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, "normal");
				PolygonHelper.Plane2D.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, "distance");
				PolygonHelper.Plane2D.NativeMethodInfoPtr_Distance_Public_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664639);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_ClosestPoint_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664640);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_Intersect_Public_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664641);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_GetSide_Public_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664642);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_FromPoints_Public_Static_Plane2D_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664643);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_FromNormalAndPoint_Public_Static_Plane2D_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664644);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_Flip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664645);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_CutConvex_Public_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664646);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664647);
			}

			// Token: 0x0600BED2 RID: 48850 RVA: 0x002ED2F8 File Offset: 0x002EB4F8
			[CallerCount(0)]
			public unsafe float Distance(Vector2 point)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_Distance_Public_Single_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BED3 RID: 48851 RVA: 0x002ED338 File Offset: 0x002EB538
			[CallerCount(0)]
			public unsafe Vector2 ClosestPoint(Vector2 pt)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref pt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_ClosestPoint_Public_Vector2_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BED4 RID: 48852 RVA: 0x002ED378 File Offset: 0x002EB578
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 82747, RefRangeEnd = 82749, XrefRangeStart = 82747, XrefRangeEnd = 82747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 Intersect(Vector2 p1, Vector2 p2)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p1;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_Intersect_Public_Vector2_Vector2_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BED5 RID: 48853 RVA: 0x002ED3C4 File Offset: 0x002EB5C4
			[CallerCount(0)]
			public unsafe bool GetSide(Vector2 point)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_GetSide_Public_Boolean_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BED6 RID: 48854 RVA: 0x002ED404 File Offset: 0x002EB604
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82749, XrefRangeEnd = 82750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static PolygonHelper.Plane2D FromPoints(Vector3 p1, Vector3 p2)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p1;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_FromPoints_Public_Static_Plane2D_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BED7 RID: 48855 RVA: 0x002ED450 File Offset: 0x002EB650
			[CallerCount(0)]
			public unsafe static PolygonHelper.Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref normalizedNormal;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_FromNormalAndPoint_Public_Static_Plane2D_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BED8 RID: 48856 RVA: 0x002ED49C File Offset: 0x002EB69C
			[CallerCount(0)]
			public unsafe void Flip()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_Flip_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BED9 RID: 48857 RVA: 0x002ED4C4 File Offset: 0x002EB6C4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 82771, RefRangeEnd = 82772, XrefRangeStart = 82750, XrefRangeEnd = 82771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<Vector2> CutConvex(Il2CppStructArray<Vector2> poly)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(poly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_CutConvex_Public_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}

			// Token: 0x0600BEDA RID: 48858 RVA: 0x002ED508 File Offset: 0x002EB708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82772, XrefRangeEnd = 82782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600BEDB RID: 48859 RVA: 0x0005D4DB File Offset: 0x0005B6DB
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, ref this));
			}

			// Token: 0x0400814A RID: 33098
			private static readonly IntPtr NativeFieldInfoPtr_normal;

			// Token: 0x0400814B RID: 33099
			private static readonly IntPtr NativeFieldInfoPtr_distance;

			// Token: 0x0400814C RID: 33100
			private static readonly IntPtr NativeMethodInfoPtr_Distance_Public_Single_Vector2_0;

			// Token: 0x0400814D RID: 33101
			private static readonly IntPtr NativeMethodInfoPtr_ClosestPoint_Public_Vector2_Vector2_0;

			// Token: 0x0400814E RID: 33102
			private static readonly IntPtr NativeMethodInfoPtr_Intersect_Public_Vector2_Vector2_Vector2_0;

			// Token: 0x0400814F RID: 33103
			private static readonly IntPtr NativeMethodInfoPtr_GetSide_Public_Boolean_Vector2_0;

			// Token: 0x04008150 RID: 33104
			private static readonly IntPtr NativeMethodInfoPtr_FromPoints_Public_Static_Plane2D_Vector3_Vector3_0;

			// Token: 0x04008151 RID: 33105
			private static readonly IntPtr NativeMethodInfoPtr_FromNormalAndPoint_Public_Static_Plane2D_Vector3_Vector3_0;

			// Token: 0x04008152 RID: 33106
			private static readonly IntPtr NativeMethodInfoPtr_Flip_Public_Void_0;

			// Token: 0x04008153 RID: 33107
			private static readonly IntPtr NativeMethodInfoPtr_CutConvex_Public_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_0;

			// Token: 0x04008154 RID: 33108
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04008155 RID: 33109
			[FieldOffset(0)]
			public Vector2 normal;

			// Token: 0x04008156 RID: 33110
			[FieldOffset(8)]
			public float distance;
		}
	}
}
