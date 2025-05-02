using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x020007A3 RID: 1955
	public class AudioZone : Zone
	{
		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x0600352F RID: 13615 RVA: 0x000DF97C File Offset: 0x000DDB7C
		// (set) Token: 0x06003530 RID: 13616 RVA: 0x000DF984 File Offset: 0x000DDB84
		public float VolumeModifier { get; set; }

		// Token: 0x06003531 RID: 13617 RVA: 0x000DF990 File Offset: 0x000DDB90
		private void Start()
		{
			foreach (AudioZone.Track track in this.Tracks)
			{
				track.Init();
			}
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x000DFA08 File Offset: 0x000DDC08
		private void Update()
		{
			this.VolumeModifier = Mathf.MoveTowards(this.VolumeModifier, this.GetFalloffFactor(base.LocalPlayerDistance), 1f * Time.deltaTime);
			this.CurrentVolumeMultiplier = Mathf.MoveTowards(this.CurrentVolumeMultiplier, this.GetTotalVolumeMultiplier(), 1f * Time.deltaTime);
			foreach (AudioZone.Track track in this.Tracks)
			{
				track.Update(this.VolumeModifier * this.CurrentVolumeMultiplier);
			}
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x000DFAB0 File Offset: 0x000DDCB0
		private float GetTotalVolumeMultiplier()
		{
			float num = 1f;
			foreach (KeyValuePair<AudioZoneModifierVolume, float> keyValuePair in this.Modifiers)
			{
				num *= keyValuePair.Value;
			}
			return num;
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x000DFB10 File Offset: 0x000DDD10
		private void MinPass()
		{
			foreach (AudioZone.Track track in this.Tracks)
			{
				track.UpdateTimeMultiplier(NetworkSingleton<TimeManager>.Instance.CurrentTime);
			}
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x000DFB6C File Offset: 0x000DDD6C
		public void AddModifier(AudioZoneModifierVolume modifier, float value)
		{
			if (!this.Modifiers.ContainsKey(modifier))
			{
				this.Modifiers.Add(modifier, value);
			}
			this.Modifiers[modifier] = value;
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x000DFB96 File Offset: 0x000DDD96
		public void RemoveModifier(AudioZoneModifierVolume modifier)
		{
			if (this.Modifiers.ContainsKey(modifier))
			{
				this.Modifiers.Remove(modifier);
			}
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x000DFBB3 File Offset: 0x000DDDB3
		private float GetFalloffFactor(float distance)
		{
			if (distance > this.MaxDistance)
			{
				return 0f;
			}
			return 1f / (1f + 0.5f * distance);
		}

		// Token: 0x04002620 RID: 9760
		public const float VOLUME_CHANGE_RATE = 1f;

		// Token: 0x04002621 RID: 9761
		public const float ROLLOFF_SCALE = 0.5f;

		// Token: 0x04002622 RID: 9762
		[Header("Settings")]
		[Range(1f, 200f)]
		public float MaxDistance = 100f;

		// Token: 0x04002623 RID: 9763
		public List<AudioZone.Track> Tracks = new List<AudioZone.Track>();

		// Token: 0x04002624 RID: 9764
		public Dictionary<AudioZoneModifierVolume, float> Modifiers = new Dictionary<AudioZoneModifierVolume, float>();

		// Token: 0x04002626 RID: 9766
		protected float CurrentVolumeMultiplier = 1f;

		// Token: 0x020007A4 RID: 1956
		[Serializable]
		public class Track
		{
			// Token: 0x06003539 RID: 13625 RVA: 0x000DFC0C File Offset: 0x000DDE0C
			public void Init()
			{
				this.fadeInStart = TimeManager.AddMinutesTo24HourTime(this.StartTime, -this.FadeTime / 2);
				this.fadeInEnd = TimeManager.AddMinutesTo24HourTime(this.StartTime, this.FadeTime / 2);
				this.fadeOutStart = TimeManager.AddMinutesTo24HourTime(this.EndTime, -this.FadeTime / 2);
				this.fadeOutEnd = TimeManager.AddMinutesTo24HourTime(this.EndTime, this.FadeTime / 2);
				this.fadeInStartMinSum = TimeManager.GetMinSumFrom24HourTime(this.fadeInStart);
				this.fadeInEndMinSum = TimeManager.GetMinSumFrom24HourTime(this.fadeInEnd);
				this.fadeOutStartMinSum = TimeManager.GetMinSumFrom24HourTime(this.fadeOutStart);
				this.fadeOutEndMinSum = TimeManager.GetMinSumFrom24HourTime(this.fadeOutEnd);
			}

			// Token: 0x0600353A RID: 13626 RVA: 0x000DFCC4 File Offset: 0x000DDEC4
			public void Update(float multiplier)
			{
				float num = this.Volume * multiplier * this.timeVolMultiplier;
				this.Source.SetVolume(num);
				if (num > 0f)
				{
					if (!this.Source.isPlaying)
					{
						this.Source.Play();
						return;
					}
				}
				else if (this.Source.isPlaying)
				{
					this.Source.Stop();
				}
			}

			// Token: 0x0600353B RID: 13627 RVA: 0x000DFD28 File Offset: 0x000DDF28
			public void UpdateTimeMultiplier(int time)
			{
				int minSumFrom24HourTime = TimeManager.GetMinSumFrom24HourTime(time);
				if (TimeManager.IsGivenTimeWithinRange(time, this.fadeInEnd, this.fadeOutStart))
				{
					this.timeVolMultiplier = 1f;
					return;
				}
				if (TimeManager.IsGivenTimeWithinRange(time, this.fadeInStart, this.fadeInEnd))
				{
					this.timeVolMultiplier = (float)(minSumFrom24HourTime - this.fadeInStartMinSum) / (float)(this.fadeInEndMinSum - this.fadeInStartMinSum);
					return;
				}
				if (TimeManager.IsGivenTimeWithinRange(time, this.fadeOutStart, this.fadeOutEnd))
				{
					this.timeVolMultiplier = 1f - (float)(minSumFrom24HourTime - this.fadeOutStartMinSum) / (float)(this.fadeOutEndMinSum - this.fadeOutStartMinSum);
					return;
				}
				this.timeVolMultiplier = 0f;
			}

			// Token: 0x04002627 RID: 9767
			public AudioSourceController Source;

			// Token: 0x04002628 RID: 9768
			[Range(0.01f, 2f)]
			public float Volume = 1f;

			// Token: 0x04002629 RID: 9769
			public int StartTime;

			// Token: 0x0400262A RID: 9770
			public int EndTime;

			// Token: 0x0400262B RID: 9771
			public int FadeTime = 60;

			// Token: 0x0400262C RID: 9772
			private float timeVolMultiplier;

			// Token: 0x0400262D RID: 9773
			private int fadeInStart;

			// Token: 0x0400262E RID: 9774
			private int fadeInEnd;

			// Token: 0x0400262F RID: 9775
			private int fadeOutStart;

			// Token: 0x04002630 RID: 9776
			private int fadeOutEnd;

			// Token: 0x04002631 RID: 9777
			private int fadeInStartMinSum;

			// Token: 0x04002632 RID: 9778
			private int fadeInEndMinSum;

			// Token: 0x04002633 RID: 9779
			private int fadeOutStartMinSum;

			// Token: 0x04002634 RID: 9780
			private int fadeOutEndMinSum;
		}
	}
}
