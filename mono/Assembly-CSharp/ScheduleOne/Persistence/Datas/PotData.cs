using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200041E RID: 1054
	public class PotData : GridItemData
	{
		// Token: 0x06001593 RID: 5523 RVA: 0x0005FFD8 File Offset: 0x0005E1D8
		public PotData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, string soilID, float soilLevel, int remainingSoilUses, float waterLevel, string[] appliedAdditives, PlantData plantData) : base(guid, item, loadOrder, grid, originCoordinate, rotation)
		{
			this.SoilID = soilID;
			this.SoilLevel = soilLevel;
			this.RemainingSoilUses = remainingSoilUses;
			this.WaterLevel = waterLevel;
			this.AppliedAdditives = appliedAdditives;
			this.PlantData = plantData;
		}

		// Token: 0x04001422 RID: 5154
		public string SoilID;

		// Token: 0x04001423 RID: 5155
		public float SoilLevel;

		// Token: 0x04001424 RID: 5156
		public int RemainingSoilUses;

		// Token: 0x04001425 RID: 5157
		public float WaterLevel;

		// Token: 0x04001426 RID: 5158
		public string[] AppliedAdditives;

		// Token: 0x04001427 RID: 5159
		public PlantData PlantData;
	}
}
