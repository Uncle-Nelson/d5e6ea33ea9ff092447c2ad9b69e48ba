using System;
using UnityEngine;

// Token: 0x02000053 RID: 83
public class MouseMove : MonoBehaviour
{
	// Token: 0x060001BB RID: 443 RVA: 0x0000ACDC File Offset: 0x00008EDC
	private void Start()
	{
		this._originalPos = base.transform.position;
	}

	// Token: 0x060001BC RID: 444 RVA: 0x0000ACF0 File Offset: 0x00008EF0
	private void Update()
	{
		Vector3 vector = Input.mousePosition;
		vector.x /= (float)Screen.width;
		vector.y /= (float)Screen.height;
		vector.x -= 0.5f;
		vector.y -= 0.5f;
		vector *= 2f * this._sensitivity;
		base.transform.position = this._originalPos + vector;
	}

	// Token: 0x040001E1 RID: 481
	[SerializeField]
	private float _sensitivity = 0.5f;

	// Token: 0x040001E2 RID: 482
	private Vector3 _originalPos;
}
