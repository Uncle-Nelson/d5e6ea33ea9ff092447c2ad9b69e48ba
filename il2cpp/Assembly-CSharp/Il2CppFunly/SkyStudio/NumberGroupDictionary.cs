using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000110 RID: 272
	[Serializable]
	public class NumberGroupDictionary : SerializableDictionary<string, NumberKeyframeGroup>
	{
		// Token: 0x060015C3 RID: 5571 RVA: 0x0000CE22 File Offset: 0x0000B022
		// Note: this type is marked as 'beforefieldinit'.
		static NumberGroupDictionary()
		{
			Il2CppClassPointerStore<NumberGroupDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "NumberGroupDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberGroupDictionary>.NativeClassPtr);
			NumberGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberGroupDictionary>.NativeClassPtr, 100665560);
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x000B33F8 File Offset: 0x000B15F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90669, RefRangeEnd = 90670, XrefRangeStart = 90666, XrefRangeEnd = 90669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberGroupDictionary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberGroupDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x0000CE5B File Offset: 0x0000B05B
		public NumberGroupDictionary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
