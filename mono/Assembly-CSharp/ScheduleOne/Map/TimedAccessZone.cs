using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000C35 RID: 3125
	public class TimedAccessZone : AccessZone
	{
		// Token: 0x06005790 RID: 22416 RVA: 0x0016F75D File Offset: 0x0016D95D
		protected virtual void Start()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
		}

		// Token: 0x06005791 RID: 22417 RVA: 0x0016F786 File Offset: 0x0016D986
		protected virtual void MinPass()
		{
			this.SetIsOpen(this.GetIsOpen());
		}

		// Token: 0x06005792 RID: 22418 RVA: 0x0016F794 File Offset: 0x0016D994
		protected virtual bool GetIsOpen()
		{
			return NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(this.OpenTime, this.CloseTime);
		}

		// Token: 0x040040DC RID: 16604
		[Header("Timing Settings")]
		public int OpenTime = 600;

		// Token: 0x040040DD RID: 16605
		public int CloseTime = 1800;
	}
}
