using System;
using ScheduleOne.AvatarFramework;

namespace ScheduleOne.UI.CharacterCustomization
{
	// Token: 0x02000B3F RID: 2879
	public class TattooShopUI : CharacterCustomizationUI
	{
		// Token: 0x06004CA5 RID: 19621 RVA: 0x0014367C File Offset: 0x0014187C
		public override bool IsOptionCurrentlyApplied(CharacterCustomizationOption option)
		{
			Console.Log("Checking if tattoo is applied: " + option.Label, null);
			Console.Log((this.currentSettings.Tattoos != null) ? string.Join(", ", this.currentSettings.Tattoos.ToArray()) : "No tattoos applied", null);
			return this.currentSettings.Tattoos != null && this.currentSettings.Tattoos.Contains(option.Label);
		}

		// Token: 0x06004CA6 RID: 19622 RVA: 0x001436F8 File Offset: 0x001418F8
		public override void OptionSelected(CharacterCustomizationOption option)
		{
			base.OptionSelected(option);
			if (!this.currentSettings.Tattoos.Contains(option.Label))
			{
				this.currentSettings.Tattoos.Add(option.Label);
			}
			AvatarSettings avatarSettings = this.currentSettings.GetAvatarSettings();
			this.AvatarRig.ApplyBodyLayerSettings(avatarSettings, 19);
			this.AvatarRig.ApplyFaceLayerSettings(avatarSettings);
		}

		// Token: 0x06004CA7 RID: 19623 RVA: 0x00143760 File Offset: 0x00141960
		public override void OptionDeselected(CharacterCustomizationOption option)
		{
			base.OptionDeselected(option);
			this.currentSettings.Tattoos.Remove(option.Label);
			AvatarSettings avatarSettings = this.currentSettings.GetAvatarSettings();
			this.AvatarRig.ApplyBodyLayerSettings(avatarSettings, 19);
			this.AvatarRig.ApplyFaceLayerSettings(avatarSettings);
		}
	}
}
