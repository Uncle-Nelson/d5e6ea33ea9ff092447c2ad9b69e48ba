using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200009E RID: 158
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		// Token: 0x06000AF3 RID: 2803 RVA: 0x00007A0A File Offset: 0x00005C0A
		// Note: this type is marked as 'beforefieldinit'.
		static HighlightNullAttribute()
		{
			Il2CppClassPointerStore<HighlightNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "HighlightNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HighlightNullAttribute>.NativeClassPtr);
			HighlightNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightNullAttribute>.NativeClassPtr, 100664543);
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00093044 File Offset: 0x00091244
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75787, RefRangeEnd = 75789, XrefRangeStart = 75787, XrefRangeEnd = 75789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HighlightNullAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HighlightNullAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00007A43 File Offset: 0x00005C43
		public HighlightNullAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
