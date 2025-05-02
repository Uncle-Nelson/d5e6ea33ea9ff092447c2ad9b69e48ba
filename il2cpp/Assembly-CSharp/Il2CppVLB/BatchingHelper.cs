using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200007A RID: 122
	public static class BatchingHelper : Il2CppSystem.Object
	{
		// Token: 0x0600089C RID: 2204 RVA: 0x0008AE48 File Offset: 0x00089048
		// Note: this type is marked as 'beforefieldinit'.
		static BatchingHelper()
		{
			Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "BatchingHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr);
			BatchingHelper.NativeMethodInfoPtr_IsGpuInstancingEnabled_Public_Static_Boolean_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664212);
			BatchingHelper.NativeMethodInfoPtr_SetMaterialProperties_Public_Static_Void_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664213);
			BatchingHelper.NativeMethodInfoPtr_get_forceEnableDepthBlend_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664214);
			BatchingHelper.NativeMethodInfoPtr_DoesRenderingModePreventBatching_Private_Static_Boolean_ShaderMode_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664215);
			BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamSD_VolumetricLightBeamSD_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664216);
			BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamSD_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664217);
			BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamHD_VolumetricLightBeamHD_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664218);
			BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamHD_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664219);
			BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamAbstractBase_VolumetricLightBeamAbstractBase_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664220);
			BatchingHelper.NativeMethodInfoPtr_AppendErrorMessage_Private_Static_Void_byref_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664221);
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0008AF40 File Offset: 0x00089140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79320, XrefRangeEnd = 79322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGpuInstancingEnabled(Material material)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_IsGpuInstancingEnabled_Public_Static_Boolean_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0008AF84 File Offset: 0x00089184
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79324, RefRangeEnd = 79325, XrefRangeStart = 79322, XrefRangeEnd = 79324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMaterialProperties(Material material, bool enableGpuInstancing)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableGpuInstancing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_SetMaterialProperties_Public_Static_Void_Material_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x0008AFC8 File Offset: 0x000891C8
		public unsafe static bool forceEnableDepthBlend
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 79327, RefRangeEnd = 79331, XrefRangeStart = 79325, XrefRangeEnd = 79327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_get_forceEnableDepthBlend_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0008AFF8 File Offset: 0x000891F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79353, RefRangeEnd = 79355, XrefRangeStart = 79331, XrefRangeEnd = 79353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoesRenderingModePreventBatching(ShaderMode shaderMode, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shaderMode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_DoesRenderingModePreventBatching_Private_Static_Boolean_ShaderMode_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reasons = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0008B058 File Offset: 0x00089258
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79429, RefRangeEnd = 79430, XrefRangeStart = 79355, XrefRangeEnd = 79429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBeBatched(VolumetricLightBeamSD beamA, VolumetricLightBeamSD beamB, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beamA);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beamB);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamSD_VolumetricLightBeamSD_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reasons = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0008B0CC File Offset: 0x000892CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79450, RefRangeEnd = 79452, XrefRangeStart = 79430, XrefRangeEnd = 79450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBeBatched(VolumetricLightBeamSD beam, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beam);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamSD_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reasons = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0008B130 File Offset: 0x00089330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79508, RefRangeEnd = 79509, XrefRangeStart = 79452, XrefRangeEnd = 79508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBeBatched(VolumetricLightBeamHD beamA, VolumetricLightBeamHD beamB, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beamA);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beamB);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamHD_VolumetricLightBeamHD_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reasons = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0008B1A4 File Offset: 0x000893A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79530, RefRangeEnd = 79532, XrefRangeStart = 79509, XrefRangeEnd = 79530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBeBatched(VolumetricLightBeamHD beam, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beam);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamHD_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reasons = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0008B208 File Offset: 0x00089408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79532, XrefRangeEnd = 79538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBeBatched(VolumetricLightBeamAbstractBase beamA, VolumetricLightBeamAbstractBase beamB, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beamA);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beamB);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamAbstractBase_VolumetricLightBeamAbstractBase_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reasons = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x0008B27C File Offset: 0x0008947C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 79549, RefRangeEnd = 79564, XrefRangeStart = 79538, XrefRangeEnd = 79549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendErrorMessage(ref string message, string toAppend)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(toAppend);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_AppendErrorMessage_Private_Static_Void_byref_String_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00006ABD File Offset: 0x00004CBD
		public BatchingHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_IsGpuInstancingEnabled_Public_Static_Boolean_Material_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProperties_Public_Static_Void_Material_Boolean_0;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr_get_forceEnableDepthBlend_Public_Static_get_Boolean_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr_DoesRenderingModePreventBatching_Private_Static_Boolean_ShaderMode_byref_String_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamSD_VolumetricLightBeamSD_byref_String_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamSD_byref_String_0;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamHD_VolumetricLightBeamHD_byref_String_0;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamHD_byref_String_0;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamAbstractBase_VolumetricLightBeamAbstractBase_byref_String_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_AppendErrorMessage_Private_Static_Void_byref_String_String_0;
	}
}
