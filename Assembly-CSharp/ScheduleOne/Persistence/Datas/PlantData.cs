using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000427 RID: 1063
	[Serializable]
	public class PlantData : SaveData
	{
		// Token: 0x0600159C RID: 5532 RVA: 0x000600F5 File Offset: 0x0005E2F5
		public PlantData(string seedID, float growthProgress, float yieldLevel, float qualityLevel, int[] activeBuds)
		{
			this.SeedID = seedID;
			this.GrowthProgress = growthProgress;
			this.YieldLevel = yieldLevel;
			this.QualityLevel = qualityLevel;
			this.ActiveBuds = activeBuds;
		}

		// Token: 0x04001434 RID: 5172
		public string SeedID;

		// Token: 0x04001435 RID: 5173
		public float GrowthProgress;

		// Token: 0x04001436 RID: 5174
		public float YieldLevel;

		// Token: 0x04001437 RID: 5175
		public float QualityLevel;

		// Token: 0x04001438 RID: 5176
		public int[] ActiveBuds;
	}
}
