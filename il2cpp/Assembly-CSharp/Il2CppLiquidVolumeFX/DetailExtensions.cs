using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000D7 RID: 215
	public static class DetailExtensions : Object
	{
		// Token: 0x06000FAD RID: 4013 RVA: 0x000A1964 File Offset: 0x0009FB64
		// Note: this type is marked as 'beforefieldinit'.
		static DetailExtensions()
		{
			Il2CppClassPointerStore<DetailExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "DetailExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetailExtensions>.NativeClassPtr);
			DetailExtensions.NativeMethodInfoPtr_allowsRefraction_Public_Static_Boolean_DETAIL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailExtensions>.NativeClassPtr, 100665101);
			DetailExtensions.NativeMethodInfoPtr_usesFlask_Public_Static_Boolean_DETAIL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailExtensions>.NativeClassPtr, 100665102);
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x000A19BC File Offset: 0x0009FBBC
		[CallerCount(0)]
		public unsafe static bool allowsRefraction(this DETAIL detail)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref detail;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailExtensions.NativeMethodInfoPtr_allowsRefraction_Public_Static_Boolean_DETAIL_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x000A19FC File Offset: 0x0009FBFC
		[CallerCount(0)]
		public unsafe static bool usesFlask(this DETAIL detail)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref detail;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailExtensions.NativeMethodInfoPtr_usesFlask_Public_Static_Boolean_DETAIL_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00009D42 File Offset: 0x00007F42
		public DetailExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeMethodInfoPtr_allowsRefraction_Public_Static_Boolean_DETAIL_0;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeMethodInfoPtr_usesFlask_Public_Static_Boolean_DETAIL_0;
	}
}
