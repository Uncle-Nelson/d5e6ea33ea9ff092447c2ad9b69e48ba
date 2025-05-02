using System;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x020007AF RID: 1967
	public class HeartbeatSoundController : MonoBehaviour
	{
		// Token: 0x0600355C RID: 13660 RVA: 0x000E04E2 File Offset: 0x000DE6E2
		private void Awake()
		{
			this.VolumeController.Initialize();
			this.VolumeController.SetDefault(0f);
			this.PitchController.Initialize();
			this.PitchController.SetDefault(1f);
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x000E051C File Offset: 0x000DE71C
		private void Update()
		{
			this.sound.VolumeMultiplier = this.VolumeController.CurrentValue;
			this.sound.PitchMultiplier = this.PitchController.CurrentValue;
			this.sound.ApplyPitch();
			if (this.sound.VolumeMultiplier > 0f)
			{
				if (!this.sound.isPlaying)
				{
					this.sound.Play();
					return;
				}
			}
			else if (this.sound.isPlaying)
			{
				this.sound.Stop();
			}
		}

		// Token: 0x04002653 RID: 9811
		public AudioSourceController sound;

		// Token: 0x04002654 RID: 9812
		public FloatSmoother VolumeController;

		// Token: 0x04002655 RID: 9813
		public FloatSmoother PitchController;
	}
}
