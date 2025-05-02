using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003EF RID: 1007
	[Serializable]
	public class LaunderOperationData : SaveData
	{
		// Token: 0x06001562 RID: 5474 RVA: 0x0005F922 File Offset: 0x0005DB22
		public LaunderOperationData(float amount, int minutesSinceStarted)
		{
			this.Amount = amount;
			this.MinutesSinceStarted = minutesSinceStarted;
		}

		// Token: 0x040013A6 RID: 5030
		public float Amount;

		// Token: 0x040013A7 RID: 5031
		public int MinutesSinceStarted;
	}
}
