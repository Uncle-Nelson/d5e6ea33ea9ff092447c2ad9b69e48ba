using System;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200099F RID: 2463
	public class ACAccessorySelection : ACSelection<Accessory>
	{
		// Token: 0x060042BE RID: 17086 RVA: 0x001180F3 File Offset: 0x001162F3
		public override string GetOptionLabel(int index)
		{
			return this.Options[index].Name;
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x00118108 File Offset: 0x00116308
		public override void CallValueChange()
		{
			if (this.onValueChange != null)
			{
				this.onValueChange.Invoke((this.SelectedOptionIndex == -1) ? null : this.Options[this.SelectedOptionIndex]);
			}
			if (this.onValueChangeWithIndex != null)
			{
				this.onValueChangeWithIndex.Invoke((this.SelectedOptionIndex == -1) ? null : this.Options[this.SelectedOptionIndex], this.PropertyIndex);
			}
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x0011817C File Offset: 0x0011637C
		public override int GetAssetPathIndex(string path)
		{
			Accessory accessory = this.Options.Find((Accessory x) => x.AssetPath == path);
			if (!(accessory != null))
			{
				return -1;
			}
			return this.Options.IndexOf(accessory);
		}
	}
}
