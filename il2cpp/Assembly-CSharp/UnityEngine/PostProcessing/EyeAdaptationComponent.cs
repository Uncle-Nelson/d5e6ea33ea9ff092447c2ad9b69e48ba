using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000055 RID: 85
	public sealed class EyeAdaptationComponent : PostProcessingComponentRenderTexture<EyeAdaptationModel>
	{
		// Token: 0x060006A8 RID: 1704 RVA: 0x0008477C File Offset: 0x0008297C
		// Note: this type is marked as 'beforefieldinit'.
		static EyeAdaptationComponent()
		{
			Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "EyeAdaptationComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr);
			EyeAdaptationComponent.NativeFieldInfoPtr_m_EyeCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "m_EyeCompute");
			EyeAdaptationComponent.NativeFieldInfoPtr_m_HistogramBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "m_HistogramBuffer");
			EyeAdaptationComponent.NativeFieldInfoPtr_m_AutoExposurePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "m_AutoExposurePool");
			EyeAdaptationComponent.NativeFieldInfoPtr_m_AutoExposurePingPing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "m_AutoExposurePingPing");
			EyeAdaptationComponent.NativeFieldInfoPtr_m_CurrentAutoExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "m_CurrentAutoExposure");
			EyeAdaptationComponent.NativeFieldInfoPtr_m_DebugHistogram = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "m_DebugHistogram");
			EyeAdaptationComponent.NativeFieldInfoPtr_s_EmptyHistogramBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "s_EmptyHistogramBuffer");
			EyeAdaptationComponent.NativeFieldInfoPtr_m_FirstFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "m_FirstFrame");
			EyeAdaptationComponent.NativeFieldInfoPtr_k_HistogramBins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "k_HistogramBins");
			EyeAdaptationComponent.NativeFieldInfoPtr_k_HistogramThreadX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "k_HistogramThreadX");
			EyeAdaptationComponent.NativeFieldInfoPtr_k_HistogramThreadY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "k_HistogramThreadY");
			EyeAdaptationComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, 100663951);
			EyeAdaptationComponent.NativeMethodInfoPtr_ResetHistory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, 100663952);
			EyeAdaptationComponent.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, 100663953);
			EyeAdaptationComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, 100663954);
			EyeAdaptationComponent.NativeMethodInfoPtr_GetHistogramScaleOffsetRes_Private_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, 100663955);
			EyeAdaptationComponent.NativeMethodInfoPtr_Prepare_Public_Texture_RenderTexture_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, 100663956);
			EyeAdaptationComponent.NativeMethodInfoPtr_OnGUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, 100663957);
			EyeAdaptationComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, 100663958);
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00084928 File Offset: 0x00082B28
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76674, XrefRangeEnd = 76676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00084964 File Offset: 0x00082B64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57573, RefRangeEnd = 57575, XrefRangeStart = 57573, XrefRangeEnd = 57575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationComponent.NativeMethodInfoPtr_ResetHistory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00084998 File Offset: 0x00082B98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57573, RefRangeEnd = 57575, XrefRangeStart = 57573, XrefRangeEnd = 57575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationComponent.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x000849CC File Offset: 0x00082BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76676, XrefRangeEnd = 76688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00084A00 File Offset: 0x00082C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76688, XrefRangeEnd = 76693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetHistogramScaleOffsetRes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationComponent.NativeMethodInfoPtr_GetHistogramScaleOffsetRes_Private_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00084A3C File Offset: 0x00082C3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76828, RefRangeEnd = 76829, XrefRangeStart = 76693, XrefRangeEnd = 76828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture Prepare(RenderTexture source, Material uberMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uberMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationComponent.NativeMethodInfoPtr_Prepare_Public_Texture_RenderTexture_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00084AA0 File Offset: 0x00082CA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76840, RefRangeEnd = 76841, XrefRangeStart = 76829, XrefRangeEnd = 76840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationComponent.NativeMethodInfoPtr_OnGUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00084AD4 File Offset: 0x00082CD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76848, RefRangeEnd = 76849, XrefRangeStart = 76841, XrefRangeEnd = 76848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyeAdaptationComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00005C96 File Offset: 0x00003E96
		public EyeAdaptationComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00084B10 File Offset: 0x00082D10
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x00005C9F File Offset: 0x00003E9F
		public unsafe ComputeShader m_EyeCompute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_EyeCompute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_EyeCompute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00084B40 File Offset: 0x00082D40
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x00005CBE File Offset: 0x00003EBE
		public unsafe ComputeBuffer m_HistogramBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_HistogramBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_HistogramBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x00084B70 File Offset: 0x00082D70
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x00005CDD File Offset: 0x00003EDD
		public unsafe Il2CppReferenceArray<RenderTexture> m_AutoExposurePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_AutoExposurePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RenderTexture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_AutoExposurePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x00084BA0 File Offset: 0x00082DA0
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x00005CFC File Offset: 0x00003EFC
		public unsafe int m_AutoExposurePingPing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_AutoExposurePingPing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_AutoExposurePingPing)) = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x00084BC8 File Offset: 0x00082DC8
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x00005D17 File Offset: 0x00003F17
		public unsafe RenderTexture m_CurrentAutoExposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_CurrentAutoExposure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_CurrentAutoExposure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x00084BF8 File Offset: 0x00082DF8
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x00005D36 File Offset: 0x00003F36
		public unsafe RenderTexture m_DebugHistogram
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_DebugHistogram);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_DebugHistogram), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00084C28 File Offset: 0x00082E28
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x00005D55 File Offset: 0x00003F55
		public unsafe static Il2CppStructArray<uint> s_EmptyHistogramBuffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.NativeFieldInfoPtr_s_EmptyHistogramBuffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.NativeFieldInfoPtr_s_EmptyHistogramBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00084C50 File Offset: 0x00082E50
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x00005D67 File Offset: 0x00003F67
		public unsafe bool m_FirstFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_FirstFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_FirstFrame)) = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00084C78 File Offset: 0x00082E78
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x00005D82 File Offset: 0x00003F82
		public unsafe static int k_HistogramBins
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.NativeFieldInfoPtr_k_HistogramBins, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.NativeFieldInfoPtr_k_HistogramBins, (void*)(&value));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00084C94 File Offset: 0x00082E94
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x00005D90 File Offset: 0x00003F90
		public unsafe static int k_HistogramThreadX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.NativeFieldInfoPtr_k_HistogramThreadX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.NativeFieldInfoPtr_k_HistogramThreadX, (void*)(&value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00084CB0 File Offset: 0x00082EB0
		// (set) Token: 0x060006C7 RID: 1735 RVA: 0x00005D9E File Offset: 0x00003F9E
		public unsafe static int k_HistogramThreadY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.NativeFieldInfoPtr_k_HistogramThreadY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.NativeFieldInfoPtr_k_HistogramThreadY, (void*)(&value));
			}
		}

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeFieldInfoPtr_m_EyeCompute;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeFieldInfoPtr_m_HistogramBuffer;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoExposurePool;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoExposurePingPing;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentAutoExposure;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugHistogram;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr_s_EmptyHistogramBuffer;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstFrame;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeFieldInfoPtr_k_HistogramBins;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr_k_HistogramThreadX;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr_k_HistogramThreadY;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_ResetHistory_Public_Void_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_GetHistogramScaleOffsetRes_Private_Vector4_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Texture_RenderTexture_Material_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Public_Void_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007CE RID: 1998
		public static class Uniforms : Object
		{
			// Token: 0x0600BB76 RID: 47990 RVA: 0x002E5B9C File Offset: 0x002E3D9C
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<EyeAdaptationComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeAdaptationComponent.Uniforms>.NativeClassPtr);
				EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent.Uniforms>.NativeClassPtr, "_Params");
				EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent.Uniforms>.NativeClassPtr, "_Speed");
				EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__ScaleOffsetRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent.Uniforms>.NativeClassPtr, "_ScaleOffsetRes");
				EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__ExposureCompensation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent.Uniforms>.NativeClassPtr, "_ExposureCompensation");
				EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__AutoExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent.Uniforms>.NativeClassPtr, "_AutoExposure");
				EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__DebugWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent.Uniforms>.NativeClassPtr, "_DebugWidth");
			}

			// Token: 0x0600BB77 RID: 47991 RVA: 0x0005BB85 File Offset: 0x00059D85
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039FA RID: 14842
			// (get) Token: 0x0600BB78 RID: 47992 RVA: 0x002E5C40 File Offset: 0x002E3E40
			// (set) Token: 0x0600BB79 RID: 47993 RVA: 0x0005BB8E File Offset: 0x00059D8E
			public unsafe static int _Params
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__Params, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__Params, (void*)(&value));
				}
			}

			// Token: 0x170039FB RID: 14843
			// (get) Token: 0x0600BB7A RID: 47994 RVA: 0x002E5C5C File Offset: 0x002E3E5C
			// (set) Token: 0x0600BB7B RID: 47995 RVA: 0x0005BB9C File Offset: 0x00059D9C
			public unsafe static int _Speed
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__Speed, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__Speed, (void*)(&value));
				}
			}

			// Token: 0x170039FC RID: 14844
			// (get) Token: 0x0600BB7C RID: 47996 RVA: 0x002E5C78 File Offset: 0x002E3E78
			// (set) Token: 0x0600BB7D RID: 47997 RVA: 0x0005BBAA File Offset: 0x00059DAA
			public unsafe static int _ScaleOffsetRes
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__ScaleOffsetRes, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__ScaleOffsetRes, (void*)(&value));
				}
			}

			// Token: 0x170039FD RID: 14845
			// (get) Token: 0x0600BB7E RID: 47998 RVA: 0x002E5C94 File Offset: 0x002E3E94
			// (set) Token: 0x0600BB7F RID: 47999 RVA: 0x0005BBB8 File Offset: 0x00059DB8
			public unsafe static int _ExposureCompensation
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__ExposureCompensation, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__ExposureCompensation, (void*)(&value));
				}
			}

			// Token: 0x170039FE RID: 14846
			// (get) Token: 0x0600BB80 RID: 48000 RVA: 0x002E5CB0 File Offset: 0x002E3EB0
			// (set) Token: 0x0600BB81 RID: 48001 RVA: 0x0005BBC6 File Offset: 0x00059DC6
			public unsafe static int _AutoExposure
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__AutoExposure, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__AutoExposure, (void*)(&value));
				}
			}

			// Token: 0x170039FF RID: 14847
			// (get) Token: 0x0600BB82 RID: 48002 RVA: 0x002E5CCC File Offset: 0x002E3ECC
			// (set) Token: 0x0600BB83 RID: 48003 RVA: 0x0005BBD4 File Offset: 0x00059DD4
			public unsafe static int _DebugWidth
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__DebugWidth, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__DebugWidth, (void*)(&value));
				}
			}

			// Token: 0x04007E57 RID: 32343
			private static readonly IntPtr NativeFieldInfoPtr__Params;

			// Token: 0x04007E58 RID: 32344
			private static readonly IntPtr NativeFieldInfoPtr__Speed;

			// Token: 0x04007E59 RID: 32345
			private static readonly IntPtr NativeFieldInfoPtr__ScaleOffsetRes;

			// Token: 0x04007E5A RID: 32346
			private static readonly IntPtr NativeFieldInfoPtr__ExposureCompensation;

			// Token: 0x04007E5B RID: 32347
			private static readonly IntPtr NativeFieldInfoPtr__AutoExposure;

			// Token: 0x04007E5C RID: 32348
			private static readonly IntPtr NativeFieldInfoPtr__DebugWidth;
		}
	}
}
