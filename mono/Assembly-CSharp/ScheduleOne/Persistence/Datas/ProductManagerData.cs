using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Product;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200042D RID: 1069
	[Serializable]
	public class ProductManagerData : SaveData
	{
		// Token: 0x060015A3 RID: 5539 RVA: 0x000601C9 File Offset: 0x0005E3C9
		public ProductManagerData(string[] discoveredProducts, string[] listedProducts, NewMixOperation activeOperation, bool isMixComplete, MixRecipeData[] mixRecipes, StringIntPair[] productPrices, string[] favouritedProducts)
		{
			this.DiscoveredProducts = discoveredProducts;
			this.ListedProducts = listedProducts;
			this.ActiveMixOperation = activeOperation;
			this.IsMixComplete = isMixComplete;
			this.MixRecipes = mixRecipes;
			this.ProductPrices = productPrices;
			this.FavouritedProducts = favouritedProducts;
		}

		// Token: 0x04001444 RID: 5188
		public string[] DiscoveredProducts;

		// Token: 0x04001445 RID: 5189
		public string[] ListedProducts;

		// Token: 0x04001446 RID: 5190
		public NewMixOperation ActiveMixOperation;

		// Token: 0x04001447 RID: 5191
		public bool IsMixComplete;

		// Token: 0x04001448 RID: 5192
		public MixRecipeData[] MixRecipes;

		// Token: 0x04001449 RID: 5193
		public StringIntPair[] ProductPrices;

		// Token: 0x0400144A RID: 5194
		public string[] FavouritedProducts;
	}
}
