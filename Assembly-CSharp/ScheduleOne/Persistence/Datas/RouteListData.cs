using System;
using System.Collections.Generic;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000404 RID: 1028
	[Serializable]
	public class RouteListData
	{
		// Token: 0x06001578 RID: 5496 RVA: 0x0005FAD7 File Offset: 0x0005DCD7
		public RouteListData(List<AdvancedTransitRouteData> routes)
		{
			this.Routes = routes;
		}

		// Token: 0x040013CC RID: 5068
		public List<AdvancedTransitRouteData> Routes;
	}
}
