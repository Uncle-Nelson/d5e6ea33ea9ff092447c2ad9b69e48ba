using System;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x02000173 RID: 371
	public class SpotlightAnimator : MonoBehaviour
	{
		// Token: 0x06000701 RID: 1793 RVA: 0x0002032D File Offset: 0x0001E52D
		private void Awake()
		{
			this.spotLight = base.GetComponent<Light>();
			this.spotLight.intensity = 0f;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0002034C File Offset: 0x0001E54C
		private void Update()
		{
			if (Time.time < this.lightOnDelay)
			{
				return;
			}
			float num = (Time.time - this.lightOnDelay) / this.duration;
			this.spotLight.intensity = Mathf.Lerp(this.initialIntensity, this.targetIntensity, num);
			if (Time.time - this.lastColorChange > this.nextColorInterval)
			{
				if (this.changingColor)
				{
					num = (Time.time - this.colorChangeStarted) / this.colorChangeDuration;
					if (num >= 1f)
					{
						this.changingColor = false;
						this.lastColorChange = Time.time;
					}
					this.spotLight.color = Color.Lerp(this.currentColor, this.nextColor, num);
					return;
				}
				this.currentColor = this.spotLight.color;
				this.nextColor = new Color(Mathf.Clamp01(Random.value + 0.25f), Mathf.Clamp01(Random.value + 0.25f), Mathf.Clamp01(Random.value + 0.25f), 1f);
				this.changingColor = true;
				this.colorChangeStarted = Time.time;
			}
		}

		// Token: 0x040007FF RID: 2047
		public float lightOnDelay = 2f;

		// Token: 0x04000800 RID: 2048
		public float targetIntensity = 3.5f;

		// Token: 0x04000801 RID: 2049
		public float initialIntensity;

		// Token: 0x04000802 RID: 2050
		public float duration = 3f;

		// Token: 0x04000803 RID: 2051
		public float nextColorInterval = 2f;

		// Token: 0x04000804 RID: 2052
		public float colorChangeDuration = 2f;

		// Token: 0x04000805 RID: 2053
		private Light spotLight;

		// Token: 0x04000806 RID: 2054
		private float lastColorChange;

		// Token: 0x04000807 RID: 2055
		private float colorChangeStarted;

		// Token: 0x04000808 RID: 2056
		private Color currentColor;

		// Token: 0x04000809 RID: 2057
		private Color nextColor;

		// Token: 0x0400080A RID: 2058
		private bool changingColor;
	}
}
