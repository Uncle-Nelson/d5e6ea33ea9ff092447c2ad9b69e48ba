using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006F8 RID: 1784
	public class PositionHistoryTracker : MonoBehaviour
	{
		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x0600307B RID: 12411 RVA: 0x000C9EC7 File Offset: 0x000C80C7
		public float RecordedTime
		{
			get
			{
				return (float)this.positionHistory.Count * this.recordingFrequency;
			}
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x000C9EDC File Offset: 0x000C80DC
		private void Start()
		{
			this.lastRecordTime = Time.time;
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x000C9EE9 File Offset: 0x000C80E9
		private void Update()
		{
			if (Time.time - this.lastRecordTime >= this.recordingFrequency)
			{
				this.RecordPosition();
				this.lastRecordTime = Time.time;
			}
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x000C9F10 File Offset: 0x000C8110
		private void RecordPosition()
		{
			this.positionHistory.Add(base.transform.position);
			if ((float)this.positionHistory.Count * this.recordingFrequency > this.historyDuration)
			{
				this.positionHistory.RemoveAt(0);
			}
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x000C9F50 File Offset: 0x000C8150
		public Vector3 GetPositionXSecondsAgo(float secondsAgo)
		{
			int num = (int)(secondsAgo / this.recordingFrequency);
			num = Mathf.Clamp(num, 0, this.positionHistory.Count - 1);
			return this.positionHistory[num];
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x000C9F88 File Offset: 0x000C8188
		public void ClearHistory()
		{
			this.positionHistory.Clear();
		}

		// Token: 0x04002274 RID: 8820
		[Tooltip("Frequency (in seconds) to record the position.")]
		public float recordingFrequency = 1f;

		// Token: 0x04002275 RID: 8821
		[Tooltip("Duration (in seconds) to store the position history.")]
		public float historyDuration = 10f;

		// Token: 0x04002276 RID: 8822
		public List<Vector3> positionHistory = new List<Vector3>();

		// Token: 0x04002277 RID: 8823
		private float lastRecordTime;
	}
}
