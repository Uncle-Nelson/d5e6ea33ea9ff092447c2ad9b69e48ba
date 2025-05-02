using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200004D RID: 77
	public sealed class TrackballGroupAttribute : PropertyAttribute
	{
		// Token: 0x06000630 RID: 1584 RVA: 0x00005A47 File Offset: 0x00003C47
		// Note: this type is marked as 'beforefieldinit'.
		static TrackballGroupAttribute()
		{
			Il2CppClassPointerStore<TrackballGroupAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "TrackballGroupAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackballGroupAttribute>.NativeClassPtr);
			TrackballGroupAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackballGroupAttribute>.NativeClassPtr, 100663871);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00082BEC File Offset: 0x00080DEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75787, RefRangeEnd = 75789, XrefRangeStart = 75786, XrefRangeEnd = 75787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackballGroupAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackballGroupAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackballGroupAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00005A80 File Offset: 0x00003C80
		public TrackballGroupAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
