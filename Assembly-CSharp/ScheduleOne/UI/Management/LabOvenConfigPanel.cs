using System;
using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AE4 RID: 2788
	public class LabOvenConfigPanel : ConfigPanel
	{
		// Token: 0x06004AA2 RID: 19106 RVA: 0x00139564 File Offset: 0x00137764
		public override void Bind(List<EntityConfiguration> configs)
		{
			List<ObjectField> list = new List<ObjectField>();
			foreach (EntityConfiguration entityConfiguration in configs)
			{
				LabOvenConfiguration labOvenConfiguration = (LabOvenConfiguration)entityConfiguration;
				if (labOvenConfiguration == null)
				{
					Console.LogError("Failed to cast EntityConfiguration to LabOvenConfiguration", null);
					return;
				}
				list.Add(labOvenConfiguration.Destination);
			}
			this.DestinationUI.Bind(list);
		}

		// Token: 0x040037F2 RID: 14322
		[Header("References")]
		public ObjectFieldUI DestinationUI;
	}
}
