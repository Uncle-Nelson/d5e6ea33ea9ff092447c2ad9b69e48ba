using System;
using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000ADD RID: 2781
	public class BotanistConfigPanel : ConfigPanel
	{
		// Token: 0x06004A94 RID: 19092 RVA: 0x00139148 File Offset: 0x00137348
		public override void Bind(List<EntityConfiguration> configs)
		{
			List<ObjectField> list = new List<ObjectField>();
			List<ObjectField> list2 = new List<ObjectField>();
			List<ObjectListField> list3 = new List<ObjectListField>();
			foreach (EntityConfiguration entityConfiguration in configs)
			{
				BotanistConfiguration botanistConfiguration = (BotanistConfiguration)entityConfiguration;
				if (botanistConfiguration == null)
				{
					Console.LogError("Failed to cast EntityConfiguration to BotanistConfiguration", null);
					return;
				}
				list.Add(botanistConfiguration.Bed);
				list2.Add(botanistConfiguration.Supplies);
				list3.Add(botanistConfiguration.AssignedStations);
			}
			this.BedUI.Bind(list);
			this.SuppliesUI.Bind(list2);
			this.PotsUI.Bind(list3);
		}

		// Token: 0x040037E5 RID: 14309
		[Header("References")]
		public ObjectFieldUI BedUI;

		// Token: 0x040037E6 RID: 14310
		public ObjectFieldUI SuppliesUI;

		// Token: 0x040037E7 RID: 14311
		public ObjectListFieldUI PotsUI;
	}
}
