using System;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BB1 RID: 2993
	public class CocaineVisuals : MonoBehaviour
	{
		// Token: 0x060050D8 RID: 20696 RVA: 0x00154B84 File Offset: 0x00152D84
		public void Setup(CocaineDefinition definition)
		{
			MeshRenderer[] meshes = this.Meshes;
			for (int i = 0; i < meshes.Length; i++)
			{
				meshes[i].material = definition.RockMaterial;
			}
		}

		// Token: 0x04003CD2 RID: 15570
		public MeshRenderer[] Meshes;
	}
}
