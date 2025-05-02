using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000407 RID: 1031
	[Serializable]
	public class MoneyData : SaveData
	{
		// Token: 0x0600157B RID: 5499 RVA: 0x0005FB22 File Offset: 0x0005DD22
		public MoneyData(float onlineBalance, float netWorth, float lifetimeEarnings, float weeklyDepositSum)
		{
			this.OnlineBalance = onlineBalance;
			this.Networth = netWorth;
			this.LifetimeEarnings = lifetimeEarnings;
			this.WeeklyDepositSum = weeklyDepositSum;
		}

		// Token: 0x040013D3 RID: 5075
		public float OnlineBalance;

		// Token: 0x040013D4 RID: 5076
		public float Networth;

		// Token: 0x040013D5 RID: 5077
		public float LifetimeEarnings;

		// Token: 0x040013D6 RID: 5078
		public float WeeklyDepositSum;
	}
}
