using System;
using ScheduleOne.Clothing;
using ScheduleOne.DevUtilities;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x020009FC RID: 2556
	public class ClothingSlotUI : ItemSlotUI
	{
		// Token: 0x060044DE RID: 17630 RVA: 0x001204B1 File Offset: 0x0011E6B1
		private void Start()
		{
			this.SlotTypeImage.sprite = Singleton<ClothingUtility>.Instance.GetSlotData(this.SlotType).Icon;
		}

		// Token: 0x04003264 RID: 12900
		public EClothingSlot SlotType;

		// Token: 0x04003265 RID: 12901
		public Image SlotTypeImage;
	}
}
