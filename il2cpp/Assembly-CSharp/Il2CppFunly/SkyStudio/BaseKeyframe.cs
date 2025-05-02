using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000FC RID: 252
	[Serializable]
	public class BaseKeyframe : Object
	{
		// Token: 0x0600132E RID: 4910 RVA: 0x000ADC20 File Offset: 0x000ABE20
		// Note: this type is marked as 'beforefieldinit'.
		static BaseKeyframe()
		{
			Il2CppClassPointerStore<BaseKeyframe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "BaseKeyframe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseKeyframe>.NativeClassPtr);
			BaseKeyframe.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseKeyframe>.NativeClassPtr, "m_Id");
			BaseKeyframe.NativeFieldInfoPtr_m_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseKeyframe>.NativeClassPtr, "m_Time");
			BaseKeyframe.NativeFieldInfoPtr_m_InterpolationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseKeyframe>.NativeClassPtr, "m_InterpolationCurve");
			BaseKeyframe.NativeFieldInfoPtr_m_InterpolationDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseKeyframe>.NativeClassPtr, "m_InterpolationDirection");
			BaseKeyframe.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKeyframe>.NativeClassPtr, 100665505);
			BaseKeyframe.NativeMethodInfoPtr_set_id_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKeyframe>.NativeClassPtr, 100665506);
			BaseKeyframe.NativeMethodInfoPtr_get_time_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKeyframe>.NativeClassPtr, 100665507);
			BaseKeyframe.NativeMethodInfoPtr_set_time_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKeyframe>.NativeClassPtr, 100665508);
			BaseKeyframe.NativeMethodInfoPtr_get_interpolationCurve_Public_Virtual_Final_New_get_InterpolationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKeyframe>.NativeClassPtr, 100665509);
			BaseKeyframe.NativeMethodInfoPtr_set_interpolationCurve_Public_Virtual_Final_New_set_Void_InterpolationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKeyframe>.NativeClassPtr, 100665510);
			BaseKeyframe.NativeMethodInfoPtr_get_interpolationDirection_Public_Virtual_Final_New_get_InterpolationDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKeyframe>.NativeClassPtr, 100665511);
			BaseKeyframe.NativeMethodInfoPtr_set_interpolationDirection_Public_Virtual_Final_New_set_Void_InterpolationDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKeyframe>.NativeClassPtr, 100665512);
			BaseKeyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKeyframe>.NativeClassPtr, 100665513);
			BaseKeyframe.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKeyframe>.NativeClassPtr, 100665514);
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x000ADD68 File Offset: 0x000ABF68
		// (set) Token: 0x06001330 RID: 4912 RVA: 0x000ADDA0 File Offset: 0x000ABFA0
		public unsafe virtual string id
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17380, RefRangeEnd = 17390, XrefRangeStart = 17380, XrefRangeEnd = 17390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseKeyframe.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29995, RefRangeEnd = 29997, XrefRangeStart = 29995, XrefRangeEnd = 29997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseKeyframe.NativeMethodInfoPtr_set_id_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x000ADDE4 File Offset: 0x000ABFE4
		// (set) Token: 0x06001332 RID: 4914 RVA: 0x000ADE20 File Offset: 0x000AC020
		public unsafe virtual float time
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseKeyframe.NativeMethodInfoPtr_get_time_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 90261, RefRangeEnd = 90265, XrefRangeStart = 90261, XrefRangeEnd = 90261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseKeyframe.NativeMethodInfoPtr_set_time_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x000ADE60 File Offset: 0x000AC060
		// (set) Token: 0x06001334 RID: 4916 RVA: 0x000ADE9C File Offset: 0x000AC09C
		public unsafe virtual InterpolationCurve interpolationCurve
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseKeyframe.NativeMethodInfoPtr_get_interpolationCurve_Public_Virtual_Final_New_get_InterpolationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 41641, RefRangeEnd = 41642, XrefRangeStart = 41641, XrefRangeEnd = 41642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseKeyframe.NativeMethodInfoPtr_set_interpolationCurve_Public_Virtual_Final_New_set_Void_InterpolationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x000ADEDC File Offset: 0x000AC0DC
		// (set) Token: 0x06001336 RID: 4918 RVA: 0x000ADF18 File Offset: 0x000AC118
		public unsafe virtual InterpolationDirection interpolationDirection
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20564, RefRangeEnd = 20565, XrefRangeStart = 20564, XrefRangeEnd = 20565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseKeyframe.NativeMethodInfoPtr_get_interpolationDirection_Public_Virtual_Final_New_get_InterpolationDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29976, RefRangeEnd = 29977, XrefRangeStart = 29976, XrefRangeEnd = 29977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseKeyframe.NativeMethodInfoPtr_set_interpolationDirection_Public_Virtual_Final_New_set_Void_InterpolationDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x000ADF58 File Offset: 0x000AC158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90265, XrefRangeEnd = 90269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseKeyframe(float time) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseKeyframe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseKeyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x000ADFA0 File Offset: 0x000AC1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90269, XrefRangeEnd = 90273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int CompareTo(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseKeyframe.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x0000B6BC File Offset: 0x000098BC
		public BaseKeyframe(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x000ADFF0 File Offset: 0x000AC1F0
		// (set) Token: 0x0600133B RID: 4923 RVA: 0x0000B6C5 File Offset: 0x000098C5
		public unsafe string m_Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseKeyframe.NativeFieldInfoPtr_m_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseKeyframe.NativeFieldInfoPtr_m_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x000AE018 File Offset: 0x000AC218
		// (set) Token: 0x0600133D RID: 4925 RVA: 0x0000B6E4 File Offset: 0x000098E4
		public unsafe float m_Time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseKeyframe.NativeFieldInfoPtr_m_Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseKeyframe.NativeFieldInfoPtr_m_Time)) = value;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x0600133E RID: 4926 RVA: 0x000AE040 File Offset: 0x000AC240
		// (set) Token: 0x0600133F RID: 4927 RVA: 0x0000B6FF File Offset: 0x000098FF
		public unsafe InterpolationCurve m_InterpolationCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseKeyframe.NativeFieldInfoPtr_m_InterpolationCurve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseKeyframe.NativeFieldInfoPtr_m_InterpolationCurve)) = value;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001340 RID: 4928 RVA: 0x000AE068 File Offset: 0x000AC268
		// (set) Token: 0x06001341 RID: 4929 RVA: 0x0000B71A File Offset: 0x0000991A
		public unsafe InterpolationDirection m_InterpolationDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseKeyframe.NativeFieldInfoPtr_m_InterpolationDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseKeyframe.NativeFieldInfoPtr_m_InterpolationDirection)) = value;
			}
		}

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeFieldInfoPtr_m_Id;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeFieldInfoPtr_m_Time;

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeFieldInfoPtr_m_InterpolationCurve;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeFieldInfoPtr_m_InterpolationDirection;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeMethodInfoPtr_set_id_Public_set_Void_String_0;

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeMethodInfoPtr_set_time_Public_Virtual_Final_New_set_Void_Single_0;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeMethodInfoPtr_get_interpolationCurve_Public_Virtual_Final_New_get_InterpolationCurve_0;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeMethodInfoPtr_set_interpolationCurve_Public_Virtual_Final_New_set_Void_InterpolationCurve_0;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeMethodInfoPtr_get_interpolationDirection_Public_Virtual_Final_New_get_InterpolationDirection_0;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeMethodInfoPtr_set_interpolationDirection_Public_Virtual_Final_New_set_Void_InterpolationDirection_0;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;
	}
}
