using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

namespace ScheduleOne.Audio
{
	// Token: 0x020007B2 RID: 1970
	public class MusicPlayer : PersistentSingleton<MusicPlayer>
	{
		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06003563 RID: 13667 RVA: 0x000E0739 File Offset: 0x000DE939
		public bool IsPlaying
		{
			get
			{
				return this._currentTrack != null && this._currentTrack.IsPlaying;
			}
		}

		// Token: 0x06003564 RID: 13668 RVA: 0x000E0758 File Offset: 0x000DE958
		public void OnValidate()
		{
			this.Tracks = new List<MusicTrack>(base.GetComponentsInChildren<MusicTrack>());
			for (int i = 0; i < this.Tracks.Count - 1; i++)
			{
				if (this.Tracks[i].Priority > this.Tracks[i + 1].Priority)
				{
					this.Tracks[i].transform.SetSiblingIndex(i + 1);
				}
			}
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x000E07D0 File Offset: 0x000DE9D0
		protected override void Start()
		{
			base.Start();
			if (Singleton<MusicPlayer>.Instance == null || Singleton<MusicPlayer>.Instance != this)
			{
				return;
			}
			base.InvokeRepeating("UpdateTracks", 0f, 0.2f);
			Singleton<LoadManager>.Instance.onPreSceneChange.AddListener(new UnityAction(delegate()
			{
				this.SetMusicDistorted(false, 0.5f);
			}));
			this.DefaultSnapshot.TransitionTo(0.1f);
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x000E083E File Offset: 0x000DEA3E
		private void Update()
		{
			MusicPlayer.TimeSinceLastAmbientTrack += Time.unscaledDeltaTime;
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x000E0850 File Offset: 0x000DEA50
		public void SetMusicDistorted(bool distorted, float transition = 5f)
		{
			if (distorted)
			{
				this.DistortedSnapshot.TransitionTo(transition);
				return;
			}
			this.DefaultSnapshot.TransitionTo(transition);
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x000E0870 File Offset: 0x000DEA70
		public void SetTrackEnabled(string trackName, bool enabled)
		{
			MusicTrack musicTrack = this.Tracks.Find((MusicTrack t) => t.TrackName == trackName);
			if (musicTrack == null)
			{
				Console.LogWarning("Music track not found: " + trackName, null);
				return;
			}
			if (enabled)
			{
				musicTrack.Enable();
				return;
			}
			musicTrack.Disable();
		}

		// Token: 0x06003569 RID: 13673 RVA: 0x000E08D4 File Offset: 0x000DEAD4
		public void StopTrack(string trackName)
		{
			MusicTrack musicTrack = this.Tracks.Find((MusicTrack t) => t.TrackName == trackName);
			if (musicTrack == null)
			{
				Console.LogWarning("Music track not found: " + trackName, null);
				return;
			}
			musicTrack.Stop();
		}

		// Token: 0x0600356A RID: 13674 RVA: 0x000E092C File Offset: 0x000DEB2C
		public void StopAndDisableTracks()
		{
			foreach (MusicTrack musicTrack in this.Tracks)
			{
				musicTrack.Disable();
				musicTrack.Stop();
			}
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x000E0984 File Offset: 0x000DEB84
		private void UpdateTracks()
		{
			if (this._currentTrack != null && !this._currentTrack.IsPlaying)
			{
				this._currentTrack = null;
			}
			MusicTrack musicTrack = null;
			foreach (MusicTrack musicTrack2 in this.Tracks)
			{
				if (musicTrack2.Enabled && (musicTrack == null || musicTrack2.Priority > musicTrack.Priority))
				{
					musicTrack = musicTrack2;
				}
			}
			if (this._currentTrack != musicTrack && musicTrack != null)
			{
				if (this._currentTrack != null)
				{
					this._currentTrack.Stop();
				}
				this._currentTrack = musicTrack;
				if (this._currentTrack != null)
				{
					this._currentTrack.Play();
				}
			}
		}

		// Token: 0x04002666 RID: 9830
		public static float TimeSinceLastAmbientTrack = 100000f;

		// Token: 0x04002667 RID: 9831
		public List<MusicTrack> Tracks = new List<MusicTrack>();

		// Token: 0x04002668 RID: 9832
		public AudioMixerGroup MusicMixer;

		// Token: 0x04002669 RID: 9833
		public AudioMixerSnapshot DefaultSnapshot;

		// Token: 0x0400266A RID: 9834
		public AudioMixerSnapshot DistortedSnapshot;

		// Token: 0x0400266B RID: 9835
		private MusicTrack _currentTrack;
	}
}
