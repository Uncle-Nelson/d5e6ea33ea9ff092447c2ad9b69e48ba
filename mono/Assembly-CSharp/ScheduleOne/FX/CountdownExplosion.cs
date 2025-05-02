using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet;
using ScheduleOne.Audio;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.FX
{
	// Token: 0x0200061C RID: 1564
	public class CountdownExplosion : MonoBehaviour
	{
		// Token: 0x06002901 RID: 10497 RVA: 0x000A9289 File Offset: 0x000A7489
		public void Trigger()
		{
			this.countdownRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(this.<Trigger>g__Routine|5_0());
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x000A92A1 File Offset: 0x000A74A1
		public void StopCountdown()
		{
			if (this.countdownRoutine != null)
			{
				base.StopCoroutine(this.countdownRoutine);
			}
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x000A92B7 File Offset: 0x000A74B7
		[CompilerGenerated]
		private IEnumerator <Trigger>g__Routine|5_0()
		{
			float timeUntilNextTick = 1f;
			for (float i = 0f; i < 30f; i += Time.deltaTime)
			{
				timeUntilNextTick -= Time.deltaTime;
				if (timeUntilNextTick <= 0f)
				{
					timeUntilNextTick = Mathf.Lerp(1f, 0.1f, i / 30f);
					this.TickSound.PitchMultiplier = Mathf.Lerp(1f, 1.1f, i / 30f);
					this.TickSound.VolumeMultiplier = Mathf.Lerp(0.6f, 1f, i / 30f);
					this.TickSound.Play();
				}
				yield return new WaitForEndOfFrame();
			}
			if (InstanceFinder.IsServer)
			{
				NetworkSingleton<CombatManager>.Instance.CreateExplosion(base.transform.position, ExplosionData.DefaultSmall);
			}
			this.countdownRoutine = null;
			yield break;
		}

		// Token: 0x04001E21 RID: 7713
		public const float COUNTDOWN = 30f;

		// Token: 0x04001E22 RID: 7714
		public const float TICK_SPACING_MAX = 1f;

		// Token: 0x04001E23 RID: 7715
		public const float TICK_SPACING_MIN = 0.1f;

		// Token: 0x04001E24 RID: 7716
		public AudioSourceController TickSound;

		// Token: 0x04001E25 RID: 7717
		private Coroutine countdownRoutine;
	}
}
