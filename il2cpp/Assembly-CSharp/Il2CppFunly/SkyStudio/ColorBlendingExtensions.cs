using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000E7 RID: 231
	public static class ColorBlendingExtensions : Il2CppSystem.Object
	{
		// Token: 0x06001246 RID: 4678 RVA: 0x0000B151 File Offset: 0x00009351
		// Note: this type is marked as 'beforefieldinit'.
		static ColorBlendingExtensions()
		{
			Il2CppClassPointerStore<ColorBlendingExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ColorBlendingExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorBlendingExtensions>.NativeClassPtr);
			ColorBlendingExtensions.NativeMethodInfoPtr_Clear_Public_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlendingExtensions>.NativeClassPtr, 100665390);
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x000A9F58 File Offset: 0x000A8158
		[CallerCount(0)]
		public unsafe static Color Clear(this Color color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlendingExtensions.NativeMethodInfoPtr_Clear_Public_Static_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x0000B18A File Offset: 0x0000938A
		public ColorBlendingExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Color_Color_0;
	}
}
