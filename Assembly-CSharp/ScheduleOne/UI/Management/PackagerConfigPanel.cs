using System;
using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AE6 RID: 2790
	public class PackagerConfigPanel : ConfigPanel
	{
		// Token: 0x06004AA6 RID: 19110 RVA: 0x00139678 File Offset: 0x00137878
		public override void Bind(List<EntityConfiguration> configs)
		{
			List<ObjectField> list = new List<ObjectField>();
			List<ObjectListField> list2 = new List<ObjectListField>();
			List<RouteListField> list3 = new List<RouteListField>();
			foreach (EntityConfiguration entityConfiguration in configs)
			{
				PackagerConfiguration packagerConfiguration = (PackagerConfiguration)entityConfiguration;
				if (packagerConfiguration == null)
				{
					Console.LogError("Failed to cast EntityConfiguration to PackagerConfiguration", null);
					return;
				}
				list.Add(packagerConfiguration.Bed);
				list2.Add(packagerConfiguration.Stations);
				list3.Add(packagerConfiguration.Routes);
			}
			this.BedUI.Bind(list);
			this.StationsUI.Bind(list2);
			this.RoutesUI.Bind(list3);
		}

		// Token: 0x040037F5 RID: 14325
		[Header("References")]
		public ObjectFieldUI BedUI;

		// Token: 0x040037F6 RID: 14326
		public ObjectListFieldUI StationsUI;

		// Token: 0x040037F7 RID: 14327
		public RouteListFieldUI RoutesUI;
	}
}
