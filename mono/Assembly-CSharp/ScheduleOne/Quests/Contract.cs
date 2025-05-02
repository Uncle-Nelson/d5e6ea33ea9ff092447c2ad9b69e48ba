using System;
using System.Collections.Generic;
using System.Linq;
using FishNet;
using FishNet.Object;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Product;
using ScheduleOne.UI;
using ScheduleOne.UI.Handover;
using ScheduleOne.UI.Phone;
using ScheduleOne.Variables;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x020002D4 RID: 724
	public class Contract : Quest
	{
		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x00046092 File Offset: 0x00044292
		// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x0004609A File Offset: 0x0004429A
		public NetworkObject Customer { get; protected set; }

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x000460A3 File Offset: 0x000442A3
		// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x000460AB File Offset: 0x000442AB
		public Dealer Dealer { get; protected set; }

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x000460B4 File Offset: 0x000442B4
		// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x000460BC File Offset: 0x000442BC
		public float Payment { get; protected set; }

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x000460C5 File Offset: 0x000442C5
		// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x000460CD File Offset: 0x000442CD
		public int PickupScheduleIndex { get; protected set; }

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x000460D6 File Offset: 0x000442D6
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x000460DE File Offset: 0x000442DE
		public GameDateTime AcceptTime { get; protected set; }

		// Token: 0x06000FBA RID: 4026 RVA: 0x000460E7 File Offset: 0x000442E7
		protected override void Start()
		{
			this.autoInitialize = false;
			base.Start();
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x000460F8 File Offset: 0x000442F8
		public virtual void InitializeContract(string title, string description, QuestEntryData[] entries, string guid, NetworkObject customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTime acceptTime)
		{
			this.SilentlyInitializeContract(this.title, this.Description, entries, guid, customer, payment, products, deliveryLocationGUID, deliveryWindow, pickupScheduleIndex, acceptTime);
			Debug.Log("Contract initialized");
			Contract.Contracts.Add(this);
			base.InitializeQuest(title, description, entries, guid);
			this.Customer.GetComponent<Customer>().AssignContract(this);
			if (this.DeliveryLocation != null && !this.DeliveryLocation.ScheduledContracts.Contains(this))
			{
				this.DeliveryLocation.ScheduledContracts.Add(this);
			}
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x0004618C File Offset: 0x0004438C
		public virtual void SilentlyInitializeContract(string title, string description, QuestEntryData[] entries, string guid, NetworkObject customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTime acceptTime)
		{
			this.Customer = customer;
			this.Payment = Mathf.Clamp(payment, 0f, float.MaxValue);
			this.ProductList = products;
			if (GUIDManager.IsGUIDValid(deliveryLocationGUID))
			{
				this.DeliveryLocation = GUIDManager.GetObject<DeliveryLocation>(new Guid(deliveryLocationGUID));
			}
			this.DeliveryWindow = deliveryWindow;
			this.PickupScheduleIndex = pickupScheduleIndex;
			this.AcceptTime = acceptTime;
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x000461F3 File Offset: 0x000443F3
		protected override void MinPass()
		{
			base.MinPass();
			this.UpdateTiming();
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00046201 File Offset: 0x00044401
		private void OnDestroy()
		{
			Contract.Contracts.Remove(this);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00046210 File Offset: 0x00044410
		private void UpdateTiming()
		{
			if (base.Expires && this.ExpiryVisibility != EExpiryVisibility.Never)
			{
				int minsUntilExpiry = base.GetMinsUntilExpiry();
				int num = Mathf.FloorToInt((float)minsUntilExpiry / 60f);
				int num2 = minsUntilExpiry - 360;
				int num3 = Mathf.FloorToInt((float)num2 / 60f);
				if (num2 > 0)
				{
					if (num3 > 0)
					{
						base.SetSubtitle("<color=#c0c0c0ff> (Begins in " + num3.ToString() + " hrs)</color>");
						return;
					}
					base.SetSubtitle("<color=#c0c0c0ff> (Begins in " + num2.ToString() + " min)</color>");
					return;
				}
				else if (minsUntilExpiry < 120)
				{
					if (num > 0)
					{
						base.SetSubtitle(string.Concat(new string[]
						{
							"<color=#",
							ColorUtility.ToHtmlStringRGBA(this.criticalTimeBackground.color),
							"> (Expires in ",
							num.ToString(),
							" hrs)</color>"
						}));
						return;
					}
					base.SetSubtitle(string.Concat(new string[]
					{
						"<color=#",
						ColorUtility.ToHtmlStringRGBA(this.criticalTimeBackground.color),
						"> (Expires in ",
						minsUntilExpiry.ToString(),
						" min)</color>"
					}));
					return;
				}
				else
				{
					if (num > 0)
					{
						base.SetSubtitle("<color=green> (Expires in " + num.ToString() + " hrs)</color>");
						return;
					}
					base.SetSubtitle("<color=green> (Expires in " + num.ToString() + " min)</color>");
				}
			}
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00046378 File Offset: 0x00044578
		public override void End()
		{
			base.End();
			if (this.DeliveryLocation != null)
			{
				this.DeliveryLocation.ScheduledContracts.Remove(this);
			}
			Contract.Contracts.Remove(this);
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x000463AC File Offset: 0x000445AC
		public override void Complete(bool network = true)
		{
			if (InstanceFinder.IsServer && !this.completedContractsIncremented)
			{
				this.completedContractsIncremented = true;
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Completed_Contracts_Count", (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Completed_Contracts_Count") + 1f).ToString(), true);
			}
			float lawIntensityChange = (Registry.GetItem(this.ProductList.entries[0].ProductID) as ProductDefinition).LawIntensityChange;
			Mathf.Lerp(0.5f, 2f, (float)this.ProductList.entries[0].Quantity / 25f);
			base.Complete(network);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00046456 File Offset: 0x00044656
		public void SetDealer(Dealer dealer)
		{
			this.Dealer = dealer;
			if (this.journalEntry != null)
			{
				this.journalEntry.gameObject.SetActive(this.ShouldShowJournalEntry());
			}
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00046483 File Offset: 0x00044683
		public virtual void SubmitPayment(float bonusTotal)
		{
			NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(this.Payment + bonusTotal, true, false);
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00046499 File Offset: 0x00044699
		protected override void SendExpiryReminder()
		{
			Singleton<NotificationsManager>.Instance.SendNotification("<color=#FFB43C>Deal Expiring Soon</color>", this.title, PlayerSingleton<JournalApp>.Instance.AppIcon, 5f, true);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x000464C0 File Offset: 0x000446C0
		protected override void SendExpiredNotification()
		{
			Singleton<NotificationsManager>.Instance.SendNotification("<color=#FF6455>Deal Expired</color>", this.title, PlayerSingleton<JournalApp>.Instance.AppIcon, 5f, true);
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x000464E7 File Offset: 0x000446E7
		protected override bool ShouldShowJournalEntry()
		{
			return !(this.Dealer != null) && base.ShouldShowJournalEntry();
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x000464FF File Offset: 0x000446FF
		protected override bool CanExpire()
		{
			return !(Singleton<HandoverScreen>.Instance.CurrentContract == this) && !this.Customer.GetComponent<NPC>().dialogueHandler.IsPlaying && base.CanExpire();
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00046534 File Offset: 0x00044734
		public bool DoesProductListMatchSpecified(List<ItemInstance> items, bool enforceQuality)
		{
			using (List<ProductList.Entry>.Enumerator enumerator = this.ProductList.entries.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ProductList.Entry entry = enumerator.Current;
					List<ItemInstance> list = (from x in items
					where x.ID == entry.ProductID
					select x).ToList<ItemInstance>();
					List<ProductItemInstance> list2 = new List<ProductItemInstance>();
					for (int i = 0; i < list.Count; i++)
					{
						list2.Add(list[i] as ProductItemInstance);
					}
					List<ProductItemInstance> list3 = new List<ProductItemInstance>();
					for (int j = 0; j < items.Count; j++)
					{
						ProductItemInstance productItemInstance = items[j] as ProductItemInstance;
						if (productItemInstance.Quality >= entry.Quality)
						{
							list3.Add(productItemInstance);
						}
					}
					int num = 0;
					for (int k = 0; k < list2.Count; k++)
					{
						num += list2[k].Quantity * list2[k].Amount;
					}
					int num2 = 0;
					for (int l = 0; l < list3.Count; l++)
					{
						num2 += list3[l].Quantity * list2[l].Amount;
					}
					if (enforceQuality)
					{
						if (num2 < entry.Quantity)
						{
							return false;
						}
					}
					else if (num < entry.Quantity)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x000466D4 File Offset: 0x000448D4
		public float GetProductListMatch(List<ItemInstance> items, out int matchedProductCount)
		{
			float num = 0f;
			int totalQuantity = this.ProductList.GetTotalQuantity();
			matchedProductCount = 0;
			List<ItemInstance> list = new List<ItemInstance>();
			for (int i = 0; i < items.Count; i++)
			{
				list.Add(items[i].GetCopy(-1));
			}
			foreach (ProductList.Entry entry in this.ProductList.entries)
			{
				int num2 = entry.Quantity;
				ProductDefinition other = Registry.GetItem(entry.ProductID) as ProductDefinition;
				Dictionary<ProductItemInstance, float> matchRatings = new Dictionary<ProductItemInstance, float>();
				foreach (ItemInstance itemInstance in list)
				{
					if (itemInstance.Quantity != 0)
					{
						ProductItemInstance productItemInstance = itemInstance as ProductItemInstance;
						if (productItemInstance != null)
						{
							matchRatings.Add(productItemInstance, productItemInstance.GetSimilarity(other, entry.Quality));
						}
					}
				}
				List<ProductItemInstance> list2 = matchRatings.Keys.ToList<ProductItemInstance>();
				list2.Sort((ProductItemInstance x, ProductItemInstance y) => matchRatings[y].CompareTo(matchRatings[x]));
				for (int j = 0; j < list2.Count; j++)
				{
					int amount = list2[j].Amount;
					int quantity = list2[j].Quantity;
					int num3 = Mathf.Min(Mathf.CeilToInt((float)num2 / (float)amount), list2[j].Quantity);
					num2 -= num3 * amount;
					num += matchRatings[list2[j]] * (float)num3 * (float)amount;
					if (matchRatings[list2[j]] > 0f)
					{
						matchedProductCount += num3 * amount;
					}
					list2[j].ChangeQuantity(-num3);
				}
			}
			return num / (float)totalQuantity;
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00046908 File Offset: 0x00044B08
		public override string GetSaveString()
		{
			List<QuestEntryData> list = new List<QuestEntryData>();
			for (int i = 0; i < this.Entries.Count; i++)
			{
				list.Add(this.Entries[i].GetSaveData());
			}
			return new ContractData(base.GUID.ToString(), base.QuestState, base.IsTracked, this.title, this.Description, base.Expires, new GameDateTimeData(base.Expiry), list.ToArray(), this.Customer.GetComponent<NPC>().GUID.ToString(), this.Payment, this.ProductList, this.DeliveryLocation.GUID.ToString(), this.DeliveryWindow, this.PickupScheduleIndex, new GameDateTimeData(this.AcceptTime)).GetJson(true);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x000469F0 File Offset: 0x00044BF0
		public bool ShouldSave()
		{
			return !(base.gameObject == null) && base.QuestState == EQuestState.Active;
		}

		// Token: 0x04001060 RID: 4192
		public const int DefaultExpiryTime = 2880;

		// Token: 0x04001061 RID: 4193
		public static List<Contract> Contracts = new List<Contract>();

		// Token: 0x04001065 RID: 4197
		[Header("Contract Settings")]
		public ProductList ProductList;

		// Token: 0x04001066 RID: 4198
		public DeliveryLocation DeliveryLocation;

		// Token: 0x04001067 RID: 4199
		public QuestWindowConfig DeliveryWindow;

		// Token: 0x0400106A RID: 4202
		private bool completedContractsIncremented;

		// Token: 0x020002D5 RID: 725
		public class BonusPayment
		{
			// Token: 0x06000FCE RID: 4046 RVA: 0x00046A1F File Offset: 0x00044C1F
			public BonusPayment(string title, float amount)
			{
				this.Title = title;
				this.Amount = Mathf.Clamp(amount, 0f, float.MaxValue);
			}

			// Token: 0x0400106B RID: 4203
			public string Title;

			// Token: 0x0400106C RID: 4204
			public float Amount;
		}
	}
}
