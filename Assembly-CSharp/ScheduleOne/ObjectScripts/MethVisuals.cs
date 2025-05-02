using System;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BB2 RID: 2994
	public class MethVisuals : MonoBehaviour
	{
		// Token: 0x060050DA RID: 20698 RVA: 0x00154BB4 File Offset: 0x00152DB4
		public void Setup(MethDefinition definition)
		{
			MeshRenderer[] meshes = this.Meshes;
			for (int i = 0; i < meshes.Length; i++)
			{
				meshes[i].material = definition.CrystalMaterial;
			}
		}

		// Token: 0x04003CD3 RID: 15571
		public MeshRenderer[] Meshes;
	}
}
