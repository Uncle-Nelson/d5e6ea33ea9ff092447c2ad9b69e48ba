using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003E2 RID: 994
	[Serializable]
	public class CashData : ItemData
	{
		// Token: 0x06001555 RID: 5461 RVA: 0x0005F869 File Offset: 0x0005DA69
		public CashData(string iD, int quantity, float cashBalance) : base(iD, quantity)
		{
			this.CashBalance = cashBalance;
		}

		// Token: 0x0400139A RID: 5018
		public float CashBalance;
	}
}
