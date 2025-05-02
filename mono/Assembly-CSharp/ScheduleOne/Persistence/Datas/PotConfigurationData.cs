using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000402 RID: 1026
	[Serializable]
	public class PotConfigurationData : SaveData
	{
		// Token: 0x06001576 RID: 5494 RVA: 0x0005FA9B File Offset: 0x0005DC9B
		public PotConfigurationData(ItemFieldData seed, ItemFieldData additive1, ItemFieldData additive2, ItemFieldData additive3, ObjectFieldData destination)
		{
			this.Seed = seed;
			this.Additive1 = additive1;
			this.Additive2 = additive2;
			this.Additive3 = additive3;
			this.Destination = destination;
		}

		// Token: 0x040013C6 RID: 5062
		public ItemFieldData Seed;

		// Token: 0x040013C7 RID: 5063
		public ItemFieldData Additive1;

		// Token: 0x040013C8 RID: 5064
		public ItemFieldData Additive2;

		// Token: 0x040013C9 RID: 5065
		public ItemFieldData Additive3;

		// Token: 0x040013CA RID: 5066
		public ObjectFieldData Destination;
	}
}
