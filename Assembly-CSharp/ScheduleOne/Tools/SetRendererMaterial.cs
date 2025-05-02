using System;
using EasyButtons;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000875 RID: 2165
	public class SetRendererMaterial : MonoBehaviour
	{
		// Token: 0x06003AE1 RID: 15073 RVA: 0x000F7C58 File Offset: 0x000F5E58
		[Button]
		public void SetMaterial()
		{
			foreach (MeshRenderer meshRenderer in base.GetComponentsInChildren<MeshRenderer>())
			{
				Material[] sharedMaterials = meshRenderer.sharedMaterials;
				for (int j = 0; j < sharedMaterials.Length; j++)
				{
					sharedMaterials[j] = this.Material;
				}
				meshRenderer.sharedMaterials = sharedMaterials;
			}
		}

		// Token: 0x04002A5D RID: 10845
		public Material Material;
	}
}
