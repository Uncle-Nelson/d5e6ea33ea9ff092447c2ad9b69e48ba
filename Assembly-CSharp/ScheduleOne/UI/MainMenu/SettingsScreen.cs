using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Settings;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000B25 RID: 2853
	public class SettingsScreen : MainMenuScreen
	{
		// Token: 0x06004C08 RID: 19464 RVA: 0x0013F5B7 File Offset: 0x0013D7B7
		protected override void Awake()
		{
			base.Awake();
			this.ApplyDisplayButton.onClick.AddListener(new UnityAction(this.ApplyDisplaySettings));
			this.ApplyDisplayButton.gameObject.SetActive(false);
		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x0013F5EC File Offset: 0x0013D7EC
		protected void Start()
		{
			for (int i = 0; i < this.Categories.Length; i++)
			{
				int index = i;
				this.Categories[i].Button.onClick.AddListener(new UnityAction(delegate()
				{
					this.ShowCategory(index);
				}));
			}
			this.ShowCategory(0);
		}

		// Token: 0x06004C0A RID: 19466 RVA: 0x0013F64C File Offset: 0x0013D84C
		public void ShowCategory(int index)
		{
			for (int i = 0; i < this.Categories.Length; i++)
			{
				this.Categories[i].Button.interactable = (i != index);
				this.Categories[i].Panel.SetActive(i == index);
			}
		}

		// Token: 0x06004C0B RID: 19467 RVA: 0x0013F69B File Offset: 0x0013D89B
		public void DisplayChanged()
		{
			this.ApplyDisplayButton.gameObject.SetActive(true);
		}

		// Token: 0x06004C0C RID: 19468 RVA: 0x0013F6B0 File Offset: 0x0013D8B0
		private void ApplyDisplaySettings()
		{
			this.ApplyDisplayButton.gameObject.SetActive(false);
			DisplaySettings displaySettings = Singleton<Settings>.Instance.DisplaySettings;
			DisplaySettings unappliedDisplaySettings = Singleton<Settings>.Instance.UnappliedDisplaySettings;
			Singleton<Settings>.Instance.ApplyDisplaySettings(unappliedDisplaySettings);
			this.ConfirmDisplaySettings.Open(displaySettings, unappliedDisplaySettings);
		}

		// Token: 0x04003901 RID: 14593
		public SettingsScreen.SettingsCategory[] Categories;

		// Token: 0x04003902 RID: 14594
		public Button ApplyDisplayButton;

		// Token: 0x04003903 RID: 14595
		public ConfirmDisplaySettings ConfirmDisplaySettings;

		// Token: 0x02000B26 RID: 2854
		[Serializable]
		public class SettingsCategory
		{
			// Token: 0x04003904 RID: 14596
			public Button Button;

			// Token: 0x04003905 RID: 14597
			public GameObject Panel;
		}
	}
}
