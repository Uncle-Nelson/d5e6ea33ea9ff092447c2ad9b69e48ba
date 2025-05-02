using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Product;
using ScheduleOne.Product.Packaging;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x02000447 RID: 1095
	public class ProductItemLoader : ItemLoader
	{
		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x00060A2F File Offset: 0x0005EC2F
		public override string ItemType
		{
			get
			{
				return typeof(ProductItemData).Name;
			}
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00060A40 File Offset: 0x0005EC40
		public override ItemInstance LoadItem(string itemString)
		{
			ProductItemData productItemData = base.LoadData<ProductItemData>(itemString);
			if (productItemData == null)
			{
				Console.LogWarning("Failed loading item data from " + itemString, null);
				return null;
			}
			if (productItemData.ID == string.Empty)
			{
				return null;
			}
			ItemDefinition item = Registry.GetItem(productItemData.ID);
			if (item == null)
			{
				Console.LogWarning("Failed to find item definition for " + productItemData.ID, null);
				return null;
			}
			EQuality equality;
			EQuality quality = Enum.TryParse<EQuality>(productItemData.Quality, out equality) ? equality : EQuality.Standard;
			PackagingDefinition packaging = null;
			if (productItemData.PackagingID != string.Empty)
			{
				ItemDefinition item2 = Registry.GetItem(productItemData.PackagingID);
				if (item != null)
				{
					packaging = (item2 as PackagingDefinition);
				}
			}
			return new ProductItemInstance(item, productItemData.Quantity, quality, packaging);
		}
	}
}
