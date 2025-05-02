using System;
using System.Collections;
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
using ScheduleOne.Levelling;
using ScheduleOne.Messaging;
using ScheduleOne.Money;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Quests;
using ScheduleOne.Storage;
using ScheduleOne.UI.Phone;
using ScheduleOne.UI.Phone.Delivery;
using ScheduleOne.UI.Phone.Messages;
using ScheduleOne.UI.Shop;
using ScheduleOne.Variables;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Economy
{
	// Token: 0x0200067B RID: 1659
	public class Supplier : NPC
	{
		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06002DA9 RID: 11689 RVA: 0x000BEDE1 File Offset: 0x000BCFE1
		// (set) Token: 0x06002DAA RID: 11690 RVA: 0x000BEDE9 File Offset: 0x000BCFE9
		public Supplier.ESupplierStatus Status { get; private set; }

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06002DAB RID: 11691 RVA: 0x000BEDF2 File Offset: 0x000BCFF2
		// (set) Token: 0x06002DAC RID: 11692 RVA: 0x000BEDFA File Offset: 0x000BCFFA
		public bool DeliveriesEnabled { get; private set; }

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06002DAD RID: 11693 RVA: 0x000BEE03 File Offset: 0x000BD003
		public float Debt
		{
			get
			{
				return this.SyncAccessor_debt;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06002DAE RID: 11694 RVA: 0x000BEE0B File Offset: 0x000BD00B
		// (set) Token: 0x06002DAF RID: 11695 RVA: 0x000BEE13 File Offset: 0x000BD013
		public int minsUntilDeaddropReady { get; private set; } = -1;

		// Token: 0x06002DB0 RID: 11696 RVA: 0x000BEE1C File Offset: 0x000BD01C
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Economy.Supplier_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x000BEE30 File Offset: 0x000BD030
		protected override void Start()
		{
			base.Start();
			NPCRelationData relationData = this.RelationData;
			relationData.onUnlocked = (Action<NPCRelationData.EUnlockType, bool>)Delegate.Combine(relationData.onUnlocked, new Action<NPCRelationData.EUnlockType, bool>(this.SupplierUnlocked));
			NPCRelationData relationData2 = this.RelationData;
			relationData2.onRelationshipChange = (Action<float>)Delegate.Combine(relationData2.onRelationshipChange, new Action<float>(this.RelationshipChange));
			string orderCompleteDialogue = this.dialogueHandler.Database.GetLine(EDialogueModule.Generic, "meeting_order_complete");
			this.Shop.onOrderCompleted.AddListener(new UnityAction(delegate()
			{
				this.dialogueHandler.ShowWorldspaceDialogue(orderCompleteDialogue, 3f);
			}));
			this.dialogueController = this.dialogueHandler.GetComponent<DialogueController>();
			this.meetingGreeting = new DialogueController.GreetingOverride();
			this.meetingGreeting.Greeting = this.dialogueHandler.Database.GetLine(EDialogueModule.Generic, "supplier_meeting_greeting");
			this.meetingGreeting.PlayVO = true;
			this.meetingGreeting.VOType = EVOLineType.Question;
			this.dialogueController.AddGreetingOverride(this.meetingGreeting);
			this.meetingChoice = new DialogueController.DialogueChoice();
			this.meetingChoice.ChoiceText = "Yes";
			this.meetingChoice.onChoosen.AddListener(new UnityAction(delegate()
			{
				this.Shop.SetIsOpen(true);
			}));
			this.meetingChoice.Enabled = false;
			this.dialogueController.AddDialogueChoice(this.meetingChoice, 0);
			TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance.onTimeSkip = (Action<int>)Delegate.Combine(instance.onTimeSkip, new Action<int>(this.OnTimeSkip));
			foreach (PhoneShopInterface.Listing listing in this.OnlineShopItems)
			{
				if ((listing.Item as StorableItemDefinition).RequiresLevelToPurchase)
				{
					NetworkSingleton<LevelManager>.Instance.AddUnlockable(new Unlockable((listing.Item as StorableItemDefinition).RequiredRank, listing.Item.Name, listing.Item.Icon));
				}
			}
			TimeManager instance2 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance2.onHourPass = (Action)Delegate.Remove(instance2.onHourPass, new Action(this.HourPass));
			TimeManager instance3 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance3.onHourPass = (Action)Delegate.Combine(instance3.onHourPass, new Action(this.HourPass));
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x000BF068 File Offset: 0x000BD268
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (connection.IsLocalClient)
			{
				return;
			}
			if (this.Status == Supplier.ESupplierStatus.Meeting)
			{
				this.MeetAtLocation(connection, SupplierLocation.AllLocations.IndexOf(this.currentLocation), 360);
			}
			if (this.DeliveriesEnabled)
			{
				this.EnableDeliveries(connection);
			}
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x000BF0B9 File Offset: 0x000BD2B9
		[ServerRpc(RequireOwnership = false)]
		public void SendUnlocked()
		{
			this.RpcWriter___Server_SendUnlocked_2166136261();
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x000BF0C1 File Offset: 0x000BD2C1
		[ObserversRpc]
		private void SetUnlocked()
		{
			this.RpcWriter___Observers_SetUnlocked_2166136261();
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x000BF0CC File Offset: 0x000BD2CC
		protected override void MinPass()
		{
			base.MinPass();
			this.minsSinceDeaddropOrder++;
			if (this.Status == Supplier.ESupplierStatus.Meeting)
			{
				this.minsSinceMeetingStart++;
				this.minsSinceLastMeetingEnd = 0;
				if (this.minsSinceMeetingStart > 360)
				{
					this.EndMeeting();
				}
			}
			else
			{
				this.minsSinceLastMeetingEnd++;
			}
			if (InstanceFinder.IsServer)
			{
				if (this.SyncAccessor_deadDropPreparing)
				{
					this.minsUntilDeaddropReady--;
					if (this.minsUntilDeaddropReady <= 0)
					{
						this.CompleteDeaddrop();
					}
				}
				if (this.SyncAccessor_debt > 0f && !this.Stash.Storage.IsOpened && this.Stash.CashAmount > 1f && this.minsSinceDeaddropOrder > 3)
				{
					this.TryRecoverDebt();
				}
			}
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x000BF19C File Offset: 0x000BD39C
		protected void HourPass()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.repaymentReminderSent && this.SyncAccessor_debt > this.GetDeadDropLimit() * 0.5f && !this.SyncAccessor_deadDropPreparing)
			{
				float num = 0.020833334f;
				if (Random.Range(0f, 1f) < num)
				{
					this.SendDebtReminder();
				}
			}
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x000BF1F3 File Offset: 0x000BD3F3
		private void OnTimeSkip(int minsSlept)
		{
			if (this.Status == Supplier.ESupplierStatus.Meeting)
			{
				this.minsSinceMeetingStart += minsSlept;
			}
			if (this.SyncAccessor_deadDropPreparing)
			{
				this.minsUntilDeaddropReady -= minsSlept;
			}
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x000BF224 File Offset: 0x000BD424
		[ObserversRpc(RunLocally = true)]
		public void MeetAtLocation(NetworkConnection conn, int locationIndex, int expireIn)
		{
			this.RpcWriter___Observers_MeetAtLocation_3470796954(conn, locationIndex, expireIn);
			this.RpcLogic___MeetAtLocation_3470796954(conn, locationIndex, expireIn);
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x000BF258 File Offset: 0x000BD458
		public void EndMeeting()
		{
			Console.Log("Meeting ended", null);
			this.Status = Supplier.ESupplierStatus.Idle;
			this.minsSinceMeetingStart = -1;
			this.meetingGreeting.ShouldShow = false;
			this.meetingChoice.Enabled = false;
			this.currentLocation.SetActiveSupplier(null);
			this.SetVisible(false);
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x000BF2A9 File Offset: 0x000BD4A9
		protected virtual void SupplierUnlocked(NPCRelationData.EUnlockType type, bool notify)
		{
			if (notify)
			{
				this.SetUnlockMessage();
			}
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x000BF2B4 File Offset: 0x000BD4B4
		protected virtual void RelationshipChange(float change)
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (Singleton<LoadManager>.Instance.IsLoading)
			{
				if (this.RelationData.RelationDelta >= 5f && !this.DeliveriesEnabled)
				{
					this.EnableDeliveries(null);
				}
				return;
			}
			float num = this.RelationData.RelationDelta - change;
			float relationDelta = this.RelationData.RelationDelta;
			if (num < 4f && relationDelta >= 4f)
			{
				Console.Log("Supplier relationship high enough for meetings", null);
				DialogueChain chain = this.dialogueHandler.Database.GetChain(EDialogueModule.Generic, "supplier_meetings_unlocked");
				if (chain == null)
				{
					return;
				}
				base.MSGConversation.SendMessageChain(chain.GetMessageChain(), 3f, true, true);
			}
			if (relationDelta >= 5f && !this.DeliveriesEnabled)
			{
				Console.Log("Supplier relationship high enough for deliveries", null);
				this.EnableDeliveries(null);
				DialogueChain chain2 = this.dialogueHandler.Database.GetChain(EDialogueModule.Generic, "supplier_deliveries_unlocked");
				if (chain2 != null)
				{
					base.MSGConversation.SendMessageChain(chain2.GetMessageChain(), 3f, true, true);
				}
			}
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x000BF3B1 File Offset: 0x000BD5B1
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void EnableDeliveries(NetworkConnection conn)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_EnableDeliveries_328543758(conn);
				this.RpcLogic___EnableDeliveries_328543758(conn);
			}
			else
			{
				this.RpcWriter___Target_EnableDeliveries_328543758(conn);
			}
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x000BF3DC File Offset: 0x000BD5DC
		public void SetUnlockMessage()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			DialogueChain chain = this.dialogueHandler.Database.GetChain(EDialogueModule.Generic, "supplier_unlocked");
			if (chain == null)
			{
				return;
			}
			base.MSGConversation.SendMessageChain(chain.GetMessageChain(), 0f, true, true);
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x000BF424 File Offset: 0x000BD624
		protected override void CreateMessageConversation()
		{
			base.CreateMessageConversation();
			SendableMessage sendableMessage = base.MSGConversation.CreateSendableMessage("I need to order a dead drop");
			sendableMessage.IsValidCheck = new SendableMessage.ValidityCheck(this.IsDeadDropValid);
			sendableMessage.disableDefaultSendBehaviour = true;
			sendableMessage.onSelected = (Action)Delegate.Combine(sendableMessage.onSelected, new Action(this.DeaddropRequested));
			SendableMessage sendableMessage2 = base.MSGConversation.CreateSendableMessage("We need to meet up");
			sendableMessage2.IsValidCheck = new SendableMessage.ValidityCheck(this.IsMeetupValid);
			sendableMessage2.onSent = (Action)Delegate.Combine(sendableMessage2.onSent, new Action(this.MeetupRequested));
			SendableMessage sendableMessage3 = base.MSGConversation.CreateSendableMessage("I want to pay off my debt");
			sendableMessage3.onSent = (Action)Delegate.Combine(sendableMessage3.onSent, new Action(this.PayDebtRequested));
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x000BF4F8 File Offset: 0x000BD6F8
		protected virtual void DeaddropRequested()
		{
			float orderLimit = Mathf.Max(this.GetDeadDropLimit() - this.SyncAccessor_debt, 0f);
			PlayerSingleton<MessagesApp>.Instance.PhoneShopInterface.Open("Request Dead Drop", "Select items to order from " + this.FirstName, base.MSGConversation, this.OnlineShopItems.ToList<PhoneShopInterface.Listing>(), orderLimit, this.SyncAccessor_debt, new Action<List<PhoneShopInterface.CartEntry>, float>(this.DeaddropConfirmed));
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x000BF568 File Offset: 0x000BD768
		protected virtual void DeaddropConfirmed(List<PhoneShopInterface.CartEntry> cart, float totalPrice)
		{
			if (this.SyncAccessor_deadDropPreparing)
			{
				Console.LogWarning("Already preparing a dead drop", null);
				return;
			}
			int num = cart.Sum((PhoneShopInterface.CartEntry x) => x.Quantity);
			StringIntPair[] array = new StringIntPair[cart.Count];
			for (int i = 0; i < cart.Count; i++)
			{
				array[i] = new StringIntPair(cart[i].Listing.Item.ID, cart[i].Quantity);
			}
			string text = "I need a dead drop:\n";
			for (int j = 0; j < cart.Count; j++)
			{
				if (cart[j].Quantity > 0)
				{
					text = text + cart[j].Quantity.ToString() + "x " + cart[j].Listing.Item.Name;
					if (j < cart.Count - 1)
					{
						text += "\n";
					}
				}
			}
			base.MSGConversation.SendMessage(new Message(text, Message.ESenderType.Player, false, -1), true, true);
			int num2 = Mathf.Clamp(num * 30, 30, 360);
			string text2 = this.dialogueHandler.Database.GetLine(EDialogueModule.Supplier, "deaddrop_requested");
			if (num2 < 60)
			{
				text2 = text2.Replace("<TIME>", num2.ToString() + ((num2 == 1) ? " min" : " mins"));
			}
			else
			{
				float num3 = (float)Mathf.FloorToInt((float)num2 / 60f);
				float num4 = (float)num2 - num3 * 60f;
				string text3 = num3.ToString() + ((num3 == 1f) ? " hour" : " hours");
				if (num4 > 0f)
				{
					text3 = text3 + " " + num4.ToString() + " min";
				}
				text2 = text2.Replace("<TIME>", text3);
			}
			base.MSGConversation.SendMessageChain(new MessageChain
			{
				Messages = new List<string>
				{
					text2
				},
				id = Random.Range(int.MinValue, int.MaxValue)
			}, 0.5f, false, true);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Deaddrops_Ordered", (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Deaddrops_Ordered") + 1f).ToString(), true);
			this.SetDeaddrop(array, num2);
			this.minsSinceDeaddropOrder = 0;
			this.ChangeDebt(totalPrice);
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x000BF7DB File Offset: 0x000BD9DB
		[ServerRpc(RequireOwnership = false)]
		private void SetDeaddrop(StringIntPair[] items, int minsUntilReady)
		{
			this.RpcWriter___Server_SetDeaddrop_3971994486(items, minsUntilReady);
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x000BF7EB File Offset: 0x000BD9EB
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void ChangeDebt(float amount)
		{
			this.RpcWriter___Server_ChangeDebt_431000436(amount);
			this.RpcLogic___ChangeDebt_431000436(amount);
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x000BF804 File Offset: 0x000BDA04
		private void TryRecoverDebt()
		{
			float num = Mathf.Min(this.SyncAccessor_debt, this.Stash.CashAmount);
			if (num > 0f)
			{
				Debug.Log("Recovering debt: " + num.ToString());
				float num2 = this.SyncAccessor_debt;
				this.Stash.RemoveCash(num);
				this.ChangeDebt(-num);
				this.RelationData.ChangeRelationship(num / this.MaxOrderLimit * 0.5f, true);
				float num3 = num2 - num;
				string text = "I've received " + MoneyManager.FormatAmount(num, false, false) + " cash from you.";
				if (num3 <= 0f)
				{
					text += " Your debt is now paid off.";
				}
				else
				{
					text = text + " Your debt is now " + MoneyManager.FormatAmount(num3, false, false);
				}
				this.repaymentReminderSent = false;
				base.MSGConversation.SendMessageChain(new MessageChain
				{
					Messages = new List<string>
					{
						text
					},
					id = Random.Range(int.MinValue, int.MaxValue)
				}, 0f, true, true);
			}
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x000BF908 File Offset: 0x000BDB08
		private void CompleteDeaddrop()
		{
			Console.Log("Dead drop ready", null);
			DeadDrop randomEmptyDrop = DeadDrop.GetRandomEmptyDrop(Player.Local.transform.position);
			if (randomEmptyDrop == null)
			{
				Console.LogError("No empty dead drop locations", null);
				return;
			}
			foreach (StringIntPair stringIntPair in this.deaddropItems)
			{
				ItemDefinition item = Registry.GetItem(stringIntPair.String);
				if (item == null)
				{
					Console.LogError("Item not found: " + stringIntPair.String, null);
				}
				else
				{
					int num;
					for (int j = stringIntPair.Int; j > 0; j -= num)
					{
						num = Mathf.Min(j, item.StackLimit);
						ItemInstance defaultInstance = item.GetDefaultInstance(num);
						randomEmptyDrop.Storage.InsertItem(defaultInstance, true);
					}
				}
			}
			string text = this.dialogueHandler.Database.GetLine(EDialogueModule.Supplier, "deaddrop_ready");
			text = text.Replace("<LOCATION>", randomEmptyDrop.DeadDropDescription);
			base.MSGConversation.SendMessageChain(new MessageChain
			{
				Messages = new List<string>
				{
					text
				},
				id = Random.Range(int.MinValue, int.MaxValue)
			}, 0f, true, true);
			this.sync___set_value_deadDropPreparing(false, true);
			this.minsUntilDeaddropReady = -1;
			this.deaddropItems = null;
			if (this.onDeaddropReady != null)
			{
				this.onDeaddropReady.Invoke();
			}
			string guidString = GUIDManager.GenerateUniqueGUID().ToString();
			NetworkSingleton<QuestManager>.Instance.CreateDeaddropCollectionQuest(null, randomEmptyDrop.GUID.ToString(), guidString);
			this.SetDeaddrop(null, -1);
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x000BFAAC File Offset: 0x000BDCAC
		private void SendDebtReminder()
		{
			this.repaymentReminderSent = true;
			DialogueChain chain = this.dialogueHandler.Database.GetChain(EDialogueModule.Supplier, "supplier_request_repayment");
			chain.Lines[0] = chain.Lines[0].Replace("<DEBT>", "<color=#46CB4F>" + MoneyManager.FormatAmount(this.SyncAccessor_debt, false, false) + "</color>");
			base.MSGConversation.SendMessageChain(chain.GetMessageChain(), 0f, true, true);
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x000BFB28 File Offset: 0x000BDD28
		protected virtual void MeetupRequested()
		{
			if (InstanceFinder.IsServer)
			{
				int locationIndex;
				SupplierLocation appropriateLocation = this.GetAppropriateLocation(out locationIndex);
				string text = this.dialogueHandler.Database.GetLine(EDialogueModule.Generic, "supplier_meet_confirm");
				text = text.Replace("<LOCATION>", appropriateLocation.LocationDescription);
				MessageChain messageChain = new MessageChain();
				messageChain.Messages.Add(text);
				messageChain.id = Random.Range(int.MinValue, int.MaxValue);
				base.MSGConversation.SendMessageChain(messageChain, 0.5f, true, true);
				this.MeetAtLocation(null, locationIndex, 360);
			}
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x000BFBB8 File Offset: 0x000BDDB8
		protected virtual void PayDebtRequested()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			MessageChain messageChain = new MessageChain();
			messageChain.Messages.Add("You can pay off your debt by placing cash in my stash. It's " + this.Stash.locationDescription + ".");
			messageChain.id = Random.Range(int.MinValue, int.MaxValue);
			base.MSGConversation.SendMessageChain(messageChain, 0.5f, true, true);
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x000BFC20 File Offset: 0x000BDE20
		protected SupplierLocation GetAppropriateLocation(out int locationIndex)
		{
			locationIndex = -1;
			List<SupplierLocation> list = new List<SupplierLocation>();
			list.AddRange(SupplierLocation.AllLocations);
			foreach (SupplierLocation supplierLocation in SupplierLocation.AllLocations)
			{
				if (supplierLocation.IsOccupied)
				{
					list.Remove(supplierLocation);
				}
			}
			foreach (SupplierLocation supplierLocation2 in SupplierLocation.AllLocations)
			{
				foreach (Player player in Player.PlayerList)
				{
					if (Vector3.Distance(supplierLocation2.transform.position, player.Avatar.CenterPoint) < 30f)
					{
						list.Remove(supplierLocation2);
					}
				}
			}
			if (list.Count == 0)
			{
				Console.LogError("No available locations for supplier", null);
				return null;
			}
			SupplierLocation supplierLocation3 = list[Random.Range(0, list.Count)];
			locationIndex = SupplierLocation.AllLocations.IndexOf(supplierLocation3);
			return supplierLocation3;
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x000BFD6C File Offset: 0x000BDF6C
		private bool IsDeadDropValid(SendableMessage message, out string invalidReason)
		{
			invalidReason = string.Empty;
			if (this.SyncAccessor_deadDropPreparing)
			{
				invalidReason = "Already waiting for a dead drop";
				return false;
			}
			return true;
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x000BFD87 File Offset: 0x000BDF87
		private bool IsMeetupValid(SendableMessage message, out string invalidReason)
		{
			if (this.RelationData.RelationDelta < 4f)
			{
				invalidReason = "Insufficient trust";
				return false;
			}
			if (this.Status != Supplier.ESupplierStatus.Idle)
			{
				invalidReason = "Busy";
				return false;
			}
			invalidReason = "";
			return true;
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x000BFDBD File Offset: 0x000BDFBD
		public virtual float GetDeadDropLimit()
		{
			return Mathf.Lerp(this.MinOrderLimit, this.MaxOrderLimit, this.RelationData.RelationDelta / 5f);
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x000BFDE1 File Offset: 0x000BDFE1
		public override string GetSaveString()
		{
			return new SupplierData(this.ID, this.minsSinceMeetingStart, this.minsSinceLastMeetingEnd, this.SyncAccessor_debt, this.minsUntilDeaddropReady, this.deaddropItems, this.repaymentReminderSent).GetJson(true);
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x000BFE18 File Offset: 0x000BE018
		public override void Load(NPCData data, string containerPath)
		{
			base.Load(data, containerPath);
			string text;
			if (((ISaveable)this).TryLoadFile(containerPath, "NPC", out text))
			{
				SupplierData supplierData = null;
				try
				{
					supplierData = JsonUtility.FromJson<SupplierData>(text);
				}
				catch (Exception ex)
				{
					Console.LogWarning("Failed to deserialize character data: " + ex.Message, null);
					return;
				}
				this.minsSinceMeetingStart = supplierData.timeSinceMeetingStart;
				this.minsSinceLastMeetingEnd = supplierData.timeSinceLastMeetingEnd;
				this.sync___set_value_debt(supplierData.debt, true);
				this.minsUntilDeaddropReady = supplierData.minsUntilDeadDropReady;
				if (this.minsUntilDeaddropReady > 0)
				{
					this.sync___set_value_deadDropPreparing(true, true);
				}
				if (supplierData.deaddropItems != null)
				{
					this.deaddropItems = supplierData.deaddropItems.ToArray<StringIntPair>();
				}
				this.repaymentReminderSent = supplierData.debtReminderSent;
			}
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x000BFF54 File Offset: 0x000BE154
		[CompilerGenerated]
		private IEnumerator <EnableDeliveries>g__Wait|54_0()
		{
			yield return new WaitUntil(() => PlayerSingleton<DeliveryApp>.InstanceExists);
			PlayerSingleton<DeliveryApp>.Instance.GetShop(this.Shop).SetIsAvailable();
			yield break;
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x000BFF64 File Offset: 0x000BE164
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Economy.SupplierAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Economy.SupplierAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___deadDropPreparing = new SyncVar<bool>(this, 2U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.deadDropPreparing);
			this.syncVar___debt = new SyncVar<float>(this, 1U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.debt);
			base.RegisterServerRpc(35U, new ServerRpcDelegate(this.RpcReader___Server_SendUnlocked_2166136261));
			base.RegisterObserversRpc(36U, new ClientRpcDelegate(this.RpcReader___Observers_SetUnlocked_2166136261));
			base.RegisterObserversRpc(37U, new ClientRpcDelegate(this.RpcReader___Observers_MeetAtLocation_3470796954));
			base.RegisterObserversRpc(38U, new ClientRpcDelegate(this.RpcReader___Observers_EnableDeliveries_328543758));
			base.RegisterTargetRpc(39U, new ClientRpcDelegate(this.RpcReader___Target_EnableDeliveries_328543758));
			base.RegisterServerRpc(40U, new ServerRpcDelegate(this.RpcReader___Server_SetDeaddrop_3971994486));
			base.RegisterServerRpc(41U, new ServerRpcDelegate(this.RpcReader___Server_ChangeDebt_431000436));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.Economy.Supplier));
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x000C0091 File Offset: 0x000BE291
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Economy.SupplierAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Economy.SupplierAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___deadDropPreparing.SetRegistered();
			this.syncVar___debt.SetRegistered();
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x000C00C0 File Offset: 0x000BE2C0
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x000C00D0 File Offset: 0x000BE2D0
		private void RpcWriter___Server_SendUnlocked_2166136261()
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

		// Token: 0x06002DD5 RID: 11733 RVA: 0x000C016A File Offset: 0x000BE36A
		public void RpcLogic___SendUnlocked_2166136261()
		{
			this.SetUnlocked();
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x000C0174 File Offset: 0x000BE374
		private void RpcReader___Server_SendUnlocked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendUnlocked_2166136261();
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x000C0194 File Offset: 0x000BE394
		private void RpcWriter___Observers_SetUnlocked_2166136261()
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

		// Token: 0x06002DD8 RID: 11736 RVA: 0x000C023D File Offset: 0x000BE43D
		private void RpcLogic___SetUnlocked_2166136261()
		{
			this.RelationData.Unlock(NPCRelationData.EUnlockType.Recommendation, true);
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x000C024C File Offset: 0x000BE44C
		private void RpcReader___Observers_SetUnlocked_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetUnlocked_2166136261();
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x000C026C File Offset: 0x000BE46C
		private void RpcWriter___Observers_MeetAtLocation_3470796954(NetworkConnection conn, int locationIndex, int expireIn)
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
			writer.WriteNetworkConnection(conn);
			writer.WriteInt32(locationIndex, AutoPackType.Packed);
			writer.WriteInt32(expireIn, AutoPackType.Packed);
			base.SendObserversRpc(37U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x000C0348 File Offset: 0x000BE548
		public void RpcLogic___MeetAtLocation_3470796954(NetworkConnection conn, int locationIndex, int expireIn)
		{
			SupplierLocation supplierLocation = SupplierLocation.AllLocations[locationIndex];
			if (supplierLocation == null)
			{
				Console.LogError("Location not found: " + locationIndex.ToString(), null);
				return;
			}
			if (supplierLocation.SupplierStandPoint == null)
			{
				Console.LogError("Supplier stand point not set up for location: " + supplierLocation.name, null);
				return;
			}
			if (this.meetingGreeting == null || this.meetingChoice == null)
			{
				Console.LogError("Meeting greeting or choice not set up", null);
				return;
			}
			Console.Log(string.Concat(new string[]
			{
				base.fullName,
				" meeting at ",
				supplierLocation.name,
				" for ",
				expireIn.ToString(),
				" minutes"
			}), null);
			this.Status = Supplier.ESupplierStatus.Meeting;
			this.currentLocation = supplierLocation;
			this.minsSinceMeetingStart = 0;
			supplierLocation.SetActiveSupplier(this);
			ShopInterface shop = this.Shop;
			StorageEntity[] deliveryBays = supplierLocation.DeliveryBays;
			shop.DeliveryBays = deliveryBays;
			this.meetingGreeting.ShouldShow = true;
			this.meetingChoice.Enabled = true;
			this.movement.Warp(supplierLocation.SupplierStandPoint.position);
			this.movement.FaceDirection(supplierLocation.SupplierStandPoint.forward, 0.5f);
			this.SetVisible(true);
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x000C0488 File Offset: 0x000BE688
		private void RpcReader___Observers_MeetAtLocation_3470796954(PooledReader PooledReader0, Channel channel)
		{
			NetworkConnection conn = PooledReader0.ReadNetworkConnection();
			int locationIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			int expireIn = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___MeetAtLocation_3470796954(conn, locationIndex, expireIn);
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x000C04F0 File Offset: 0x000BE6F0
		private void RpcWriter___Observers_EnableDeliveries_328543758(NetworkConnection conn)
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

		// Token: 0x06002DDE RID: 11742 RVA: 0x000C0599 File Offset: 0x000BE799
		private void RpcLogic___EnableDeliveries_328543758(NetworkConnection conn)
		{
			this.DeliveriesEnabled = true;
			Singleton<CoroutineService>.Instance.StartCoroutine(this.<EnableDeliveries>g__Wait|54_0());
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x000C05B4 File Offset: 0x000BE7B4
		private void RpcReader___Observers_EnableDeliveries_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___EnableDeliveries_328543758(null);
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x000C05E0 File Offset: 0x000BE7E0
		private void RpcWriter___Target_EnableDeliveries_328543758(NetworkConnection conn)
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

		// Token: 0x06002DE1 RID: 11745 RVA: 0x000C0688 File Offset: 0x000BE888
		private void RpcReader___Target_EnableDeliveries_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___EnableDeliveries_328543758(base.LocalConnection);
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x000C06B0 File Offset: 0x000BE8B0
		private void RpcWriter___Server_SetDeaddrop_3971994486(StringIntPair[] items, int minsUntilReady)
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
			writer.Write___ScheduleOne.DevUtilities.StringIntPair[]FishNet.Serializing.Generated(items);
			writer.WriteInt32(minsUntilReady, AutoPackType.Packed);
			base.SendServerRpc(40U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x000C0769 File Offset: 0x000BE969
		private void RpcLogic___SetDeaddrop_3971994486(StringIntPair[] items, int minsUntilReady)
		{
			if (items != null)
			{
				this.minsSinceDeaddropOrder = 0;
				this.sync___set_value_deadDropPreparing(true, true);
			}
			else
			{
				this.sync___set_value_deadDropPreparing(false, true);
			}
			this.minsUntilDeaddropReady = minsUntilReady;
			this.deaddropItems = items;
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x000C0798 File Offset: 0x000BE998
		private void RpcReader___Server_SetDeaddrop_3971994486(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			StringIntPair[] items = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.DevUtilities.StringIntPair[]FishNet.Serializing.Generateds(PooledReader0);
			int minsUntilReady = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SetDeaddrop_3971994486(items, minsUntilReady);
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x000C07E0 File Offset: 0x000BE9E0
		private void RpcWriter___Server_ChangeDebt_431000436(float amount)
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
			writer.WriteSingle(amount, AutoPackType.Unpacked);
			base.SendServerRpc(41U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x000C088C File Offset: 0x000BEA8C
		private void RpcLogic___ChangeDebt_431000436(float amount)
		{
			this.sync___set_value_debt(Mathf.Clamp(this.SyncAccessor_debt + amount, 0f, this.GetDeadDropLimit()), true);
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x000C08B0 File Offset: 0x000BEAB0
		private void RpcReader___Server_ChangeDebt_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			float amount = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___ChangeDebt_431000436(amount);
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06002DE8 RID: 11752 RVA: 0x000C08F3 File Offset: 0x000BEAF3
		// (set) Token: 0x06002DE9 RID: 11753 RVA: 0x000C08FB File Offset: 0x000BEAFB
		public float SyncAccessor_debt
		{
			get
			{
				return this.debt;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.debt = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___debt.SetValue(value, value);
				}
			}
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x000C0938 File Offset: 0x000BEB38
		public virtual bool Supplier(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 == 2U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_deadDropPreparing(this.syncVar___deadDropPreparing.GetValue(true), true);
					return true;
				}
				bool value = PooledReader0.ReadBoolean();
				this.sync___set_value_deadDropPreparing(value, Boolean2);
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
					this.sync___set_value_debt(this.syncVar___debt.GetValue(true), true);
					return true;
				}
				float value2 = PooledReader0.ReadSingle(AutoPackType.Unpacked);
				this.sync___set_value_debt(value2, Boolean2);
				return true;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06002DEB RID: 11755 RVA: 0x000C09D3 File Offset: 0x000BEBD3
		// (set) Token: 0x06002DEC RID: 11756 RVA: 0x000C09DB File Offset: 0x000BEBDB
		public bool SyncAccessor_deadDropPreparing
		{
			get
			{
				return this.deadDropPreparing;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.deadDropPreparing = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___deadDropPreparing.SetValue(value, value);
				}
			}
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x000C0A17 File Offset: 0x000BEC17
		protected virtual void dll()
		{
			base.Awake();
		}

		// Token: 0x0400206F RID: 8303
		public const float MEETUP_RELATIONSHIP_REQUIREMENT = 4f;

		// Token: 0x04002070 RID: 8304
		public const int MEETUP_DURATION_MINS = 360;

		// Token: 0x04002071 RID: 8305
		public const int MEETING_COOLDOWN_MINS = 720;

		// Token: 0x04002072 RID: 8306
		public const int DEADDROP_WAIT_PER_ITEM = 30;

		// Token: 0x04002073 RID: 8307
		public const int DEADDROP_MAX_WAIT = 360;

		// Token: 0x04002074 RID: 8308
		public const int DEADDROP_ITEM_LIMIT = 10;

		// Token: 0x04002075 RID: 8309
		public const float DELIVERY_RELATIONSHIP_REQUIREMENT = 5f;

		// Token: 0x04002076 RID: 8310
		public static Color32 SupplierLabelColor = new Color32(byte.MaxValue, 150, 145, byte.MaxValue);

		// Token: 0x04002079 RID: 8313
		[Header("Supplier Settings")]
		public float MinOrderLimit = 100f;

		// Token: 0x0400207A RID: 8314
		public float MaxOrderLimit = 500f;

		// Token: 0x0400207B RID: 8315
		public PhoneShopInterface.Listing[] OnlineShopItems;

		// Token: 0x0400207C RID: 8316
		[TextArea(3, 10)]
		public string SupplierRecommendMessage = "My friend <NAME> can hook you up with <PRODUCT>. I've passed your number on to them.";

		// Token: 0x0400207D RID: 8317
		[TextArea(3, 10)]
		public string SupplierUnlockHint = "You can now order <PRODUCT> from <NAME>. <PRODUCT> can be used to <PURPOSE>.";

		// Token: 0x0400207E RID: 8318
		[Header("References")]
		public ShopInterface Shop;

		// Token: 0x0400207F RID: 8319
		public SupplierStash Stash;

		// Token: 0x04002080 RID: 8320
		public UnityEvent onDeaddropReady;

		// Token: 0x04002081 RID: 8321
		private int minsSinceMeetingStart = -1;

		// Token: 0x04002082 RID: 8322
		private int minsSinceLastMeetingEnd = 720;

		// Token: 0x04002083 RID: 8323
		private SupplierLocation currentLocation;

		// Token: 0x04002084 RID: 8324
		private DialogueController dialogueController;

		// Token: 0x04002085 RID: 8325
		private DialogueController.GreetingOverride meetingGreeting;

		// Token: 0x04002086 RID: 8326
		private DialogueController.DialogueChoice meetingChoice;

		// Token: 0x04002087 RID: 8327
		[SyncVar]
		public float debt;

		// Token: 0x04002088 RID: 8328
		[SyncVar]
		public bool deadDropPreparing;

		// Token: 0x0400208A RID: 8330
		private StringIntPair[] deaddropItems;

		// Token: 0x0400208B RID: 8331
		private int minsSinceDeaddropOrder;

		// Token: 0x0400208C RID: 8332
		private bool repaymentReminderSent;

		// Token: 0x0400208D RID: 8333
		public SyncVar<float> syncVar___debt;

		// Token: 0x0400208E RID: 8334
		public SyncVar<bool> syncVar___deadDropPreparing;

		// Token: 0x0400208F RID: 8335
		private bool dll_Excuted;

		// Token: 0x04002090 RID: 8336
		private bool dll_Excuted;

		// Token: 0x0200067C RID: 1660
		public enum ESupplierStatus
		{
			// Token: 0x04002092 RID: 8338
			Idle,
			// Token: 0x04002093 RID: 8339
			PreppingDeadDrop,
			// Token: 0x04002094 RID: 8340
			Meeting
		}
	}
}
