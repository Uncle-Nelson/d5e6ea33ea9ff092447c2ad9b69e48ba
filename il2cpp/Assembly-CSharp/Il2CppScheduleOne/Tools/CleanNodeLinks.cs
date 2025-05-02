using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000530 RID: 1328
	public class CleanNodeLinks : MonoBehaviour
	{
		// Token: 0x06007672 RID: 30322 RVA: 0x00203330 File Offset: 0x00201530
		// Note: this type is marked as 'beforefieldinit'.
		static CleanNodeLinks()
		{
			Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CleanNodeLinks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr);
			CleanNodeLinks.NativeMethodInfoPtr_Clean_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr, 100678209);
			CleanNodeLinks.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr, 100678210);
		}

		// Token: 0x06007673 RID: 30323 RVA: 0x00203388 File Offset: 0x00201588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230963, XrefRangeEnd = 230982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanNodeLinks.NativeMethodInfoPtr_Clean_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007674 RID: 30324 RVA: 0x002033BC File Offset: 0x002015BC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanNodeLinks() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanNodeLinks.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007675 RID: 30325 RVA: 0x0003821C File Offset: 0x0003641C
		public CleanNodeLinks(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040050E8 RID: 20712
		private static readonly IntPtr NativeMethodInfoPtr_Clean_Public_Void_0;

		// Token: 0x040050E9 RID: 20713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
