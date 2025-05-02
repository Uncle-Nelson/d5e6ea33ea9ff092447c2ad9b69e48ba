using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003ED RID: 1005
	[Serializable]
	public class WateringCanData : ItemData
	{
		// Token: 0x06001560 RID: 5472 RVA: 0x0005F911 File Offset: 0x0005DB11
		public WateringCanData(string iD, int quantity, float currentFillLevel) : base(iD, quantity)
		{
			this.CurrentFillAmount = currentFillLevel;
		}

		// Token: 0x040013A5 RID: 5029
		public float CurrentFillAmount;
	}
}
