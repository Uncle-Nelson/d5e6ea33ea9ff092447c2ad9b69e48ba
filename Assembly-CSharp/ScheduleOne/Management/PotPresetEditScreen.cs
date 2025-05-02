using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management.Presets;
using ScheduleOne.Management.Presets.Options;
using ScheduleOne.Management.SetterScreens;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x02000585 RID: 1413
	public class PotPresetEditScreen : PresetEditScreen
	{
		// Token: 0x06002332 RID: 9010 RVA: 0x0009021C File Offset: 0x0008E41C
		protected override void Awake()
		{
			base.Awake();
			this.SeedsUI.Button.onClick.AddListener(new UnityAction(this.SeedsUIClicked));
			this.AdditivesUI.Button.onClick.AddListener(new UnityAction(this.AdditivesUIClicked));
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x00090271 File Offset: 0x0008E471
		protected virtual void Update()
		{
			if (base.isOpen)
			{
				this.UpdateUI();
			}
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x00090281 File Offset: 0x0008E481
		public override void Open(Preset preset)
		{
			base.Open(preset);
			this.castedPreset = (PotPreset)this.EditedPreset;
			this.UpdateUI();
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x000902A4 File Offset: 0x0008E4A4
		private void UpdateUI()
		{
			this.SeedsUI.ValueLabel.text = this.castedPreset.Seeds.GetDisplayString();
			this.AdditivesUI.ValueLabel.text = this.castedPreset.Additives.GetDisplayString();
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x000902F1 File Offset: 0x0008E4F1
		public void SeedsUIClicked()
		{
			Singleton<ItemSetterScreen>.Instance.Open((this.EditedPreset as PotPreset).Seeds);
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x0009030D File Offset: 0x0008E50D
		public void AdditivesUIClicked()
		{
			Singleton<ItemSetterScreen>.Instance.Open((this.EditedPreset as PotPreset).Additives);
		}

		// Token: 0x04001A56 RID: 6742
		public GenericOptionUI SeedsUI;

		// Token: 0x04001A57 RID: 6743
		public GenericOptionUI AdditivesUI;

		// Token: 0x04001A58 RID: 6744
		private PotPreset castedPreset;
	}
}
