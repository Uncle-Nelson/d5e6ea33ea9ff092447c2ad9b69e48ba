using System;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020009A1 RID: 2465
	public class ACAvatarLayerSelection : ACSelection<AvatarLayer>
	{
		// Token: 0x060042C4 RID: 17092 RVA: 0x001181E0 File Offset: 0x001163E0
		public override string GetOptionLabel(int index)
		{
			return this.Options[index].Name;
		}

		// Token: 0x060042C5 RID: 17093 RVA: 0x001181F4 File Offset: 0x001163F4
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

		// Token: 0x060042C6 RID: 17094 RVA: 0x00118268 File Offset: 0x00116468
		public override int GetAssetPathIndex(string path)
		{
			AvatarLayer avatarLayer = this.Options.Find((AvatarLayer x) => x.AssetPath == path);
			if (!(avatarLayer != null))
			{
				return -1;
			}
			return this.Options.IndexOf(avatarLayer);
		}
	}
}
