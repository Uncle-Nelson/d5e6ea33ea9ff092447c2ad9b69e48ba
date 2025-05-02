using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.Economy;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using ScheduleOne.Product;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Messages
{
	// Token: 0x02000ABB RID: 2747
	public class DealerManagementApp : App<DealerManagementApp>
	{
		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x060049F1 RID: 18929 RVA: 0x00135D15 File Offset: 0x00133F15
		// (set) Token: 0x060049F2 RID: 18930 RVA: 0x00135D1D File Offset: 0x00133F1D
		public Dealer SelectedDealer { get; private set; }

		// Token: 0x060049F3 RID: 18931 RVA: 0x00135D28 File Offset: 0x00133F28
		protected override void Awake()
		{
			base.Awake();
			foreach (Dealer dealer in Dealer.AllDealers)
			{
				if (dealer.IsRecruited)
				{
					this.AddDealer(dealer);
				}
			}
			Dealer.onDealerRecruited = (Action<Dealer>)Delegate.Combine(Dealer.onDealerRecruited, new Action<Dealer>(this.AddDealer));
			this.BackButton.onClick.AddListener(new UnityAction(this.BackPressed));
			this.NextButton.onClick.AddListener(new UnityAction(this.NextPressed));
			this.AssignCustomerButton.onClick.AddListener(new UnityAction(this.AssignCustomer));
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x00135DFC File Offset: 0x00133FFC
		protected override void Start()
		{
			base.Start();
			this.CustomerSelector.onCustomerSelected.AddListener(new UnityAction<Customer>(this.AddCustomer));
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x00135E20 File Offset: 0x00134020
		protected override void OnDestroy()
		{
			Dealer.onDealerRecruited = (Action<Dealer>)Delegate.Remove(Dealer.onDealerRecruited, new Action<Dealer>(this.AddDealer));
			base.OnDestroy();
		}

		// Token: 0x060049F6 RID: 18934 RVA: 0x00135E48 File Offset: 0x00134048
		public override void SetOpen(bool open)
		{
			if (this.SelectedDealer != null)
			{
				this.SetDisplayedDealer(this.SelectedDealer);
			}
			else if (this.dealers.Count > 0)
			{
				this.SetDisplayedDealer(this.dealers[0]);
			}
			else
			{
				this.NoDealersLabel.gameObject.SetActive(true);
				this.Content.gameObject.SetActive(false);
			}
			base.SetOpen(open);
		}

		// Token: 0x060049F7 RID: 18935 RVA: 0x00135EBC File Offset: 0x001340BC
		public void SetDisplayedDealer(Dealer dealer)
		{
			this.SelectedDealer = dealer;
			this.SelectorImage.sprite = dealer.MugshotSprite;
			this.SelectorTitle.text = dealer.fullName;
			this.CashLabel.text = MoneyManager.FormatAmount(dealer.Cash, false, false);
			this.CutLabel.text = Mathf.RoundToInt(dealer.Cut * 100f).ToString() + "%";
			this.HomeLabel.text = dealer.HomeName;
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			List<string> list = new List<string>();
			foreach (ItemSlot itemSlot in dealer.GetAllSlots())
			{
				if (itemSlot.Quantity != 0)
				{
					int num = itemSlot.Quantity;
					if (itemSlot.ItemInstance is ProductItemInstance)
					{
						num *= ((ProductItemInstance)itemSlot.ItemInstance).Amount;
					}
					if (list.Contains(itemSlot.ItemInstance.ID))
					{
						Dictionary<string, int> dictionary2 = dictionary;
						string id = itemSlot.ItemInstance.ID;
						dictionary2[id] += num;
					}
					else
					{
						list.Add(itemSlot.ItemInstance.ID);
						dictionary.Add(itemSlot.ItemInstance.ID, num);
					}
				}
			}
			for (int i = 0; i < this.InventoryEntries.Length; i++)
			{
				if (list.Count > i)
				{
					ItemDefinition item = Registry.GetItem(list[i]);
					this.InventoryEntries[i].Find("Image").GetComponent<Image>().sprite = item.Icon;
					this.InventoryEntries[i].Find("Title").GetComponent<Text>().text = dictionary[list[i]].ToString() + "x " + item.Name;
					this.InventoryEntries[i].gameObject.SetActive(true);
				}
				else
				{
					this.InventoryEntries[i].gameObject.SetActive(false);
				}
			}
			this.CustomerTitleLabel.text = string.Concat(new string[]
			{
				"Assigned Customers (",
				dealer.AssignedCustomers.Count.ToString(),
				"/",
				8.ToString(),
				")"
			});
			for (int j = 0; j < this.CustomerEntries.Length; j++)
			{
				if (dealer.AssignedCustomers.Count > j)
				{
					Customer customer = dealer.AssignedCustomers[j];
					this.CustomerEntries[j].Find("Mugshot").GetComponent<Image>().sprite = customer.NPC.MugshotSprite;
					this.CustomerEntries[j].Find("Name").GetComponent<Text>().text = customer.NPC.fullName;
					Button component = this.CustomerEntries[j].Find("Remove").GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					component.onClick.AddListener(new UnityAction(delegate()
					{
						this.RemoveCustomer(customer);
					}));
					this.CustomerEntries[j].gameObject.SetActive(true);
				}
				else
				{
					this.CustomerEntries[j].gameObject.SetActive(false);
				}
			}
			this.BackButton.interactable = (this.dealers.IndexOf(dealer) > 0);
			this.NextButton.interactable = (this.dealers.IndexOf(dealer) < this.dealers.Count - 1);
			this.AssignCustomerButton.gameObject.SetActive(dealer.AssignedCustomers.Count < 8);
			this.NoDealersLabel.gameObject.SetActive(false);
			this.Content.gameObject.SetActive(true);
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x001362E4 File Offset: 0x001344E4
		private void AddDealer(Dealer dealer)
		{
			if (this.dealers.Contains(dealer))
			{
				return;
			}
			this.dealers.Add(dealer);
			this.dealers = (from d in this.dealers
			orderby d.FirstName
			select d).ToList<Dealer>();
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x00136341 File Offset: 0x00134541
		private void AddCustomer(Customer customer)
		{
			this.SelectedDealer.SendAddCustomer(customer.NPC.ID);
			if (customer.OfferedContractInfo != null)
			{
				Console.Log("Expiring...", null);
				customer.ExpireOffer();
			}
			this.SetDisplayedDealer(this.SelectedDealer);
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x0013637E File Offset: 0x0013457E
		private void RemoveCustomer(Customer customer)
		{
			this.SelectedDealer.SendRemoveCustomer(customer.NPC.ID);
			this.SetDisplayedDealer(this.SelectedDealer);
		}

		// Token: 0x060049FB RID: 18939 RVA: 0x001363A4 File Offset: 0x001345A4
		private void BackPressed()
		{
			int num = this.dealers.IndexOf(this.SelectedDealer);
			if (num > 0)
			{
				this.SetDisplayedDealer(this.dealers[num - 1]);
			}
		}

		// Token: 0x060049FC RID: 18940 RVA: 0x001363DC File Offset: 0x001345DC
		private void NextPressed()
		{
			int num = this.dealers.IndexOf(this.SelectedDealer);
			if (num < this.dealers.Count - 1)
			{
				this.SetDisplayedDealer(this.dealers[num + 1]);
			}
		}

		// Token: 0x060049FD RID: 18941 RVA: 0x0013641F File Offset: 0x0013461F
		public void AssignCustomer()
		{
			this.CustomerSelector.Open();
		}

		// Token: 0x04003707 RID: 14087
		[Header("References")]
		public Text NoDealersLabel;

		// Token: 0x04003708 RID: 14088
		public RectTransform Content;

		// Token: 0x04003709 RID: 14089
		public CustomerSelector CustomerSelector;

		// Token: 0x0400370A RID: 14090
		[Header("Selector")]
		public Image SelectorImage;

		// Token: 0x0400370B RID: 14091
		public Text SelectorTitle;

		// Token: 0x0400370C RID: 14092
		public Button BackButton;

		// Token: 0x0400370D RID: 14093
		public Button NextButton;

		// Token: 0x0400370E RID: 14094
		[Header("Basic Info")]
		public Text CashLabel;

		// Token: 0x0400370F RID: 14095
		public Text CutLabel;

		// Token: 0x04003710 RID: 14096
		public Text HomeLabel;

		// Token: 0x04003711 RID: 14097
		[Header("Inventory")]
		public RectTransform[] InventoryEntries;

		// Token: 0x04003712 RID: 14098
		[Header("Customers")]
		public Text CustomerTitleLabel;

		// Token: 0x04003713 RID: 14099
		public RectTransform[] CustomerEntries;

		// Token: 0x04003714 RID: 14100
		public Button AssignCustomerButton;

		// Token: 0x04003715 RID: 14101
		private List<Dealer> dealers = new List<Dealer>();
	}
}
