using System;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x020005A5 RID: 1445
	[RequireComponent(typeof(Light))]
	public class FlickeringLight : MonoBehaviour
	{
		// Token: 0x060023D4 RID: 9172 RVA: 0x00091856 File Offset: 0x0008FA56
		private void Start()
		{
			this.lightSource = base.GetComponent<Light>();
			this.UpdateTargetValues();
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x0009186C File Offset: 0x0008FA6C
		private void Update()
		{
			this.lightSource.intensity = Mathf.Lerp(this.lightSource.intensity, this.targetIntensity, this.flickerSpeed * Time.deltaTime);
			if (this.enableColorShift)
			{
				this.lightSource.color = Color.Lerp(this.lightSource.color, this.targetColor, this.flickerSpeed * Time.deltaTime);
			}
			if (Mathf.Abs(this.lightSource.intensity - this.targetIntensity) < 0.05f)
			{
				this.UpdateTargetValues();
			}
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x000918FF File Offset: 0x0008FAFF
		private void UpdateTargetValues()
		{
			this.targetIntensity = Random.Range(this.minIntensity, this.maxIntensity);
			if (this.enableColorShift)
			{
				this.targetColor = Color.Lerp(this.minColor, this.maxColor, Random.value);
			}
		}

		// Token: 0x04001AAF RID: 6831
		[Header("Intensity Settings")]
		[Tooltip("The minimum light intensity.")]
		public float minIntensity = 0.8f;

		// Token: 0x04001AB0 RID: 6832
		[Tooltip("The maximum light intensity.")]
		public float maxIntensity = 1.2f;

		// Token: 0x04001AB1 RID: 6833
		[Header("Color Settings")]
		[Tooltip("Enable slight color shifts to simulate a warm flame.")]
		public bool enableColorShift = true;

		// Token: 0x04001AB2 RID: 6834
		public Color minColor = new Color(1f, 0.8f, 0.6f);

		// Token: 0x04001AB3 RID: 6835
		public Color maxColor = new Color(1f, 0.9f, 0.7f);

		// Token: 0x04001AB4 RID: 6836
		[Header("Flicker Speed")]
		[Tooltip("How quickly the light flickers (lower is faster).")]
		public float flickerSpeed = 0.1f;

		// Token: 0x04001AB5 RID: 6837
		private Light lightSource;

		// Token: 0x04001AB6 RID: 6838
		private float targetIntensity;

		// Token: 0x04001AB7 RID: 6839
		private Color targetColor;
	}
}
