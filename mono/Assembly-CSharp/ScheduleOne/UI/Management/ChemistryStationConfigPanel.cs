using System;
using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AE1 RID: 2785
	public class ChemistryStationConfigPanel : ConfigPanel
	{
		// Token: 0x06004A9C RID: 19100 RVA: 0x0013939C File Offset: 0x0013759C
		public override void Bind(List<EntityConfiguration> configs)
		{
			List<StationRecipeField> list = new List<StationRecipeField>();
			List<ObjectField> list2 = new List<ObjectField>();
			foreach (EntityConfiguration entityConfiguration in configs)
			{
				ChemistryStationConfiguration chemistryStationConfiguration = (ChemistryStationConfiguration)entityConfiguration;
				if (chemistryStationConfiguration == null)
				{
					Console.LogError("Failed to cast EntityConfiguration to ChemistryStationConfiguration", null);
					return;
				}
				list2.Add(chemistryStationConfiguration.Destination);
				list.Add(chemistryStationConfiguration.Recipe);
			}
			this.RecipeUI.Bind(list);
			this.DestinationUI.Bind(list2);
		}

		// Token: 0x040037EC RID: 14316
		[Header("References")]
		public StationRecipeFieldUI RecipeUI;

		// Token: 0x040037ED RID: 14317
		public ObjectFieldUI DestinationUI;
	}
}
