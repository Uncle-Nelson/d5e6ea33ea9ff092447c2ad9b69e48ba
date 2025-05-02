using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using TMPro;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000B6D RID: 2925
	public class ItemUI_Cash : ItemUI
	{
		// Token: 0x06004DED RID: 19949 RVA: 0x0014810C File Offset: 0x0014630C
		public override void Setup(ItemInstance item)
		{
			this.cashInstance = (item as CashInstance);
			base.Setup(item);
		}

		// Token: 0x06004DEE RID: 19950 RVA: 0x00148121 File Offset: 0x00146321
		public override void UpdateUI()
		{
			base.UpdateUI();
			if (this.Destroyed)
			{
				return;
			}
			this.SetDisplayedBalance(this.cashInstance.Balance);
		}

		// Token: 0x06004DEF RID: 19951 RVA: 0x00148143 File Offset: 0x00146343
		public void SetDisplayedBalance(float balance)
		{
			this.AmountLabel.text = MoneyManager.FormatAmount(balance, false, false);
		}

		// Token: 0x04003AC2 RID: 15042
		protected CashInstance cashInstance;

		// Token: 0x04003AC3 RID: 15043
		public TextMeshProUGUI AmountLabel;
	}
}
