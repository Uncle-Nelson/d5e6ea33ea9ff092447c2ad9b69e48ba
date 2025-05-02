using System;
using System.Collections.Generic;
using ScheduleOne.Management;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003F1 RID: 1009
	[Serializable]
	public class AdvancedTransitRouteData
	{
		// Token: 0x06001564 RID: 5476 RVA: 0x0005F947 File Offset: 0x0005DB47
		public AdvancedTransitRouteData(string sourceGUID, string destinationGUID, ManagementItemFilter.EMode filtermode, List<string> filterGUIDs)
		{
			this.SourceGUID = sourceGUID;
			this.DestinationGUID = destinationGUID;
			this.FilterMode = filtermode;
			this.FilterItemIDs = filterGUIDs;
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x0000494F File Offset: 0x00002B4F
		public AdvancedTransitRouteData()
		{
		}

		// Token: 0x040013A9 RID: 5033
		public string SourceGUID;

		// Token: 0x040013AA RID: 5034
		public string DestinationGUID;

		// Token: 0x040013AB RID: 5035
		public ManagementItemFilter.EMode FilterMode;

		// Token: 0x040013AC RID: 5036
		public List<string> FilterItemIDs;
	}
}
