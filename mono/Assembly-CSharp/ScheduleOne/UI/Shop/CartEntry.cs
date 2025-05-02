using System;
using ScheduleOne.Money;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000B54 RID: 2900
	public class CartEntry : MonoBehaviour
	{
		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06004D37 RID: 19767 RVA: 0x00145C07 File Offset: 0x00143E07
		// (set) Token: 0x06004D38 RID: 19768 RVA: 0x00145C0F File Offset: 0x00143E0F
		public int Quantity { get; protected set; }

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06004D39 RID: 19769 RVA: 0x00145C18 File Offset: 0x00143E18
		// (set) Token: 0x06004D3A RID: 19770 RVA: 0x00145C20 File Offset: 0x00143E20
		public Cart Cart { get; protected set; }

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06004D3B RID: 19771 RVA: 0x00145C29 File Offset: 0x00143E29
		// (set) Token: 0x06004D3C RID: 19772 RVA: 0x00145C31 File Offset: 0x00143E31
		public ShopListing Listing { get; protected set; }

		// Token: 0x06004D3D RID: 19773 RVA: 0x00145C3C File Offset: 0x00143E3C
		public void Initialize(Cart cart, ShopListing listing, int quantity)
		{
			this.Cart = cart;
			this.Listing = listing;
			this.Quantity = quantity;
			this.IncrementButton.onClick.AddListener(new UnityAction(delegate()
			{
				this.ChangeAmount(1);
			}));
			this.DecrementButton.onClick.AddListener(new UnityAction(delegate()
			{
				this.ChangeAmount(-1);
			}));
			this.RemoveButton.onClick.AddListener(new UnityAction(delegate()
			{
				this.ChangeAmount(-999);
			}));
			this.UpdateTitle();
			this.UpdatePrice();
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x00145CBE File Offset: 0x00143EBE
		public void SetQuantity(int quantity)
		{
			this.Quantity = quantity;
			this.UpdateTitle();
			this.UpdatePrice();
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x00145CD4 File Offset: 0x00143ED4
		protected virtual void UpdateTitle()
		{
			this.NameLabel.text = this.Quantity.ToString() + "x " + this.Listing.Item.Name;
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x00145D14 File Offset: 0x00143F14
		private void UpdatePrice()
		{
			this.PriceLabel.text = MoneyManager.FormatAmount((float)this.Quantity * this.Listing.Price, false, false);
		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x00145D3B File Offset: 0x00143F3B
		private void ChangeAmount(int change)
		{
			if (change > 0)
			{
				this.Cart.AddItem(this.Listing, change);
				return;
			}
			if (change < 0)
			{
				this.Cart.RemoveItem(this.Listing, -change);
			}
		}

		// Token: 0x04003A26 RID: 14886
		[Header("References")]
		public TextMeshProUGUI NameLabel;

		// Token: 0x04003A27 RID: 14887
		public TextMeshProUGUI PriceLabel;

		// Token: 0x04003A28 RID: 14888
		public Button IncrementButton;

		// Token: 0x04003A29 RID: 14889
		public Button DecrementButton;

		// Token: 0x04003A2A RID: 14890
		public Button RemoveButton;
	}
}
