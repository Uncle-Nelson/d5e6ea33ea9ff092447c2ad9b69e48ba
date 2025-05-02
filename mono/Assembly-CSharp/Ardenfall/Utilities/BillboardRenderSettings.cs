using System;
using System.Collections.Generic;
using UnityEngine;

namespace Ardenfall.Utilities
{
	// Token: 0x02000229 RID: 553
	[CreateAssetMenu(menuName = "Ardenfall/Foliage/Billboard Render Settings")]
	public class BillboardRenderSettings : ScriptableObject
	{
		// Token: 0x04000D35 RID: 3381
		public List<BillboardRenderSettings.BillboardTexture> billboardTextures;

		// Token: 0x04000D36 RID: 3382
		public Shader billboardShader;

		// Token: 0x0200022A RID: 554
		[Serializable]
		public class BillboardTexture
		{
			// Token: 0x06000BC8 RID: 3016 RVA: 0x00036DE0 File Offset: 0x00034FE0
			public TextureFormat GetFormat()
			{
				Vector4 vector = default(Vector4);
				foreach (BillboardRenderSettings.BakePass bakePass in this.bakePasses)
				{
					if (bakePass.r)
					{
						vector.x += 1f;
					}
					if (bakePass.g)
					{
						vector.y += 1f;
					}
					if (bakePass.b)
					{
						vector.z += 1f;
					}
					if (bakePass.a)
					{
						vector.w += 1f;
					}
				}
				if (vector.x > 1f || vector.y > 1f || vector.z > 1f || vector.w > 1f)
				{
					Debug.LogError("Multiple bake passes in the same texture channel detected");
				}
				if (vector.w >= 1f)
				{
					return TextureFormat.RGBA32;
				}
				if (vector.z >= 1f)
				{
					return TextureFormat.RGB24;
				}
				if (vector.y >= 1f)
				{
					return TextureFormat.RG16;
				}
				return TextureFormat.R8;
			}

			// Token: 0x04000D37 RID: 3383
			public string textureId = "_MainTex";

			// Token: 0x04000D38 RID: 3384
			public bool powerOfTwo = true;

			// Token: 0x04000D39 RID: 3385
			public bool alphaIsTransparency = true;

			// Token: 0x04000D3A RID: 3386
			public List<BillboardRenderSettings.BakePass> bakePasses;
		}

		// Token: 0x0200022B RID: 555
		[Serializable]
		public class BakePass
		{
			// Token: 0x04000D3B RID: 3387
			public Shader customShader;

			// Token: 0x04000D3C RID: 3388
			public MaterialOverrides materialOverrides;

			// Token: 0x04000D3D RID: 3389
			public bool r = true;

			// Token: 0x04000D3E RID: 3390
			public bool g = true;

			// Token: 0x04000D3F RID: 3391
			public bool b = true;

			// Token: 0x04000D40 RID: 3392
			public bool a = true;
		}
	}
}
