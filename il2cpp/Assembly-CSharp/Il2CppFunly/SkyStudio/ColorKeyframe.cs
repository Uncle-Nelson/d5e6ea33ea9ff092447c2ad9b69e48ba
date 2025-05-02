using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000FE RID: 254
	[Serializable]
	public class ColorKeyframe : BaseKeyframe
	{
		// Token: 0x06001348 RID: 4936 RVA: 0x000AE1C8 File Offset: 0x000AC3C8
		// Note: this type is marked as 'beforefieldinit'.
		static ColorKeyframe()
		{
			Il2CppClassPointerStore<ColorKeyframe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ColorKeyframe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorKeyframe>.NativeClassPtr);
			ColorKeyframe.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorKeyframe>.NativeClassPtr, "color");
			ColorKeyframe.NativeMethodInfoPtr__ctor_Public_Void_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorKeyframe>.NativeClassPtr, 100665517);
			ColorKeyframe.NativeMethodInfoPtr__ctor_Public_Void_ColorKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorKeyframe>.NativeClassPtr, 100665518);
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x000AE234 File Offset: 0x000AC434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90281, XrefRangeEnd = 90285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorKeyframe(Color c, float time) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorKeyframe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref c;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorKeyframe.NativeMethodInfoPtr__ctor_Public_Void_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x000AE28C File Offset: 0x000AC48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90285, XrefRangeEnd = 90289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorKeyframe(ColorKeyframe keyframe) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorKeyframe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyframe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorKeyframe.NativeMethodInfoPtr__ctor_Public_Void_ColorKeyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x0000B759 File Offset: 0x00009959
		public ColorKeyframe(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x000AE2D8 File Offset: 0x000AC4D8
		// (set) Token: 0x0600134D RID: 4941 RVA: 0x0000B762 File Offset: 0x00009962
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorKeyframe.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorKeyframe.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Single_0;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ColorKeyframe_0;
	}
}
