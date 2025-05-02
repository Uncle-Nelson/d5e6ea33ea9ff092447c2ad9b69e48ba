using System;
using ScheduleOne.Money;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000B5A RID: 2906
	public class ListingUI : MonoBehaviour
	{
		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06004D58 RID: 19800 RVA: 0x00146153 File Offset: 0x00144353
		// (set) Token: 0x06004D59 RID: 19801 RVA: 0x0014615B File Offset: 0x0014435B
		public ShopListing Listing { get; protected set; }

		// Token: 0x06004D5A RID: 19802 RVA: 0x00146164 File Offset: 0x00144364
		public virtual void Initialize(ShopListing listing)
		{
			this.Listing = listing;
			this.Icon.sprite = listing.Item.Icon;
			this.Icon.color = (listing.UseIconTint ? listing.IconTint : Color.white);
			this.NameLabel.text = listing.Item.Name;
			this.UpdatePrice();
			this.UpdateStock();
			EventTrigger.Entry entry = new EventTrigger.Entry();
			entry.eventID = 0;
			entry.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData <p0>)
			{
				this.HoverStart();
			}));
			this.Trigger.triggers.Add(entry);
			EventTrigger.Entry entry2 = new EventTrigger.Entry();
			entry2.eventID = 1;
			entry2.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData <p0>)
			{
				this.HoverEnd();
			}));
			this.Trigger.triggers.Add(entry2);
			listing.onStockChanged = (Action)Delegate.Combine(listing.onStockChanged, new Action(this.StockChanged));
			this.BuyButton.onClick.AddListener(new UnityAction(this.Clicked));
			this.DropdownButton.onClick.AddListener(new UnityAction(this.DropdownClicked));
			this.UpdateLockStatus();
		}

		// Token: 0x06004D5B RID: 19803 RVA: 0x0014629A File Offset: 0x0014449A
		public virtual RectTransform GetIconCopy(RectTransform parent)
		{
			return Object.Instantiate<GameObject>(this.Icon.gameObject, parent).GetComponent<RectTransform>();
		}

		// Token: 0x06004D5C RID: 19804 RVA: 0x001462B2 File Offset: 0x001444B2
		public void Update()
		{
			this.UpdateButtons();
		}

		// Token: 0x06004D5D RID: 19805 RVA: 0x001462BA File Offset: 0x001444BA
		private void Clicked()
		{
			if (this.onClicked != null)
			{
				this.onClicked();
			}
		}

		// Token: 0x06004D5E RID: 19806 RVA: 0x001462CF File Offset: 0x001444CF
		private void DropdownClicked()
		{
			if (this.onDropdownClicked != null)
			{
				this.onDropdownClicked();
			}
		}

		// Token: 0x06004D5F RID: 19807 RVA: 0x001462E4 File Offset: 0x001444E4
		private void HoverStart()
		{
			if (this.hoverStart != null)
			{
				this.hoverStart();
			}
		}

		// Token: 0x06004D60 RID: 19808 RVA: 0x001462F9 File Offset: 0x001444F9
		private void HoverEnd()
		{
			if (this.hoverEnd != null)
			{
				this.hoverEnd();
			}
		}

		// Token: 0x06004D61 RID: 19809 RVA: 0x0014630E File Offset: 0x0014450E
		private void StockChanged()
		{
			this.UpdateButtons();
			this.UpdatePrice();
			this.UpdateStock();
		}

		// Token: 0x06004D62 RID: 19810 RVA: 0x00146322 File Offset: 0x00144522
		private void UpdatePrice()
		{
			this.PriceLabel.text = MoneyManager.FormatAmount(this.Listing.Price, false, false);
			this.PriceLabel.color = ListingUI.PriceLabelColor_Normal;
		}

		// Token: 0x06004D63 RID: 19811 RVA: 0x00146358 File Offset: 0x00144558
		private void UpdateStock()
		{
			if (this.StockLabel == null)
			{
				return;
			}
			if (this.Listing.IsUnlimitedStock)
			{
				this.StockLabel.enabled = false;
				return;
			}
			int currentStockMinusCart = this.Listing.CurrentStockMinusCart;
			this.StockLabel.text = currentStockMinusCart.ToString() + " / " + this.Listing.DefaultStock.ToString();
			if (currentStockMinusCart > 0)
			{
				this.StockLabel.color = this.StockLabelDefault;
			}
			else
			{
				this.StockLabel.text = "Out of stock";
				this.StockLabel.color = this.StockLabelNone;
			}
			if (currentStockMinusCart == 1 && this.Listing.RestockRate == ShopListing.ERestockRate.Never)
			{
				this.StockLabel.text = "1 of 1";
			}
			this.StockLabel.enabled = true;
		}

		// Token: 0x06004D64 RID: 19812 RVA: 0x00146438 File Offset: 0x00144638
		private void UpdateButtons()
		{
			bool interactable = this.CanAddToCart();
			this.BuyButton.interactable = interactable;
			this.DropdownButton.interactable = interactable;
		}

		// Token: 0x06004D65 RID: 19813 RVA: 0x00146464 File Offset: 0x00144664
		public bool CanAddToCart()
		{
			return this.Listing.IsUnlimitedStock || this.Listing.CurrentStockMinusCart > 0;
		}

		// Token: 0x06004D66 RID: 19814 RVA: 0x00146483 File Offset: 0x00144683
		public void UpdateLockStatus()
		{
			this.LockedContainer.gameObject.SetActive(!this.Listing.Item.IsPurchasable);
		}

		// Token: 0x04003A48 RID: 14920
		public static Color32 PriceLabelColor_Normal = new Color32(90, 185, 90, byte.MaxValue);

		// Token: 0x04003A49 RID: 14921
		public static Color32 PriceLabelColor_NoStock = new Color32(165, 70, 60, byte.MaxValue);

		// Token: 0x04003A4B RID: 14923
		[Header("Colors")]
		public Color32 StockLabelDefault = new Color32(40, 40, 40, byte.MaxValue);

		// Token: 0x04003A4C RID: 14924
		public Color32 StockLabelNone = new Color32(185, 55, 55, byte.MaxValue);

		// Token: 0x04003A4D RID: 14925
		[Header("References")]
		public Image Icon;

		// Token: 0x04003A4E RID: 14926
		public TextMeshProUGUI NameLabel;

		// Token: 0x04003A4F RID: 14927
		public TextMeshProUGUI PriceLabel;

		// Token: 0x04003A50 RID: 14928
		public TextMeshProUGUI StockLabel;

		// Token: 0x04003A51 RID: 14929
		public GameObject LockedContainer;

		// Token: 0x04003A52 RID: 14930
		public Button BuyButton;

		// Token: 0x04003A53 RID: 14931
		public Button DropdownButton;

		// Token: 0x04003A54 RID: 14932
		public EventTrigger Trigger;

		// Token: 0x04003A55 RID: 14933
		public RectTransform DetailPanelAnchor;

		// Token: 0x04003A56 RID: 14934
		public RectTransform DropdownAnchor;

		// Token: 0x04003A57 RID: 14935
		public RectTransform TopDropdownAnchor;

		// Token: 0x04003A58 RID: 14936
		public Action hoverStart;

		// Token: 0x04003A59 RID: 14937
		public Action hoverEnd;

		// Token: 0x04003A5A RID: 14938
		public Action onClicked;

		// Token: 0x04003A5B RID: 14939
		public Action onDropdownClicked;
	}
}
