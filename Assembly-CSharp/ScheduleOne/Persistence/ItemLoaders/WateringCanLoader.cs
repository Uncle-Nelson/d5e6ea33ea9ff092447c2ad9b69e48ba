using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x0200044A RID: 1098
	public class WateringCanLoader : ItemLoader
	{
		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x060015DA RID: 5594 RVA: 0x00060C38 File Offset: 0x0005EE38
		public override string ItemType
		{
			get
			{
				return typeof(WateringCanData).Name;
			}
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00060C4C File Offset: 0x0005EE4C
		public override ItemInstance LoadItem(string itemString)
		{
			WateringCanData wateringCanData = base.LoadData<WateringCanData>(itemString);
			if (wateringCanData == null)
			{
				Console.LogWarning("Failed loading item data from " + itemString, null);
				return null;
			}
			if (wateringCanData.ID == string.Empty)
			{
				return null;
			}
			ItemDefinition item = Registry.GetItem(wateringCanData.ID);
			if (item == null)
			{
				Console.LogWarning("Failed to find item definition for " + wateringCanData.ID, null);
				return null;
			}
			return new WateringCanInstance(item, wateringCanData.Quantity, wateringCanData.CurrentFillAmount);
		}
	}
}
