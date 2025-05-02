using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001E1 RID: 481
	[RequireComponent(typeof(Camera))]
	public class WeatherDepthCamera : MonoBehaviour
	{
		// Token: 0x06000AB0 RID: 2736 RVA: 0x0002F957 File Offset: 0x0002DB57
		private void Start()
		{
			this.m_DepthCamera = base.GetComponent<Camera>();
			this.m_DepthCamera.enabled = false;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0002F971 File Offset: 0x0002DB71
		private void Update()
		{
			if (this.m_DepthCamera.enabled)
			{
				this.m_DepthCamera.enabled = false;
			}
			if (Time.frameCount % this.renderFrameInterval != 0)
			{
				return;
			}
			this.RenderOverheadCamera();
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0002F9A4 File Offset: 0x0002DBA4
		private void RenderOverheadCamera()
		{
			this.PrepareRenderTexture();
			if (this.depthShader == null)
			{
				Debug.LogError("Can't render depth since depth shader is missing.");
				return;
			}
			RenderTexture active = RenderTexture.active;
			RenderTexture.active = this.overheadDepthTexture;
			GL.Clear(true, true, Color.black);
			this.m_DepthCamera.RenderWithShader(this.depthShader, "RenderType");
			RenderTexture.active = active;
			Shader.SetGlobalTexture("_OverheadDepthTex", this.overheadDepthTexture);
			Shader.SetGlobalVector("_OverheadDepthPosition", this.m_DepthCamera.transform.position);
			Shader.SetGlobalFloat("_OverheadDepthNearClip", this.m_DepthCamera.nearClipPlane);
			Shader.SetGlobalFloat("_OverheadDepthFarClip", this.m_DepthCamera.farClipPlane);
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0002FA60 File Offset: 0x0002DC60
		private void PrepareRenderTexture()
		{
			if (this.overheadDepthTexture == null)
			{
				int num = Mathf.ClosestPowerOfTwo(Mathf.FloorToInt((float)this.textureResolution));
				RenderTextureFormat format = RenderTextureFormat.ARGB32;
				this.overheadDepthTexture = new RenderTexture(num, num, 24, format, RenderTextureReadWrite.Linear);
				this.overheadDepthTexture.useMipMap = false;
				this.overheadDepthTexture.autoGenerateMips = false;
				this.overheadDepthTexture.filterMode = FilterMode.Point;
				this.overheadDepthTexture.antiAliasing = 2;
			}
			if (!this.overheadDepthTexture.IsCreated())
			{
				this.overheadDepthTexture.Create();
			}
			if (this.m_DepthCamera.targetTexture != this.overheadDepthTexture)
			{
				this.m_DepthCamera.targetTexture = this.overheadDepthTexture;
			}
		}

		// Token: 0x04000B9C RID: 2972
		private Camera m_DepthCamera;

		// Token: 0x04000B9D RID: 2973
		[Tooltip("Shader used to render out depth + normal texture. This should be the sky studio depth shader.")]
		public Shader depthShader;

		// Token: 0x04000B9E RID: 2974
		[HideInInspector]
		public RenderTexture overheadDepthTexture;

		// Token: 0x04000B9F RID: 2975
		[Tooltip("You can help increase performance by only rendering periodically some number of frames.")]
		[Range(1f, 60f)]
		public int renderFrameInterval = 5;

		// Token: 0x04000BA0 RID: 2976
		[Tooltip("The resolution of the texture. Higher resolution uses more rendering time but makes more precise weather along edges.")]
		[Range(128f, 8192f)]
		public int textureResolution = 1024;
	}
}
