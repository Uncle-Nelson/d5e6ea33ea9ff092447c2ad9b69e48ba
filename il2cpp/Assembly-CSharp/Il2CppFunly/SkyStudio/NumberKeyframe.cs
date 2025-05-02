using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000102 RID: 258
	[Serializable]
	public class NumberKeyframe : BaseKeyframe
	{
		// Token: 0x06001357 RID: 4951 RVA: 0x000AE5B4 File Offset: 0x000AC7B4
		// Note: this type is marked as 'beforefieldinit'.
		static NumberKeyframe()
		{
			Il2CppClassPointerStore<NumberKeyframe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "NumberKeyframe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberKeyframe>.NativeClassPtr);
			NumberKeyframe.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberKeyframe>.NativeClassPtr, "value");
			NumberKeyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberKeyframe>.NativeClassPtr, 100665526);
			NumberKeyframe.NativeMethodInfoPtr__ctor_Public_Void_NumberKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberKeyframe>.NativeClassPtr, 100665527);
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x000AE620 File Offset: 0x000AC820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90289, XrefRangeEnd = 90293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberKeyframe(float time, float value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberKeyframe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberKeyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x000AE678 File Offset: 0x000AC878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90293, XrefRangeEnd = 90297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberKeyframe(NumberKeyframe keyframe) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberKeyframe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyframe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberKeyframe.NativeMethodInfoPtr__ctor_Public_Void_NumberKeyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0000B786 File Offset: 0x00009986
		public NumberKeyframe(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x0600135B RID: 4955 RVA: 0x000AE6C4 File Offset: 0x000AC8C4
		// (set) Token: 0x0600135C RID: 4956 RVA: 0x0000B78F File Offset: 0x0000998F
		public unsafe float value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberKeyframe.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberKeyframe.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NumberKeyframe_0;
	}
}
