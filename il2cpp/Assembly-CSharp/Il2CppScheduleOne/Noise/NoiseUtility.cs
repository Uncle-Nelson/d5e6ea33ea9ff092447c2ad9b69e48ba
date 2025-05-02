using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Noise
{
	// Token: 0x0200036D RID: 877
	public static class NoiseUtility : Il2CppSystem.Object
	{
		// Token: 0x06004480 RID: 17536 RVA: 0x0002175D File Offset: 0x0001F95D
		// Note: this type is marked as 'beforefieldinit'.
		static NoiseUtility()
		{
			Il2CppClassPointerStore<NoiseUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Noise", "NoiseUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoiseUtility>.NativeClassPtr);
			NoiseUtility.NativeMethodInfoPtr_EmitNoise_Public_Static_Void_Vector3_ENoiseType_Single_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtility>.NativeClassPtr, 100671659);
		}

		// Token: 0x06004481 RID: 17537 RVA: 0x00152880 File Offset: 0x00150A80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 155095, RefRangeEnd = 155098, XrefRangeStart = 155063, XrefRangeEnd = 155095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EmitNoise(Vector3 origin, ENoiseType type, float range, GameObject source = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref range;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoiseUtility.NativeMethodInfoPtr_EmitNoise_Public_Static_Void_Vector3_ENoiseType_Single_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004482 RID: 17538 RVA: 0x00021796 File Offset: 0x0001F996
		public NoiseUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002DDF RID: 11743
		private static readonly IntPtr NativeMethodInfoPtr_EmitNoise_Public_Static_Void_Vector3_ENoiseType_Single_GameObject_0;
	}
}
