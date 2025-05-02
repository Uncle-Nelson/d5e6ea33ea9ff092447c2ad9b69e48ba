using System;
using UnityEngine;

// Token: 0x02000065 RID: 101
[ExecuteInEditMode]
public class RenderPipelineLighting : MonoBehaviour
{
	// Token: 0x06000237 RID: 567 RVA: 0x0000D214 File Offset: 0x0000B414
	private void OnValidate()
	{
		this.Awake();
	}

	// Token: 0x06000238 RID: 568 RVA: 0x000045B1 File Offset: 0x000027B1
	private void Awake()
	{
	}

	// Token: 0x0400026C RID: 620
	[SerializeField]
	private GameObject _standardLighting;

	// Token: 0x0400026D RID: 621
	[SerializeField]
	private Material _standardSky;

	// Token: 0x0400026E RID: 622
	[SerializeField]
	private Material _standardTerrain;

	// Token: 0x0400026F RID: 623
	[SerializeField]
	private GameObject _universalLighting;

	// Token: 0x04000270 RID: 624
	[SerializeField]
	private Material _universalSky;

	// Token: 0x04000271 RID: 625
	[SerializeField]
	private Material _universalTerrain;

	// Token: 0x04000272 RID: 626
	[SerializeField]
	private GameObject _highDefinitionLighting;

	// Token: 0x04000273 RID: 627
	[SerializeField]
	private Material _highDefinitionSky;

	// Token: 0x04000274 RID: 628
	[SerializeField]
	private Material _highDefinitionTerrain;
}
