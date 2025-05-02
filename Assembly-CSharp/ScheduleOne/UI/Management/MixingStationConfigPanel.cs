using System;
using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AE5 RID: 2789
	public class MixingStationConfigPanel : ConfigPanel
	{
		// Token: 0x06004AA4 RID: 19108 RVA: 0x001395E0 File Offset: 0x001377E0
		public override void Bind(List<EntityConfiguration> configs)
		{
			List<ObjectField> list = new List<ObjectField>();
			List<NumberField> list2 = new List<NumberField>();
			foreach (EntityConfiguration entityConfiguration in configs)
			{
				MixingStationConfiguration mixingStationConfiguration = (MixingStationConfiguration)entityConfiguration;
				if (mixingStationConfiguration == null)
				{
					Console.LogError("Failed to cast EntityConfiguration to MixingStationConfiguration", null);
					return;
				}
				list.Add(mixingStationConfiguration.Destination);
				list2.Add(mixingStationConfiguration.StartThrehold);
			}
			this.DestinationUI.Bind(list);
			this.StartThresholdUI.Bind(list2);
		}

		// Token: 0x040037F3 RID: 14323
		[Header("References")]
		public ObjectFieldUI DestinationUI;

		// Token: 0x040037F4 RID: 14324
		public NumberFieldUI StartThresholdUI;
	}
}
