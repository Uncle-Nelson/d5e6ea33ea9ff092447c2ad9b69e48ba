using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000035 RID: 53
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class MeshCombiner : MonoBehaviour
{
	// Token: 0x17000010 RID: 16
	// (get) Token: 0x0600010D RID: 269 RVA: 0x000067BD File Offset: 0x000049BD
	// (set) Token: 0x0600010E RID: 270 RVA: 0x000067C5 File Offset: 0x000049C5
	public bool CreateMultiMaterialMesh
	{
		get
		{
			return this.createMultiMaterialMesh;
		}
		set
		{
			this.createMultiMaterialMesh = value;
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x0600010F RID: 271 RVA: 0x000067CE File Offset: 0x000049CE
	// (set) Token: 0x06000110 RID: 272 RVA: 0x000067D6 File Offset: 0x000049D6
	public bool CombineInactiveChildren
	{
		get
		{
			return this.combineInactiveChildren;
		}
		set
		{
			this.combineInactiveChildren = value;
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000111 RID: 273 RVA: 0x000067DF File Offset: 0x000049DF
	// (set) Token: 0x06000112 RID: 274 RVA: 0x000067E7 File Offset: 0x000049E7
	public bool DeactivateCombinedChildren
	{
		get
		{
			return this.deactivateCombinedChildren;
		}
		set
		{
			this.deactivateCombinedChildren = value;
			this.CheckDeactivateCombinedChildren();
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000113 RID: 275 RVA: 0x000067F6 File Offset: 0x000049F6
	// (set) Token: 0x06000114 RID: 276 RVA: 0x000067FE File Offset: 0x000049FE
	public bool DeactivateCombinedChildrenMeshRenderers
	{
		get
		{
			return this.deactivateCombinedChildrenMeshRenderers;
		}
		set
		{
			this.deactivateCombinedChildrenMeshRenderers = value;
			this.CheckDeactivateCombinedChildren();
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000115 RID: 277 RVA: 0x0000680D File Offset: 0x00004A0D
	// (set) Token: 0x06000116 RID: 278 RVA: 0x00006815 File Offset: 0x00004A15
	public bool GenerateUVMap
	{
		get
		{
			return this.generateUVMap;
		}
		set
		{
			this.generateUVMap = value;
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000117 RID: 279 RVA: 0x0000681E File Offset: 0x00004A1E
	// (set) Token: 0x06000118 RID: 280 RVA: 0x00006826 File Offset: 0x00004A26
	public bool DestroyCombinedChildren
	{
		get
		{
			return this.destroyCombinedChildren;
		}
		set
		{
			this.destroyCombinedChildren = value;
			this.CheckDestroyCombinedChildren();
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000119 RID: 281 RVA: 0x00006835 File Offset: 0x00004A35
	// (set) Token: 0x0600011A RID: 282 RVA: 0x0000683D File Offset: 0x00004A3D
	public string FolderPath
	{
		get
		{
			return this.folderPath;
		}
		set
		{
			this.folderPath = value;
		}
	}

	// Token: 0x0600011B RID: 283 RVA: 0x00006846 File Offset: 0x00004A46
	private void CheckDeactivateCombinedChildren()
	{
		if (this.deactivateCombinedChildren || this.deactivateCombinedChildrenMeshRenderers)
		{
			this.destroyCombinedChildren = false;
		}
	}

	// Token: 0x0600011C RID: 284 RVA: 0x0000685F File Offset: 0x00004A5F
	private void CheckDestroyCombinedChildren()
	{
		if (this.destroyCombinedChildren)
		{
			this.deactivateCombinedChildren = false;
			this.deactivateCombinedChildrenMeshRenderers = false;
		}
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00006878 File Offset: 0x00004A78
	public void CombineMeshes(bool showCreatedMeshInfo)
	{
		Vector3 localScale = base.transform.localScale;
		int siblingIndex = base.transform.GetSiblingIndex();
		Transform parent = base.transform.parent;
		base.transform.parent = null;
		Quaternion rotation = base.transform.rotation;
		Vector3 position = base.transform.position;
		Vector3 localScale2 = base.transform.localScale;
		base.transform.rotation = Quaternion.identity;
		base.transform.position = Vector3.zero;
		base.transform.localScale = Vector3.one;
		if (!this.createMultiMaterialMesh)
		{
			this.CombineMeshesWithSingleMaterial(showCreatedMeshInfo);
		}
		else
		{
			this.CombineMeshesWithMutliMaterial(showCreatedMeshInfo);
		}
		base.transform.rotation = rotation;
		base.transform.position = position;
		base.transform.localScale = localScale2;
		base.transform.parent = parent;
		base.transform.SetSiblingIndex(siblingIndex);
		base.transform.localScale = localScale;
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00006970 File Offset: 0x00004B70
	private MeshFilter[] GetMeshFiltersToCombine()
	{
		MeshCombiner.<>c__DisplayClass33_0 CS$<>8__locals1 = new MeshCombiner.<>c__DisplayClass33_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.meshFilters = base.GetComponentsInChildren<MeshFilter>(this.combineInactiveChildren);
		this.meshFiltersToSkip = (from meshFilter in this.meshFiltersToSkip
		where meshFilter != CS$<>8__locals1.meshFilters[0]
		select meshFilter).ToArray<MeshFilter>();
		this.meshFiltersToSkip = (from meshFilter in this.meshFiltersToSkip
		where meshFilter != null
		select meshFilter).ToArray<MeshFilter>();
		int i;
		int j;
		for (i = 0; i < this.meshFiltersToSkip.Length; i = j + 1)
		{
			CS$<>8__locals1.meshFilters = (from meshFilter in CS$<>8__locals1.meshFilters
			where meshFilter != CS$<>8__locals1.<>4__this.meshFiltersToSkip[i]
			select meshFilter).ToArray<MeshFilter>();
			j = i;
		}
		return CS$<>8__locals1.meshFilters;
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00006A5C File Offset: 0x00004C5C
	private void CombineMeshesWithSingleMaterial(bool showCreatedMeshInfo)
	{
		MeshFilter[] meshFiltersToCombine = this.GetMeshFiltersToCombine();
		CombineInstance[] array = new CombineInstance[meshFiltersToCombine.Length - 1];
		long num = 0L;
		for (int i = 0; i < meshFiltersToCombine.Length - 1; i++)
		{
			array[i].subMeshIndex = 0;
			array[i].mesh = meshFiltersToCombine[i + 1].sharedMesh;
			array[i].transform = meshFiltersToCombine[i + 1].transform.localToWorldMatrix;
			num += (long)array[i].mesh.vertices.Length;
		}
		MeshRenderer[] componentsInChildren = base.GetComponentsInChildren<MeshRenderer>(this.combineInactiveChildren);
		if (componentsInChildren.Length >= 2)
		{
			componentsInChildren[0].sharedMaterials = new Material[1];
			componentsInChildren[0].sharedMaterial = componentsInChildren[1].sharedMaterial;
		}
		else
		{
			componentsInChildren[0].sharedMaterials = new Material[0];
		}
		Mesh mesh = new Mesh();
		mesh.name = base.name;
		if (num > 65535L)
		{
			mesh.indexFormat = IndexFormat.UInt32;
		}
		mesh.CombineMeshes(array);
		this.GenerateUV(mesh);
		meshFiltersToCombine[0].sharedMesh = mesh;
		this.DeactivateCombinedGameObjects(meshFiltersToCombine);
		if (showCreatedMeshInfo)
		{
			if (num <= 65535L)
			{
				Debug.Log(string.Concat(new string[]
				{
					"<color=#00cc00><b>Mesh \"",
					base.name,
					"\" was created from ",
					array.Length.ToString(),
					" children meshes and has ",
					num.ToString(),
					" vertices.</b></color>"
				}));
				return;
			}
			Debug.Log(string.Concat(new string[]
			{
				"<color=#ff3300><b>Mesh \"",
				base.name,
				"\" was created from ",
				array.Length.ToString(),
				" children meshes and has ",
				num.ToString(),
				" vertices. Some old devices, like Android with Mali-400 GPU, do not support over 65535 vertices.</b></color>"
			}));
		}
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00006C28 File Offset: 0x00004E28
	private void CombineMeshesWithMutliMaterial(bool showCreatedMeshInfo)
	{
		MeshFilter[] meshFiltersToCombine = this.GetMeshFiltersToCombine();
		MeshRenderer[] array = new MeshRenderer[meshFiltersToCombine.Length];
		array[0] = base.GetComponent<MeshRenderer>();
		List<Material> list = new List<Material>();
		for (int i = 0; i < meshFiltersToCombine.Length - 1; i++)
		{
			array[i + 1] = meshFiltersToCombine[i + 1].GetComponent<MeshRenderer>();
			if (array[i + 1] != null)
			{
				Material[] sharedMaterials = array[i + 1].sharedMaterials;
				for (int j = 0; j < sharedMaterials.Length; j++)
				{
					if (!list.Contains(sharedMaterials[j]))
					{
						list.Add(sharedMaterials[j]);
					}
				}
			}
		}
		List<CombineInstance> list2 = new List<CombineInstance>();
		long num = 0L;
		for (int k = 0; k < list.Count; k++)
		{
			List<CombineInstance> list3 = new List<CombineInstance>();
			for (int l = 0; l < meshFiltersToCombine.Length - 1; l++)
			{
				if (array[l + 1] != null)
				{
					Material[] sharedMaterials2 = array[l + 1].sharedMaterials;
					for (int m = 0; m < sharedMaterials2.Length; m++)
					{
						if (list[k] == sharedMaterials2[m])
						{
							CombineInstance item = new CombineInstance
							{
								subMeshIndex = m,
								mesh = meshFiltersToCombine[l + 1].sharedMesh,
								transform = meshFiltersToCombine[l + 1].transform.localToWorldMatrix
							};
							list3.Add(item);
							num += (long)item.mesh.vertices.Length;
						}
					}
				}
			}
			Mesh mesh = new Mesh();
			if (num > 65535L)
			{
				mesh.indexFormat = IndexFormat.UInt32;
			}
			mesh.CombineMeshes(list3.ToArray(), true);
			list2.Add(new CombineInstance
			{
				subMeshIndex = 0,
				mesh = mesh,
				transform = Matrix4x4.identity
			});
		}
		array[0].sharedMaterials = list.ToArray();
		Mesh mesh2 = new Mesh();
		mesh2.name = base.name;
		if (num > 65535L)
		{
			mesh2.indexFormat = IndexFormat.UInt32;
		}
		mesh2.CombineMeshes(list2.ToArray(), false);
		this.GenerateUV(mesh2);
		meshFiltersToCombine[0].sharedMesh = mesh2;
		this.DeactivateCombinedGameObjects(meshFiltersToCombine);
		if (showCreatedMeshInfo)
		{
			if (num <= 65535L)
			{
				Debug.Log(string.Concat(new string[]
				{
					"<color=#00cc00><b>Mesh \"",
					base.name,
					"\" was created from ",
					(meshFiltersToCombine.Length - 1).ToString(),
					" children meshes and has ",
					list2.Count.ToString(),
					" submeshes, and ",
					num.ToString(),
					" vertices.</b></color>"
				}));
				return;
			}
			Debug.Log(string.Concat(new string[]
			{
				"<color=#ff3300><b>Mesh \"",
				base.name,
				"\" was created from ",
				(meshFiltersToCombine.Length - 1).ToString(),
				" children meshes and has ",
				list2.Count.ToString(),
				" submeshes, and ",
				num.ToString(),
				" vertices. Some old devices, like Android with Mali-400 GPU, do not support over 65535 vertices.</b></color>"
			}));
		}
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00006F40 File Offset: 0x00005140
	private void DeactivateCombinedGameObjects(MeshFilter[] meshFilters)
	{
		for (int i = 0; i < meshFilters.Length - 1; i++)
		{
			if (!this.destroyCombinedChildren)
			{
				if (this.deactivateCombinedChildren)
				{
					meshFilters[i + 1].gameObject.SetActive(false);
				}
				if (this.deactivateCombinedChildrenMeshRenderers)
				{
					MeshRenderer component = meshFilters[i + 1].gameObject.GetComponent<MeshRenderer>();
					if (component != null)
					{
						component.enabled = false;
					}
				}
			}
			else
			{
				Object.DestroyImmediate(meshFilters[i + 1].gameObject);
			}
		}
	}

	// Token: 0x06000122 RID: 290 RVA: 0x000045B1 File Offset: 0x000027B1
	private void GenerateUV(Mesh combinedMesh)
	{
	}

	// Token: 0x040000F9 RID: 249
	private const int Mesh16BitBufferVertexLimit = 65535;

	// Token: 0x040000FA RID: 250
	[SerializeField]
	private bool createMultiMaterialMesh = true;

	// Token: 0x040000FB RID: 251
	[SerializeField]
	private bool combineInactiveChildren;

	// Token: 0x040000FC RID: 252
	[SerializeField]
	private bool deactivateCombinedChildren;

	// Token: 0x040000FD RID: 253
	[SerializeField]
	private bool deactivateCombinedChildrenMeshRenderers;

	// Token: 0x040000FE RID: 254
	[SerializeField]
	private bool generateUVMap;

	// Token: 0x040000FF RID: 255
	[SerializeField]
	private bool destroyCombinedChildren = true;

	// Token: 0x04000100 RID: 256
	[SerializeField]
	private string folderPath = "Prefabs/CombinedMeshes";

	// Token: 0x04000101 RID: 257
	[SerializeField]
	[Tooltip("MeshFilters with Meshes which we don't want to combine into one Mesh.")]
	private MeshFilter[] meshFiltersToSkip = new MeshFilter[0];
}
