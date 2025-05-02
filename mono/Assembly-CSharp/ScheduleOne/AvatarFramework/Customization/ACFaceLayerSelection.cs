using System;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020009A4 RID: 2468
	public class ACFaceLayerSelection : ACSelection<FaceLayer>
	{
		// Token: 0x060042CC RID: 17100 RVA: 0x001182E9 File Offset: 0x001164E9
		public override string GetOptionLabel(int index)
		{
			return this.Options[index].Name;
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x001182FC File Offset: 0x001164FC
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

		// Token: 0x060042CE RID: 17102 RVA: 0x00118370 File Offset: 0x00116570
		public override int GetAssetPathIndex(string path)
		{
			FaceLayer faceLayer = this.Options.Find((FaceLayer x) => x.AssetPath == path);
			if (!(faceLayer != null))
			{
				return -1;
			}
			return this.Options.IndexOf(faceLayer);
		}
	}
}
