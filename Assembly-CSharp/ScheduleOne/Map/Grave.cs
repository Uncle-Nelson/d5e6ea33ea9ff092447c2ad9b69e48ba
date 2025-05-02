using System;
using EasyButtons;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000C10 RID: 3088
	public class Grave : MonoBehaviour
	{
		// Token: 0x060056D0 RID: 22224 RVA: 0x0016D1D0 File Offset: 0x0016B3D0
		[Button]
		public void RandomizeGrave()
		{
			int num = Random.Range(0, this.Surfaces.Length);
			int num2 = Random.Range(0, this.HeadstoneObjects.Length);
			for (int i = 0; i < this.Surfaces.Length; i++)
			{
				this.Surfaces[i].Object.SetActive(i == num);
			}
			for (int j = 0; j < this.HeadstoneObjects.Length; j++)
			{
				this.HeadstoneObjects[j].SetActive(j == num2);
			}
			int num3 = Random.Range(0, this.Surfaces[num].Materials.Length);
			int num4 = Random.Range(0, this.HeadstoneMaterials.Length);
			this.Surfaces[num].Mesh.material = this.Surfaces[num].Materials[num3];
			for (int k = 0; k < this.HeadstoneMeshes.Length; k++)
			{
				this.HeadstoneMeshes[k].material = this.HeadstoneMaterials[num4];
			}
		}

		// Token: 0x0400402F RID: 16431
		[Header("References")]
		public Grave.GraveSuface[] Surfaces;

		// Token: 0x04004030 RID: 16432
		public GameObject[] HeadstoneObjects;

		// Token: 0x04004031 RID: 16433
		public MeshRenderer[] HeadstoneMeshes;

		// Token: 0x04004032 RID: 16434
		public Material[] HeadstoneMaterials;

		// Token: 0x02000C11 RID: 3089
		[Serializable]
		public class GraveSuface
		{
			// Token: 0x04004033 RID: 16435
			public GameObject Object;

			// Token: 0x04004034 RID: 16436
			public MeshRenderer Mesh;

			// Token: 0x04004035 RID: 16437
			public Material[] Materials;
		}
	}
}
