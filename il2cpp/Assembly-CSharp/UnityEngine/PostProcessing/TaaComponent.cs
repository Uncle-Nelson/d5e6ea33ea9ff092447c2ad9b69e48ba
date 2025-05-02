using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200005B RID: 91
	public sealed class TaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel>
	{
		// Token: 0x06000705 RID: 1797 RVA: 0x000859E8 File Offset: 0x00083BE8
		// Note: this type is marked as 'beforefieldinit'.
		static TaaComponent()
		{
			Il2CppClassPointerStore<TaaComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "TaaComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr);
			TaaComponent.NativeFieldInfoPtr_k_ShaderString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, "k_ShaderString");
			TaaComponent.NativeFieldInfoPtr_k_SampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, "k_SampleCount");
			TaaComponent.NativeFieldInfoPtr_m_MRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, "m_MRT");
			TaaComponent.NativeFieldInfoPtr_m_SampleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, "m_SampleIndex");
			TaaComponent.NativeFieldInfoPtr_m_ResetHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, "m_ResetHistory");
			TaaComponent.NativeFieldInfoPtr_m_HistoryTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, "m_HistoryTexture");
			TaaComponent.NativeFieldInfoPtr__jitterVector_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, "<jitterVector>k__BackingField");
			TaaComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664011);
			TaaComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664012);
			TaaComponent.NativeMethodInfoPtr_get_jitterVector_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664013);
			TaaComponent.NativeMethodInfoPtr_set_jitterVector_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664014);
			TaaComponent.NativeMethodInfoPtr_ResetHistory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664015);
			TaaComponent.NativeMethodInfoPtr_SetProjectionMatrix_Public_Void_Func_2_Vector2_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664016);
			TaaComponent.NativeMethodInfoPtr_Render_Public_Void_RenderTexture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664017);
			TaaComponent.NativeMethodInfoPtr_GetHaltonValue_Private_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664018);
			TaaComponent.NativeMethodInfoPtr_GenerateRandomOffset_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664019);
			TaaComponent.NativeMethodInfoPtr_GetPerspectiveProjectionMatrix_Private_Matrix4x4_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664020);
			TaaComponent.NativeMethodInfoPtr_GetOrthographicProjectionMatrix_Private_Matrix4x4_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664021);
			TaaComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664022);
			TaaComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664023);
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00085BA8 File Offset: 0x00083DA8
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77541, XrefRangeEnd = 77544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00085BE4 File Offset: 0x00083DE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77283, RefRangeEnd = 77284, XrefRangeStart = 77283, XrefRangeEnd = 77284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x00085C20 File Offset: 0x00083E20
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x00085C5C File Offset: 0x00083E5C
		public unsafe Vector2 jitterVector
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_get_jitterVector_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_set_jitterVector_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00085C9C File Offset: 0x00083E9C
		[CallerCount(0)]
		public unsafe void ResetHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_ResetHistory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00085CD0 File Offset: 0x00083ED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77570, RefRangeEnd = 77571, XrefRangeStart = 77544, XrefRangeEnd = 77570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProjectionMatrix(Func<Vector2, Matrix4x4> jitteredFunc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(jitteredFunc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_SetProjectionMatrix_Public_Void_Func_2_Vector2_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00085D14 File Offset: 0x00083F14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77632, RefRangeEnd = 77633, XrefRangeStart = 77571, XrefRangeEnd = 77632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(RenderTexture source, RenderTexture destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_Render_Public_Void_RenderTexture_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00085D68 File Offset: 0x00083F68
		[CallerCount(0)]
		public unsafe float GetHaltonValue(int index, int radix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_GetHaltonValue_Private_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00085DC0 File Offset: 0x00083FC0
		[CallerCount(0)]
		public unsafe Vector2 GenerateRandomOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_GenerateRandomOffset_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00085DFC File Offset: 0x00083FFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77668, RefRangeEnd = 77669, XrefRangeStart = 77633, XrefRangeEnd = 77668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 GetPerspectiveProjectionMatrix(Vector2 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_GetPerspectiveProjectionMatrix_Private_Matrix4x4_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00085E48 File Offset: 0x00084048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77669, XrefRangeEnd = 77676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 GetOrthographicProjectionMatrix(Vector2 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_GetOrthographicProjectionMatrix_Private_Matrix4x4_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00085E94 File Offset: 0x00084094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77676, XrefRangeEnd = 77682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00085EC8 File Offset: 0x000840C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77682, XrefRangeEnd = 77689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaaComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00005EEE File Offset: 0x000040EE
		public TaaComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00085F04 File Offset: 0x00084104
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x00005EF7 File Offset: 0x000040F7
		public unsafe static string k_ShaderString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaaComponent.NativeFieldInfoPtr_k_ShaderString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaaComponent.NativeFieldInfoPtr_k_ShaderString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00085F24 File Offset: 0x00084124
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x00005F09 File Offset: 0x00004109
		public unsafe static int k_SampleCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TaaComponent.NativeFieldInfoPtr_k_SampleCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaaComponent.NativeFieldInfoPtr_k_SampleCount, (void*)(&value));
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00085F40 File Offset: 0x00084140
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00005F17 File Offset: 0x00004117
		public unsafe Il2CppStructArray<RenderBuffer> m_MRT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr_m_MRT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderBuffer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr_m_MRT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00085F70 File Offset: 0x00084170
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x00005F36 File Offset: 0x00004136
		public unsafe int m_SampleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr_m_SampleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr_m_SampleIndex)) = value;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00085F98 File Offset: 0x00084198
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x00005F51 File Offset: 0x00004151
		public unsafe bool m_ResetHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr_m_ResetHistory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr_m_ResetHistory)) = value;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00085FC0 File Offset: 0x000841C0
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x00005F6C File Offset: 0x0000416C
		public unsafe RenderTexture m_HistoryTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr_m_HistoryTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr_m_HistoryTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00085FF0 File Offset: 0x000841F0
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x00005F8B File Offset: 0x0000418B
		public unsafe Vector2 _jitterVector_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr__jitterVector_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr__jitterVector_k__BackingField)) = value;
			}
		}

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderString;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeFieldInfoPtr_k_SampleCount;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr_m_MRT;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeFieldInfoPtr_m_SampleIndex;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeFieldInfoPtr_m_ResetHistory;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeFieldInfoPtr_m_HistoryTexture;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeFieldInfoPtr__jitterVector_k__BackingField;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_get_jitterVector_Public_get_Vector2_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_set_jitterVector_Private_set_Void_Vector2_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_ResetHistory_Public_Void_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_SetProjectionMatrix_Public_Void_Func_2_Vector2_Matrix4x4_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_RenderTexture_RenderTexture_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_GetHaltonValue_Private_Single_Int32_Int32_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandomOffset_Private_Vector2_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_GetPerspectiveProjectionMatrix_Private_Matrix4x4_Vector2_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_GetOrthographicProjectionMatrix_Private_Matrix4x4_Vector2_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007D8 RID: 2008
		public static class Uniforms : Object
		{
			// Token: 0x0600BC39 RID: 48185 RVA: 0x002E713C File Offset: 0x002E533C
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<TaaComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaaComponent.Uniforms>.NativeClassPtr);
				TaaComponent.Uniforms.NativeFieldInfoPtr__Jitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent.Uniforms>.NativeClassPtr, "_Jitter");
				TaaComponent.Uniforms.NativeFieldInfoPtr__SharpenParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent.Uniforms>.NativeClassPtr, "_SharpenParameters");
				TaaComponent.Uniforms.NativeFieldInfoPtr__FinalBlendParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent.Uniforms>.NativeClassPtr, "_FinalBlendParameters");
				TaaComponent.Uniforms.NativeFieldInfoPtr__HistoryTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent.Uniforms>.NativeClassPtr, "_HistoryTex");
				TaaComponent.Uniforms.NativeFieldInfoPtr__MainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent.Uniforms>.NativeClassPtr, "_MainTex");
			}

			// Token: 0x0600BC3A RID: 48186 RVA: 0x0005C0B7 File Offset: 0x0005A2B7
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A4E RID: 14926
			// (get) Token: 0x0600BC3B RID: 48187 RVA: 0x002E71CC File Offset: 0x002E53CC
			// (set) Token: 0x0600BC3C RID: 48188 RVA: 0x0005C0C0 File Offset: 0x0005A2C0
			public unsafe static int _Jitter
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(TaaComponent.Uniforms.NativeFieldInfoPtr__Jitter, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TaaComponent.Uniforms.NativeFieldInfoPtr__Jitter, (void*)(&value));
				}
			}

			// Token: 0x17003A4F RID: 14927
			// (get) Token: 0x0600BC3D RID: 48189 RVA: 0x002E71E8 File Offset: 0x002E53E8
			// (set) Token: 0x0600BC3E RID: 48190 RVA: 0x0005C0CE File Offset: 0x0005A2CE
			public unsafe static int _SharpenParameters
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(TaaComponent.Uniforms.NativeFieldInfoPtr__SharpenParameters, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TaaComponent.Uniforms.NativeFieldInfoPtr__SharpenParameters, (void*)(&value));
				}
			}

			// Token: 0x17003A50 RID: 14928
			// (get) Token: 0x0600BC3F RID: 48191 RVA: 0x002E7204 File Offset: 0x002E5404
			// (set) Token: 0x0600BC40 RID: 48192 RVA: 0x0005C0DC File Offset: 0x0005A2DC
			public unsafe static int _FinalBlendParameters
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(TaaComponent.Uniforms.NativeFieldInfoPtr__FinalBlendParameters, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TaaComponent.Uniforms.NativeFieldInfoPtr__FinalBlendParameters, (void*)(&value));
				}
			}

			// Token: 0x17003A51 RID: 14929
			// (get) Token: 0x0600BC41 RID: 48193 RVA: 0x002E7220 File Offset: 0x002E5420
			// (set) Token: 0x0600BC42 RID: 48194 RVA: 0x0005C0EA File Offset: 0x0005A2EA
			public unsafe static int _HistoryTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(TaaComponent.Uniforms.NativeFieldInfoPtr__HistoryTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TaaComponent.Uniforms.NativeFieldInfoPtr__HistoryTex, (void*)(&value));
				}
			}

			// Token: 0x17003A52 RID: 14930
			// (get) Token: 0x0600BC43 RID: 48195 RVA: 0x002E723C File Offset: 0x002E543C
			// (set) Token: 0x0600BC44 RID: 48196 RVA: 0x0005C0F8 File Offset: 0x0005A2F8
			public unsafe static int _MainTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(TaaComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TaaComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&value));
				}
			}

			// Token: 0x04007ECA RID: 32458
			private static readonly IntPtr NativeFieldInfoPtr__Jitter;

			// Token: 0x04007ECB RID: 32459
			private static readonly IntPtr NativeFieldInfoPtr__SharpenParameters;

			// Token: 0x04007ECC RID: 32460
			private static readonly IntPtr NativeFieldInfoPtr__FinalBlendParameters;

			// Token: 0x04007ECD RID: 32461
			private static readonly IntPtr NativeFieldInfoPtr__HistoryTex;

			// Token: 0x04007ECE RID: 32462
			private static readonly IntPtr NativeFieldInfoPtr__MainTex;
		}
	}
}
