using System;
using ScheduleOne.Audio;
using ScheduleOne.Stealth;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x020009B7 RID: 2487
	public class SpottedTremolo : MonoBehaviour
	{
		// Token: 0x0600432B RID: 17195 RVA: 0x00119940 File Offset: 0x00117B40
		public void Update()
		{
			this.Intensity = ((this.PlayerVisibility.HighestVisionEvent != null) ? this.PlayerVisibility.HighestVisionEvent.NormalizedNoticeLevel : 0f);
			if (this.Intensity > this.smoothedIntensity)
			{
				this.smoothedIntensity = Mathf.MoveTowards(this.smoothedIntensity, this.Intensity, Time.deltaTime / this.SmoothTime);
			}
			else
			{
				this.smoothedIntensity = Mathf.MoveTowards(this.smoothedIntensity, this.Intensity, Time.deltaTime / 3f);
			}
			float num = Mathf.Lerp(this.MinVolume, this.MaxVolume, this.smoothedIntensity);
			this.Loop.VolumeMultiplier = num;
			this.Loop.PitchMultiplier = Mathf.Lerp(this.MinPitch, this.MaxPitch, this.smoothedIntensity);
			this.Loop.ApplyPitch();
			if (num > 0f && !this.Loop.isPlaying)
			{
				this.Loop.Play();
				return;
			}
			if (num <= 0f && this.Loop.isPlaying)
			{
				this.Loop.Stop();
			}
		}

		// Token: 0x040030C5 RID: 12485
		[Range(0f, 1f)]
		public float Intensity;

		// Token: 0x040030C6 RID: 12486
		public AudioSourceController Loop;

		// Token: 0x040030C7 RID: 12487
		public PlayerVisibility PlayerVisibility;

		// Token: 0x040030C8 RID: 12488
		[Header("Settings")]
		public float MinVolume;

		// Token: 0x040030C9 RID: 12489
		public float MaxVolume = 1f;

		// Token: 0x040030CA RID: 12490
		public float MinPitch = 0.9f;

		// Token: 0x040030CB RID: 12491
		public float MaxPitch = 1.2f;

		// Token: 0x040030CC RID: 12492
		public float SmoothTime = 0.5f;

		// Token: 0x040030CD RID: 12493
		[Range(0f, 1f)]
		[SerializeField]
		private float smoothedIntensity;
	}
}
