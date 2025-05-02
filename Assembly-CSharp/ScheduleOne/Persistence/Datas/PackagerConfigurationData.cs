using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000400 RID: 1024
	[Serializable]
	public class PackagerConfigurationData : SaveData
	{
		// Token: 0x06001574 RID: 5492 RVA: 0x0005FA6F File Offset: 0x0005DC6F
		public PackagerConfigurationData(ObjectFieldData bed, ObjectListFieldData stations, RouteListData routes)
		{
			this.Bed = bed;
			this.Stations = stations;
			this.Routes = routes;
		}

		// Token: 0x040013C2 RID: 5058
		public ObjectFieldData Bed;

		// Token: 0x040013C3 RID: 5059
		public ObjectListFieldData Stations;

		// Token: 0x040013C4 RID: 5060
		public RouteListData Routes;
	}
}
