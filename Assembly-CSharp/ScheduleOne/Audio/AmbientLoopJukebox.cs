using System;
using System.Collections.Generic;
using GameKit.Utilities;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x0200079C RID: 1948
	[RequireComponent(typeof(AudioSourceController))]
	public class AmbientLoopJukebox : MonoBehaviour
	{
		// Token: 0x060034F7 RID: 13559 RVA: 0x000DEB78 File Offset: 0x000DCD78
		private void Start()
		{
			this.audioSourceController = base.GetComponent<AudioSourceController>();
			this.audioSourceController.Play();
			Arrays.Shuffle<AudioClip>(this.Clips);
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
		}

		// Token: 0x060034F8 RID: 13560 RVA: 0x000DEBD0 File Offset: 0x000DCDD0
		private void Update()
		{
			if (Singleton<MusicPlayer>.Instance.IsPlaying)
			{
				this.musicScale = Mathf.Lerp(this.musicScale, 0.3f, Time.deltaTime / 4f);
				return;
			}
			this.musicScale = Mathf.Lerp(this.musicScale, 1f, Time.deltaTime / 4f);
		}

		// Token: 0x060034F9 RID: 13561 RVA: 0x000DEC2C File Offset: 0x000DCE2C
		private void MinPass()
		{
			float num = this.VolumeCurve.Evaluate((float)NetworkSingleton<TimeManager>.Instance.DailyMinTotal / 1440f);
			this.audioSourceController.VolumeMultiplier = num * this.musicScale;
			if (!this.audioSourceController.isPlaying)
			{
				this.currentClipIndex = (this.currentClipIndex + 1) % this.Clips.Count;
				this.audioSourceController.AudioSource.clip = this.Clips[this.currentClipIndex];
				this.audioSourceController.Play();
			}
		}

		// Token: 0x040025DE RID: 9694
		public AnimationCurve VolumeCurve;

		// Token: 0x040025DF RID: 9695
		public List<AudioClip> Clips = new List<AudioClip>();

		// Token: 0x040025E0 RID: 9696
		private AudioSourceController audioSourceController;

		// Token: 0x040025E1 RID: 9697
		private int currentClipIndex;

		// Token: 0x040025E2 RID: 9698
		private float musicScale = 1f;
	}
}
