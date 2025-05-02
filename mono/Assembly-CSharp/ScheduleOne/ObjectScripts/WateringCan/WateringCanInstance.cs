using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x02000BFA RID: 3066
	[Serializable]
	public class WateringCanInstance : StorableItemInstance
	{
		// Token: 0x0600565C RID: 22108 RVA: 0x000D1AAE File Offset: 0x000CFCAE
		public WateringCanInstance()
		{
		}

		// Token: 0x0600565D RID: 22109 RVA: 0x0016B5EC File Offset: 0x001697EC
		public WateringCanInstance(ItemDefinition definition, int quantity, float fillAmount) : base(definition, quantity)
		{
			this.CurrentFillAmount = fillAmount;
		}

		// Token: 0x0600565E RID: 22110 RVA: 0x0016B600 File Offset: 0x00169800
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			int quantity = this.Quantity;
			if (overrideQuantity != -1)
			{
				quantity = overrideQuantity;
			}
			return new WateringCanInstance(base.Definition, quantity, this.CurrentFillAmount);
		}

		// Token: 0x0600565F RID: 22111 RVA: 0x0016B62C File Offset: 0x0016982C
		public void ChangeFillAmount(float change)
		{
			this.CurrentFillAmount = Mathf.Clamp(this.CurrentFillAmount + change, 0f, 15f);
			if (this.onDataChanged != null)
			{
				this.onDataChanged();
			}
		}

		// Token: 0x06005660 RID: 22112 RVA: 0x0016B65E File Offset: 0x0016985E
		public override ItemData GetItemData()
		{
			return new WateringCanData(this.ID, this.Quantity, this.CurrentFillAmount);
		}

		// Token: 0x04003FBC RID: 16316
		public float CurrentFillAmount;
	}
}
