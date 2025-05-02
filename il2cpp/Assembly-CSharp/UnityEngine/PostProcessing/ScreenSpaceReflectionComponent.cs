using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200005A RID: 90
	public sealed class ScreenSpaceReflectionComponent : PostProcessingComponentCommandBuffer<ScreenSpaceReflectionModel>
	{
		// Token: 0x060006F2 RID: 1778 RVA: 0x00085658 File Offset: 0x00083858
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenSpaceReflectionComponent()
		{
			Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "ScreenSpaceReflectionComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr);
			ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_HighlightSuppression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, "k_HighlightSuppression");
			ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_TraceBehindObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, "k_TraceBehindObjects");
			ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_TreatBackfaceHitAsMiss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, "k_TreatBackfaceHitAsMiss");
			ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_BilateralUpsample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, "k_BilateralUpsample");
			ScreenSpaceReflectionComponent.NativeFieldInfoPtr_m_ReflectionTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, "m_ReflectionTextures");
			ScreenSpaceReflectionComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, 100664003);
			ScreenSpaceReflectionComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, 100664004);
			ScreenSpaceReflectionComponent.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, 100664005);
			ScreenSpaceReflectionComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, 100664006);
			ScreenSpaceReflectionComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, 100664007);
			ScreenSpaceReflectionComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, 100664008);
			ScreenSpaceReflectionComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, 100664009);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00085778 File Offset: 0x00083978
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 76505, RefRangeEnd = 76509, XrefRangeStart = 76505, XrefRangeEnd = 76509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x000857B4 File Offset: 0x000839B4
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77356, XrefRangeEnd = 77358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x000857F0 File Offset: 0x000839F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77358, XrefRangeEnd = 77373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionComponent.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00085824 File Offset: 0x00083A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77373, XrefRangeEnd = 77375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0008585C File Offset: 0x00083A5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77375, RefRangeEnd = 77377, XrefRangeStart = 77375, XrefRangeEnd = 77375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CameraEvent GetCameraEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00085898 File Offset: 0x00083A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77377, XrefRangeEnd = 77534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PopulateCommandBuffer(CommandBuffer cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x000858DC File Offset: 0x00083ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77534, XrefRangeEnd = 77541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenSpaceReflectionComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00005E5A File Offset: 0x0000405A
		public ScreenSpaceReflectionComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x00085918 File Offset: 0x00083B18
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x00005E63 File Offset: 0x00004063
		public unsafe bool k_HighlightSuppression
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_HighlightSuppression);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_HighlightSuppression)) = value;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00085940 File Offset: 0x00083B40
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x00005E7E File Offset: 0x0000407E
		public unsafe bool k_TraceBehindObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_TraceBehindObjects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_TraceBehindObjects)) = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x00085968 File Offset: 0x00083B68
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x00005E99 File Offset: 0x00004099
		public unsafe bool k_TreatBackfaceHitAsMiss
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_TreatBackfaceHitAsMiss);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_TreatBackfaceHitAsMiss)) = value;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00085990 File Offset: 0x00083B90
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x00005EB4 File Offset: 0x000040B4
		public unsafe bool k_BilateralUpsample
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_BilateralUpsample);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_k_BilateralUpsample)) = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x000859B8 File Offset: 0x00083BB8
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x00005ECF File Offset: 0x000040CF
		public unsafe Il2CppStructArray<int> m_ReflectionTextures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_m_ReflectionTextures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionComponent.NativeFieldInfoPtr_m_ReflectionTextures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeFieldInfoPtr_k_HighlightSuppression;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeFieldInfoPtr_k_TraceBehindObjects;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeFieldInfoPtr_k_TreatBackfaceHitAsMiss;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeFieldInfoPtr_k_BilateralUpsample;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeFieldInfoPtr_m_ReflectionTextures;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007D6 RID: 2006
		public static class Uniforms : Object
		{
			// Token: 0x0600BBF1 RID: 48113 RVA: 0x002E6A80 File Offset: 0x002E4C80
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenSpaceReflectionComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr);
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__RayStepSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_RayStepSize");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__AdditiveReflection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_AdditiveReflection");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__BilateralUpsampling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_BilateralUpsampling");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__TreatBackfaceHitAsMiss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_TreatBackfaceHitAsMiss");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__AllowBackwardsRays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_AllowBackwardsRays");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__TraceBehindObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_TraceBehindObjects");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__MaxSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_MaxSteps");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FullResolutionFiltering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_FullResolutionFiltering");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__HalfResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_HalfResolution");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__HighlightSuppression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_HighlightSuppression");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__PixelsPerMeterAtOneMeter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_PixelsPerMeterAtOneMeter");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ScreenEdgeFading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_ScreenEdgeFading");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ReflectionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_ReflectionBlur");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__MaxRayTraceDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_MaxRayTraceDistance");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FadeDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_FadeDistance");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__LayerThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_LayerThickness");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__SSRMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_SSRMultiplier");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FresnelFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_FresnelFade");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FresnelFadePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_FresnelFadePower");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ReflectionBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_ReflectionBufferSize");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ScreenSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_ScreenSize");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__InvScreenSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_InvScreenSize");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ProjInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_ProjInfo");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__CameraClipInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_CameraClipInfo");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ProjectToPixelMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_ProjectToPixelMatrix");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__WorldToCameraMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_WorldToCameraMatrix");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__CameraToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_CameraToWorldMatrix");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_Axis");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__CurrentMipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_CurrentMipLevel");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__NormalAndRoughnessTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_NormalAndRoughnessTexture");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__HitPointTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_HitPointTexture");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__BlurTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_BlurTexture");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FilteredReflections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_FilteredReflections");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FinalReflectionTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_FinalReflectionTexture");
				ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__TempTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionComponent.Uniforms>.NativeClassPtr, "_TempTexture");
			}

			// Token: 0x0600BBF2 RID: 48114 RVA: 0x0005BEC4 File Offset: 0x0005A0C4
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A2B RID: 14891
			// (get) Token: 0x0600BBF3 RID: 48115 RVA: 0x002E6D68 File Offset: 0x002E4F68
			// (set) Token: 0x0600BBF4 RID: 48116 RVA: 0x0005BECD File Offset: 0x0005A0CD
			public unsafe static int _RayStepSize
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__RayStepSize, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__RayStepSize, (void*)(&value));
				}
			}

			// Token: 0x17003A2C RID: 14892
			// (get) Token: 0x0600BBF5 RID: 48117 RVA: 0x002E6D84 File Offset: 0x002E4F84
			// (set) Token: 0x0600BBF6 RID: 48118 RVA: 0x0005BEDB File Offset: 0x0005A0DB
			public unsafe static int _AdditiveReflection
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__AdditiveReflection, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__AdditiveReflection, (void*)(&value));
				}
			}

			// Token: 0x17003A2D RID: 14893
			// (get) Token: 0x0600BBF7 RID: 48119 RVA: 0x002E6DA0 File Offset: 0x002E4FA0
			// (set) Token: 0x0600BBF8 RID: 48120 RVA: 0x0005BEE9 File Offset: 0x0005A0E9
			public unsafe static int _BilateralUpsampling
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__BilateralUpsampling, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__BilateralUpsampling, (void*)(&value));
				}
			}

			// Token: 0x17003A2E RID: 14894
			// (get) Token: 0x0600BBF9 RID: 48121 RVA: 0x002E6DBC File Offset: 0x002E4FBC
			// (set) Token: 0x0600BBFA RID: 48122 RVA: 0x0005BEF7 File Offset: 0x0005A0F7
			public unsafe static int _TreatBackfaceHitAsMiss
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__TreatBackfaceHitAsMiss, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__TreatBackfaceHitAsMiss, (void*)(&value));
				}
			}

			// Token: 0x17003A2F RID: 14895
			// (get) Token: 0x0600BBFB RID: 48123 RVA: 0x002E6DD8 File Offset: 0x002E4FD8
			// (set) Token: 0x0600BBFC RID: 48124 RVA: 0x0005BF05 File Offset: 0x0005A105
			public unsafe static int _AllowBackwardsRays
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__AllowBackwardsRays, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__AllowBackwardsRays, (void*)(&value));
				}
			}

			// Token: 0x17003A30 RID: 14896
			// (get) Token: 0x0600BBFD RID: 48125 RVA: 0x002E6DF4 File Offset: 0x002E4FF4
			// (set) Token: 0x0600BBFE RID: 48126 RVA: 0x0005BF13 File Offset: 0x0005A113
			public unsafe static int _TraceBehindObjects
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__TraceBehindObjects, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__TraceBehindObjects, (void*)(&value));
				}
			}

			// Token: 0x17003A31 RID: 14897
			// (get) Token: 0x0600BBFF RID: 48127 RVA: 0x002E6E10 File Offset: 0x002E5010
			// (set) Token: 0x0600BC00 RID: 48128 RVA: 0x0005BF21 File Offset: 0x0005A121
			public unsafe static int _MaxSteps
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__MaxSteps, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__MaxSteps, (void*)(&value));
				}
			}

			// Token: 0x17003A32 RID: 14898
			// (get) Token: 0x0600BC01 RID: 48129 RVA: 0x002E6E2C File Offset: 0x002E502C
			// (set) Token: 0x0600BC02 RID: 48130 RVA: 0x0005BF2F File Offset: 0x0005A12F
			public unsafe static int _FullResolutionFiltering
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FullResolutionFiltering, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FullResolutionFiltering, (void*)(&value));
				}
			}

			// Token: 0x17003A33 RID: 14899
			// (get) Token: 0x0600BC03 RID: 48131 RVA: 0x002E6E48 File Offset: 0x002E5048
			// (set) Token: 0x0600BC04 RID: 48132 RVA: 0x0005BF3D File Offset: 0x0005A13D
			public unsafe static int _HalfResolution
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__HalfResolution, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__HalfResolution, (void*)(&value));
				}
			}

			// Token: 0x17003A34 RID: 14900
			// (get) Token: 0x0600BC05 RID: 48133 RVA: 0x002E6E64 File Offset: 0x002E5064
			// (set) Token: 0x0600BC06 RID: 48134 RVA: 0x0005BF4B File Offset: 0x0005A14B
			public unsafe static int _HighlightSuppression
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__HighlightSuppression, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__HighlightSuppression, (void*)(&value));
				}
			}

			// Token: 0x17003A35 RID: 14901
			// (get) Token: 0x0600BC07 RID: 48135 RVA: 0x002E6E80 File Offset: 0x002E5080
			// (set) Token: 0x0600BC08 RID: 48136 RVA: 0x0005BF59 File Offset: 0x0005A159
			public unsafe static int _PixelsPerMeterAtOneMeter
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__PixelsPerMeterAtOneMeter, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__PixelsPerMeterAtOneMeter, (void*)(&value));
				}
			}

			// Token: 0x17003A36 RID: 14902
			// (get) Token: 0x0600BC09 RID: 48137 RVA: 0x002E6E9C File Offset: 0x002E509C
			// (set) Token: 0x0600BC0A RID: 48138 RVA: 0x0005BF67 File Offset: 0x0005A167
			public unsafe static int _ScreenEdgeFading
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ScreenEdgeFading, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ScreenEdgeFading, (void*)(&value));
				}
			}

			// Token: 0x17003A37 RID: 14903
			// (get) Token: 0x0600BC0B RID: 48139 RVA: 0x002E6EB8 File Offset: 0x002E50B8
			// (set) Token: 0x0600BC0C RID: 48140 RVA: 0x0005BF75 File Offset: 0x0005A175
			public unsafe static int _ReflectionBlur
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ReflectionBlur, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ReflectionBlur, (void*)(&value));
				}
			}

			// Token: 0x17003A38 RID: 14904
			// (get) Token: 0x0600BC0D RID: 48141 RVA: 0x002E6ED4 File Offset: 0x002E50D4
			// (set) Token: 0x0600BC0E RID: 48142 RVA: 0x0005BF83 File Offset: 0x0005A183
			public unsafe static int _MaxRayTraceDistance
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__MaxRayTraceDistance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__MaxRayTraceDistance, (void*)(&value));
				}
			}

			// Token: 0x17003A39 RID: 14905
			// (get) Token: 0x0600BC0F RID: 48143 RVA: 0x002E6EF0 File Offset: 0x002E50F0
			// (set) Token: 0x0600BC10 RID: 48144 RVA: 0x0005BF91 File Offset: 0x0005A191
			public unsafe static int _FadeDistance
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FadeDistance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FadeDistance, (void*)(&value));
				}
			}

			// Token: 0x17003A3A RID: 14906
			// (get) Token: 0x0600BC11 RID: 48145 RVA: 0x002E6F0C File Offset: 0x002E510C
			// (set) Token: 0x0600BC12 RID: 48146 RVA: 0x0005BF9F File Offset: 0x0005A19F
			public unsafe static int _LayerThickness
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__LayerThickness, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__LayerThickness, (void*)(&value));
				}
			}

			// Token: 0x17003A3B RID: 14907
			// (get) Token: 0x0600BC13 RID: 48147 RVA: 0x002E6F28 File Offset: 0x002E5128
			// (set) Token: 0x0600BC14 RID: 48148 RVA: 0x0005BFAD File Offset: 0x0005A1AD
			public unsafe static int _SSRMultiplier
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__SSRMultiplier, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__SSRMultiplier, (void*)(&value));
				}
			}

			// Token: 0x17003A3C RID: 14908
			// (get) Token: 0x0600BC15 RID: 48149 RVA: 0x002E6F44 File Offset: 0x002E5144
			// (set) Token: 0x0600BC16 RID: 48150 RVA: 0x0005BFBB File Offset: 0x0005A1BB
			public unsafe static int _FresnelFade
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FresnelFade, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FresnelFade, (void*)(&value));
				}
			}

			// Token: 0x17003A3D RID: 14909
			// (get) Token: 0x0600BC17 RID: 48151 RVA: 0x002E6F60 File Offset: 0x002E5160
			// (set) Token: 0x0600BC18 RID: 48152 RVA: 0x0005BFC9 File Offset: 0x0005A1C9
			public unsafe static int _FresnelFadePower
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FresnelFadePower, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FresnelFadePower, (void*)(&value));
				}
			}

			// Token: 0x17003A3E RID: 14910
			// (get) Token: 0x0600BC19 RID: 48153 RVA: 0x002E6F7C File Offset: 0x002E517C
			// (set) Token: 0x0600BC1A RID: 48154 RVA: 0x0005BFD7 File Offset: 0x0005A1D7
			public unsafe static int _ReflectionBufferSize
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ReflectionBufferSize, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ReflectionBufferSize, (void*)(&value));
				}
			}

			// Token: 0x17003A3F RID: 14911
			// (get) Token: 0x0600BC1B RID: 48155 RVA: 0x002E6F98 File Offset: 0x002E5198
			// (set) Token: 0x0600BC1C RID: 48156 RVA: 0x0005BFE5 File Offset: 0x0005A1E5
			public unsafe static int _ScreenSize
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ScreenSize, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ScreenSize, (void*)(&value));
				}
			}

			// Token: 0x17003A40 RID: 14912
			// (get) Token: 0x0600BC1D RID: 48157 RVA: 0x002E6FB4 File Offset: 0x002E51B4
			// (set) Token: 0x0600BC1E RID: 48158 RVA: 0x0005BFF3 File Offset: 0x0005A1F3
			public unsafe static int _InvScreenSize
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__InvScreenSize, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__InvScreenSize, (void*)(&value));
				}
			}

			// Token: 0x17003A41 RID: 14913
			// (get) Token: 0x0600BC1F RID: 48159 RVA: 0x002E6FD0 File Offset: 0x002E51D0
			// (set) Token: 0x0600BC20 RID: 48160 RVA: 0x0005C001 File Offset: 0x0005A201
			public unsafe static int _ProjInfo
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ProjInfo, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ProjInfo, (void*)(&value));
				}
			}

			// Token: 0x17003A42 RID: 14914
			// (get) Token: 0x0600BC21 RID: 48161 RVA: 0x002E6FEC File Offset: 0x002E51EC
			// (set) Token: 0x0600BC22 RID: 48162 RVA: 0x0005C00F File Offset: 0x0005A20F
			public unsafe static int _CameraClipInfo
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__CameraClipInfo, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__CameraClipInfo, (void*)(&value));
				}
			}

			// Token: 0x17003A43 RID: 14915
			// (get) Token: 0x0600BC23 RID: 48163 RVA: 0x002E7008 File Offset: 0x002E5208
			// (set) Token: 0x0600BC24 RID: 48164 RVA: 0x0005C01D File Offset: 0x0005A21D
			public unsafe static int _ProjectToPixelMatrix
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ProjectToPixelMatrix, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__ProjectToPixelMatrix, (void*)(&value));
				}
			}

			// Token: 0x17003A44 RID: 14916
			// (get) Token: 0x0600BC25 RID: 48165 RVA: 0x002E7024 File Offset: 0x002E5224
			// (set) Token: 0x0600BC26 RID: 48166 RVA: 0x0005C02B File Offset: 0x0005A22B
			public unsafe static int _WorldToCameraMatrix
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__WorldToCameraMatrix, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__WorldToCameraMatrix, (void*)(&value));
				}
			}

			// Token: 0x17003A45 RID: 14917
			// (get) Token: 0x0600BC27 RID: 48167 RVA: 0x002E7040 File Offset: 0x002E5240
			// (set) Token: 0x0600BC28 RID: 48168 RVA: 0x0005C039 File Offset: 0x0005A239
			public unsafe static int _CameraToWorldMatrix
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__CameraToWorldMatrix, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__CameraToWorldMatrix, (void*)(&value));
				}
			}

			// Token: 0x17003A46 RID: 14918
			// (get) Token: 0x0600BC29 RID: 48169 RVA: 0x002E705C File Offset: 0x002E525C
			// (set) Token: 0x0600BC2A RID: 48170 RVA: 0x0005C047 File Offset: 0x0005A247
			public unsafe static int _Axis
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__Axis, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__Axis, (void*)(&value));
				}
			}

			// Token: 0x17003A47 RID: 14919
			// (get) Token: 0x0600BC2B RID: 48171 RVA: 0x002E7078 File Offset: 0x002E5278
			// (set) Token: 0x0600BC2C RID: 48172 RVA: 0x0005C055 File Offset: 0x0005A255
			public unsafe static int _CurrentMipLevel
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__CurrentMipLevel, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__CurrentMipLevel, (void*)(&value));
				}
			}

			// Token: 0x17003A48 RID: 14920
			// (get) Token: 0x0600BC2D RID: 48173 RVA: 0x002E7094 File Offset: 0x002E5294
			// (set) Token: 0x0600BC2E RID: 48174 RVA: 0x0005C063 File Offset: 0x0005A263
			public unsafe static int _NormalAndRoughnessTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__NormalAndRoughnessTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__NormalAndRoughnessTexture, (void*)(&value));
				}
			}

			// Token: 0x17003A49 RID: 14921
			// (get) Token: 0x0600BC2F RID: 48175 RVA: 0x002E70B0 File Offset: 0x002E52B0
			// (set) Token: 0x0600BC30 RID: 48176 RVA: 0x0005C071 File Offset: 0x0005A271
			public unsafe static int _HitPointTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__HitPointTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__HitPointTexture, (void*)(&value));
				}
			}

			// Token: 0x17003A4A RID: 14922
			// (get) Token: 0x0600BC31 RID: 48177 RVA: 0x002E70CC File Offset: 0x002E52CC
			// (set) Token: 0x0600BC32 RID: 48178 RVA: 0x0005C07F File Offset: 0x0005A27F
			public unsafe static int _BlurTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__BlurTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__BlurTexture, (void*)(&value));
				}
			}

			// Token: 0x17003A4B RID: 14923
			// (get) Token: 0x0600BC33 RID: 48179 RVA: 0x002E70E8 File Offset: 0x002E52E8
			// (set) Token: 0x0600BC34 RID: 48180 RVA: 0x0005C08D File Offset: 0x0005A28D
			public unsafe static int _FilteredReflections
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FilteredReflections, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FilteredReflections, (void*)(&value));
				}
			}

			// Token: 0x17003A4C RID: 14924
			// (get) Token: 0x0600BC35 RID: 48181 RVA: 0x002E7104 File Offset: 0x002E5304
			// (set) Token: 0x0600BC36 RID: 48182 RVA: 0x0005C09B File Offset: 0x0005A29B
			public unsafe static int _FinalReflectionTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FinalReflectionTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__FinalReflectionTexture, (void*)(&value));
				}
			}

			// Token: 0x17003A4D RID: 14925
			// (get) Token: 0x0600BC37 RID: 48183 RVA: 0x002E7120 File Offset: 0x002E5320
			// (set) Token: 0x0600BC38 RID: 48184 RVA: 0x0005C0A9 File Offset: 0x0005A2A9
			public unsafe static int _TempTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__TempTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenSpaceReflectionComponent.Uniforms.NativeFieldInfoPtr__TempTexture, (void*)(&value));
				}
			}

			// Token: 0x04007E9D RID: 32413
			private static readonly IntPtr NativeFieldInfoPtr__RayStepSize;

			// Token: 0x04007E9E RID: 32414
			private static readonly IntPtr NativeFieldInfoPtr__AdditiveReflection;

			// Token: 0x04007E9F RID: 32415
			private static readonly IntPtr NativeFieldInfoPtr__BilateralUpsampling;

			// Token: 0x04007EA0 RID: 32416
			private static readonly IntPtr NativeFieldInfoPtr__TreatBackfaceHitAsMiss;

			// Token: 0x04007EA1 RID: 32417
			private static readonly IntPtr NativeFieldInfoPtr__AllowBackwardsRays;

			// Token: 0x04007EA2 RID: 32418
			private static readonly IntPtr NativeFieldInfoPtr__TraceBehindObjects;

			// Token: 0x04007EA3 RID: 32419
			private static readonly IntPtr NativeFieldInfoPtr__MaxSteps;

			// Token: 0x04007EA4 RID: 32420
			private static readonly IntPtr NativeFieldInfoPtr__FullResolutionFiltering;

			// Token: 0x04007EA5 RID: 32421
			private static readonly IntPtr NativeFieldInfoPtr__HalfResolution;

			// Token: 0x04007EA6 RID: 32422
			private static readonly IntPtr NativeFieldInfoPtr__HighlightSuppression;

			// Token: 0x04007EA7 RID: 32423
			private static readonly IntPtr NativeFieldInfoPtr__PixelsPerMeterAtOneMeter;

			// Token: 0x04007EA8 RID: 32424
			private static readonly IntPtr NativeFieldInfoPtr__ScreenEdgeFading;

			// Token: 0x04007EA9 RID: 32425
			private static readonly IntPtr NativeFieldInfoPtr__ReflectionBlur;

			// Token: 0x04007EAA RID: 32426
			private static readonly IntPtr NativeFieldInfoPtr__MaxRayTraceDistance;

			// Token: 0x04007EAB RID: 32427
			private static readonly IntPtr NativeFieldInfoPtr__FadeDistance;

			// Token: 0x04007EAC RID: 32428
			private static readonly IntPtr NativeFieldInfoPtr__LayerThickness;

			// Token: 0x04007EAD RID: 32429
			private static readonly IntPtr NativeFieldInfoPtr__SSRMultiplier;

			// Token: 0x04007EAE RID: 32430
			private static readonly IntPtr NativeFieldInfoPtr__FresnelFade;

			// Token: 0x04007EAF RID: 32431
			private static readonly IntPtr NativeFieldInfoPtr__FresnelFadePower;

			// Token: 0x04007EB0 RID: 32432
			private static readonly IntPtr NativeFieldInfoPtr__ReflectionBufferSize;

			// Token: 0x04007EB1 RID: 32433
			private static readonly IntPtr NativeFieldInfoPtr__ScreenSize;

			// Token: 0x04007EB2 RID: 32434
			private static readonly IntPtr NativeFieldInfoPtr__InvScreenSize;

			// Token: 0x04007EB3 RID: 32435
			private static readonly IntPtr NativeFieldInfoPtr__ProjInfo;

			// Token: 0x04007EB4 RID: 32436
			private static readonly IntPtr NativeFieldInfoPtr__CameraClipInfo;

			// Token: 0x04007EB5 RID: 32437
			private static readonly IntPtr NativeFieldInfoPtr__ProjectToPixelMatrix;

			// Token: 0x04007EB6 RID: 32438
			private static readonly IntPtr NativeFieldInfoPtr__WorldToCameraMatrix;

			// Token: 0x04007EB7 RID: 32439
			private static readonly IntPtr NativeFieldInfoPtr__CameraToWorldMatrix;

			// Token: 0x04007EB8 RID: 32440
			private static readonly IntPtr NativeFieldInfoPtr__Axis;

			// Token: 0x04007EB9 RID: 32441
			private static readonly IntPtr NativeFieldInfoPtr__CurrentMipLevel;

			// Token: 0x04007EBA RID: 32442
			private static readonly IntPtr NativeFieldInfoPtr__NormalAndRoughnessTexture;

			// Token: 0x04007EBB RID: 32443
			private static readonly IntPtr NativeFieldInfoPtr__HitPointTexture;

			// Token: 0x04007EBC RID: 32444
			private static readonly IntPtr NativeFieldInfoPtr__BlurTexture;

			// Token: 0x04007EBD RID: 32445
			private static readonly IntPtr NativeFieldInfoPtr__FilteredReflections;

			// Token: 0x04007EBE RID: 32446
			private static readonly IntPtr NativeFieldInfoPtr__FinalReflectionTexture;

			// Token: 0x04007EBF RID: 32447
			private static readonly IntPtr NativeFieldInfoPtr__TempTexture;
		}

		// Token: 0x020007D7 RID: 2007
		[OriginalName("Assembly-CSharp.dll", "", "PassIndex")]
		public enum PassIndex
		{
			// Token: 0x04007EC1 RID: 32449
			RayTraceStep,
			// Token: 0x04007EC2 RID: 32450
			CompositeFinal,
			// Token: 0x04007EC3 RID: 32451
			Blur,
			// Token: 0x04007EC4 RID: 32452
			CompositeSSR,
			// Token: 0x04007EC5 RID: 32453
			MinMipGeneration,
			// Token: 0x04007EC6 RID: 32454
			HitPointToReflections,
			// Token: 0x04007EC7 RID: 32455
			BilateralKeyPack,
			// Token: 0x04007EC8 RID: 32456
			BlitDepthAsCSZ,
			// Token: 0x04007EC9 RID: 32457
			PoissonBlur
		}
	}
}
