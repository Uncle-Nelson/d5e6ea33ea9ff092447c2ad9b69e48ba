using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Token: 0x0200003F RID: 63
public static class SmartCombineUtilities
{
	// Token: 0x06000146 RID: 326 RVA: 0x000074F8 File Offset: 0x000056F8
	public static void CombineMeshesSmart(this Mesh mesh, SmartMeshData[] meshData, out Material[] materials)
	{
		IDictionary<Material, SmartCombineUtilities.SmartSubmeshData> dictionary = new Dictionary<Material, SmartCombineUtilities.SmartSubmeshData>();
		IList<CombineInstance> list = new List<CombineInstance>();
		foreach (SmartMeshData smartMeshData in meshData)
		{
			IList<Material> materials2 = smartMeshData.materials;
			for (int j = 0; j < smartMeshData.mesh.subMeshCount; j++)
			{
				SmartCombineUtilities.SmartSubmeshData smartSubmeshData;
				if (dictionary.ContainsKey(materials2[j]))
				{
					smartSubmeshData = dictionary[materials2[j]];
				}
				else
				{
					smartSubmeshData = new SmartCombineUtilities.SmartSubmeshData();
					dictionary.Add(materials2[j], smartSubmeshData);
				}
				CombineInstance item = default(CombineInstance);
				item.mesh = smartMeshData.mesh;
				item.subMeshIndex = j;
				item.transform = smartMeshData.transform;
				smartSubmeshData.combineInstances.Add(item);
			}
		}
		foreach (SmartCombineUtilities.SmartSubmeshData smartSubmeshData2 in dictionary.Values)
		{
			smartSubmeshData2.CombineSubmeshes();
			list.Add(new CombineInstance
			{
				mesh = smartSubmeshData2.mesh,
				subMeshIndex = 0
			});
		}
		mesh.Clear();
		mesh.CombineMeshes(list.ToArray<CombineInstance>(), false, false);
		mesh.Optimize();
		materials = dictionary.Keys.ToArray<Material>();
	}

	// Token: 0x02000040 RID: 64
	private class SmartSubmeshData
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00007664 File Offset: 0x00005864
		// (set) Token: 0x06000148 RID: 328 RVA: 0x0000766C File Offset: 0x0000586C
		public Mesh mesh { get; private set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00007675 File Offset: 0x00005875
		// (set) Token: 0x0600014A RID: 330 RVA: 0x0000767D File Offset: 0x0000587D
		public IList<CombineInstance> combineInstances { get; private set; }

		// Token: 0x0600014B RID: 331 RVA: 0x00007686 File Offset: 0x00005886
		public SmartSubmeshData()
		{
			this.combineInstances = new List<CombineInstance>();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00007699 File Offset: 0x00005899
		public void CombineSubmeshes()
		{
			if (this.mesh == null)
			{
				this.mesh = new Mesh();
			}
			else
			{
				this.mesh.Clear();
			}
			this.mesh.CombineMeshes(this.combineInstances.ToArray<CombineInstance>(), true, true);
		}
	}
}
