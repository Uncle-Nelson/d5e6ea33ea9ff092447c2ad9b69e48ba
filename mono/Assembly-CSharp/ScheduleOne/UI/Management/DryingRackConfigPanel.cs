using System;
using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AE3 RID: 2787
	public class DryingRackConfigPanel : ConfigPanel
	{
		// Token: 0x06004AA0 RID: 19104 RVA: 0x001394CC File Offset: 0x001376CC
		public override void Bind(List<EntityConfiguration> configs)
		{
			List<QualityField> list = new List<QualityField>();
			List<ObjectField> list2 = new List<ObjectField>();
			foreach (EntityConfiguration entityConfiguration in configs)
			{
				DryingRackConfiguration dryingRackConfiguration = (DryingRackConfiguration)entityConfiguration;
				if (dryingRackConfiguration == null)
				{
					Console.LogError("Failed to cast EntityConfiguration to DryingRackConfiguration", null);
					return;
				}
				list.Add(dryingRackConfiguration.TargetQuality);
				list2.Add(dryingRackConfiguration.Destination);
			}
			this.QualityUI.Bind(list);
			this.DestinationUI.Bind(list2);
		}

		// Token: 0x040037F0 RID: 14320
		[Header("References")]
		public QualityFieldUI QualityUI;

		// Token: 0x040037F1 RID: 14321
		public ObjectFieldUI DestinationUI;
	}
}
