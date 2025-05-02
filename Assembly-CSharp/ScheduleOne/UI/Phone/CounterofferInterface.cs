using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Messaging;
using ScheduleOne.Money;
using ScheduleOne.Product;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000A8F RID: 2703
	public class CounterofferInterface : MonoBehaviour
	{
		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x060048B4 RID: 18612 RVA: 0x00130D2F File Offset: 0x0012EF2F
		// (set) Token: 0x060048B5 RID: 18613 RVA: 0x00130D37 File Offset: 0x0012EF37
		public bool IsOpen { get; private set; }

		// Token: 0x060048B6 RID: 18614 RVA: 0x00130D40 File Offset: 0x0012EF40
		private void Awake()
		{
			CounterOfferProductSelector productSelector = this.ProductSelector;
			productSelector.onProductPreviewed = (Action<ProductDefinition>)Delegate.Combine(productSelector.onProductPreviewed, new Action<ProductDefinition>(this.DisplayProduct));
			CounterOfferProductSelector productSelector2 = this.ProductSelector;
			productSelector2.onProductSelected = (Action<ProductDefinition>)Delegate.Combine(productSelector2.onProductSelected, new Action<ProductDefinition>(this.SetProduct));
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x00130D9B File Offset: 0x0012EF9B
		private void Start()
		{
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 4);
			this.Close();
		}

		// Token: 0x060048B8 RID: 18616 RVA: 0x00130DB8 File Offset: 0x0012EFB8
		private void Update()
		{
			if (this.ProductSelector.IsOpen && GameInput.GetButtonUp(GameInput.ButtonCode.PrimaryClick) && this.mouseUp && !this.ProductSelector.IsMouseOverSelector())
			{
				this.ProductSelector.Close();
			}
			if (!GameInput.GetButton(GameInput.ButtonCode.PrimaryClick))
			{
				this.mouseUp = true;
			}
		}

		// Token: 0x060048B9 RID: 18617 RVA: 0x00130E0C File Offset: 0x0012F00C
		public void Open(ProductDefinition product, int quantity, float price, MSGConversation _conversation, Action<ProductDefinition, int, float> _orderConfirmedCallback)
		{
			this.IsOpen = true;
			this.selectedProduct = product;
			this.quantity = Mathf.Clamp(quantity, 1, this.MaxQuantity);
			this.price = price;
			this.conversation = _conversation;
			MSGConversation msgconversation = this.conversation;
			msgconversation.onMessageRendered = (Action)Delegate.Combine(msgconversation.onMessageRendered, new Action(this.Close));
			this.orderConfirmedCallback = _orderConfirmedCallback;
			this.Container.gameObject.SetActive(true);
			this.SetProduct(product);
			this.PriceInput.text = price.ToString();
		}

		// Token: 0x060048BA RID: 18618 RVA: 0x00130EA4 File Offset: 0x0012F0A4
		public void Close()
		{
			this.IsOpen = false;
			if (this.conversation != null)
			{
				MSGConversation msgconversation = this.conversation;
				msgconversation.onMessageRendered = (Action)Delegate.Remove(msgconversation.onMessageRendered, new Action(this.Close));
			}
			if (this.ProductSelector.IsOpen)
			{
				this.ProductSelector.Close();
			}
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x00130F10 File Offset: 0x0012F110
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

		// Token: 0x060048BC RID: 18620 RVA: 0x00130F34 File Offset: 0x0012F134
		public void Send()
		{
			float num;
			if (float.TryParse(this.PriceInput.text, out num))
			{
				this.price = num;
			}
			this.price = Mathf.Clamp(this.price, 1f, 9999f);
			this.PriceInput.SetTextWithoutNotify(this.price.ToString());
			if (this.orderConfirmedCallback != null)
			{
				this.orderConfirmedCallback(this.selectedProduct, this.quantity, this.price);
			}
			this.Close();
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x00130FB8 File Offset: 0x0012F1B8
		private void UpdateFairPrice()
		{
			float amount = this.selectedProduct.MarketValue * (float)this.quantity;
			this.FairPriceLabel.text = "Fair price: " + MoneyManager.FormatAmount(amount, false, false);
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x00130FF6 File Offset: 0x0012F1F6
		private void SetProduct(ProductDefinition newProduct)
		{
			this.selectedProduct = newProduct;
			this.DisplayProduct(newProduct);
			this.UpdateFairPrice();
			this.ProductSelector.Close();
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x00131017 File Offset: 0x0012F217
		private void DisplayProduct(ProductDefinition tempProduct)
		{
			this.ProductIcon.sprite = tempProduct.Icon;
			this.UpdatePriceQuantityLabel(tempProduct.Name);
		}

		// Token: 0x060048C0 RID: 18624 RVA: 0x00131036 File Offset: 0x0012F236
		public void ChangeQuantity(int change)
		{
			this.quantity = Mathf.Clamp(this.quantity + change, 1, this.MaxQuantity);
			this.UpdatePriceQuantityLabel(this.selectedProduct.Name);
			this.UpdateFairPrice();
		}

		// Token: 0x060048C1 RID: 18625 RVA: 0x0013106C File Offset: 0x0012F26C
		private void UpdatePriceQuantityLabel(string productName)
		{
			this.ProductLabel.text = this.quantity.ToString() + "x " + productName;
			float value = -(this.ProductLabel.preferredWidth / 2f) + 20f;
			this.ProductLabelRect.anchoredPosition = new Vector2(Mathf.Clamp(value, -120f, float.MaxValue), this.ProductLabelRect.anchoredPosition.y);
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x001310E3 File Offset: 0x0012F2E3
		public void ChangePrice(float change)
		{
			this.price = Mathf.Clamp(this.price + change, 1f, 9999f);
			this.PriceInput.SetTextWithoutNotify(this.price.ToString());
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x00131118 File Offset: 0x0012F318
		public void PriceSubmitted(string value)
		{
			float num;
			if (float.TryParse(value, out num))
			{
				this.price = num;
			}
			else
			{
				this.price = 0f;
			}
			this.price = Mathf.Clamp(this.price, 1f, 9999f);
			this.PriceInput.SetTextWithoutNotify(this.price.ToString());
		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x00131174 File Offset: 0x0012F374
		public void OpenProductSelector()
		{
			if (!this.mouseUp)
			{
				return;
			}
			this.mouseUp = false;
			this.ProductSelector.Open();
		}

		// Token: 0x040035C7 RID: 13767
		public const int COUNTEROFFER_SUCCESS_XP = 5;

		// Token: 0x040035C9 RID: 13769
		public const int MinQuantity = 1;

		// Token: 0x040035CA RID: 13770
		public int MaxQuantity = 50;

		// Token: 0x040035CB RID: 13771
		public const float MinPrice = 1f;

		// Token: 0x040035CC RID: 13772
		public const float MaxPrice = 9999f;

		// Token: 0x040035CD RID: 13773
		public float IconAlignment = 0.2f;

		// Token: 0x040035CE RID: 13774
		public GameObject ProductEntryPrefab;

		// Token: 0x040035CF RID: 13775
		[Header("References")]
		public GameObject Container;

		// Token: 0x040035D0 RID: 13776
		public Text TitleLabel;

		// Token: 0x040035D1 RID: 13777
		public Button ConfirmButton;

		// Token: 0x040035D2 RID: 13778
		public Image ProductIcon;

		// Token: 0x040035D3 RID: 13779
		public Text ProductLabel;

		// Token: 0x040035D4 RID: 13780
		public RectTransform ProductLabelRect;

		// Token: 0x040035D5 RID: 13781
		public InputField PriceInput;

		// Token: 0x040035D6 RID: 13782
		public Text FairPriceLabel;

		// Token: 0x040035D7 RID: 13783
		public CounterOfferProductSelector ProductSelector;

		// Token: 0x040035D8 RID: 13784
		private Action<ProductDefinition, int, float> orderConfirmedCallback;

		// Token: 0x040035D9 RID: 13785
		private ProductDefinition selectedProduct;

		// Token: 0x040035DA RID: 13786
		private int quantity;

		// Token: 0x040035DB RID: 13787
		private float price;

		// Token: 0x040035DC RID: 13788
		private Dictionary<ProductDefinition, RectTransform> productEntries = new Dictionary<ProductDefinition, RectTransform>();

		// Token: 0x040035DD RID: 13789
		private bool mouseUp;

		// Token: 0x040035DE RID: 13790
		private MSGConversation conversation;
	}
}
