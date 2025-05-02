using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000DD RID: 221
	public class BaseArtItem : ScriptableObject
	{
		// Token: 0x060011F3 RID: 4595 RVA: 0x0000AE5A File Offset: 0x0000905A
		// Note: this type is marked as 'beforefieldinit'.
		static BaseArtItem()
		{
			Il2CppClassPointerStore<BaseArtItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "BaseArtItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseArtItem>.NativeClassPtr);
			BaseArtItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseArtItem>.NativeClassPtr, 100665361);
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x000A8EFC File Offset: 0x000A70FC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88919, RefRangeEnd = 88931, XrefRangeStart = 88918, XrefRangeEnd = 88919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseArtItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseArtItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseArtItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x0000AE93 File Offset: 0x00009093
		public BaseArtItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
