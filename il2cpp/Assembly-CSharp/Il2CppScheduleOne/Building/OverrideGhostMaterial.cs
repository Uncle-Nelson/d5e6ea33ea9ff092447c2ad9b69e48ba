using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004C3 RID: 1219
	public class OverrideGhostMaterial : MonoBehaviour
	{
		// Token: 0x06006ACD RID: 27341 RVA: 0x000327EB File Offset: 0x000309EB
		// Note: this type is marked as 'beforefieldinit'.
		static OverrideGhostMaterial()
		{
			Il2CppClassPointerStore<OverrideGhostMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "OverrideGhostMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverrideGhostMaterial>.NativeClassPtr);
			OverrideGhostMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverrideGhostMaterial>.NativeClassPtr, 100676835);
		}

		// Token: 0x06006ACE RID: 27342 RVA: 0x001DCBB8 File Offset: 0x001DADB8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverrideGhostMaterial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverrideGhostMaterial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverrideGhostMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ACF RID: 27343 RVA: 0x00032824 File Offset: 0x00030A24
		public OverrideGhostMaterial(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004918 RID: 18712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
