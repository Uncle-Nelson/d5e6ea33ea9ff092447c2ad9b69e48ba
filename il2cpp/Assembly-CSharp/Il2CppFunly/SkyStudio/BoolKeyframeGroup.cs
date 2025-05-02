using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000F5 RID: 245
	[Serializable]
	public class BoolKeyframeGroup : KeyframeGroup<BoolKeyframe>
	{
		// Token: 0x060012DC RID: 4828 RVA: 0x000AC324 File Offset: 0x000AA524
		// Note: this type is marked as 'beforefieldinit'.
		static BoolKeyframeGroup()
		{
			Il2CppClassPointerStore<BoolKeyframeGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "BoolKeyframeGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolKeyframeGroup>.NativeClassPtr);
			BoolKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolKeyframeGroup>.NativeClassPtr, 100665455);
			BoolKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_BoolKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolKeyframeGroup>.NativeClassPtr, 100665456);
			BoolKeyframeGroup.NativeMethodInfoPtr_BoolForTime_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolKeyframeGroup>.NativeClassPtr, 100665457);
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x000AC390 File Offset: 0x000AA590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89996, XrefRangeEnd = 89999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolKeyframeGroup(string name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolKeyframeGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x000AC3DC File Offset: 0x000AA5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89999, XrefRangeEnd = 90005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolKeyframeGroup(string name, BoolKeyframe keyframe) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolKeyframeGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyframe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_BoolKeyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x000AC43C File Offset: 0x000AA63C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90017, RefRangeEnd = 90018, XrefRangeStart = 90005, XrefRangeEnd = 90017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BoolForTime(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolKeyframeGroup.NativeMethodInfoPtr_BoolForTime_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x0000B5B2 File Offset: 0x000097B2
		public BoolKeyframeGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_BoolKeyframe_0;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr_BoolForTime_Public_Boolean_Single_0;
	}
}
