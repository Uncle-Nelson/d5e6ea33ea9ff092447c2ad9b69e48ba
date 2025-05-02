using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000405 RID: 1029
	[Serializable]
	public class StationRecipeFieldData
	{
		// Token: 0x06001579 RID: 5497 RVA: 0x0005FAE6 File Offset: 0x0005DCE6
		public StationRecipeFieldData(string recipeID)
		{
			this.RecipeID = recipeID;
		}

		// Token: 0x040013CD RID: 5069
		public string RecipeID;
	}
}
