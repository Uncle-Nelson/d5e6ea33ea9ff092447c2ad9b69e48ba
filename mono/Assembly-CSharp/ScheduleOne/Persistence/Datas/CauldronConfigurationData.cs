using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003F4 RID: 1012
	[Serializable]
	public class CauldronConfigurationData : SaveData
	{
		// Token: 0x06001568 RID: 5480 RVA: 0x0005F998 File Offset: 0x0005DB98
		public CauldronConfigurationData(ObjectFieldData destination)
		{
			this.Destination = destination;
		}

		// Token: 0x040013B1 RID: 5041
		public ObjectFieldData Destination;
	}
}
