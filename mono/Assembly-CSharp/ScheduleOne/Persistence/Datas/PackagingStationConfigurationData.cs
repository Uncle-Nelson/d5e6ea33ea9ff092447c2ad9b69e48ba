using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000401 RID: 1025
	[Serializable]
	public class PackagingStationConfigurationData : SaveData
	{
		// Token: 0x06001575 RID: 5493 RVA: 0x0005FA8C File Offset: 0x0005DC8C
		public PackagingStationConfigurationData(ObjectFieldData destination)
		{
			this.Destination = destination;
		}

		// Token: 0x040013C5 RID: 5061
		public ObjectFieldData Destination;
	}
}
