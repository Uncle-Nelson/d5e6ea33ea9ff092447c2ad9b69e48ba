using System;
using ScheduleOne.GameTime;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003D8 RID: 984
	[Serializable]
	public class GameDateTimeData : SaveData
	{
		// Token: 0x0600153E RID: 5438 RVA: 0x0005F613 File Offset: 0x0005D813
		public GameDateTimeData(int _elapsedDays, int _time)
		{
			this.ElapsedDays = _elapsedDays;
			this.Time = _time;
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x0005F629 File Offset: 0x0005D829
		public GameDateTimeData(GameDateTime gameDateTime)
		{
			this.ElapsedDays = gameDateTime.elapsedDays;
			this.Time = gameDateTime.time;
		}

		// Token: 0x04001387 RID: 4999
		public int ElapsedDays;

		// Token: 0x04001388 RID: 5000
		public int Time;
	}
}
