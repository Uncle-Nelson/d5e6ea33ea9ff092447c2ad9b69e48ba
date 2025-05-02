using System;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x02000174 RID: 372
	public class VerticalBounce : MonoBehaviour
	{
		// Token: 0x06000704 RID: 1796 RVA: 0x000204A8 File Offset: 0x0001E6A8
		private void Update()
		{
			base.transform.localPosition = new Vector3(base.transform.localPosition.x, this.y, base.transform.localPosition.z);
			this.y += this.speed;
			this.direction = ((this.y < 0f) ? 1f : -1f);
			this.speed += Time.deltaTime * this.direction * this.acceleration;
		}

		// Token: 0x0400080B RID: 2059
		[Range(0f, 0.1f)]
		public float acceleration = 0.1f;

		// Token: 0x0400080C RID: 2060
		private float direction = 1f;

		// Token: 0x0400080D RID: 2061
		private float y;

		// Token: 0x0400080E RID: 2062
		private float speed = 0.01f;
	}
}
