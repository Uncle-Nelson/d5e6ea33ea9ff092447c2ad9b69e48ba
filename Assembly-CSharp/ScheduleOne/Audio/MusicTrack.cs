using System;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x020007B6 RID: 1974
	[RequireComponent(typeof(AudioSourceController))]
	public class MusicTrack : MonoBehaviour
	{
		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06003576 RID: 13686 RVA: 0x000E0AD5 File Offset: 0x000DECD5
		// (set) Token: 0x06003577 RID: 13687 RVA: 0x000E0ADD File Offset: 0x000DECDD
		public bool IsPlaying { get; private set; }

		// Token: 0x06003578 RID: 13688 RVA: 0x000E0AE6 File Offset: 0x000DECE6
		private void OnValidate()
		{
			base.gameObject.name = this.TrackName + " (" + this.Priority.ToString() + ")";
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x000E0B13 File Offset: 0x000DED13
		public void Enable()
		{
			this.Enabled = true;
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x000E0B1C File Offset: 0x000DED1C
		public void Disable()
		{
			this.Enabled = false;
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x000E0B25 File Offset: 0x000DED25
		protected virtual void Awake()
		{
			this.volumeMultiplier = 0f;
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x000E0B34 File Offset: 0x000DED34
		public virtual void Update()
		{
			if (this.IsPlaying && this.Controller.AudioSource.time >= this.Controller.AudioSource.clip.length - this.FadeOutTime && this.AutoFadeOut)
			{
				this.Stop();
				this.Disable();
			}
			if (this.IsPlaying)
			{
				this.volumeMultiplier = Mathf.Min(this.volumeMultiplier + Time.deltaTime / this.FadeInTime, 1f);
				this.Controller.VolumeMultiplier = this.volumeMultiplier * this.VolumeMultiplier;
				return;
			}
			this.volumeMultiplier = Mathf.Max(this.volumeMultiplier - Time.deltaTime / this.FadeOutTime, 0f);
			this.Controller.VolumeMultiplier = this.volumeMultiplier * this.VolumeMultiplier;
			if (this.Controller.VolumeMultiplier == 0f)
			{
				this.Controller.AudioSource.Stop();
			}
		}

		// Token: 0x0600357D RID: 13693 RVA: 0x000E0C2C File Offset: 0x000DEE2C
		public virtual void Play()
		{
			this.IsPlaying = true;
			this.Controller.Play();
		}

		// Token: 0x0600357E RID: 13694 RVA: 0x000E0C40 File Offset: 0x000DEE40
		public virtual void Stop()
		{
			this.IsPlaying = false;
		}

		// Token: 0x0400266F RID: 9839
		public bool Enabled;

		// Token: 0x04002670 RID: 9840
		public string TrackName = "Track";

		// Token: 0x04002671 RID: 9841
		public int Priority = 1;

		// Token: 0x04002672 RID: 9842
		public float FadeInTime = 1f;

		// Token: 0x04002673 RID: 9843
		public float FadeOutTime = 2f;

		// Token: 0x04002674 RID: 9844
		public AudioSourceController Controller;

		// Token: 0x04002675 RID: 9845
		public float VolumeMultiplier = 1f;

		// Token: 0x04002676 RID: 9846
		public bool AutoFadeOut = true;

		// Token: 0x04002677 RID: 9847
		protected float volumeMultiplier = 1f;
	}
}
