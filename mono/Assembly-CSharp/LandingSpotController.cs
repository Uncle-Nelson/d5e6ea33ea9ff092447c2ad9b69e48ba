using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200004F RID: 79
public class LandingSpotController : MonoBehaviour
{
	// Token: 0x060001A6 RID: 422 RVA: 0x0000A914 File Offset: 0x00008B14
	public void Start()
	{
		if (this._thisT == null)
		{
			this._thisT = base.transform;
		}
		if (this._flock == null)
		{
			this._flock = (FlockController)Object.FindObjectOfType(typeof(FlockController));
			Debug.Log(((this != null) ? this.ToString() : null) + " has no assigned FlockController, a random FlockController has been assigned");
		}
		if (this._landOnStart)
		{
			base.StartCoroutine(this.InstantLandOnStart(0.1f));
		}
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x0000A999 File Offset: 0x00008B99
	public void ScareAll()
	{
		this.ScareAll(0f, 1f);
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x0000A9AC File Offset: 0x00008BAC
	public void ScareAll(float minDelay, float maxDelay)
	{
		for (int i = 0; i < this._thisT.childCount; i++)
		{
			if (this._thisT.GetChild(i).GetComponent<LandingSpot>() != null)
			{
				this._thisT.GetChild(i).GetComponent<LandingSpot>().Invoke("ReleaseFlockChild", Random.Range(minDelay, maxDelay));
			}
		}
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x0000AA0C File Offset: 0x00008C0C
	public void LandAll()
	{
		for (int i = 0; i < this._thisT.childCount; i++)
		{
			if (this._thisT.GetChild(i).GetComponent<LandingSpot>() != null)
			{
				LandingSpot component = this._thisT.GetChild(i).GetComponent<LandingSpot>();
				base.StartCoroutine(component.GetFlockChild(0f, 2f));
			}
		}
	}

	// Token: 0x060001AA RID: 426 RVA: 0x0000AA71 File Offset: 0x00008C71
	public IEnumerator InstantLandOnStart(float delay)
	{
		yield return new WaitForSeconds(delay);
		for (int i = 0; i < this._thisT.childCount; i++)
		{
			if (this._thisT.GetChild(i).GetComponent<LandingSpot>() != null)
			{
				this._thisT.GetChild(i).GetComponent<LandingSpot>().InstantLand();
			}
		}
		yield break;
	}

	// Token: 0x060001AB RID: 427 RVA: 0x0000AA87 File Offset: 0x00008C87
	public IEnumerator InstantLand(float delay)
	{
		yield return new WaitForSeconds(delay);
		for (int i = 0; i < this._thisT.childCount; i++)
		{
			if (this._thisT.GetChild(i).GetComponent<LandingSpot>() != null)
			{
				this._thisT.GetChild(i).GetComponent<LandingSpot>().InstantLand();
			}
		}
		yield break;
	}

	// Token: 0x040001C4 RID: 452
	public bool _randomRotate = true;

	// Token: 0x040001C5 RID: 453
	public Vector2 _autoCatchDelay = new Vector2(10f, 20f);

	// Token: 0x040001C6 RID: 454
	public Vector2 _autoDismountDelay = new Vector2(10f, 20f);

	// Token: 0x040001C7 RID: 455
	public float _maxBirdDistance = 20f;

	// Token: 0x040001C8 RID: 456
	public float _minBirdDistance = 5f;

	// Token: 0x040001C9 RID: 457
	public bool _takeClosest;

	// Token: 0x040001CA RID: 458
	public FlockController _flock;

	// Token: 0x040001CB RID: 459
	public bool _landOnStart;

	// Token: 0x040001CC RID: 460
	public bool _soarLand = true;

	// Token: 0x040001CD RID: 461
	public bool _onlyBirdsAbove;

	// Token: 0x040001CE RID: 462
	public float _landingSpeedModifier = 0.5f;

	// Token: 0x040001CF RID: 463
	public float _landingTurnSpeedModifier = 5f;

	// Token: 0x040001D0 RID: 464
	public Transform _featherPS;

	// Token: 0x040001D1 RID: 465
	public Transform _thisT;

	// Token: 0x040001D2 RID: 466
	public int _activeLandingSpots;

	// Token: 0x040001D3 RID: 467
	public float _snapLandDistance = 0.1f;

	// Token: 0x040001D4 RID: 468
	public float _landedRotateSpeed = 0.01f;

	// Token: 0x040001D5 RID: 469
	public float _gizmoSize = 0.2f;
}
