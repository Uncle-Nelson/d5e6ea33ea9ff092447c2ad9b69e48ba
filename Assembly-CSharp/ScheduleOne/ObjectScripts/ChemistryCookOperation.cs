using System;
using FishNet.Serializing.Helping;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.StationFramework;
using ScheduleOne.UI.Stations;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BC7 RID: 3015
	public class ChemistryCookOperation
	{
		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06005212 RID: 21010 RVA: 0x00159D2C File Offset: 0x00157F2C
		[CodegenExclude]
		public StationRecipe Recipe
		{
			get
			{
				if (this.recipe == null)
				{
					this.recipe = Singleton<ChemistryStationCanvas>.Instance.Recipes.Find((StationRecipe r) => r.RecipeID == this.RecipeID);
				}
				return this.recipe;
			}
		}

		// Token: 0x06005213 RID: 21011 RVA: 0x00159D63 File Offset: 0x00157F63
		public ChemistryCookOperation(StationRecipe recipe, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime = 0)
		{
			this.RecipeID = recipe.RecipeID;
			this.ProductQuality = productQuality;
			this.StartLiquidColor = startLiquidColor;
			this.LiquidLevel = liquidLevel;
			this.CurrentTime = currentTime;
		}

		// Token: 0x06005214 RID: 21012 RVA: 0x00159D95 File Offset: 0x00157F95
		public ChemistryCookOperation(string recipeID, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime = 0)
		{
			this.RecipeID = recipeID;
			this.ProductQuality = productQuality;
			this.StartLiquidColor = startLiquidColor;
			this.LiquidLevel = liquidLevel;
			this.CurrentTime = currentTime;
		}

		// Token: 0x06005215 RID: 21013 RVA: 0x0000494F File Offset: 0x00002B4F
		public ChemistryCookOperation()
		{
		}

		// Token: 0x06005216 RID: 21014 RVA: 0x00159DC2 File Offset: 0x00157FC2
		public void Progress(int mins)
		{
			this.CurrentTime += mins;
			int currentTime = this.CurrentTime;
			int cookTime_Mins = this.Recipe.CookTime_Mins;
		}

		// Token: 0x04003D87 RID: 15751
		[CodegenExclude]
		private StationRecipe recipe;

		// Token: 0x04003D88 RID: 15752
		public string RecipeID;

		// Token: 0x04003D89 RID: 15753
		public EQuality ProductQuality;

		// Token: 0x04003D8A RID: 15754
		public Color StartLiquidColor;

		// Token: 0x04003D8B RID: 15755
		public float LiquidLevel;

		// Token: 0x04003D8C RID: 15756
		public int CurrentTime;
	}
}
