using System;

namespace VLB
{
	// Token: 0x02000148 RID: 328
	public static class ShaderKeywords
	{
		// Token: 0x04000708 RID: 1800
		public const string AlphaAsBlack = "VLB_ALPHA_AS_BLACK";

		// Token: 0x04000709 RID: 1801
		public const string ColorGradientMatrixLow = "VLB_COLOR_GRADIENT_MATRIX_LOW";

		// Token: 0x0400070A RID: 1802
		public const string ColorGradientMatrixHigh = "VLB_COLOR_GRADIENT_MATRIX_HIGH";

		// Token: 0x0400070B RID: 1803
		public const string Noise3D = "VLB_NOISE_3D";

		// Token: 0x02000149 RID: 329
		public static class SD
		{
			// Token: 0x0400070C RID: 1804
			public const string DepthBlend = "VLB_DEPTH_BLEND";

			// Token: 0x0400070D RID: 1805
			public const string OcclusionClippingPlane = "VLB_OCCLUSION_CLIPPING_PLANE";

			// Token: 0x0400070E RID: 1806
			public const string OcclusionDepthTexture = "VLB_OCCLUSION_DEPTH_TEXTURE";

			// Token: 0x0400070F RID: 1807
			public const string MeshSkewing = "VLB_MESH_SKEWING";

			// Token: 0x04000710 RID: 1808
			public const string ShaderAccuracyHigh = "VLB_SHADER_ACCURACY_HIGH";
		}

		// Token: 0x0200014A RID: 330
		public static class HD
		{
			// Token: 0x06000645 RID: 1605 RVA: 0x0001C7C6 File Offset: 0x0001A9C6
			public static string GetRaymarchingQuality(int id)
			{
				return "VLB_RAYMARCHING_QUALITY_" + id.ToString();
			}

			// Token: 0x04000711 RID: 1809
			public const string AttenuationLinear = "VLB_ATTENUATION_LINEAR";

			// Token: 0x04000712 RID: 1810
			public const string AttenuationQuad = "VLB_ATTENUATION_QUAD";

			// Token: 0x04000713 RID: 1811
			public const string Shadow = "VLB_SHADOW";

			// Token: 0x04000714 RID: 1812
			public const string CookieSingleChannel = "VLB_COOKIE_1CHANNEL";

			// Token: 0x04000715 RID: 1813
			public const string CookieRGBA = "VLB_COOKIE_RGBA";

			// Token: 0x04000716 RID: 1814
			public const string RaymarchingStepCount = "VLB_RAYMARCHING_STEP_COUNT";
		}
	}
}
