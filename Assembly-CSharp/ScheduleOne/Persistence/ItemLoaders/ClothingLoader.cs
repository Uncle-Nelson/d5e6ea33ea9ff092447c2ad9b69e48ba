using System;
using ScheduleOne.Clothing;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x02000442 RID: 1090
	public class ClothingLoader : ItemLoader
	{
		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060015C1 RID: 5569 RVA: 0x00060639 File Offset: 0x0005E839
		public override string ItemType
		{
			get
			{
				return typeof(ClothingData).Name;
			}
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x0006064C File Offset: 0x0005E84C
		public override ItemInstance LoadItem(string itemString)
		{
			ClothingData clothingData = base.LoadData<ClothingData>(itemString);
			if (clothingData == null)
			{
				Console.LogWarning("Failed loading item data from " + itemString, null);
				return null;
			}
			if (clothingData.ID == string.Empty)
			{
				return null;
			}
			ItemDefinition item = Registry.GetItem(clothingData.ID);
			if (item == null)
			{
				Console.LogWarning("Failed to find item definition for " + clothingData.ID, null);
				return null;
			}
			return new ClothingInstance(item, clothingData.Quantity, clothingData.Color);
		}
	}
}
