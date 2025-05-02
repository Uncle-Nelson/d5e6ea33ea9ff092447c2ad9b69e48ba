using System;
using UnityEngine;

namespace ScheduleOne.VoiceOver
{
	// Token: 0x02000278 RID: 632
	[Serializable]
	public class VODatabaseEntry
	{
		// Token: 0x06000D2C RID: 3372 RVA: 0x0003A81C File Offset: 0x00038A1C
		public AudioClip GetRandomClip()
		{
			if (this.Clips.Length == 0)
			{
				return null;
			}
			AudioClip audioClip = this.Clips[Random.Range(0, this.Clips.Length)];
			int num = 0;
			while (audioClip == this.lastClip && this.Clips.Length != 1 && num <= 5)
			{
				audioClip = this.Clips[Random.Range(0, this.Clips.Length)];
				num++;
			}
			this.lastClip = audioClip;
			return audioClip;
		}

		// Token: 0x04000DC8 RID: 3528
		public EVOLineType LineType;

		// Token: 0x04000DC9 RID: 3529
		public AudioClip[] Clips;

		// Token: 0x04000DCA RID: 3530
		private AudioClip lastClip;

		// Token: 0x04000DCB RID: 3531
		public float VolumeMultiplier = 1f;
	}
}
