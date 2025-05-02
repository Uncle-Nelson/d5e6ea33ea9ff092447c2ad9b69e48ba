using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x0200079D RID: 1949
	public class AmbientOneShot : MonoBehaviour
	{
		// Token: 0x060034FB RID: 13563 RVA: 0x000DECDA File Offset: 0x000DCEDA
		private void Start()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x000DED04 File Offset: 0x000DCF04
		private void OnDrawGizmosSelected()
		{
			Gizmos.color = Color.green;
			Gizmos.DrawWireSphere(base.transform.position, this.MinDistance);
			Gizmos.color = Color.red;
			Gizmos.DrawWireSphere(base.transform.position, this.MaxDistance);
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x000DED54 File Offset: 0x000DCF54
		private void MinPass()
		{
			this.timeSinceLastPlay++;
			if (this.timeSinceLastPlay < this.CooldownTime)
			{
				return;
			}
			if (NetworkSingleton<TimeManager>.Instance.SleepInProgress)
			{
				return;
			}
			if (this.PlayTime == AmbientOneShot.EPlayTime.Day && NetworkSingleton<TimeManager>.Instance.IsNight)
			{
				return;
			}
			if (this.PlayTime == AmbientOneShot.EPlayTime.Night && !NetworkSingleton<TimeManager>.Instance.IsNight)
			{
				return;
			}
			float num = Vector3.Distance(base.transform.position, PlayerSingleton<PlayerCamera>.Instance.transform.position);
			if (num < this.MinDistance)
			{
				return;
			}
			if (num > this.MaxDistance)
			{
				return;
			}
			if (Random.value < this.ChancePerHour / 60f)
			{
				this.Play();
			}
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x000DEE04 File Offset: 0x000DD004
		private void Play()
		{
			this.timeSinceLastPlay = 0;
			this.Audio.SetVolume(this.Volume);
			this.Audio.Play();
		}

		// Token: 0x040025E3 RID: 9699
		public AudioSourceController Audio;

		// Token: 0x040025E4 RID: 9700
		[Header("Settings")]
		[Range(0f, 1f)]
		public float Volume = 0.2f;

		// Token: 0x040025E5 RID: 9701
		[Range(0f, 1f)]
		public float ChancePerHour = 0.2f;

		// Token: 0x040025E6 RID: 9702
		public int CooldownTime = 60;

		// Token: 0x040025E7 RID: 9703
		public AmbientOneShot.EPlayTime PlayTime;

		// Token: 0x040025E8 RID: 9704
		public float MinDistance = 20f;

		// Token: 0x040025E9 RID: 9705
		public float MaxDistance = 100f;

		// Token: 0x040025EA RID: 9706
		private int timeSinceLastPlay;

		// Token: 0x0200079E RID: 1950
		public enum EPlayTime
		{
			// Token: 0x040025EC RID: 9708
			All,
			// Token: 0x040025ED RID: 9709
			Day,
			// Token: 0x040025EE RID: 9710
			Night
		}
	}
}
