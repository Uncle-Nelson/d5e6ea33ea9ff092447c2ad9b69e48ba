using System;
using UnityEngine;

// Token: 0x0200004B RID: 75
public class FlockWaypointTrigger : MonoBehaviour
{
	// Token: 0x06000192 RID: 402 RVA: 0x000098C0 File Offset: 0x00007AC0
	public void Start()
	{
		if (this._flockChild == null)
		{
			this._flockChild = base.transform.parent.GetComponent<FlockChild>();
		}
		float num = Random.Range(this._timer, this._timer * 3f);
		base.InvokeRepeating("Trigger", num, num);
	}

	// Token: 0x06000193 RID: 403 RVA: 0x00009916 File Offset: 0x00007B16
	public void Trigger()
	{
		this._flockChild.Wander(0f);
	}

	// Token: 0x040001B3 RID: 435
	public float _timer = 1f;

	// Token: 0x040001B4 RID: 436
	public FlockChild _flockChild;
}
