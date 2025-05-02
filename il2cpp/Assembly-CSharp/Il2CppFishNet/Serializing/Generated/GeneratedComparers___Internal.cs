using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppFishNet.Serializing.Generated
{
	// Token: 0x0200079F RID: 1951
	[StructLayout(3, CharSet = 4)]
	public static class GeneratedComparers___Internal : Object
	{
		// Token: 0x0600B876 RID: 47222 RVA: 0x0005A860 File Offset: 0x00058A60
		// Note: this type is marked as 'beforefieldinit'.
		static GeneratedComparers___Internal()
		{
			Il2CppClassPointerStore<GeneratedComparers___Internal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishNet.Serializing.Generated", "GeneratedComparers___Internal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneratedComparers___Internal>.NativeClassPtr);
			GeneratedComparers___Internal.NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedComparers___Internal>.NativeClassPtr, 100685968);
		}

		// Token: 0x0600B877 RID: 47223 RVA: 0x002DC13C File Offset: 0x002DA33C
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeOnce()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedComparers___Internal.NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B878 RID: 47224 RVA: 0x0005A899 File Offset: 0x00058A99
		public GeneratedComparers___Internal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04007C43 RID: 31811
		private static readonly IntPtr NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0;
	}
}
