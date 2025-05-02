using System;
using EasyButtons;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x020007BD RID: 1981
	public class StartLoopStopAudio : MonoBehaviour
	{
		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06003595 RID: 13717 RVA: 0x000E10D3 File Offset: 0x000DF2D3
		// (set) Token: 0x06003596 RID: 13718 RVA: 0x000E10DB File Offset: 0x000DF2DB
		public bool Runnning { get; private set; }

		// Token: 0x06003597 RID: 13719 RVA: 0x000E10E4 File Offset: 0x000DF2E4
		private void Update()
		{
			if (!this.Runnning)
			{
				this.timeSinceStop += Time.deltaTime;
				if (this.FadeLoopOut)
				{
					this.LoopSound.VolumeMultiplier = Mathf.Lerp(1f, 0f, this.timeSinceStop / this.StopSound.AudioSource.clip.length);
				}
				else
				{
					this.LoopSound.VolumeMultiplier = 0f;
				}
				if (this.LoopSound.isPlaying && this.LoopSound.VolumeMultiplier == 0f)
				{
					this.LoopSound.Stop();
				}
				return;
			}
			this.timeSinceStart += Time.deltaTime;
			if (this.FadeLoopIn)
			{
				this.LoopSound.VolumeMultiplier = Mathf.Lerp(0f, 1f, this.timeSinceStart / this.StartSound.AudioSource.clip.length);
				return;
			}
			this.LoopSound.VolumeMultiplier = 1f;
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x000E11E8 File Offset: 0x000DF3E8
		[Button]
		public void StartAudio()
		{
			if (this.Runnning)
			{
				return;
			}
			this.Runnning = true;
			this.timeSinceStart = 0f;
			this.LoopSound.Play();
			this.LoopSound.AudioSource.loop = true;
			this.StartSound.Play();
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x000E1237 File Offset: 0x000DF437
		[Button]
		public void StopAudio()
		{
			if (!this.Runnning)
			{
				return;
			}
			this.Runnning = false;
			this.timeSinceStop = 0f;
			this.StartSound.Stop();
			this.StopSound.Play();
		}

		// Token: 0x0400268A RID: 9866
		public AudioSourceController StartSound;

		// Token: 0x0400268B RID: 9867
		public AudioSourceController LoopSound;

		// Token: 0x0400268C RID: 9868
		public AudioSourceController StopSound;

		// Token: 0x0400268D RID: 9869
		public bool FadeLoopIn;

		// Token: 0x0400268E RID: 9870
		public bool FadeLoopOut;

		// Token: 0x0400268F RID: 9871
		private float timeSinceStart;

		// Token: 0x04002690 RID: 9872
		private float timeSinceStop;
	}
}
