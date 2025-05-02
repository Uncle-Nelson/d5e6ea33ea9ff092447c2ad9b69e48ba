using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management;
using ScheduleOne.StationFramework;
using ScheduleOne.UI.Stations;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AF5 RID: 2805
	public class StationRecipeFieldUI : MonoBehaviour
	{
		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06004AFE RID: 19198 RVA: 0x0013B14C File Offset: 0x0013934C
		// (set) Token: 0x06004AFF RID: 19199 RVA: 0x0013B154 File Offset: 0x00139354
		public List<StationRecipeField> Fields { get; protected set; } = new List<StationRecipeField>();

		// Token: 0x06004B00 RID: 19200 RVA: 0x0013B160 File Offset: 0x00139360
		public void Bind(List<StationRecipeField> field)
		{
			this.Fields = new List<StationRecipeField>();
			this.Fields.AddRange(field);
			this.Fields[this.Fields.Count - 1].onRecipeChanged.AddListener(new UnityAction<StationRecipe>(this.Refresh));
			this.Refresh(this.Fields[0].SelectedRecipe);
		}

		// Token: 0x06004B01 RID: 19201 RVA: 0x0013B1CC File Offset: 0x001393CC
		private void Refresh(StationRecipe newVal)
		{
			this.None.gameObject.SetActive(false);
			this.Mixed.gameObject.SetActive(false);
			this.ClearButton.gameObject.SetActive(false);
			this.RecipeEntry.gameObject.SetActive(false);
			if (this.AreFieldsUniform())
			{
				if (newVal != null)
				{
					this.ClearButton.gameObject.SetActive(true);
					this.RecipeEntry.AssignRecipe(newVal);
					this.RecipeEntry.gameObject.SetActive(true);
				}
				else
				{
					this.None.SetActive(true);
				}
			}
			else
			{
				this.Mixed.gameObject.SetActive(true);
				this.ClearButton.gameObject.SetActive(true);
			}
			this.ClearButton.gameObject.SetActive(false);
		}

		// Token: 0x06004B02 RID: 19202 RVA: 0x0013B2A0 File Offset: 0x001394A0
		private bool AreFieldsUniform()
		{
			for (int i = 0; i < this.Fields.Count - 1; i++)
			{
				if (this.Fields[i].SelectedRecipe != this.Fields[i + 1].SelectedRecipe)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x0013B2F4 File Offset: 0x001394F4
		public void Clicked()
		{
			bool flag = this.AreFieldsUniform();
			StationRecipe selectedOption = null;
			if (flag)
			{
				selectedOption = this.Fields[0].SelectedRecipe;
			}
			List<StationRecipe> options = (from x in this.Fields[0].Options
			where x.Unlocked
			select x).ToList<StationRecipe>();
			Singleton<ManagementInterface>.Instance.RecipeSelectorScreen.Initialize("Select Recipe", options, selectedOption, new Action<StationRecipe>(this.OptionSelected));
			Singleton<ManagementInterface>.Instance.RecipeSelectorScreen.Open();
		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x0013B38C File Offset: 0x0013958C
		private void OptionSelected(StationRecipe option)
		{
			foreach (StationRecipeField stationRecipeField in this.Fields)
			{
				stationRecipeField.SetRecipe(option, true);
			}
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x0013B3E0 File Offset: 0x001395E0
		public void ClearClicked()
		{
			foreach (StationRecipeField stationRecipeField in this.Fields)
			{
				stationRecipeField.SetRecipe(null, true);
			}
		}

		// Token: 0x0400383F RID: 14399
		[Header("References")]
		public StationRecipeEntry RecipeEntry;

		// Token: 0x04003840 RID: 14400
		public GameObject None;

		// Token: 0x04003841 RID: 14401
		public GameObject Mixed;

		// Token: 0x04003842 RID: 14402
		public GameObject ClearButton;
	}
}
