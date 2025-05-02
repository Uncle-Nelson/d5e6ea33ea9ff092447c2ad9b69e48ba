using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x020005C9 RID: 1481
	[Serializable]
	public class CurfewInstance
	{
		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x0600248B RID: 9355 RVA: 0x000937BD File Offset: 0x000919BD
		// (set) Token: 0x0600248C RID: 9356 RVA: 0x000937C5 File Offset: 0x000919C5
		public bool Enabled { get; protected set; }

		// Token: 0x0600248D RID: 9357 RVA: 0x000937CE File Offset: 0x000919CE
		public void Evaluate(bool ignoreSleepReq = false)
		{
			if (this.Enabled)
			{
				return;
			}
			if (Singleton<LawController>.Instance.LE_Intensity >= this.IntensityRequirement && (NetworkSingleton<TimeManager>.Instance.SleepInProgress || ignoreSleepReq))
			{
				this.Enable();
			}
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x000937FF File Offset: 0x000919FF
		private void MinPass()
		{
			if (this.Enabled)
			{
				if (Singleton<LawController>.Instance.LE_Intensity < this.IntensityRequirement)
				{
					this.shouldDisable = true;
				}
				if (this.shouldDisable && NetworkSingleton<TimeManager>.Instance.SleepInProgress)
				{
					this.Disable();
				}
			}
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x0009383C File Offset: 0x00091A3C
		public void Enable()
		{
			CurfewInstance.ActiveInstance = this;
			this.Enabled = true;
			this.shouldDisable = false;
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
			NetworkSingleton<CurfewManager>.Instance.Enable(null);
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x00093890 File Offset: 0x00091A90
		public void Disable()
		{
			this.Enabled = false;
			this.shouldDisable = false;
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			if (CurfewInstance.ActiveInstance == this)
			{
				NetworkSingleton<CurfewManager>.Instance.Disable();
			}
		}

		// Token: 0x04001B2C RID: 6956
		public static CurfewInstance ActiveInstance;

		// Token: 0x04001B2D RID: 6957
		[Range(1f, 10f)]
		public int IntensityRequirement = 5;

		// Token: 0x04001B2F RID: 6959
		[HideInInspector]
		public bool shouldDisable;
	}
}
