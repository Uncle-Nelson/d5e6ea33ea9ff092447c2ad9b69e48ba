using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Clothing
{
	// Token: 0x0200049E RID: 1182
	public static class ClothingColorExtensions : Il2CppSystem.Object
	{
		// Token: 0x0600665C RID: 26204 RVA: 0x001CCB44 File Offset: 0x001CAD44
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingColorExtensions()
		{
			Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Clothing", "ClothingColorExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr);
			ClothingColorExtensions.NativeMethodInfoPtr_GetActualColor_Public_Static_Color_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100676243);
			ClothingColorExtensions.NativeMethodInfoPtr_GetLabelColor_Public_Static_Color_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100676244);
			ClothingColorExtensions.NativeMethodInfoPtr_GetLabel_Public_Static_String_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100676245);
			ClothingColorExtensions.NativeMethodInfoPtr_GetClothingColor_Public_Static_EClothingColor_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100676246);
			ClothingColorExtensions.NativeMethodInfoPtr_ColorEquals_Public_Static_Boolean_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100676247);
		}

		// Token: 0x0600665D RID: 26205 RVA: 0x001CCBD8 File Offset: 0x001CADD8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 207153, RefRangeEnd = 207161, XrefRangeStart = 207148, XrefRangeEnd = 207153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetActualColor(this EClothingColor color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_GetActualColor_Public_Static_Color_EClothingColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600665E RID: 26206 RVA: 0x001CCC18 File Offset: 0x001CAE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207161, XrefRangeEnd = 207166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetLabelColor(this EClothingColor color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_GetLabelColor_Public_Static_Color_EClothingColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600665F RID: 26207 RVA: 0x001CCC58 File Offset: 0x001CAE58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207169, RefRangeEnd = 207171, XrefRangeStart = 207166, XrefRangeEnd = 207169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLabel(this EClothingColor color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_GetLabel_Public_Static_String_EClothingColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006660 RID: 26208 RVA: 0x001CCC90 File Offset: 0x001CAE90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207199, RefRangeEnd = 207202, XrefRangeStart = 207171, XrefRangeEnd = 207199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EClothingColor GetClothingColor(Color color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_GetClothingColor_Public_Static_EClothingColor_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006661 RID: 26209 RVA: 0x001CCCD0 File Offset: 0x001CAED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207202, RefRangeEnd = 207203, XrefRangeStart = 207202, XrefRangeEnd = 207202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ColorEquals(Color a, Color b, float tolerance = 0.004f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tolerance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_ColorEquals_Public_Static_Boolean_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006662 RID: 26210 RVA: 0x000306B8 File Offset: 0x0002E8B8
		public ClothingColorExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040045F9 RID: 17913
		private static readonly IntPtr NativeMethodInfoPtr_GetActualColor_Public_Static_Color_EClothingColor_0;

		// Token: 0x040045FA RID: 17914
		private static readonly IntPtr NativeMethodInfoPtr_GetLabelColor_Public_Static_Color_EClothingColor_0;

		// Token: 0x040045FB RID: 17915
		private static readonly IntPtr NativeMethodInfoPtr_GetLabel_Public_Static_String_EClothingColor_0;

		// Token: 0x040045FC RID: 17916
		private static readonly IntPtr NativeMethodInfoPtr_GetClothingColor_Public_Static_EClothingColor_Color_0;

		// Token: 0x040045FD RID: 17917
		private static readonly IntPtr NativeMethodInfoPtr_ColorEquals_Public_Static_Boolean_Color_Color_Single_0;
	}
}
