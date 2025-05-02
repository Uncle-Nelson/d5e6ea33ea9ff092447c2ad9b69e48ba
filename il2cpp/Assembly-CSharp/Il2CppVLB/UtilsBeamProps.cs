using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000B5 RID: 181
	public static class UtilsBeamProps : Il2CppSystem.Object
	{
		// Token: 0x06000D80 RID: 3456 RVA: 0x0009BFDC File Offset: 0x0009A1DC
		// Note: this type is marked as 'beforefieldinit'.
		static UtilsBeamProps()
		{
			Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "UtilsBeamProps");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr);
			UtilsBeamProps.NativeMethodInfoPtr_CanChangeDuringPlaytime_Public_Static_Boolean_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664960);
			UtilsBeamProps.NativeMethodInfoPtr_GetInternalLocalRotation_Public_Static_Quaternion_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664961);
			UtilsBeamProps.NativeMethodInfoPtr_GetThickness_Public_Static_Single_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664962);
			UtilsBeamProps.NativeMethodInfoPtr_GetFallOffEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664963);
			UtilsBeamProps.NativeMethodInfoPtr_GetColorMode_Public_Static_ColorMode_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664964);
			UtilsBeamProps.NativeMethodInfoPtr_GetColorFlat_Public_Static_Color_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664965);
			UtilsBeamProps.NativeMethodInfoPtr_GetColorGradient_Public_Static_Gradient_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664966);
			UtilsBeamProps.NativeMethodInfoPtr_GetConeAngle_Public_Static_Single_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664967);
			UtilsBeamProps.NativeMethodInfoPtr_GetConeRadiusStart_Public_Static_Single_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664968);
			UtilsBeamProps.NativeMethodInfoPtr_GetConeRadiusEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664969);
			UtilsBeamProps.NativeMethodInfoPtr_GetSortingLayerID_Public_Static_Int32_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664970);
			UtilsBeamProps.NativeMethodInfoPtr_GetSortingOrder_Public_Static_Int32_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664971);
			UtilsBeamProps.NativeMethodInfoPtr_GetFadeOutEnabled_Public_Static_Boolean_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664972);
			UtilsBeamProps.NativeMethodInfoPtr_GetFadeOutEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664973);
			UtilsBeamProps.NativeMethodInfoPtr_GetDimensions_Public_Static_Dimensions_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664974);
			UtilsBeamProps.NativeMethodInfoPtr_GetGeomSides_Public_Static_Int32_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664975);
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0009C14C File Offset: 0x0009A34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84790, XrefRangeEnd = 84798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanChangeDuringPlaytime(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_CanChangeDuringPlaytime_Public_Static_Boolean_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0009C190 File Offset: 0x0009A390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84798, XrefRangeEnd = 84816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion GetInternalLocalRotation(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetInternalLocalRotation_Public_Static_Quaternion_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0009C1D4 File Offset: 0x0009A3D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84830, RefRangeEnd = 84831, XrefRangeStart = 84816, XrefRangeEnd = 84830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetThickness(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetThickness_Public_Static_Single_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0009C218 File Offset: 0x0009A418
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84845, RefRangeEnd = 84848, XrefRangeStart = 84831, XrefRangeEnd = 84845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFallOffEnd(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetFallOffEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0009C25C File Offset: 0x0009A45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84848, XrefRangeEnd = 84863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ColorMode GetColorMode(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetColorMode_Public_Static_ColorMode_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0009C2A0 File Offset: 0x0009A4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84863, XrefRangeEnd = 84877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetColorFlat(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetColorFlat_Public_Static_Color_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0009C2E4 File Offset: 0x0009A4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84877, XrefRangeEnd = 84891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Gradient GetColorGradient(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetColorGradient_Public_Static_Gradient_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr3) : null;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0009C328 File Offset: 0x0009A528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84905, RefRangeEnd = 84906, XrefRangeStart = 84891, XrefRangeEnd = 84905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetConeAngle(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetConeAngle_Public_Static_Single_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0009C36C File Offset: 0x0009A56C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84920, RefRangeEnd = 84922, XrefRangeStart = 84906, XrefRangeEnd = 84920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetConeRadiusStart(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetConeRadiusStart_Public_Static_Single_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0009C3B0 File Offset: 0x0009A5B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84936, RefRangeEnd = 84937, XrefRangeStart = 84922, XrefRangeEnd = 84936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetConeRadiusEnd(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetConeRadiusEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0009C3F4 File Offset: 0x0009A5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84937, XrefRangeEnd = 84951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSortingLayerID(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetSortingLayerID_Public_Static_Int32_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0009C438 File Offset: 0x0009A638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84951, XrefRangeEnd = 84965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSortingOrder(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetSortingOrder_Public_Static_Int32_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0009C47C File Offset: 0x0009A67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84965, XrefRangeEnd = 84973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetFadeOutEnabled(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetFadeOutEnabled_Public_Static_Boolean_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0009C4C0 File Offset: 0x0009A6C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84973, XrefRangeEnd = 84981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFadeOutEnd(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetFadeOutEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0009C504 File Offset: 0x0009A704
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84995, RefRangeEnd = 84998, XrefRangeStart = 84981, XrefRangeEnd = 84995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dimensions GetDimensions(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetDimensions_Public_Static_Dimensions_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0009C548 File Offset: 0x0009A748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84998, XrefRangeEnd = 85006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGeomSides(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetGeomSides_Public_Static_Int32_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x000088D2 File Offset: 0x00006AD2
		public UtilsBeamProps(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeMethodInfoPtr_CanChangeDuringPlaytime_Public_Static_Boolean_VolumetricLightBeamAbstractBase_0;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalLocalRotation_Public_Static_Quaternion_VolumetricLightBeamAbstractBase_0;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeMethodInfoPtr_GetThickness_Public_Static_Single_VolumetricLightBeamAbstractBase_0;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeMethodInfoPtr_GetFallOffEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeMethodInfoPtr_GetColorMode_Public_Static_ColorMode_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeMethodInfoPtr_GetColorFlat_Public_Static_Color_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeMethodInfoPtr_GetColorGradient_Public_Static_Gradient_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeMethodInfoPtr_GetConeAngle_Public_Static_Single_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeMethodInfoPtr_GetConeRadiusStart_Public_Static_Single_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeMethodInfoPtr_GetConeRadiusEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeMethodInfoPtr_GetSortingLayerID_Public_Static_Int32_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeMethodInfoPtr_GetSortingOrder_Public_Static_Int32_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeMethodInfoPtr_GetFadeOutEnabled_Public_Static_Boolean_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeMethodInfoPtr_GetFadeOutEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeMethodInfoPtr_GetDimensions_Public_Static_Dimensions_VolumetricLightBeamAbstractBase_0;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeMethodInfoPtr_GetGeomSides_Public_Static_Int32_VolumetricLightBeamAbstractBase_0;
	}
}
