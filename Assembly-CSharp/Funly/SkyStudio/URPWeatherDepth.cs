using System;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Funly.SkyStudio
{
	// Token: 0x020001E9 RID: 489
	[RequireComponent(typeof(Camera))]
	[RequireComponent(typeof(UniversalAdditionalCameraData))]
	public class URPWeatherDepth : MonoBehaviour
	{
		// Token: 0x06000AD3 RID: 2771 RVA: 0x0002FFC7 File Offset: 0x0002E1C7
		private void Start()
		{
			this.m_Camera = base.GetComponent<Camera>();
			this.m_CameraData = base.GetComponent<UniversalAdditionalCameraData>();
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0002FFE4 File Offset: 0x0002E1E4
		private void Update()
		{
			this.m_CameraData.SetRenderer(1);
			Shader.SetGlobalTexture("_OverheadDepthTex", this.renderTexture);
			Shader.SetGlobalVector("_OverheadDepthPosition", this.m_Camera.transform.position);
			Shader.SetGlobalFloat("_OverheadDepthNearClip", this.m_Camera.nearClipPlane);
			Shader.SetGlobalFloat("_OverheadDepthFarClip", this.m_Camera.farClipPlane);
		}

		// Token: 0x04000BBD RID: 3005
		public RenderTexture renderTexture;

		// Token: 0x04000BBE RID: 3006
		private Camera m_Camera;

		// Token: 0x04000BBF RID: 3007
		private UniversalAdditionalCameraData m_CameraData;
	}
}
