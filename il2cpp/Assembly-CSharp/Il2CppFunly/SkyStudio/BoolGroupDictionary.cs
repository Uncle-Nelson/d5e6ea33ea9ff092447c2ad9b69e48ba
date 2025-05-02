using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200010E RID: 270
	[Serializable]
	public class BoolGroupDictionary : SerializableDictionary<string, BoolKeyframeGroup>
	{
		// Token: 0x060015BD RID: 5565 RVA: 0x0000CD9E File Offset: 0x0000AF9E
		// Note: this type is marked as 'beforefieldinit'.
		static BoolGroupDictionary()
		{
			Il2CppClassPointerStore<BoolGroupDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "BoolGroupDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolGroupDictionary>.NativeClassPtr);
			BoolGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolGroupDictionary>.NativeClassPtr, 100665558);
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x000B3380 File Offset: 0x000B1580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90661, RefRangeEnd = 90662, XrefRangeStart = 90658, XrefRangeEnd = 90661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolGroupDictionary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolGroupDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x0000CDD7 File Offset: 0x0000AFD7
		public BoolGroupDictionary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
