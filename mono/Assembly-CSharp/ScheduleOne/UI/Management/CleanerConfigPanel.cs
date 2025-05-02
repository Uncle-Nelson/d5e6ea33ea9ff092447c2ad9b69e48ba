using System;
using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AE2 RID: 2786
	public class CleanerConfigPanel : ConfigPanel
	{
		// Token: 0x06004A9E RID: 19102 RVA: 0x00139434 File Offset: 0x00137634
		public override void Bind(List<EntityConfiguration> configs)
		{
			List<ObjectField> list = new List<ObjectField>();
			List<ObjectListField> list2 = new List<ObjectListField>();
			foreach (EntityConfiguration entityConfiguration in configs)
			{
				CleanerConfiguration cleanerConfiguration = (CleanerConfiguration)entityConfiguration;
				if (cleanerConfiguration == null)
				{
					Console.LogError("Failed to cast EntityConfiguration to CleanerConfiguration", null);
					return;
				}
				list.Add(cleanerConfiguration.Bed);
				list2.Add(cleanerConfiguration.Bins);
			}
			this.BedUI.Bind(list);
			this.BinsUI.Bind(list2);
		}

		// Token: 0x040037EE RID: 14318
		[Header("References")]
		public ObjectFieldUI BedUI;

		// Token: 0x040037EF RID: 14319
		public ObjectListFieldUI BinsUI;
	}
}
