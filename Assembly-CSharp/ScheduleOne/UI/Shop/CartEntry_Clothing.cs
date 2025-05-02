using System;
using ScheduleOne.Clothing;
using TMPro;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000B55 RID: 2901
	public class CartEntry_Clothing : CartEntry
	{
		// Token: 0x06004D46 RID: 19782 RVA: 0x00145D8C File Offset: 0x00143F8C
		protected override void UpdateTitle()
		{
			base.UpdateTitle();
			if ((base.Listing.Item as ClothingDefinition).Colorable)
			{
				TextMeshProUGUI nameLabel = this.NameLabel;
				nameLabel.text = nameLabel.text + " (" + (base.Listing as ClothingShopListing).Color.GetLabel() + ")";
			}
		}
	}
}
