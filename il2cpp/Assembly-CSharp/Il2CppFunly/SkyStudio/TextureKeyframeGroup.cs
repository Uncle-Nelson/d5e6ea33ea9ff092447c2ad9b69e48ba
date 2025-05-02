using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000FB RID: 251
	[Serializable]
	public class TextureKeyframeGroup : KeyframeGroup<TextureKeyframe>
	{
		// Token: 0x0600132A RID: 4906 RVA: 0x000ADB1C File Offset: 0x000ABD1C
		// Note: this type is marked as 'beforefieldinit'.
		static TextureKeyframeGroup()
		{
			Il2CppClassPointerStore<TextureKeyframeGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "TextureKeyframeGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureKeyframeGroup>.NativeClassPtr);
			TextureKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_TextureKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureKeyframeGroup>.NativeClassPtr, 100665503);
			TextureKeyframeGroup.NativeMethodInfoPtr_TextureForTime_Public_Texture_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureKeyframeGroup>.NativeClassPtr, 100665504);
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x000ADB74 File Offset: 0x000ABD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90245, XrefRangeEnd = 90251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureKeyframeGroup(string name, TextureKeyframe keyframe) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureKeyframeGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyframe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_TextureKeyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x000ADBD4 File Offset: 0x000ABDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90251, XrefRangeEnd = 90261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture TextureForTime(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureKeyframeGroup.NativeMethodInfoPtr_TextureForTime_Public_Texture_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x0000B6B3 File Offset: 0x000098B3
		public TextureKeyframeGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_TextureKeyframe_0;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeMethodInfoPtr_TextureForTime_Public_Texture_Single_0;
	}
}
