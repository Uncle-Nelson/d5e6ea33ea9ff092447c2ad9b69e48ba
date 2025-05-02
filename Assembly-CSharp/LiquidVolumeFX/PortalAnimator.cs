using System;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x02000172 RID: 370
	public class PortalAnimator : MonoBehaviour
	{
		// Token: 0x060006FE RID: 1790 RVA: 0x0002026D File Offset: 0x0001E46D
		private void Start()
		{
			this.scale = base.transform.localScale;
			base.transform.localScale = Vector3.zero;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00020290 File Offset: 0x0001E490
		private void Update()
		{
			if (Time.time < this.delay)
			{
				return;
			}
			float value;
			if (Time.time > this.delayFadeOut)
			{
				value = 1f - (Time.time - this.delayFadeOut) / this.duration;
			}
			else
			{
				value = (Time.time - this.delay) / this.duration;
			}
			base.transform.localScale = Mathf.Clamp01(value) * this.scale;
		}

		// Token: 0x040007FB RID: 2043
		public float delay = 2f;

		// Token: 0x040007FC RID: 2044
		public float duration = 1f;

		// Token: 0x040007FD RID: 2045
		public float delayFadeOut = 4f;

		// Token: 0x040007FE RID: 2046
		private Vector3 scale;
	}
}
