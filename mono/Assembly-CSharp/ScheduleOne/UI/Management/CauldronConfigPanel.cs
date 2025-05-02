using System;
using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000ADF RID: 2783
	public class CauldronConfigPanel : ConfigPanel
	{
		// Token: 0x06004A98 RID: 19096 RVA: 0x00139288 File Offset: 0x00137488
		public override void Bind(List<EntityConfiguration> configs)
		{
			List<ObjectField> list = new List<ObjectField>();
			foreach (EntityConfiguration entityConfiguration in configs)
			{
				CauldronConfiguration cauldronConfiguration = (CauldronConfiguration)entityConfiguration;
				if (cauldronConfiguration == null)
				{
					Console.LogError("Failed to cast EntityConfiguration to CauldronConfiguration", null);
					return;
				}
				list.Add(cauldronConfiguration.Destination);
			}
			this.DestinationUI.Bind(list);
		}

		// Token: 0x040037E9 RID: 14313
		[Header("References")]
		public ObjectFieldUI DestinationUI;
	}
}
