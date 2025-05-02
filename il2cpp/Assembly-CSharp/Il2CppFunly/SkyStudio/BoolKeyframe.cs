using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000FD RID: 253
	[Serializable]
	public class BoolKeyframe : BaseKeyframe
	{
		// Token: 0x06001342 RID: 4930 RVA: 0x000AE090 File Offset: 0x000AC290
		// Note: this type is marked as 'beforefieldinit'.
		static BoolKeyframe()
		{
			Il2CppClassPointerStore<BoolKeyframe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "BoolKeyframe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolKeyframe>.NativeClassPtr);
			BoolKeyframe.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolKeyframe>.NativeClassPtr, "value");
			BoolKeyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolKeyframe>.NativeClassPtr, 100665515);
			BoolKeyframe.NativeMethodInfoPtr__ctor_Public_Void_BoolKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolKeyframe>.NativeClassPtr, 100665516);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x000AE0FC File Offset: 0x000AC2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90273, XrefRangeEnd = 90277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolKeyframe(float time, bool value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolKeyframe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolKeyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x000AE154 File Offset: 0x000AC354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90277, XrefRangeEnd = 90281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolKeyframe(BoolKeyframe keyframe) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolKeyframe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyframe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolKeyframe.NativeMethodInfoPtr__ctor_Public_Void_BoolKeyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x0000B735 File Offset: 0x00009935
		public BoolKeyframe(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x000AE1A0 File Offset: 0x000AC3A0
		// (set) Token: 0x06001347 RID: 4935 RVA: 0x0000B73E File Offset: 0x0000993E
		public unsafe bool value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolKeyframe.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolKeyframe.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BoolKeyframe_0;
	}
}
