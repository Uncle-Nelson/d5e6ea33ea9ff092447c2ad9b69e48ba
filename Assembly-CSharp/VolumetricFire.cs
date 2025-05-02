using System;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000062 RID: 98
[ExecuteAlways]
public class VolumetricFire : MonoBehaviour
{
	// Token: 0x0600022B RID: 555 RVA: 0x0000CEBC File Offset: 0x0000B0BC
	private void Start()
	{
		this.materialPropertyBlock = new MaterialPropertyBlock();
		MeshRenderer component = base.GetComponent<MeshRenderer>();
		component.enabled = false;
		this.material = component.sharedMaterial;
		this.mesh = base.GetComponent<MeshFilter>().sharedMesh;
		this.boundaryCollider = base.GetComponent<Collider>();
		this.randomStatic = Random.Range(0f, 1f);
	}

	// Token: 0x0600022C RID: 556 RVA: 0x0000CF20 File Offset: 0x0000B120
	private void OnEnable()
	{
		RenderPipelineManager.beginCameraRendering += this.RenderFlames;
	}

	// Token: 0x0600022D RID: 557 RVA: 0x0000CF33 File Offset: 0x0000B133
	private void OnDisable()
	{
		RenderPipelineManager.beginCameraRendering -= this.RenderFlames;
	}

	// Token: 0x0600022E RID: 558 RVA: 0x0000CF46 File Offset: 0x0000B146
	private static bool IsVisible(Camera camera, Bounds bounds)
	{
		return GeometryUtility.TestPlanesAABB(GeometryUtility.CalculateFrustumPlanes(camera), bounds);
	}

	// Token: 0x0600022F RID: 559 RVA: 0x0000CF54 File Offset: 0x0000B154
	private void RenderFlames(ScriptableRenderContext context, Camera camera)
	{
		VolumetricFire.IsVisible(camera, this.boundaryCollider.bounds);
		this.internalCount = (this.thickness - 1) * 2;
		float spacing = 0f;
		if (this.internalCount > 0)
		{
			spacing = this.spread / (float)this.internalCount;
		}
		for (int i = 0; i <= this.internalCount; i++)
		{
			float item = (float)i - (float)this.internalCount * 0.5f;
			this.SetupMaterialPropertyBlock(item);
			this.CreateItem(spacing, item, camera);
		}
	}

	// Token: 0x06000230 RID: 560 RVA: 0x0000CFD4 File Offset: 0x0000B1D4
	private void SetupMaterialPropertyBlock(float item)
	{
		if (this.materialPropertyBlock == null)
		{
			return;
		}
		this.materialPropertyBlock.SetFloat("_ITEMNUMBER", item);
		this.materialPropertyBlock.SetFloat("_INTERNALCOUNT", (float)this.internalCount);
		this.materialPropertyBlock.SetFloat("_INITIALPOSITIONINT", this.randomStatic);
	}

	// Token: 0x06000231 RID: 561 RVA: 0x0000D028 File Offset: 0x0000B228
	private void CreateItem(float spacing, float item, Camera camera)
	{
		Quaternion quaternion = Quaternion.identity;
		Vector3 pos = Vector3.zero;
		if (this.billboard)
		{
			quaternion *= camera.transform.rotation;
			Vector3 normalized = (base.transform.position - camera.transform.position).normalized;
			pos = base.transform.position - normalized * item * spacing;
		}
		else
		{
			quaternion = base.transform.rotation;
			pos = base.transform.position - base.transform.forward * item * spacing;
		}
		Matrix4x4 matrix = Matrix4x4.TRS(pos, quaternion, base.transform.localScale);
		Graphics.DrawMesh(this.mesh, matrix, this.material, 0, camera, 0, this.materialPropertyBlock, false, false, false);
	}

	// Token: 0x0400025F RID: 607
	private Mesh mesh;

	// Token: 0x04000260 RID: 608
	private Material material;

	// Token: 0x04000261 RID: 609
	[SerializeField]
	[Range(1f, 20f)]
	[Tooltip("Controls the number of additional meshes to render in front of and behind the original mesh")]
	private int thickness = 1;

	// Token: 0x04000262 RID: 610
	[SerializeField]
	[Range(0.01f, 1f)]
	[Tooltip("Controls the total distance between the frontmost mesh and the backmost mesh")]
	private float spread = 0.2f;

	// Token: 0x04000263 RID: 611
	[SerializeField]
	private bool billboard = true;

	// Token: 0x04000264 RID: 612
	private MaterialPropertyBlock materialPropertyBlock;

	// Token: 0x04000265 RID: 613
	private int internalCount;

	// Token: 0x04000266 RID: 614
	private float randomStatic;

	// Token: 0x04000267 RID: 615
	private Collider boundaryCollider;
}
