using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000115 RID: 277
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeamHD))]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-shadow-hd/")]
	public class VolumetricShadowHD : MonoBehaviour
	{
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00017EE7 File Offset: 0x000160E7
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00017EEF File Offset: 0x000160EF
		public float strength
		{
			get
			{
				return this.m_Strength;
			}
			set
			{
				if (this.m_Strength != value)
				{
					this.m_Strength = value;
					this.SetDirty();
				}
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00017F07 File Offset: 0x00016107
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x00017F0F File Offset: 0x0001610F
		public ShadowUpdateRate updateRate
		{
			get
			{
				return this.m_UpdateRate;
			}
			set
			{
				this.m_UpdateRate = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00017F18 File Offset: 0x00016118
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00017F20 File Offset: 0x00016120
		public int waitXFrames
		{
			get
			{
				return this.m_WaitXFrames;
			}
			set
			{
				this.m_WaitXFrames = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00017F29 File Offset: 0x00016129
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00017F31 File Offset: 0x00016131
		public LayerMask layerMask
		{
			get
			{
				return this.m_LayerMask;
			}
			set
			{
				this.m_LayerMask = value;
				this.UpdateDepthCameraProperties();
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00017F40 File Offset: 0x00016140
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00017F48 File Offset: 0x00016148
		public bool useOcclusionCulling
		{
			get
			{
				return this.m_UseOcclusionCulling;
			}
			set
			{
				this.m_UseOcclusionCulling = value;
				this.UpdateDepthCameraProperties();
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00017F57 File Offset: 0x00016157
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00017F5F File Offset: 0x0001615F
		public int depthMapResolution
		{
			get
			{
				return this.m_DepthMapResolution;
			}
			set
			{
				if (this.m_DepthCamera != null && Application.isPlaying)
				{
					Debug.LogErrorFormat(Consts.Shadow.GetErrorChangeRuntimeDepthMapResolution(this), Array.Empty<object>());
				}
				this.m_DepthMapResolution = value;
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00017F8D File Offset: 0x0001618D
		public void ProcessOcclusionManually()
		{
			this.ProcessOcclusion(VolumetricShadowHD.ProcessOcclusionSource.User);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00017F96 File Offset: 0x00016196
		public void UpdateDepthCameraProperties()
		{
			if (this.m_DepthCamera)
			{
				this.m_DepthCamera.cullingMask = this.layerMask;
				this.m_DepthCamera.useOcclusionCulling = this.useOcclusionCulling;
			}
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00017FCC File Offset: 0x000161CC
		private void ProcessOcclusion(VolumetricShadowHD.ProcessOcclusionSource source)
		{
			if (!Config.Instance.featureEnabledShadow)
			{
				return;
			}
			if (this.m_LastFrameRendered == Time.frameCount && Application.isPlaying && source == VolumetricShadowHD.ProcessOcclusionSource.OnEnable)
			{
				return;
			}
			if (SRPHelper.IsUsingCustomRenderPipeline())
			{
				this.m_NeedToUpdateOcclusionNextFrame = true;
			}
			else
			{
				this.ProcessOcclusionInternal();
			}
			this.SetDirty();
			if (this.updateRate.HasFlag(ShadowUpdateRate.OnBeamMove))
			{
				this.m_TransformPacked = base.transform.GetWorldPacked();
			}
			bool flag = this.m_LastFrameRendered < 0;
			this.m_LastFrameRendered = Time.frameCount;
			if (flag && VolumetricShadowHD._INTERNAL_ApplyRandomFrameOffset)
			{
				this.m_LastFrameRendered += Random.Range(0, this.waitXFrames);
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0001807C File Offset: 0x0001627C
		public static void ApplyMaterialProperties(VolumetricShadowHD instance, BeamGeometryHD geom)
		{
			if (instance && instance.enabled)
			{
				geom.SetMaterialProp(ShaderProperties.HD.ShadowDepthTexture, instance.m_DepthCamera.targetTexture);
				Vector3 vector = instance.m_Master.scalable ? instance.m_Master.GetLossyScale() : Vector3.one;
				geom.SetMaterialProp(ShaderProperties.HD.ShadowProps, new Vector4(Mathf.Sign(vector.x) * Mathf.Sign(vector.z), Mathf.Sign(vector.y), instance.m_Strength, instance.m_DepthCamera.orthographic ? 0f : 1f));
				return;
			}
			geom.SetMaterialProp(ShaderProperties.HD.ShadowDepthTexture, BeamGeometryHD.InvalidTexture.NoDepth);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00018133 File Offset: 0x00016333
		private void Awake()
		{
			this.m_Master = base.GetComponent<VolumetricLightBeamHD>();
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00018141 File Offset: 0x00016341
		private void OnEnable()
		{
			this.OnValidateProperties();
			this.InstantiateOrActivateDepthCamera();
			this.OnBeamEnabled();
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00018155 File Offset: 0x00016355
		private void OnDisable()
		{
			if (this.m_DepthCamera)
			{
				this.m_DepthCamera.gameObject.SetActive(false);
			}
			this.SetDirty();
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0001817B File Offset: 0x0001637B
		private void OnDestroy()
		{
			this.DestroyDepthCamera();
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00018183 File Offset: 0x00016383
		private void ProcessOcclusionInternal()
		{
			this.UpdateDepthCameraPropertiesAccordingToBeam();
			this.m_DepthCamera.Render();
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00018196 File Offset: 0x00016396
		private void OnBeamEnabled()
		{
			if (!base.enabled)
			{
				return;
			}
			if (!this.updateRate.HasFlag(ShadowUpdateRate.Never))
			{
				this.ProcessOcclusion(VolumetricShadowHD.ProcessOcclusionSource.OnEnable);
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x000181C0 File Offset: 0x000163C0
		public void OnWillCameraRenderThisBeam(Camera cam, BeamGeometryHD beamGeom)
		{
			if (!base.enabled)
			{
				return;
			}
			if (cam != null && cam.enabled && Time.frameCount != this.m_LastFrameRendered && this.updateRate != ShadowUpdateRate.Never)
			{
				bool flag = false;
				if (!flag && this.updateRate.HasFlag(ShadowUpdateRate.OnBeamMove) && !this.m_TransformPacked.IsSame(base.transform))
				{
					flag = true;
				}
				if (!flag && this.updateRate.HasFlag(ShadowUpdateRate.EveryXFrames) && Time.frameCount >= this.m_LastFrameRendered + this.waitXFrames)
				{
					flag = true;
				}
				if (flag)
				{
					this.ProcessOcclusion(VolumetricShadowHD.ProcessOcclusionSource.RenderLoop);
				}
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00018270 File Offset: 0x00016470
		private void Update()
		{
			if (this.m_NeedToUpdateOcclusionNextFrame && this.m_Master && this.m_DepthCamera && Time.frameCount > 1)
			{
				this.ProcessOcclusionInternal();
				this.m_NeedToUpdateOcclusionNextFrame = false;
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x000182AC File Offset: 0x000164AC
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
			Utils.SetupDepthCamera(this.m_DepthCamera, this.m_Master.GetConeApexOffsetZ(true), this.m_Master.maxGeometryDistance, this.m_Master.coneRadiusStart, this.m_Master.coneRadiusEnd, this.m_Master.beamLocalForward, this.m_Master.GetLossyScale(), this.m_Master.scalable, this.m_Master.beamInternalLocalRotation, false);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00018320 File Offset: 0x00016520
		private void InstantiateOrActivateDepthCamera()
		{
			if (this.m_DepthCamera != null)
			{
				this.m_DepthCamera.gameObject.SetActive(true);
				return;
			}
			base.gameObject.ForeachComponentsInDirectChildrenOnly(delegate(Camera cam)
			{
				Object.DestroyImmediate(cam.gameObject);
			}, true);
			this.m_DepthCamera = Utils.NewWithComponent<Camera>("Depth Camera");
			if (this.m_DepthCamera && this.m_Master)
			{
				this.m_DepthCamera.enabled = false;
				this.UpdateDepthCameraProperties();
				this.m_DepthCamera.clearFlags = CameraClearFlags.Depth;
				this.m_DepthCamera.depthTextureMode = DepthTextureMode.Depth;
				this.m_DepthCamera.renderingPath = RenderingPath.Forward;
				this.m_DepthCamera.gameObject.hideFlags = Consts.Internal.ProceduralObjectsHideFlags;
				this.m_DepthCamera.transform.SetParent(base.transform, false);
				Config.Instance.SetURPScriptableRendererIndexToDepthCamera(this.m_DepthCamera);
				RenderTexture targetTexture = new RenderTexture(this.depthMapResolution, this.depthMapResolution, 16, RenderTextureFormat.Depth);
				this.m_DepthCamera.targetTexture = targetTexture;
				this.UpdateDepthCameraPropertiesAccordingToBeam();
			}
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00018444 File Offset: 0x00016644
		private void DestroyDepthCamera()
		{
			if (this.m_DepthCamera)
			{
				if (this.m_DepthCamera.targetTexture)
				{
					this.m_DepthCamera.targetTexture.Release();
					Object.DestroyImmediate(this.m_DepthCamera.targetTexture);
					this.m_DepthCamera.targetTexture = null;
				}
				Object.DestroyImmediate(this.m_DepthCamera.gameObject);
				this.m_DepthCamera = null;
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x000184B3 File Offset: 0x000166B3
		private void OnValidateProperties()
		{
			this.m_WaitXFrames = Mathf.Clamp(this.m_WaitXFrames, 1, 60);
			this.m_DepthMapResolution = Mathf.Clamp(Mathf.NextPowerOfTwo(this.m_DepthMapResolution), 8, 2048);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x000184E5 File Offset: 0x000166E5
		private void SetDirty()
		{
			if (this.m_Master)
			{
				this.m_Master.SetPropertyDirty(DirtyProps.ShadowProps);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00018504 File Offset: 0x00016704
		public int _INTERNAL_LastFrameRendered
		{
			get
			{
				return this.m_LastFrameRendered;
			}
		}

		// Token: 0x0400061E RID: 1566
		public const string ClassName = "VolumetricShadowHD";

		// Token: 0x0400061F RID: 1567
		[SerializeField]
		private float m_Strength = 1f;

		// Token: 0x04000620 RID: 1568
		[SerializeField]
		private ShadowUpdateRate m_UpdateRate = ShadowUpdateRate.EveryXFrames;

		// Token: 0x04000621 RID: 1569
		[SerializeField]
		private int m_WaitXFrames = 3;

		// Token: 0x04000622 RID: 1570
		[SerializeField]
		private LayerMask m_LayerMask = Consts.Shadow.LayerMaskDefault;

		// Token: 0x04000623 RID: 1571
		[SerializeField]
		private bool m_UseOcclusionCulling = true;

		// Token: 0x04000624 RID: 1572
		[SerializeField]
		private int m_DepthMapResolution = 128;

		// Token: 0x04000625 RID: 1573
		private VolumetricLightBeamHD m_Master;

		// Token: 0x04000626 RID: 1574
		private TransformUtils.Packed m_TransformPacked;

		// Token: 0x04000627 RID: 1575
		private int m_LastFrameRendered = int.MinValue;

		// Token: 0x04000628 RID: 1576
		private Camera m_DepthCamera;

		// Token: 0x04000629 RID: 1577
		private bool m_NeedToUpdateOcclusionNextFrame;

		// Token: 0x0400062A RID: 1578
		public static bool _INTERNAL_ApplyRandomFrameOffset = true;

		// Token: 0x02000116 RID: 278
		private enum ProcessOcclusionSource
		{
			// Token: 0x0400062C RID: 1580
			RenderLoop,
			// Token: 0x0400062D RID: 1581
			OnEnable,
			// Token: 0x0400062E RID: 1582
			EditorUpdate,
			// Token: 0x0400062F RID: 1583
			User
		}
	}
}
