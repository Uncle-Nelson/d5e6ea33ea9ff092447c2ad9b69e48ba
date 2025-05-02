using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts.WateringCan;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000B6E RID: 2926
	public class ItemUI_WateringCan : ItemUI
	{
		// Token: 0x06004DF1 RID: 19953 RVA: 0x00148160 File Offset: 0x00146360
		public override void Setup(ItemInstance item)
		{
			this.wcInstance = (item as WateringCanInstance);
			base.Setup(item);
		}

		// Token: 0x06004DF2 RID: 19954 RVA: 0x00148178 File Offset: 0x00146378
		public override void UpdateUI()
		{
			base.UpdateUI();
			if (this.Destroyed)
			{
				return;
			}
			if (this.wcInstance == null)
			{
				return;
			}
			this.AmountLabel.text = ((float)Mathf.RoundToInt(this.wcInstance.CurrentFillAmount * 10f) / 10f).ToString() + "L";
		}

		// Token: 0x04003AC4 RID: 15044
		protected WateringCanInstance wcInstance;

		// Token: 0x04003AC5 RID: 15045
		public Text AmountLabel;
	}
}
