using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000A8C RID: 2700
	public class CustomerSelector : MonoBehaviour
	{
		// Token: 0x060048A1 RID: 18593 RVA: 0x00130924 File Offset: 0x0012EB24
		public void Awake()
		{
			for (int i = 0; i < Customer.UnlockedCustomers.Count; i++)
			{
				this.CreateEntry(Customer.UnlockedCustomers[i]);
			}
			Customer.onCustomerUnlocked = (Action<Customer>)Delegate.Combine(Customer.onCustomerUnlocked, new Action<Customer>(this.CreateEntry));
			this.Close();
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x0013097D File Offset: 0x0012EB7D
		public void Start()
		{
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 7);
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x00130991 File Offset: 0x0012EB91
		private void OnDestroy()
		{
			Customer.onCustomerUnlocked = (Action<Customer>)Delegate.Remove(Customer.onCustomerUnlocked, new Action<Customer>(this.CreateEntry));
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x001309B3 File Offset: 0x0012EBB3
		private void Exit(ExitAction action)
		{
			if (action == null)
			{
				return;
			}
			if (action.used)
			{
				return;
			}
			if (this != null && base.gameObject != null && base.gameObject.activeInHierarchy)
			{
				action.used = true;
				this.Close();
			}
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x001309F4 File Offset: 0x0012EBF4
		public void Open()
		{
			for (int i = 0; i < this.customerEntries.Count; i++)
			{
				if (this.entryToCustomer[this.customerEntries[i]].AssignedDealer != null)
				{
					this.customerEntries[i].gameObject.SetActive(false);
				}
				else
				{
					this.customerEntries[i].gameObject.SetActive(true);
				}
			}
			base.gameObject.SetActive(true);
		}

		// Token: 0x060048A6 RID: 18598 RVA: 0x000C0CA9 File Offset: 0x000BEEA9
		public void Close()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x060048A7 RID: 18599 RVA: 0x00130A78 File Offset: 0x0012EC78
		private void CreateEntry(Customer customer)
		{
			RectTransform component = Object.Instantiate<GameObject>(this.ButtonPrefab, this.EntriesContainer).GetComponent<RectTransform>();
			component.Find("Mugshot").GetComponent<Image>().sprite = customer.NPC.MugshotSprite;
			component.Find("Name").GetComponent<Text>().text = customer.NPC.fullName;
			component.GetComponent<Button>().onClick.AddListener(new UnityAction(delegate()
			{
				this.CustomerSelected(customer);
			}));
			this.customerEntries.Add(component);
			this.entryToCustomer.Add(component, customer);
		}

		// Token: 0x060048A8 RID: 18600 RVA: 0x00130B34 File Offset: 0x0012ED34
		private void CustomerSelected(Customer customer)
		{
			if (customer.AssignedDealer == null && this.onCustomerSelected != null)
			{
				this.onCustomerSelected.Invoke(customer);
			}
			this.Close();
		}

		// Token: 0x040035B5 RID: 13749
		public GameObject ButtonPrefab;

		// Token: 0x040035B6 RID: 13750
		[Header("References")]
		public RectTransform EntriesContainer;

		// Token: 0x040035B7 RID: 13751
		public UnityEvent<Customer> onCustomerSelected;

		// Token: 0x040035B8 RID: 13752
		private List<RectTransform> customerEntries = new List<RectTransform>();

		// Token: 0x040035B9 RID: 13753
		private Dictionary<RectTransform, Customer> entryToCustomer = new Dictionary<RectTransform, Customer>();
	}
}
