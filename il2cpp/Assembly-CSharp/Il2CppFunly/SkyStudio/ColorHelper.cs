using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000119 RID: 281
	public class ColorHelper : Il2CppSystem.Object
	{
		// Token: 0x06001851 RID: 6225 RVA: 0x000BC4E0 File Offset: 0x000BA6E0
		// Note: this type is marked as 'beforefieldinit'.
		static ColorHelper()
		{
			Il2CppClassPointerStore<ColorHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ColorHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorHelper>.NativeClassPtr);
			ColorHelper.NativeMethodInfoPtr_ColorWithHex_Public_Static_Color_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorHelper>.NativeClassPtr, 100665886);
			ColorHelper.NativeMethodInfoPtr_ColorWithHexAlpha_Public_Static_Color_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorHelper>.NativeClassPtr, 100665887);
			ColorHelper.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorHelper>.NativeClassPtr, 100665888);
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x000BC54C File Offset: 0x000BA74C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 95270, RefRangeEnd = 95276, XrefRangeStart = 95270, XrefRangeEnd = 95270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color ColorWithHex(uint hex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorHelper.NativeMethodInfoPtr_ColorWithHex_Public_Static_Color_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x000BC58C File Offset: 0x000BA78C
		[CallerCount(0)]
		public unsafe static Color ColorWithHexAlpha(uint hex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorHelper.NativeMethodInfoPtr_ColorWithHexAlpha_Public_Static_Color_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x000BC5CC File Offset: 0x000BA7CC
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorHelper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorHelper.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x0000DFBD File Offset: 0x0000C1BD
		public ColorHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000FFD RID: 4093
		private static readonly IntPtr NativeMethodInfoPtr_ColorWithHex_Public_Static_Color_UInt32_0;

		// Token: 0x04000FFE RID: 4094
		private static readonly IntPtr NativeMethodInfoPtr_ColorWithHexAlpha_Public_Static_Color_UInt32_0;

		// Token: 0x04000FFF RID: 4095
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
