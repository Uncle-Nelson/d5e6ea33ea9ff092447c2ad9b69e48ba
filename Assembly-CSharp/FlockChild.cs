using System;
using UnityEngine;

// Token: 0x02000047 RID: 71
public class FlockChild : MonoBehaviour
{
	// Token: 0x06000167 RID: 359 RVA: 0x0000815C File Offset: 0x0000635C
	public void Start()
	{
		this.FindRequiredComponents();
		this.Wander(0f);
		this.SetRandomScale();
		this._thisT.position = this.findWaypoint();
		this.RandomizeStartAnimationFrame();
		this.InitAvoidanceValues();
		this._speed = this._spawner._minSpeed;
		this._spawner._activeChildren += 1f;
		this._instantiated = true;
		if (this._spawner._updateDivisor > 1)
		{
			int num = this._spawner._updateDivisor - 1;
			FlockChild._updateNextSeed++;
			this._updateSeed = FlockChild._updateNextSeed;
			FlockChild._updateNextSeed %= num;
		}
	}

	// Token: 0x06000168 RID: 360 RVA: 0x0000820B File Offset: 0x0000640B
	public void Update()
	{
		if (this._spawner._updateDivisor <= 1 || this._spawner._updateCounter == this._updateSeed)
		{
			this.SoarTimeLimit();
			this.CheckForDistanceToWaypoint();
			this.RotationBasedOnWaypointOrAvoidance();
			this.LimitRotationOfModel();
		}
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00008246 File Offset: 0x00006446
	public void OnDisable()
	{
		base.CancelInvoke();
		this._spawner._activeChildren -= 1f;
	}

	// Token: 0x0600016A RID: 362 RVA: 0x00008268 File Offset: 0x00006468
	public void OnEnable()
	{
		if (this._instantiated)
		{
			this._spawner._activeChildren += 1f;
			if (this._landing)
			{
				this._model.GetComponent<Animation>().Play(this._spawner._idleAnimation);
				return;
			}
			this._model.GetComponent<Animation>().Play(this._spawner._flapAnimation);
		}
	}

	// Token: 0x0600016B RID: 363 RVA: 0x000082D8 File Offset: 0x000064D8
	public void FindRequiredComponents()
	{
		if (this._thisT == null)
		{
			this._thisT = base.transform;
		}
		if (this._model == null)
		{
			this._model = this._thisT.Find("Model").gameObject;
		}
		if (this._modelT == null)
		{
			this._modelT = this._model.transform;
		}
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00008348 File Offset: 0x00006548
	public void RandomizeStartAnimationFrame()
	{
		foreach (object obj in this._model.GetComponent<Animation>())
		{
			AnimationState animationState = (AnimationState)obj;
			animationState.time = Random.value * animationState.length;
		}
	}

	// Token: 0x0600016D RID: 365 RVA: 0x000083B4 File Offset: 0x000065B4
	public void InitAvoidanceValues()
	{
		this._avoidValue = Random.Range(0.3f, 0.1f);
		if (this._spawner._birdAvoidDistanceMax != this._spawner._birdAvoidDistanceMin)
		{
			this._avoidDistance = Random.Range(this._spawner._birdAvoidDistanceMax, this._spawner._birdAvoidDistanceMin);
			return;
		}
		this._avoidDistance = this._spawner._birdAvoidDistanceMin;
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00008424 File Offset: 0x00006624
	public void SetRandomScale()
	{
		float num = Random.Range(this._spawner._minScale, this._spawner._maxScale);
		this._thisT.localScale = new Vector3(num, num, num);
	}

	// Token: 0x0600016F RID: 367 RVA: 0x00008460 File Offset: 0x00006660
	public void SoarTimeLimit()
	{
		if (this._soar && this._spawner._soarMaxTime > 0f)
		{
			if (this._soarTimer > this._spawner._soarMaxTime)
			{
				this.Flap();
				this._soarTimer = 0f;
				return;
			}
			this._soarTimer += this._spawner._newDelta;
		}
	}

	// Token: 0x06000170 RID: 368 RVA: 0x000084C4 File Offset: 0x000066C4
	public void CheckForDistanceToWaypoint()
	{
		if (!this._landing && (this._thisT.position - this._wayPoint).magnitude < this._spawner._waypointDistance + this._stuckCounter)
		{
			this.Wander(0f);
			this._stuckCounter = 0f;
			return;
		}
		if (!this._landing)
		{
			this._stuckCounter += this._spawner._newDelta;
			return;
		}
		this._stuckCounter = 0f;
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00008550 File Offset: 0x00006750
	public void RotationBasedOnWaypointOrAvoidance()
	{
		Vector3 vector = this._wayPoint - this._thisT.position;
		if (this._targetSpeed > -1f && vector != Vector3.zero)
		{
			Quaternion b = Quaternion.LookRotation(vector);
			this._thisT.rotation = Quaternion.Slerp(this._thisT.rotation, b, this._spawner._newDelta * this._damping);
		}
		if (this._spawner._childTriggerPos && (this._thisT.position - this._spawner._posBuffer).magnitude < 1f)
		{
			this._spawner.SetFlockRandomPosition();
		}
		this._speed = Mathf.Lerp(this._speed, this._targetSpeed, this._spawner._newDelta * 2.5f);
		if (this._move)
		{
			this._thisT.position += this._thisT.forward * this._speed * this._spawner._newDelta;
			if (this._avoid && this._spawner._birdAvoid)
			{
				this.Avoidance();
			}
		}
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00008690 File Offset: 0x00006890
	public bool Avoidance()
	{
		RaycastHit raycastHit = default(RaycastHit);
		Vector3 forward = this._modelT.forward;
		bool result = false;
		Quaternion rotation = Quaternion.identity;
		Vector3 eulerAngles = Vector3.zero;
		Vector3 position = Vector3.zero;
		position = this._thisT.position;
		rotation = this._thisT.rotation;
		eulerAngles = this._thisT.rotation.eulerAngles;
		if (Physics.Raycast(this._thisT.position, forward + this._modelT.right * this._avoidValue, ref raycastHit, this._avoidDistance, this._spawner._avoidanceMask))
		{
			eulerAngles.y -= (float)this._spawner._birdAvoidHorizontalForce * this._spawner._newDelta * this._damping;
			rotation.eulerAngles = eulerAngles;
			this._thisT.rotation = rotation;
			result = true;
		}
		else if (Physics.Raycast(this._thisT.position, forward + this._modelT.right * -this._avoidValue, ref raycastHit, this._avoidDistance, this._spawner._avoidanceMask))
		{
			eulerAngles.y += (float)this._spawner._birdAvoidHorizontalForce * this._spawner._newDelta * this._damping;
			rotation.eulerAngles = eulerAngles;
			this._thisT.rotation = rotation;
			result = true;
		}
		if (this._spawner._birdAvoidDown && !this._landing && Physics.Raycast(this._thisT.position, -Vector3.up, ref raycastHit, this._avoidDistance, this._spawner._avoidanceMask))
		{
			eulerAngles.x -= (float)this._spawner._birdAvoidVerticalForce * this._spawner._newDelta * this._damping;
			rotation.eulerAngles = eulerAngles;
			this._thisT.rotation = rotation;
			position.y += (float)this._spawner._birdAvoidVerticalForce * this._spawner._newDelta * 0.01f;
			this._thisT.position = position;
			result = true;
		}
		else if (this._spawner._birdAvoidUp && !this._landing && Physics.Raycast(this._thisT.position, Vector3.up, ref raycastHit, this._avoidDistance, this._spawner._avoidanceMask))
		{
			eulerAngles.x += (float)this._spawner._birdAvoidVerticalForce * this._spawner._newDelta * this._damping;
			rotation.eulerAngles = eulerAngles;
			this._thisT.rotation = rotation;
			position.y -= (float)this._spawner._birdAvoidVerticalForce * this._spawner._newDelta * 0.01f;
			this._thisT.position = position;
			result = true;
		}
		return result;
	}

	// Token: 0x06000173 RID: 371 RVA: 0x00008998 File Offset: 0x00006B98
	public void LimitRotationOfModel()
	{
		Quaternion localRotation = Quaternion.identity;
		Vector3 eulerAngles = Vector3.zero;
		localRotation = this._modelT.localRotation;
		eulerAngles = localRotation.eulerAngles;
		if ((((this._soar && this._spawner._flatSoar) || (this._spawner._flatFly && !this._soar)) && this._wayPoint.y > this._thisT.position.y) || this._landing)
		{
			eulerAngles.x = Mathf.LerpAngle(this._modelT.localEulerAngles.x, -this._thisT.localEulerAngles.x, this._spawner._newDelta * 1.75f);
			localRotation.eulerAngles = eulerAngles;
			this._modelT.localRotation = localRotation;
			return;
		}
		eulerAngles.x = Mathf.LerpAngle(this._modelT.localEulerAngles.x, 0f, this._spawner._newDelta * 1.75f);
		localRotation.eulerAngles = eulerAngles;
		this._modelT.localRotation = localRotation;
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00008AB0 File Offset: 0x00006CB0
	public void Wander(float delay)
	{
		if (!this._landing)
		{
			this._damping = Random.Range(this._spawner._minDamping, this._spawner._maxDamping);
			this._targetSpeed = Random.Range(this._spawner._minSpeed, this._spawner._maxSpeed);
			base.Invoke("SetRandomMode", delay);
		}
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00008B14 File Offset: 0x00006D14
	public void SetRandomMode()
	{
		base.CancelInvoke("SetRandomMode");
		if (!this._dived && Random.value < this._spawner._soarFrequency)
		{
			this.Soar();
			return;
		}
		if (!this._dived && Random.value < this._spawner._diveFrequency)
		{
			this.Dive();
			return;
		}
		this.Flap();
	}

	// Token: 0x06000176 RID: 374 RVA: 0x00008B74 File Offset: 0x00006D74
	public void Flap()
	{
		if (this._move)
		{
			if (this._model != null)
			{
				this._model.GetComponent<Animation>().CrossFade(this._spawner._flapAnimation, 0.5f);
			}
			this._soar = false;
			this.animationSpeed();
			this._wayPoint = this.findWaypoint();
			this._dived = false;
		}
	}

	// Token: 0x06000177 RID: 375 RVA: 0x00008BD8 File Offset: 0x00006DD8
	public Vector3 findWaypoint()
	{
		Vector3 zero = Vector3.zero;
		zero.x = Random.Range(-this._spawner._spawnSphere, this._spawner._spawnSphere) + this._spawner._posBuffer.x;
		zero.z = Random.Range(-this._spawner._spawnSphereDepth, this._spawner._spawnSphereDepth) + this._spawner._posBuffer.z;
		zero.y = Random.Range(-this._spawner._spawnSphereHeight, this._spawner._spawnSphereHeight) + this._spawner._posBuffer.y;
		return zero;
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00008C88 File Offset: 0x00006E88
	public void Soar()
	{
		if (this._move)
		{
			this._model.GetComponent<Animation>().CrossFade(this._spawner._soarAnimation, 1.5f);
			this._wayPoint = this.findWaypoint();
			this._soar = true;
		}
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00008CC8 File Offset: 0x00006EC8
	public void Dive()
	{
		if (this._spawner._soarAnimation != null)
		{
			this._model.GetComponent<Animation>().CrossFade(this._spawner._soarAnimation, 1.5f);
		}
		else
		{
			foreach (object obj in this._model.GetComponent<Animation>())
			{
				AnimationState animationState = (AnimationState)obj;
				if (this._thisT.position.y < this._wayPoint.y + 25f)
				{
					animationState.speed = 0.1f;
				}
			}
		}
		this._wayPoint = this.findWaypoint();
		this._wayPoint.y = this._wayPoint.y - this._spawner._diveValue;
		this._dived = true;
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00008DAC File Offset: 0x00006FAC
	public void animationSpeed()
	{
		foreach (object obj in this._model.GetComponent<Animation>())
		{
			AnimationState animationState = (AnimationState)obj;
			if (!this._dived && !this._landing)
			{
				animationState.speed = Random.Range(this._spawner._minAnimationSpeed, this._spawner._maxAnimationSpeed);
			}
			else
			{
				animationState.speed = this._spawner._maxAnimationSpeed;
			}
		}
	}

	// Token: 0x04000156 RID: 342
	[HideInInspector]
	public FlockController _spawner;

	// Token: 0x04000157 RID: 343
	[HideInInspector]
	public Vector3 _wayPoint;

	// Token: 0x04000158 RID: 344
	public float _speed;

	// Token: 0x04000159 RID: 345
	[HideInInspector]
	public bool _dived = true;

	// Token: 0x0400015A RID: 346
	[HideInInspector]
	public float _stuckCounter;

	// Token: 0x0400015B RID: 347
	[HideInInspector]
	public float _damping;

	// Token: 0x0400015C RID: 348
	[HideInInspector]
	public bool _soar = true;

	// Token: 0x0400015D RID: 349
	[HideInInspector]
	public bool _landing;

	// Token: 0x0400015E RID: 350
	[HideInInspector]
	public float _targetSpeed;

	// Token: 0x0400015F RID: 351
	[HideInInspector]
	public bool _move = true;

	// Token: 0x04000160 RID: 352
	public GameObject _model;

	// Token: 0x04000161 RID: 353
	public Transform _modelT;

	// Token: 0x04000162 RID: 354
	[HideInInspector]
	public float _avoidValue;

	// Token: 0x04000163 RID: 355
	[HideInInspector]
	public float _avoidDistance;

	// Token: 0x04000164 RID: 356
	private float _soarTimer;

	// Token: 0x04000165 RID: 357
	private bool _instantiated;

	// Token: 0x04000166 RID: 358
	private static int _updateNextSeed;

	// Token: 0x04000167 RID: 359
	private int _updateSeed = -1;

	// Token: 0x04000168 RID: 360
	[HideInInspector]
	public bool _avoid = true;

	// Token: 0x04000169 RID: 361
	public Transform _thisT;

	// Token: 0x0400016A RID: 362
	public Vector3 _landingPosOffset;
}
