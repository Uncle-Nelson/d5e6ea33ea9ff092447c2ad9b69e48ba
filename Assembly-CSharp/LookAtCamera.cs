using System;
using UnityEngine;

// Token: 0x02000045 RID: 69
public class LookAtCamera : MonoBehaviour
{
	// Token: 0x0600015D RID: 349 RVA: 0x00007BEA File Offset: 0x00005DEA
	public void Start()
	{
		if (this.lookAtCamera == null)
		{
			this.lookAtCamera = Camera.main;
		}
		if (this.lookOnlyOnAwake)
		{
			this.LookCam();
		}
	}

	// Token: 0x0600015E RID: 350 RVA: 0x00007C13 File Offset: 0x00005E13
	public void Update()
	{
		if (!this.lookOnlyOnAwake)
		{
			this.LookCam();
		}
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00007C23 File Offset: 0x00005E23
	public void LookCam()
	{
		base.transform.LookAt(this.lookAtCamera.transform);
	}

	// Token: 0x0400013C RID: 316
	public Camera lookAtCamera;

	// Token: 0x0400013D RID: 317
	public bool lookOnlyOnAwake;
}
