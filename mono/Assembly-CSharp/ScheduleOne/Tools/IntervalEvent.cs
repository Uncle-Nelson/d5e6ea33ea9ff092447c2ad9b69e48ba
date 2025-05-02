using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000865 RID: 2149
	public class IntervalEvent : MonoBehaviour
	{
		// Token: 0x06003AA1 RID: 15009 RVA: 0x000F7150 File Offset: 0x000F5350
		public void Start()
		{
			base.InvokeRepeating("Execute", this.Interval, this.Interval);
		}

		// Token: 0x06003AA2 RID: 15010 RVA: 0x000F7169 File Offset: 0x000F5369
		private void Execute()
		{
			if (this.Event != null)
			{
				this.Event.Invoke();
			}
		}

		// Token: 0x04002A30 RID: 10800
		public float Interval = 1f;

		// Token: 0x04002A31 RID: 10801
		public UnityEvent Event;
	}
}
