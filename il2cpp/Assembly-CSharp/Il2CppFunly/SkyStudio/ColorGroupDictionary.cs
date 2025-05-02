using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200010F RID: 271
	[Serializable]
	public class ColorGroupDictionary : SerializableDictionary<string, ColorKeyframeGroup>
	{
		// Token: 0x060015C0 RID: 5568 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		// Note: this type is marked as 'beforefieldinit'.
		static ColorGroupDictionary()
		{
			Il2CppClassPointerStore<ColorGroupDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ColorGroupDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGroupDictionary>.NativeClassPtr);
			ColorGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGroupDictionary>.NativeClassPtr, 100665559);
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x000B33BC File Offset: 0x000B15BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90665, RefRangeEnd = 90666, XrefRangeStart = 90662, XrefRangeEnd = 90665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorGroupDictionary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGroupDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x0000CE19 File Offset: 0x0000B019
		public ColorGroupDictionary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
