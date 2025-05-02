using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000FA RID: 250
	[Serializable]
	public class SpherePointKeyframeGroup : KeyframeGroup<SpherePointKeyframe>
	{
		// Token: 0x0600131D RID: 4893 RVA: 0x000AD8F8 File Offset: 0x000ABAF8
		// Note: this type is marked as 'beforefieldinit'.
		static SpherePointKeyframeGroup()
		{
			Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "SpherePointKeyframeGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr);
			SpherePointKeyframeGroup.NativeFieldInfoPtr_MinHorizontalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr, "MinHorizontalRotation");
			SpherePointKeyframeGroup.NativeFieldInfoPtr_MaxHorizontalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr, "MaxHorizontalRotation");
			SpherePointKeyframeGroup.NativeFieldInfoPtr_MinVerticalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr, "MinVerticalRotation");
			SpherePointKeyframeGroup.NativeFieldInfoPtr_MaxVerticalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr, "MaxVerticalRotation");
			SpherePointKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr, 100665500);
			SpherePointKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_SpherePointKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr, 100665501);
			SpherePointKeyframeGroup.NativeMethodInfoPtr_SpherePointForTime_Public_SpherePoint_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr, 100665502);
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x000AD9B4 File Offset: 0x000ABBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90208, XrefRangeEnd = 90211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePointKeyframeGroup(string name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePointKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x000ADA00 File Offset: 0x000ABC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90211, XrefRangeEnd = 90217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePointKeyframeGroup(string name, SpherePointKeyframe keyframe) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyframe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePointKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_SpherePointKeyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x000ADA60 File Offset: 0x000ABC60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90243, RefRangeEnd = 90245, XrefRangeStart = 90217, XrefRangeEnd = 90243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePoint SpherePointForTime(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePointKeyframeGroup.NativeMethodInfoPtr_SpherePointForTime_Public_SpherePoint_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpherePoint>(intPtr3) : null;
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0000B672 File Offset: 0x00009872
		public SpherePointKeyframeGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001322 RID: 4898 RVA: 0x000ADAAC File Offset: 0x000ABCAC
		// (set) Token: 0x06001323 RID: 4899 RVA: 0x0000B67B File Offset: 0x0000987B
		public unsafe static float MinHorizontalRotation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpherePointKeyframeGroup.NativeFieldInfoPtr_MinHorizontalRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpherePointKeyframeGroup.NativeFieldInfoPtr_MinHorizontalRotation, (void*)(&value));
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x000ADAC8 File Offset: 0x000ABCC8
		// (set) Token: 0x06001325 RID: 4901 RVA: 0x0000B689 File Offset: 0x00009889
		public unsafe static float MaxHorizontalRotation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpherePointKeyframeGroup.NativeFieldInfoPtr_MaxHorizontalRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpherePointKeyframeGroup.NativeFieldInfoPtr_MaxHorizontalRotation, (void*)(&value));
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x000ADAE4 File Offset: 0x000ABCE4
		// (set) Token: 0x06001327 RID: 4903 RVA: 0x0000B697 File Offset: 0x00009897
		public unsafe static float MinVerticalRotation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpherePointKeyframeGroup.NativeFieldInfoPtr_MinVerticalRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpherePointKeyframeGroup.NativeFieldInfoPtr_MinVerticalRotation, (void*)(&value));
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x000ADB00 File Offset: 0x000ABD00
		// (set) Token: 0x06001329 RID: 4905 RVA: 0x0000B6A5 File Offset: 0x000098A5
		public unsafe static float MaxVerticalRotation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpherePointKeyframeGroup.NativeFieldInfoPtr_MaxVerticalRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpherePointKeyframeGroup.NativeFieldInfoPtr_MaxVerticalRotation, (void*)(&value));
			}
		}

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeFieldInfoPtr_MinHorizontalRotation;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeFieldInfoPtr_MaxHorizontalRotation;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeFieldInfoPtr_MinVerticalRotation;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeFieldInfoPtr_MaxVerticalRotation;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_SpherePointKeyframe_0;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeMethodInfoPtr_SpherePointForTime_Public_SpherePoint_Single_0;
	}
}
