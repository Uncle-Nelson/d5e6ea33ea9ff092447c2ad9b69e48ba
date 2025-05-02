using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000B0 RID: 176
	public static class SpotLightHelper : Il2CppSystem.Object
	{
		// Token: 0x06000D25 RID: 3365 RVA: 0x0009A874 File Offset: 0x00098A74
		// Note: this type is marked as 'beforefieldinit'.
		static SpotLightHelper()
		{
			Il2CppClassPointerStore<SpotLightHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "SpotLightHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpotLightHelper>.NativeClassPtr);
			SpotLightHelper.NativeMethodInfoPtr_GetIntensity_Public_Static_Single_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotLightHelper>.NativeClassPtr, 100664902);
			SpotLightHelper.NativeMethodInfoPtr_GetSpotAngle_Public_Static_Single_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotLightHelper>.NativeClassPtr, 100664903);
			SpotLightHelper.NativeMethodInfoPtr_GetFallOffEnd_Public_Static_Single_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotLightHelper>.NativeClassPtr, 100664904);
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x0009A8E0 File Offset: 0x00098AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84386, XrefRangeEnd = 84391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetIntensity(Light light)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotLightHelper.NativeMethodInfoPtr_GetIntensity_Public_Static_Single_Light_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x0009A924 File Offset: 0x00098B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84391, XrefRangeEnd = 84396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetSpotAngle(Light light)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotLightHelper.NativeMethodInfoPtr_GetSpotAngle_Public_Static_Single_Light_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x0009A968 File Offset: 0x00098B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84396, XrefRangeEnd = 84401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFallOffEnd(Light light)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotLightHelper.NativeMethodInfoPtr_GetFallOffEnd_Public_Static_Single_Light_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00008773 File Offset: 0x00006973
		public SpotLightHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeMethodInfoPtr_GetIntensity_Public_Static_Single_Light_0;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr_GetSpotAngle_Public_Static_Single_Light_0;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeMethodInfoPtr_GetFallOffEnd_Public_Static_Single_Light_0;
	}
}
