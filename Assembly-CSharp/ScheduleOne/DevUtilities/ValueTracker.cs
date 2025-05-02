using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.GameTime;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006FC RID: 1788
	public class ValueTracker
	{
		// Token: 0x06003090 RID: 12432 RVA: 0x000CA13E File Offset: 0x000C833E
		public ValueTracker(float HistoryDuration)
		{
			this.historyDuration = HistoryDuration;
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onUpdate = (Action)Delegate.Combine(instance.onUpdate, new Action(this.Update));
		}

		// Token: 0x06003091 RID: 12433 RVA: 0x000CA17E File Offset: 0x000C837E
		public void Destroy()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onUpdate = (Action)Delegate.Remove(instance.onUpdate, new Action(this.Update));
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x000CA1A8 File Offset: 0x000C83A8
		public void Update()
		{
			int num = 0;
			while (num < this.valueHistory.Count && Time.timeSinceLevelLoad - this.valueHistory[num].time > this.historyDuration)
			{
				this.valueHistory.RemoveAt(num);
				num--;
				num++;
			}
		}

		// Token: 0x06003093 RID: 12435 RVA: 0x000CA1FA File Offset: 0x000C83FA
		public void SubmitValue(float value)
		{
			this.valueHistory.Add(new ValueTracker.Value(value, Time.timeSinceLevelLoad));
		}

		// Token: 0x06003094 RID: 12436 RVA: 0x000CA212 File Offset: 0x000C8412
		public float RecordedHistoryLength()
		{
			if (this.valueHistory.Count == 0)
			{
				return 0f;
			}
			return Time.timeSinceLevelLoad - this.valueHistory[0].time;
		}

		// Token: 0x06003095 RID: 12437 RVA: 0x000CA240 File Offset: 0x000C8440
		public float GetLowestValue()
		{
			ValueTracker.Value value = (from x in this.valueHistory
			orderby x.val
			select x).FirstOrDefault<ValueTracker.Value>();
			if (value != null)
			{
				return value.val;
			}
			return 0f;
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x000CA28C File Offset: 0x000C848C
		public float GetAverageValue()
		{
			if (this.valueHistory.Count == 0)
			{
				return 0f;
			}
			float num = 0f;
			foreach (ValueTracker.Value value in this.valueHistory)
			{
				num += value.val;
			}
			num /= (float)this.valueHistory.Count;
			return num;
		}

		// Token: 0x04002285 RID: 8837
		private float historyDuration;

		// Token: 0x04002286 RID: 8838
		private List<ValueTracker.Value> valueHistory = new List<ValueTracker.Value>();

		// Token: 0x020006FD RID: 1789
		public class Value
		{
			// Token: 0x06003097 RID: 12439 RVA: 0x000CA30C File Offset: 0x000C850C
			public Value(float val, float time)
			{
				this.val = val;
				this.time = time;
			}

			// Token: 0x04002287 RID: 8839
			public float val;

			// Token: 0x04002288 RID: 8840
			public float time;
		}
	}
}
