using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000DE RID: 222
	public class BaseArtSet : ScriptableObject
	{
		// Token: 0x060011F6 RID: 4598 RVA: 0x0000AE9C File Offset: 0x0000909C
		// Note: this type is marked as 'beforefieldinit'.
		static BaseArtSet()
		{
			Il2CppClassPointerStore<BaseArtSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "BaseArtSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseArtSet>.NativeClassPtr);
			BaseArtSet.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseArtSet>.NativeClassPtr, 100665362);
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x000A8F38 File Offset: 0x000A7138
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88919, RefRangeEnd = 88931, XrefRangeStart = 88919, XrefRangeEnd = 88931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseArtSet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseArtSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseArtSet.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x0000AED5 File Offset: 0x000090D5
		public BaseArtSet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
