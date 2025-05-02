using System;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x020007B7 RID: 1975
	public class RandomizedAudioSourceController : AudioSourceController
	{
		// Token: 0x06003580 RID: 13696 RVA: 0x000E0CA4 File Offset: 0x000DEEA4
		public override void Play()
		{
			if (this.Clips.Length == 0)
			{
				Console.LogWarning("RandomizedAudioSourceController: No clips to play", null);
				return;
			}
			int num = Random.Range(0, this.Clips.Length);
			this.AudioSource.clip = this.Clips[num];
			base.Play();
		}

		// Token: 0x06003581 RID: 13697 RVA: 0x000E0CF0 File Offset: 0x000DEEF0
		public override void PlayOneShot(bool duplicateAudioSource = false)
		{
			if (this.Clips.Length == 0)
			{
				Console.LogWarning("RandomizedAudioSourceController: No clips to play", null);
				return;
			}
			int num = Random.Range(0, this.Clips.Length);
			this.AudioSource.clip = this.Clips[num];
			base.PlayOneShot(duplicateAudioSource);
		}

		// Token: 0x04002678 RID: 9848
		public AudioClip[] Clips;
	}
}
