using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000111 RID: 273
	[Serializable]
	public class SpherePointGroupDictionary : SerializableDictionary<string, SpherePointKeyframeGroup>
	{
		// Token: 0x060015C6 RID: 5574 RVA: 0x0000CE64 File Offset: 0x0000B064
		// Note: this type is marked as 'beforefieldinit'.
		static SpherePointGroupDictionary()
		{
			Il2CppClassPointerStore<SpherePointGroupDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "SpherePointGroupDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpherePointGroupDictionary>.NativeClassPtr);
			SpherePointGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePointGroupDictionary>.NativeClassPtr, 100665561);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x000B3434 File Offset: 0x000B1634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90673, RefRangeEnd = 90674, XrefRangeStart = 90670, XrefRangeEnd = 90673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePointGroupDictionary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpherePointGroupDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePointGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x0000CE9D File Offset: 0x0000B09D
		public SpherePointGroupDictionary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
