using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x0200079B RID: 1947
	[RequireComponent(typeof(AudioSourceController))]
	public class AmbientLoop : MonoBehaviour
	{
		// Token: 0x060034F4 RID: 13556 RVA: 0x000DEAA1 File Offset: 0x000DCCA1
		private void Start()
		{
			this.audioSourceController = base.GetComponent<AudioSourceController>();
			this.audioSourceController.Play();
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x000DEABC File Offset: 0x000DCCBC
		private void Update()
		{
			if (this.FadeDuringMusic)
			{
				if (Singleton<MusicPlayer>.Instance.IsPlaying)
				{
					this.musicScale = Mathf.Lerp(this.musicScale, 0.3f, Time.deltaTime / 4f);
				}
				else
				{
					this.musicScale = Mathf.Lerp(this.musicScale, 1f, Time.deltaTime / 4f);
				}
			}
			else
			{
				this.musicScale = 1f;
			}
			float num = this.VolumeCurve.Evaluate((float)NetworkSingleton<TimeManager>.Instance.DailyMinTotal / 1440f);
			this.audioSourceController.VolumeMultiplier = num * this.musicScale;
		}

		// Token: 0x040025D8 RID: 9688
		public const float MUSIC_FADE_MULTIPLIER = 0.3f;

		// Token: 0x040025D9 RID: 9689
		public const float MUSIC_FADE_TIME = 4f;

		// Token: 0x040025DA RID: 9690
		public AnimationCurve VolumeCurve;

		// Token: 0x040025DB RID: 9691
		public bool FadeDuringMusic = true;

		// Token: 0x040025DC RID: 9692
		private AudioSourceController audioSourceController;

		// Token: 0x040025DD RID: 9693
		private float musicScale = 1f;
	}
}
