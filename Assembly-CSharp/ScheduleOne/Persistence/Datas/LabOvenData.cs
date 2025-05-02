using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200041A RID: 1050
	public class LabOvenData : GridItemData
	{
		// Token: 0x0600158F RID: 5519 RVA: 0x0005FF18 File Offset: 0x0005E118
		public LabOvenData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet inputContents, ItemSet outputContents, string ingredientID, int currentIngredientQuantity, EQuality ingredientQuality, string productID, int currentCookProgress) : base(guid, item, loadOrder, grid, originCoordinate, rotation)
		{
			this.InputContents = inputContents;
			this.OutputContents = outputContents;
			this.CurrentIngredientID = ingredientID;
			this.CurrentIngredientQuantity = currentIngredientQuantity;
			this.CurrentIngredientQuality = ingredientQuality;
			this.CurrentProductID = productID;
			this.CurrentCookProgress = currentCookProgress;
		}

		// Token: 0x04001414 RID: 5140
		public ItemSet InputContents;

		// Token: 0x04001415 RID: 5141
		public ItemSet OutputContents;

		// Token: 0x04001416 RID: 5142
		public string CurrentIngredientID;

		// Token: 0x04001417 RID: 5143
		public int CurrentIngredientQuantity;

		// Token: 0x04001418 RID: 5144
		public EQuality CurrentIngredientQuality;

		// Token: 0x04001419 RID: 5145
		public string CurrentProductID;

		// Token: 0x0400141A RID: 5146
		public int CurrentCookProgress;
	}
}
