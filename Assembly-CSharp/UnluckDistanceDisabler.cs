using System;
using UnityEngine;

// Token: 0x02000044 RID: 68
public class UnluckDistanceDisabler : MonoBehaviour
{
	// Token: 0x06000158 RID: 344 RVA: 0x00007A78 File Offset: 0x00005C78
	public void Start()
	{
		if (this._distanceFromMainCam)
		{
			this._distanceFrom = Camera.main.transform;
		}
		base.InvokeRepeating("CheckDisable", this._disableCheckInterval + Random.value * this._disableCheckInterval, this._disableCheckInterval);
		base.InvokeRepeating("CheckEnable", this._enableCheckInterval + Random.value * this._enableCheckInterval, this._enableCheckInterval);
		base.Invoke("DisableOnStart", 0.01f);
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00007AF5 File Offset: 0x00005CF5
	public void DisableOnStart()
	{
		if (this._disableOnStart)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600015A RID: 346 RVA: 0x00007B0C File Offset: 0x00005D0C
	public void CheckDisable()
	{
		if (base.gameObject.activeInHierarchy && (base.transform.position - this._distanceFrom.position).sqrMagnitude > (float)(this._distanceDisable * this._distanceDisable))
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600015B RID: 347 RVA: 0x00007B68 File Offset: 0x00005D68
	public void CheckEnable()
	{
		if (!base.gameObject.activeInHierarchy && (base.transform.position - this._distanceFrom.position).sqrMagnitude < (float)(this._distanceDisable * this._distanceDisable))
		{
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x04000136 RID: 310
	public int _distanceDisable = 1000;

	// Token: 0x04000137 RID: 311
	public Transform _distanceFrom;

	// Token: 0x04000138 RID: 312
	public bool _distanceFromMainCam;

	// Token: 0x04000139 RID: 313
	public float _disableCheckInterval = 10f;

	// Token: 0x0400013A RID: 314
	public float _enableCheckInterval = 1f;

	// Token: 0x0400013B RID: 315
	public bool _disableOnStart;
}
