using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management;
using ScheduleOne.StationFramework;
using ScheduleOne.UI.Stations;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000B00 RID: 2816
	public class RecipeSelector : ClipboardScreen
	{
		// Token: 0x06004B50 RID: 19280 RVA: 0x0013CCA0 File Offset: 0x0013AEA0
		public void Initialize(string selectionTitle, List<StationRecipe> _options, StationRecipe _selectedOption = null, Action<StationRecipe> _optionCallback = null)
		{
			this.TitleLabel.text = selectionTitle;
			this.options = new List<StationRecipe>();
			this.options.AddRange(_options);
			this.selectedOption = _selectedOption;
			this.optionCallback = _optionCallback;
			this.DeleteOptions();
			this.CreateOptions(this.options);
		}

		// Token: 0x06004B51 RID: 19281 RVA: 0x0013CCF4 File Offset: 0x0013AEF4
		public override void Open()
		{
			base.Open();
			Debug.Log(this.Container.gameObject.name + " is active: " + this.Container.gameObject.activeSelf.ToString());
			Singleton<ManagementInterface>.Instance.MainScreen.Close();
		}

		// Token: 0x06004B52 RID: 19282 RVA: 0x0013CD4D File Offset: 0x0013AF4D
		public override void Close()
		{
			base.Close();
			Debug.Log("Closed");
			Singleton<ManagementInterface>.Instance.MainScreen.Open();
		}

		// Token: 0x06004B53 RID: 19283 RVA: 0x0013CD6E File Offset: 0x0013AF6E
		private void ButtonClicked(StationRecipe option)
		{
			if (this.optionCallback != null)
			{
				this.optionCallback(option);
			}
			this.Close();
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x0013CD8C File Offset: 0x0013AF8C
		private void CreateOptions(List<StationRecipe> options)
		{
			options.Sort((StationRecipe a, StationRecipe b) => a.RecipeTitle.CompareTo(b.RecipeTitle));
			for (int i = 0; i < options.Count; i++)
			{
				StationRecipeEntry component = Object.Instantiate<GameObject>(this.OptionPrefab, this.OptionContainer).GetComponent<StationRecipeEntry>();
				component.AssignRecipe(options[i]);
				if (options[i] == this.selectedOption)
				{
					component.transform.Find("Selected").gameObject.GetComponent<Image>().color = new Color32(90, 90, 90, byte.MaxValue);
				}
				StationRecipe opt = options[i];
				component.Button.onClick.AddListener(new UnityAction(delegate()
				{
					this.ButtonClicked(opt);
				}));
				this.optionButtons.Add(component.GetComponent<RectTransform>());
			}
		}

		// Token: 0x06004B55 RID: 19285 RVA: 0x0013CE88 File Offset: 0x0013B088
		private void DeleteOptions()
		{
			for (int i = 0; i < this.optionButtons.Count; i++)
			{
				Object.Destroy(this.optionButtons[i].gameObject);
			}
			this.optionButtons.Clear();
		}

		// Token: 0x0400387E RID: 14462
		[Header("References")]
		public RectTransform OptionContainer;

		// Token: 0x0400387F RID: 14463
		public TextMeshProUGUI TitleLabel;

		// Token: 0x04003880 RID: 14464
		public GameObject OptionPrefab;

		// Token: 0x04003881 RID: 14465
		[Header("Settings")]
		public Sprite EmptyOptionSprite;

		// Token: 0x04003882 RID: 14466
		private Coroutine lerpRoutine;

		// Token: 0x04003883 RID: 14467
		private List<StationRecipe> options = new List<StationRecipe>();

		// Token: 0x04003884 RID: 14468
		private StationRecipe selectedOption;

		// Token: 0x04003885 RID: 14469
		private List<RectTransform> optionButtons = new List<RectTransform>();

		// Token: 0x04003886 RID: 14470
		private Action<StationRecipe> optionCallback;
	}
}
