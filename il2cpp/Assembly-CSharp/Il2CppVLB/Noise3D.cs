using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000A4 RID: 164
	public static class Noise3D : Il2CppSystem.Object
	{
		// Token: 0x06000B3C RID: 2876 RVA: 0x00094384 File Offset: 0x00092584
		// Note: this type is marked as 'beforefieldinit'.
		static Noise3D()
		{
			Il2CppClassPointerStore<Noise3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "Noise3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Noise3D>.NativeClassPtr);
			Noise3D.NativeFieldInfoPtr_ms_IsSupportedChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, "ms_IsSupportedChecked");
			Noise3D.NativeFieldInfoPtr_ms_IsSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, "ms_IsSupported");
			Noise3D.NativeFieldInfoPtr_ms_NoiseTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, "ms_NoiseTexture");
			Noise3D.NativeFieldInfoPtr_kMinShaderLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, "kMinShaderLevel");
			Noise3D.NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100664630);
			Noise3D.NativeMethodInfoPtr_get_isProperlyLoaded_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100664631);
			Noise3D.NativeMethodInfoPtr_get_isNotSupportedString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100664632);
			Noise3D.NativeMethodInfoPtr_OnStartUp_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100664633);
			Noise3D.NativeMethodInfoPtr_LoadIfNeeded_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100664634);
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00094468 File Offset: 0x00092668
		public unsafe static bool isSupported
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 82686, RefRangeEnd = 82696, XrefRangeStart = 82666, XrefRangeEnd = 82686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x00094498 File Offset: 0x00092698
		public unsafe static bool isProperlyLoaded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82696, XrefRangeEnd = 82702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_get_isProperlyLoaded_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x000944C8 File Offset: 0x000926C8
		public unsafe static string isNotSupportedString
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 82711, RefRangeEnd = 82712, XrefRangeStart = 82702, XrefRangeEnd = 82711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_get_isNotSupportedString_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x000944F4 File Offset: 0x000926F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82712, XrefRangeEnd = 82713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnStartUp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_OnStartUp_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0009451C File Offset: 0x0009271C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 82732, RefRangeEnd = 82735, XrefRangeStart = 82713, XrefRangeEnd = 82732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadIfNeeded()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_LoadIfNeeded_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00007B57 File Offset: 0x00005D57
		public Noise3D(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00094544 File Offset: 0x00092744
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x00007B60 File Offset: 0x00005D60
		public unsafe static bool ms_IsSupportedChecked
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Noise3D.NativeFieldInfoPtr_ms_IsSupportedChecked, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Noise3D.NativeFieldInfoPtr_ms_IsSupportedChecked, (void*)(&value));
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00094560 File Offset: 0x00092760
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x00007B6E File Offset: 0x00005D6E
		public unsafe static bool ms_IsSupported
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Noise3D.NativeFieldInfoPtr_ms_IsSupported, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Noise3D.NativeFieldInfoPtr_ms_IsSupported, (void*)(&value));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x0009457C File Offset: 0x0009277C
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x00007B7C File Offset: 0x00005D7C
		public unsafe static Texture3D ms_NoiseTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Noise3D.NativeFieldInfoPtr_ms_NoiseTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Noise3D.NativeFieldInfoPtr_ms_NoiseTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x000945A4 File Offset: 0x000927A4
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x00007B8E File Offset: 0x00005D8E
		public unsafe static int kMinShaderLevel
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Noise3D.NativeFieldInfoPtr_kMinShaderLevel, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Noise3D.NativeFieldInfoPtr_kMinShaderLevel, (void*)(&value));
			}
		}

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeFieldInfoPtr_ms_IsSupportedChecked;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeFieldInfoPtr_ms_IsSupported;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeFieldInfoPtr_ms_NoiseTexture;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeFieldInfoPtr_kMinShaderLevel;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr_get_isProperlyLoaded_Public_Static_get_Boolean_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr_get_isNotSupportedString_Public_Static_get_String_0;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr_OnStartUp_Private_Static_Void_0;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_LoadIfNeeded_Public_Static_Void_0;
	}
}
