using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x020007BB RID: 1979
	public class StartLoopMusicTrack : MusicTrack
	{
		// Token: 0x0600358A RID: 13706 RVA: 0x000E0F30 File Offset: 0x000DF130
		protected override void Awake()
		{
			base.Awake();
			this.AutoFadeOut = false;
			this.LoopSound.AudioSource.loop = true;
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x000E0F50 File Offset: 0x000DF150
		public override void Update()
		{
			base.Update();
			if (base.IsPlaying)
			{
				if (!this.Controller.AudioSource.isPlaying && !this.LoopSound.isPlaying)
				{
					this.LoopSound.Play();
				}
				this.LoopSound.VolumeMultiplier = this.volumeMultiplier * this.VolumeMultiplier;
				return;
			}
			this.LoopSound.VolumeMultiplier = this.volumeMultiplier * this.VolumeMultiplier;
			if (this.LoopSound.VolumeMultiplier == 0f)
			{
				this.LoopSound.AudioSource.Stop();
			}
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x000E0FE8 File Offset: 0x000DF1E8
		public override void Play()
		{
			base.Play();
			Singleton<CoroutineService>.Instance.StartCoroutine(this.<Play>g__WaitForStart|3_0());
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x000E1009 File Offset: 0x000DF209
		[CompilerGenerated]
		private IEnumerator <Play>g__WaitForStart|3_0()
		{
			while (base.IsPlaying)
			{
				if (this.Controller.AudioSource.clip.length - this.Controller.AudioSource.time <= Time.deltaTime)
				{
					Console.Log("Starting loop for " + this.TrackName, null);
					this.LoopSound.Play();
					yield break;
				}
				yield return new WaitForEndOfFrame();
			}
			yield break;
		}

		// Token: 0x04002685 RID: 9861
		public AudioSourceController LoopSound;
	}
}
