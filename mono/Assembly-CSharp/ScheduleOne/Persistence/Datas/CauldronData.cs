using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000415 RID: 1045
	public class CauldronData : GridItemData
	{
		// Token: 0x0600158A RID: 5514 RVA: 0x0005FE00 File Offset: 0x0005E000
		public CauldronData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet ingredients, ItemSet liquid, ItemSet output, int remainingCookTime, EQuality inputQuality) : base(guid, item, loadOrder, grid, originCoordinate, rotation)
		{
			this.Ingredients = ingredients;
			this.Liquid = liquid;
			this.Output = output;
			this.RemainingCookTime = remainingCookTime;
			this.InputQuality = inputQuality;
		}

		// Token: 0x04001401 RID: 5121
		public ItemSet Ingredients;

		// Token: 0x04001402 RID: 5122
		public ItemSet Liquid;

		// Token: 0x04001403 RID: 5123
		public ItemSet Output;

		// Token: 0x04001404 RID: 5124
		public int RemainingCookTime;

		// Token: 0x04001405 RID: 5125
		public EQuality InputQuality;
	}
}
