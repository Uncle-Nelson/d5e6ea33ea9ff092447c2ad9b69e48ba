using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management.UI;
using ScheduleOne.Tools;
using ScheduleOne.UI;
using ScheduleOne.UI.Management;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Management
{
	// Token: 0x0200058A RID: 1418
	public class ManagementInterface : Singleton<ManagementInterface>
	{
		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x000906F5 File Offset: 0x0008E8F5
		// (set) Token: 0x06002353 RID: 9043 RVA: 0x000906FD File Offset: 0x0008E8FD
		public ManagementClipboard_Equippable EquippedClipboard { get; protected set; }

		// Token: 0x06002354 RID: 9044 RVA: 0x00090706 File Offset: 0x0008E906
		protected override void Start()
		{
			base.Start();
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x00090710 File Offset: 0x0008E910
		public void Open(List<IConfigurable> configurables, ManagementClipboard_Equippable _equippedClipboard)
		{
			this.Configurables = new List<IConfigurable>();
			this.Configurables.AddRange(configurables);
			this.EquippedClipboard = _equippedClipboard;
			this.areConfigurablesUniform = true;
			if (this.Configurables.Count > 1)
			{
				for (int i = 0; i < this.Configurables.Count - 1; i++)
				{
					if (this.Configurables[i].ConfigurableType != this.Configurables[i + 1].ConfigurableType)
					{
						this.areConfigurablesUniform = false;
						break;
					}
				}
			}
			this.UpdateMainLabels();
			this.InitializeConfigPanel();
			Singleton<InputPromptsCanvas>.Instance.LoadModule("backonly_rightclick");
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x000907B4 File Offset: 0x0008E9B4
		public void Close(bool preserveState = false)
		{
			if (this.ItemSelectorScreen.IsOpen)
			{
				this.ItemSelectorScreen.Close();
			}
			if (this.RecipeSelectorScreen.IsOpen)
			{
				this.RecipeSelectorScreen.Close();
			}
			if (Singleton<InputPromptsCanvas>.Instance.currentModuleLabel == "exitonly")
			{
				Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			}
			this.DestroyConfigPanel();
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x00090817 File Offset: 0x0008EA17
		private void UpdateMainLabels()
		{
			this.NothingSelectedLabel.gameObject.SetActive(this.Configurables.Count == 0);
			this.DifferentTypesSelectedLabel.gameObject.SetActive(!this.areConfigurablesUniform);
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x00090850 File Offset: 0x0008EA50
		private void InitializeConfigPanel()
		{
			if (this.loadedPanel != null)
			{
				Console.LogWarning("InitializeConfigPanel called when there is an existing config panel. Destroying existing.", null);
				this.DestroyConfigPanel();
			}
			if (!this.areConfigurablesUniform || this.Configurables.Count == 0)
			{
				return;
			}
			ConfigPanel configPanelPrefab = this.GetConfigPanelPrefab(this.Configurables[0].ConfigurableType);
			this.loadedPanel = Object.Instantiate<ConfigPanel>(configPanelPrefab, this.PanelContainer).GetComponent<ConfigPanel>();
			this.loadedPanel.Bind((from x in this.Configurables
			select x.Configuration).ToList<EntityConfiguration>());
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x000908FB File Offset: 0x0008EAFB
		private void DestroyConfigPanel()
		{
			if (this.loadedPanel != null)
			{
				Object.Destroy(this.loadedPanel.gameObject);
				this.loadedPanel = null;
			}
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x00090924 File Offset: 0x0008EB24
		public ConfigPanel GetConfigPanelPrefab(EConfigurableType type)
		{
			return this.ConfigPanelPrefabs.FirstOrDefault((ManagementInterface.ConfigurableTypePanel x) => x.Type == type).Panel;
		}

		// Token: 0x04001A67 RID: 6759
		public const float PANEL_SLIDE_TIME = 0.1f;

		// Token: 0x04001A69 RID: 6761
		[Header("References")]
		public TextMeshProUGUI NothingSelectedLabel;

		// Token: 0x04001A6A RID: 6762
		public TextMeshProUGUI DifferentTypesSelectedLabel;

		// Token: 0x04001A6B RID: 6763
		public RectTransform PanelContainer;

		// Token: 0x04001A6C RID: 6764
		public ClipboardScreen MainScreen;

		// Token: 0x04001A6D RID: 6765
		public ScheduleOne.UI.Management.ItemSelector ItemSelectorScreen;

		// Token: 0x04001A6E RID: 6766
		public NPCSelector NPCSelector;

		// Token: 0x04001A6F RID: 6767
		public ScheduleOne.UI.Management.ObjectSelector ObjectSelector;

		// Token: 0x04001A70 RID: 6768
		public RecipeSelector RecipeSelectorScreen;

		// Token: 0x04001A71 RID: 6769
		public TransitEntitySelector TransitEntitySelector;

		// Token: 0x04001A72 RID: 6770
		[SerializeField]
		protected ManagementInterface.ConfigurableTypePanel[] ConfigPanelPrefabs;

		// Token: 0x04001A73 RID: 6771
		public List<IConfigurable> Configurables = new List<IConfigurable>();

		// Token: 0x04001A74 RID: 6772
		private bool areConfigurablesUniform;

		// Token: 0x04001A75 RID: 6773
		private ConfigPanel loadedPanel;

		// Token: 0x0200058B RID: 1419
		[Serializable]
		public class ConfigurableTypePanel
		{
			// Token: 0x04001A76 RID: 6774
			public EConfigurableType Type;

			// Token: 0x04001A77 RID: 6775
			public ConfigPanel Panel;
		}
	}
}
