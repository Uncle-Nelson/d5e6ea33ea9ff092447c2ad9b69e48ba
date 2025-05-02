using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003F5 RID: 1013
	[Serializable]
	public class ChemistConfigurationData : SaveData
	{
		// Token: 0x06001569 RID: 5481 RVA: 0x0005F9A7 File Offset: 0x0005DBA7
		public ChemistConfigurationData(ObjectFieldData bed, ObjectListFieldData stations)
		{
			this.Bed = bed;
			this.Stations = stations;
		}

		// Token: 0x040013B2 RID: 5042
		public ObjectFieldData Bed;

		// Token: 0x040013B3 RID: 5043
		public ObjectListFieldData Stations;
	}
}
