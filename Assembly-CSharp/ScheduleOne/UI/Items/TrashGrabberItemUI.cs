using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts.WateringCan;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000B7B RID: 2939
	public class TrashGrabberItemUI : ItemUI
	{
		// Token: 0x06004E36 RID: 20022 RVA: 0x0014A120 File Offset: 0x00148320
		public override void Setup(ItemInstance item)
		{
			this.trashGrabberInstance = (item as TrashGrabberInstance);
			base.Setup(item);
		}

		// Token: 0x06004E37 RID: 20023 RVA: 0x0014A138 File Offset: 0x00148338
		public override void UpdateUI()
		{
			if (this.Destroyed)
			{
				return;
			}
			this.ValueLabel.text = Mathf.FloorToInt(Mathf.Clamp01((float)this.trashGrabberInstance.GetTotalSize() / 20f) * 100f).ToString() + "%";
			base.UpdateUI();
		}

		// Token: 0x04003B03 RID: 15107
		public TextMeshProUGUI ValueLabel;

		// Token: 0x04003B04 RID: 15108
		protected TrashGrabberInstance trashGrabberInstance;
	}
}
