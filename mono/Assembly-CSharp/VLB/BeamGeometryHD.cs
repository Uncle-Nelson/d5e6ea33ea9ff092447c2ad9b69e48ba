using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB
{
	// Token: 0x0200010D RID: 269
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-hd/")]
	public class BeamGeometryHD : BeamGeometryAbstractBase
	{
		// Token: 0x0600040F RID: 1039 RVA: 0x00016363 File Offset: 0x00014563
		protected override VolumetricLightBeamAbstractBase GetMaster()
		{
			return this.m_Master;
		}

		// Token: 0x1700009D RID: 157
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x0001636B File Offset: 0x0001456B
		public bool visible
		{
			set
			{
				if (base.meshRenderer)
				{
					base.meshRenderer.enabled = value;
				}
			}
		}

		// Token: 0x1700009E RID: 158
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00016386 File Offset: 0x00014586
		public int sortingLayerID
		{
			set
			{
				if (base.meshRenderer)
				{
					base.meshRenderer.sortingLayerID = value;
				}
			}
		}

		// Token: 0x1700009F RID: 159
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x000163A1 File Offset: 0x000145A1
		public int sortingOrder
		{
			set
			{
				if (base.meshRenderer)
				{
					base.meshRenderer.sortingOrder = value;
				}
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x000163BC File Offset: 0x000145BC
		private void OnDisable()
		{
			SRPHelper.UnregisterOnBeginCameraRendering(new Action<ScriptableRenderContext, Camera>(this.OnBeginCameraRenderingSRP));
			this.m_CurrentCameraRenderingSRP = null;
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x000022C9 File Offset: 0x000004C9
		public static bool isCustomRenderPipelineSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x000163D6 File Offset: 0x000145D6
		private bool shouldUseGPUInstancedMaterial
		{
			get
			{
				return Config.Instance.GetActualRenderingMode(ShaderMode.HD) == RenderingMode.GPUInstancing && this.m_Cookie == null && this.m_Shadow == null;
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00016404 File Offset: 0x00014604
		private void OnEnable()
		{
			SRPHelper.RegisterOnBeginCameraRendering(new Action<ScriptableRenderContext, Camera>(this.OnBeginCameraRenderingSRP));
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00016418 File Offset: 0x00014618
		public void Initialize(VolumetricLightBeamHD master)
		{
			HideFlags proceduralObjectsHideFlags = Consts.Internal.ProceduralObjectsHideFlags;
			this.m_Master = master;
			base.transform.SetParent(master.transform, false);
			base.meshRenderer = base.gameObject.GetOrAddComponent<MeshRenderer>();
			base.meshRenderer.hideFlags = proceduralObjectsHideFlags;
			base.meshRenderer.shadowCastingMode = ShadowCastingMode.Off;
			base.meshRenderer.receiveShadows = false;
			base.meshRenderer.reflectionProbeUsage = ReflectionProbeUsage.Off;
			base.meshRenderer.lightProbeUsage = LightProbeUsage.Off;
			this.m_Cookie = this.m_Master.GetAdditionalComponentCookie();
			this.m_Shadow = this.m_Master.GetAdditionalComponentShadow();
			if (!this.shouldUseGPUInstancedMaterial)
			{
				this.m_CustomMaterial = Config.Instance.NewMaterialTransient(ShaderMode.HD, false);
				this.ApplyMaterial();
			}
			if (this.m_Master.DoesSupportSorting2D())
			{
				if (SortingLayer.IsValid(this.m_Master.GetSortingLayerID()))
				{
					this.sortingLayerID = this.m_Master.GetSortingLayerID();
				}
				else
				{
					Debug.LogError(string.Format("Beam '{0}' has an invalid sortingLayerID ({1}). Please fix it by setting a valid layer.", Utils.GetPath(this.m_Master.transform), this.m_Master.GetSortingLayerID()));
				}
				this.sortingOrder = this.m_Master.GetSortingOrder();
			}
			base.meshFilter = base.gameObject.GetOrAddComponent<MeshFilter>();
			base.meshFilter.hideFlags = proceduralObjectsHideFlags;
			base.gameObject.hideFlags = proceduralObjectsHideFlags;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00016570 File Offset: 0x00014770
		public void RegenerateMesh()
		{
			if (Config.Instance.geometryOverrideLayer)
			{
				base.gameObject.layer = Config.Instance.geometryLayerID;
			}
			else
			{
				base.gameObject.layer = this.m_Master.gameObject.layer;
			}
			base.gameObject.tag = Config.Instance.geometryTag;
			base.coneMesh = GlobalMeshHD.Get();
			base.meshFilter.sharedMesh = base.coneMesh;
			this.UpdateMaterialAndBounds();
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000165F4 File Offset: 0x000147F4
		private Vector3 ComputeLocalMatrix()
		{
			float num = Mathf.Max(this.m_Master.coneRadiusStart, this.m_Master.coneRadiusEnd);
			Vector3 vector = new Vector3(num, num, this.m_Master.maxGeometryDistance);
			if (!this.m_Master.scalable)
			{
				vector = vector.Divide(this.m_Master.GetLossyScale());
			}
			base.transform.localScale = vector;
			base.transform.localRotation = this.m_Master.beamInternalLocalRotation;
			return vector;
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00016673 File Offset: 0x00014873
		private bool isNoiseEnabled
		{
			get
			{
				return this.m_Master.isNoiseEnabled && this.m_Master.noiseIntensity > 0f && Noise3D.isSupported;
			}
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0001669C File Offset: 0x0001489C
		private MaterialManager.StaticPropertiesHD ComputeMaterialStaticProperties()
		{
			MaterialManager.ColorGradient colorGradient = MaterialManager.ColorGradient.Off;
			if (this.m_Master.colorMode == ColorMode.Gradient)
			{
				colorGradient = ((Utils.GetFloatPackingPrecision() == Utils.FloatPackingPrecision.High) ? MaterialManager.ColorGradient.MatrixHigh : MaterialManager.ColorGradient.MatrixLow);
			}
			return new MaterialManager.StaticPropertiesHD
			{
				blendingMode = (MaterialManager.BlendingMode)this.m_Master.blendingMode,
				attenuation = ((this.m_Master.attenuationEquation == AttenuationEquationHD.Linear) ? MaterialManager.HD.Attenuation.Linear : MaterialManager.HD.Attenuation.Quadratic),
				noise3D = (this.isNoiseEnabled ? MaterialManager.Noise3D.On : MaterialManager.Noise3D.Off),
				colorGradient = colorGradient,
				shadow = ((this.m_Shadow != null) ? MaterialManager.HD.Shadow.On : MaterialManager.HD.Shadow.Off),
				cookie = ((this.m_Cookie != null) ? ((this.m_Cookie.channel == CookieChannel.RGBA) ? MaterialManager.HD.Cookie.RGBA : MaterialManager.HD.Cookie.SingleChannel) : MaterialManager.HD.Cookie.Off),
				raymarchingQualityIndex = this.m_Master.raymarchingQualityIndex
			};
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0001676C File Offset: 0x0001496C
		private bool ApplyMaterial()
		{
			MaterialManager.StaticPropertiesHD staticPropertiesHD = this.ComputeMaterialStaticProperties();
			Material material;
			if (!this.shouldUseGPUInstancedMaterial)
			{
				material = this.m_CustomMaterial;
				if (material)
				{
					staticPropertiesHD.ApplyToMaterial(material);
				}
			}
			else
			{
				material = MaterialManager.GetInstancedMaterial(this.m_Master._INTERNAL_InstancedMaterialGroupID, ref staticPropertiesHD);
			}
			base.meshRenderer.material = material;
			return material != null;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000167C9 File Offset: 0x000149C9
		public void SetMaterialProp(int nameID, float value)
		{
			if (this.m_CustomMaterial)
			{
				this.m_CustomMaterial.SetFloat(nameID, value);
				return;
			}
			MaterialManager.materialPropertyBlock.SetFloat(nameID, value);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x000167F2 File Offset: 0x000149F2
		public void SetMaterialProp(int nameID, Vector4 value)
		{
			if (this.m_CustomMaterial)
			{
				this.m_CustomMaterial.SetVector(nameID, value);
				return;
			}
			MaterialManager.materialPropertyBlock.SetVector(nameID, value);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0001681B File Offset: 0x00014A1B
		public void SetMaterialProp(int nameID, Color value)
		{
			if (this.m_CustomMaterial)
			{
				this.m_CustomMaterial.SetColor(nameID, value);
				return;
			}
			MaterialManager.materialPropertyBlock.SetColor(nameID, value);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00016844 File Offset: 0x00014A44
		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
			if (this.m_CustomMaterial)
			{
				this.m_CustomMaterial.SetMatrix(nameID, value);
				return;
			}
			MaterialManager.materialPropertyBlock.SetMatrix(nameID, value);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0001686D File Offset: 0x00014A6D
		public void SetMaterialProp(int nameID, Texture value)
		{
			if (this.m_CustomMaterial)
			{
				this.m_CustomMaterial.SetTexture(nameID, value);
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0001688C File Offset: 0x00014A8C
		public void SetMaterialProp(int nameID, BeamGeometryHD.InvalidTexture invalidTexture)
		{
			if (this.m_CustomMaterial)
			{
				Texture value = null;
				if (invalidTexture == BeamGeometryHD.InvalidTexture.NoDepth)
				{
					value = (SystemInfo.usesReversedZBuffer ? Texture2D.blackTexture : Texture2D.whiteTexture);
				}
				this.m_CustomMaterial.SetTexture(nameID, value);
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x000168CD File Offset: 0x00014ACD
		private void MaterialChangeStart()
		{
			if (this.m_CustomMaterial == null)
			{
				base.meshRenderer.GetPropertyBlock(MaterialManager.materialPropertyBlock);
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x000168ED File Offset: 0x00014AED
		private void MaterialChangeStop()
		{
			if (this.m_CustomMaterial == null)
			{
				base.meshRenderer.SetPropertyBlock(MaterialManager.materialPropertyBlock);
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0001690D File Offset: 0x00014B0D
		public void SetPropertyDirty(DirtyProps prop)
		{
			this.m_DirtyProps |= prop;
			if (prop.HasAtLeastOneFlag(DirtyProps.OnlyMaterialChangeOnly))
			{
				this.UpdateMaterialAndBounds();
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0001693A File Offset: 0x00014B3A
		private void UpdateMaterialAndBounds()
		{
			if (!this.ApplyMaterial())
			{
				return;
			}
			this.MaterialChangeStart();
			this.m_DirtyProps = DirtyProps.All;
			if (this.isNoiseEnabled)
			{
				Noise3D.LoadIfNeeded();
			}
			this.ComputeLocalMatrix();
			this.UpdateMatricesPropertiesForGPUInstancingSRP();
			this.MaterialChangeStop();
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00016978 File Offset: 0x00014B78
		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
			if (SRPHelper.IsUsingCustomRenderPipeline() && Config.Instance.GetActualRenderingMode(ShaderMode.HD) == RenderingMode.GPUInstancing)
			{
				this.SetMaterialProp(ShaderProperties.LocalToWorldMatrix, base.transform.localToWorldMatrix);
				this.SetMaterialProp(ShaderProperties.WorldToLocalMatrix, base.transform.worldToLocalMatrix);
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x000169C6 File Offset: 0x00014BC6
		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
			this.m_CurrentCameraRenderingSRP = cam;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000169D0 File Offset: 0x00014BD0
		private void OnWillRenderObject()
		{
			Camera cam;
			if (SRPHelper.IsUsingCustomRenderPipeline())
			{
				cam = this.m_CurrentCameraRenderingSRP;
			}
			else
			{
				cam = Camera.current;
			}
			this.OnWillCameraRenderThisBeam(cam);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000169FC File Offset: 0x00014BFC
		private void OnWillCameraRenderThisBeam(Camera cam)
		{
			if (this.m_Master && cam && cam.enabled)
			{
				this.UpdateMaterialPropertiesForCamera(cam);
				if (this.m_Shadow)
				{
					this.m_Shadow.OnWillCameraRenderThisBeam(cam, this);
				}
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00016A3C File Offset: 0x00014C3C
		private void UpdateDirtyMaterialProperties()
		{
			if (this.m_DirtyProps != DirtyProps.None)
			{
				if (this.m_DirtyProps.HasFlag(DirtyProps.Intensity))
				{
					this.SetMaterialProp(ShaderProperties.HD.Intensity, this.m_Master.intensity);
				}
				if (this.m_DirtyProps.HasFlag(DirtyProps.HDRPExposureWeight) && Config.Instance.isHDRPExposureWeightSupported)
				{
					this.SetMaterialProp(ShaderProperties.HDRPExposureWeight, this.m_Master.hdrpExposureWeight);
				}
				if (this.m_DirtyProps.HasFlag(DirtyProps.SideSoftness))
				{
					this.SetMaterialProp(ShaderProperties.HD.SideSoftness, this.m_Master.sideSoftness);
				}
				if (this.m_DirtyProps.HasFlag(DirtyProps.Color))
				{
					if (this.m_Master.colorMode == ColorMode.Flat)
					{
						this.SetMaterialProp(ShaderProperties.ColorFlat, this.m_Master.colorFlat);
					}
					else
					{
						Utils.FloatPackingPrecision floatPackingPrecision = Utils.GetFloatPackingPrecision();
						this.m_ColorGradientMatrix = this.m_Master.colorGradient.SampleInMatrix((int)floatPackingPrecision);
					}
				}
				if (this.m_DirtyProps.HasFlag(DirtyProps.Cone))
				{
					Vector2 v = new Vector2(Mathf.Max(this.m_Master.coneRadiusStart, 0.0001f), Mathf.Max(this.m_Master.coneRadiusEnd, 0.0001f));
					this.SetMaterialProp(ShaderProperties.ConeRadius, v);
					float coneApexOffsetZ = this.m_Master.GetConeApexOffsetZ(false);
					float x = Mathf.Sign(coneApexOffsetZ) * Mathf.Max(Mathf.Abs(coneApexOffsetZ), 0.0001f);
					this.SetMaterialProp(ShaderProperties.ConeGeomProps, new Vector2(x, (float)Config.Instance.sharedMeshSides));
					this.SetMaterialProp(ShaderProperties.DistanceFallOff, new Vector3(this.m_Master.fallOffStart, this.m_Master.fallOffEnd, this.m_Master.maxGeometryDistance));
					this.ComputeLocalMatrix();
				}
				if (this.m_DirtyProps.HasFlag(DirtyProps.Jittering))
				{
					this.SetMaterialProp(ShaderProperties.HD.Jittering, new Vector4(this.m_Master.jitteringFactor, (float)this.m_Master.jitteringFrameRate, this.m_Master.jitteringLerpRange.minValue, this.m_Master.jitteringLerpRange.maxValue));
				}
				if (this.isNoiseEnabled)
				{
					if (this.m_DirtyProps.HasFlag(DirtyProps.NoiseMode) || this.m_DirtyProps.HasFlag(DirtyProps.NoiseIntensity))
					{
						this.SetMaterialProp(ShaderProperties.NoiseParam, new Vector2(this.m_Master.noiseIntensity, (this.m_Master.noiseMode == NoiseMode.WorldSpace) ? 0f : 1f));
					}
					if (this.m_DirtyProps.HasFlag(DirtyProps.NoiseVelocityAndScale))
					{
						Vector3 vector = this.m_Master.noiseVelocityUseGlobal ? Config.Instance.globalNoiseVelocity : this.m_Master.noiseVelocityLocal;
						float w = this.m_Master.noiseScaleUseGlobal ? Config.Instance.globalNoiseScale : this.m_Master.noiseScaleLocal;
						this.SetMaterialProp(ShaderProperties.NoiseVelocityAndScale, new Vector4(vector.x, vector.y, vector.z, w));
					}
				}
				if (this.m_DirtyProps.HasFlag(DirtyProps.CookieProps))
				{
					VolumetricCookieHD.ApplyMaterialProperties(this.m_Cookie, this);
				}
				if (this.m_DirtyProps.HasFlag(DirtyProps.ShadowProps))
				{
					VolumetricShadowHD.ApplyMaterialProperties(this.m_Shadow, this);
				}
				this.m_DirtyProps = DirtyProps.None;
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00016DF8 File Offset: 0x00014FF8
		private void UpdateMaterialPropertiesForCamera(Camera cam)
		{
			if (cam && this.m_Master)
			{
				this.MaterialChangeStart();
				this.SetMaterialProp(ShaderProperties.HD.TransformScale, this.m_Master.scalable ? this.m_Master.GetLossyScale() : Vector3.one);
				Vector3 normalized = base.transform.InverseTransformDirection(cam.transform.forward).normalized;
				this.SetMaterialProp(ShaderProperties.HD.CameraForwardOS, normalized);
				this.SetMaterialProp(ShaderProperties.HD.CameraForwardWS, cam.transform.forward);
				this.UpdateDirtyMaterialProperties();
				if (this.m_Master.colorMode == ColorMode.Gradient)
				{
					this.SetMaterialProp(ShaderProperties.ColorGradientMatrix, this.m_ColorGradientMatrix);
				}
				this.UpdateMatricesPropertiesForGPUInstancingSRP();
				this.MaterialChangeStop();
				cam.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x040005E5 RID: 1509
		private VolumetricLightBeamHD m_Master;

		// Token: 0x040005E6 RID: 1510
		private VolumetricCookieHD m_Cookie;

		// Token: 0x040005E7 RID: 1511
		private VolumetricShadowHD m_Shadow;

		// Token: 0x040005E8 RID: 1512
		private Camera m_CurrentCameraRenderingSRP;

		// Token: 0x040005E9 RID: 1513
		private DirtyProps m_DirtyProps;

		// Token: 0x0200010E RID: 270
		public enum InvalidTexture
		{
			// Token: 0x040005EB RID: 1515
			Null,
			// Token: 0x040005EC RID: 1516
			NoDepth
		}
	}
}
