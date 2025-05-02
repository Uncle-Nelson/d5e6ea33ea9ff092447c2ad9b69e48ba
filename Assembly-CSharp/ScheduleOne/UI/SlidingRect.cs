using System;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A50 RID: 2640
	public class SlidingRect : MonoBehaviour
	{
		// Token: 0x06004724 RID: 18212 RVA: 0x0012A0B8 File Offset: 0x001282B8
		public void Update()
		{
			this._time += Time.deltaTime * this.SpeedMultiplier;
			if (this._time > this.Duration)
			{
				this._time -= this.Duration;
			}
			float t = this._time / this.Duration;
			this.Rect.anchoredPosition = Vector2.Lerp(this.Start, this.End, t);
		}

		// Token: 0x0400348F RID: 13455
		public RectTransform Rect;

		// Token: 0x04003490 RID: 13456
		public Vector2 Start;

		// Token: 0x04003491 RID: 13457
		public Vector2 End;

		// Token: 0x04003492 RID: 13458
		public float Duration = 1f;

		// Token: 0x04003493 RID: 13459
		public float SpeedMultiplier = 1f;

		// Token: 0x04003494 RID: 13460
		private float _time;
	}
}
