using System;
using UnityEngine;

namespace Beautify.Universal
{
	// Token: 0x020001EF RID: 495
	public class CameraAnimator : MonoBehaviour
	{
		// Token: 0x06000AED RID: 2797 RVA: 0x000303B4 File Offset: 0x0002E5B4
		private void Update()
		{
			base.transform.Rotate(new Vector3(0f, 0f, Time.deltaTime * 10f));
		}
	}
}
