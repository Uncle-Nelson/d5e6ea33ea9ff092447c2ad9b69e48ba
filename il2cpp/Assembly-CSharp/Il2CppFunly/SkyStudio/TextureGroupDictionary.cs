using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000112 RID: 274
	[Serializable]
	public class TextureGroupDictionary : SerializableDictionary<string, TextureKeyframeGroup>
	{
		// Token: 0x060015C9 RID: 5577 RVA: 0x0000CEA6 File Offset: 0x0000B0A6
		// Note: this type is marked as 'beforefieldinit'.
		static TextureGroupDictionary()
		{
			Il2CppClassPointerStore<TextureGroupDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "TextureGroupDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureGroupDictionary>.NativeClassPtr);
			TextureGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureGroupDictionary>.NativeClassPtr, 100665562);
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x000B3470 File Offset: 0x000B1670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90677, RefRangeEnd = 90678, XrefRangeStart = 90674, XrefRangeEnd = 90677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureGroupDictionary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureGroupDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0000CEDF File Offset: 0x0000B0DF
		public TextureGroupDictionary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
