using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000F8 RID: 248
	[Serializable]
	public class KeyframeGroup<T> : Object
	{
		// Token: 0x060012EF RID: 4847 RVA: 0x000AC888 File Offset: 0x000AAA88
		// Note: this type is marked as 'beforefieldinit'.
		static KeyframeGroup()
		{
			Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "KeyframeGroup`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr);
			KeyframeGroup<T>.NativeFieldInfoPtr_keyframes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, "keyframes");
			KeyframeGroup<T>.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, "m_Name");
			KeyframeGroup<T>.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, "m_Id");
			KeyframeGroup<T>.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665468);
			KeyframeGroup<T>.NativeMethodInfoPtr_set_name_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665469);
			KeyframeGroup<T>.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665470);
			KeyframeGroup<T>.NativeMethodInfoPtr_set_id_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665471);
			KeyframeGroup<T>.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665472);
			KeyframeGroup<T>.NativeMethodInfoPtr_AddKeyFrame_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665473);
			KeyframeGroup<T>.NativeMethodInfoPtr_RemoveKeyFrame_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665474);
			KeyframeGroup<T>.NativeMethodInfoPtr_RemoveKeyFrame_Public_Virtual_Final_New_Void_IBaseKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665475);
			KeyframeGroup<T>.NativeMethodInfoPtr_GetKeyFrameCount_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665476);
			KeyframeGroup<T>.NativeMethodInfoPtr_GetKeyframe_Public_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665477);
			KeyframeGroup<T>.NativeMethodInfoPtr_SortKeyframes_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665478);
			KeyframeGroup<T>.NativeMethodInfoPtr_CurveAdjustedBlendingTime_Public_Single_InterpolationCurve_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665479);
			KeyframeGroup<T>.NativeMethodInfoPtr_GetPreviousKeyFrame_Public_T_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665480);
			KeyframeGroup<T>.NativeMethodInfoPtr_GetSurroundingKeyFrames_Public_Boolean_Single_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665481);
			KeyframeGroup<T>.NativeMethodInfoPtr_GetSurroundingKeyFrames_Public_Boolean_Single_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665482);
			KeyframeGroup<T>.NativeMethodInfoPtr_ProgressBetweenSurroundingKeyframes_Public_Static_Single_Single_BaseKeyframe_BaseKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665483);
			KeyframeGroup<T>.NativeMethodInfoPtr_ProgressBetweenSurroundingKeyframes_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665484);
			KeyframeGroup<T>.NativeMethodInfoPtr_WidthBetweenCircularValues_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665485);
			KeyframeGroup<T>.NativeMethodInfoPtr_TrimToSingleKeyframe_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665486);
			KeyframeGroup<T>.NativeMethodInfoPtr_GetShortestInterpolationDirection_Public_InterpolationDirection_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665487);
			KeyframeGroup<T>.NativeMethodInfoPtr_CalculateCircularDistances_Public_Void_Single_Single_Single_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665488);
			KeyframeGroup<T>.NativeMethodInfoPtr_InterpolateFloat_Public_Single_InterpolationCurve_InterpolationDirection_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665489);
			KeyframeGroup<T>.NativeMethodInfoPtr_AutoInterpolation_Public_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665490);
			KeyframeGroup<T>.NativeMethodInfoPtr_ForwardInterpolation_Public_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665491);
			KeyframeGroup<T>.NativeMethodInfoPtr_ReverseInterpolation_Public_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665492);
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x000ACB24 File Offset: 0x000AAD24
		// (set) Token: 0x060012F1 RID: 4849 RVA: 0x000ACB5C File Offset: 0x000AAD5C
		public unsafe virtual string name
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_set_name_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x000ACBA0 File Offset: 0x000AADA0
		// (set) Token: 0x060012F3 RID: 4851 RVA: 0x000ACBD8 File Offset: 0x000AADD8
		public unsafe virtual string id
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_set_id_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x000ACC1C File Offset: 0x000AAE1C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 90065, RefRangeEnd = 90079, XrefRangeStart = 90056, XrefRangeEnd = 90065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyframeGroup(string name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x000ACC68 File Offset: 0x000AAE68
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 90085, RefRangeEnd = 90095, XrefRangeStart = 90079, XrefRangeEnd = 90085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKeyFrame(T keyFrame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = keyFrame;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref keyFrame;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_AddKeyFrame_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x000ACCF8 File Offset: 0x000AAEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90095, XrefRangeEnd = 90104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveKeyFrame(T keyFrame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = keyFrame;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref keyFrame;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_RemoveKeyFrame_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x000ACD88 File Offset: 0x000AAF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90104, XrefRangeEnd = 90111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveKeyFrame(IBaseKeyframe keyframe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyframe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_RemoveKeyFrame_Public_Virtual_Final_New_Void_IBaseKeyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x000ACDCC File Offset: 0x000AAFCC
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 37219, RefRangeEnd = 37277, XrefRangeStart = 37219, XrefRangeEnd = 37277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetKeyFrameCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_GetKeyFrameCount_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x000ACE08 File Offset: 0x000AB008
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 37189, RefRangeEnd = 37207, XrefRangeStart = 37189, XrefRangeEnd = 37207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetKeyframe(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_GetKeyframe_Public_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x000ACE50 File Offset: 0x000AB050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90111, XrefRangeEnd = 90113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SortKeyframes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_SortKeyframes_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x000ACE84 File Offset: 0x000AB084
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90114, RefRangeEnd = 90116, XrefRangeStart = 90113, XrefRangeEnd = 90114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CurveAdjustedBlendingTime(InterpolationCurve curve, float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref curve;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_CurveAdjustedBlendingTime_Public_Single_InterpolationCurve_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x000ACEDC File Offset: 0x000AB0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90116, XrefRangeEnd = 90121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetPreviousKeyFrame(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_GetPreviousKeyFrame_Public_T_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x000ACF24 File Offset: 0x000AB124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90121, XrefRangeEnd = 90122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetSurroundingKeyFrames(float time, out T beforeKeyframe, out T afterKeyframe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref beforeKeyframe;
			}
			ptr2 = intPtr2;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			IntPtr intPtr4;
			if (!typeof(T).IsValueType)
			{
				intPtr3 = 0;
				intPtr4 = &intPtr3;
			}
			else
			{
				intPtr4 = ref afterKeyframe;
			}
			ptr3 = intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_GetSurroundingKeyFrames_Public_Boolean_Single_byref_T_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr7 = intPtr;
				beforeKeyframe = ((intPtr7 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr7, false, false));
			}
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr8 = intPtr3;
				afterKeyframe = ((intPtr8 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr8, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr5);
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x000AD00C File Offset: 0x000AB20C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 90132, RefRangeEnd = 90139, XrefRangeStart = 90122, XrefRangeEnd = 90132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetSurroundingKeyFrames(float time, out int beforeIndex, out int afterIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &beforeIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &afterIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_GetSurroundingKeyFrames_Public_Boolean_Single_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x000AD074 File Offset: 0x000AB274
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90149, RefRangeEnd = 90150, XrefRangeStart = 90139, XrefRangeEnd = 90149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ProgressBetweenSurroundingKeyframes(float time, BaseKeyframe beforeKey, BaseKeyframe afterKey)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beforeKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_ProgressBetweenSurroundingKeyframes_Public_Static_Single_Single_BaseKeyframe_BaseKeyframe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x000AD0D8 File Offset: 0x000AB2D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90157, XrefRangeStart = 90150, XrefRangeEnd = 90156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ProgressBetweenSurroundingKeyframes(float time, float beforeKeyTime, float afterKeyTime)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beforeKeyTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref afterKeyTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_ProgressBetweenSurroundingKeyframes_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x000AD134 File Offset: 0x000AB334
		[CallerCount(0)]
		public unsafe static float WidthBetweenCircularValues(float begin, float end)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref begin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_WidthBetweenCircularValues_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x000AD180 File Offset: 0x000AB380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90157, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TrimToSingleKeyframe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_TrimToSingleKeyframe_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x000AD1B4 File Offset: 0x000AB3B4
		[CallerCount(0)]
		public unsafe InterpolationDirection GetShortestInterpolationDirection(float previousKeyValue, float nextKeyValue, float minValue, float maxValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref previousKeyValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextKeyValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_GetShortestInterpolationDirection_Public_InterpolationDirection_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x000AD228 File Offset: 0x000AB428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90158, XrefRangeEnd = 90159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateCircularDistances(float previousKeyValue, float nextKeyValue, float minValue, float maxValue, out float forwardDistance, out float reverseDistance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref previousKeyValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextKeyValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &forwardDistance;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &reverseDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_CalculateCircularDistances_Public_Void_Single_Single_Single_Single_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x000AD2B0 File Offset: 0x000AB4B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90176, RefRangeEnd = 90177, XrefRangeStart = 90159, XrefRangeEnd = 90176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float InterpolateFloat(InterpolationCurve curve, InterpolationDirection direction, float time, float beforeTime, float nextTime, float previousKeyValue, float nextKeyValue, float minValue, float maxValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref curve;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beforeTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextTime;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousKeyValue;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextKeyValue;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_InterpolateFloat_Public_Single_InterpolationCurve_InterpolationDirection_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x000AD36C File Offset: 0x000AB56C
		[CallerCount(0)]
		public unsafe float AutoInterpolation(float curvedTime, float previousValue, float nextValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref curvedTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_AutoInterpolation_Public_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x000AD3D4 File Offset: 0x000AB5D4
		[CallerCount(0)]
		public unsafe float ForwardInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousKeyValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextKeyValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_ForwardInterpolation_Public_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x000AD464 File Offset: 0x000AB664
		[CallerCount(0)]
		public unsafe float ReverseInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousKeyValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextKeyValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_ReverseInterpolation_Public_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x0000B5CD File Offset: 0x000097CD
		public KeyframeGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x000AD4F4 File Offset: 0x000AB6F4
		// (set) Token: 0x0600130B RID: 4875 RVA: 0x0000B5D6 File Offset: 0x000097D6
		public unsafe List<T> keyframes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroup<T>.NativeFieldInfoPtr_keyframes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroup<T>.NativeFieldInfoPtr_keyframes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x000AD524 File Offset: 0x000AB724
		// (set) Token: 0x0600130D RID: 4877 RVA: 0x0000B5F5 File Offset: 0x000097F5
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroup<T>.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroup<T>.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x000AD54C File Offset: 0x000AB74C
		// (set) Token: 0x0600130F RID: 4879 RVA: 0x0000B614 File Offset: 0x00009814
		public unsafe string m_Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroup<T>.NativeFieldInfoPtr_m_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroup<T>.NativeFieldInfoPtr_m_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeFieldInfoPtr_keyframes;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeFieldInfoPtr_m_Id;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_set_id_Public_set_Void_String_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyFrame_Public_Void_T_0;

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKeyFrame_Public_Void_T_0;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKeyFrame_Public_Virtual_Final_New_Void_IBaseKeyframe_0;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyFrameCount_Public_Virtual_Final_New_Int32_0;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyframe_Public_T_Int32_0;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeMethodInfoPtr_SortKeyframes_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeMethodInfoPtr_CurveAdjustedBlendingTime_Public_Single_InterpolationCurve_Single_0;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousKeyFrame_Public_T_Single_0;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr_GetSurroundingKeyFrames_Public_Boolean_Single_byref_T_byref_T_0;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr_GetSurroundingKeyFrames_Public_Boolean_Single_byref_Int32_byref_Int32_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_ProgressBetweenSurroundingKeyframes_Public_Static_Single_Single_BaseKeyframe_BaseKeyframe_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr_ProgressBetweenSurroundingKeyframes_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr_WidthBetweenCircularValues_Public_Static_Single_Single_Single_0;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeMethodInfoPtr_TrimToSingleKeyframe_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr_GetShortestInterpolationDirection_Public_InterpolationDirection_Single_Single_Single_Single_0;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_CalculateCircularDistances_Public_Void_Single_Single_Single_Single_byref_Single_byref_Single_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_InterpolateFloat_Public_Single_InterpolationCurve_InterpolationDirection_Single_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr_AutoInterpolation_Public_Single_Single_Single_Single_0;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_ForwardInterpolation_Public_Single_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr_ReverseInterpolation_Public_Single_Single_Single_Single_Single_Single_Single_0;
	}
}
