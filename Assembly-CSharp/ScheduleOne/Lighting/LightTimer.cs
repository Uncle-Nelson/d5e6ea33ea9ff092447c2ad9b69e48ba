using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Misc;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x020005A7 RID: 1447
	[RequireComponent(typeof(ToggleableLight))]
	public class LightTimer : MonoBehaviour
	{
		// Token: 0x060023DD RID: 9181 RVA: 0x00091AE5 File Offset: 0x0008FCE5
		protected virtual void Awake()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.UpdateState));
			this.toggleableLight = base.GetComponent<ToggleableLight>();
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x00091B1A File Offset: 0x0008FD1A
		private void Start()
		{
			this.UpdateState();
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x00091B22 File Offset: 0x0008FD22
		protected virtual void UpdateState()
		{
			this.SetState(NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(this.StartTime + this.StartTimeOffset, this.EndTime));
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x000045B1 File Offset: 0x000027B1
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x00091B47 File Offset: 0x0008FD47
		private void SetState(bool on)
		{
			this.toggleableLight.isOn = on;
		}

		// Token: 0x04001ABA RID: 6842
		[Header("Timing")]
		public int StartTime = 600;

		// Token: 0x04001ABB RID: 6843
		public int EndTime = 1800;

		// Token: 0x04001ABC RID: 6844
		public int StartTimeOffset;

		// Token: 0x04001ABD RID: 6845
		private ToggleableLight toggleableLight;
	}
}
