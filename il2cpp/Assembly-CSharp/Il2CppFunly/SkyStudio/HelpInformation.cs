using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200011B RID: 283
	public class HelpInformation : MonoBehaviour
	{
		// Token: 0x0600185E RID: 6238 RVA: 0x0000E009 File Offset: 0x0000C209
		// Note: this type is marked as 'beforefieldinit'.
		static HelpInformation()
		{
			Il2CppClassPointerStore<HelpInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "HelpInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelpInformation>.NativeClassPtr);
			HelpInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpInformation>.NativeClassPtr, 100665891);
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x000BC750 File Offset: 0x000BA950
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HelpInformation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelpInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelpInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x0000E042 File Offset: 0x0000C242
		public HelpInformation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001004 RID: 4100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
