using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x0200086F RID: 2159
	public class RandomIntervalEvent : MonoBehaviour
	{
		// Token: 0x06003AD0 RID: 15056 RVA: 0x000F79AB File Offset: 0x000F5BAB
		private void OnEnable()
		{
			if (this.ExecuteOnEnable)
			{
				this.Execute();
			}
			this.nextInterval = Time.time + Random.Range(this.MinInterval, this.MaxInterval);
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x000F79D8 File Offset: 0x000F5BD8
		private void Update()
		{
			if (Time.time >= this.nextInterval)
			{
				this.Execute();
			}
		}

		// Token: 0x06003AD2 RID: 15058 RVA: 0x000F79ED File Offset: 0x000F5BED
		private void Execute()
		{
			if (this.OnInterval != null)
			{
				this.OnInterval.Invoke();
			}
			this.nextInterval = Time.time + Random.Range(this.MinInterval, this.MaxInterval);
		}

		// Token: 0x04002A4E RID: 10830
		public float MinInterval = 5f;

		// Token: 0x04002A4F RID: 10831
		public float MaxInterval = 10f;

		// Token: 0x04002A50 RID: 10832
		public bool ExecuteOnEnable;

		// Token: 0x04002A51 RID: 10833
		public UnityEvent OnInterval;

		// Token: 0x04002A52 RID: 10834
		private float nextInterval;
	}
}
