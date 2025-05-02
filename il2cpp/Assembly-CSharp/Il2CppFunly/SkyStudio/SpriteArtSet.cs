using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000E4 RID: 228
	public class SpriteArtSet : BaseArtSet
	{
		// Token: 0x06001228 RID: 4648 RVA: 0x0000B0CF File Offset: 0x000092CF
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteArtSet()
		{
			Il2CppClassPointerStore<SpriteArtSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "SpriteArtSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteArtSet>.NativeClassPtr);
			SpriteArtSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteArtSet>.NativeClassPtr, 100665368);
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x000A95DC File Offset: 0x000A77DC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88919, RefRangeEnd = 88931, XrefRangeStart = 88919, XrefRangeEnd = 88931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteArtSet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteArtSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteArtSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0000B108 File Offset: 0x00009308
		public SpriteArtSet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
