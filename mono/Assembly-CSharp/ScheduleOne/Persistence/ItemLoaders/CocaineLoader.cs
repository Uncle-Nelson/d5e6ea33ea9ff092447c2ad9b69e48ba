using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Product;
using ScheduleOne.Product.Packaging;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x02000443 RID: 1091
	public class CocaineLoader : ItemLoader
	{
		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x000606CA File Offset: 0x0005E8CA
		public override string ItemType
		{
			get
			{
				return typeof(CocaineData).Name;
			}
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x000606DC File Offset: 0x0005E8DC
		public override ItemInstance LoadItem(string itemString)
		{
			CocaineData cocaineData = base.LoadData<CocaineData>(itemString);
			if (cocaineData == null)
			{
				Console.LogWarning("Failed loading item data from " + itemString, null);
				return null;
			}
			if (cocaineData.ID == string.Empty)
			{
				return null;
			}
			ItemDefinition item = Registry.GetItem(cocaineData.ID);
			if (item == null)
			{
				Console.LogWarning("Failed to find item definition for " + cocaineData.ID, null);
				return null;
			}
			EQuality equality;
			EQuality quality = Enum.TryParse<EQuality>(cocaineData.Quality, out equality) ? equality : EQuality.Standard;
			PackagingDefinition packaging = null;
			if (cocaineData.PackagingID != string.Empty)
			{
				ItemDefinition item2 = Registry.GetItem(cocaineData.PackagingID);
				if (item != null)
				{
					packaging = (item2 as PackagingDefinition);
				}
			}
			return new CocaineInstance(item, cocaineData.Quantity, quality, packaging);
		}
	}
}
