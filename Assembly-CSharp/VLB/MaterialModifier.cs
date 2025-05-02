using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x0200012B RID: 299
	public static class MaterialModifier
	{
		// Token: 0x0200012C RID: 300
		public interface Interface
		{
			// Token: 0x0600050C RID: 1292
			void SetMaterialProp(int nameID, float value);

			// Token: 0x0600050D RID: 1293
			void SetMaterialProp(int nameID, Vector4 value);

			// Token: 0x0600050E RID: 1294
			void SetMaterialProp(int nameID, Color value);

			// Token: 0x0600050F RID: 1295
			void SetMaterialProp(int nameID, Matrix4x4 value);

			// Token: 0x06000510 RID: 1296
			void SetMaterialProp(int nameID, Texture value);
		}

		// Token: 0x0200012D RID: 301
		// (Invoke) Token: 0x06000512 RID: 1298
		public delegate void Callback(MaterialModifier.Interface owner);
	}
}
