using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003F6 RID: 1014
	[Serializable]
	public class ChemistryStationConfigurationData : SaveData
	{
		// Token: 0x0600156A RID: 5482 RVA: 0x0005F9BD File Offset: 0x0005DBBD
		public ChemistryStationConfigurationData(StationRecipeFieldData recipe, ObjectFieldData destination)
		{
			this.Recipe = recipe;
			this.Destination = destination;
		}

		// Token: 0x040013B4 RID: 5044
		public StationRecipeFieldData Recipe;

		// Token: 0x040013B5 RID: 5045
		public ObjectFieldData Destination;
	}
}
