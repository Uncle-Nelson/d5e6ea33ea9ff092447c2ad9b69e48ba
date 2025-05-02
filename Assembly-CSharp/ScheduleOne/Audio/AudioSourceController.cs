using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace ScheduleOne.Audio
{
	// Token: 0x020007A1 RID: 1953
	[RequireComponent(typeof(AudioSource))]
	public class AudioSourceController : MonoBehaviour
	{
		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x0600351D RID: 13597 RVA: 0x000DF4FB File Offset: 0x000DD6FB
		// (set) Token: 0x0600351E RID: 13598 RVA: 0x000DF503 File Offset: 0x000DD703
		public float Volume { get; protected set; } = 1f;

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x0600351F RID: 13599 RVA: 0x000DF50C File Offset: 0x000DD70C
		public bool isPlaying
		{
			get
			{
				return this.AudioSource.isPlaying;
			}
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x000DF519 File Offset: 0x000DD719
		private void Awake()
		{
			this.DoPauseStuff();
			this.basePitch = this.AudioSource.pitch;
			this.AudioSource.volume = 0f;
			if (this.AudioSource.playOnAwake)
			{
				this.isPlayingCached = true;
			}
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x000DF558 File Offset: 0x000DD758
		private void Start()
		{
			this.SetVolume(this.DefaultVolume);
			Singleton<AudioManager>.Instance.onSettingsChanged.AddListener(new UnityAction(this.ApplyVolume));
			if (this.AudioType == EAudioType.Music)
			{
				this.AudioSource.outputAudioMixerGroup = Singleton<AudioManager>.Instance.MusicMixer;
				return;
			}
			if (SceneManager.GetActiveScene().name == "Main")
			{
				this.AudioSource.outputAudioMixerGroup = Singleton<AudioManager>.Instance.MainGameMixer;
				return;
			}
			this.AudioSource.outputAudioMixerGroup = Singleton<AudioManager>.Instance.MenuMixer;
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x000DF5F0 File Offset: 0x000DD7F0
		private void DoPauseStuff()
		{
			if (Singleton<PauseMenu>.InstanceExists)
			{
				Singleton<PauseMenu>.Instance.onPause.RemoveListener(new UnityAction(this.Pause));
				Singleton<PauseMenu>.Instance.onPause.AddListener(new UnityAction(this.Pause));
				Singleton<PauseMenu>.Instance.onResume.RemoveListener(new UnityAction(this.Unpause));
				Singleton<PauseMenu>.Instance.onResume.AddListener(new UnityAction(this.Pause));
			}
		}

		// Token: 0x06003523 RID: 13603 RVA: 0x000DF670 File Offset: 0x000DD870
		private void OnDestroy()
		{
			if (Singleton<AudioManager>.Instance != null)
			{
				Singleton<AudioManager>.Instance.onSettingsChanged.RemoveListener(new UnityAction(this.ApplyVolume));
			}
		}

		// Token: 0x06003524 RID: 13604 RVA: 0x000DF69A File Offset: 0x000DD89A
		private void OnValidate()
		{
			if (this.AudioSource == null)
			{
				this.AudioSource = base.GetComponent<AudioSource>();
			}
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x000DF6B6 File Offset: 0x000DD8B6
		private void FixedUpdate()
		{
			if (this.isPlayingCached)
			{
				this.ApplyVolume();
				if (!this.AudioSource.isPlaying && !this.paused)
				{
					this.isPlayingCached = false;
				}
			}
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x000DF6E2 File Offset: 0x000DD8E2
		private void Pause()
		{
			this.paused = true;
			this.AudioSource.Pause();
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x000DF6F6 File Offset: 0x000DD8F6
		private void Unpause()
		{
			this.paused = false;
			this.AudioSource.UnPause();
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x000DF70A File Offset: 0x000DD90A
		public void SetVolume(float volume)
		{
			this.Volume = volume;
			this.ApplyVolume();
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x000DF71C File Offset: 0x000DD91C
		public void ApplyVolume()
		{
			if (!Singleton<AudioManager>.InstanceExists)
			{
				return;
			}
			if (this.DEBUG)
			{
				Debug.Log(string.Concat(new string[]
				{
					"Applying volume: ",
					this.Volume.ToString(),
					" * ",
					Singleton<AudioManager>.Instance.GetVolume(this.AudioType, true).ToString(),
					" * ",
					this.VolumeMultiplier.ToString()
				}));
			}
			this.AudioSource.volume = this.Volume * Singleton<AudioManager>.Instance.GetVolume(this.AudioType, true) * this.VolumeMultiplier;
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x000DF7C8 File Offset: 0x000DD9C8
		public void ApplyPitch()
		{
			if (this.RandomizePitch)
			{
				this.AudioSource.pitch = Random.Range(this.MinPitch, this.MaxPitch) * this.PitchMultiplier;
				return;
			}
			this.AudioSource.pitch = this.basePitch * this.PitchMultiplier;
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x000DF819 File Offset: 0x000DDA19
		public virtual void Play()
		{
			this.ApplyPitch();
			this.ApplyVolume();
			this.isPlayingCached = true;
			this.AudioSource.Play();
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x000DF83C File Offset: 0x000DDA3C
		public virtual void PlayOneShot(bool duplicateAudioSource = false)
		{
			if (this.RandomizePitch)
			{
				this.AudioSource.pitch = Random.Range(this.MinPitch, this.MaxPitch) * this.PitchMultiplier;
			}
			this.ApplyVolume();
			if (!duplicateAudioSource)
			{
				this.AudioSource.PlayOneShot(this.AudioSource.clip, 1f);
				return;
			}
			GameObject gameObject = Object.Instantiate<GameObject>(base.gameObject, NetworkSingleton<GameManager>.Instance.Temp);
			gameObject.transform.position = base.transform.position;
			gameObject.GetComponent<AudioSourceController>().PlayOneShot(false);
			if (this.AudioSource.clip != null)
			{
				Object.Destroy(gameObject, this.AudioSource.clip.length + 0.1f);
				return;
			}
			Object.Destroy(gameObject, 5f);
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x000DF90C File Offset: 0x000DDB0C
		public void Stop()
		{
			this.AudioSource.Stop();
		}

		// Token: 0x0400260C RID: 9740
		public bool DEBUG;

		// Token: 0x0400260E RID: 9742
		public AudioSource AudioSource;

		// Token: 0x0400260F RID: 9743
		[Header("Settings")]
		public EAudioType AudioType;

		// Token: 0x04002610 RID: 9744
		[Range(0f, 1f)]
		public float DefaultVolume = 1f;

		// Token: 0x04002611 RID: 9745
		public bool RandomizePitch;

		// Token: 0x04002612 RID: 9746
		public float MinPitch = 0.9f;

		// Token: 0x04002613 RID: 9747
		public float MaxPitch = 1.1f;

		// Token: 0x04002614 RID: 9748
		[Range(0f, 2f)]
		public float VolumeMultiplier = 1f;

		// Token: 0x04002615 RID: 9749
		[Range(0f, 2f)]
		public float PitchMultiplier = 1f;

		// Token: 0x04002616 RID: 9750
		private bool paused;

		// Token: 0x04002617 RID: 9751
		private bool isPlayingCached;

		// Token: 0x04002618 RID: 9752
		private float basePitch = 1f;
	}
}
