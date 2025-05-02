using System;
using System.Collections.Generic;
using UnityEngine;

namespace Ardenfall.Utilities
{
	// Token: 0x02000228 RID: 552
	[CreateAssetMenu(menuName = "Ardenfall/Foliage/Billboard Asset")]
	public class BillboardAsset : ScriptableObject
	{
		// Token: 0x04000D2B RID: 3371
		public GameObject prefab;

		// Token: 0x04000D2C RID: 3372
		public BillboardRenderSettings renderSettings;

		// Token: 0x04000D2D RID: 3373
		[Header("Values")]
		public int textureSize = 512;

		// Token: 0x04000D2E RID: 3374
		public float cutoff = 0.15f;

		// Token: 0x04000D2F RID: 3375
		[Header("LODs")]
		public bool pickLastLOD = true;

		// Token: 0x04000D30 RID: 3376
		public int LODIndex;

		// Token: 0x04000D31 RID: 3377
		[HideInInspector]
		public List<Texture2D> generatedTextures;

		// Token: 0x04000D32 RID: 3378
		[HideInInspector]
		public Mesh generatedMesh;

		// Token: 0x04000D33 RID: 3379
		[HideInInspector]
		public Material generatedMaterial;

		// Token: 0x04000D34 RID: 3380
		[HideInInspector]
		public GameObject generatedPrefab;
	}
}
