using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200007C RID: 124
	public sealed class DitheringComponent : PostProcessingComponentRenderTexture<DitheringModel>
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000F8EE File Offset: 0x0000DAEE
		public override bool active
		{
			get
			{
				return base.model.enabled && !this.context.interrupted;
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000F90D File Offset: 0x0000DB0D
		public override void OnDisable()
		{
			this.noiseTextures = null;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000F918 File Offset: 0x0000DB18
		private void LoadNoiseTextures()
		{
			this.noiseTextures = new Texture2D[64];
			for (int i = 0; i < 64; i++)
			{
				this.noiseTextures[i] = Resources.Load<Texture2D>("Bluenoise64/LDR_LLL1_" + i.ToString());
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000F960 File Offset: 0x0000DB60
		public override void Prepare(Material uberMaterial)
		{
			int num = this.textureIndex + 1;
			this.textureIndex = num;
			if (num >= 64)
			{
				this.textureIndex = 0;
			}
			float value = Random.value;
			float value2 = Random.value;
			if (this.noiseTextures == null)
			{
				this.LoadNoiseTextures();
			}
			Texture2D texture2D = this.noiseTextures[this.textureIndex];
			uberMaterial.EnableKeyword("DITHERING");
			uberMaterial.SetTexture(DitheringComponent.Uniforms._DitheringTex, texture2D);
			uberMaterial.SetVector(DitheringComponent.Uniforms._DitheringCoords, new Vector4((float)this.context.width / (float)texture2D.width, (float)this.context.height / (float)texture2D.height, value, value2));
		}

		// Token: 0x040002DA RID: 730
		private Texture2D[] noiseTextures;

		// Token: 0x040002DB RID: 731
		private int textureIndex;

		// Token: 0x040002DC RID: 732
		private const int k_TextureCount = 64;

		// Token: 0x0200007D RID: 125
		private static class Uniforms
		{
			// Token: 0x040002DD RID: 733
			internal static readonly int _DitheringTex = Shader.PropertyToID("_DitheringTex");

			// Token: 0x040002DE RID: 734
			internal static readonly int _DitheringCoords = Shader.PropertyToID("_DitheringCoords");
		}
	}
}
