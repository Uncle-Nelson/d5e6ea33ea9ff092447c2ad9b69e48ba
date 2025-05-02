using System;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x02000170 RID: 368
	public class FishAnimator : MonoBehaviour
	{
		// Token: 0x060006F9 RID: 1785 RVA: 0x0001FFC0 File Offset: 0x0001E1C0
		private void Update()
		{
			Vector3 position = Camera.main.transform.position;
			base.transform.LookAt(new Vector3(-position.x, base.transform.position.y, -position.z));
		}
	}
}
