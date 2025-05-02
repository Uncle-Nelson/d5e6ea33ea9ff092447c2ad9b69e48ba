using System;
using UnityEngine;

// Token: 0x02000052 RID: 82
public class LookAtTarget : MonoBehaviour
{
	// Token: 0x060001B9 RID: 441 RVA: 0x0000AC8E File Offset: 0x00008E8E
	private void Update()
	{
		this._lookAtTarget = Vector3.Lerp(this._lookAtTarget, this._target.position, Time.deltaTime * this._speed);
		base.transform.LookAt(this._lookAtTarget);
	}

	// Token: 0x040001DE RID: 478
	[SerializeField]
	private Transform _target;

	// Token: 0x040001DF RID: 479
	[SerializeField]
	private float _speed = 0.5f;

	// Token: 0x040001E0 RID: 480
	private Vector3 _lookAtTarget;
}
