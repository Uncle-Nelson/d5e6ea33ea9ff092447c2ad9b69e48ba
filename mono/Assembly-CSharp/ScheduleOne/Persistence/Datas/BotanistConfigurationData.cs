using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003F2 RID: 1010
	[Serializable]
	public class BotanistConfigurationData : SaveData
	{
		// Token: 0x06001566 RID: 5478 RVA: 0x0005F96C File Offset: 0x0005DB6C
		public BotanistConfigurationData(ObjectFieldData bed, ObjectFieldData supplies, ObjectListFieldData pots)
		{
			this.Bed = bed;
			this.Supplies = supplies;
			this.Pots = pots;
		}

		// Token: 0x040013AD RID: 5037
		public ObjectFieldData Bed;

		// Token: 0x040013AE RID: 5038
		public ObjectFieldData Supplies;

		// Token: 0x040013AF RID: 5039
		public ObjectListFieldData Pots;
	}
}
