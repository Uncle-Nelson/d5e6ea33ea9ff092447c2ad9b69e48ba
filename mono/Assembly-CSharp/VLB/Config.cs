using System;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Serialization;

namespace VLB
{
	// Token: 0x020000E0 RID: 224
	[HelpURL("http://saladgamer.com/vlb-doc/config/")]
	public class Config : ScriptableObject
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060003AD RID: 941 RVA: 0x00015433 File Offset: 0x00013633
		// (set) Token: 0x060003AE RID: 942 RVA: 0x0001543B File Offset: 0x0001363B
		public RenderPipeline renderPipeline
		{
			get
			{
				return this.m_RenderPipeline;
			}
			set
			{
				Debug.LogError("Modifying the RenderPipeline in standalone builds is not permitted");
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00015447 File Offset: 0x00013647
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x0001544F File Offset: 0x0001364F
		public RenderingMode renderingMode
		{
			get
			{
				return this.m_RenderingMode;
			}
			set
			{
				Debug.LogError("Modifying the RenderingMode in standalone builds is not permitted");
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0001545C File Offset: 0x0001365C
		public bool IsSRPBatcherSupported()
		{
			if (this.renderPipeline == RenderPipeline.BuiltIn)
			{
				return false;
			}
			RenderPipeline projectRenderPipeline = SRPHelper.projectRenderPipeline;
			return projectRenderPipeline == RenderPipeline.URP || projectRenderPipeline == RenderPipeline.HDRP;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00015483 File Offset: 0x00013683
		public RenderingMode GetActualRenderingMode(ShaderMode shaderMode)
		{
			if (this.renderingMode == RenderingMode.SRPBatcher && !this.IsSRPBatcherSupported())
			{
				return RenderingMode.Default;
			}
			if (this.renderPipeline != RenderPipeline.BuiltIn && this.renderingMode == RenderingMode.MultiPass)
			{
				return RenderingMode.Default;
			}
			if (shaderMode == ShaderMode.HD && this.renderingMode == RenderingMode.MultiPass)
			{
				return RenderingMode.Default;
			}
			return this.renderingMode;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x000154BE File Offset: 0x000136BE
		public bool SD_useSinglePassShader
		{
			get
			{
				return this.GetActualRenderingMode(ShaderMode.SD) > RenderingMode.MultiPass;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x000154CA File Offset: 0x000136CA
		public bool SD_requiresDoubleSidedMesh
		{
			get
			{
				return this.SD_useSinglePassShader;
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x000154D2 File Offset: 0x000136D2
		public unsafe Shader GetBeamShader(ShaderMode mode)
		{
			return *this.GetBeamShaderInternal(mode);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x000154DC File Offset: 0x000136DC
		private ref Shader GetBeamShaderInternal(ShaderMode mode)
		{
			if (mode == ShaderMode.SD)
			{
				return ref this._BeamShader;
			}
			return ref this._BeamShaderHD;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x000154EE File Offset: 0x000136EE
		private int GetRenderQueueInternal(ShaderMode mode)
		{
			if (mode == ShaderMode.SD)
			{
				return this.geometryRenderQueue;
			}
			return this.geometryRenderQueueHD;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00015500 File Offset: 0x00013700
		public Material NewMaterialTransient(ShaderMode mode, bool gpuInstanced)
		{
			Material material = MaterialManager.NewMaterialPersistent(this.GetBeamShader(mode), gpuInstanced);
			if (material)
			{
				material.hideFlags = Consts.Internal.ProceduralObjectsHideFlags;
				material.renderQueue = this.GetRenderQueueInternal(mode);
			}
			return material;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0001553C File Offset: 0x0001373C
		public void SetURPScriptableRendererIndexToDepthCamera(Camera camera)
		{
			if (this.urpDepthCameraScriptableRendererIndex < 0)
			{
				return;
			}
			UniversalAdditionalCameraData universalAdditionalCameraData = CameraExtensions.GetUniversalAdditionalCameraData(camera);
			if (universalAdditionalCameraData)
			{
				universalAdditionalCameraData.SetRenderer(this.urpDepthCameraScriptableRendererIndex);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060003BA RID: 954 RVA: 0x0001556E File Offset: 0x0001376E
		public Transform fadeOutCameraTransform
		{
			get
			{
				if (this.m_CachedFadeOutCamera == null)
				{
					this.ForceUpdateFadeOutCamera();
				}
				return this.m_CachedFadeOutCamera;
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0001558C File Offset: 0x0001378C
		public void ForceUpdateFadeOutCamera()
		{
			GameObject gameObject = GameObject.FindGameObjectWithTag(this.fadeOutCameraTag);
			if (gameObject)
			{
				this.m_CachedFadeOutCamera = gameObject.transform;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060003BC RID: 956 RVA: 0x000155B9 File Offset: 0x000137B9
		public int defaultRaymarchingQualityUniqueID
		{
			get
			{
				return this.m_DefaultRaymarchingQualityUniqueID;
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000155C1 File Offset: 0x000137C1
		public RaymarchingQuality GetRaymarchingQualityForIndex(int index)
		{
			return this.m_RaymarchingQualities[index];
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000155CC File Offset: 0x000137CC
		public RaymarchingQuality GetRaymarchingQualityForUniqueID(int id)
		{
			int raymarchingQualityIndexForUniqueID = this.GetRaymarchingQualityIndexForUniqueID(id);
			if (raymarchingQualityIndexForUniqueID >= 0)
			{
				return this.GetRaymarchingQualityForIndex(raymarchingQualityIndexForUniqueID);
			}
			return null;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x000155F0 File Offset: 0x000137F0
		public int GetRaymarchingQualityIndexForUniqueID(int id)
		{
			for (int i = 0; i < this.m_RaymarchingQualities.Length; i++)
			{
				RaymarchingQuality raymarchingQuality = this.m_RaymarchingQualities[i];
				if (raymarchingQuality != null && raymarchingQuality.uniqueID == id)
				{
					return i;
				}
			}
			Debug.LogErrorFormat("Failed to find RaymarchingQualityIndex for Unique ID {0}", new object[]
			{
				id
			});
			return -1;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00015641 File Offset: 0x00013841
		public bool IsRaymarchingQualityUniqueIDValid(int id)
		{
			return this.GetRaymarchingQualityIndexForUniqueID(id) >= 0;
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00015650 File Offset: 0x00013850
		public int raymarchingQualitiesCount
		{
			get
			{
				return Mathf.Max(1, (this.m_RaymarchingQualities != null) ? this.m_RaymarchingQualities.Length : 1);
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0001566C File Offset: 0x0001386C
		private void CreateDefaultRaymarchingQualityPreset(bool onlyIfNeeded)
		{
			if (this.m_RaymarchingQualities == null || this.m_RaymarchingQualities.Length == 0 || !onlyIfNeeded)
			{
				this.m_RaymarchingQualities = new RaymarchingQuality[3];
				this.m_RaymarchingQualities[0] = RaymarchingQuality.New("Fast", 1, 5);
				this.m_RaymarchingQualities[1] = RaymarchingQuality.New("Balanced", 2, 10);
				this.m_RaymarchingQualities[2] = RaymarchingQuality.New("High", 3, 20);
				this.m_DefaultRaymarchingQualityUniqueID = this.m_RaymarchingQualities[1].uniqueID;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x000156EA File Offset: 0x000138EA
		public bool isHDRPExposureWeightSupported
		{
			get
			{
				return this.renderPipeline == RenderPipeline.HDRP;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x000156F5 File Offset: 0x000138F5
		public bool hasRenderPipelineMismatch
		{
			get
			{
				return SRPHelper.projectRenderPipeline == RenderPipeline.BuiltIn != (this.m_RenderPipeline == RenderPipeline.BuiltIn);
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0001570D File Offset: 0x0001390D
		[RuntimeInitializeOnLoadMethod]
		private static void OnStartup()
		{
			Config.Instance.m_CachedFadeOutCamera = null;
			Config.Instance.RefreshGlobalShaderProperties();
			if (Config.Instance.hasRenderPipelineMismatch)
			{
				Debug.LogError("It looks like the 'Render Pipeline' is not correctly set in the config. Please make sure to select the proper value depending on your pipeline in use.", Config.Instance);
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00015740 File Offset: 0x00013940
		public void Reset()
		{
			this.geometryOverrideLayer = true;
			this.geometryLayerID = 1;
			this.geometryTag = "Untagged";
			this.geometryRenderQueue = 3000;
			this.geometryRenderQueueHD = 3100;
			this.sharedMeshSides = 24;
			this.sharedMeshSegments = 5;
			this.globalNoiseScale = 0.5f;
			this.globalNoiseVelocity = Consts.Beam.NoiseVelocityDefault;
			this.renderPipeline = RenderPipeline.BuiltIn;
			this.renderingMode = RenderingMode.Default;
			this.ditheringFactor = 0f;
			this.useLightColorTemperature = true;
			this.fadeOutCameraTag = "MainCamera";
			this.featureEnabledColorGradient = FeatureEnabledColorGradient.HighOnly;
			this.featureEnabledDepthBlend = true;
			this.featureEnabledNoise3D = true;
			this.featureEnabledDynamicOcclusion = true;
			this.featureEnabledMeshSkewing = true;
			this.featureEnabledShaderAccuracyHigh = true;
			this.hdBeamsCameraBlendingDistance = 0.5f;
			this.urpDepthCameraScriptableRendererIndex = -1;
			this.CreateDefaultRaymarchingQualityPreset(false);
			this.ResetInternalData();
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00015818 File Offset: 0x00013A18
		private void RefreshGlobalShaderProperties()
		{
			Shader.SetGlobalFloat(ShaderProperties.GlobalUsesReversedZBuffer, SystemInfo.usesReversedZBuffer ? 1f : 0f);
			Shader.SetGlobalFloat(ShaderProperties.GlobalDitheringFactor, this.ditheringFactor);
			Shader.SetGlobalTexture(ShaderProperties.GlobalDitheringNoiseTex, this.ditheringNoiseTexture);
			Shader.SetGlobalFloat(ShaderProperties.HD.GlobalCameraBlendingDistance, this.hdBeamsCameraBlendingDistance);
			Shader.SetGlobalTexture(ShaderProperties.HD.GlobalJitteringNoiseTex, this.jitteringNoiseTexture);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00015884 File Offset: 0x00013A84
		public void ResetInternalData()
		{
			this.noiseTexture3D = (Resources.Load("Noise3D_64x64x64") as Texture3D);
			this.dustParticlesPrefab = (Resources.Load("DustParticles", typeof(ParticleSystem)) as ParticleSystem);
			this.ditheringNoiseTexture = (Resources.Load("VLBDitheringNoise", typeof(Texture2D)) as Texture2D);
			this.jitteringNoiseTexture = (Resources.Load("VLBBlueNoise", typeof(Texture2D)) as Texture2D);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00015904 File Offset: 0x00013B04
		public ParticleSystem NewVolumetricDustParticles()
		{
			if (!this.dustParticlesPrefab)
			{
				if (Application.isPlaying)
				{
					Debug.LogError("Failed to instantiate VolumetricDustParticles prefab.");
				}
				return null;
			}
			ParticleSystem particleSystem = Object.Instantiate<ParticleSystem>(this.dustParticlesPrefab);
			particleSystem.useAutoRandomSeed = false;
			particleSystem.name = "Dust Particles";
			particleSystem.gameObject.hideFlags = Consts.Internal.ProceduralObjectsHideFlags;
			particleSystem.gameObject.SetActive(true);
			return particleSystem;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0001596A File Offset: 0x00013B6A
		private void OnEnable()
		{
			this.CreateDefaultRaymarchingQualityPreset(true);
			this.HandleBackwardCompatibility(this.pluginVersion, 20100);
			this.pluginVersion = 20100;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x000045B1 File Offset: 0x000027B1
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060003CC RID: 972 RVA: 0x0001598F File Offset: 0x00013B8F
		public static Config Instance
		{
			get
			{
				return Config.GetInstance(true);
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00015997 File Offset: 0x00013B97
		private static Config LoadAssetInternal(string assetName)
		{
			return Resources.Load<Config>(assetName);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x000159A0 File Offset: 0x00013BA0
		private static Config GetInstance(bool assertIfNotFound)
		{
			if (Config.ms_Instance == null)
			{
				Config x = Config.LoadAssetInternal("VLBConfigOverride" + PlatformHelper.GetCurrentPlatformSuffix());
				if (x == null)
				{
					x = Config.LoadAssetInternal("VLBConfigOverride");
				}
				Config.ms_Instance = x;
				Config.ms_Instance == null;
			}
			return Config.ms_Instance;
		}

		// Token: 0x04000490 RID: 1168
		public const string ClassName = "Config";

		// Token: 0x04000491 RID: 1169
		public const string kAssetName = "VLBConfigOverride";

		// Token: 0x04000492 RID: 1170
		public const string kAssetNameExt = ".asset";

		// Token: 0x04000493 RID: 1171
		public bool geometryOverrideLayer = true;

		// Token: 0x04000494 RID: 1172
		public int geometryLayerID = 1;

		// Token: 0x04000495 RID: 1173
		public string geometryTag = "Untagged";

		// Token: 0x04000496 RID: 1174
		public int geometryRenderQueue = 3000;

		// Token: 0x04000497 RID: 1175
		public int geometryRenderQueueHD = 3100;

		// Token: 0x04000498 RID: 1176
		[FormerlySerializedAs("renderPipeline")]
		[FormerlySerializedAs("_RenderPipeline")]
		[SerializeField]
		private RenderPipeline m_RenderPipeline;

		// Token: 0x04000499 RID: 1177
		[FormerlySerializedAs("renderingMode")]
		[FormerlySerializedAs("_RenderingMode")]
		[SerializeField]
		private RenderingMode m_RenderingMode = RenderingMode.Default;

		// Token: 0x0400049A RID: 1178
		public float ditheringFactor;

		// Token: 0x0400049B RID: 1179
		public bool useLightColorTemperature = true;

		// Token: 0x0400049C RID: 1180
		public int sharedMeshSides = 24;

		// Token: 0x0400049D RID: 1181
		public int sharedMeshSegments = 5;

		// Token: 0x0400049E RID: 1182
		public float hdBeamsCameraBlendingDistance = 0.5f;

		// Token: 0x0400049F RID: 1183
		public int urpDepthCameraScriptableRendererIndex = -1;

		// Token: 0x040004A0 RID: 1184
		[Range(0.01f, 2f)]
		public float globalNoiseScale = 0.5f;

		// Token: 0x040004A1 RID: 1185
		public Vector3 globalNoiseVelocity = Consts.Beam.NoiseVelocityDefault;

		// Token: 0x040004A2 RID: 1186
		public string fadeOutCameraTag = "MainCamera";

		// Token: 0x040004A3 RID: 1187
		[HighlightNull]
		public Texture3D noiseTexture3D;

		// Token: 0x040004A4 RID: 1188
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		// Token: 0x040004A5 RID: 1189
		[HighlightNull]
		public Texture2D ditheringNoiseTexture;

		// Token: 0x040004A6 RID: 1190
		[HighlightNull]
		public Texture2D jitteringNoiseTexture;

		// Token: 0x040004A7 RID: 1191
		public FeatureEnabledColorGradient featureEnabledColorGradient = FeatureEnabledColorGradient.HighOnly;

		// Token: 0x040004A8 RID: 1192
		public bool featureEnabledDepthBlend = true;

		// Token: 0x040004A9 RID: 1193
		public bool featureEnabledNoise3D = true;

		// Token: 0x040004AA RID: 1194
		public bool featureEnabledDynamicOcclusion = true;

		// Token: 0x040004AB RID: 1195
		public bool featureEnabledMeshSkewing = true;

		// Token: 0x040004AC RID: 1196
		public bool featureEnabledShaderAccuracyHigh = true;

		// Token: 0x040004AD RID: 1197
		public bool featureEnabledShadow = true;

		// Token: 0x040004AE RID: 1198
		public bool featureEnabledCookie = true;

		// Token: 0x040004AF RID: 1199
		[SerializeField]
		private RaymarchingQuality[] m_RaymarchingQualities;

		// Token: 0x040004B0 RID: 1200
		[SerializeField]
		private int m_DefaultRaymarchingQualityUniqueID;

		// Token: 0x040004B1 RID: 1201
		[SerializeField]
		private int pluginVersion = -1;

		// Token: 0x040004B2 RID: 1202
		[SerializeField]
		private Material _DummyMaterial;

		// Token: 0x040004B3 RID: 1203
		[SerializeField]
		private Material _DummyMaterialHD;

		// Token: 0x040004B4 RID: 1204
		[SerializeField]
		private Shader _BeamShader;

		// Token: 0x040004B5 RID: 1205
		[SerializeField]
		private Shader _BeamShaderHD;

		// Token: 0x040004B6 RID: 1206
		private Transform m_CachedFadeOutCamera;

		// Token: 0x040004B7 RID: 1207
		private static Config ms_Instance;
	}
}
