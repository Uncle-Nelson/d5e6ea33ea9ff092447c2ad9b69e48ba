using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003FB RID: 1019
	[Serializable]
	public class MixingStationConfigurationData : SaveData
	{
		// Token: 0x0600156F RID: 5487 RVA: 0x0005FA1D File Offset: 0x0005DC1D
		public MixingStationConfigurationData(ObjectFieldData destination, NumberFieldData threshold)
		{
			this.Destination = destination;
			this.Threshold = threshold;
		}

		// Token: 0x040013BC RID: 5052
		public ObjectFieldData Destination;

		// Token: 0x040013BD RID: 5053
		public NumberFieldData Threshold;
	}
}
