using System;
using ScheduleOne.Management;
using ScheduleOne.ObjectScripts;
using ScheduleOne.UI.Stations;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000B09 RID: 2825
	public class ChemistryStationUIElement : WorldspaceUIElement
	{
		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06004B82 RID: 19330 RVA: 0x0013DAD7 File Offset: 0x0013BCD7
		// (set) Token: 0x06004B83 RID: 19331 RVA: 0x0013DADF File Offset: 0x0013BCDF
		public ChemistryStation AssignedStation { get; protected set; }

		// Token: 0x06004B84 RID: 19332 RVA: 0x0013DAE8 File Offset: 0x0013BCE8
		public void Initialize(ChemistryStation oven)
		{
			this.AssignedStation = oven;
			this.AssignedStation.Configuration.onChanged.AddListener(new UnityAction(this.RefreshUI));
			this.RefreshUI();
			base.gameObject.SetActive(false);
		}

		// Token: 0x06004B85 RID: 19333 RVA: 0x0013DB28 File Offset: 0x0013BD28
		protected virtual void RefreshUI()
		{
			ChemistryStationConfiguration chemistryStationConfiguration = this.AssignedStation.Configuration as ChemistryStationConfiguration;
			base.SetAssignedNPC(chemistryStationConfiguration.AssignedChemist.SelectedNPC);
			if (chemistryStationConfiguration.Recipe.SelectedRecipe != null)
			{
				this.RecipeEntry.AssignRecipe(chemistryStationConfiguration.Recipe.SelectedRecipe);
				this.RecipeEntry.gameObject.SetActive(true);
				this.NoRecipe.SetActive(false);
				return;
			}
			this.RecipeEntry.gameObject.SetActive(false);
			this.NoRecipe.SetActive(true);
		}

		// Token: 0x040038A9 RID: 14505
		[Header("References")]
		public StationRecipeEntry RecipeEntry;

		// Token: 0x040038AA RID: 14506
		public GameObject NoRecipe;
	}
}
