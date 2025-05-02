using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Levelling;
using ScheduleOne.Messaging;
using ScheduleOne.Money;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000A93 RID: 2707
	public class PhoneShopInterface : MonoBehaviour
	{
		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x060048DD RID: 18653 RVA: 0x00131885 File Offset: 0x0012FA85
		// (set) Token: 0x060048DE RID: 18654 RVA: 0x0013188D File Offset: 0x0012FA8D
		public bool IsOpen { get; private set; }

		// Token: 0x060048DF RID: 18655 RVA: 0x00131898 File Offset: 0x0012FA98
		private void Start()
		{
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 4);
			this.ConfirmButton.onClick.AddListener(new UnityAction(this.ConfirmOrderPressed));
			this.ItemLimitContainer.gameObject.SetActive(true);
			this.Close();
		}

		// Token: 0x060048E0 RID: 18656 RVA: 0x001318EC File Offset: 0x0012FAEC
		public void Open(string title, string subtitle, MSGConversation _conversation, List<PhoneShopInterface.Listing> listings, float _orderLimit, float debt, Action<List<PhoneShopInterface.CartEntry>, float> _orderConfirmedCallback)
		{
			this.IsOpen = true;
			this.TitleLabel.text = title;
			this.SubtitleLabel.text = subtitle;
			this.OrderLimitLabel.text = MoneyManager.FormatAmount(_orderLimit, false, false);
			this.DebtLabel.text = MoneyManager.FormatAmount(debt, false, false);
			this.orderLimit = _orderLimit;
			this.conversation = _conversation;
			MSGConversation msgconversation = this.conversation;
			msgconversation.onMessageRendered = (Action)Delegate.Combine(msgconversation.onMessageRendered, new Action(this.Close));
			this.orderConfirmedCallback = _orderConfirmedCallback;
			this._items.Clear();
			this._items.AddRange(listings);
			using (List<PhoneShopInterface.Listing>.Enumerator enumerator = listings.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					PhoneShopInterface.Listing entry = enumerator.Current;
					RectTransform rectTransform = Object.Instantiate<RectTransform>(this.EntryPrefab, this.EntryContainer);
					rectTransform.Find("Icon").GetComponent<Image>().sprite = entry.Item.Icon;
					rectTransform.Find("Name").GetComponent<Text>().text = entry.Item.Name;
					rectTransform.Find("Price").GetComponent<Text>().text = MoneyManager.FormatAmount(entry.Price, false, false);
					rectTransform.Find("Quantity").GetComponent<Text>().text = "0";
					StorableItemDefinition storableItemDefinition = entry.Item as StorableItemDefinition;
					if (!storableItemDefinition.RequiresLevelToPurchase || NetworkSingleton<LevelManager>.Instance.GetFullRank() >= storableItemDefinition.RequiredRank)
					{
						rectTransform.Find("Quantity/Remove").GetComponent<Button>().onClick.AddListener(new UnityAction(delegate()
						{
							this.ChangeListingQuantity(entry, -1);
						}));
						rectTransform.Find("Quantity/Add").GetComponent<Button>().onClick.AddListener(new UnityAction(delegate()
						{
							this.ChangeListingQuantity(entry, 1);
						}));
						rectTransform.Find("Locked").gameObject.SetActive(false);
					}
					else
					{
						rectTransform.Find("Locked/Title").GetComponent<Text>().text = "Unlocks at " + storableItemDefinition.RequiredRank.ToString();
						rectTransform.Find("Locked").gameObject.SetActive(true);
					}
					this._entries.Add(rectTransform);
				}
			}
			this.CartChanged();
			this.Container.gameObject.SetActive(true);
		}

		// Token: 0x060048E1 RID: 18657 RVA: 0x00131B90 File Offset: 0x0012FD90
		public void Close()
		{
			this.IsOpen = false;
			this._items.Clear();
			this._cart.Clear();
			if (this.conversation != null)
			{
				MSGConversation msgconversation = this.conversation;
				msgconversation.onMessageRendered = (Action)Delegate.Remove(msgconversation.onMessageRendered, new Action(this.Close));
			}
			foreach (RectTransform rectTransform in this._entries)
			{
				Object.Destroy(rectTransform.gameObject);
			}
			this._entries.Clear();
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x060048E2 RID: 18658 RVA: 0x00131C50 File Offset: 0x0012FE50
		public void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!this.IsOpen)
			{
				return;
			}
			action.used = true;
			this.Close();
		}

		// Token: 0x060048E3 RID: 18659 RVA: 0x00131C74 File Offset: 0x0012FE74
		private void ChangeListingQuantity(PhoneShopInterface.Listing listing, int change)
		{
			PhoneShopInterface.CartEntry cartEntry = this._cart.Find((PhoneShopInterface.CartEntry e) => e.Listing.Item.ID == listing.Item.ID);
			if (cartEntry == null)
			{
				cartEntry = new PhoneShopInterface.CartEntry(listing, 0);
				this._cart.Add(cartEntry);
			}
			cartEntry.Quantity = Mathf.Clamp(cartEntry.Quantity + change, 0, 99);
			this._entries[this._items.IndexOf(listing)].Find("Quantity").GetComponent<Text>().text = cartEntry.Quantity.ToString();
			this.CartChanged();
		}

		// Token: 0x060048E4 RID: 18660 RVA: 0x00131D19 File Offset: 0x0012FF19
		private void CartChanged()
		{
			this.UpdateOrderTotal();
			this.ConfirmButton.interactable = this.CanConfirmOrder();
		}

		// Token: 0x060048E5 RID: 18661 RVA: 0x00131D34 File Offset: 0x0012FF34
		private void ConfirmOrderPressed()
		{
			int num;
			this.orderConfirmedCallback(this._cart, this.GetOrderTotal(out num));
			this.Close();
		}

		// Token: 0x060048E6 RID: 18662 RVA: 0x00131D60 File Offset: 0x0012FF60
		private bool CanConfirmOrder()
		{
			int num;
			float orderTotal = this.GetOrderTotal(out num);
			return orderTotal > 0f && orderTotal <= this.orderLimit && num <= 10;
		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x00131D94 File Offset: 0x0012FF94
		private void UpdateOrderTotal()
		{
			int num;
			float orderTotal = this.GetOrderTotal(out num);
			this.OrderTotalLabel.text = MoneyManager.FormatAmount(orderTotal, false, false);
			this.OrderTotalLabel.color = ((orderTotal <= this.orderLimit) ? this.ValidAmountColor : this.InvalidAmountColor);
			this.ItemLimitLabel.text = num.ToString() + "/" + 10.ToString();
			this.ItemLimitLabel.color = ((num <= 10) ? Color.black : this.InvalidAmountColor);
		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x00131E24 File Offset: 0x00130024
		private float GetOrderTotal(out int itemCount)
		{
			float num = 0f;
			itemCount = 0;
			foreach (PhoneShopInterface.CartEntry cartEntry in this._cart)
			{
				num += cartEntry.Listing.Price * (float)cartEntry.Quantity;
				itemCount += cartEntry.Quantity;
			}
			return num;
		}

		// Token: 0x040035F4 RID: 13812
		public RectTransform EntryPrefab;

		// Token: 0x040035F5 RID: 13813
		public Color ValidAmountColor;

		// Token: 0x040035F6 RID: 13814
		public Color InvalidAmountColor;

		// Token: 0x040035F7 RID: 13815
		[Header("References")]
		public GameObject Container;

		// Token: 0x040035F8 RID: 13816
		public Text TitleLabel;

		// Token: 0x040035F9 RID: 13817
		public Text SubtitleLabel;

		// Token: 0x040035FA RID: 13818
		public RectTransform EntryContainer;

		// Token: 0x040035FB RID: 13819
		public Text OrderTotalLabel;

		// Token: 0x040035FC RID: 13820
		public Text OrderLimitLabel;

		// Token: 0x040035FD RID: 13821
		public Text DebtLabel;

		// Token: 0x040035FE RID: 13822
		public Button ConfirmButton;

		// Token: 0x040035FF RID: 13823
		public GameObject ItemLimitContainer;

		// Token: 0x04003600 RID: 13824
		public Text ItemLimitLabel;

		// Token: 0x04003601 RID: 13825
		private List<RectTransform> _entries = new List<RectTransform>();

		// Token: 0x04003602 RID: 13826
		private List<PhoneShopInterface.Listing> _items = new List<PhoneShopInterface.Listing>();

		// Token: 0x04003603 RID: 13827
		private List<PhoneShopInterface.CartEntry> _cart = new List<PhoneShopInterface.CartEntry>();

		// Token: 0x04003604 RID: 13828
		private float orderLimit;

		// Token: 0x04003605 RID: 13829
		private Action<List<PhoneShopInterface.CartEntry>, float> orderConfirmedCallback;

		// Token: 0x04003606 RID: 13830
		private MSGConversation conversation;

		// Token: 0x02000A94 RID: 2708
		[Serializable]
		public class Listing
		{
			// Token: 0x060048EA RID: 18666 RVA: 0x00131EC5 File Offset: 0x001300C5
			public Listing(ItemDefinition item, float price)
			{
				this.Item = item;
				this.Price = price;
			}

			// Token: 0x04003607 RID: 13831
			public ItemDefinition Item;

			// Token: 0x04003608 RID: 13832
			public float Price;
		}

		// Token: 0x02000A95 RID: 2709
		[Serializable]
		public class CartEntry
		{
			// Token: 0x060048EB RID: 18667 RVA: 0x00131EDB File Offset: 0x001300DB
			public CartEntry(PhoneShopInterface.Listing listing, int quantity)
			{
				this.Listing = listing;
				this.Quantity = quantity;
			}

			// Token: 0x04003609 RID: 13833
			public PhoneShopInterface.Listing Listing;

			// Token: 0x0400360A RID: 13834
			public int Quantity;
		}
	}
}
