using System;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.VoiceOver
{
	// Token: 0x02000279 RID: 633
	[RequireComponent(typeof(AudioSourceController))]
	public class VOEmitter : MonoBehaviour
	{
		// Token: 0x06000D2E RID: 3374 RVA: 0x0003A8A0 File Offset: 0x00038AA0
		protected virtual void Awake()
		{
			this.audioSourceController = base.GetComponent<AudioSourceController>();
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x0003A8B0 File Offset: 0x00038AB0
		public virtual void Play(EVOLineType lineType)
		{
			if (!this.audioSourceController.gameObject.activeInHierarchy)
			{
				return;
			}
			if (this.Database == null)
			{
				Console.LogError("Database is not set on VOEmitter.", null);
				return;
			}
			AudioClip randomClip = this.Database.GetRandomClip(lineType);
			if (randomClip == null)
			{
				Console.LogError("No clip found for line type: " + lineType.ToString(), null);
				return;
			}
			this.audioSourceController.Stop();
			this.audioSourceController.AudioSource.clip = randomClip;
			this.audioSourceController.VolumeMultiplier = this.Database.VolumeMultiplier * this.Database.GetEntry(lineType).VolumeMultiplier;
			this.audioSourceController.PitchMultiplier = (this.PitchMultiplier + Random.Range(-0.05f, 0.05f)) * this.runtimePitchMultiplier;
			this.audioSourceController.Play();
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x0003A995 File Offset: 0x00038B95
		public void SetRuntimePitchMultiplier(float pitchMultiplier)
		{
			this.runtimePitchMultiplier = pitchMultiplier;
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x0003A99E File Offset: 0x00038B9E
		public void SetDatabase(VODatabase database, bool writeDefault = true)
		{
			this.Database = database;
			if (writeDefault)
			{
				this.defaultVODatabase = database;
			}
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x0003A9B1 File Offset: 0x00038BB1
		public void ResetDatabase()
		{
			this.SetDatabase(this.defaultVODatabase, false);
		}

		// Token: 0x04000DCC RID: 3532
		public const float PitchVariation = 0.05f;

		// Token: 0x04000DCD RID: 3533
		[SerializeField]
		private VODatabase Database;

		// Token: 0x04000DCE RID: 3534
		[Range(0.5f, 2f)]
		public float PitchMultiplier = 1f;

		// Token: 0x04000DCF RID: 3535
		private float runtimePitchMultiplier = 1f;

		// Token: 0x04000DD0 RID: 3536
		protected AudioSourceController audioSourceController;

		// Token: 0x04000DD1 RID: 3537
		private VODatabase defaultVODatabase;
	}
}
