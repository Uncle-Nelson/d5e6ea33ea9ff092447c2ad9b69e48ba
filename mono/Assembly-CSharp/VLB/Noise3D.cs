using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000134 RID: 308
	public static class Noise3D
	{
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00019636 File Offset: 0x00017836
		public static bool isSupported
		{
			get
			{
				if (!Noise3D.ms_IsSupportedChecked)
				{
					Noise3D.ms_IsSupported = (SystemInfo.graphicsShaderLevel >= 35);
					if (!Noise3D.ms_IsSupported)
					{
						Debug.LogWarning(Noise3D.isNotSupportedString);
					}
					Noise3D.ms_IsSupportedChecked = true;
				}
				return Noise3D.ms_IsSupported;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0001966C File Offset: 0x0001786C
		public static bool isProperlyLoaded
		{
			get
			{
				return Noise3D.ms_NoiseTexture != null;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00019679 File Offset: 0x00017879
		public static string isNotSupportedString
		{
			get
			{
				return string.Format("3D Noise requires higher shader capabilities (Shader Model 3.5 / OpenGL ES 3.0), which are not available on the current platform: graphicsShaderLevel (current/required) = {0} / {1}", SystemInfo.graphicsShaderLevel, 35);
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00019696 File Offset: 0x00017896
		[RuntimeInitializeOnLoadMethod]
		private static void OnStartUp()
		{
			Noise3D.LoadIfNeeded();
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x000196A0 File Offset: 0x000178A0
		public static void LoadIfNeeded()
		{
			if (!Noise3D.isSupported)
			{
				return;
			}
			if (Noise3D.ms_NoiseTexture == null)
			{
				Noise3D.ms_NoiseTexture = Config.Instance.noiseTexture3D;
				Shader.SetGlobalTexture(ShaderProperties.GlobalNoiseTex3D, Noise3D.ms_NoiseTexture);
				Shader.SetGlobalFloat(ShaderProperties.GlobalNoiseCustomTime, -1f);
			}
		}

		// Token: 0x04000688 RID: 1672
		private static bool ms_IsSupportedChecked;

		// Token: 0x04000689 RID: 1673
		private static bool ms_IsSupported;

		// Token: 0x0400068A RID: 1674
		private static Texture3D ms_NoiseTexture;

		// Token: 0x0400068B RID: 1675
		private const int kMinShaderLevel = 35;
	}
}
