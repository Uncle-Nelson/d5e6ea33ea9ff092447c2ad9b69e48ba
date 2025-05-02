using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000049 RID: 73
public class FlockController : MonoBehaviour
{
	// Token: 0x06000180 RID: 384 RVA: 0x0000907C File Offset: 0x0000727C
	public void Start()
	{
		this._thisT = base.transform;
		if (this._positionSphereDepth == -1f)
		{
			this._positionSphereDepth = this._positionSphere;
		}
		if (this._spawnSphereDepth == -1f)
		{
			this._spawnSphereDepth = this._spawnSphere;
		}
		this._posBuffer = this._thisT.position + this._startPosOffset;
		if (!this._slowSpawn)
		{
			this.AddChild(this._childAmount);
		}
		if (this._randomPositionTimer > 0f)
		{
			base.InvokeRepeating("SetFlockRandomPosition", this._randomPositionTimer, this._randomPositionTimer);
		}
	}

	// Token: 0x06000181 RID: 385 RVA: 0x0000911C File Offset: 0x0000731C
	public void AddChild(int amount)
	{
		if (this._groupChildToNewTransform)
		{
			this.InstantiateGroup();
		}
		for (int i = 0; i < amount; i++)
		{
			FlockChild flockChild = Object.Instantiate<FlockChild>(this._childPrefab);
			flockChild._spawner = this;
			this._roamers.Add(flockChild);
			this.AddChildToParent(flockChild.transform);
		}
	}

	// Token: 0x06000182 RID: 386 RVA: 0x0000916E File Offset: 0x0000736E
	public void AddChildToParent(Transform obj)
	{
		if (this._groupChildToFlock)
		{
			obj.parent = base.transform;
			return;
		}
		if (this._groupChildToNewTransform)
		{
			obj.parent = this._groupTransform;
			return;
		}
	}

	// Token: 0x06000183 RID: 387 RVA: 0x0000919C File Offset: 0x0000739C
	public void RemoveChild(int amount)
	{
		for (int i = 0; i < amount; i++)
		{
			Component component = this._roamers[this._roamers.Count - 1];
			this._roamers.RemoveAt(this._roamers.Count - 1);
			Object.Destroy(component.gameObject);
		}
	}

	// Token: 0x06000184 RID: 388 RVA: 0x000091F0 File Offset: 0x000073F0
	public void Update()
	{
		if (this._activeChildren > 0f)
		{
			if (this._updateDivisor > 1)
			{
				this._updateCounter++;
				this._updateCounter %= this._updateDivisor;
				this._newDelta = Time.deltaTime * (float)this._updateDivisor;
			}
			else
			{
				this._newDelta = Time.deltaTime;
			}
		}
		this.UpdateChildAmount();
	}

	// Token: 0x06000185 RID: 389 RVA: 0x0000925C File Offset: 0x0000745C
	public void InstantiateGroup()
	{
		if (this._groupTransform != null)
		{
			return;
		}
		GameObject gameObject = new GameObject();
		this._groupTransform = gameObject.transform;
		this._groupTransform.position = this._thisT.position;
		if (this._groupName != "")
		{
			gameObject.name = this._groupName;
			return;
		}
		gameObject.name = this._thisT.name + " Fish Container";
	}

	// Token: 0x06000186 RID: 390 RVA: 0x000092DA File Offset: 0x000074DA
	public void UpdateChildAmount()
	{
		if (this._childAmount >= 0 && this._childAmount < this._roamers.Count)
		{
			this.RemoveChild(1);
			return;
		}
		if (this._childAmount > this._roamers.Count)
		{
			this.AddChild(1);
		}
	}

