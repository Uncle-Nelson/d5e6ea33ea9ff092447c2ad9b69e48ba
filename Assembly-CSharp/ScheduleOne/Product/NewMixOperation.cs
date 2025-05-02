using System;

namespace ScheduleOne.Product
{
	// Token: 0x020008ED RID: 2285
	[Serializable]
	public class NewMixOperation
	{
		// Token: 0x06003DAA RID: 15786 RVA: 0x00102DC1 File Offset: 0x00100FC1
		public NewMixOperation(string productID, string ingredientID)
		{
			this.ProductID = productID;
			this.IngredientID = ingredientID;
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x0000494F File Offset: 0x00002B4F
		public NewMixOperation()
		{
		}

		// Token: 0x04002C78 RID: 11384
		public string ProductID;

		// Token: 0x04002C79 RID: 11385
		public string IngredientID;
	}
}
