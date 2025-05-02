using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000416 RID: 1046
	public class ChemistryStationData : GridItemData
	{
		// Token: 0x0600158B RID: 5515 RVA: 0x0005FE3C File Offset: 0x0005E03C
		public ChemistryStationData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet inputContents, ItemSet outputContents, string currentRecipeID, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime) : base(guid, item, loadOrder, grid, originCoordinate, rotation)
		{
			this.InputContents = inputContents;
			this.OutputContents = outputContents;
			this.CurrentRecipeID = currentRecipeID;
			this.ProductQuality = productQuality;
			this.StartLiquidColor = startLiquidColor;
			this.LiquidLevel = liquidLevel;
			this.CurrentTime = currentTime;
		}

		// Token: 0x04001406 RID: 5126
		public ItemSet InputContents;

		// Token: 0x04001407 RID: 5127
		public ItemSet OutputContents;

		// Token: 0x04001408 RID: 5128
		public string CurrentRecipeID;

		// Token: 0x04001409 RID: 5129
		public EQuality ProductQuality;

		// Token: 0x0400140A RID: 5130
		public Color StartLiquidColor;

		// Token: 0x0400140B RID: 5131
		public float LiquidLevel;

		// Token: 0x0400140C RID: 5132
		public int CurrentTime;
	}
}
