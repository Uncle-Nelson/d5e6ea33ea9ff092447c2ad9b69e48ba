using System;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.GameTime
{
	// Token: 0x020002A8 RID: 680
	public class AnalogueClock : MonoBehaviour
	{
		// Token: 0x06000E3D RID: 3645 RVA: 0x0003F900 File Offset: 0x0003DB00
		public void Start()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			TimeManager instance2 = NetworkSingleton<TimeManager>.Instance;
			instance2.onMinutePass = (Action)Delegate.Combine(instance2.onMinutePass, new Action(this.MinPass));
			this.MinPass();
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0003F95F File Offset: 0x0003DB5F
		private void OnDestroy()
		{
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			}
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0003F990 File Offset: 0x0003DB90
		public void MinPass()
		{
			int currentTime = NetworkSingleton<TimeManager>.Instance.CurrentTime;
			int minSumFrom24HourTime = TimeManager.GetMinSumFrom24HourTime(currentTime);
			float num = (float)(minSumFrom24HourTime % 60);
			float num2 = (float)(minSumFrom24HourTime / 60);
			float num3 = num / 60f * 360f;
			float d = num2 / 12f * 360f + num3 / 12f;
			if (currentTime == 1200 && this.onNoon != null)
			{
				this.onNoon.Invoke();
			}
			if (currentTime == 0 && this.onMidnight != null)
			{
				this.onMidnight.Invoke();
			}
			this.MinHand.localEulerAngles = this.RotationAxis * num3;
			this.HourHand.localEulerAngles = this.RotationAxis * d;
		}

		// Token: 0x04000EEF RID: 3823
		public Transform MinHand;

		// Token: 0x04000EF0 RID: 3824
		public Transform HourHand;

		// Token: 0x04000EF1 RID: 3825
		public Vector3 RotationAxis = Vector3.forward;

		// Token: 0x04000EF2 RID: 3826
		public UnityEvent onNoon;

		// Token: 0x04000EF3 RID: 3827
		public UnityEvent onMidnight;
	}
}
