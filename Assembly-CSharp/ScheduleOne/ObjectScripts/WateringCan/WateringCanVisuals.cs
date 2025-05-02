using System;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x02000BFB RID: 3067
	public class WateringCanVisuals : MonoBehaviour
	{
		// Token: 0x06005661 RID: 22113 RVA: 0x0016B678 File Offset: 0x00169878
		public virtual void SetFillLevel(float normalizedFillLevel)
		{
			this.WaterTransform.localPosition = new Vector3(this.WaterTransform.localPosition.x, Mathf.Lerp(this.WaterMinY, this.WaterMaxY, normalizedFillLevel), this.WaterTransform.localPosition.z);
			this.SideWaterTransform.localScale = new Vector3(Mathf.Lerp(this.SideWaterMinScale, this.SideWaterMaxScale, normalizedFillLevel), this.SideWaterTransform.localScale.y, this.SideWaterTransform.localScale.z);
			this.SideWaterTransform.localPosition = new Vector3(this.SideWaterTransform.localPosition.x, this.SideWaterTransform.localPosition.y, -this.SideWaterTransform.localScale.x * 0.5f);
		}

		// Token: 0x06005662 RID: 22114 RVA: 0x0016B750 File Offset: 0x00169950
		public void SetOverflowParticles(bool enabled)
		{
			if (enabled)
			{
				if (!this.OverflowParticles.isPlaying)
				{
					this.OverflowParticles.Play();
					return;
				}
			}
			else if (this.OverflowParticles.isPlaying)
			{
				this.OverflowParticles.Stop();
			}
		}

		// Token: 0x04003FBD RID: 16317
		public ParticleSystem OverflowParticles;

		// Token: 0x04003FBE RID: 16318
		public Transform WaterTransform;

		// Token: 0x04003FBF RID: 16319
		public float WaterMaxY;

		// Token: 0x04003FC0 RID: 16320
		public float WaterMinY;

		// Token: 0x04003FC1 RID: 16321
		public Transform SideWaterTransform;

		// Token: 0x04003FC2 RID: 16322
		public float SideWaterMinScale;

		// Token: 0x04003FC3 RID: 16323
		public float SideWaterMaxScale;

		// Token: 0x04003FC4 RID: 16324
		public AudioSourceController FillSound;
	}
}
