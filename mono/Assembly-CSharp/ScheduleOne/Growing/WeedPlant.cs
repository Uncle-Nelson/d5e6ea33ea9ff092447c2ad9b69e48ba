using System;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Growing
{
	// Token: 0x02000889 RID: 2185
	public class WeedPlant : Plant
	{
		// Token: 0x06003B2F RID: 15151 RVA: 0x000F9018 File Offset: 0x000F7218
		public override ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			EQuality quality = ItemQuality.GetQuality(this.QualityLevel);
			QualityItemInstance qualityItemInstance = this.BranchPrefab.Product.GetDefaultInstance(quantity) as QualityItemInstance;
			qualityItemInstance.Quality = quality;
			return qualityItemInstance;
		}

		// Token: 0x04002AB8 RID: 10936
		public PlantHarvestable BranchPrefab;
	}
}
