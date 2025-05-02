using System;
using System.Collections.Generic;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.StationFramework;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x0200057B RID: 1403
	public class StationRecipeField : ConfigField
	{
		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x0008F880 File Offset: 0x0008DA80
		// (set) Token: 0x060022E6 RID: 8934 RVA: 0x0008F888 File Offset: 0x0008DA88
		public StationRecipe SelectedRecipe { get; protected set; }

		// Token: 0x060022E7 RID: 8935 RVA: 0x0008F891 File Offset: 0x0008DA91
		public StationRecipeField(EntityConfiguration parentConfig) : base(parentConfig)
		{
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x0008F8B0 File Offset: 0x0008DAB0
		public void SetRecipe(StationRecipe recipe, bool network)
		{
			this.SelectedRecipe = recipe;
			if (network)
			{
				base.ParentConfig.ReplicateField(this, null);
			}
			if (this.onRecipeChanged != null)
			{
				this.onRecipeChanged.Invoke(this.SelectedRecipe);
			}
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x0008F8E2 File Offset: 0x0008DAE2
		public override bool IsValueDefault()
		{
			return this.SelectedRecipe == null;
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x0008F8F0 File Offset: 0x0008DAF0
		public StationRecipeFieldData GetData()
		{
			return new StationRecipeFieldData((this.SelectedRecipe != null) ? this.SelectedRecipe.RecipeID.ToString() : "");
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x0008F91C File Offset: 0x0008DB1C
		public void Load(StationRecipeFieldData data)
		{
			if (data != null && !string.IsNullOrEmpty(data.RecipeID))
			{
				this.SelectedRecipe = this.Options.Find((StationRecipe x) => x.RecipeID == data.RecipeID);
			}
		}

		// Token: 0x04001A44 RID: 6724
		public List<StationRecipe> Options = new List<StationRecipe>();

		// Token: 0x04001A45 RID: 6725
		public UnityEvent<StationRecipe> onRecipeChanged = new UnityEvent<StationRecipe>();
	}
}
