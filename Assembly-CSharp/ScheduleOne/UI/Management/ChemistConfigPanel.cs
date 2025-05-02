using System;
using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AE0 RID: 2784
	public class ChemistConfigPanel : ConfigPanel
	{
		// Token: 0x06004A9A RID: 19098 RVA: 0x00139304 File Offset: 0x00137504
		public override void Bind(List<EntityConfiguration> configs)
		{
			List<ObjectField> list = new List<ObjectField>();
			List<ObjectListField> list2 = new List<ObjectListField>();
			foreach (EntityConfiguration entityConfiguration in configs)
			{
				ChemistConfiguration chemistConfiguration = (ChemistConfiguration)entityConfiguration;
				if (chemistConfiguration == null)
				{
					Console.LogError("Failed to cast EntityConfiguration to BotanistConfiguration", null);
					return;
				}
				list.Add(chemistConfiguration.Bed);
				list2.Add(chemistConfiguration.Stations);
			}
			this.BedUI.Bind(list);
			this.StationsUI.Bind(list2);
		}

		// Token: 0x040037EA RID: 14314
		[Header("References")]
		public ObjectFieldUI BedUI;

		// Token: 0x040037EB RID: 14315
		public ObjectListFieldUI StationsUI;
	}
}
