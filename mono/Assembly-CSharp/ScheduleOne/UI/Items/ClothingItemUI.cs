using System;
using ScheduleOne.Clothing;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000B6F RID: 2927
	public class ClothingItemUI : ItemUI
	{
		// Token: 0x06004DF4 RID: 19956 RVA: 0x001481D8 File Offset: 0x001463D8
		public override void UpdateUI()
		{
			base.UpdateUI();
			ClothingInstance clothingInstance = this.itemInstance as ClothingInstance;
			if (this.itemInstance != null && (this.itemInstance.Definition as ClothingDefinition).Colorable)
			{
				this.IconImg.color = clothingInstance.Color.GetActualColor();
			}
			else
			{
				this.IconImg.color = Color.white;
			}
			if (this.itemInstance != null)
			{
				this.ClothingTypeIcon.sprite = Singleton<ClothingUtility>.Instance.GetSlotData((this.itemInstance.Definition as ClothingDefinition).Slot).Icon;
				return;
			}
			this.ClothingTypeIcon.sprite = null;
		}

		// Token: 0x04003AC6 RID: 15046
		public Image ClothingTypeIcon;
	}
}