	// Token: 0x06000187 RID: 391 RVA: 0x0000931C File Offset: 0x0000751C
	public void OnDrawGizmos()
	{
		if (this._thisT == null)
		{
			this._thisT = base.transform;
		}
		if (!Application.isPlaying && this._posBuffer != this._thisT.position + this._startPosOffset)
		{
			this._posBuffer = this._thisT.position + this._startPosOffset;
		}
		if (this._positionSphereDepth == -1f)
		{
			this._positionSphereDepth = this._positionSphere;
		}
		if (this._spawnSphereDepth == -1f)
		{
			this._spawnSphereDepth = this._spawnSphere;
		}
		Gizmos.color = Color.blue;
		Gizmos.DrawWireCube(this._posBuffer, new Vector3(this._spawnSphere * 2f, this._spawnSphereHeight * 2f, this._spawnSphereDepth * 2f));
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireCube(this._thisT.position, new Vector3(this._positionSphere * 2f + this._spawnSphere * 2f, this._positionSphereHeight * 2f + this._spawnSphereHeight * 2f, this._positionSphereDepth * 2f + this._spawnSphereDepth * 2f));
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00009464 File Offset: 0x00007664
	public void SetFlockRandomPosition()
	{
		Vector3 zero = Vector3.zero;
		zero.x = Random.Range(-this._positionSphere, this._positionSphere) + this._thisT.position.x;
		zero.z = Random.Range(-this._positionSphereDepth, this._positionSphereDepth) + this._thisT.position.z;
		zero.y = Random.Range(-this._positionSphereHeight, this._positionSphereHeight) + this._thisT.position.y;
		this._posBuffer = zero;
		if (this._forceChildWaypoints)
		{
			for (int i = 0; i < this._roamers.Count; i++)
			{
				this._roamers[i].Wander(Random.value * this._forcedRandomDelay);
			}
		}
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00009538 File Offset: 0x00007738
	public void destroyBirds()
	{
		for (int i = 0; i < this._roamers.Count; i++)
		{
			Object.Destroy(this._roamers[i].gameObject);
		}
		this._childAmount = 0;
		this._roamers.Clear();
	}

	// Token: 0x04000178 RID: 376
	public FlockChild _childPrefab;

	// Token: 0x04000179 RID: 377
	public int _childAmount = 250;

	// Token: 0x0400017A RID: 378
	public bool _slowSpawn;

	// Token: 0x0400017B RID: 379
	public float _spawnSphere = 3f;

	// Token: 0x0400017C RID: 380
	public float _spawnSphereHeight = 3f;

	// Token: 0x0400017D RID: 381
	public float _spawnSphereDepth = -1f;

	// Token: 0x0400017E RID: 382
	public float _minSpeed = 6f;

	// Token: 0x0400017F RID: 383
	public float _maxSpeed = 10f;

	// Token: 0x04000180 RID: 384
	public float _minScale = 0.7f;

	// Token: 0x04000181 RID: 385
	public float _maxScale = 1f;

	// Token: 0x04000182 RID: 386
	public float _soarFrequency;

	// Token: 0x04000183 RID: 387
	public string _soarAnimation = "Soar";

	// Token: 0x04000184 RID: 388
	public string _flapAnimation = "Flap";

	// Token: 0x04000185 RID: 389
	public string _idleAnimation = "Idle";

	// Token: 0x04000186 RID: 390
	public float _diveValue = 7f;

	// Token: 0x04000187 RID: 391
	public float _diveFrequency = 0.5f;

	// Token: 0x04000188 RID: 392
	public float _minDamping = 1f;

	// Token: 0x04000189 RID: 393
	public float _maxDamping = 2f;

	// Token: 0x0400018A RID: 394
	public float _waypointDistance = 1f;

	// Token: 0x0400018B RID: 395
	public float _minAnimationSpeed = 2f;

	// Token: 0x0400018C RID: 396
	public float _maxAnimationSpeed = 4f;

	// Token: 0x0400018D RID: 397
	public float _randomPositionTimer = 10f;

	// Token: 0x0400018E RID: 398
	public float _positionSphere = 25f;

	// Token: 0x0400018F RID: 399
	public float _positionSphereHeight = 25f;

	// Token: 0x04000190 RID: 400
	public float _positionSphereDepth = -1f;

	// Token: 0x04000191 RID: 401
	public bool _childTriggerPos;

	// Token: 0x04000192 RID: 402
	public bool _forceChildWaypoints;

	// Token: 0x04000193 RID: 403
	public float _forcedRandomDelay = 1.5f;

	// Token: 0x04000194 RID: 404
	public bool _flatFly;

	// Token: 0x04000195 RID: 405
	public bool _flatSoar;

	// Token: 0x04000196 RID: 406
	public bool _birdAvoid;

	// Token: 0x04000197 RID: 407
	public int _birdAvoidHorizontalForce = 1000;

	// Token: 0x04000198 RID: 408
	public bool _birdAvoidDown;

	// Token: 0x04000199 RID: 409
	public bool _birdAvoidUp;

	// Token: 0x0400019A RID: 410
	public int _birdAvoidVerticalForce = 300;

	// Token: 0x0400019B RID: 411
	public float _birdAvoidDistanceMax = 4.5f;

	// Token: 0x0400019C RID: 412
	public float _birdAvoidDistanceMin = 5f;

	// Token: 0x0400019D RID: 413
	public float _soarMaxTime;

	// Token: 0x0400019E RID: 414
	public LayerMask _avoidanceMask = -1;

	// Token: 0x0400019F RID: 415
	public List<FlockChild> _roamers;

	// Token: 0x040001A0 RID: 416
	public Vector3 _posBuffer;

	// Token: 0x040001A1 RID: 417
	public int _updateDivisor = 1;

	// Token: 0x040001A2 RID: 418
	public float _newDelta;

	// Token: 0x040001A3 RID: 419
	public int _updateCounter;

	// Token: 0x040001A4 RID: 420
	public float _activeChildren;

	// Token: 0x040001A5 RID: 421
	public bool _groupChildToNewTransform;

	// Token: 0x040001A6 RID: 422
	public Transform _groupTransform;

	// Token: 0x040001A7 RID: 423
	public string _groupName = "";

	// Token: 0x040001A8 RID: 424
	public bool _groupChildToFlock;

	// Token: 0x040001A9 RID: 425
	public Vector3 _startPosOffset;

	// Token: 0x040001AA RID: 426
	public Transform _thisT;
}
