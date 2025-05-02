using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004B2 RID: 1202
	public class ActivateDuringBuild : MonoBehaviour
	{
		// Token: 0x060069CD RID: 27085 RVA: 0x00032041 File Offset: 0x00030241
		// Note: this type is marked as 'beforefieldinit'.
		static ActivateDuringBuild()
		{
			Il2CppClassPointerStore<ActivateDuringBuild>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "ActivateDuringBuild");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivateDuringBuild>.NativeClassPtr);
			ActivateDuringBuild.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateDuringBuild>.NativeClassPtr, 100676728);
		}

		// Token: 0x060069CE RID: 27086 RVA: 0x001D96A4 File Offset: 0x001D78A4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivateDuringBuild() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivateDuringBuild>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivateDuringBuild.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069CF RID: 27087 RVA: 0x0003207A File Offset: 0x0003027A
		public ActivateDuringBuild(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004876 RID: 18550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
