using System;
using UnityEngine;

// Token: 0x02000054 RID: 84
public class SwooshTest : MonoBehaviour
{
	// Token: 0x060001BE RID: 446 RVA: 0x0000AD88 File Offset: 0x00008F88
	private void Start()
	{
		float num = this._animation.frameRate * this._animation.length;
		this._startN = (float)this._start / num;
		this._endN = (float)this._end / num;
		this._animationState = base.GetComponent<Animation>()[this._animation.name];
		this._trail.Emit = false;
	}

	// Token: 0x060001BF RID: 447 RVA: 0x0000ADF4 File Offset: 0x00008FF4
	private void Update()
	{
		this._time += this._animationState.normalizedTime - this._prevAnimTime;
		if (this._time > 1f || this._firstFrame)
		{
			if (!this._firstFrame)
			{
				this._time -= 1f;
			}
			this._firstFrame = false;
		}
		if (this._prevTime < this._startN && this._time >= this._startN)
		{
			this._trail.Emit = true;
		}
		else if (this._prevTime < this._endN && this._time >= this._endN)
		{
			this._trail.Emit = false;
		}
		this._prevTime = this._time;
		this._prevAnimTime = this._animationState.normalizedTime;
	}

	// Token: 0x040001E3 RID: 483
	[SerializeField]
	private AnimationClip _animation;

	// Token: 0x040001E4 RID: 484
	private AnimationState _animationState;

	// Token: 0x040001E5 RID: 485
	[SerializeField]
	private int _start;

	// Token: 0x040001E6 RID: 486
	[SerializeField]
	private int _end;

	// Token: 0x040001E7 RID: 487
	private float _startN;

	// Token: 0x040001E8 RID: 488
	private float _endN;

	// Token: 0x040001E9 RID: 489
	private float _time;

	// Token: 0x040001EA RID: 490
	private float _prevTime;

	// Token: 0x040001EB RID: 491
	private float _prevAnimTime;

	// Token: 0x040001EC RID: 492
	[SerializeField]
	private MeleeWeaponTrail _trail;

	// Token: 0x040001ED RID: 493
	private bool _firstFrame = true;
}
