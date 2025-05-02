using System;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Growing
{
	// Token: 0x02000881 RID: 2177
	public class CocaPlant : Plant
	{
		// Token: 0x06003B06 RID: 15110 RVA: 0x000F86BC File Offset: 0x000F68BC
		public override ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			EQuality quality = ItemQuality.GetQuality(this.QualityLevel);
			QualityItemInstance qualityItemInstance = this.Harvestable.Product.GetDefaultInstance(quantity) as QualityItemInstance;
			qualityItemInstance.Quality = quality;
			return qualityItemInstance;
		}

		// Token: 0x04002A91 RID: 10897
		public PlantHarvestable Harvestable;
	}
}
