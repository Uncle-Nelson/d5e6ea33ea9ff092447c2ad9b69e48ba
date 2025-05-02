using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Levelling;
using ScheduleOne.Money;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCustomization
{
	// Token: 0x02000B3A RID: 2874
	public class CharacterCustomizationOption : MonoBehaviour
	{
		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06004C73 RID: 19571 RVA: 0x00142BF3 File Offset: 0x00140DF3
		// (set) Token: 0x06004C74 RID: 19572 RVA: 0x00142BFB File Offset: 0x00140DFB
		public bool purchased { get; private set; }

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06004C75 RID: 19573 RVA: 0x00142C04 File Offset: 0x00140E04
		private bool purchaseable
		{
			get
			{
				return !this.RequireLevel || this.RequiredLevel <= NetworkSingleton<LevelManager>.Instance.GetFullRank();
			}
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x00142C28 File Offset: 0x00140E28
		private void Awake()
		{
			this.NameLabel.text = this.Name;
			if (this.Price > 0f)
			{
				this.PriceLabel.text = MoneyManager.FormatAmount(this.Price, false, false);
			}
			else
			{
				this.PriceLabel.text = "Free";
			}
			this.UpdatePriceColor();
			this.LevelLabel.text = this.RequiredLevel.ToString();
			this.MainButton.onClick.AddListener(new UnityAction(this.Selected));
			this.BuyButton.onClick.AddListener(new UnityAction(this.Purchased));
		}

		// Token: 0x06004C77 RID: 19575 RVA: 0x00142CD7 File Offset: 0x00140ED7
		private void OnValidate()
		{
			base.gameObject.name = this.Name;
		}

		// Token: 0x06004C78 RID: 19576 RVA: 0x00142CEA File Offset: 0x00140EEA
		private void FixedUpdate()
		{
			this.BuyButton.interactable = (NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance >= this.Price);
		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x00142D0C File Offset: 0x00140F0C
		private void Start()
		{
			this.UpdateUI();
		}

		// Token: 0x06004C7A RID: 19578 RVA: 0x00142D14 File Offset: 0x00140F14
		private void Selected()
		{
			this.SetSelected(true);
		}

		// Token: 0x06004C7B RID: 19579 RVA: 0x00142D20 File Offset: 0x00140F20
		private void Purchased()
		{
			if (!this.purchaseable)
			{
				return;
			}
			if (this.onPurchase != null)
			{
				this.onPurchase.Invoke();
			}
			if (this.Price > 0f)
			{
				NetworkSingleton<MoneyManager>.Instance.CreateOnlineTransaction("Character customization", -this.Price, 1f, string.Empty);
			}
			this.SetPurchased(true);
		}

		// Token: 0x06004C7C RID: 19580 RVA: 0x00142D80 File Offset: 0x00140F80
		private void UpdatePriceColor()
		{
			if (this.Price <= 0f)
			{
				Color color;
				this.PriceLabel.color = (ColorUtility.TryParseHtmlString("#4CBFFF", out color) ? color : Color.white);
				return;
			}
			if (NetworkSingleton<MoneyManager>.Instance.cashBalance >= this.Price)
			{
				Color color2;
				this.PriceLabel.color = (ColorUtility.TryParseHtmlString("#4CBFFF", out color2) ? color2 : Color.white);
				return;
			}
			this.PriceLabel.color = new Color32(200, 75, 70, byte.MaxValue);
		}

		// Token: 0x06004C7D RID: 19581 RVA: 0x00142E14 File Offset: 0x00141014
		public void SetSelected(bool _selected)
		{
			this.selected = _selected;
			this.SelectionIndicator.gameObject.SetActive(this.selected);
			this.NameLabel.rectTransform.offsetMin = new Vector2(this.selected ? 30f : 10f, this.NameLabel.rectTransform.offsetMin.y);
			this.UpdateUI();
			if (this.selected)
			{
				if (this.onSelect != null)
				{
					this.onSelect.Invoke();
					return;
				}
			}
			else if (this.onDeselect != null)
			{
				this.onDeselect.Invoke();
			}
		}

		// Token: 0x06004C7E RID: 19582 RVA: 0x00142EB4 File Offset: 0x001410B4
		public void SetPurchased(bool _purchased)
		{
			this.purchased = _purchased;
			this.BuyButton.gameObject.SetActive(!this.purchased);
			this.PriceLabel.gameObject.SetActive(!this.purchased);
			if (_purchased)
			{
				this.SetSelected(true);
			}
			this.UpdateUI();
		}

		// Token: 0x06004C7F RID: 19583 RVA: 0x00142F0C File Offset: 0x0014110C
		private void UpdateUI()
		{
			this.LockDisplay.gameObject.SetActive(!this.purchaseable);
			this.PriceLabel.gameObject.SetActive(this.purchaseable && !this.purchased);
			this.BuyButton.gameObject.SetActive(this.purchaseable && !this.purchased);
			this.UpdatePriceColor();
		}

		// Token: 0x06004C80 RID: 19584 RVA: 0x00142F80 File Offset: 0x00141180
		public void ParentCategoryClosed()
		{
			if (this.selected && !this.purchased)
			{
				this.SetSelected(false);
				return;
			}
			if (this.purchased && !this.selected)
			{
				this.SetSelected(true);
			}
		}

		// Token: 0x06004C81 RID: 19585 RVA: 0x00142FB1 File Offset: 0x001411B1
		public void SiblingOptionSelected(CharacterCustomizationOption option)
		{
			if (option != this && this.selected)
			{
				this.SetSelected(false);
			}
		}

		// Token: 0x06004C82 RID: 19586 RVA: 0x00142FCB File Offset: 0x001411CB
		public void SiblingOptionPurchased(CharacterCustomizationOption option)
		{
			if (option != this && this.purchased)
			{
				this.SetPurchased(false);
			}
		}

		// Token: 0x04003991 RID: 14737
		public string Name = "Option";

		// Token: 0x04003992 RID: 14738
		public string Label = "AssetPath or Label";

		// Token: 0x04003993 RID: 14739
		public float Price;

		// Token: 0x04003994 RID: 14740
		public bool RequireLevel;

		// Token: 0x04003995 RID: 14741
		public FullRank RequiredLevel = new FullRank(ERank.Street_Rat, 1);

		// Token: 0x04003996 RID: 14742
		[Header("References")]
		public TextMeshProUGUI NameLabel;

		// Token: 0x04003997 RID: 14743
		public TextMeshProUGUI PriceLabel;

		// Token: 0x04003998 RID: 14744
		public TextMeshProUGUI LevelLabel;

		// Token: 0x04003999 RID: 14745
		public RectTransform LockDisplay;

		// Token: 0x0400399A RID: 14746
		public Button MainButton;

		// Token: 0x0400399B RID: 14747
		public Button BuyButton;

		// Token: 0x0400399C RID: 14748
		public RectTransform SelectionIndicator;

		// Token: 0x0400399D RID: 14749
		[Header("Events")]
		public UnityEvent onSelect;

		// Token: 0x0400399E RID: 14750
		public UnityEvent onDeselect;

		// Token: 0x0400399F RID: 14751
		public UnityEvent onPurchase;

		// Token: 0x040039A1 RID: 14753
		private bool selected;
	}
}
