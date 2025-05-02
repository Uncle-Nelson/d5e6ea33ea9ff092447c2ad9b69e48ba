using System;
using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AE7 RID: 2791
	public class PackagingStationConfigPanel : ConfigPanel
	{
		// Token: 0x06004AA8 RID: 19112 RVA: 0x00139734 File Offset: 0x00137934
		public override void Bind(List<EntityConfiguration> configs)
		{
			List<ObjectField> list = new List<ObjectField>();
			foreach (EntityConfiguration entityConfiguration in configs)
			{
				PackagingStationConfiguration packagingStationConfiguration = (PackagingStationConfiguration)entityConfiguration;
				if (packagingStationConfiguration == null)
				{
					Console.LogError("Failed to cast EntityConfiguration to PackagingStationConfiguration", null);
					return;
				}
				list.Add(packagingStationConfiguration.Destination);
			}
			this.DestinationUI.Bind(list);
		}

		// Token: 0x040037F8 RID: 14328
		[Header("References")]
		public ObjectFieldUI DestinationUI;
	}
}
