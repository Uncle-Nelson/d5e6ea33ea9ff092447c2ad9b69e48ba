using System;
using UnityEngine;

namespace Beautify.Universal
{
	// Token: 0x020001F0 RID: 496
	[ExecuteInEditMode]
	public class LUTBlending : MonoBehaviour
	{
		// Token: 0x06000AEF RID: 2799 RVA: 0x000303DB File Offset: 0x0002E5DB
		private void OnEnable()
		{
			this.UpdateBeautifyLUT();
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x000303E3 File Offset: 0x0002E5E3
		private void OnValidate()
		{
			this.oldPhase = -1f;
			this.UpdateBeautifyLUT();
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x000303F6 File Offset: 0x0002E5F6
		private void OnDestroy()
		{
			if (this.rt != null)
			{
				this.rt.Release();
			}
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x000303DB File Offset: 0x0002E5DB
		private void LateUpdate()
		{
			this.UpdateBeautifyLUT();
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00030414 File Offset: 0x0002E614
		private void UpdateBeautifyLUT()
		{
			if (this.oldPhase == this.phase || this.LUT1 == null || this.LUT2 == null || this.lerpShader == null)
			{
				return;
			}
			this.oldPhase = this.phase;
			if (this.rt == null)
			{
				this.rt = new RenderTexture(this.LUT1.width, this.LUT1.height, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
				this.rt.filterMode = FilterMode.Point;
			}
			if (this.lerpMat == null)
			{
				this.lerpMat = new Material(this.lerpShader);
			}
			this.lerpMat.SetTexture(LUTBlending.ShaderParams.LUT2, this.LUT2);
			this.lerpMat.SetFloat(LUTBlending.ShaderParams.Phase, this.phase);
			Graphics.Blit(this.LUT1, this.rt, this.lerpMat);
			BeautifySettings.settings.lut.Override(true);
			float num = Mathf.Lerp(this.LUT1Intensity, this.LUT2Intensity, this.phase);
			BeautifySettings.settings.lutIntensity.Override(num);
			BeautifySettings.settings.lutTexture.Override(this.rt);
		}

		// Token: 0x04000BC1 RID: 3009
		public Texture2D LUT1;

		// Token: 0x04000BC2 RID: 3010
		public Texture2D LUT2;

		// Token: 0x04000BC3 RID: 3011
		[Range(0f, 1f)]
		public float LUT1Intensity = 1f;

		// Token: 0x04000BC4 RID: 3012
		[Range(0f, 1f)]
		public float LUT2Intensity = 1f;

		// Token: 0x04000BC5 RID: 3013
		[Range(0f, 1f)]
		public float phase;

		// Token: 0x04000BC6 RID: 3014
		public Shader lerpShader;

		// Token: 0x04000BC7 RID: 3015
		private float oldPhase = -1f;

		// Token: 0x04000BC8 RID: 3016
		private RenderTexture rt;

		// Token: 0x04000BC9 RID: 3017
		private Material lerpMat;

		// Token: 0x020001F1 RID: 497
		private static class ShaderParams
		{
			// Token: 0x04000BCA RID: 3018
			public static int LUT2 = Shader.PropertyToID("_LUT2");

			// Token: 0x04000BCB RID: 3019
			public static int Phase = Shader.PropertyToID("_Phase");
		}
	}
}
