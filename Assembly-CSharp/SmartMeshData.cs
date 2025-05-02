using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

// Token: 0x0200003E RID: 62
public class SmartMeshData
{
	// Token: 0x17000019 RID: 25
	// (get) Token: 0x0600013C RID: 316 RVA: 0x000073E2 File Offset: 0x000055E2
	// (set) Token: 0x0600013D RID: 317 RVA: 0x000073EA File Offset: 0x000055EA
	public Mesh mesh { get; private set; }

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x0600013E RID: 318 RVA: 0x000073F3 File Offset: 0x000055F3
	// (set) Token: 0x0600013F RID: 319 RVA: 0x000073FB File Offset: 0x000055FB
	public Matrix4x4 transform { get; private set; }

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000140 RID: 320 RVA: 0x00007404 File Offset: 0x00005604
	public IList<Material> materials
	{
		get
		{
			return new ReadOnlyCollection<Material>(this._materials);
		}
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00007414 File Offset: 0x00005614
	public SmartMeshData(Mesh inMesh, Material[] inMaterials, Matrix4x4 inTransform)
	{
		this.mesh = inMesh;
		this._materials = inMaterials;
		this.transform = inTransform;
		if (this._materials.Length != this.mesh.subMeshCount)
		{
			Debug.LogWarning("SmartMeshData has incorrect number of materials. Resizing to match submesh count");
			Material[] array = new Material[this.mesh.subMeshCount];
			for (int i = 0; i < this._materials.Length; i++)
			{
				if (i < this._materials.Length)
				{
					array[i] = this._materials[i];
				}
				else
				{
					array[i] = null;
				}
			}
			this._materials = array;
		}
	}

	// Token: 0x06000142 RID: 322 RVA: 0x000074A2 File Offset: 0x000056A2
	public SmartMeshData(Mesh inputMesh, Material[] inputMaterials) : this(inputMesh, inputMaterials, Matrix4x4.identity)
	{
	}

	// Token: 0x06000143 RID: 323 RVA: 0x000074B1 File Offset: 0x000056B1
	public SmartMeshData(Mesh inputMesh, Material[] inputMaterials, Vector3 position) : this(inputMesh, inputMaterials, Matrix4x4.TRS(position, Quaternion.identity, Vector3.one))
	{
	}

	// Token: 0x06000144 RID: 324 RVA: 0x000074CB File Offset: 0x000056CB
	public SmartMeshData(Mesh inputMesh, Material[] inputMaterials, Vector3 position, Quaternion rotation) : this(inputMesh, inputMaterials, Matrix4x4.TRS(position, rotation, Vector3.one))
	{
	}

	// Token: 0x06000145 RID: 325 RVA: 0x000074E2 File Offset: 0x000056E2
	public SmartMeshData(Mesh inputMesh, Material[] inputMaterials, Vector3 position, Quaternion rotation, Vector3 scale) : this(inputMesh, inputMaterials, Matrix4x4.TRS(position, rotation, scale))
	{
	}

	// Token: 0x0400011D RID: 285
	private Material[] _materials;
}
