using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000F9 RID: 249
	[Serializable]
	public class NumberKeyframeGroup : KeyframeGroup<NumberKeyframe>
	{
		// Token: 0x06001310 RID: 4880 RVA: 0x000AD574 File Offset: 0x000AB774
		// Note: this type is marked as 'beforefieldinit'.
		static NumberKeyframeGroup()
		{
			Il2CppClassPointerStore<NumberKeyframeGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "NumberKeyframeGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberKeyframeGroup>.NativeClassPtr);
			NumberKeyframeGroup.NativeFieldInfoPtr_minValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberKeyframeGroup>.NativeClassPtr, "minValue");
			NumberKeyframeGroup.NativeFieldInfoPtr_maxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberKeyframeGroup>.NativeClassPtr, "maxValue");
			NumberKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberKeyframeGroup>.NativeClassPtr, 100665493);
			NumberKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_NumberKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberKeyframeGroup>.NativeClassPtr, 100665494);
			NumberKeyframeGroup.NativeMethodInfoPtr_GetFirstValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberKeyframeGroup>.NativeClassPtr, 100665495);
			NumberKeyframeGroup.NativeMethodInfoPtr_ValueToPercent_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberKeyframeGroup>.NativeClassPtr, 100665496);
			NumberKeyframeGroup.NativeMethodInfoPtr_ValuePercentAtTime_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberKeyframeGroup>.NativeClassPtr, 100665497);
			NumberKeyframeGroup.NativeMethodInfoPtr_PercentToValue_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberKeyframeGroup>.NativeClassPtr, 100665498);
			NumberKeyframeGroup.NativeMethodInfoPtr_NumericValueAtTime_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberKeyframeGroup>.NativeClassPtr, 100665499);
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x000AD658 File Offset: 0x000AB858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90177, XrefRangeEnd = 90180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberKeyframeGroup(string name, float min, float max) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberKeyframeGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x000AD6C0 File Offset: 0x000AB8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90180, XrefRangeEnd = 90186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberKeyframeGroup(string name, float min, float max, NumberKeyframe frame) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberKeyframeGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(frame);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_NumberKeyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x000AD73C File Offset: 0x000AB93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90186, XrefRangeEnd = 90189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetFirstValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberKeyframeGroup.NativeMethodInfoPtr_GetFirstValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x000AD778 File Offset: 0x000AB978
		[CallerCount(0)]
		public unsafe float ValueToPercent(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberKeyframeGroup.NativeMethodInfoPtr_ValueToPercent_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x000AD7C4 File Offset: 0x000AB9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90189, XrefRangeEnd = 90190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ValuePercentAtTime(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberKeyframeGroup.NativeMethodInfoPtr_ValuePercentAtTime_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x000AD810 File Offset: 0x000ABA10
		[CallerCount(0)]
		public unsafe float PercentToValue(float percent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref percent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberKeyframeGroup.NativeMethodInfoPtr_PercentToValue_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x000AD85C File Offset: 0x000ABA5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 90205, RefRangeEnd = 90208, XrefRangeStart = 90190, XrefRangeEnd = 90205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float NumericValueAtTime(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberKeyframeGroup.NativeMethodInfoPtr_NumericValueAtTime_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0000B633 File Offset: 0x00009833
		public NumberKeyframeGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x000AD8A8 File Offset: 0x000ABAA8
		// (set) Token: 0x0600131A RID: 4890 RVA: 0x0000B63C File Offset: 0x0000983C
		public unsafe float minValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberKeyframeGroup.NativeFieldInfoPtr_minValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberKeyframeGroup.NativeFieldInfoPtr_minValue)) = value;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x000AD8D0 File Offset: 0x000ABAD0
		// (set) Token: 0x0600131C RID: 4892 RVA: 0x0000B657 File Offset: 0x00009857
		public unsafe float maxValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberKeyframeGroup.NativeFieldInfoPtr_maxValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberKeyframeGroup.NativeFieldInfoPtr_maxValue)) = value;
			}
		}

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeFieldInfoPtr_minValue;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeFieldInfoPtr_maxValue;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_0;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_NumberKeyframe_0;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstValue_Public_Single_0;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr_ValueToPercent_Public_Single_Single_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr_ValuePercentAtTime_Public_Single_Single_0;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr_PercentToValue_Public_Single_Single_0;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeMethodInfoPtr_NumericValueAtTime_Public_Single_Single_0;
	}
}
