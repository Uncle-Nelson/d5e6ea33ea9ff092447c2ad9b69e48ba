using System;
using System.Collections.Generic;
using UnityEngine;

namespace Ardenfall.Utilities
{
	// Token: 0x0200022C RID: 556
	[Serializable]
	public class MaterialOverrides
	{
		// Token: 0x06000BCB RID: 3019 RVA: 0x00036F48 File Offset: 0x00035148
		public void OverrideMaterial(Material material)
		{
			foreach (MaterialOverrides.TextureProperty textureProperty in this.textureOverrides)
			{
				material.SetTexture(textureProperty.propertyName, textureProperty.propertyValue);
			}
			foreach (MaterialOverrides.FloatProperty floatProperty in this.floatOverrides)
			{
				material.SetFloat(floatProperty.propertyName, floatProperty.propertyValue);
			}
			foreach (MaterialOverrides.IntProperty intProperty in this.intOverrides)
			{
				material.SetInt(intProperty.propertyName, intProperty.propertyValue);
			}
			foreach (MaterialOverrides.VectorProperty vectorProperty in this.vectorOverrides)
			{
				material.SetVector(vectorProperty.propertyName, vectorProperty.propertyValue);
			}
			foreach (MaterialOverrides.ColorProperty colorProperty in this.colorOverrides)
			{
				material.SetColor(colorProperty.propertyName, colorProperty.propertyValue);
			}
		}

		// Token: 0x04000D41 RID: 3393
		public List<MaterialOverrides.TextureProperty> textureOverrides;

		// Token: 0x04000D42 RID: 3394
		public List<MaterialOverrides.FloatProperty> floatOverrides;

		// Token: 0x04000D43 RID: 3395
		public List<MaterialOverrides.IntProperty> intOverrides;

		// Token: 0x04000D44 RID: 3396
		public List<MaterialOverrides.VectorProperty> vectorOverrides;

		// Token: 0x04000D45 RID: 3397
		public List<MaterialOverrides.ColorProperty> colorOverrides;

		// Token: 0x0200022D RID: 557
		[Serializable]
		public class TextureProperty
		{
			// Token: 0x04000D46 RID: 3398
			public string propertyName;

			// Token: 0x04000D47 RID: 3399
			public Texture2D propertyValue;
		}

		// Token: 0x0200022E RID: 558
		[Serializable]
		public class FloatProperty
		{
			// Token: 0x04000D48 RID: 3400
			public string propertyName;

			// Token: 0x04000D49 RID: 3401
			public float propertyValue;
		}

		// Token: 0x0200022F RID: 559
		[Serializable]
		public class IntProperty
		{
			// Token: 0x04000D4A RID: 3402
			public string propertyName;

			// Token: 0x04000D4B RID: 3403
			public int propertyValue;
		}

		// Token: 0x02000230 RID: 560
		[Serializable]
		public class VectorProperty
		{
			// Token: 0x04000D4C RID: 3404
			public string propertyName;

			// Token: 0x04000D4D RID: 3405
			public Vector4 propertyValue;
		}

		// Token: 0x02000231 RID: 561
		[Serializable]
		public class ColorProperty
		{
			// Token: 0x04000D4E RID: 3406
			public string propertyName;

			// Token: 0x04000D4F RID: 3407
			public Color propertyValue;
		}
	}
}
