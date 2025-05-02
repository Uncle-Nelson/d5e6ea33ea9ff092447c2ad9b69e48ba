using System;
using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AE8 RID: 2792
	public class PotConfigPanel : ConfigPanel
	{
		// Token: 0x06004AAA RID: 19114 RVA: 0x001397B0 File Offset: 0x001379B0
		public override void Bind(List<EntityConfiguration> configs)
		{
			List<ItemField> list = new List<ItemField>();
			List<ItemField> list2 = new List<ItemField>();
			List<ItemField> list3 = new List<ItemField>();
			List<ItemField> list4 = new List<ItemField>();
			List<NPCField> list5 = new List<NPCField>();
			List<ObjectField> list6 = new List<ObjectField>();
			foreach (EntityConfiguration entityConfiguration in configs)
			{
				PotConfiguration potConfiguration = (PotConfiguration)entityConfiguration;
				if (potConfiguration == null)
				{
					Console.LogError("Failed to cast EntityConfiguration to PotConfiguration", null);
					return;
				}
				list.Add(potConfiguration.Seed);
				list2.Add(potConfiguration.Additive1);
				list3.Add(potConfiguration.Additive2);
				list4.Add(potConfiguration.Additive3);
				list5.Add(potConfiguration.AssignedBotanist);
				list6.Add(potConfiguration.Destination);
			}
			this.SeedUI.Bind(list);
			this.Additive1UI.Bind(list2);
			this.Additive2UI.Bind(list3);
			this.Additive3UI.Bind(list4);
			this.DestinationUI.Bind(list6);
		}

		// Token: 0x040037F9 RID: 14329
		[Header("References")]
		public ItemFieldUI SeedUI;

		// Token: 0x040037FA RID: 14330
		public ItemFieldUI Additive1UI;

		// Token: 0x040037FB RID: 14331
		public ItemFieldUI Additive2UI;

		// Token: 0x040037FC RID: 14332
		public ItemFieldUI Additive3UI;

		// Token: 0x040037FD RID: 14333
		public ObjectFieldUI DestinationUI;
	}
}
