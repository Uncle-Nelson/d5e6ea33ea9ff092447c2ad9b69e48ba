using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000438 RID: 1080
	[Serializable]
	public class TimeData : SaveData
	{
		// Token: 0x060015B4 RID: 5556 RVA: 0x0006045E File Offset: 0x0005E65E
		public TimeData(int timeOfDay, int elapsedDays, int playtime)
		{
			this.TimeOfDay = timeOfDay;
			this.ElapsedDays = elapsedDays;
			this.Playtime = playtime;
		}

		// Token: 0x04001470 RID: 5232
		public int TimeOfDay;

		// Token: 0x04001471 RID: 5233
		public int ElapsedDays;

		// Token: 0x04001472 RID: 5234
		public int Playtime;
	}
}
