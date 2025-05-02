using System;
using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000ADE RID: 2782
	public class BrickPressConfigPanel : ConfigPanel
	{
		// Token: 0x06004A96 RID: 19094 RVA: 0x0013920C File Offset: 0x0013740C
		public override void Bind(List<EntityConfiguration> configs)
		{
			List<ObjectField> list = new List<ObjectField>();
			foreach (EntityConfiguration entityConfiguration in configs)
			{
				BrickPressConfiguration brickPressConfiguration = (BrickPressConfiguration)entityConfiguration;
				if (brickPressConfiguration == null)
				{
					Console.LogError("Failed to cast EntityConfiguration to BrickPressConfiguration", null);
					return;
				}
				list.Add(brickPressConfiguration.Destination);
			}
			this.DestinationUI.Bind(list);
		}

		// Token: 0x040037E8 RID: 14312
		[Header("References")]
		public ObjectFieldUI DestinationUI;
	}
}
