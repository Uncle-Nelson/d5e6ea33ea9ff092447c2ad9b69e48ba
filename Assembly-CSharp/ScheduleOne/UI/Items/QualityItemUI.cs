using System;
using ScheduleOne.ItemFramework;
using UnityEngine.UI;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000B7A RID: 2938
	public class QualityItemUI : ItemUI
	{
		// Token: 0x06004E33 RID: 20019 RVA: 0x0014A0D3 File Offset: 0x001482D3
		public override void Setup(ItemInstance item)
		{
			this.qualityItemInstance = (item as QualityItemInstance);
			base.Setup(item);
		}

		// Token: 0x06004E34 RID: 20020 RVA: 0x0014A0E8 File Offset: 0x001482E8
		public override void UpdateUI()
		{
			if (this.Destroyed)
			{
				return;
			}
			this.QualityIcon.enabled = true;
			this.QualityIcon.color = ItemQuality.GetColor(this.qualityItemInstance.Quality);
			base.UpdateUI();
		}

		// Token: 0x04003B01 RID: 15105
		public Image QualityIcon;

		// Token: 0x04003B02 RID: 15106
		protected QualityItemInstance qualityItemInstance;
	}
}
