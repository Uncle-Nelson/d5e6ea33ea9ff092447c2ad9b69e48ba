using System;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.GameTime
{
	// Token: 0x020002A9 RID: 681
	[Serializable]
	public struct GameDateTime
	{
		// Token: 0x06000E41 RID: 3649 RVA: 0x0003FA4B File Offset: 0x0003DC4B
		public GameDateTime(int _elapsedDays, int _time)
		{
			this.elapsedDays = _elapsedDays;
			this.time = _time;
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0003FA5C File Offset: 0x0003DC5C
		public GameDateTime(int _minSum)
		{
			this.elapsedDays = _minSum / 1440;
			int minSum = _minSum % 1440;
			if (_minSum < 0)
			{
				minSum = -_minSum % 1440;
			}
			this.time = TimeManager.Get24HourTimeFromMinSum(minSum);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0003FA97 File Offset: 0x0003DC97
		public GameDateTime(GameDateTimeData data)
		{
			this.elapsedDays = data.ElapsedDays;
			this.time = data.Time;
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0003FAB1 File Offset: 0x0003DCB1
		public int GetMinSum()
		{
			return this.elapsedDays * 1440 + TimeManager.GetMinSumFrom24HourTime(this.time);
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0003FACB File Offset: 0x0003DCCB
		public GameDateTime AddMins(int mins)
		{
			return new GameDateTime(this.GetMinSum() + mins);
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0003FADA File Offset: 0x0003DCDA
		public static GameDateTime operator +(GameDateTime a, GameDateTime b)
		{
			return new GameDateTime(a.GetMinSum() + b.GetMinSum());
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0003FAF0 File Offset: 0x0003DCF0
		public static GameDateTime operator -(GameDateTime a, GameDateTime b)
		{
			return new GameDateTime(a.GetMinSum() - b.GetMinSum());
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x0003FB06 File Offset: 0x0003DD06
		public static bool operator >(GameDateTime a, GameDateTime b)
		{
			return a.GetMinSum() > b.GetMinSum();
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x0003FB18 File Offset: 0x0003DD18
		public static bool operator <(GameDateTime a, GameDateTime b)
		{
			return a.GetMinSum() < b.GetMinSum();
		}

		// Token: 0x04000EF4 RID: 3828
		public int elapsedDays;

		// Token: 0x04000EF5 RID: 3829
		public int time;
	}
}
