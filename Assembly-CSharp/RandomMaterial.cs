using System;
using UnityEngine;

// Token: 0x02000043 RID: 67
public class RandomMaterial : MonoBehaviour
{
	// Token: 0x06000155 RID: 341 RVA: 0x00007A4B File Offset: 0x00005C4B
	public void Start()
	{
		this.ChangeMaterial();
	}

	// Token: 0x06000156 RID: 342 RVA: 0x00007A53 File Offset: 0x00005C53
	public void ChangeMaterial()
	{
		this.targetRenderer.sharedMaterial = this.materials[Random.Range(0, this.materials.Length)];
	}

	// Token: 0x04000134 RID: 308
	public Renderer targetRenderer;

	// Token: 0x04000135 RID: 309
	public Material[] materials;
}
