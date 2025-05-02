using System;
using HSVPicker;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCustomization
{
	// Token: 0x02000B37 RID: 2871
	public class BarbershopUI : CharacterCustomizationUI
	{
		// Token: 0x06004C60 RID: 19552 RVA: 0x0014275B File Offset: 0x0014095B
		public override bool IsOptionCurrentlyApplied(CharacterCustomizationOption option)
		{
			return this.currentSettings.HairStyle == option.Label;
		}

		// Token: 0x06004C61 RID: 19553 RVA: 0x00142773 File Offset: 0x00140973
		public override void OptionSelected(CharacterCustomizationOption option)
		{
			base.OptionSelected(option);
			this.currentSettings.HairStyle = option.Label;
			this.AvatarRig.ApplyHairSettings(this.currentSettings.GetAvatarSettings());
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x001427A3 File Offset: 0x001409A3
		protected override void Update()
		{
			base.Update();
			if (!base.IsOpen)
			{
				return;
			}
			this.currentSettings == null;
		}

		// Token: 0x06004C63 RID: 19555 RVA: 0x001427C1 File Offset: 0x001409C1
		public override void Open()
		{
			base.Open();
			this.ColorPicker.CurrentColor = this.currentSettings.HairColor;
			this.appliedColor = this.currentSettings.HairColor;
			this.ApplyColorButton.interactable = false;
		}

		// Token: 0x06004C64 RID: 19556 RVA: 0x001427FC File Offset: 0x001409FC
		public void ColorFieldChanged(Color color)
		{
			this.currentSettings.HairColor = color;
			this.AvatarRig.ApplyHairColorSettings(this.currentSettings.GetAvatarSettings());
			this.ApplyColorButton.interactable = true;
		}

		// Token: 0x06004C65 RID: 19557 RVA: 0x0014282C File Offset: 0x00140A2C
		public void ApplyColorChange()
		{
			this.appliedColor = this.ColorPicker.CurrentColor;
			this.currentSettings.HairColor = this.appliedColor;
			this.AvatarRig.ApplyHairSettings(this.currentSettings.GetAvatarSettings());
			this.ApplyColorButton.interactable = false;
		}

		// Token: 0x06004C66 RID: 19558 RVA: 0x00142880 File Offset: 0x00140A80
		public void RevertColorChange()
		{
			this.ColorPicker.CurrentColor = this.currentSettings.HairColor;
			this.currentSettings.HairColor = this.appliedColor;
			this.AvatarRig.ApplyHairSettings(this.currentSettings.GetAvatarSettings());
			this.ApplyColorButton.interactable = false;
		}

		// Token: 0x04003984 RID: 14724
		public ColorPicker ColorPicker;

		// Token: 0x04003985 RID: 14725
		public Button ApplyColorButton;

		// Token: 0x04003986 RID: 14726
		private Color appliedColor = Color.black;
	}
}
