using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Product;
using ScheduleOne.Product.Packaging;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x0200044B RID: 1099
	public class WeedLoader : ItemLoader
	{
		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x060015DD RID: 5597 RVA: 0x00060CCA File Offset: 0x0005EECA
		public override string ItemType
		{
			get
			{
				return typeof(WeedData).Name;
			}
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00060CDC File Offset: 0x0005EEDC
		public override ItemInstance LoadItem(string itemString)
		{
			WeedData weedData = base.LoadData<WeedData>(itemString);
			if (weedData == null)
			{
				Console.LogWarning("Failed loading item data from " + itemString, null);
				return null;
			}
			if (weedData.ID == string.Empty)
			{
				return null;
			}
			ItemDefinition item = Registry.GetItem(weedData.ID);
			if (item == null)
			{
				Console.LogWarning("Failed to find item definition for " + weedData.ID, null);
				return null;
			}
			EQuality equality;
			EQuality quality = Enum.TryParse<EQuality>(weedData.Quality, out equality) ? equality : EQuality.Standard;
			PackagingDefinition packaging = null;
			if (weedData.PackagingID != string.Empty)
			{
				ItemDefinition item2 = Registry.GetItem(weedData.PackagingID);
				if (item != null)
				{
					packaging = (item2 as PackagingDefinition);
				}
			}
			return new WeedInstance(item, weedData.Quantity, quality, packaging);
		}
	}
}
