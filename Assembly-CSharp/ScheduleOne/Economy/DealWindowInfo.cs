using System;

namespace ScheduleOne.Economy
{
	// Token: 0x02000676 RID: 1654
	public struct DealWindowInfo
	{
		// Token: 0x06002D9A RID: 11674 RVA: 0x000BEB8B File Offset: 0x000BCD8B
		public DealWindowInfo(int startTime, int endTime)
		{
			this.StartTime = startTime;
			this.EndTime = endTime;
		}

		// Token: 0x06002D9B RID: 11675 RVA: 0x000BEB9B File Offset: 0x000BCD9B
		public static DealWindowInfo GetWindowInfo(EDealWindow window)
		{
			switch (window)
			{
			case EDealWindow.Morning:
				return DealWindowInfo.Morning;
			case EDealWindow.Afternoon:
				return DealWindowInfo.Afternoon;
			case EDealWindow.Night:
				return DealWindowInfo.Night;
			case EDealWindow.LateNight:
				return DealWindowInfo.LateNight;
			default:
				return DealWindowInfo.Morning;
			}
		}

		// Token: 0x06002D9C RID: 11676 RVA: 0x000BEBD4 File Offset: 0x000BCDD4
		public static EDealWindow GetWindow(int time)
		{
			if (time >= DealWindowInfo.Morning.StartTime && time < DealWindowInfo.Morning.EndTime)
			{
				return EDealWindow.Morning;
			}
			if (time >= DealWindowInfo.Afternoon.StartTime && time < DealWindowInfo.Afternoon.EndTime)
			{
				return EDealWindow.Afternoon;
			}
			if (time >= DealWindowInfo.Night.StartTime && time < DealWindowInfo.Night.EndTime)
			{
				return EDealWindow.Night;
			}
			return EDealWindow.LateNight;
		}

		// Token: 0x04002059 RID: 8281
		public const int WINDOW_DURATION_MINS = 360;

		// Token: 0x0400205A RID: 8282
		public const int WINDOW_COUNT = 4;

		// Token: 0x0400205B RID: 8283
		public int StartTime;

		// Token: 0x0400205C RID: 8284
		public int EndTime;

		// Token: 0x0400205D RID: 8285
		public static readonly DealWindowInfo Morning = new DealWindowInfo(600, 1200);

		// Token: 0x0400205E RID: 8286
		public static readonly DealWindowInfo Afternoon = new DealWindowInfo(1200, 1800);

		// Token: 0x0400205F RID: 8287
		public static readonly DealWindowInfo Night = new DealWindowInfo(1800, 2400);

		// Token: 0x04002060 RID: 8288
		public static readonly DealWindowInfo LateNight = new DealWindowInfo(0, 600);
	}
}
