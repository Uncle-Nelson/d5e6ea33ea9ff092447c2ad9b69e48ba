using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000A1 RID: 161
	public static class MeshGenerator : Il2CppSystem.Object
	{
		// Token: 0x06000B11 RID: 2833 RVA: 0x000936B0 File Offset: 0x000918B0
		// Note: this type is marked as 'beforefieldinit'.
		static MeshGenerator()
		{
			Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "MeshGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr);
			MeshGenerator.NativeFieldInfoPtr_kMinTruncatedRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, "kMinTruncatedRadius");
			MeshGenerator.NativeMethodInfoPtr_GetAngleOffset_Private_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664594);
			MeshGenerator.NativeMethodInfoPtr_GetRadiiScale_Private_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664595);
			MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_RadiusAndAngle_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664596);
			MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Angle_Public_Static_Mesh_Single_Single_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664597);
			MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Radii_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664598);
			MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Radii_DoubleCaps_Public_Static_Mesh_Single_Single_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664599);
			MeshGenerator.NativeMethodInfoPtr_ComputeBounds_Public_Static_Bounds_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664600);
			MeshGenerator.NativeMethodInfoPtr_GetCapAdditionalVerticesCount_Private_Static_Int32_CapMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664601);
			MeshGenerator.NativeMethodInfoPtr_GetCapAdditionalIndicesCount_Private_Static_Int32_CapMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664602);
			MeshGenerator.NativeMethodInfoPtr_GetVertexCount_Public_Static_Int32_Int32_Int32_CapMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664603);
			MeshGenerator.NativeMethodInfoPtr_GetIndicesCount_Public_Static_Int32_Int32_Int32_CapMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664604);
			MeshGenerator.NativeMethodInfoPtr_GetSharedMeshVertexCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664605);
			MeshGenerator.NativeMethodInfoPtr_GetSharedMeshIndicesCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664606);
			MeshGenerator.NativeMethodInfoPtr_GetSharedMeshHDVertexCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664607);
			MeshGenerator.NativeMethodInfoPtr_GetSharedMeshHDIndicesCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664608);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00093820 File Offset: 0x00091A20
		[CallerCount(0)]
		public unsafe static float GetAngleOffset(int numSides)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref numSides;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetAngleOffset_Private_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00093860 File Offset: 0x00091A60
		[CallerCount(0)]
		public unsafe static float GetRadiiScale(int numSides)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref numSides;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetRadiiScale_Private_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x000938A0 File Offset: 0x00091AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82522, XrefRangeEnd = 82524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lengthZ;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneAngle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cap;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_RadiusAndAngle_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00093934 File Offset: 0x00091B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82524, XrefRangeEnd = 82526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lengthZ;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cap;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Angle_Public_Static_Mesh_Single_Single_Int32_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x000939BC File Offset: 0x00091BBC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 82574, RefRangeEnd = 82578, XrefRangeStart = 82526, XrefRangeEnd = 82574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh GenerateConeZ_Radii(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lengthZ;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cap;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Radii_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00093A50 File Offset: 0x00091C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82630, RefRangeEnd = 82631, XrefRangeStart = 82578, XrefRangeEnd = 82630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh GenerateConeZ_Radii_DoubleCaps(float lengthZ, float radiusStart, float radiusEnd, int numSides, bool inverted)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lengthZ;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inverted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Radii_DoubleCaps_Public_Static_Mesh_Single_Single_Single_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00093AC8 File Offset: 0x00091CC8
		[CallerCount(0)]
		public unsafe static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lengthZ;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_ComputeBounds_Public_Static_Bounds_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00093B24 File Offset: 0x00091D24
		[CallerCount(0)]
		public unsafe static int GetCapAdditionalVerticesCount(MeshGenerator.CapMode capMode, int numSides)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capMode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetCapAdditionalVerticesCount_Private_Static_Int32_CapMode_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00093B70 File Offset: 0x00091D70
		[CallerCount(0)]
		public unsafe static int GetCapAdditionalIndicesCount(MeshGenerator.CapMode capMode, int numSides)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capMode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetCapAdditionalIndicesCount_Private_Static_Int32_CapMode_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00093BBC File Offset: 0x00091DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82631, XrefRangeEnd = 82635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetVertexCount(int numSides, int numSegments, MeshGenerator.CapMode capMode, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref numSides;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetVertexCount_Public_Static_Int32_Int32_Int32_CapMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00093C24 File Offset: 0x00091E24
		[CallerCount(0)]
		public unsafe static int GetIndicesCount(int numSides, int numSegments, MeshGenerator.CapMode capMode, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref numSides;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetIndicesCount_Public_Static_Int32_Int32_Int32_CapMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00093C8C File Offset: 0x00091E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82635, XrefRangeEnd = 82639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSharedMeshVertexCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetSharedMeshVertexCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00093CBC File Offset: 0x00091EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82639, XrefRangeEnd = 82643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSharedMeshIndicesCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetSharedMeshIndicesCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00093CEC File Offset: 0x00091EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82643, XrefRangeEnd = 82644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSharedMeshHDVertexCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetSharedMeshHDVertexCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00093D1C File Offset: 0x00091F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82644, XrefRangeEnd = 82645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSharedMeshHDIndicesCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetSharedMeshHDIndicesCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00007AEF File Offset: 0x00005CEF
		public MeshGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x00093D4C File Offset: 0x00091F4C
		// (set) Token: 0x06000B23 RID: 2851 RVA: 0x00007AF8 File Offset: 0x00005CF8
		public unsafe static float kMinTruncatedRadius
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MeshGenerator.NativeFieldInfoPtr_kMinTruncatedRadius, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshGenerator.NativeFieldInfoPtr_kMinTruncatedRadius, (void*)(&value));
			}
		}

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeFieldInfoPtr_kMinTruncatedRadius;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_GetAngleOffset_Private_Static_Single_Int32_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_GetRadiiScale_Private_Static_Single_Int32_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_GenerateConeZ_RadiusAndAngle_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_GenerateConeZ_Angle_Public_Static_Mesh_Single_Single_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_GenerateConeZ_Radii_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_GenerateConeZ_Radii_DoubleCaps_Public_Static_Mesh_Single_Single_Single_Int32_Boolean_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_ComputeBounds_Public_Static_Bounds_Single_Single_Single_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_GetCapAdditionalVerticesCount_Private_Static_Int32_CapMode_Int32_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_GetCapAdditionalIndicesCount_Private_Static_Int32_CapMode_Int32_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexCount_Public_Static_Int32_Int32_Int32_CapMode_Boolean_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr_GetIndicesCount_Public_Static_Int32_Int32_Int32_CapMode_Boolean_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMeshVertexCount_Public_Static_Int32_0;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMeshIndicesCount_Public_Static_Int32_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMeshHDVertexCount_Public_Static_Int32_0;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMeshHDIndicesCount_Public_Static_Int32_0;

		// Token: 0x0200082B RID: 2091
		[OriginalName("Assembly-CSharp.dll", "", "CapMode")]
		public enum CapMode
		{
			// Token: 0x04008139 RID: 33081
			None,
			// Token: 0x0400813A RID: 33082
			OneVertexPerCap_1Cap,
			// Token: 0x0400813B RID: 33083
			OneVertexPerCap_2Caps,
			// Token: 0x0400813C RID: 33084
			SpecificVerticesPerCap_1Cap,
			// Token: 0x0400813D RID: 33085
			SpecificVerticesPerCap_2Caps
		}

		// Token: 0x0200082C RID: 2092
		[ObfuscatedName("VLB.MeshGenerator+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BEBA RID: 48826 RVA: 0x002ECE14 File Offset: 0x002EB014
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr);
				MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_numSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, "numSides");
				MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertCountSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, "vertCountSides");
				MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertSidesStartFromSlide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, "vertSidesStartFromSlide");
				MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertCenterFromSlide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, "vertCenterFromSlide");
				MeshGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, 100664609);
				MeshGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, 100664610);
				MeshGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__1_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, 100664611);
			}

			// Token: 0x0600BEBB RID: 48827 RVA: 0x002ECECC File Offset: 0x002EB0CC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEBC RID: 48828 RVA: 0x002ECF08 File Offset: 0x002EB108
			[CallerCount(0)]
			public unsafe int _GenerateConeZ_Radii_DoubleCaps_b__0(int slideID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref slideID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BEBD RID: 48829 RVA: 0x002ECF54 File Offset: 0x002EB154
			[CallerCount(0)]
			public unsafe int _GenerateConeZ_Radii_DoubleCaps_b__1(int slideID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref slideID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__1_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BEBE RID: 48830 RVA: 0x0005D3FC File Offset: 0x0005B5FC
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B4F RID: 15183
			// (get) Token: 0x0600BEBF RID: 48831 RVA: 0x002ECFA0 File Offset: 0x002EB1A0
			// (set) Token: 0x0600BEC0 RID: 48832 RVA: 0x0005D405 File Offset: 0x0005B605
			public unsafe int numSides
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_numSides);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_numSides)) = value;
				}
			}

			// Token: 0x17003B50 RID: 15184
			// (get) Token: 0x0600BEC1 RID: 48833 RVA: 0x002ECFC8 File Offset: 0x002EB1C8
			// (set) Token: 0x0600BEC2 RID: 48834 RVA: 0x0005D420 File Offset: 0x0005B620
			public unsafe int vertCountSides
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertCountSides);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertCountSides)) = value;
				}
			}

			// Token: 0x17003B51 RID: 15185
			// (get) Token: 0x0600BEC3 RID: 48835 RVA: 0x002ECFF0 File Offset: 0x002EB1F0
			// (set) Token: 0x0600BEC4 RID: 48836 RVA: 0x0005D43B File Offset: 0x0005B63B
			public unsafe Func<int, int> vertSidesStartFromSlide
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertSidesStartFromSlide);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertSidesStartFromSlide), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B52 RID: 15186
			// (get) Token: 0x0600BEC5 RID: 48837 RVA: 0x002ED020 File Offset: 0x002EB220
			// (set) Token: 0x0600BEC6 RID: 48838 RVA: 0x0005D45A File Offset: 0x0005B65A
			public unsafe Func<int, int> vertCenterFromSlide
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertCenterFromSlide);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertCenterFromSlide), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400813E RID: 33086
			private static readonly IntPtr NativeFieldInfoPtr_numSides;

			// Token: 0x0400813F RID: 33087
			private static readonly IntPtr NativeFieldInfoPtr_vertCountSides;

			// Token: 0x04008140 RID: 33088
			private static readonly IntPtr NativeFieldInfoPtr_vertSidesStartFromSlide;

			// Token: 0x04008141 RID: 33089
			private static readonly IntPtr NativeFieldInfoPtr_vertCenterFromSlide;

			// Token: 0x04008142 RID: 33090
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008143 RID: 33091
			private static readonly IntPtr NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__0_Internal_Int32_Int32_0;

			// Token: 0x04008144 RID: 33092
			private static readonly IntPtr NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__1_Internal_Int32_Int32_0;
		}

		// Token: 0x0200082D RID: 2093
		[ObfuscatedName("VLB.MeshGenerator+<>c__DisplayClass6_1")]
		public sealed class __c__DisplayClass6_1 : Il2CppSystem.Object
		{
			// Token: 0x0600BEC7 RID: 48839 RVA: 0x002ED050 File Offset: 0x002EB250
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_1()
			{
				Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, "<>c__DisplayClass6_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr);
				MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr, "indices");
				MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_ind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr, "ind");
				MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr, "CS$<>8__locals1");
				MeshGenerator.__c__DisplayClass6_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr, 100664612);
				MeshGenerator.__c__DisplayClass6_1.NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__2_Internal_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr, 100664613);
			}

			// Token: 0x0600BEC8 RID: 48840 RVA: 0x002ED0E0 File Offset: 0x002EB2E0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.__c__DisplayClass6_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEC9 RID: 48841 RVA: 0x002ED11C File Offset: 0x002EB31C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82521, XrefRangeEnd = 82522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GenerateConeZ_Radii_DoubleCaps_b__2(int slideID, bool invert)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref slideID;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.__c__DisplayClass6_1.NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__2_Internal_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BECA RID: 48842 RVA: 0x0005D479 File Offset: 0x0005B679
			public __c__DisplayClass6_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B53 RID: 15187
			// (get) Token: 0x0600BECB RID: 48843 RVA: 0x002ED168 File Offset: 0x002EB368
			// (set) Token: 0x0600BECC RID: 48844 RVA: 0x0005D482 File Offset: 0x0005B682
			public unsafe Il2CppStructArray<int> indices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_indices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_indices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B54 RID: 15188
			// (get) Token: 0x0600BECD RID: 48845 RVA: 0x002ED198 File Offset: 0x002EB398
			// (set) Token: 0x0600BECE RID: 48846 RVA: 0x0005D4A1 File Offset: 0x0005B6A1
			public unsafe int ind
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_ind);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_ind)) = value;
				}
			}

			// Token: 0x17003B55 RID: 15189
			// (get) Token: 0x0600BECF RID: 48847 RVA: 0x002ED1C0 File Offset: 0x002EB3C0
			// (set) Token: 0x0600BED0 RID: 48848 RVA: 0x0005D4BC File Offset: 0x0005B6BC
			public unsafe MeshGenerator.__c__DisplayClass6_0 field_Public___c__DisplayClass6_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshGenerator.__c__DisplayClass6_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008145 RID: 33093
			private static readonly IntPtr NativeFieldInfoPtr_indices;

			// Token: 0x04008146 RID: 33094
			private static readonly IntPtr NativeFieldInfoPtr_ind;

			// Token: 0x04008147 RID: 33095
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0;

			// Token: 0x04008148 RID: 33096
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008149 RID: 33097
			private static readonly IntPtr NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__2_Internal_Void_Int32_Boolean_0;
		}
	}
}
