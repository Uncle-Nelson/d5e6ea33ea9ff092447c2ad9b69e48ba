using System;
using ScheduleOne.ItemFramework;
using UnityEngine.UI;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000B70 RID: 2928
	public class IntegerItemUI : ItemUI
	{
		// Token: 0x06004DF6 RID: 19958 RVA: 0x00148282 File Offset: 0x00146482
		public override void Setup(ItemInstance item)
		{
			this.integerItemInstance = (item as IntegerItemInstance);
			base.Setup(item);
		}

		// Token: 0x06004DF7 RID: 19959 RVA: 0x00148297 File Offset: 0x00146497
		public override void UpdateUI()
		{
			if (this.Destroyed)
			{
				return;
			}
			this.ValueLabel.text = this.integerItemInstance.Value.ToString();
			base.UpdateUI();
		}

		// Token: 0x04003AC7 RID: 15047
		public Text ValueLabel;

		// Token: 0x04003AC8 RID: 15048
		protected IntegerItemInstance integerItemInstance;
	}
}
