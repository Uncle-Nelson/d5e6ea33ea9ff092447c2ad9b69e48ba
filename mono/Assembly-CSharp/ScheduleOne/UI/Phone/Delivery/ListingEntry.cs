using System;
using ScheduleOne.Money;
using ScheduleOne.UI.Shop;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Delivery
{
	// Token: 0x02000ABA RID: 2746
	public class ListingEntry : MonoBehaviour
	{
		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x060049E3 RID: 18915 RVA: 0x00135AFA File Offset: 0x00133CFA
		// (set) Token: 0x060049E4 RID: 18916 RVA: 0x00135B02 File Offset: 0x00133D02
		public ShopListing MatchingListing { get; private set; }

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x060049E5 RID: 18917 RVA: 0x00135B0B File Offset: 0x00133D0B
		// (set) Token: 0x060049E6 RID: 18918 RVA: 0x00135B13 File Offset: 0x00133D13
		public int SelectedQuantity { get; private set; }

		// Token: 0x060049E7 RID: 18919 RVA: 0x00135B1C File Offset: 0x00133D1C
		public void Initialize(ShopListing match)
		{
			this.MatchingListing = match;
			this.Icon.sprite = this.MatchingListing.Item.Icon;
			this.ItemNameLabel.text = this.MatchingListing.Item.Name;
			this.ItemPriceLabel.text = MoneyManager.FormatAmount(this.MatchingListing.Price, false, false);
			this.QuantityInput.onSubmit.AddListener(new UnityAction<string>(this.OnQuantityInputSubmitted));
			this.QuantityInput.onEndEdit.AddListener(new UnityAction<string>(delegate(string value)
			{
				this.ValidateInput();
			}));
			this.IncrementButton.onClick.AddListener(new UnityAction(delegate()
			{
				this.ChangeQuantity(1);
			}));
			this.DecrementButton.onClick.AddListener(new UnityAction(delegate()
			{
				this.ChangeQuantity(-1);
			}));
			this.QuantityInput.SetTextWithoutNotify(this.SelectedQuantity.ToString());
			this.RefreshLocked();
		}

		// Token: 0x060049E8 RID: 18920 RVA: 0x00135C12 File Offset: 0x00133E12
		public void RefreshLocked()
		{
			if (this.MatchingListing.Item.IsPurchasable)
			{
				this.LockedContainer.gameObject.SetActive(false);
				return;
			}
			this.LockedContainer.gameObject.SetActive(true);
		}

		// Token: 0x060049E9 RID: 18921 RVA: 0x00135C4C File Offset: 0x00133E4C
		public void SetQuantity(int quant, bool notify = true)
		{
			if (!this.MatchingListing.Item.IsPurchasable)
			{
				quant = 0;
			}
			this.SelectedQuantity = Mathf.Clamp(quant, 0, 999);
			this.QuantityInput.SetTextWithoutNotify(this.SelectedQuantity.ToString());
			if (notify && this.onQuantityChanged != null)
			{
				this.onQuantityChanged.Invoke();
			}
		}

		// Token: 0x060049EA RID: 18922 RVA: 0x00135CAF File Offset: 0x00133EAF
		private void ChangeQuantity(int change)
		{
			this.SetQuantity(this.SelectedQuantity + change, true);
		}

		// Token: 0x060049EB RID: 18923 RVA: 0x00135CC0 File Offset: 0x00133EC0
		private void OnQuantityInputSubmitted(string value)
		{
			int quant;
			if (int.TryParse(value, out quant))
			{
				this.SetQuantity(quant, true);
				return;
			}
			this.SetQuantity(0, true);
		}

		// Token: 0x060049EC RID: 18924 RVA: 0x00135CE8 File Offset: 0x00133EE8
		private void ValidateInput()
		{
			this.OnQuantityInputSubmitted(this.QuantityInput.text);
		}

		// Token: 0x040036FE RID: 14078
		[Header("References")]
		public Image Icon;

		// Token: 0x040036FF RID: 14079
		public Text ItemNameLabel;

		// Token: 0x04003700 RID: 14080
		public Text ItemPriceLabel;

		// Token: 0x04003701 RID: 14081
		public InputField QuantityInput;

		// Token: 0x04003702 RID: 14082
		public Button IncrementButton;

		// Token: 0x04003703 RID: 14083
		public Button DecrementButton;

		// Token: 0x04003704 RID: 14084
		public RectTransform LockedContainer;

		// Token: 0x04003705 RID: 14085
		public UnityEvent onQuantityChanged;
	}
}
