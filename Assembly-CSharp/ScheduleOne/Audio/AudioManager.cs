using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace ScheduleOne.Audio
{
	// Token: 0x020007A0 RID: 1952
	public class AudioManager : PersistentSingleton<AudioManager>
	{
		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06003505 RID: 13573 RVA: 0x000DF162 File Offset: 0x000DD362
		public float MasterVolume
		{
			get
			{
				return this.masterVolume;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06003506 RID: 13574 RVA: 0x000DF16A File Offset: 0x000DD36A
		public float AmbientVolume
		{
			get
			{
				return this.ambientVolume * this.masterVolume;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06003507 RID: 13575 RVA: 0x000DF179 File Offset: 0x000DD379
		public float UnscaledAmbientVolume
		{
			get
			{
				return this.ambientVolume;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06003508 RID: 13576 RVA: 0x000DF181 File Offset: 0x000DD381
		public float FootstepsVolume
		{
			get
			{
				return this.footstepsVolume * this.masterVolume;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06003509 RID: 13577 RVA: 0x000DF190 File Offset: 0x000DD390
		public float UnscaledFootstepsVolume
		{
			get
			{
				return this.footstepsVolume;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x0600350A RID: 13578 RVA: 0x000DF198 File Offset: 0x000DD398
		public float FXVolume
		{
			get
			{
				return this.fxVolume * this.masterVolume;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x0600350B RID: 13579 RVA: 0x000DF1A7 File Offset: 0x000DD3A7
		public float UnscaledFXVolume
		{
			get
			{
				return this.fxVolume;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x0600350C RID: 13580 RVA: 0x000DF1AF File Offset: 0x000DD3AF
		public float UIVolume
		{
			get
			{
				return this.uiVolume * this.masterVolume;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x0600350D RID: 13581 RVA: 0x000DF1BE File Offset: 0x000DD3BE
		public float UnscaledUIVolume
		{
			get
			{
				return this.uiVolume;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x0600350E RID: 13582 RVA: 0x000DF1C6 File Offset: 0x000DD3C6
		public float MusicVolume
		{
			get
			{
				return this.musicVolume * this.masterVolume * 0.7f;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x0600350F RID: 13583 RVA: 0x000DF1DB File Offset: 0x000DD3DB
		public float UnscaledMusicVolume
		{
			get
			{
				return this.musicVolume;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06003510 RID: 13584 RVA: 0x000DF1E3 File Offset: 0x000DD3E3
		public float VoiceVolume
		{
			get
			{
				return this.voiceVolume * this.masterVolume * 0.5f;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06003511 RID: 13585 RVA: 0x000DF1F8 File Offset: 0x000DD3F8
		public float UnscaledVoiceVolume
		{
			get
			{
				return this.voiceVolume;
			}
		}

		// Token: 0x06003512 RID: 13586 RVA: 0x000DF200 File Offset: 0x000DD400
		protected override void Awake()
		{
			base.Awake();
			if (Singleton<AudioManager>.Instance == null || Singleton<AudioManager>.Instance != this)
			{
				return;
			}
			this.SetGameVolume(0f);
		}

		// Token: 0x06003513 RID: 13587 RVA: 0x000DF22E File Offset: 0x000DD42E
		protected override void Start()
		{
			base.Start();
			if (Singleton<AudioManager>.Instance == null || Singleton<AudioManager>.Instance != this)
			{
				return;
			}
			Singleton<LoadManager>.Instance.onPreSceneChange.AddListener(new UnityAction(delegate()
			{
				this.SetDistorted(false, 0.5f);
			}));
		}

		// Token: 0x06003514 RID: 13588 RVA: 0x000DF26C File Offset: 0x000DD46C
		protected void Update()
		{
			if (SceneManager.GetActiveScene().name == "Main" && !Singleton<LoadingScreen>.Instance.IsOpen)
			{
				if (this.currentGameVolume < 1f)
				{
					this.SetGameVolume(this.currentGameVolume + Time.deltaTime * 1f);
					return;
				}
			}
			else if (this.currentGameVolume > 0f)
			{
				this.SetGameVolume(this.currentGameVolume - Time.deltaTime * 1f);
			}
		}

		// Token: 0x06003515 RID: 13589 RVA: 0x000DF2E9 File Offset: 0x000DD4E9
		public void SetGameVolumeMultipler(float value)
		{
			this.gameVolumeMultiplier = value;
			this.SetGameVolume(this.currentGameVolume);
		}

		// Token: 0x06003516 RID: 13590 RVA: 0x000DF2FE File Offset: 0x000DD4FE
		public void SetDistorted(bool distorted, float transition = 5f)
		{
			if (distorted)
			{
				this.DistortedSnapshot.TransitionTo(transition);
				return;
			}
			this.DefaultSnapshot.TransitionTo(transition);
		}

		// Token: 0x06003517 RID: 13591 RVA: 0x000DF31C File Offset: 0x000DD51C
		private void SetGameVolume(float value)
		{
			this.currentGameVolume = value;
			value = Mathf.Lerp(value * this.gameVolumeMultiplier, 0.0001f, 0.0001f);
			this.MainGameMixer.audioMixer.SetFloat("MasterVolume", Mathf.Log10(value) * 20f);
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x000DF36C File Offset: 0x000DD56C
		public float GetVolume(EAudioType audioType, bool scaled = true)
		{
			switch (audioType)
			{
			case EAudioType.Ambient:
				if (!scaled)
				{
					return this.UnscaledAmbientVolume;
				}
				return this.AmbientVolume;
			case EAudioType.Footsteps:
				if (!scaled)
				{
					return this.UnscaledFootstepsVolume;
				}
				return this.FootstepsVolume;
			case EAudioType.FX:
				if (!scaled)
				{
					return this.UnscaledFXVolume;
				}
				return this.FXVolume;
			case EAudioType.UI:
				if (!scaled)
				{
					return this.UnscaledUIVolume;
				}
				return this.UIVolume;
			case EAudioType.Music:
				if (!scaled)
				{
					return this.UnscaledMusicVolume;
				}
				return this.MusicVolume;
			case EAudioType.Voice:
				if (!scaled)
				{
					return this.UnscaledVoiceVolume;
				}
				return this.VoiceVolume;
			default:
				return 1f;
			}
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x000DF404 File Offset: 0x000DD604
		public void SetMasterVolume(float volume)
		{
			this.masterVolume = volume;
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x000DF410 File Offset: 0x000DD610
		public void SetVolume(EAudioType type, float volume)
		{
			switch (type)
			{
			case EAudioType.Ambient:
				this.ambientVolume = volume;
				return;
			case EAudioType.Footsteps:
				this.footstepsVolume = volume;
				return;
			case EAudioType.FX:
				this.fxVolume = volume;
				return;
			case EAudioType.UI:
				this.uiVolume = volume;
				return;
			case EAudioType.Music:
				this.musicVolume = volume;
				return;
			case EAudioType.Voice:
				this.voiceVolume = volume;
				return;
			default:
				return;
			}
		}

		// Token: 0x040025F9 RID: 9721
		[Range(0f, 2f)]
		[SerializeField]
		protected float masterVolume = 1f;

		// Token: 0x040025FA RID: 9722
		[Range(0f, 2f)]
		[SerializeField]
		protected float ambientVolume = 1f;

		// Token: 0x040025FB RID: 9723
		[Range(0f, 2f)]
		[SerializeField]
		protected float footstepsVolume = 1f;

		// Token: 0x040025FC RID: 9724
		[Range(0f, 2f)]
		[SerializeField]
		protected float fxVolume = 1f;

		// Token: 0x040025FD RID: 9725
		[Range(0f, 2f)]
		[SerializeField]
		protected float uiVolume = 1f;

		// Token: 0x040025FE RID: 9726
		[Range(0f, 2f)]
		[SerializeField]
		protected float musicVolume = 1f;

		// Token: 0x040025FF RID: 9727
		[Range(0f, 2f)]
		[SerializeField]
		protected float voiceVolume = 1f;

		// Token: 0x04002600 RID: 9728
		public UnityEvent onSettingsChanged = new UnityEvent();

		// Token: 0x04002601 RID: 9729
		[Header("Generic Door Sounds")]
		public AudioSourceController DoorOpen;

		// Token: 0x04002602 RID: 9730
		public AudioSourceController DoorClose;

		// Token: 0x04002603 RID: 9731
		[Header("Mixers")]
		public AudioMixerGroup MainGameMixer;

		// Token: 0x04002604 RID: 9732
		public AudioMixerGroup MenuMixer;

		// Token: 0x04002605 RID: 9733
		public AudioMixerGroup MusicMixer;

		// Token: 0x04002606 RID: 9734
		private float currentGameVolume = 1f;

		// Token: 0x04002607 RID: 9735
		private const float minGameVolume = 0.0001f;

		// Token: 0x04002608 RID: 9736
		private const float maxGameVolume = 0.0001f;

		// Token: 0x04002609 RID: 9737
		private float gameVolumeMultiplier = 1f;

		// Token: 0x0400260A RID: 9738
		public AudioMixerSnapshot DefaultSnapshot;

		// Token: 0x0400260B RID: 9739
		public AudioMixerSnapshot DistortedSnapshot;
	}
}
