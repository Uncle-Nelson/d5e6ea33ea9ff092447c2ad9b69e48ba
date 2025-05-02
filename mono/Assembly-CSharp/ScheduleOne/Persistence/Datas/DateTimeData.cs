using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003D4 RID: 980
	[Serializable]
	public class DateTimeData : SaveData
	{
		// Token: 0x06001538 RID: 5432 RVA: 0x0005F524 File Offset: 0x0005D724
		public DateTimeData(DateTime date)
		{
			this.Year = date.Year;
			this.Month = date.Month;
			this.Day = date.Day;
			this.Hour = date.Hour;
			this.Minute = date.Minute;
			this.Second = date.Second;
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x0005F585 File Offset: 0x0005D785
		public DateTime GetDateTime()
		{
			return new DateTime(this.Year, this.Month, this.Day, this.Hour, this.Minute, this.Second);
		}

		// Token: 0x0400137A RID: 4986
		public int Year;

		// Token: 0x0400137B RID: 4987
		public int Month;

		// Token: 0x0400137C RID: 4988
		public int Day;

		// Token: 0x0400137D RID: 4989
		public int Hour;

		// Token: 0x0400137E RID: 4990
		public int Minute;

		// Token: 0x0400137F RID: 4991
		public int Second;
	}
}
