using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000B51 RID: 2897
	public class Cart : MonoBehaviour
	{
		// Token: 0x06004D18 RID: 19736 RVA: 0x0014507D File Offset: 0x0014327D
		protected virtual void Start()
		{
			this.UpdateViewCartText();
			this.BuyButton.onClick.AddListener(new UnityAction(this.Buy));
		}

		// Token: 0x06004D19 RID: 19737 RVA: 0x001450A1 File Offset: 0x001432A1
		protected virtual void Update()
		{
			if (this.Shop.IsOpen)
			{
				this.UpdateEntries();
				this.UpdateLoadVehicleToggle();
				this.UpdateTotal();
				this.UpdateProblem();
			}
		}

		// Token: 0x06004D1A RID: 19738 RVA: 0x001450C8 File Offset: 0x001432C8
		public void AddItem(ShopListing listing, int quantity)
		{
			if (!this.cartDictionary.ContainsKey(listing))
			{
				this.cartDictionary.Add(listing, 0);
			}
			Console.Log(string.Concat(new string[]
			{
				"Adding ",
				quantity.ToString(),
				" ",
				listing.Item.Name,
				" to cart"
			}), null);
			Dictionary<ShopListing, int> dictionary = this.cartDictionary;
			dictionary[listing] += quantity;
			listing.SetQuantityInCart(this.cartDictionary[listing]);
			this.UpdateViewCartText();
			this.UpdateEntries();
		}

		// Token: 0x06004D1B RID: 19739 RVA: 0x00145168 File Offset: 0x00143368
		public void RemoveItem(ShopListing listing, int quantity)
		{
			Dictionary<ShopListing, int> dictionary = this.cartDictionary;
			dictionary[listing] -= quantity;
			if (this.cartDictionary[listing] <= 0)
			{
				this.cartDictionary.Remove(listing);
			}
			listing.SetQuantityInCart(this.cartDictionary.ContainsKey(listing) ? this.cartDictionary[listing] : 0);
			this.Shop.RemoveItemSound.Play();
			this.UpdateProblem();
			this.UpdateViewCartText();
			this.UpdateEntries();
			this.UpdateTotal();
		}

		// Token: 0x06004D1C RID: 19740 RVA: 0x001451F8 File Offset: 0x001433F8
		public void ClearCart()
		{
			this.cartDictionary.Clear();
			foreach (KeyValuePair<ShopListing, int> keyValuePair in this.cartDictionary)
			{
				keyValuePair.Key.SetQuantityInCart(0);
			}
			this.UpdateViewCartText();
			this.UpdateEntries();
			this.UpdateTotal();
		}

		// Token: 0x06004D1D RID: 19741 RVA: 0x00145270 File Offset: 0x00143470
		public int GetCartCount(ShopListing listing)
		{
			if (this.cartDictionary.ContainsKey(listing))
			{
				return this.cartDictionary[listing];
			}
			return 0;
		}

		// Token: 0x06004D1E RID: 19742 RVA: 0x0014528E File Offset: 0x0014348E
		public void BopCartIcon()
		{
			if (this.cartIconBop != null)
			{
				base.StopCoroutine(this.cartIconBop);
			}
			this.cartIconBop = base.StartCoroutine(this.<BopCartIcon>g__Routine|21_0());
		}

		// Token: 0x06004D1F RID: 19743 RVA: 0x001452B8 File Offset: 0x001434B8
		public bool CanPlayerAffordCart()
		{
			float priceSum = this.GetPriceSum();
			switch (this.Shop.PaymentType)
			{
			case ShopInterface.EPaymentType.Cash:
				return NetworkSingleton<MoneyManager>.Instance.cashBalance >= priceSum;
			case ShopInterface.EPaymentType.Online:
				return NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance >= priceSum;
			case ShopInterface.EPaymentType.PreferCash:
				return NetworkSingleton<MoneyManager>.Instance.cashBalance >= priceSum || NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance >= priceSum;
			case ShopInterface.EPaymentType.PreferOnline:
				return NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance >= priceSum || NetworkSingleton<MoneyManager>.Instance.cashBalance >= priceSum;
			default:
				return false;
			}
		}

		// Token: 0x06004D20 RID: 19744 RVA: 0x00145354 File Offset: 0x00143554
		public void Buy()
		{
			string text;
			if (!this.CanCheckout(out text))
			{
				return;
			}
			foreach (KeyValuePair<ShopListing, int> keyValuePair in this.cartDictionary)
			{
				ShopListing key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (!key.IsUnlimitedStock)
				{
					key.RemoveStock(value);
				}
			}
			this.Shop.HandoverItems();
			switch (this.Shop.PaymentType)
			{
			case ShopInterface.EPaymentType.Cash:
				NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(-this.GetPriceSum(), true, false);
				break;
			case ShopInterface.EPaymentType.Online:
				NetworkSingleton<MoneyManager>.Instance.CreateOnlineTransaction("Purchase from " + this.Shop.ShopName, -this.GetPriceSum(), 1f, string.Empty);
				break;
			case ShopInterface.EPaymentType.PreferCash:
				if (NetworkSingleton<MoneyManager>.Instance.cashBalance >= this.GetPriceSum())
				{
					NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(-this.GetPriceSum(), true, false);
				}
				else
				{
					NetworkSingleton<MoneyManager>.Instance.CreateOnlineTransaction("Purchase from " + this.Shop.ShopName, -this.GetPriceSum(), 1f, string.Empty);
				}
				break;
			case ShopInterface.EPaymentType.PreferOnline:
				if (NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance >= this.GetPriceSum())
				{
					NetworkSingleton<MoneyManager>.Instance.CreateOnlineTransaction("Purchase from " + this.Shop.ShopName, -this.GetPriceSum(), 1f, string.Empty);
				}
				else
				{
					NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(-this.GetPriceSum(), true, false);
				}
				break;
			}
			this.ClearCart();
			this.Shop.CheckoutSound.Play();
			this.Shop.SetIsOpen(false);
			if (this.Shop.onOrderCompleted != null)
			{
				this.Shop.onOrderCompleted.Invoke();
			}
		}

		// Token: 0x06004D21 RID: 19745 RVA: 0x00145540 File Offset: 0x00143740
		private void UpdateEntries()
		{
			List<ShopListing> list = this.cartDictionary.Keys.ToList<ShopListing>();
			for (int i = 0; i < list.Count; i++)
			{
				CartEntry cartEntry = this.GetEntry(list[i]);
				if (cartEntry == null)
				{
					cartEntry = Object.Instantiate<CartEntry>(this.EntryPrefab, this.CartEntryContainer);
					cartEntry.Initialize(this, list[i], this.cartDictionary[list[i]]);
					this.cartEntries.Add(cartEntry);
				}
				if (cartEntry.Quantity != this.cartDictionary[list[i]])
				{
					cartEntry.SetQuantity(this.cartDictionary[list[i]]);
				}
			}
			for (int j = 0; j < this.cartEntries.Count; j++)
			{
				if (!this.cartDictionary.ContainsKey(this.cartEntries[j].Listing))
				{
					Object.Destroy(this.cartEntries[j].gameObject);
					this.cartEntries.RemoveAt(j);
					j--;
				}
			}
		}

		// Token: 0x06004D22 RID: 19746 RVA: 0x00145658 File Offset: 0x00143858
		private void UpdateTotal()
		{
			this.TotalText.text = string.Concat(new string[]
			{
				"Total: <color=#",
				ColorUtility.ToHtmlStringRGBA(ListingUI.PriceLabelColor_Normal),
				">",
				MoneyManager.FormatAmount(this.GetPriceSum(), false, false),
				"</color>"
			});
		}

		// Token: 0x06004D23 RID: 19747 RVA: 0x001456B8 File Offset: 0x001438B8
		private void UpdateProblem()
		{
			string text;
			bool flag = this.CanCheckout(out text);
			this.BuyButton.interactable = (flag && this.cartDictionary.Count > 0);
			if (flag)
			{
				this.ProblemText.enabled = false;
			}
			else
			{
				this.ProblemText.text = text;
				this.ProblemText.enabled = true;
			}
			string text2;
			if (this.GetWarning(out text2) && !this.ProblemText.enabled)
			{
				this.WarningText.text = text2;
				this.WarningText.enabled = true;
				return;
			}
			this.WarningText.enabled = false;
		}

		// Token: 0x06004D24 RID: 19748 RVA: 0x00145754 File Offset: 0x00143954
		private bool CanCheckout(out string reason)
		{
			if (!this.Shop.WillCartFit())
			{
				if (this.Shop.DeliveryBays.Length != 0)
				{
					reason = "Order too large";
				}
				else
				{
					reason = "Order won't fit in inventory";
				}
				return false;
			}
			if (!this.CanPlayerAffordCart())
			{
				if (this.Shop.PaymentType == ShopInterface.EPaymentType.Cash)
				{
					reason = "Insufficient cash. Visit an ATM to withdraw cash.";
				}
				else if (this.Shop.PaymentType == ShopInterface.EPaymentType.Online)
				{
					reason = "Insufficient online balance. Visit an ATM to deposit cash.";
				}
				else
				{
					reason = "Insufficient funds";
				}
				return false;
			}
			reason = string.Empty;
			return true;
		}

		// Token: 0x06004D25 RID: 19749 RVA: 0x001457D4 File Offset: 0x001439D4
		private bool GetWarning(out string warning)
		{
			warning = string.Empty;
			if (this.Shop.GetLoadingBayVehicle() != null && this.LoadVehicleToggle.isOn)
			{
				List<ItemSlot> itemSlots = this.Shop.GetLoadingBayVehicle().Storage.ItemSlots;
				if (!this.Shop.WillCartFit(itemSlots))
				{
					warning = "Vehicle won't fit everything. Some items will be placed on the pallets.";
					return true;
				}
			}
			else
			{
				List<ItemSlot> availableSlots = PlayerSingleton<PlayerInventory>.Instance.hotbarSlots.Cast<ItemSlot>().ToList<ItemSlot>();
				if (!this.Shop.WillCartFit(availableSlots))
				{
					warning = "Inventory won't fit everything. Some items will be placed on the pallets.";
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x00145864 File Offset: 0x00143A64
		private void UpdateViewCartText()
		{
			int itemSum = this.GetItemSum();
			if (itemSum > 0)
			{
				this.ViewCartText.text = string.Concat(new string[]
				{
					"View Cart (",
					itemSum.ToString(),
					" item",
					(itemSum > 1) ? "s" : "",
					")"
				});
				return;
			}
			this.ViewCartText.text = "View Cart";
		}

		// Token: 0x06004D27 RID: 19751 RVA: 0x001458D8 File Offset: 0x00143AD8
		private void UpdateLoadVehicleToggle()
		{
			this.LoadVehicleToggle.gameObject.SetActive(this.Shop.GetLoadingBayVehicle() != null);
		}

		// Token: 0x06004D28 RID: 19752 RVA: 0x001458FC File Offset: 0x00143AFC
		private int GetItemSum()
		{
			int num = 0;
			List<ShopListing> list = this.cartDictionary.Keys.ToList<ShopListing>();
			for (int i = 0; i < list.Count; i++)
			{
				num += this.cartDictionary[list[i]];
			}
			return num;
		}

		// Token: 0x06004D29 RID: 19753 RVA: 0x00145944 File Offset: 0x00143B44
		private float GetPriceSum()
		{
			float num = 0f;
			List<ShopListing> list = this.cartDictionary.Keys.ToList<ShopListing>();
			for (int i = 0; i < list.Count; i++)
			{
				num += (float)this.cartDictionary[list[i]] * list[i].Price;
			}
			return num;
		}

		// Token: 0x06004D2A RID: 19754 RVA: 0x001459A0 File Offset: 0x00143BA0
		private CartEntry GetEntry(ShopListing listing)
		{
			return this.cartEntries.Find((CartEntry x) => x.Listing == listing);
		}

		// Token: 0x06004D2B RID: 19755 RVA: 0x001459D1 File Offset: 0x00143BD1
		private bool IsMouseOverMenuArea()
		{
			return RectTransformUtility.RectangleContainsScreenPoint(this.CartArea.rectTransform, Input.mousePosition);
		}

		// Token: 0x06004D2C RID: 19756 RVA: 0x001459F0 File Offset: 0x00143BF0
		public int GetTotalSlotRequirement()
		{
			ShopListing[] array = this.cartDictionary.Keys.ToArray<ShopListing>();
			int num = 0;
			for (int i = 0; i < array.Length; i++)
			{
				int num2 = this.cartDictionary[array[i]];
				num += Mathf.CeilToInt((float)num2 / (float)array[i].Item.StackLimit);
			}
			return num;
		}

		// Token: 0x06004D2E RID: 19758 RVA: 0x00145A65 File Offset: 0x00143C65
		[CompilerGenerated]
		private IEnumerator <BopCartIcon>g__Routine|21_0()
		{
			Vector3 startScale = Vector3.one;
			Vector3 endScale = Vector3.one * 1.25f;
			float lerpTime = 0.09f;
			for (float i = 0f; i < lerpTime; i += Time.deltaTime)
			{
				this.CartIcon.transform.localScale = Vector3.Lerp(startScale, endScale, i / lerpTime);
				yield return new WaitForEndOfFrame();
			}
			for (float i = 0f; i < lerpTime; i += Time.deltaTime)
			{
				this.CartIcon.transform.localScale = Vector3.Lerp(endScale, startScale, i / lerpTime);
				yield return new WaitForEndOfFrame();
			}
			this.CartIcon.transform.localScale = startScale;
			this.cartIconBop = null;
			yield break;
		}

		// Token: 0x04003A0F RID: 14863
		[Header("References")]
		public ShopInterface Shop;

		// Token: 0x04003A10 RID: 14864
		public Image CartIcon;

		// Token: 0x04003A11 RID: 14865
		public TextMeshProUGUI ViewCartText;

		// Token: 0x04003A12 RID: 14866
		public RectTransform CartEntryContainer;

		// Token: 0x04003A13 RID: 14867
		public TextMeshProUGUI ProblemText;

		// Token: 0x04003A14 RID: 14868
		public TextMeshProUGUI WarningText;

		// Token: 0x04003A15 RID: 14869
		public Button BuyButton;

		// Token: 0x04003A16 RID: 14870
		public RectTransform CartContainer;

		// Token: 0x04003A17 RID: 14871
		public Image CartArea;

		// Token: 0x04003A18 RID: 14872
		public TextMeshProUGUI TotalText;

		// Token: 0x04003A19 RID: 14873
		public Toggle LoadVehicleToggle;

		// Token: 0x04003A1A RID: 14874
		[Header("Prefabs")]
		public CartEntry EntryPrefab;

		// Token: 0x04003A1B RID: 14875
		public Dictionary<ShopListing, int> cartDictionary = new Dictionary<ShopListing, int>();

		// Token: 0x04003A1C RID: 14876
		private Coroutine cartIconBop;

		// Token: 0x04003A1D RID: 14877
		private List<CartEntry> cartEntries = new List<CartEntry>();
	}
}
