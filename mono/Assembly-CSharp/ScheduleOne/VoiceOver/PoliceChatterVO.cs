using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.VoiceOver
{
	// Token: 0x02000275 RID: 629
	public class PoliceChatterVO : VOEmitter
	{
		// Token: 0x06000D1D RID: 3357 RVA: 0x0003A61B File Offset: 0x0003881B
		public override void Play(EVOLineType lineType)
		{
			if (lineType == EVOLineType.PoliceChatter)
			{
				this.PlayChatter();
				return;
			}
			base.Play(lineType);
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x0003A630 File Offset: 0x00038830
		private void PlayChatter()
		{
			if (this.chatterRoutine != null)
			{
				base.StopCoroutine(this.chatterRoutine);
			}
			this.chatterRoutine = base.StartCoroutine(this.<PlayChatter>g__Play|5_0());
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x0003A660 File Offset: 0x00038860
		[CompilerGenerated]
		private IEnumerator <PlayChatter>g__Play|5_0()
		{
			this.StartBeep.Play();
			this.Static.Play();
			yield return new WaitForSeconds(0.25f);
			base.Play(EVOLineType.PoliceChatter);
			yield return new WaitForSeconds(0.1f);
			yield return new WaitUntil(() => !this.audioSourceController.isPlaying);
			this.StartEndBeep.Play();
			this.Static.Stop();
			this.chatterRoutine = null;
			yield break;
		}

		// Token: 0x04000DBF RID: 3519
		public AudioSourceController StartBeep;

		// Token: 0x04000DC0 RID: 3520
		public AudioSourceController StartEndBeep;

		// Token: 0x04000DC1 RID: 3521
		public AudioSourceController Static;

		// Token: 0x04000DC2 RID: 3522
		private Coroutine chatterRoutine;
	}
}
