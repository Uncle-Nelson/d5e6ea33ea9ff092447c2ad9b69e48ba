using System;
using UnityEngine;

// Token: 0x0200004A RID: 74
public class FlockScare : MonoBehaviour
{
	// Token: 0x0600018B RID: 395 RVA: 0x000096E0 File Offset: 0x000078E0
	private void CheckProximityToLandingSpots()
	{
		this.IterateLandingSpots();
		if (this.currentController._activeLandingSpots > 0 && this.CheckDistanceToLandingSpot(this.landingSpotControllers[this.lsc]))
		{
			this.landingSpotControllers[this.lsc].ScareAll();
		}
		base.Invoke("CheckProximityToLandingSpots", this.scareInterval);
	}

	// Token: 0x0600018C RID: 396 RVA: 0x0000973C File Offset: 0x0000793C
	private void IterateLandingSpots()
	{
		this.ls += this.checkEveryNthLandingSpot;
		this.currentController = this.landingSpotControllers[this.lsc];
		int childCount = this.currentController.transform.childCount;
		if (this.ls > childCount - 1)
		{
			this.ls -= childCount;
			if (this.lsc < this.landingSpotControllers.Length - 1)
			{
				this.lsc++;
				return;
			}
			this.lsc = 0;
		}
	}

	// Token: 0x0600018D RID: 397 RVA: 0x000097C4 File Offset: 0x000079C4
	private bool CheckDistanceToLandingSpot(LandingSpotController lc)
	{
		Transform child = lc.transform.GetChild(this.ls);
		return child.GetComponent<LandingSpot>().landingChild != null && (child.position - base.transform.position).sqrMagnitude < this.distanceToScare * this.distanceToScare;
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00009828 File Offset: 0x00007A28
	private void Invoker()
	{
		for (int i = 0; i < this.InvokeAmounts; i++)
		{
			float num = this.scareInterval / (float)this.InvokeAmounts * (float)i;
			base.Invoke("CheckProximityToLandingSpots", this.scareInterval + num);
		}
	}

	// Token: 0x0600018F RID: 399 RVA: 0x0000986B File Offset: 0x00007A6B
	private void OnEnable()
	{
		base.CancelInvoke("CheckProximityToLandingSpots");
		if (this.landingSpotControllers.Length != 0)
		{
			this.Invoker();
		}
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00009887 File Offset: 0x00007A87
	private void OnDisable()
	{
		base.CancelInvoke("CheckProximityToLandingSpots");
	}

	// Token: 0x040001AB RID: 427
	public LandingSpotController[] landingSpotControllers;

	// Token: 0x040001AC RID: 428
	public float scareInterval = 0.1f;

	// Token: 0x040001AD RID: 429
	public float distanceToScare = 2f;

	// Token: 0x040001AE RID: 430
	public int checkEveryNthLandingSpot = 1;

	// Token: 0x040001AF RID: 431
	public int InvokeAmounts = 1;

	// Token: 0x040001B0 RID: 432
	private int lsc;

	// Token: 0x040001B1 RID: 433
	private int ls;

	// Token: 0x040001B2 RID: 434
	private LandingSpotController currentController;
}
