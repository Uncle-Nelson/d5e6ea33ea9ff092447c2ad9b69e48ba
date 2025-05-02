using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Management.Presets.Options.SetterScreens
{
	// Token: 0x020003B1 RID: 945
	public class OptionSetterScreen : MonoBehaviour
	{
		// Token: 0x060049CA RID: 18890 RVA: 0x000238D6 File Offset: 0x00021AD6
		// Note: this type is marked as 'beforefieldinit'.
		static OptionSetterScreen()
		{
			Il2CppClassPointerStore<OptionSetterScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Presets.Options.SetterScreens", "OptionSetterScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionSetterScreen>.NativeClassPtr);
			OptionSetterScreen.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSetterScreen>.NativeClassPtr, 100672450);
		}

		// Token: 0x060049CB RID: 18891 RVA: 0x00167264 File Offset: 0x00165464
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionSetterScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionSetterScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSetterScreen.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049CC RID: 18892 RVA: 0x0002390F File Offset: 0x00021B0F
		public OptionSetterScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040031C2 RID: 12738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
