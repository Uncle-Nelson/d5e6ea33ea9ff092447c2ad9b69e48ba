using System;
using System.Collections.Generic;
using EasyButtons;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x0200079F RID: 1951
	public class AmbientTrack : MonoBehaviour
	{
		// Token: 0x06003500 RID: 13568 RVA: 0x000DEE68 File Offset: 0x000DD068
		private void Awake()
		{
			for (int i = 0; i < this.Tracks.Count; i++)
			{
				int index = Random.Range(i, this.Tracks.Count);
				MusicTrack value = this.Tracks[index];
				this.Tracks[index] = this.Tracks[i];
				this.Tracks[i] = value;
			}
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x000DEED0 File Offset: 0x000DD0D0
		[Button]
		public void ForcePlay()
		{
			AmbientTrack.LastPlayedTrack = this;
			MusicPlayer.TimeSinceLastAmbientTrack = 0f;
			this.playTrack = false;
			AmbientTrack.TrackQueued = false;
			this.Tracks[0].Enable();
			this.Tracks.Add(this.Tracks[0]);
			this.Tracks.RemoveAt(0);
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x000DEF2E File Offset: 0x000DD12E
		public void Stop()
		{
			this.Tracks[0].Disable();
			this.Tracks[0].Stop();
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x000DEF54 File Offset: 0x000DD154
		private void Update()
		{
			if (!NetworkSingleton<TimeManager>.InstanceExists)
			{
				this.trackRandomized = false;
				AmbientTrack.TrackQueued = false;
				return;
			}
			int currentTime = NetworkSingleton<TimeManager>.Instance.CurrentTime;
			if (NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(this.MinTime, this.MaxTime))
			{
				if (!this.trackRandomized)
				{
					this.playTrack = (Random.value < this.Chance && MusicPlayer.TimeSinceLastAmbientTrack > 540f && AmbientTrack.LastPlayedTrack != this && !AmbientTrack.TrackQueued && this.Tracks.Count > 0 && Time.timeSinceLevelLoad > 20f && !GameManager.IS_TUTORIAL);
					this.startTime = TimeManager.AddMinutesTo24HourTime(currentTime, Random.Range(0, 120));
					if (this.playTrack)
					{
						Console.Log("Will play " + this.Tracks[0].TrackName + " at " + this.startTime.ToString(), null);
						AmbientTrack.TrackQueued = true;
						MusicPlayer.TimeSinceLastAmbientTrack = 0f;
					}
					this.trackRandomized = true;
				}
				if (this.playTrack && !this.Tracks[0].Enabled && NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(this.startTime, this.MaxTime))
				{
					AmbientTrack.LastPlayedTrack = this;
					MusicPlayer.TimeSinceLastAmbientTrack = 0f;
					this.playTrack = false;
					AmbientTrack.TrackQueued = false;
					this.Tracks[0].Enable();
					this.Tracks.Add(this.Tracks[0]);
					this.Tracks.RemoveAt(0);
					return;
				}
			}
			else
			{
				this.trackRandomized = false;
				this.playTrack = false;
				foreach (MusicTrack musicTrack in this.Tracks)
				{
					musicTrack.Disable();
				}
			}
		}

		// Token: 0x040025EF RID: 9711
		public const float MIN_TIME_BETWEEN_AMBIENT_TRACKS = 540f;

		// Token: 0x040025F0 RID: 9712
		public static AmbientTrack LastPlayedTrack;

		// Token: 0x040025F1 RID: 9713
		public static bool TrackQueued;

		// Token: 0x040025F2 RID: 9714
		public List<MusicTrack> Tracks = new List<MusicTrack>();

		// Token: 0x040025F3 RID: 9715
		public int MinTime;

		// Token: 0x040025F4 RID: 9716
		public int MaxTime;

		// Token: 0x040025F5 RID: 9717
		public float Chance = 0.3f;

		// Token: 0x040025F6 RID: 9718
		private int startTime;

		// Token: 0x040025F7 RID: 9719
		private bool playTrack;

		// Token: 0x040025F8 RID: 9720
		private bool trackRandomized;
	}
}
