using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.Messaging;
using ScheduleOne.Money;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.NPCs.Schedules;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Product;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Quests;
using ScheduleOne.UI;
using ScheduleOne.Variables;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Economy
{
	// Token: 0x0200066D RID: 1645
	public class Dealer : NPC, IItemSlotOwner
	{
		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06002CF7 RID: 11511 RVA: 0x000BAEEA File Offset: 0x000B90EA
		// (set) Token: 0x06002CF8 RID: 11512 RVA: 0x000BAEF2 File Offset: 0x000B90F2
		public bool IsRecruited { get; private set; }

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06002CF9 RID: 11513 RVA: 0x000BAEFB File Offset: 0x000B90FB
		// (set) Token: 0x06002CFA RID: 11514 RVA: 0x000BAF03 File Offset: 0x000B9103
		public List<ItemSlot> ItemSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06002CFB RID: 11515 RVA: 0x000BAF0C File Offset: 0x000B910C
		// (set) Token: 0x06002CFC RID: 11516 RVA: 0x000BAF14 File Offset: 0x000B9114
		public float Cash
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<Cash>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.sync___set_value_<Cash>k__BackingField(value, true);
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06002CFD RID: 11517 RVA: 0x000BAF1E File Offset: 0x000B911E
		// (set) Token: 0x06002CFE RID: 11518 RVA: 0x000BAF26 File Offset: 0x000B9126
		public bool HasBeenRecommended { get; private set; }

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06002CFF RID: 11519 RVA: 0x000BAF2F File Offset: 0x000B912F
		// (set) Token: 0x06002D00 RID: 11520 RVA: 0x000BAF37 File Offset: 0x000B9137
		public NPCPoI potentialDealerPoI { get; protected set; }

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06002D01 RID: 11521 RVA: 0x000BAF40 File Offset: 0x000B9140
		// (set) Token: 0x06002D02 RID: 11522 RVA: 0x000BAF48 File Offset: 0x000B9148
		public NPCPoI dealerPoI { get; protected set; }

		// Token: 0x06002D03 RID: 11523 RVA: 0x000BAF54 File Offset: 0x000B9154
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Economy.Dealer_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x000BAF73 File Offset: 0x000B9173
		protected override void OnValidate()
		{
			base.OnValidate();
			this.HomeEvent.Building = this.Home;
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x000BAF8C File Offset: 0x000B918C
		protected override void OnDestroy()
		{
			base.OnDestroy();
			Dealer.AllDealers.Remove(this);
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x000BAFA0 File Offset: 0x000B91A0
		protected override void Start()
		{
			base.Start();
			if (Application.isEditor)
			{
				foreach (Customer customer in this.InitialCustomers)
				{
					this.SendAddCustomer(customer.NPC.ID);
				}
				foreach (ProductDefinition productDefinition in this.InitialItems)
				{
					base.Inventory.InsertItem(productDefinition.GetDefaultInstance(10), true);
				}
			}
			for (int i = 0; i < base.Inventory.ItemSlots.Count; i++)
			{
				base.Inventory.ItemSlots[i].AddFilter(new ItemFilter_PackagedProduct());
			}
			this.SetUpDialogue();
			this.SetupPoI();
			NPCRelationData relationData = this.RelationData;
			relationData.onUnlocked = (Action<NPCRelationData.EUnlockType, bool>)Delegate.Combine(relationData.onUnlocked, new Action<NPCRelationData.EUnlockType, bool>(this.OnDealerUnlocked));
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x000BB0CC File Offset: 0x000B92CC
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (connection.IsLocalClient)
			{
				return;
			}
			if (this.IsRecruited)
			{
				this.SetIsRecruited(connection);
			}
			foreach (Customer customer in this.AssignedCustomers)
			{
				this.AddCustomer(connection, customer.NPC.ID);
			}
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x000BB14C File Offset: 0x000B934C
		private void SetupPoI()
		{
			if (this.dealerPoI == null)
			{
				this.dealerPoI = Object.Instantiate<NPCPoI>(NetworkSingleton<NPCManager>.Instance.NPCPoIPrefab, base.transform);
				this.dealerPoI.SetMainText(base.fullName + "\n(Dealer)");
				this.dealerPoI.SetNPC(this);
				this.dealerPoI.transform.localPosition = Vector3.zero;
				this.dealerPoI.enabled = this.IsRecruited;
			}
			if (this.potentialDealerPoI == null)
			{
				this.potentialDealerPoI = Object.Instantiate<NPCPoI>(NetworkSingleton<NPCManager>.Instance.PotentialDealerPoIPrefab, base.transform);
				this.potentialDealerPoI.SetMainText("Potential Dealer\n" + base.fullName);
				this.potentialDealerPoI.SetNPC(this);
				float y = (float)(this.FirstName[0] % '$') * 10f;
				float d = Mathf.Clamp((float)this.FirstName.Length * 1.5f, 1f, 10f);
				Vector3 vector = base.transform.forward;
				vector = Quaternion.Euler(0f, y, 0f) * vector;
				this.potentialDealerPoI.transform.localPosition = vector * d;
			}
			this.UpdatePotentialDealerPoI();
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x000BB29C File Offset: 0x000B949C
		private void SetUpDialogue()
		{
			this.recruitChoice = new DialogueController.DialogueChoice();
			this.recruitChoice.ChoiceText = "Do you want to work for me as a distributor?";
			this.recruitChoice.Enabled = !this.IsRecruited;
			this.recruitChoice.Conversation = this.RecruitDialogue;
			this.recruitChoice.onChoosen.AddListener(new UnityAction(this.RecruitmentRequested));
			this.recruitChoice.isValidCheck = new DialogueController.DialogueChoice.IsChoiceValid(this.CanOfferRecruitment);
			this.DialogueController.AddDialogueChoice(this.recruitChoice, 0);
			DialogueController.DialogueChoice dialogueChoice = new DialogueController.DialogueChoice();
			dialogueChoice.ChoiceText = "Nevermind";
			dialogueChoice.Enabled = true;
			this.DialogueController.AddDialogueChoice(dialogueChoice, 0);
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x000BB358 File Offset: 0x000B9558
		protected override void MinPass()
		{
			base.MinPass();
			this.UpdatePotentialDealerPoI();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (Singleton<LoadManager>.Instance.IsLoading)
			{
				return;
			}
			if (this.currentContract != null)
			{
				this.UpdateCurrentDeal();
			}
			else
			{
				this.CheckAttendStart();
			}
			this.HomeEvent.gameObject.SetActive(true);
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x000BB3B3 File Offset: 0x000B95B3
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void MarkAsRecommended()
		{
			this.RpcWriter___Server_MarkAsRecommended_2166136261();
			this.RpcLogic___MarkAsRecommended_2166136261();
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x000BB3C1 File Offset: 0x000B95C1
		[ObserversRpc(RunLocally = true)]
		private void SetRecommended()
		{
			this.RpcWriter___Observers_SetRecommended_2166136261();
			this.RpcLogic___SetRecommended_2166136261();
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x000BB3CF File Offset: 0x000B95CF
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void InitialRecruitment()
		{
			this.RpcWriter___Server_InitialRecruitment_2166136261();
			this.RpcLogic___InitialRecruitment_2166136261();
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x000BB3E0 File Offset: 0x000B95E0
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public virtual void SetIsRecruited(NetworkConnection conn)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetIsRecruited_328543758(conn);
				this.RpcLogic___SetIsRecruited_328543758(conn);
			}
			else
			{
				this.RpcWriter___Target_SetIsRecruited_328543758(conn);
			}
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x000BB415 File Offset: 0x000B9615
		protected virtual void OnDealerUnlocked(NPCRelationData.EUnlockType unlockType, bool b)
		{
			this.UpdatePotentialDealerPoI();
			NetworkSingleton<MoneyManager>.Instance.CashSound.Play();
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x000BB42C File Offset: 0x000B962C
		protected virtual void UpdatePotentialDealerPoI()
		{
			this.potentialDealerPoI.enabled = (this.RelationData.IsMutuallyKnown() && !this.RelationData.Unlocked);
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x000BB458 File Offset: 0x000B9658
		private void TradeItems()
		{
			this.dialogueHandler.SkipNextDialogueBehaviourEnd();
			this.itemCountOnTradeStart = base.Inventory.GetTotalItemCount();
			Singleton<StorageMenu>.Instance.Open(base.Inventory, base.fullName + "'s Inventory", "Place <color=#4CB0FF>packaged product</color> here and the dealer will sell it to assigned customers");
			Singleton<StorageMenu>.Instance.onClosed.AddListener(new UnityAction(this.TradeItemsDone));
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x000BB4C4 File Offset: 0x000B96C4
		private void TradeItemsDone()
		{
			Singleton<StorageMenu>.Instance.onClosed.RemoveListener(new UnityAction(this.TradeItemsDone));
			this.behaviour.GenericDialogueBehaviour.SendDisable();
			if (base.Inventory.GetTotalItemCount() > this.itemCountOnTradeStart)
			{
				this.dialogueHandler.WorldspaceRend.ShowText("Thanks boss", 2.5f);
				base.PlayVO(EVOLineType.Thanks);
			}
			this.TryMoveOverflowItems();
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x000BB536 File Offset: 0x000B9736
		private bool CanCollectCash(out string reason)
		{
			reason = string.Empty;
			return this.Cash > 0f;
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x000BB54F File Offset: 0x000B974F
		private void UpdateCollectCashChoice(float oldCash, float newCash, bool asServer)
		{
			if (this.collectCashChoice == null)
			{
				return;
			}
			this.collectCashChoice.ChoiceText = "I need to collect the earnings <color=#54E717>(" + MoneyManager.FormatAmount(this.Cash, false, false) + ")</color>";
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x000BB581 File Offset: 0x000B9781
		private void CollectCash()
		{
			NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(this.Cash, true, true);
			this.SetCash(0f);
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x000BB5A0 File Offset: 0x000B97A0
		private void UpdateCurrentDeal()
		{
			if (this.currentContract.QuestState != EQuestState.Active)
			{
				this.currentContract.SetDealer(null);
				this.currentContract = null;
				this.DealSignal.gameObject.SetActive(false);
				return;
			}
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x000BB5D8 File Offset: 0x000B97D8
		private bool CanOfferRecruitment(out string reason)
		{
			reason = string.Empty;
			if (this.IsRecruited)
			{
				return false;
			}
			if (!this.HasBeenRecommended)
			{
				reason = "Reach 'friendly' with one of " + this.FirstName + "'s connections";
				return false;
			}
			if (!this.RelationData.IsMutuallyKnown())
			{
				reason = "Unlock one of " + this.FirstName + "'s connections";
				return false;
			}
			return true;
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x000BB640 File Offset: 0x000B9840
		private void CheckAttendStart()
		{
			Contract contract = this.ActiveContracts.FirstOrDefault<Contract>();
			if (contract == null)
			{
				return;
			}
			int time = ScheduleOne.GameTime.TimeManager.AddMinutesTo24HourTime(contract.DeliveryWindow.WindowStartTime, 30);
			int num = Mathf.CeilToInt(Vector3.Distance(this.Avatar.CenterPoint, contract.DeliveryLocation.CustomerStandPoint.position) / base.Movement.WalkSpeed * 1.5f);
			num = Mathf.Clamp(num, 15, 360);
			int min = ScheduleOne.GameTime.TimeManager.AddMinutesTo24HourTime(time, -num);
			int minsUntilExpiry = contract.GetMinsUntilExpiry();
			if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.IsCurrentTimeWithinRange(min, contract.DeliveryWindow.WindowEndTime) || minsUntilExpiry <= 240)
			{
				Debug.Log("Dealer start attend deal: " + contract.Title);
				this.currentContract = contract;
				this.DealSignal.SetStartTime(NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.CurrentTime);
				this.DealSignal.AssignContract(contract);
				this.DealSignal.gameObject.SetActive(true);
			}
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x000BB738 File Offset: 0x000B9938
		public virtual bool ShouldAcceptContract(ContractInfo contractInfo, Customer customer)
		{
			foreach (ProductList.Entry entry in contractInfo.Products.entries)
			{
				string productID = entry.ProductID;
				EQuality minQuality = customer.CustomerData.Standards.GetCorrespondingQuality();
				EQuality maxQuality = customer.CustomerData.Standards.GetCorrespondingQuality();
				if (this.SellInsufficientQualityItems)
				{
					minQuality = EQuality.Trash;
				}
				if (this.SellExcessQualityItems)
				{
					maxQuality = EQuality.Heavenly;
				}
				int productCount = this.GetProductCount(productID, minQuality, maxQuality);
				if (entry.Quantity > productCount)
				{
					Console.Log(string.Concat(new string[]
					{
						"Dealer ",
						base.fullName,
						" does not have enough ",
						productID,
						" for ",
						customer.NPC.fullName
					}), null);
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x000BB82C File Offset: 0x000B9A2C
		public virtual void ContractedOffered(ContractInfo contractInfo, Customer customer)
		{
			if (!this.ShouldAcceptContract(contractInfo, customer))
			{
				Console.Log("Contract accepted by dealer " + base.fullName, null);
				return;
			}
			EDealWindow dealWindow = this.GetDealWindow();
			Console.Log("Contract accepted by dealer " + base.fullName + " in window " + dealWindow.ToString(), null);
			this.SyncAccessor_acceptedContractGUIDs.Add(customer.ContractAccepted(dealWindow, false));
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x000BB89C File Offset: 0x000B9A9C
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendAddCustomer(string npcID)
		{
			this.RpcWriter___Server_SendAddCustomer_3615296227(npcID);
			this.RpcLogic___SendAddCustomer_3615296227(npcID);
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x000BB8B4 File Offset: 0x000B9AB4
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void AddCustomer(NetworkConnection conn, string npcID)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_AddCustomer_2971853958(conn, npcID);
				this.RpcLogic___AddCustomer_2971853958(conn, npcID);
			}
			else
			{
				this.RpcWriter___Target_AddCustomer_2971853958(conn, npcID);
			}
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x000BB8F5 File Offset: 0x000B9AF5
		protected virtual void AddCustomer(Customer customer)
		{
			if (this.AssignedCustomers.Contains(customer))
			{
				return;
			}
			this.AssignedCustomers.Add(customer);
			customer.AssignDealer(this);
			customer.onContractAssigned.AddListener(new UnityAction<Contract>(this.CustomerContractStarted));
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x000BB930 File Offset: 0x000B9B30
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendRemoveCustomer(string npcID)
		{
			this.RpcWriter___Server_SendRemoveCustomer_3615296227(npcID);
			this.RpcLogic___SendRemoveCustomer_3615296227(npcID);
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x000BB948 File Offset: 0x000B9B48
		[ObserversRpc(RunLocally = true)]
		private void RemoveCustomer(string npcID)
		{
			this.RpcWriter___Observers_RemoveCustomer_3615296227(npcID);
			this.RpcLogic___RemoveCustomer_3615296227(npcID);
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x000BB969 File Offset: 0x000B9B69
		public virtual void RemoveCustomer(Customer customer)
		{
			if (!this.AssignedCustomers.Contains(customer))
			{
				return;
			}
			this.AssignedCustomers.Remove(customer);
			customer.AssignDealer(null);
			customer.onContractAssigned.RemoveListener(new UnityAction<Contract>(this.CustomerContractStarted));
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x000BB9A5 File Offset: 0x000B9BA5
		public void ChangeCash(float change)
		{
			this.SetCash(this.Cash + change);
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x000BB9B5 File Offset: 0x000B9BB5
		[ServerRpc(RequireOwnership = false)]
		public void SetCash(float cash)
		{
			this.RpcWriter___Server_SetCash_431000436(cash);
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x000BB9C4 File Offset: 0x000B9BC4
		[ServerRpc(RequireOwnership = false)]
		public virtual void CompletedDeal()
		{
			this.RpcWriter___Server_CompletedDeal_2166136261();
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x000BB9D8 File Offset: 0x000B9BD8
		[ServerRpc(RequireOwnership = false)]
		public void SubmitPayment(float payment)
		{
			this.RpcWriter___Server_SubmitPayment_431000436(payment);
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x000BB9F0 File Offset: 0x000B9BF0
		public List<ProductDefinition> GetOrderableProducts()
		{
			List<ProductDefinition> list = new List<ProductDefinition>();
			foreach (ItemSlot itemSlot in this.GetAllSlots())
			{
				if (itemSlot.ItemInstance != null && itemSlot.ItemInstance is ProductItemInstance)
				{
					ProductItemInstance product = itemSlot.ItemInstance as ProductItemInstance;
					if (list.Find((ProductDefinition x) => x.ID == product.ID) == null)
					{
						list.Add(product.Definition as ProductDefinition);
					}
				}
			}
			return list;
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x000BBAA0 File Offset: 0x000B9CA0
		public int GetProductCount(string productID, EQuality minQuality, EQuality maxQuality)
		{
			int num = 0;
			foreach (ItemSlot itemSlot in this.GetAllSlots())
			{
				if (itemSlot.ItemInstance != null && itemSlot.ItemInstance is ProductItemInstance)
				{
					ProductItemInstance productItemInstance = itemSlot.ItemInstance as ProductItemInstance;
					if (productItemInstance.ID == productID && productItemInstance.Quality >= minQuality && productItemInstance.Quality <= maxQuality)
					{
						num += productItemInstance.Quantity * productItemInstance.Amount;
					}
				}
			}
			return num;
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x000BBB40 File Offset: 0x000B9D40
		private EDealWindow GetDealWindow()
		{
			EDealWindow window = DealWindowInfo.GetWindow(NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.CurrentTime);
			int num = (int)window;
			int num2 = ScheduleOne.GameTime.TimeManager.GetMinSumFrom24HourTime(DealWindowInfo.GetWindowInfo(window).EndTime) - ScheduleOne.GameTime.TimeManager.GetMinSumFrom24HourTime(NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.CurrentTime);
			List<EDealWindow> list = new List<EDealWindow>();
			if (num2 > 120)
			{
				list.Add(window);
			}
			for (int i = 1; i < 4; i++)
			{
				int item = (num + i) % 4;
				list.Add((EDealWindow)item);
			}
			int num3 = 3;
			for (;;)
			{
				foreach (EDealWindow edealWindow in list)
				{
					if (this.GetContractCountInWindow(edealWindow) <= num3)
					{
						return edealWindow;
					}
				}
				num3++;
			}
			EDealWindow result;
			return result;
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x000BBC08 File Offset: 0x000B9E08
		private int GetContractCountInWindow(EDealWindow window)
		{
			int num = 0;
			using (List<Contract>.Enumerator enumerator = this.ActiveContracts.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (DealWindowInfo.GetWindow(ScheduleOne.GameTime.TimeManager.AddMinutesTo24HourTime(enumerator.Current.DeliveryWindow.WindowStartTime, 1)) == window)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x000BBC74 File Offset: 0x000B9E74
		private void CustomerContractStarted(Contract contract)
		{
			if (!this.SyncAccessor_acceptedContractGUIDs.Contains(contract.GUID.ToString()))
			{
				return;
			}
			this.ActiveContracts.Add(contract);
			contract.SetDealer(this);
			contract.onQuestEnd.AddListener(new UnityAction<EQuestState>(delegate(EQuestState <p0>)
			{
				this.CustomerContractEnded(contract);
			}));
			contract.ShouldSendExpiredNotification = false;
			contract.ShouldSendExpiryReminder = false;
			base.Invoke("SortContracts", 0.05f);
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x000BBD20 File Offset: 0x000B9F20
		private void CustomerContractEnded(Contract contract)
		{
			if (!this.ActiveContracts.Contains(contract))
			{
				return;
			}
			this.ActiveContracts.Remove(contract);
			contract.SetDealer(null);
			if (InstanceFinder.IsServer && this.GetTotalInventoryItemCount() == 0)
			{
				DialogueChain chain = this.dialogueHandler.Database.GetChain(EDialogueModule.Dealer, "inventory_depleted");
				base.MSGConversation.SendMessageChain(chain.GetMessageChain(), 0f, true, true);
			}
			base.Invoke("SortContracts", 0.05f);
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x000BBD9E File Offset: 0x000B9F9E
		private void SortContracts()
		{
			this.ActiveContracts = (from x in this.ActiveContracts
			orderby x.GetMinsUntilExpiry()
			select x).ToList<Contract>();
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void RecruitmentRequested()
		{
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x000BBDD8 File Offset: 0x000B9FD8
		public bool RemoveContractItems(Contract contract, EQuality targetQuality, out List<ItemInstance> items)
		{
			Dealer.<>c__DisplayClass101_0 CS$<>8__locals1 = new Dealer.<>c__DisplayClass101_0();
			CS$<>8__locals1.targetQuality = targetQuality;
			CS$<>8__locals1.<>4__this = this;
			items = new List<ItemInstance>();
			foreach (ProductList.Entry entry in contract.ProductList.entries)
			{
				int num;
				List<ItemInstance> items2 = this.GetItems(entry.ProductID, entry.Quantity, new Func<ProductItemInstance, bool>(CS$<>8__locals1.<RemoveContractItems>g__DoesQualityMatch|0), out num);
				if (num < entry.Quantity)
				{
					Console.LogWarning("Could not find enough items for contract entry: " + entry.ProductID, null);
				}
				items.AddRange(items2);
			}
			this.TryMoveOverflowItems();
			return true;
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x000BBE94 File Offset: 0x000BA094
		private List<ItemInstance> GetItems(string ID, int requiredQuantity, Func<ProductItemInstance, bool> qualityCheck, out int returnedQuantity)
		{
			List<ItemInstance> list = new List<ItemInstance>();
			returnedQuantity = 0;
			List<ItemSlot> allSlots = this.GetAllSlots();
			for (int i = 0; i < allSlots.Count; i++)
			{
				if (allSlots[i].ItemInstance == null)
				{
					allSlots.RemoveAt(i);
					i--;
				}
				else
				{
					ProductItemInstance productItemInstance = allSlots[i].ItemInstance as ProductItemInstance;
					if (productItemInstance == null || productItemInstance.ID != ID || productItemInstance.AppliedPackaging == null || !qualityCheck(productItemInstance))
					{
						allSlots.RemoveAt(i);
						i--;
					}
				}
			}
			allSlots.Sort(delegate(ItemSlot x, ItemSlot y)
			{
				if (x.ItemInstance == null)
				{
					return 1;
				}
				if (y.ItemInstance == null)
				{
					return -1;
				}
				return (y.ItemInstance as ProductItemInstance).Amount.CompareTo((x.ItemInstance as ProductItemInstance).Amount);
			});
			foreach (ItemSlot itemSlot in allSlots)
			{
				int amount = (itemSlot.ItemInstance as ProductItemInstance).Amount;
				while (requiredQuantity >= amount && itemSlot.Quantity > 0)
				{
					list.Add(itemSlot.ItemInstance.GetCopy(1));
					itemSlot.ChangeQuantity(-1, false);
					returnedQuantity += amount;
					requiredQuantity -= amount;
				}
			}
			if (requiredQuantity > 0)
			{
				while (requiredQuantity > 0)
				{
					allSlots = this.GetAllSlots();
					for (int j = 0; j < allSlots.Count; j++)
					{
						if (allSlots[j].ItemInstance == null)
						{
							allSlots.RemoveAt(j);
							j--;
						}
						else
						{
							ProductItemInstance productItemInstance2 = allSlots[j].ItemInstance as ProductItemInstance;
							if (productItemInstance2 == null || productItemInstance2.ID != ID || productItemInstance2.AppliedPackaging == null || !qualityCheck(productItemInstance2))
							{
								allSlots.RemoveAt(j);
								j--;
							}
						}
					}
					if (allSlots.Count == 0)
					{
						Console.LogWarning("Dealer " + base.fullName + " has no items to fulfill contract", null);
						return list;
					}
					allSlots.Sort(delegate(ItemSlot x, ItemSlot y)
					{
						if (x.ItemInstance == null)
						{
							return -1;
						}
						if (y.ItemInstance == null)
						{
							return 1;
						}
						return (x.ItemInstance as ProductItemInstance).Amount.CompareTo((y.ItemInstance as ProductItemInstance).Amount);
					});
					ItemSlot itemSlot2 = allSlots[0];
					int amount2 = (itemSlot2.ItemInstance as ProductItemInstance).Amount;
					if (requiredQuantity >= amount2)
					{
						while (requiredQuantity >= amount2)
						{
							if (itemSlot2.Quantity <= 0)
							{
								break;
							}
							Console.Log(string.Concat(new string[]
							{
								"Removing 1x ",
								itemSlot2.ItemInstance.Name,
								"(",
								(itemSlot2.ItemInstance as ProductItemInstance).AppliedPackaging.Name,
								")"
							}), null);
							list.Add(itemSlot2.ItemInstance.GetCopy(1));
							itemSlot2.ChangeQuantity(-1, false);
							returnedQuantity += amount2;
							requiredQuantity -= amount2;
						}
					}
					else
					{
						PackagingDefinition appliedPackaging = (itemSlot2.ItemInstance as ProductItemInstance).AppliedPackaging;
						ProductDefinition productDefinition = (itemSlot2.ItemInstance as ProductItemInstance).Definition as ProductDefinition;
						PackagingDefinition packagingDefinition = null;
						for (int k = 0; k < productDefinition.ValidPackaging.Length; k++)
						{
							if (productDefinition.ValidPackaging[k].ID == appliedPackaging.ID && k > 0)
							{
								packagingDefinition = productDefinition.ValidPackaging[k - 1];
							}
						}
						if (packagingDefinition == null)
						{
							Console.LogWarning("Failed to find next packaging smaller than " + appliedPackaging.ID, null);
							break;
						}
						int quantity = packagingDefinition.Quantity;
						int overrideQuantity = appliedPackaging.Quantity / quantity;
						Console.Log(string.Concat(new string[]
						{
							"Splitting 1x ",
							itemSlot2.ItemInstance.Name,
							"(",
							appliedPackaging.Name,
							") into ",
							overrideQuantity.ToString(),
							"x ",
							packagingDefinition.Name
						}), null);
						ProductItemInstance productItemInstance3 = itemSlot2.ItemInstance.GetCopy(overrideQuantity) as ProductItemInstance;
						productItemInstance3.SetPackaging(packagingDefinition);
						itemSlot2.ChangeQuantity(-1, false);
						this.AddItemToInventory(productItemInstance3);
					}
				}
			}
			return list;
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x000BC2B4 File Offset: 0x000BA4B4
		public List<ItemSlot> GetAllSlots()
		{
			List<ItemSlot> list = new List<ItemSlot>(base.Inventory.ItemSlots);
			list.AddRange(this.OverflowSlots);
			return list;
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x000BC2D4 File Offset: 0x000BA4D4
		public void AddItemToInventory(ItemInstance item)
		{
			while (base.Inventory.CanItemFit(item, 1) && item.Quantity > 0)
			{
				base.Inventory.InsertItem(item.GetCopy(1), true);
				item.ChangeQuantity(-1);
			}
			if (item.Quantity > 0 && !ItemSlot.TryInsertItemIntoSet(this.OverflowSlots.ToList<ItemSlot>(), item))
			{
				Console.LogWarning("Dealer " + base.fullName + " has doesn't have enough space for item " + item.ID, null);
			}
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x000BC354 File Offset: 0x000BA554
		public void TryMoveOverflowItems()
		{
			foreach (ItemSlot itemSlot in this.OverflowSlots)
			{
				if (itemSlot.ItemInstance != null)
				{
					while (base.Inventory.CanItemFit(itemSlot.ItemInstance, 1) && itemSlot.ItemInstance.Quantity > 0)
					{
						base.Inventory.InsertItem(itemSlot.ItemInstance.GetCopy(1), true);
						itemSlot.ItemInstance.ChangeQuantity(-1);
					}
				}
			}
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x000BC3CC File Offset: 0x000BA5CC
		public int GetTotalInventoryItemCount()
		{
			List<ItemSlot> allSlots = this.GetAllSlots();
			int num = 0;
			foreach (ItemSlot itemSlot in allSlots)
			{
				if (itemSlot.ItemInstance != null)
				{
					num += itemSlot.ItemInstance.Quantity;
				}
			}
			return num;
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x000BC434 File Offset: 0x000BA634
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			this.RpcWriter___Server_SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
			this.RpcLogic___SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x000BC45C File Offset: 0x000BA65C
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetStoredInstance_Internal_2652194801(conn, itemSlotIndex, instance);
				this.RpcLogic___SetStoredInstance_Internal_2652194801(conn, itemSlotIndex, instance);
			}
			else
			{
				this.RpcWriter___Target_SetStoredInstance_Internal_2652194801(conn, itemSlotIndex, instance);
				this.RpcLogic___SetStoredInstance_Internal_2652194801(conn, itemSlotIndex, instance);
			}
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x000BC4BB File Offset: 0x000BA6BB
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Server_SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x000BC4D9 File Offset: 0x000BA6D9
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x000BC4F7 File Offset: 0x000BA6F7
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			this.RpcWriter___Server_SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
			this.RpcLogic___SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x000BC530 File Offset: 0x000BA730
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetSlotLocked_Internal_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
				this.RpcLogic___SetSlotLocked_Internal_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
			}
			else
			{
				this.RpcWriter___Target_SetSlotLocked_Internal_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
				this.RpcLogic___SetSlotLocked_Internal_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
			}
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x000BC5B0 File Offset: 0x000BA7B0
		public override string GetSaveString()
		{
			string[] array = new string[this.AssignedCustomers.Count];
			for (int i = 0; i < this.AssignedCustomers.Count; i++)
			{
				array[i] = this.AssignedCustomers[i].NPC.ID;
			}
			string[] array2 = new string[this.ActiveContracts.Count];
			for (int j = 0; j < this.ActiveContracts.Count; j++)
			{
				array2[j] = this.ActiveContracts[j].GUID.ToString();
			}
			return new DealerData(this.ID, this.IsRecruited, array, array2, this.Cash, new ItemSet(this.OverflowSlots), this.HasBeenRecommended).GetJson(true);
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x000BC678 File Offset: 0x000BA878
		public override void Load(NPCData data, string containerPath)
		{
			base.Load(data, containerPath);
			string text;
			if (((ISaveable)this).TryLoadFile(containerPath, "NPC", out text))
			{
				DealerData dealerData = null;
				try
				{
					dealerData = JsonUtility.FromJson<DealerData>(text);
				}
				catch (Exception ex)
				{
					Console.LogWarning("Failed to deserialize character data: " + ex.Message, null);
					return;
				}
				if (dealerData == null)
				{
					return;
				}
				if (dealerData.Recruited)
				{
					this.SetIsRecruited(null);
				}
				this.SetCash(dealerData.Cash);
				for (int i = 0; i < dealerData.AssignedCustomerIDs.Length; i++)
				{
					NPC npc = NPCManager.GetNPC(dealerData.AssignedCustomerIDs[i]);
					if (npc == null)
					{
						Console.LogWarning("Failed to find customer NPC with ID " + dealerData.AssignedCustomerIDs[i], null);
					}
					else
					{
						Customer component = npc.GetComponent<Customer>();
						if (component == null)
						{
							Console.LogWarning("NPC is not a customer: " + npc.fullName, null);
						}
						else
						{
							this.SendAddCustomer(component.NPC.ID);
						}
					}
				}
				if (dealerData.ActiveContractGUIDs != null)
				{
					for (int j = 0; j < dealerData.ActiveContractGUIDs.Length; j++)
					{
						if (!GUIDManager.IsGUIDValid(dealerData.ActiveContractGUIDs[j]))
						{
							Console.LogWarning("Invalid contract GUID: " + dealerData.ActiveContractGUIDs[j], null);
						}
						else
						{
							Contract @object = GUIDManager.GetObject<Contract>(new Guid(dealerData.ActiveContractGUIDs[j]));
							if (@object != null)
							{
								this.SyncAccessor_acceptedContractGUIDs.Add(@object.GUID.ToString());
								this.CustomerContractStarted(@object);
							}
						}
					}
				}
				if (dealerData.HasBeenRecommended)
				{
					this.MarkAsRecommended();
				}
				for (int k = 0; k < dealerData.OverflowItems.Items.Length; k++)
				{
					ItemInstance instance = ItemDeserializer.LoadItem(dealerData.OverflowItems.Items[k]);
					if (this.OverflowSlots.Length > k)
					{
						this.OverflowSlots[k].SetStoredItem(instance, false);
					}
				}
			}
		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x000BC934 File Offset: 0x000BAB34
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Economy.DealerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Economy.DealerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___acceptedContractGUIDs = new SyncVar<List<string>>(this, 2U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.acceptedContractGUIDs);
			this.syncVar___<Cash>k__BackingField = new SyncVar<float>(this, 1U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.<Cash>k__BackingField);
			this.syncVar___<Cash>k__BackingField.OnChange += this.UpdateCollectCashChoice;
			base.RegisterServerRpc(35U, new ServerRpcDelegate(this.RpcReader___Server_MarkAsRecommended_2166136261));
			base.RegisterObserversRpc(36U, new ClientRpcDelegate(this.RpcReader___Observers_SetRecommended_2166136261));
			base.RegisterServerRpc(37U, new ServerRpcDelegate(this.RpcReader___Server_InitialRecruitment_2166136261));
			base.RegisterObserversRpc(38U, new ClientRpcDelegate(this.RpcReader___Observers_SetIsRecruited_328543758));
			base.RegisterTargetRpc(39U, new ClientRpcDelegate(this.RpcReader___Target_SetIsRecruited_328543758));
			base.RegisterServerRpc(40U, new ServerRpcDelegate(this.RpcReader___Server_SendAddCustomer_3615296227));
			base.RegisterObserversRpc(41U, new ClientRpcDelegate(this.RpcReader___Observers_AddCustomer_2971853958));
			base.RegisterTargetRpc(42U, new ClientRpcDelegate(this.RpcReader___Target_AddCustomer_2971853958));
			base.RegisterServerRpc(43U, new ServerRpcDelegate(this.RpcReader___Server_SendRemoveCustomer_3615296227));
			base.RegisterObserversRpc(44U, new ClientRpcDelegate(this.RpcReader___Observers_RemoveCustomer_3615296227));
			base.RegisterServerRpc(45U, new ServerRpcDelegate(this.RpcReader___Server_SetCash_431000436));
			base.RegisterServerRpc(46U, new ServerRpcDelegate(this.RpcReader___Server_CompletedDeal_2166136261));
			base.RegisterServerRpc(47U, new ServerRpcDelegate(this.RpcReader___Server_SubmitPayment_431000436));
			base.RegisterServerRpc(48U, new ServerRpcDelegate(this.RpcReader___Server_SetStoredInstance_2652194801));
			base.RegisterObserversRpc(49U, new ClientRpcDelegate(this.RpcReader___Observers_SetStoredInstance_Internal_2652194801));
			base.RegisterTargetRpc(50U, new ClientRpcDelegate(this.RpcReader___Target_SetStoredInstance_Internal_2652194801));
			base.RegisterServerRpc(51U, new ServerRpcDelegate(this.RpcReader___Server_SetItemSlotQuantity_1692629761));
			base.RegisterObserversRpc(52U, new ClientRpcDelegate(this.RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761));
			base.RegisterServerRpc(53U, new ServerRpcDelegate(this.RpcReader___Server_SetSlotLocked_3170825843));
			base.RegisterTargetRpc(54U, new ClientRpcDelegate(this.RpcReader___Target_SetSlotLocked_Internal_3170825843));
			base.RegisterObserversRpc(55U, new ClientRpcDelegate(this.RpcReader___Observers_SetSlotLocked_Internal_3170825843));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.Economy.Dealer));
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x000BCBBA File Offset: 0x000BADBA
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Economy.DealerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Economy.DealerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___acceptedContractGUIDs.SetRegistered();
			this.syncVar___<Cash>k__BackingField.SetRegistered();
		}

		// Token: 0x06002D40 RID: 11584 RVA: 0x000BCBE9 File Offset: 0x000BADE9
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x000BCBF8 File Offset: 0x000BADF8
		private void RpcWriter___Server_MarkAsRecommended_2166136261()
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendServerRpc(35U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x000BCC92 File Offset: 0x000BAE92
		public void RpcLogic___MarkAsRecommended_2166136261()
		{
			this.SetRecommended();
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x000BCC9C File Offset: 0x000BAE9C
		private void RpcReader___Server_MarkAsRecommended_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___MarkAsRecommended_2166136261();
		}

		// Token: 0x06002D44 RID: 11588 RVA: 0x000BCCCC File Offset: 0x000BAECC
		private void RpcWriter___Observers_SetRecommended_2166136261()
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendObserversRpc(36U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x000BCD75 File Offset: 0x000BAF75
		private void RpcLogic___SetRecommended_2166136261()
		{
			if (this.HasBeenRecommended)
			{
				return;
			}
			this.HasBeenRecommended = true;
			base.HasChanged = true;
			if (this.onRecommended != null)
			{
				this.onRecommended.Invoke();
			}
		}

		// Token: 0x06002D46 RID: 11590 RVA: 0x000BCDA4 File Offset: 0x000BAFA4
		private void RpcReader___Observers_SetRecommended_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetRecommended_2166136261();
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x000BCDD0 File Offset: 0x000BAFD0
		private void RpcWriter___Server_InitialRecruitment_2166136261()
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendServerRpc(37U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x000BC92A File Offset: 0x000BAB2A
		public void RpcLogic___InitialRecruitment_2166136261()
		{
			this.SetIsRecruited(null);
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x000BCE6C File Offset: 0x000BB06C
		private void RpcReader___Server_InitialRecruitment_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___InitialRecruitment_2166136261();
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x000BCE9C File Offset: 0x000BB09C
		private void RpcWriter___Observers_SetIsRecruited_328543758(NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendObserversRpc(38U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x000BCF48 File Offset: 0x000BB148
		public virtual void RpcLogic___SetIsRecruited_328543758(NetworkConnection conn)
		{
			if (this.IsRecruited)
			{
				return;
			}
			this.IsRecruited = true;
			DialogueController.GreetingOverride greetingOverride = new DialogueController.GreetingOverride();
			greetingOverride.Greeting = "Hi boss, what do you need?";
			greetingOverride.PlayVO = true;
			greetingOverride.VOType = EVOLineType.Greeting;
			greetingOverride.ShouldShow = true;
			this.DialogueController.AddGreetingOverride(greetingOverride);
			DialogueController.DialogueChoice dialogueChoice = new DialogueController.DialogueChoice();
			dialogueChoice.ChoiceText = "I need to trade some items";
			dialogueChoice.Enabled = true;
			dialogueChoice.onChoosen.AddListener(new UnityAction(this.TradeItems));
			this.DialogueController.AddDialogueChoice(dialogueChoice, 5);
			this.collectCashChoice = new DialogueController.DialogueChoice();
			this.UpdateCollectCashChoice(0f, 0f, false);
			this.collectCashChoice.Enabled = true;
			this.collectCashChoice.isValidCheck = new DialogueController.DialogueChoice.IsChoiceValid(this.CanCollectCash);
			this.collectCashChoice.onChoosen.AddListener(new UnityAction(this.CollectCash));
			this.collectCashChoice.Conversation = this.CollectCashDialogue;
			this.DialogueController.AddDialogueChoice(this.collectCashChoice, 4);
			this.assignCustomersChoice = new DialogueController.DialogueChoice();
			this.assignCustomersChoice.ChoiceText = "How do I assign customers to you?";
			this.assignCustomersChoice.Enabled = true;
			this.assignCustomersChoice.Conversation = this.AssignCustomersDialogue;
			this.DialogueController.AddDialogueChoice(this.assignCustomersChoice, 3);
			if (this.dealerPoI != null)
			{
				this.dealerPoI.enabled = true;
			}
			if (!this.RelationData.Unlocked)
			{
				this.RelationData.Unlock(NPCRelationData.EUnlockType.DirectApproach, false);
			}
			if (this.recruitChoice != null)
			{
				this.recruitChoice.Enabled = false;
			}
			if (Dealer.onDealerRecruited != null)
			{
				Dealer.onDealerRecruited(this);
			}
			base.HasChanged = true;
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x000BD100 File Offset: 0x000BB300
		private void RpcReader___Observers_SetIsRecruited_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetIsRecruited_328543758(null);
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x000BD12C File Offset: 0x000BB32C
		private void RpcWriter___Target_SetIsRecruited_328543758(NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendTargetRpc(39U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x000BD1D4 File Offset: 0x000BB3D4
		private void RpcReader___Target_SetIsRecruited_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetIsRecruited_328543758(base.LocalConnection);
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x000BD1FC File Offset: 0x000BB3FC
		private void RpcWriter___Server_SendAddCustomer_3615296227(string npcID)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(npcID);
			base.SendServerRpc(40U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002D50 RID: 11600 RVA: 0x000BD2A3 File Offset: 0x000BB4A3
		public void RpcLogic___SendAddCustomer_3615296227(string npcID)
		{
			this.AddCustomer(null, npcID);
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x000BD2B0 File Offset: 0x000BB4B0
		private void RpcReader___Server_SendAddCustomer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string npcID = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendAddCustomer_3615296227(npcID);
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x000BD2F0 File Offset: 0x000BB4F0
		private void RpcWriter___Observers_AddCustomer_2971853958(NetworkConnection conn, string npcID)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(npcID);
			base.SendObserversRpc(41U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002D53 RID: 11603 RVA: 0x000BD3A8 File Offset: 0x000BB5A8
		private void RpcLogic___AddCustomer_2971853958(NetworkConnection conn, string npcID)
		{
			NPC npc = NPCManager.GetNPC(npcID);
			if (npc == null)
			{
				Console.LogWarning("Failed to find NPC with ID: " + npcID, null);
				return;
			}
			Customer component = npc.GetComponent<Customer>();
			if (component == null)
			{
				Console.LogWarning("NPC " + npcID + " is not a customer", null);
				return;
			}
			this.AddCustomer(component);
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x000BD408 File Offset: 0x000BB608
		private void RpcReader___Observers_AddCustomer_2971853958(PooledReader PooledReader0, Channel channel)
		{
			string npcID = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___AddCustomer_2971853958(null, npcID);
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x000BD444 File Offset: 0x000BB644
		private void RpcWriter___Target_AddCustomer_2971853958(NetworkConnection conn, string npcID)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(npcID);
			base.SendTargetRpc(42U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x000BD4FC File Offset: 0x000BB6FC
		private void RpcReader___Target_AddCustomer_2971853958(PooledReader PooledReader0, Channel channel)
		{
			string npcID = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___AddCustomer_2971853958(base.LocalConnection, npcID);
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x000BD534 File Offset: 0x000BB734
		private void RpcWriter___Server_SendRemoveCustomer_3615296227(string npcID)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(npcID);
			base.SendServerRpc(43U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x000BD5DB File Offset: 0x000BB7DB
		public void RpcLogic___SendRemoveCustomer_3615296227(string npcID)
		{
			this.RemoveCustomer(npcID);
		}

		// Token: 0x06002D59 RID: 11609 RVA: 0x000BD5E4 File Offset: 0x000BB7E4
		private void RpcReader___Server_SendRemoveCustomer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string npcID = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendRemoveCustomer_3615296227(npcID);
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x000BD624 File Offset: 0x000BB824
		private void RpcWriter___Observers_RemoveCustomer_3615296227(string npcID)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(npcID);
			base.SendObserversRpc(44U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x000BD6DC File Offset: 0x000BB8DC
		private void RpcLogic___RemoveCustomer_3615296227(string npcID)
		{
			NPC npc = NPCManager.GetNPC(npcID);
			if (npc == null)
			{
				Console.LogWarning("Failed to find NPC with ID: " + npcID, null);
				return;
			}
			Customer component = npc.GetComponent<Customer>();
			if (component == null)
			{
				Console.LogWarning("NPC " + npcID + " is not a customer", null);
				return;
			}
			this.RemoveCustomer(component);
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x000BD73C File Offset: 0x000BB93C
		private void RpcReader___Observers_RemoveCustomer_3615296227(PooledReader PooledReader0, Channel channel)
		{
			string npcID = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___RemoveCustomer_3615296227(npcID);
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x000BD778 File Offset: 0x000BB978
		private void RpcWriter___Server_SetCash_431000436(float cash)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteSingle(cash, AutoPackType.Unpacked);
			base.SendServerRpc(45U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x000BD824 File Offset: 0x000BBA24
		public void RpcLogic___SetCash_431000436(float cash)
		{
			this.Cash = Mathf.Clamp(cash, 0f, float.MaxValue);
			base.HasChanged = true;
			this.UpdateCollectCashChoice(0f, 0f, false);
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x000BD854 File Offset: 0x000BBA54
		private void RpcReader___Server_SetCash_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			float cash = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SetCash_431000436(cash);
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x000BD88C File Offset: 0x000BBA8C
		private void RpcWriter___Server_CompletedDeal_2166136261()
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendServerRpc(46U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x000BD928 File Offset: 0x000BBB28
		public virtual void RpcLogic___CompletedDeal_2166136261()
		{
			this.RelationData.ChangeRelationship(0.05f, true);
			if (this.CompletedDealsVariable != string.Empty)
			{
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue(this.CompletedDealsVariable, (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>(this.CompletedDealsVariable) + 1f).ToString(), true);
			}
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x000BD988 File Offset: 0x000BBB88
		private void RpcReader___Server_CompletedDeal_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___CompletedDeal_2166136261();
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x000BD9A8 File Offset: 0x000BBBA8
		private void RpcWriter___Server_SubmitPayment_431000436(float payment)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteSingle(payment, AutoPackType.Unpacked);
			base.SendServerRpc(47U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x000BDA54 File Offset: 0x000BBC54
		public void RpcLogic___SubmitPayment_431000436(float payment)
		{
			if (payment <= 0f)
			{
				return;
			}
			Console.Log("Dealer " + base.fullName + " received payment: " + payment.ToString(), null);
			float cash = this.Cash;
			this.ChangeCash(payment * (1f - this.Cut));
			if (InstanceFinder.IsServer && this.Cash >= 500f && cash < 500f)
			{
				base.MSGConversation.SendMessage(new Message("Hey boss, just letting you know I've got " + MoneyManager.FormatAmount(this.Cash, false, false) + " ready for you to collect.", Message.ESenderType.Other, true, -1), true, true);
			}
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x000BDAF4 File Offset: 0x000BBCF4
		private void RpcReader___Server_SubmitPayment_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			float payment = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SubmitPayment_431000436(payment);
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x000BDB2C File Offset: 0x000BBD2C
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteNetworkConnection(conn);
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteItemInstance(instance);
			base.SendServerRpc(48U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x000BDBF2 File Offset: 0x000BBDF2
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetStoredInstance_Internal(null, itemSlotIndex, instance);
				return;
			}
			this.SetStoredInstance_Internal(conn, itemSlotIndex, instance);
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x000BDC1C File Offset: 0x000BBE1C
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkConnection conn2 = PooledReader0.ReadNetworkConnection();
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			ItemInstance instance = PooledReader0.ReadItemInstance();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetStoredInstance_2652194801(conn2, itemSlotIndex, instance);
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x000BDC84 File Offset: 0x000BBE84
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteItemInstance(instance);
			base.SendObserversRpc(49U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x000BDD4C File Offset: 0x000BBF4C
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (instance != null)
			{
				this.ItemSlots[itemSlotIndex].SetStoredItem(instance, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].ClearStoredInstance(true);
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x000BDD78 File Offset: 0x000BBF78
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			ItemInstance instance = PooledReader0.ReadItemInstance();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetStoredInstance_Internal_2652194801(null, itemSlotIndex, instance);
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x000BDDCC File Offset: 0x000BBFCC
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteItemInstance(instance);
			base.SendTargetRpc(50U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x000BDE94 File Offset: 0x000BC094
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			ItemInstance instance = PooledReader0.ReadItemInstance();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetStoredInstance_Internal_2652194801(base.LocalConnection, itemSlotIndex, instance);
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x000BDEEC File Offset: 0x000BC0EC
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteInt32(quantity, AutoPackType.Packed);
			base.SendServerRpc(51U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x000BDFAA File Offset: 0x000BC1AA
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			this.SetItemSlotQuantity_Internal(itemSlotIndex, quantity);
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x000BDFB4 File Offset: 0x000BC1B4
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			int quantity = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x000BE010 File Offset: 0x000BC210
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteInt32(quantity, AutoPackType.Packed);
			base.SendObserversRpc(52U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x000BE0DD File Offset: 0x000BC2DD
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			this.ItemSlots[itemSlotIndex].SetQuantity(quantity, true);
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x000BE0F4 File Offset: 0x000BC2F4
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			int quantity = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x000BE14C File Offset: 0x000BC34C
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteNetworkConnection(conn);
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteBoolean(locked);
			writer.WriteNetworkObject(lockOwner);
			writer.WriteString(lockReason);
			base.SendServerRpc(53U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x000BE22C File Offset: 0x000BC42C
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetSlotLocked_Internal(null, itemSlotIndex, locked, lockOwner, lockReason);
				return;
			}
			this.SetSlotLocked_Internal(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x000BE25C File Offset: 0x000BC45C
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkConnection conn2 = PooledReader0.ReadNetworkConnection();
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			bool locked = PooledReader0.ReadBoolean();
			NetworkObject lockOwner = PooledReader0.ReadNetworkObject();
			string lockReason = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetSlotLocked_3170825843(conn2, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x000BE2E4 File Offset: 0x000BC4E4
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteBoolean(locked);
			writer.WriteNetworkObject(lockOwner);
			writer.WriteString(lockReason);
			base.SendTargetRpc(54U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x000BE3C5 File Offset: 0x000BC5C5
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (locked)
			{
				this.ItemSlots[itemSlotIndex].ApplyLock(lockOwner, lockReason, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].RemoveLock(true);
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x000BE3F4 File Offset: 0x000BC5F4
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			bool locked = PooledReader0.ReadBoolean();
			NetworkObject lockOwner = PooledReader0.ReadNetworkObject();
			string lockReason = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetSlotLocked_Internal_3170825843(base.LocalConnection, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x000BE470 File Offset: 0x000BC670
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteBoolean(locked);
			writer.WriteNetworkObject(lockOwner);
			writer.WriteString(lockReason);
			base.SendObserversRpc(55U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x000BE554 File Offset: 0x000BC754
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			bool locked = PooledReader0.ReadBoolean();
			NetworkObject lockOwner = PooledReader0.ReadNetworkObject();
			string lockReason = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetSlotLocked_Internal_3170825843(null, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06002D7C RID: 11644 RVA: 0x000BE5C8 File Offset: 0x000BC7C8
		// (set) Token: 0x06002D7D RID: 11645 RVA: 0x000BE5D0 File Offset: 0x000BC7D0
		public float SyncAccessor_<Cash>k__BackingField
		{
			get
			{
				return this.<Cash>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<Cash>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<Cash>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x000BE60C File Offset: 0x000BC80C
		public virtual bool Dealer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 == 2U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_acceptedContractGUIDs(this.syncVar___acceptedContractGUIDs.GetValue(true), true);
					return true;
				}
				List<string> value = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generateds(PooledReader0);
				this.sync___set_value_acceptedContractGUIDs(value, Boolean2);
				return true;
			}
			else
			{
				if (UInt321 != 1U)
				{
					return false;
				}
				if (PooledReader0 == null)
				{
					this.sync___set_value_<Cash>k__BackingField(this.syncVar___<Cash>k__BackingField.GetValue(true), true);
					return true;
				}
				float value2 = PooledReader0.ReadSingle(AutoPackType.Unpacked);
				this.sync___set_value_<Cash>k__BackingField(value2, Boolean2);
				return true;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06002D7F RID: 11647 RVA: 0x000BE6A7 File Offset: 0x000BC8A7
		// (set) Token: 0x06002D80 RID: 11648 RVA: 0x000BE6AF File Offset: 0x000BC8AF
		public List<string> SyncAccessor_acceptedContractGUIDs
		{
			get
			{
				return this.acceptedContractGUIDs;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.acceptedContractGUIDs = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___acceptedContractGUIDs.SetValue(value, value);
				}
			}
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x000BE6EC File Offset: 0x000BC8EC
		protected virtual void dll()
		{
			base.Awake();
			this.HomeEvent.Building = this.Home;
			this.OverflowSlots = new ItemSlot[10];
			for (int i = 0; i < 10; i++)
			{
				this.OverflowSlots[i] = new ItemSlot();
				this.OverflowSlots[i].SetSlotOwner(this);
			}
			if (this.RelationData.Unlocked)
			{
				this.SetIsRecruited(null);
			}
			else
			{
				NPCRelationData relationData = this.RelationData;
				relationData.onUnlocked = (Action<NPCRelationData.EUnlockType, bool>)Delegate.Combine(relationData.onUnlocked, new Action<NPCRelationData.EUnlockType, bool>(delegate(NPCRelationData.EUnlockType <p0>, bool <p1>)
				{
					this.SetIsRecruited(null);
				}));
			}
			if (!Dealer.AllDealers.Contains(this))
			{
				Dealer.AllDealers.Add(this);
			}
		}

		// Token: 0x0400200A RID: 8202
		public const int MAX_CUSTOMERS = 8;

		// Token: 0x0400200B RID: 8203
		public const int DEAL_ARRIVAL_DELAY = 30;

		// Token: 0x0400200C RID: 8204
		public const int MIN_TRAVEL_TIME = 15;

		// Token: 0x0400200D RID: 8205
		public const int MAX_TRAVEL_TIME = 360;

		// Token: 0x0400200E RID: 8206
		public const int OVERFLOW_SLOT_COUNT = 10;

		// Token: 0x0400200F RID: 8207
		public const float CASH_REMINDER_THRESHOLD = 500f;

		// Token: 0x04002010 RID: 8208
		public const float RELATIONSHIP_CHANGE_PER_DEAL = 0.05f;

		// Token: 0x04002011 RID: 8209
		public static Action<Dealer> onDealerRecruited;

		// Token: 0x04002012 RID: 8210
		public static Color32 DealerLabelColor = new Color32(120, 200, byte.MaxValue, byte.MaxValue);

		// Token: 0x04002013 RID: 8211
		public static List<Dealer> AllDealers = new List<Dealer>();

		// Token: 0x04002016 RID: 8214
		[Header("Debug")]
		public List<Customer> InitialCustomers = new List<Customer>();

		// Token: 0x04002017 RID: 8215
		public List<ProductDefinition> InitialItems = new List<ProductDefinition>();

		// Token: 0x04002018 RID: 8216
		[Header("Dealer References")]
		public NPCEnterableBuilding Home;

		// Token: 0x04002019 RID: 8217
		public NPCSignal_HandleDeal DealSignal;

		// Token: 0x0400201A RID: 8218
		public NPCEvent_StayInBuilding HomeEvent;

		// Token: 0x0400201B RID: 8219
		public DialogueController_Dealer DialogueController;

		// Token: 0x0400201C RID: 8220
		[Header("Dialogue stuff")]
		public DialogueContainer RecruitDialogue;

		// Token: 0x0400201D RID: 8221
		public DialogueContainer CollectCashDialogue;

		// Token: 0x0400201E RID: 8222
		public DialogueContainer AssignCustomersDialogue;

		// Token: 0x0400201F RID: 8223
		[Header("Dealer Settings")]
		public string HomeName = "Home";

		// Token: 0x04002020 RID: 8224
		public float SigningFee = 500f;

		// Token: 0x04002021 RID: 8225
		public float Cut = 0.2f;

		// Token: 0x04002022 RID: 8226
		public bool SellInsufficientQualityItems;

		// Token: 0x04002023 RID: 8227
		public bool SellExcessQualityItems = true;

		// Token: 0x04002024 RID: 8228
		[Header("Variables")]
		public string CompletedDealsVariable = string.Empty;

		// Token: 0x04002026 RID: 8230
		public List<Customer> AssignedCustomers = new List<Customer>();

		// Token: 0x04002027 RID: 8231
		public List<Contract> ActiveContracts = new List<Contract>();

		// Token: 0x04002029 RID: 8233
		public UnityEvent onRecommended = new UnityEvent();

		// Token: 0x0400202A RID: 8234
		protected ItemSlot[] OverflowSlots;

		// Token: 0x0400202B RID: 8235
		private Contract currentContract;

		// Token: 0x0400202C RID: 8236
		private DialogueController.DialogueChoice recruitChoice;

		// Token: 0x0400202D RID: 8237
		private DialogueController.DialogueChoice collectCashChoice;

		// Token: 0x0400202E RID: 8238
		private DialogueController.DialogueChoice assignCustomersChoice;

		// Token: 0x04002031 RID: 8241
		[SyncVar]
		public List<string> acceptedContractGUIDs = new List<string>();

		// Token: 0x04002032 RID: 8242
		private int itemCountOnTradeStart;

		// Token: 0x04002033 RID: 8243
		public SyncVar<float> syncVar___<Cash>k__BackingField;

		// Token: 0x04002034 RID: 8244
		public SyncVar<List<string>> syncVar___acceptedContractGUIDs;

		// Token: 0x04002035 RID: 8245
		private bool dll_Excuted;

		// Token: 0x04002036 RID: 8246
		private bool dll_Excuted;
	}
}
