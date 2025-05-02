using System;
using UnityEngine;

// Token: 0x02000060 RID: 96
[ExecuteAlways]
public class MaterialChanger : MonoBehaviour
{
	// Token: 0x06000223 RID: 547 RVA: 0x0000CDDE File Offset: 0x0000AFDE
	private void OnEnable()
	{
		this.FindAllMaterialInChild();
	}

	// Token: 0x06000224 RID: 548 RVA: 0x0000CDE6 File Offset: 0x0000AFE6
	private void Update()
	{
		this._propBlock = new MaterialPropertyBlock();
		this.SetNewValueForAllMaterial(this._value);
	}

	// Token: 0x06000225 RID: 549 RVA: 0x0000CDFF File Offset: 0x0000AFFF
	private void FindAllMaterialInChild()
	{
		this._renderers = base.transform.GetComponentsInChildren<Renderer>();
	}

	// Token: 0x06000226 RID: 550 RVA: 0x0000CE14 File Offset: 0x0000B014
	private void SetNewValueForAllMaterial(float value)
	{
		this.FindAllMaterialInChild();
		for (int i = 0; i < this._renderers.Length; i++)
		{
			this._renderers[i].GetPropertyBlock(this._propBlock);
			this._propBlock.SetFloat(this._changeMaterialSetting, value);
			this._renderers[i].SetPropertyBlock(this._propBlock);
		}
	}

	// Token: 0x04000258 RID: 600
	[SerializeField]
	[Range(0f, 5f)]
	private float _value = 1f;

	// Token: 0x04000259 RID: 601
	[SerializeField]
	private string _changeMaterialSetting = "_Worn_Level";

	// Token: 0x0400025A RID: 602
	private Renderer[] _renderers;

	// Token: 0x0400025B RID: 603
	private MaterialPropertyBlock _propBlock;
}
