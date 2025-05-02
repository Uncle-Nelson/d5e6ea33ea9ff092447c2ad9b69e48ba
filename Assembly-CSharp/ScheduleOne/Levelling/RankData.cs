using System;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Levelling
{
	// Token: 0x020005B3 RID: 1459
	public class RankData : SaveData
	{
		// Token: 0x06002444 RID: 9284 RVA: 0x00093159 File Offset: 0x00091359
		public RankData(int rank, int tier, int xp, int totalXP)
		{
			this.Rank = rank;
			this.Tier = tier;
			this.XP = xp;
			this.TotalXP = totalXP;
		}

		// Token: 0x04001B02 RID: 6914
		public int Rank;

		// Token: 0x04001B03 RID: 6915
		public int Tier;

		// Token: 0x04001B04 RID: 6916
		public int XP;

		// Token: 0x04001B05 RID: 6917
		public int TotalXP;
	}
}
