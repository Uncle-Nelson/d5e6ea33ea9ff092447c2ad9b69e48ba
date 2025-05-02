using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200007C RID: 124
	public class Config : ScriptableObject
	{
		// Token: 0x060008C0 RID: 2240 RVA: 0x0008B828 File Offset: 0x00089A28
		// Note: this type is marked as 'beforefieldinit'.
		static Config()
		{
			Il2CppClassPointerStore<Config>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "Config");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Config>.NativeClassPtr);
			Config.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "ClassName");
			Config.NativeFieldInfoPtr_kAssetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "kAssetName");
			Config.NativeFieldInfoPtr_kAssetNameExt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "kAssetNameExt");
			Config.NativeFieldInfoPtr_geometryOverrideLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "geometryOverrideLayer");
			Config.NativeFieldInfoPtr_geometryLayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "geometryLayerID");
			Config.NativeFieldInfoPtr_geometryTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "geometryTag");
			Config.NativeFieldInfoPtr_geometryRenderQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "geometryRenderQueue");
			Config.NativeFieldInfoPtr_geometryRenderQueueHD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "geometryRenderQueueHD");
			Config.NativeFieldInfoPtr_m_RenderPipeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "m_RenderPipeline");
			Config.NativeFieldInfoPtr_m_RenderingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "m_RenderingMode");
			Config.NativeFieldInfoPtr_ditheringFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "ditheringFactor");
			Config.NativeFieldInfoPtr_useLightColorTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "useLightColorTemperature");
			Config.NativeFieldInfoPtr_sharedMeshSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "sharedMeshSides");
			Config.NativeFieldInfoPtr_sharedMeshSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "sharedMeshSegments");
			Config.NativeFieldInfoPtr_hdBeamsCameraBlendingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "hdBeamsCameraBlendingDistance");
			Config.NativeFieldInfoPtr_urpDepthCameraScriptableRendererIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "urpDepthCameraScriptableRendererIndex");
			Config.NativeFieldInfoPtr_globalNoiseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "globalNoiseScale");
			Config.NativeFieldInfoPtr_globalNoiseVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "globalNoiseVelocity");
			Config.NativeFieldInfoPtr_fadeOutCameraTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "fadeOutCameraTag");
			Config.NativeFieldInfoPtr_noiseTexture3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "noiseTexture3D");
			Config.NativeFieldInfoPtr_dustParticlesPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "dustParticlesPrefab");
			Config.NativeFieldInfoPtr_ditheringNoiseTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "ditheringNoiseTexture");
			Config.NativeFieldInfoPtr_jitteringNoiseTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "jitteringNoiseTexture");
			Config.NativeFieldInfoPtr_featureEnabledColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "featureEnabledColorGradient");
			Config.NativeFieldInfoPtr_featureEnabledDepthBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "featureEnabledDepthBlend");
			Config.NativeFieldInfoPtr_featureEnabledNoise3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "featureEnabledNoise3D");
			Config.NativeFieldInfoPtr_featureEnabledDynamicOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "featureEnabledDynamicOcclusion");
			Config.NativeFieldInfoPtr_featureEnabledMeshSkewing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "featureEnabledMeshSkewing");
			Config.NativeFieldInfoPtr_featureEnabledShaderAccuracyHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "featureEnabledShaderAccuracyHigh");
			Config.NativeFieldInfoPtr_featureEnabledShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "featureEnabledShadow");
			Config.NativeFieldInfoPtr_featureEnabledCookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "featureEnabledCookie");
			Config.NativeFieldInfoPtr_m_RaymarchingQualities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "m_RaymarchingQualities");
			Config.NativeFieldInfoPtr_m_DefaultRaymarchingQualityUniqueID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "m_DefaultRaymarchingQualityUniqueID");
			Config.NativeFieldInfoPtr_pluginVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "pluginVersion");
			Config.NativeFieldInfoPtr__DummyMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "_DummyMaterial");
			Config.NativeFieldInfoPtr__DummyMaterialHD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "_DummyMaterialHD");
			Config.NativeFieldInfoPtr__BeamShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "_BeamShader");
			Config.NativeFieldInfoPtr__BeamShaderHD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "_BeamShaderHD");
			Config.NativeFieldInfoPtr_m_CachedFadeOutCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "m_CachedFadeOutCamera");
			Config.NativeFieldInfoPtr_ms_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "ms_Instance");
			Config.NativeMethodInfoPtr_get_renderPipeline_Public_get_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664234);
			Config.NativeMethodInfoPtr_set_renderPipeline_Public_set_Void_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664235);
			Config.NativeMethodInfoPtr_get_renderingMode_Public_get_RenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664236);
			Config.NativeMethodInfoPtr_set_renderingMode_Public_set_Void_RenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664237);
			Config.NativeMethodInfoPtr_IsSRPBatcherSupported_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664238);
			Config.NativeMethodInfoPtr_GetActualRenderingMode_Public_RenderingMode_ShaderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664239);
			Config.NativeMethodInfoPtr_get_SD_useSinglePassShader_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664240);
			Config.NativeMethodInfoPtr_get_SD_requiresDoubleSidedMesh_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664241);
			Config.NativeMethodInfoPtr_GetBeamShader_Public_Shader_ShaderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664242);
			Config.NativeMethodInfoPtr_GetBeamShaderInternal_Private_byref_Shader_ShaderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664243);
			Config.NativeMethodInfoPtr_GetRenderQueueInternal_Private_Int32_ShaderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664244);
			Config.NativeMethodInfoPtr_NewMaterialTransient_Public_Material_ShaderMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664245);
			Config.NativeMethodInfoPtr_SetURPScriptableRendererIndexToDepthCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664246);
			Config.NativeMethodInfoPtr_get_fadeOutCameraTransform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664247);
			Config.NativeMethodInfoPtr_ForceUpdateFadeOutCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664248);
			Config.NativeMethodInfoPtr_get_defaultRaymarchingQualityUniqueID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664249);
			Config.NativeMethodInfoPtr_GetRaymarchingQualityForIndex_Public_RaymarchingQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664250);
			Config.NativeMethodInfoPtr_GetRaymarchingQualityForUniqueID_Public_RaymarchingQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664251);
			Config.NativeMethodInfoPtr_GetRaymarchingQualityIndexForUniqueID_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664252);
			Config.NativeMethodInfoPtr_IsRaymarchingQualityUniqueIDValid_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664253);
			Config.NativeMethodInfoPtr_get_raymarchingQualitiesCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664254);
			Config.NativeMethodInfoPtr_CreateDefaultRaymarchingQualityPreset_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664255);
			Config.NativeMethodInfoPtr_get_isHDRPExposureWeightSupported_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664256);
			Config.NativeMethodInfoPtr_get_hasRenderPipelineMismatch_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664257);
			Config.NativeMethodInfoPtr_OnStartup_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664258);
			Config.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664259);
			Config.NativeMethodInfoPtr_RefreshGlobalShaderProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664260);
			Config.NativeMethodInfoPtr_ResetInternalData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664261);
			Config.NativeMethodInfoPtr_NewVolumetricDustParticles_Public_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664262);
			Config.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664263);
			Config.NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664264);
			Config.NativeMethodInfoPtr_get_Instance_Public_Static_get_Config_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664265);
			Config.NativeMethodInfoPtr_LoadAssetInternal_Private_Static_Config_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664266);
			Config.NativeMethodInfoPtr_GetInstance_Private_Static_Config_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664267);
			Config.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664268);
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x0008BE34 File Offset: 0x0008A034
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x0008BE70 File Offset: 0x0008A070
		public unsafe RenderPipeline renderPipeline
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 40392, RefRangeEnd = 40393, XrefRangeStart = 40392, XrefRangeEnd = 40393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_renderPipeline_Public_get_RenderPipeline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79594, XrefRangeEnd = 79600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_set_renderPipeline_Public_set_Void_RenderPipeline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x0008BEB0 File Offset: 0x0008A0B0
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x0008BEEC File Offset: 0x0008A0EC
		public unsafe RenderingMode renderingMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45639, RefRangeEnd = 45640, XrefRangeStart = 45639, XrefRangeEnd = 45640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_renderingMode_Public_get_RenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79600, XrefRangeEnd = 79613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_set_renderingMode_Public_set_Void_RenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0008BF2C File Offset: 0x0008A12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79613, XrefRangeEnd = 79614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSRPBatcherSupported()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_IsSRPBatcherSupported_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0008BF68 File Offset: 0x0008A168
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 79615, RefRangeEnd = 79618, XrefRangeStart = 79614, XrefRangeEnd = 79615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderingMode GetActualRenderingMode(ShaderMode shaderMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shaderMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_GetActualRenderingMode_Public_RenderingMode_ShaderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x0008BFB4 File Offset: 0x0008A1B4
		public unsafe bool SD_useSinglePassShader
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 79619, RefRangeEnd = 79623, XrefRangeStart = 79618, XrefRangeEnd = 79619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_SD_useSinglePassShader_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x0008BFF0 File Offset: 0x0008A1F0
		public unsafe bool SD_requiresDoubleSidedMesh
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 79619, RefRangeEnd = 79623, XrefRangeStart = 79619, XrefRangeEnd = 79623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_SD_requiresDoubleSidedMesh_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0008C02C File Offset: 0x0008A22C
		[CallerCount(0)]
		public unsafe Shader GetBeamShader(ShaderMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_GetBeamShader_Public_Shader_ShaderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0008C078 File Offset: 0x0008A278
		[CallerCount(0)]
		public unsafe ref Shader GetBeamShaderInternal(ShaderMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr;
			IntPtr result = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_GetBeamShaderInternal_Private_byref_Shader_ShaderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return result;
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0008C0B8 File Offset: 0x0008A2B8
		[CallerCount(0)]
		public unsafe int GetRenderQueueInternal(ShaderMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_GetRenderQueueInternal_Private_Int32_ShaderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0008C104 File Offset: 0x0008A304
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79641, RefRangeEnd = 79643, XrefRangeStart = 79623, XrefRangeEnd = 79641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material NewMaterialTransient(ShaderMode mode, bool gpuInstanced)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gpuInstanced;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_NewMaterialTransient_Public_Material_ShaderMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0008C160 File Offset: 0x0008A360
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79648, RefRangeEnd = 79650, XrefRangeStart = 79643, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetURPScriptableRendererIndexToDepthCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_SetURPScriptableRendererIndexToDepthCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x0008C1A4 File Offset: 0x0008A3A4
		public unsafe Transform fadeOutCameraTransform
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79661, RefRangeEnd = 79662, XrefRangeStart = 79650, XrefRangeEnd = 79661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_fadeOutCameraTransform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0008C1E4 File Offset: 0x0008A3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79662, XrefRangeEnd = 79669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceUpdateFadeOutCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_ForceUpdateFadeOutCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x0008C218 File Offset: 0x0008A418
		public unsafe int defaultRaymarchingQualityUniqueID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79669, RefRangeEnd = 79670, XrefRangeStart = 79669, XrefRangeEnd = 79669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_defaultRaymarchingQualityUniqueID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0008C254 File Offset: 0x0008A454
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 79670, RefRangeEnd = 79674, XrefRangeStart = 79670, XrefRangeEnd = 79670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RaymarchingQuality GetRaymarchingQualityForIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_GetRaymarchingQualityForIndex_Public_RaymarchingQuality_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RaymarchingQuality>(intPtr3) : null;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0008C2A0 File Offset: 0x0008A4A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79675, RefRangeEnd = 79676, XrefRangeStart = 79674, XrefRangeEnd = 79675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RaymarchingQuality GetRaymarchingQualityForUniqueID(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_GetRaymarchingQualityForUniqueID_Public_RaymarchingQuality_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RaymarchingQuality>(intPtr3) : null;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0008C2EC File Offset: 0x0008A4EC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 79681, RefRangeEnd = 79687, XrefRangeStart = 79676, XrefRangeEnd = 79681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRaymarchingQualityIndexForUniqueID(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_GetRaymarchingQualityIndexForUniqueID_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0008C338 File Offset: 0x0008A538
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79688, RefRangeEnd = 79689, XrefRangeStart = 79687, XrefRangeEnd = 79688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRaymarchingQualityUniqueIDValid(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_IsRaymarchingQualityUniqueIDValid_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x0008C384 File Offset: 0x0008A584
		public unsafe int raymarchingQualitiesCount
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 79689, RefRangeEnd = 79693, XrefRangeStart = 79689, XrefRangeEnd = 79689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_raymarchingQualitiesCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0008C3C0 File Offset: 0x0008A5C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79715, RefRangeEnd = 79717, XrefRangeStart = 79693, XrefRangeEnd = 79715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateDefaultRaymarchingQualityPreset(bool onlyIfNeeded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref onlyIfNeeded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_CreateDefaultRaymarchingQualityPreset_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x0008C400 File Offset: 0x0008A600
		public unsafe bool isHDRPExposureWeightSupported
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79717, RefRangeEnd = 79718, XrefRangeStart = 79717, XrefRangeEnd = 79717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_isHDRPExposureWeightSupported_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x0008C43C File Offset: 0x0008A63C
		public unsafe bool hasRenderPipelineMismatch
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79718, XrefRangeEnd = 79719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_hasRenderPipelineMismatch_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0008C478 File Offset: 0x0008A678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79719, XrefRangeEnd = 79751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnStartup()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_OnStartup_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0008C4A0 File Offset: 0x0008A6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79751, XrefRangeEnd = 79777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0008C4D4 File Offset: 0x0008A6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79777, XrefRangeEnd = 79797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshGlobalShaderProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_RefreshGlobalShaderProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0008C508 File Offset: 0x0008A708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79839, RefRangeEnd = 79840, XrefRangeStart = 79797, XrefRangeEnd = 79839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetInternalData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_ResetInternalData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0008C53C File Offset: 0x0008A73C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79867, RefRangeEnd = 79868, XrefRangeStart = 79840, XrefRangeEnd = 79867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleSystem NewVolumetricDustParticles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_NewVolumetricDustParticles_Public_ParticleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr3) : null;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0008C57C File Offset: 0x0008A77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79868, XrefRangeEnd = 79869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0008C5B0 File Offset: 0x0008A7B0
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref serializedVersion;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x0008C5FC File Offset: 0x0008A7FC
		public unsafe static Config Instance
		{
			[CallerCount(117)]
			[CachedScanResults(RefRangeStart = 79897, RefRangeEnd = 80014, XrefRangeStart = 79869, XrefRangeEnd = 79897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_Instance_Public_Static_get_Config_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Config>(intPtr3) : null;
			}
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0008C630 File Offset: 0x0008A830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80014, XrefRangeEnd = 80017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Config LoadAssetInternal(string assetName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_LoadAssetInternal_Private_Static_Config_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Config>(intPtr3) : null;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0008C674 File Offset: 0x0008A874
		[CallerCount(117)]
		[CachedScanResults(RefRangeStart = 79897, RefRangeEnd = 80014, XrefRangeStart = 79897, XrefRangeEnd = 80014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Config GetInstance(bool assertIfNotFound)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref assertIfNotFound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_GetInstance_Private_Static_Config_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Config>(intPtr3) : null;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0008C6B4 File Offset: 0x0008A8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80017, XrefRangeEnd = 80030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Config() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Config>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00006B66 File Offset: 0x00004D66
		public Config(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x0008C6F0 File Offset: 0x0008A8F0
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x00006B6F File Offset: 0x00004D6F
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x0008C710 File Offset: 0x0008A910
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x00006B81 File Offset: 0x00004D81
		public unsafe static string kAssetName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_kAssetName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_kAssetName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x0008C730 File Offset: 0x0008A930
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x00006B93 File Offset: 0x00004D93
		public unsafe static string kAssetNameExt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_kAssetNameExt, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_kAssetNameExt, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x0008C750 File Offset: 0x0008A950
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x00006BA5 File Offset: 0x00004DA5
		public unsafe bool geometryOverrideLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryOverrideLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryOverrideLayer)) = value;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x0008C778 File Offset: 0x0008A978
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x00006BC0 File Offset: 0x00004DC0
		public unsafe int geometryLayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryLayerID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryLayerID)) = value;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x0008C7A0 File Offset: 0x0008A9A0
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x00006BDB File Offset: 0x00004DDB
		public unsafe string geometryTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryTag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryTag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x0008C7C8 File Offset: 0x0008A9C8
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00006BFA File Offset: 0x00004DFA
		public unsafe int geometryRenderQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryRenderQueue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryRenderQueue)) = value;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x0008C7F0 File Offset: 0x0008A9F0
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x00006C15 File Offset: 0x00004E15
		public unsafe int geometryRenderQueueHD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryRenderQueueHD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryRenderQueueHD)) = value;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x0008C818 File Offset: 0x0008AA18
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x00006C30 File Offset: 0x00004E30
		public unsafe RenderPipeline m_RenderPipeline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_RenderPipeline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_RenderPipeline)) = value;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x0008C840 File Offset: 0x0008AA40
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x00006C4B File Offset: 0x00004E4B
		public unsafe RenderingMode m_RenderingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_RenderingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_RenderingMode)) = value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x0008C868 File Offset: 0x0008AA68
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x00006C66 File Offset: 0x00004E66
		public unsafe float ditheringFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_ditheringFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_ditheringFactor)) = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x0008C890 File Offset: 0x0008AA90
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x00006C81 File Offset: 0x00004E81
		public unsafe bool useLightColorTemperature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_useLightColorTemperature);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_useLightColorTemperature)) = value;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x0008C8B8 File Offset: 0x0008AAB8
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x00006C9C File Offset: 0x00004E9C
		public unsafe int sharedMeshSides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_sharedMeshSides);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_sharedMeshSides)) = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x0008C8E0 File Offset: 0x0008AAE0
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x00006CB7 File Offset: 0x00004EB7
		public unsafe int sharedMeshSegments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_sharedMeshSegments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_sharedMeshSegments)) = value;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x0008C908 File Offset: 0x0008AB08
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x00006CD2 File Offset: 0x00004ED2
		public unsafe float hdBeamsCameraBlendingDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_hdBeamsCameraBlendingDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_hdBeamsCameraBlendingDistance)) = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x0008C930 File Offset: 0x0008AB30
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x00006CED File Offset: 0x00004EED
		public unsafe int urpDepthCameraScriptableRendererIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_urpDepthCameraScriptableRendererIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_urpDepthCameraScriptableRendererIndex)) = value;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x0008C958 File Offset: 0x0008AB58
		// (set) Token: 0x06000906 RID: 2310 RVA: 0x00006D08 File Offset: 0x00004F08
		public unsafe float globalNoiseScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_globalNoiseScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_globalNoiseScale)) = value;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000907 RID: 2311 RVA: 0x0008C980 File Offset: 0x0008AB80
		// (set) Token: 0x06000908 RID: 2312 RVA: 0x00006D23 File Offset: 0x00004F23
		public unsafe Vector3 globalNoiseVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_globalNoiseVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_globalNoiseVelocity)) = value;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x0008C9A8 File Offset: 0x0008ABA8
		// (set) Token: 0x0600090A RID: 2314 RVA: 0x00006D3E File Offset: 0x00004F3E
		public unsafe string fadeOutCameraTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_fadeOutCameraTag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_fadeOutCameraTag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x0008C9D0 File Offset: 0x0008ABD0
		// (set) Token: 0x0600090C RID: 2316 RVA: 0x00006D5D File Offset: 0x00004F5D
		public unsafe Texture3D noiseTexture3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_noiseTexture3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_noiseTexture3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x0008CA00 File Offset: 0x0008AC00
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x00006D7C File Offset: 0x00004F7C
		public unsafe ParticleSystem dustParticlesPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_dustParticlesPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_dustParticlesPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x0008CA30 File Offset: 0x0008AC30
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x00006D9B File Offset: 0x00004F9B
		public unsafe Texture2D ditheringNoiseTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_ditheringNoiseTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_ditheringNoiseTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x0008CA60 File Offset: 0x0008AC60
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x00006DBA File Offset: 0x00004FBA
		public unsafe Texture2D jitteringNoiseTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_jitteringNoiseTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_jitteringNoiseTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x0008CA90 File Offset: 0x0008AC90
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x00006DD9 File Offset: 0x00004FD9
		public unsafe FeatureEnabledColorGradient featureEnabledColorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledColorGradient);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledColorGradient)) = value;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x0008CAB8 File Offset: 0x0008ACB8
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x00006DF4 File Offset: 0x00004FF4
		public unsafe bool featureEnabledDepthBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledDepthBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledDepthBlend)) = value;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x0008CAE0 File Offset: 0x0008ACE0
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x00006E0F File Offset: 0x0000500F
		public unsafe bool featureEnabledNoise3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledNoise3D);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledNoise3D)) = value;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x0008CB08 File Offset: 0x0008AD08
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x00006E2A File Offset: 0x0000502A
		public unsafe bool featureEnabledDynamicOcclusion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledDynamicOcclusion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledDynamicOcclusion)) = value;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x0008CB30 File Offset: 0x0008AD30
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x00006E45 File Offset: 0x00005045
		public unsafe bool featureEnabledMeshSkewing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledMeshSkewing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledMeshSkewing)) = value;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x0008CB58 File Offset: 0x0008AD58
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x00006E60 File Offset: 0x00005060
		public unsafe bool featureEnabledShaderAccuracyHigh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledShaderAccuracyHigh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledShaderAccuracyHigh)) = value;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x0008CB80 File Offset: 0x0008AD80
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x00006E7B File Offset: 0x0000507B
		public unsafe bool featureEnabledShadow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledShadow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledShadow)) = value;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x0008CBA8 File Offset: 0x0008ADA8
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x00006E96 File Offset: 0x00005096
		public unsafe bool featureEnabledCookie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledCookie);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_featureEnabledCookie)) = value;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x0008CBD0 File Offset: 0x0008ADD0
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x00006EB1 File Offset: 0x000050B1
		public unsafe Il2CppReferenceArray<RaymarchingQuality> m_RaymarchingQualities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_RaymarchingQualities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RaymarchingQuality>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_RaymarchingQualities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x0008CC00 File Offset: 0x0008AE00
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x00006ED0 File Offset: 0x000050D0
		public unsafe int m_DefaultRaymarchingQualityUniqueID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_DefaultRaymarchingQualityUniqueID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_DefaultRaymarchingQualityUniqueID)) = value;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x0008CC28 File Offset: 0x0008AE28
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x00006EEB File Offset: 0x000050EB
		public unsafe int pluginVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_pluginVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_pluginVersion)) = value;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x0008CC50 File Offset: 0x0008AE50
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x00006F06 File Offset: 0x00005106
		public unsafe Material _DummyMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr__DummyMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr__DummyMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x0008CC80 File Offset: 0x0008AE80
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x00006F25 File Offset: 0x00005125
		public unsafe Material _DummyMaterialHD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr__DummyMaterialHD);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr__DummyMaterialHD), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x0008CCB0 File Offset: 0x0008AEB0
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x00006F44 File Offset: 0x00005144
		public unsafe Shader _BeamShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr__BeamShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr__BeamShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x0008CCE0 File Offset: 0x0008AEE0
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x00006F63 File Offset: 0x00005163
		public unsafe Shader _BeamShaderHD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr__BeamShaderHD);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr__BeamShaderHD), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x0008CD10 File Offset: 0x0008AF10
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x00006F82 File Offset: 0x00005182
		public unsafe Transform m_CachedFadeOutCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_CachedFadeOutCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_CachedFadeOutCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x0008CD40 File Offset: 0x0008AF40
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x00006FA1 File Offset: 0x000051A1
		public unsafe static Config ms_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_ms_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Config>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_ms_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeFieldInfoPtr_kAssetName;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeFieldInfoPtr_kAssetNameExt;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeFieldInfoPtr_geometryOverrideLayer;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeFieldInfoPtr_geometryLayerID;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeFieldInfoPtr_geometryTag;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeFieldInfoPtr_geometryRenderQueue;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeFieldInfoPtr_geometryRenderQueueHD;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderPipeline;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderingMode;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeFieldInfoPtr_ditheringFactor;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeFieldInfoPtr_useLightColorTemperature;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeFieldInfoPtr_sharedMeshSides;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeFieldInfoPtr_sharedMeshSegments;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeFieldInfoPtr_hdBeamsCameraBlendingDistance;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeFieldInfoPtr_urpDepthCameraScriptableRendererIndex;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeFieldInfoPtr_globalNoiseScale;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeFieldInfoPtr_globalNoiseVelocity;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeFieldInfoPtr_fadeOutCameraTag;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeFieldInfoPtr_noiseTexture3D;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeFieldInfoPtr_dustParticlesPrefab;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeFieldInfoPtr_ditheringNoiseTexture;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeFieldInfoPtr_jitteringNoiseTexture;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeFieldInfoPtr_featureEnabledColorGradient;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeFieldInfoPtr_featureEnabledDepthBlend;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeFieldInfoPtr_featureEnabledNoise3D;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeFieldInfoPtr_featureEnabledDynamicOcclusion;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeFieldInfoPtr_featureEnabledMeshSkewing;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeFieldInfoPtr_featureEnabledShaderAccuracyHigh;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeFieldInfoPtr_featureEnabledShadow;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeFieldInfoPtr_featureEnabledCookie;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeFieldInfoPtr_m_RaymarchingQualities;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultRaymarchingQualityUniqueID;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeFieldInfoPtr_pluginVersion;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeFieldInfoPtr__DummyMaterial;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeFieldInfoPtr__DummyMaterialHD;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeFieldInfoPtr__BeamShader;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeFieldInfoPtr__BeamShaderHD;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedFadeOutCamera;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeFieldInfoPtr_ms_Instance;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_get_renderPipeline_Public_get_RenderPipeline_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_set_renderPipeline_Public_set_Void_RenderPipeline_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingMode_Public_get_RenderingMode_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_set_renderingMode_Public_set_Void_RenderingMode_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_IsSRPBatcherSupported_Public_Boolean_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_GetActualRenderingMode_Public_RenderingMode_ShaderMode_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_get_SD_useSinglePassShader_Public_get_Boolean_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_get_SD_requiresDoubleSidedMesh_Public_get_Boolean_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_GetBeamShader_Public_Shader_ShaderMode_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_GetBeamShaderInternal_Private_byref_Shader_ShaderMode_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderQueueInternal_Private_Int32_ShaderMode_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_NewMaterialTransient_Public_Material_ShaderMode_Boolean_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_SetURPScriptableRendererIndexToDepthCamera_Public_Void_Camera_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeOutCameraTransform_Public_get_Transform_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_ForceUpdateFadeOutCamera_Public_Void_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultRaymarchingQualityUniqueID_Public_get_Int32_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_GetRaymarchingQualityForIndex_Public_RaymarchingQuality_Int32_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_GetRaymarchingQualityForUniqueID_Public_RaymarchingQuality_Int32_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_GetRaymarchingQualityIndexForUniqueID_Public_Int32_Int32_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_IsRaymarchingQualityUniqueIDValid_Public_Boolean_Int32_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_get_raymarchingQualitiesCount_Public_get_Int32_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultRaymarchingQualityPreset_Private_Void_Boolean_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr_get_isHDRPExposureWeightSupported_Public_get_Boolean_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_get_hasRenderPipelineMismatch_Public_get_Boolean_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_OnStartup_Private_Static_Void_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_RefreshGlobalShaderProperties_Private_Void_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_ResetInternalData_Public_Void_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_NewVolumetricDustParticles_Public_ParticleSystem_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_Config_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetInternal_Private_Static_Config_String_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Private_Static_Config_Boolean_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
