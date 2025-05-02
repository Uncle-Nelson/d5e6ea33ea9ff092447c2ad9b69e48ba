using System;
using UnityEngine;

// Token: 0x02000066 RID: 102
public class ResetPosition : MonoBehaviour
{
	// Token: 0x0600023A RID: 570 RVA: 0x0000D21C File Offset: 0x0000B41C
	private void Start()
	{
		this.startPosition = base.transform.position;
	}

	// Token: 0x0600023B RID: 571 RVA: 0x0000D22F File Offset: 0x0000B42F
	private void Update()
	{
		if (Vector3.Distance(this.startPosition, base.transform.position) >= this.distanceToReset)
		{
			base.transform.position = this.startPosition;
		}
	}

	// Token: 0x04000275 RID: 629
	public float distanceToReset = 5f;

	// Token: 0x04000276 RID: 630
	private Vector3 startPosition;
}
