using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x0200013C RID: 316
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-sd-depthbuffer/")]
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		// Token: 0x0600058F RID: 1423 RVA: 0x0001AA2D File Offset: 0x00018C2D
		protected override string GetShaderKeyword()
		{
			return "VLB_OCCLUSION_DEPTH_TEXTURE";
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0001AA34 File Offset: 0x00018C34
		protected override MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return MaterialManager.SD.DynamicOcclusion.DepthTexture;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0001AA37 File Offset: 0x00018C37
		private void ProcessOcclusionInternal()
		{
			this.UpdateDepthCameraPropertiesAccordingToBeam();
			this.m_DepthCamera.Render();
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0001AA4A File Offset: 0x00018C4A
		protected override bool OnProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			if (SRPHelper.IsUsingCustomRenderPipeline())
			{
				this.m_NeedToUpdateOcclusionNextFrame = true;
			}
			else
			{
				this.ProcessOcclusionInternal();
			}
			return true;
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0001AA63 File Offset: 0x00018C63
		private void Update()
		{
			if (this.m_NeedToUpdateOcclusionNextFrame && this.m_Master && this.m_DepthCamera && Time.frameCount > 1)
			{
				this.ProcessOcclusionInternal();
				this.m_NeedToUpdateOcclusionNextFrame = false;
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0001AA9C File Offset: 0x00018C9C
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
			Utils.SetupDepthCamera(this.m_DepthCamera, this.m_Master.coneApexOffsetZ, this.m_Master.maxGeometryDistance, this.m_Master.coneRadiusStart, this.m_Master.coneRadiusEnd, this.m_Master.beamLocalForward, this.m_Master.GetLossyScale(), this.m_Master.IsScalable(), this.m_Master.beamInternalLocalRotation, true);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0001AB10 File Offset: 0x00018D10
		public bool HasLayerMaskIssues()
		{
			if (Config.Instance.geometryOverrideLayer)
			{
				int num = 1 << Config.Instance.geometryLayerID;
				return (this.layerMask.value & num) == num;
			}
			return false;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0001AB4B File Offset: 0x00018D4B
		protected override void OnValidateProperties()
		{
			base.OnValidateProperties();
			this.depthMapResolution = Mathf.Clamp(Mathf.NextPowerOfTwo(this.depthMapResolution), 8, 2048);
			this.fadeDistanceToSurface = Mathf.Max(this.fadeDistanceToSurface, 0f);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0001AB88 File Offset: 0x00018D88
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
				this.m_DepthCamera.cullingMask = this.layerMask;
				this.m_DepthCamera.clearFlags = CameraClearFlags.Depth;
				this.m_DepthCamera.depthTextureMode = DepthTextureMode.Depth;
				this.m_DepthCamera.renderingPath = RenderingPath.VertexLit;
				this.m_DepthCamera.useOcclusionCulling = this.useOcclusionCulling;
				this.m_DepthCamera.gameObject.hideFlags = Consts.Internal.ProceduralObjectsHideFlags;
				this.m_DepthCamera.transform.SetParent(base.transform, false);
				Config.Instance.SetURPScriptableRendererIndexToDepthCamera(this.m_DepthCamera);
				RenderTexture targetTexture = new RenderTexture(this.depthMapResolution, this.depthMapResolution, 16, RenderTextureFormat.Depth);
				this.m_DepthCamera.targetTexture = targetTexture;
				this.UpdateDepthCameraPropertiesAccordingToBeam();
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0001ACCA File Offset: 0x00018ECA
		protected override void OnEnablePostValidate()
		{
			this.InstantiateOrActivateDepthCamera();
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0001ACD2 File Offset: 0x00018ED2
		protected override void OnDisable()
		{
			base.OnDisable();
			if (this.m_DepthCamera)
			{
				this.m_DepthCamera.gameObject.SetActive(false);
			}
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0001ACF8 File Offset: 0x00018EF8
		protected override void Awake()
		{
			base.Awake();
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0001AD00 File Offset: 0x00018F00
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.DestroyDepthCamera();
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0001AD10 File Offset: 0x00018F10
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

		// Token: 0x0600059D RID: 1437 RVA: 0x0001AD80 File Offset: 0x00018F80
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
			owner.SetMaterialProp(ShaderProperties.SD.DynamicOcclusionDepthTexture, this.m_DepthCamera.targetTexture);
			Vector3 lossyScale = this.m_Master.GetLossyScale();
			owner.SetMaterialProp(ShaderProperties.SD.DynamicOcclusionDepthProps, new Vector4(Mathf.Sign(lossyScale.x) * Mathf.Sign(lossyScale.z), Mathf.Sign(lossyScale.y), this.fadeDistanceToSurface, this.m_DepthCamera.orthographic ? 0f : 1f));
		}

		// Token: 0x040006A4 RID: 1700
		public new const string ClassName = "DynamicOcclusionDepthBuffer";

		// Token: 0x040006A5 RID: 1701
		public LayerMask layerMask = Consts.DynOcclusion.LayerMaskDefault;

		// Token: 0x040006A6 RID: 1702
		public bool useOcclusionCulling = true;

		// Token: 0x040006A7 RID: 1703
		public int depthMapResolution = 128;

		// Token: 0x040006A8 RID: 1704
		public float fadeDistanceToSurface;

		// Token: 0x040006A9 RID: 1705
		private Camera m_DepthCamera;

		// Token: 0x040006AA RID: 1706
		private bool m_NeedToUpdateOcclusionNextFrame;
	}
}
