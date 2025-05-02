using System;
using UnityEngine;

// Token: 0x02000061 RID: 97
public class OscillateLightBrightness : MonoBehaviour
{
	// Token: 0x06000228 RID: 552 RVA: 0x0000CE90 File Offset: 0x0000B090
	private void Start()
	{
		this.lightComponent = base.GetComponent<Light>();
	}

	// Token: 0x06000229 RID: 553 RVA: 0x0000CE9E File Offset: 0x0000B09E
	private void Update()
	{
		this.lightComponent.intensity = Random.Range(this.lower, this.upper);
	}

	// Token: 0x0400025C RID: 604
	private Light lightComponent;

	// Token: 0x0400025D RID: 605
	[SerializeField]
	[Range(0f, 10f)]
	private float lower;

	// Token: 0x0400025E RID: 606
	[SerializeField]
	[Range(0f, 10f)]
	private float upper;
}
