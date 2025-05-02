using System;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x0200016D RID: 365
	public class RandomRotation : MonoBehaviour
	{
		// Token: 0x060006F1 RID: 1777 RVA: 0x0001FB72 File Offset: 0x0001DD72
		private void Start()
		{
			this.randomization = Random.value;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0001FB80 File Offset: 0x0001DD80
		private void Update()
		{
			if (Time.time > this.lastTime)
			{
				this.lastTime = Time.time + this.randomChangeInterval + this.randomization;
				this.v = new Vector3(Random.value, Random.value, Random.value);
			}
			base.transform.Rotate(this.v * Time.deltaTime * this.speed);
		}

		// Token: 0x040007D9 RID: 2009
		[Range(1f, 50f)]
		public float speed = 10f;

		// Token: 0x040007DA RID: 2010
		[Range(1f, 30f)]
		public float randomChangeInterval = 10f;

		// Token: 0x040007DB RID: 2011
		private float lastTime;

		// Token: 0x040007DC RID: 2012
		private Vector3 v;

		// Token: 0x040007DD RID: 2013
		private float randomization;
	}
}
