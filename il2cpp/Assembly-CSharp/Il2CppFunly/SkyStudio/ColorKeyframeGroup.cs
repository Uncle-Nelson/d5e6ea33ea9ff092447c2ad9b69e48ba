using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000F6 RID: 246
	[Serializable]
	public class ColorKeyframeGroup : KeyframeGroup<ColorKeyframe>
	{
		// Token: 0x060012E1 RID: 4833 RVA: 0x000AC488 File Offset: 0x000AA688
		// Note: this type is marked as 'beforefieldinit'.
		static ColorKeyframeGroup()
		{
			Il2CppClassPointerStore<ColorKeyframeGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ColorKeyframeGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorKeyframeGroup>.NativeClassPtr);
			ColorKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorKeyframeGroup>.NativeClassPtr, 100665458);
			ColorKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_ColorKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorKeyframeGroup>.NativeClassPtr, 100665459);
			ColorKeyframeGroup.NativeMethodInfoPtr_ColorForTime_Public_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorKeyframeGroup>.NativeClassPtr, 100665460);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x000AC4F4 File Offset: 0x000AA6F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90018, XrefRangeEnd = 90021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorKeyframeGroup(string name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorKeyframeGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x000AC540 File Offset: 0x000AA740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90021, XrefRangeEnd = 90027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorKeyframeGroup(string name, ColorKeyframe frame) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorKeyframeGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(frame);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_ColorKeyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x000AC5A0 File Offset: 0x000AA7A0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 90048, RefRangeEnd = 90056, XrefRangeStart = 90027, XrefRangeEnd = 90048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color ColorForTime(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorKeyframeGroup.NativeMethodInfoPtr_ColorForTime_Public_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0000B5BB File Offset: 0x000097BB
		public ColorKeyframeGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ColorKeyframe_0;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeMethodInfoPtr_ColorForTime_Public_Color_Single_0;
	}
}
