using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;

namespace ScheduleOne.Misc
{
	// Token: 0x02000C08 RID: 3080
	public class ManholeCover : MonoBehaviour
	{
		// Token: 0x0600569E RID: 22174 RVA: 0x0016C2D8 File Offset: 0x0016A4D8
		private void Start()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
		}

		// Token: 0x0600569F RID: 22175 RVA: 0x0016C300 File Offset: 0x0016A500
		private void MinPass()
		{
			Color startColor = this.SteamColor.Evaluate((float)NetworkSingleton<TimeManager>.Instance.DailyMinTotal / 1440f);
			startColor.a = this.SteamAlpha.Evaluate((float)NetworkSingleton<TimeManager>.Instance.DailyMinTotal / 1440f);
			this.SteamParticles.startColor = startColor;
		}

		// Token: 0x04003FFE RID: 16382
		public ParticleSystem SteamParticles;

		// Token: 0x04003FFF RID: 16383
		public Gradient SteamColor;

		// Token: 0x04004000 RID: 16384
		public AnimationCurve SteamAlpha;
	}
}
