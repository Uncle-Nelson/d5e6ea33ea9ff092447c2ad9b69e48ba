using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EasyButtons;
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
using ScheduleOne.Law;
using ScheduleOne.Levelling;
using ScheduleOne.Map;
using ScheduleOne.Messaging;
using ScheduleOne.Money;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.NPCs.Responses;
using ScheduleOne.NPCs.Schedules;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product;
using ScheduleOne.Properties;
using ScheduleOne.Quests;
using ScheduleOne.UI;
using ScheduleOne.UI.Handover;
using ScheduleOne.UI.Phone.Messages;
using ScheduleOne.Variables;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Economy
{
	// Token: 0x02000652 RID: 1618
	[DisallowMultipleComponent]
	[RequireComponent(typeof(NPC))]
	public class Customer : NetworkBehaviour, ISaveable
	{
		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06002BC5 RID: 11205 RVA: 0x000B3F0E File Offset: 0x000B210E
		// (set) Token: 0x06002BC6 RID: 11206 RVA: 0x000B3F16 File Offset: 0x000B2116
		public float CurrentAddiction
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<CurrentAddiction>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.sync___set_value_<CurrentAddiction>k__BackingField(value, true);
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06002BC7 RID: 11207 RVA: 0x000B3F20 File Offset: 0x000B2120
		// (set) Token: 0x06002BC8 RID: 11208 RVA: 0x000B3F28 File Offset: 0x000B2128
		public ContractInfo OfferedContractInfo
		{
			get
			{
				return this.offeredContractInfo;
			}
			protected set
			{
				this.offeredContractInfo = value;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06002BC9 RID: 11209 RVA: 0x000B3F31 File Offset: 0x000B2131
		// (set) Token: 0x06002BCA RID: 11210 RVA: 0x000B3F39 File Offset: 0x000B2139
		public GameDateTime OfferedContractTime { get; protected set; }

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06002BCB RID: 11211 RVA: 0x000B3F42 File Offset: 0x000B2142
		// (set) Token: 0x06002BCC RID: 11212 RVA: 0x000B3F4A File Offset: 0x000B214A
		public Contract CurrentContract { get; protected set; }

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06002BCD RID: 11213 RVA: 0x000B3F53 File Offset: 0x000B2153
		// (set) Token: 0x06002BCE RID: 11214 RVA: 0x000B3F5B File Offset: 0x000B215B
		public bool IsAwaitingDelivery { get; protected set; }

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06002BCF RID: 11215 RVA: 0x000B3F64 File Offset: 0x000B2164
		// (set) Token: 0x06002BD0 RID: 11216 RVA: 0x000B3F6C File Offset: 0x000B216C
		public int TimeSinceLastDealCompleted { get; protected set; } = 1000000;

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06002BD1 RID: 11217 RVA: 0x000B3F75 File Offset: 0x000B2175
		// (set) Token: 0x06002BD2 RID: 11218 RVA: 0x000B3F7D File Offset: 0x000B217D
		public int TimeSinceLastDealOffered { get; protected set; } = 1000000;

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06002BD3 RID: 11219 RVA: 0x000B3F86 File Offset: 0x000B2186
		// (set) Token: 0x06002BD4 RID: 11220 RVA: 0x000B3F8E File Offset: 0x000B218E
		public int TimeSincePlayerApproached { get; protected set; } = 1000000;

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06002BD5 RID: 11221 RVA: 0x000B3F97 File Offset: 0x000B2197
		// (set) Token: 0x06002BD6 RID: 11222 RVA: 0x000B3F9F File Offset: 0x000B219F
		public int TimeSinceInstantDealOffered { get; protected set; } = 1000000;

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06002BD7 RID: 11223 RVA: 0x000B3FA8 File Offset: 0x000B21A8
		// (set) Token: 0x06002BD8 RID: 11224 RVA: 0x000B3FB0 File Offset: 0x000B21B0
		public int OfferedDeals { get; protected set; }

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06002BD9 RID: 11225 RVA: 0x000B3FB9 File Offset: 0x000B21B9
		// (set) Token: 0x06002BDA RID: 11226 RVA: 0x000B3FC1 File Offset: 0x000B21C1
		public int CompletedDeliveries { get; protected set; }

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06002BDB RID: 11227 RVA: 0x000B3FCA File Offset: 0x000B21CA
		// (set) Token: 0x06002BDC RID: 11228 RVA: 0x000B3FD2 File Offset: 0x000B21D2
		public bool HasBeenRecommended
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<HasBeenRecommended>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.sync___set_value_<HasBeenRecommended>k__BackingField(value, true);
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06002BDD RID: 11229 RVA: 0x000B3FDC File Offset: 0x000B21DC
		// (set) Token: 0x06002BDE RID: 11230 RVA: 0x000B3FE4 File Offset: 0x000B21E4
		public NPC NPC { get; protected set; }

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06002BDF RID: 11231 RVA: 0x000B3FED File Offset: 0x000B21ED
		// (set) Token: 0x06002BE0 RID: 11232 RVA: 0x000B3FF5 File Offset: 0x000B21F5
		public Dealer AssignedDealer { get; protected set; }

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06002BE1 RID: 11233 RVA: 0x000B3FFE File Offset: 0x000B21FE
		public CustomerData CustomerData
		{
			get
			{
				return this.customerData;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06002BE2 RID: 11234 RVA: 0x000B4006 File Offset: 0x000B2206
		public List<ProductDefinition> OrderableProducts
		{
			get
			{
				if (!(this.AssignedDealer != null))
				{
					return ProductManager.ListedProducts;
				}
				return this.AssignedDealer.GetOrderableProducts();
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06002BE3 RID: 11235 RVA: 0x000B4027 File Offset: 0x000B2227
		private DialogueDatabase dialogueDatabase
		{
			get
			{
				return this.NPC.dialogueHandler.Database;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06002BE4 RID: 11236 RVA: 0x000B4039 File Offset: 0x000B2239
		// (set) Token: 0x06002BE5 RID: 11237 RVA: 0x000B4041 File Offset: 0x000B2241
		public NPCPoI potentialCustomerPoI { get; private set; }

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06002BE6 RID: 11238 RVA: 0x000B404A File Offset: 0x000B224A
		public string SaveFolderName
		{
			get
			{
				return "CustomerData";
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06002BE7 RID: 11239 RVA: 0x000B404A File Offset: 0x000B224A
		public string SaveFileName
		{
			get
			{
				return "CustomerData";
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06002BE8 RID: 11240 RVA: 0x00046D4A File Offset: 0x00044F4A
		public Loader Loader
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06002BE9 RID: 11241 RVA: 0x000141BA File Offset: 0x000123BA
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06002BEA RID: 11242 RVA: 0x000B4051 File Offset: 0x000B2251
		// (set) Token: 0x06002BEB RID: 11243 RVA: 0x000B4059 File Offset: 0x000B2259
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06002BEC RID: 11244 RVA: 0x000B4062 File Offset: 0x000B2262
		// (set) Token: 0x06002BED RID: 11245 RVA: 0x000B406A File Offset: 0x000B226A
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06002BEE RID: 11246 RVA: 0x000B4073 File Offset: 0x000B2273
		// (set) Token: 0x06002BEF RID: 11247 RVA: 0x000B407B File Offset: 0x000B227B
		public bool HasChanged { get; set; }

		// Token: 0x06002BF0 RID: 11248 RVA: 0x000B4084 File Offset: 0x000B2284
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Economy.Customer_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x000B40A4 File Offset: 0x000B22A4
		protected override void OnValidate()
		{
			base.OnValidate();
			if (this.DealSignal == null)
			{
				NPCAction npcaction = base.GetComponentInChildren<NPCScheduleManager>().ActionList.Find((NPCAction x) => x != null && x.GetType() == typeof(NPCSignal_WaitForDelivery));
				if (npcaction == null)
				{
					GameObject gameObject = new GameObject("DealSignal");
					gameObject.transform.SetParent(base.GetComponentInChildren<NPCScheduleManager>().transform);
					npcaction = gameObject.AddComponent<NPCSignal_WaitForDelivery>();
				}
				this.DealSignal = (npcaction as NPCSignal_WaitForDelivery);
			}
			if (this.DealSignal != null)
			{
				this.DealSignal.gameObject.SetActive(false);
			}
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x000B4150 File Offset: 0x000B2350
		private void Start()
		{
			TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
			TimeManager instance2 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance2.onDayPass = (Action)Delegate.Combine(instance2.onDayPass, new Action(this.DayPass));
			if (this.NPC.RelationData.Unlocked)
			{
				this.OnCustomerUnlocked(NPCRelationData.EUnlockType.DirectApproach, false);
			}
			else
			{
				NPCRelationData relationData = this.NPC.RelationData;
				relationData.onUnlocked = (Action<NPCRelationData.EUnlockType, bool>)Delegate.Combine(relationData.onUnlocked, new Action<NPCRelationData.EUnlockType, bool>(this.OnCustomerUnlocked));
			}
			foreach (NPC npc in this.NPC.RelationData.Connections)
			{
				if (!(npc == null))
				{
					NPCRelationData relationData2 = npc.RelationData;
					relationData2.onUnlocked = (Action<NPCRelationData.EUnlockType, bool>)Delegate.Combine(relationData2.onUnlocked, new Action<NPCRelationData.EUnlockType, bool>(delegate(NPCRelationData.EUnlockType <p0>, bool <p1>)
					{
						this.UpdatePotentialCustomerPoI();
					}));
				}
			}
			if (this.NPC.MSGConversation != null)
			{
				this.<Start>g__RegisterLoadEvent|133_0();
			}
			else
			{
				NPC npc2 = this.NPC;
				npc2.onConversationCreated = (Action)Delegate.Combine(npc2.onConversationCreated, new Action(this.<Start>g__RegisterLoadEvent|133_0));
			}
			this.SetUpDialogue();
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x000B42B0 File Offset: 0x000B24B0
		public override void OnStartClient()
		{
			base.OnStartClient();
			this.SetupPoI();
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x000B42BE File Offset: 0x000B24BE
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (connection.IsLocalClient)
			{
				return;
			}
			this.ReceiveCustomerData(connection, this.GetCustomerData());
			if (this.DealSignal.IsActive)
			{
				this.ConfigureDealSignal(connection, this.DealSignal.StartTime, true);
			}
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x000B42FD File Offset: 0x000B24FD
		private void OnDestroy()
		{
			Customer.UnlockedCustomers.Remove(this);
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x000B430C File Offset: 0x000B250C
		private void SetUpDialogue()
		{
			this.sampleChoice = new DialogueController.DialogueChoice();
			this.sampleChoice.ChoiceText = "Can I interest you in a free sample?";
			this.sampleChoice.Enabled = true;
			this.sampleChoice.Conversation = null;
			this.sampleChoice.onChoosen = new UnityEvent();
			this.sampleChoice.onChoosen.AddListener(new UnityAction(this.SampleOffered));
			this.sampleChoice.shouldShowCheck = new DialogueController.DialogueChoice.ShouldShowCheck(this.ShowDirectApproachOption);
			this.sampleChoice.isValidCheck = new DialogueController.DialogueChoice.IsChoiceValid(this.SampleOptionValid);
			this.NPC.dialogueHandler.GetComponent<DialogueController>().AddDialogueChoice(this.sampleChoice, -20);
			this.completeContractChoice = new DialogueController.DialogueChoice();
			this.completeContractChoice.ChoiceText = "[Complete Deal]";
			this.completeContractChoice.Enabled = true;
			this.completeContractChoice.Conversation = null;
			this.completeContractChoice.onChoosen = new UnityEvent();
			this.completeContractChoice.onChoosen.AddListener(new UnityAction(this.HandoverChosen));
			this.completeContractChoice.shouldShowCheck = new DialogueController.DialogueChoice.ShouldShowCheck(this.IsReadyForHandover);
			this.completeContractChoice.isValidCheck = new DialogueController.DialogueChoice.IsChoiceValid(this.IsHandoverChoiceValid);
			this.NPC.dialogueHandler.GetComponent<DialogueController>().AddDialogueChoice(this.completeContractChoice, 10);
			this.offerDealChoice = new DialogueController.DialogueChoice();
			this.offerDealChoice.ChoiceText = "You wanna buy something? [Offer a deal]";
			this.offerDealChoice.Enabled = true;
			this.offerDealChoice.Conversation = null;
			this.offerDealChoice.onChoosen = new UnityEvent();
			this.offerDealChoice.onChoosen.AddListener(new UnityAction(this.InstantDealOffered));
			this.offerDealChoice.shouldShowCheck = new DialogueController.DialogueChoice.ShouldShowCheck(this.ShowOfferDealOption);
			this.offerDealChoice.isValidCheck = new DialogueController.DialogueChoice.IsChoiceValid(this.OfferDealValid);
			this.NPC.dialogueHandler.GetComponent<DialogueController>().AddDialogueChoice(this.offerDealChoice, 0);
			this.awaitingDealGreeting = new DialogueController.GreetingOverride();
			this.awaitingDealGreeting.Greeting = this.dialogueDatabase.GetLine(EDialogueModule.Customer, "awaiting_deal");
			this.awaitingDealGreeting.ShouldShow = false;
			this.awaitingDealGreeting.PlayVO = true;
			this.awaitingDealGreeting.VOType = EVOLineType.Question;
			this.NPC.dialogueHandler.GetComponent<DialogueController>().AddGreetingOverride(this.awaitingDealGreeting);
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x000B4588 File Offset: 0x000B2788
		private void SetupPoI()
		{
			if (this.potentialCustomerPoI != null)
			{
				return;
			}
			this.potentialCustomerPoI = Object.Instantiate<NPCPoI>(NetworkSingleton<NPCManager>.Instance.PotentialCustomerPoIPrefab, base.transform);
			this.potentialCustomerPoI.SetMainText("Potential Customer\n" + this.NPC.fullName);
			this.potentialCustomerPoI.SetNPC(this.NPC);
			float y = (float)(this.NPC.FirstName[0] % '$') * 10f;
			float d = Mathf.Clamp((float)this.NPC.FirstName.Length * 1.5f, 1f, 10f);
			Vector3 vector = base.transform.forward;
			vector = Quaternion.Euler(0f, y, 0f) * vector;
			this.potentialCustomerPoI.transform.localPosition = vector * d;
			this.UpdatePotentialCustomerPoI();
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x000B4674 File Offset: 0x000B2874
		protected virtual void MinPass()
		{
			int num = this.TimeSincePlayerApproached;
			this.TimeSincePlayerApproached = num + 1;
			num = this.TimeSinceLastDealCompleted;
			this.TimeSinceLastDealCompleted = num + 1;
			num = this.TimeSinceLastDealOffered;
			this.TimeSinceLastDealOffered = num + 1;
			this.minsSinceUnlocked++;
			num = this.TimeSinceInstantDealOffered;
			this.TimeSinceInstantDealOffered = num + 1;
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			this.HasChanged = true;
			if (this.DEBUG)
			{
				string str = "Current contract: ";
				Contract currentContract = this.CurrentContract;
				Console.Log(str + ((currentContract != null) ? currentContract.ToString() : null), null);
				string str2 = "Offered contract: ";
				ContractInfo contractInfo = this.OfferedContractInfo;
				Console.Log(str2 + ((contractInfo != null) ? contractInfo.ToString() : null), null);
				Console.Log("Awaiting sample: " + this.awaitingSample.ToString(), null);
				Console.Log("Sample offered today: " + this.sampleOfferedToday.ToString(), null);
				string str3 = "Dealer: ";
				Dealer assignedDealer = this.AssignedDealer;
				Console.Log(str3 + ((assignedDealer != null) ? assignedDealer.ToString() : null), null);
				Console.Log("Awaiting deal: " + this.IsAwaitingDelivery.ToString(), null);
			}
			if (this.ShouldTryGenerateDeal())
			{
				ContractInfo contractInfo2 = this.CheckContractGeneration(false);
				if (contractInfo2 != null)
				{
					if (this.AssignedDealer != null)
					{
						if (this.AssignedDealer.ShouldAcceptContract(contractInfo2, this))
						{
							num = this.OfferedDeals;
							this.OfferedDeals = num + 1;
							this.TimeSinceLastDealOffered = 0;
							this.OfferedContractInfo = contractInfo2;
							this.OfferedContractTime = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.GetDateTime();
							this.HasChanged = true;
							this.AssignedDealer.ContractedOffered(contractInfo2, this);
						}
					}
					else
					{
						this.OfferContract(contractInfo2);
					}
				}
			}
			if (this.ShouldTryApproachPlayer())
			{
				float num2 = Mathf.Lerp(0f, 0.5f, this.CurrentAddiction);
				if (Random.Range(0f, 1f) < num2 / 1440f)
				{
					Player randomPlayer = Player.GetRandomPlayer(true, true);
					string str4 = "Approaching player: ";
					Player player = randomPlayer;
					Console.Log(str4 + ((player != null) ? player.ToString() : null), null);
					if (randomPlayer != null)
					{
						this.RequestProduct(randomPlayer);
					}
				}
			}
			if (this.OfferedContractInfo != null)
			{
				this.UpdateOfferExpiry();
			}
			else
			{
				MSGConversation msgconversation = this.NPC.MSGConversation;
				if (msgconversation != null)
				{
					msgconversation.SetSliderValue(0f, Color.white);
				}
			}
			if (this.CurrentContract != null)
			{
				this.UpdateDealAttendance();
			}
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x000B48D1 File Offset: 0x000B2AD1
		protected virtual void DayPass()
		{
			this.sampleOfferedToday = false;
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if ((float)this.TimeSinceLastDealCompleted / 60f >= 24f)
			{
				this.ChangeAddiction(-0.0625f);
			}
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x000B4904 File Offset: 0x000B2B04
		private void UpdateDealAttendance()
		{
			if (this.CurrentContract == null)
			{
				return;
			}
			float num = Vector3.Distance(this.NPC.Avatar.CenterPoint, this.CurrentContract.DeliveryLocation.CustomerStandPoint.position);
			if (this.DEBUG)
			{
				Console.Log("1", null);
			}
			if (!this.NPC.IsConscious)
			{
				this.CurrentContract.Fail(true);
				return;
			}
			if (this.DEBUG)
			{
				Console.Log("2", null);
			}
			if (this.DealSignal.IsActive && this.IsAwaitingDelivery && num < 10f)
			{
				return;
			}
			int windowStartTime = this.CurrentContract.DeliveryWindow.WindowStartTime;
			int num2 = ScheduleOne.GameTime.TimeManager.AddMinutesTo24HourTime(this.CurrentContract.DeliveryWindow.WindowStartTime, 10);
			int windowEndTime = this.CurrentContract.DeliveryWindow.WindowEndTime;
			if (this.DEBUG)
			{
				Console.Log("Soft start: " + windowStartTime.ToString(), null);
				Console.Log("Hard start: " + num2.ToString(), null);
				Console.Log("End time: " + windowEndTime.ToString(), null);
			}
			if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.IsCurrentTimeWithinRange(num2, windowEndTime))
			{
				if (!this.DealSignal.IsActive)
				{
					this.ConfigureDealSignal(null, NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.CurrentTime, true);
				}
				if (num > Vector3.Distance(this.CurrentContract.DeliveryLocation.TeleportPoint.position, this.CurrentContract.DeliveryLocation.CustomerStandPoint.position) * 2f)
				{
					this.NPC.Movement.Warp(this.CurrentContract.DeliveryLocation.TeleportPoint.position);
					return;
				}
			}
			else
			{
				if (this.DealSignal.IsActive)
				{
					return;
				}
				int num3 = Mathf.CeilToInt(num / this.NPC.Movement.WalkSpeed * 2f);
				num3 = Mathf.Clamp(num3, 15, 360);
				int min = ScheduleOne.GameTime.TimeManager.AddMinutesTo24HourTime(windowStartTime, -(num3 + 10));
				if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.IsCurrentTimeWithinRange(min, num2))
				{
					this.ConfigureDealSignal(null, NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.CurrentTime, true);
				}
			}
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x000B4B30 File Offset: 0x000B2D30
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ConfigureDealSignal(NetworkConnection conn, int startTime, bool active)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_ConfigureDealSignal_338960014(conn, startTime, active);
				this.RpcLogic___ConfigureDealSignal_338960014(conn, startTime, active);
			}
			else
			{
				this.RpcWriter___Target_ConfigureDealSignal_338960014(conn, startTime, active);
			}
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x000B4B80 File Offset: 0x000B2D80
		private void UpdateOfferExpiry()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (GameManager.IS_TUTORIAL)
			{
				return;
			}
			if (this.OfferedContractInfo == null)
			{
				this.NPC.MSGConversation.SetSliderValue(0f, Color.white);
				return;
			}
			int num = this.OfferedContractTime.GetMinSum() + 600;
			int minSum = this.OfferedContractTime.GetMinSum();
			float num2 = Mathf.Clamp01((float)(NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.GetTotalMinSum() - minSum) / 600f);
			this.NPC.MSGConversation.SetSliderValue(1f - num2, Singleton<HUD>.Instance.RedGreenGradient.Evaluate(1f - num2));
			if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.GetTotalMinSum() > num)
			{
				this.ExpireOffer();
				this.OfferedContractInfo = null;
			}
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x000B4C44 File Offset: 0x000B2E44
		private ContractInfo CheckContractGeneration(bool force = false)
		{
			if (!this.ShouldTryGenerateDeal() && !force)
			{
				if (this.DEBUG)
				{
					Console.LogWarning("Customer " + this.NPC.fullName + " should not try to generate a deal", null);
				}
				return null;
			}
			if (this.OrderableProducts.Count == 0)
			{
				if (this.DEBUG)
				{
					Console.LogWarning("Customer " + this.NPC.fullName + " has no orderable products", null);
				}
				return null;
			}
			if (this.AssignedDealer == null)
			{
				if (!ProductManager.IsAcceptingOrders && !force)
				{
					if (this.DEBUG)
					{
						Console.LogWarning("Not accepting orders", null);
					}
					return null;
				}
				if (NetworkSingleton<ProductManager>.Instance.TimeSinceProductListingChanged < 3f && !force)
				{
					if (this.DEBUG)
					{
						Console.LogWarning("Product listing changed too recently", null);
					}
					return null;
				}
			}
			int num = 7;
			if (this.AssignedDealer == null)
			{
				List<EDay> orderDays = this.customerData.GetOrderDays(this.CurrentAddiction, this.NPC.RelationData.RelationDelta / 5f);
				num = orderDays.Count;
				if (!orderDays.Contains(NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.CurrentDay) && !force)
				{
					if (this.DEBUG)
					{
						Console.LogWarning(this.NPC.fullName + " cannot order today", null);
					}
					return null;
				}
			}
			int orderTime = this.customerData.OrderTime;
			int max;
			if (this.AssignedDealer == null)
			{
				max = ScheduleOne.GameTime.TimeManager.AddMinutesTo24HourTime(orderTime, 120);
			}
			else
			{
				max = ScheduleOne.GameTime.TimeManager.AddMinutesTo24HourTime(orderTime, 360);
			}
			if (!NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.IsCurrentTimeWithinRange(orderTime, max) && !force)
			{
				if (this.DEBUG)
				{
					Console.LogWarning(this.NPC.fullName + " cannot order now", null);
				}
				return null;
			}
			float num2 = this.customerData.GetAdjustedWeeklySpend(this.NPC.RelationData.RelationDelta / 5f) / (float)num;
			float num3;
			ProductDefinition weightedRandomProduct = this.GetWeightedRandomProduct(out num3);
			if (weightedRandomProduct == null || num3 < 0.05f)
			{
				if (this.DEBUG)
				{
					Console.Log(this.NPC.fullName + " has too low appeal for any products", null);
				}
				return null;
			}
			EQuality correspondingQuality = this.customerData.Standards.GetCorrespondingQuality();
			float productEnjoyment = this.GetProductEnjoyment(weightedRandomProduct, correspondingQuality);
			float num4 = weightedRandomProduct.Price * Mathf.Lerp(0.66f, 1.5f, productEnjoyment);
			num2 *= Mathf.Lerp(0.66f, 1.5f, productEnjoyment);
			int num5 = Mathf.RoundToInt(num2 / weightedRandomProduct.Price);
			num5 = Mathf.Clamp(num5, 1, 1000);
			if (this.AssignedDealer != null)
			{
				int productCount = this.AssignedDealer.GetProductCount(weightedRandomProduct.ID, correspondingQuality, EQuality.Heavenly);
				if (productCount < num5)
				{
					num5 = productCount;
				}
			}
			if (num5 >= 14)
			{
				num5 = Mathf.RoundToInt((float)(num5 / 5)) * 5;
			}
			float payment = (float)(Mathf.RoundToInt(num4 * (float)num5 / 5f) * 5);
			ProductList productList = new ProductList();
			productList.entries.Add(new ProductList.Entry
			{
				ProductID = weightedRandomProduct.ID,
				Quantity = num5,
				Quality = correspondingQuality
			});
			QuestWindowConfig deliveryWindow = new QuestWindowConfig
			{
				IsEnabled = true,
				WindowStartTime = 0,
				WindowEndTime = 0
			};
			DeliveryLocation deliveryLocation = this.DefaultDeliveryLocation;
			if (!GameManager.IS_TUTORIAL)
			{
				deliveryLocation = Singleton<Map>.Instance.GetRegionData(this.NPC.Region).GetRandomUnscheduledDeliveryLocation();
				if (deliveryLocation == null)
				{
					Console.LogError("No unscheduled delivery locations found for " + this.NPC.Region.ToString(), null);
					return null;
				}
			}
			return new ContractInfo(payment, productList, deliveryLocation.GUID.ToString(), deliveryWindow, true, 1, 0, false);
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x000B4FF0 File Offset: 0x000B31F0
		private ProductDefinition GetWeightedRandomProduct(out float appeal)
		{
			float num = Random.Range(0f, 1f);
			Dictionary<ProductDefinition, float> productAppeal = new Dictionary<ProductDefinition, float>();
			for (int i = 0; i < this.OrderableProducts.Count; i++)
			{
				float productEnjoyment = this.GetProductEnjoyment(this.OrderableProducts[i], this.customerData.Standards.GetCorrespondingQuality());
				float num2 = this.OrderableProducts[i].Price / this.OrderableProducts[i].MarketValue;
				float num3 = Mathf.Lerp(1f, -1f, num2 / 2f);
				float value = productEnjoyment + num3;
				productAppeal.Add(this.OrderableProducts[i], value);
			}
			(from x in this.OrderableProducts
			orderby productAppeal[x] descending
			select x).ToList<ProductDefinition>();
			if (num <= 0.5f || this.OrderableProducts.Count <= 1)
			{
				appeal = productAppeal[this.OrderableProducts[0]];
				return this.OrderableProducts[0];
			}
			if (num <= 0.75f || this.OrderableProducts.Count <= 2)
			{
				appeal = productAppeal[this.OrderableProducts[1]];
				return this.OrderableProducts[1];
			}
			if (num <= 0.875f || this.OrderableProducts.Count <= 3)
			{
				appeal = productAppeal[this.OrderableProducts[2]];
				return this.OrderableProducts[2];
			}
			appeal = productAppeal[this.OrderableProducts[3]];
			return this.OrderableProducts[3];
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x000B51AC File Offset: 0x000B33AC
		protected virtual void OnCustomerUnlocked(NPCRelationData.EUnlockType unlockType, bool notify)
		{
			if (notify)
			{
				Singleton<NewCustomerPopup>.Instance.PlayPopup(this);
				this.minsSinceUnlocked = 0;
			}
			Customer.UnlockedCustomers.Add(this);
			if (this.onUnlocked != null)
			{
				this.onUnlocked.Invoke();
			}
			if (Customer.onCustomerUnlocked != null)
			{
				Customer.onCustomerUnlocked(this);
			}
			this.UpdatePotentialCustomerPoI();
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x000B5204 File Offset: 0x000B3404
		public void SetHasBeenRecommended()
		{
			this.HasBeenRecommended = true;
			this.HasChanged = true;
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x000B5214 File Offset: 0x000B3414
		public virtual void OfferContract(ContractInfo info)
		{
			DialogueChain dialogueChain = this.NPC.dialogueHandler.Database.GetChain(EDialogueModule.Customer, "contract_request");
			if (this.OfferedDeals == 0 && this.NPC.dialogueHandler.Database.HasChain(EDialogueModule.Generic, "first_contract_request"))
			{
				dialogueChain = this.NPC.dialogueHandler.Database.GetChain(EDialogueModule.Generic, "first_contract_request");
			}
			dialogueChain = info.ProcessMessage(dialogueChain);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Offered_Contract_Count", (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Offered_Contract_Count") + 1f).ToString(), true);
			int offeredDeals = this.OfferedDeals;
			this.OfferedDeals = offeredDeals + 1;
			this.TimeSinceLastDealOffered = 0;
			this.OfferedContractInfo = info;
			this.OfferedContractTime = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.GetDateTime();
			this.NotifyPlayerOfContract(this.OfferedContractInfo, dialogueChain.GetMessageChain(), true, true, true);
			this.HasChanged = true;
			this.SetOfferedContract(this.OfferedContractInfo, this.OfferedContractTime);
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x000B530F File Offset: 0x000B350F
		[ObserversRpc]
		private void SetOfferedContract(ContractInfo info, GameDateTime offerTime)
		{
			this.RpcWriter___Observers_SetOfferedContract_4277245194(info, offerTime);
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x000B5320 File Offset: 0x000B3520
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public virtual void ExpireOffer()
		{
			this.RpcWriter___Server_ExpireOffer_2166136261();
			this.RpcLogic___ExpireOffer_2166136261();
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x000B533C File Offset: 0x000B353C
		public virtual void AssignContract(Contract contract)
		{
			this.CurrentContract = contract;
			this.CurrentContract.onQuestEnd.AddListener(new UnityAction<EQuestState>(this.CurrentContractEnded));
			this.DealSignal.Location = this.CurrentContract.DeliveryLocation;
			if (this.onContractAssigned != null)
			{
				this.onContractAssigned.Invoke(contract);
			}
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x000B5398 File Offset: 0x000B3598
		protected virtual void NotifyPlayerOfContract(ContractInfo contract, MessageChain offerMessage, bool canAccept, bool canReject, bool canCounterOffer = true)
		{
			this.NPC.MSGConversation.SendMessageChain(offerMessage, 0f, true, true);
			List<Response> list = new List<Response>();
			if (canAccept)
			{
				list.Add(new Response(Customer.PlayerAcceptMessages[Random.Range(0, Customer.PlayerAcceptMessages.Length - 1)], "ACCEPT_CONTRACT", new Action(this.AcceptContractClicked), true));
			}
			if (canCounterOffer)
			{
				list.Add(new Response("[Counter-offer]", "COUNTEROFFER", new Action(this.CounterOfferClicked), true));
			}
			if (canReject)
			{
				list.Add(new Response(Customer.PlayerRejectMessages[Random.Range(0, Customer.PlayerRejectMessages.Length - 1)], "REJECT_CONTRACT", new Action(this.ContractRejected), false));
			}
			this.NPC.MSGConversation.ShowResponses(list, 0f, true);
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x000B546E File Offset: 0x000B366E
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendSetUpResponseCallbacks()
		{
			this.RpcWriter___Server_SendSetUpResponseCallbacks_2166136261();
			this.RpcLogic___SendSetUpResponseCallbacks_2166136261();
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x000B547C File Offset: 0x000B367C
		[ObserversRpc(RunLocally = true)]
		private void SetUpResponseCallbacks()
		{
			this.RpcWriter___Observers_SetUpResponseCallbacks_2166136261();
			this.RpcLogic___SetUpResponseCallbacks_2166136261();
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x000B5495 File Offset: 0x000B3695
		protected virtual void AcceptContractClicked()
		{
			if (this.OfferedContractInfo == null)
			{
				Console.LogWarning("Offered contract is null!", null);
				return;
			}
			PlayerSingleton<MessagesApp>.Instance.DealWindowSelector.SetIsOpen(true, this.NPC.MSGConversation, new Action<EDealWindow>(this.PlayerAcceptedContract));
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x000B54D4 File Offset: 0x000B36D4
		protected virtual void CounterOfferClicked()
		{
			if (this.OfferedContractInfo == null)
			{
				this.NPC.MSGConversation.ClearResponses(true);
				Console.LogWarning("Offered contract is null!", null);
				return;
			}
			ProductDefinition item = Registry.GetItem<ProductDefinition>(this.OfferedContractInfo.Products.entries[0].ProductID);
			int quantity = this.OfferedContractInfo.Products.entries[0].Quantity;
			float payment = this.OfferedContractInfo.Payment;
			PlayerSingleton<MessagesApp>.Instance.CounterofferInterface.Open(item, quantity, payment, this.NPC.MSGConversation, new Action<ProductDefinition, int, float>(this.SendCounteroffer));
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x000B557C File Offset: 0x000B377C
		protected virtual void SendCounteroffer(ProductDefinition product, int quantity, float price)
		{
			if (this.OfferedContractInfo == null)
			{
				Console.LogWarning("Offered contract is null!", null);
				return;
			}
			if (this.OfferedContractInfo.IsCounterOffer)
			{
				Console.LogWarning("Counter offer already sent", null);
				return;
			}
			string text = string.Concat(new string[]
			{
				"How about ",
				quantity.ToString(),
				"x ",
				product.Name,
				" for ",
				MoneyManager.FormatAmount(price, false, false),
				"?"
			});
			this.NPC.MSGConversation.SendMessage(new Message(text, Message.ESenderType.Player, false, -1), true, true);
			this.NPC.MSGConversation.ClearResponses(false);
			this.ProcessCounterOfferServerSide(product.ID, quantity, price);
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x000B563C File Offset: 0x000B383C
		[ServerRpc(RequireOwnership = false)]
		private void ProcessCounterOfferServerSide(string productID, int quantity, float price)
		{
			this.RpcWriter___Server_ProcessCounterOfferServerSide_900355577(productID, quantity, price);
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x000B565B File Offset: 0x000B385B
		[ObserversRpc(RunLocally = true)]
		private void SetContractIsCounterOffer()
		{
			this.RpcWriter___Observers_SetContractIsCounterOffer_2166136261();
			this.RpcLogic___SetContractIsCounterOffer_2166136261();
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x000B566C File Offset: 0x000B386C
		protected virtual void PlayerAcceptedContract(EDealWindow window)
		{
			Console.Log("Player accepted contract in window " + window.ToString(), null);
			if (this.OfferedContractInfo == null)
			{
				Console.LogWarning("Offered contract is null!", null);
				return;
			}
			if (this.CurrentContract != null)
			{
				Console.LogWarning("Customer already has a contract!", null);
				return;
			}
			if (this.NPC.MSGConversation != null)
			{
				string text = this.NPC.MSGConversation.GetResponse("ACCEPT_CONTRACT").text;
				if (this.OfferedContractInfo.IsCounterOffer)
				{
					switch (window)
					{
					case EDealWindow.Morning:
						text = "Morning";
						break;
					case EDealWindow.Afternoon:
						text = "Afternoon";
						break;
					case EDealWindow.Night:
						text = "Night";
						break;
					case EDealWindow.LateNight:
						text = "Late Night";
						break;
					}
				}
				this.NPC.MSGConversation.SendMessage(new Message(text, Message.ESenderType.Player, true, -1), true, true);
				this.NPC.MSGConversation.ClearResponses(true);
			}
			else
			{
				Console.LogWarning("NPC.MSGConversation is null!", null);
			}
			DealWindowInfo windowInfo = DealWindowInfo.GetWindowInfo(window);
			this.OfferedContractInfo.DeliveryWindow.WindowStartTime = windowInfo.StartTime;
			this.OfferedContractInfo.DeliveryWindow.WindowEndTime = windowInfo.EndTime;
			this.PlayContractAcceptedReaction();
			this.SendContractAccepted(window, true);
			if (!InstanceFinder.IsServer)
			{
				this.OfferedContractInfo = null;
			}
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x000B57BA File Offset: 0x000B39BA
		[ServerRpc(RequireOwnership = false)]
		private void SendContractAccepted(EDealWindow window, bool trackContract)
		{
			this.RpcWriter___Server_SendContractAccepted_507093020(window, trackContract);
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x000B57CC File Offset: 0x000B39CC
		public virtual string ContractAccepted(EDealWindow window, bool trackContract)
		{
			if (this.OfferedContractInfo == null)
			{
				Console.LogWarning("Offered contract is null!", null);
				return null;
			}
			DealWindowInfo windowInfo = DealWindowInfo.GetWindowInfo(window);
			this.OfferedContractInfo.DeliveryWindow.WindowStartTime = windowInfo.StartTime;
			this.OfferedContractInfo.DeliveryWindow.WindowEndTime = windowInfo.EndTime;
			string text = GUIDManager.GenerateUniqueGUID().ToString();
			NetworkSingleton<QuestManager>.Instance.SendContractAccepted(base.NetworkObject, this.OfferedContractInfo, trackContract, text);
			this.ReceiveContractAccepted();
			return text;
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x000B5854 File Offset: 0x000B3A54
		[ObserversRpc(RunLocally = true)]
		private void ReceiveContractAccepted()
		{
			this.RpcWriter___Observers_ReceiveContractAccepted_2166136261();
			this.RpcLogic___ReceiveContractAccepted_2166136261();
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x000B5864 File Offset: 0x000B3A64
		protected virtual void PlayContractAcceptedReaction()
		{
			DialogueChain dialogueChain = this.dialogueDatabase.GetChain(EDialogueModule.Customer, "contract_accepted");
			dialogueChain = this.OfferedContractInfo.ProcessMessage(dialogueChain);
			this.NPC.MSGConversation.SendMessageChain(dialogueChain.GetMessageChain(), 0.5f, false, true);
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x000B58B0 File Offset: 0x000B3AB0
		protected virtual bool EvaluateCounteroffer(ProductDefinition product, int quantity, float price)
		{
			float adjustedWeeklySpend = this.customerData.GetAdjustedWeeklySpend(this.NPC.RelationData.RelationDelta / 5f);
			List<EDay> orderDays = this.customerData.GetOrderDays(this.CurrentAddiction, this.NPC.RelationData.RelationDelta / 5f);
			float num = adjustedWeeklySpend / (float)orderDays.Count;
			if (price >= num * 3f)
			{
				return false;
			}
			float valueProposition = Customer.GetValueProposition(Registry.GetItem<ProductDefinition>(this.OfferedContractInfo.Products.entries[0].ProductID), this.OfferedContractInfo.Payment / (float)this.OfferedContractInfo.Products.entries[0].Quantity);
			float productEnjoyment = this.GetProductEnjoyment(product, this.customerData.Standards.GetCorrespondingQuality());
			float num2 = Mathf.InverseLerp(-1f, 1f, productEnjoyment);
			float valueProposition2 = Customer.GetValueProposition(product, price / (float)quantity);
			float num3 = Mathf.Pow((float)quantity / (float)this.OfferedContractInfo.Products.entries[0].Quantity, 0.6f);
			float num4 = Mathf.Lerp(0f, 2f, num3 * 0.5f);
			float num5 = Mathf.Lerp(1f, 0f, Mathf.Abs(num4 - 1f));
			if (valueProposition2 * num5 > valueProposition)
			{
				return true;
			}
			if (valueProposition2 < 0.12f)
			{
				return false;
			}
			float num6 = productEnjoyment * valueProposition;
			float num7 = num2 * num5 * valueProposition2;
			if (num7 > num6)
			{
				return true;
			}
			float num8 = num6 - num7;
			float num9 = Mathf.Lerp(0f, 1f, num8 / 0.2f);
			float t = Mathf.Max(this.CurrentAddiction, this.NPC.RelationData.NormalizedRelationDelta);
			float num10 = Mathf.Lerp(0f, 0.2f, t);
			return Random.Range(0f, 0.9f) + num10 > num9;
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x000B5A94 File Offset: 0x000B3C94
		public static float GetValueProposition(ProductDefinition product, float price)
		{
			float num = product.MarketValue / price;
			if (num < 1f)
			{
				num = Mathf.Pow(num, 2.5f);
			}
			return Mathf.Clamp(num, 0f, 2f);
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x000B5ACE File Offset: 0x000B3CCE
		protected virtual void ContractRejected()
		{
			if (this.OfferedContractInfo == null)
			{
				Console.LogWarning("Offered contract is null!", null);
				return;
			}
			if (InstanceFinder.IsServer)
			{
				this.PlayContractRejectedReaction();
				this.ReceiveContractRejected();
			}
			this.OfferedContractInfo = null;
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x000B5AFE File Offset: 0x000B3CFE
		[ObserversRpc(RunLocally = true)]
		private void ReceiveContractRejected()
		{
			this.RpcWriter___Observers_ReceiveContractRejected_2166136261();
			this.RpcLogic___ReceiveContractRejected_2166136261();
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x000B5B0C File Offset: 0x000B3D0C
		protected virtual void PlayContractRejectedReaction()
		{
			DialogueChain dialogueChain = this.dialogueDatabase.GetChain(EDialogueModule.Customer, "contract_rejected");
			dialogueChain = this.OfferedContractInfo.ProcessMessage(dialogueChain);
			this.NPC.MSGConversation.SendMessageChain(dialogueChain.GetMessageChain(), 0.5f, false, true);
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x000B5B58 File Offset: 0x000B3D58
		public virtual void SetIsAwaitingDelivery(bool awaiting)
		{
			this.IsAwaitingDelivery = awaiting;
			if (awaiting && this.CurrentContract != null)
			{
				this.DealSignal.Location = this.CurrentContract.DeliveryLocation;
				int min = ScheduleOne.GameTime.TimeManager.AddMinutesTo24HourTime(this.CurrentContract.DeliveryWindow.WindowEndTime, -60);
				int num = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.GetTotalMinSum() - this.CurrentContract.AcceptTime.GetMinSum();
				if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.IsCurrentTimeWithinRange(min, this.CurrentContract.DeliveryWindow.WindowStartTime) && num > 300)
				{
					this.awaitingDealGreeting.Greeting = this.dialogueDatabase.GetLine(EDialogueModule.Customer, "late_deal");
				}
				else
				{
					this.awaitingDealGreeting.Greeting = this.dialogueDatabase.GetLine(EDialogueModule.Customer, "awaiting_deal");
				}
			}
			if (this.awaitingDealGreeting != null)
			{
				this.awaitingDealGreeting.ShouldShow = awaiting;
			}
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x000B5C44 File Offset: 0x000B3E44
		public bool IsAtDealLocation()
		{
			return !(this.CurrentContract == null) && this.IsAwaitingDelivery && this.DealSignal.IsActive && !this.NPC.Movement.IsMoving && Vector3.Distance(base.transform.position, this.CurrentContract.DeliveryLocation.CustomerStandPoint.position) < 1f;
		}

		// Token: 0x06002C1A RID: 11290 RVA: 0x000B5CBA File Offset: 0x000B3EBA
		private void UpdatePotentialCustomerPoI()
		{
			if (this.potentialCustomerPoI == null)
			{
				return;
			}
			this.potentialCustomerPoI.enabled = (!this.NPC.RelationData.Unlocked && this.IsUnlockable());
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x000B5CF1 File Offset: 0x000B3EF1
		public void SetPotentialCustomerPoIEnabled(bool enabled)
		{
			if (this.potentialCustomerPoI == null)
			{
				return;
			}
			this.potentialCustomerPoI.enabled = enabled;
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x000B5D10 File Offset: 0x000B3F10
		protected virtual bool ShouldTryGenerateDeal()
		{
			if (!this.NPC.RelationData.Unlocked)
			{
				return false;
			}
			if (this.CurrentContract != null)
			{
				if (this.DEBUG)
				{
					Console.LogWarning("Customer " + this.NPC.fullName + " already has a contract", null);
				}
				return false;
			}
			if (this.OfferedContractInfo != null)
			{
				if (this.DEBUG)
				{
					Console.LogWarning("Customer " + this.NPC.fullName + " already offered contract", null);
				}
				return false;
			}
			int num = (int)('ɘ' + this.NPC.FirstName[0] % '\n' * '\u0014');
			if (this.TimeSinceLastDealCompleted < num)
			{
				if (this.DEBUG)
				{
					Console.LogWarning("Customer " + this.NPC.fullName + " has not waited long enough since last deal", null);
				}
				return false;
			}
			if (this.TimeSinceLastDealOffered < num)
			{
				if (this.DEBUG)
				{
					Console.LogWarning("Customer " + this.NPC.fullName + " has not waited long enough since last offer", null);
				}
				return false;
			}
			if (this.minsSinceUnlocked < 30)
			{
				if (this.DEBUG)
				{
					Console.LogWarning("Customer " + this.NPC.fullName + " has not waited long enough since unlocked", null);
				}
				return false;
			}
			if (!this.NPC.IsConscious)
			{
				if (this.DEBUG)
				{
					Console.LogWarning("Customer " + this.NPC.fullName + " is not conscious", null);
				}
				return false;
			}
			if (this.NPC.behaviour.RequestProductBehaviour.Active)
			{
				if (this.DEBUG)
				{
					Console.LogWarning("Customer " + this.NPC.fullName + " is already requesting a product", null);
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x000B5ECC File Offset: 0x000B40CC
		public virtual void OfferDealItems(List<ItemInstance> items, bool offeredByPlayer, out bool accepted)
		{
			accepted = false;
			if (this.CurrentContract == null)
			{
				return;
			}
			int num;
			float productListMatch = this.CurrentContract.GetProductListMatch(items, out num);
			accepted = (Random.Range(0f, 1f) < productListMatch || GameManager.IS_TUTORIAL);
			if (accepted || !offeredByPlayer)
			{
				this.ProcessHandover(HandoverScreen.EHandoverOutcome.Finalize, this.CurrentContract, items, offeredByPlayer, true);
				return;
			}
			this.CustomerRejectedDeal(offeredByPlayer);
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x000B5F38 File Offset: 0x000B4138
		public virtual void CustomerRejectedDeal(bool offeredByPlayer)
		{
			Console.Log("Customer rejected deal", null);
			if (offeredByPlayer)
			{
				Singleton<HandoverScreen>.Instance.ClearCustomerSlots(true);
			}
			this.CurrentContract.Fail(true);
			this.NPC.RelationData.ChangeRelationship(-0.5f, true);
			this.NPC.PlayVO(EVOLineType.Annoyed);
			this.NPC.Avatar.EmotionManager.AddEmotionOverride("Annoyed", "deal_rejected", 30f, 0);
			this.NPC.dialogueHandler.ShowWorldspaceDialogue(this.dialogueDatabase.GetLine(EDialogueModule.Customer, "customer_rejected_deal"), 5f);
			this.TimeSinceLastDealCompleted = 0;
			if (this.NPC.RelationData.RelationDelta < 2.5f && offeredByPlayer && this.NPC.responses is NPCResponses_Civilian && this.NPC.Aggression > 0.5f && Random.Range(0f, this.NPC.RelationData.NormalizedRelationDelta) < this.NPC.Aggression * 0.5f)
			{
				float num;
				this.NPC.behaviour.CombatBehaviour.SetTarget(null, Player.GetClosestPlayer(base.transform.position, out num, null).NetworkObject);
				this.NPC.behaviour.CombatBehaviour.Enable_Networked(null);
			}
			base.Invoke("EndWait", 1f);
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x000B60A8 File Offset: 0x000B42A8
		public virtual void ProcessHandover(HandoverScreen.EHandoverOutcome outcome, Contract contract, List<ItemInstance> items, bool handoverByPlayer, bool giveBonuses = true)
		{
			float num;
			EDrugType drugType;
			int num2;
			float satisfaction = Mathf.Clamp01(this.EvaluateDelivery(contract, items, out num, out drugType, out num2));
			this.ChangeAddiction(num / 5f);
			float relationDelta = this.NPC.RelationData.RelationDelta;
			float relationshipChange = CustomerSatisfaction.GetRelationshipChange(satisfaction);
			float change = relationshipChange * 0.2f * Mathf.Lerp(0.75f, 1.5f, num);
			this.AdjustAffinity(drugType, change);
			this.NPC.RelationData.ChangeRelationship(relationshipChange, true);
			List<Contract.BonusPayment> list = new List<Contract.BonusPayment>();
			if (giveBonuses)
			{
				if (NetworkSingleton<CurfewManager>.Instance.IsCurrentlyActive)
				{
					list.Add(new Contract.BonusPayment("Curfew Bonus", contract.Payment * 0.2f));
				}
				if (num2 > contract.ProductList.GetTotalQuantity())
				{
					list.Add(new Contract.BonusPayment("Generosity Bonus", 10f * (float)(num2 - contract.ProductList.GetTotalQuantity())));
				}
				GameDateTime acceptTime = contract.AcceptTime;
				GameDateTime end = new GameDateTime(acceptTime.elapsedDays, ScheduleOne.GameTime.TimeManager.AddMinutesTo24HourTime(contract.DeliveryWindow.WindowStartTime, 60));
				if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.IsCurrentDateWithinRange(acceptTime, end))
				{
					list.Add(new Contract.BonusPayment("Quick Delivery Bonus", contract.Payment * 0.1f));
				}
			}
			float num3 = 0f;
			foreach (Contract.BonusPayment bonusPayment in list)
			{
				Console.Log("Bonus: " + bonusPayment.Title + " Amount: " + bonusPayment.Amount.ToString(), null);
				num3 += bonusPayment.Amount;
			}
			if (handoverByPlayer)
			{
				Singleton<HandoverScreen>.Instance.ClearCustomerSlots(false);
				contract.SubmitPayment(num3);
			}
			if (outcome == HandoverScreen.EHandoverOutcome.Finalize && handoverByPlayer)
			{
				Singleton<DealCompletionPopup>.Instance.PlayPopup(this, satisfaction, relationDelta, contract.Payment, list);
			}
			this.TimeSinceLastDealCompleted = 0;
			this.NPC.SendAnimationTrigger("GrabItem");
			NetworkObject networkObject = null;
			if (contract.Dealer != null)
			{
				networkObject = contract.Dealer.NetworkObject;
			}
			Console.Log(string.Concat(new string[]
			{
				"Base payment: ",
				contract.Payment.ToString(),
				" Total bonus: ",
				num3.ToString(),
				" Satisfaction: ",
				satisfaction.ToString(),
				" Dealer: ",
				(networkObject != null) ? networkObject.name : null
			}), null);
			float totalPayment = Mathf.Clamp(contract.Payment + num3, 0f, float.MaxValue);
			this.ProcessHandoverServerSide(outcome, items, handoverByPlayer, totalPayment, contract.ProductList, satisfaction, networkObject);
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x000B6360 File Offset: 0x000B4560
		[ServerRpc(RequireOwnership = false)]
		private void ProcessHandoverServerSide(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealer)
		{
			this.RpcWriter___Server_ProcessHandoverServerSide_3760244802(outcome, items, handoverByPlayer, totalPayment, productList, satisfaction, dealer);
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x000B6390 File Offset: 0x000B4590
		[ObserversRpc]
		private void ProcessHandoverClient(float satisfaction, bool handoverByPlayer, string npcToRecommend)
		{
			this.RpcWriter___Observers_ProcessHandoverClient_537707335(satisfaction, handoverByPlayer, npcToRecommend);
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x000B63B0 File Offset: 0x000B45B0
		public void ContractWellReceived(string npcToRecommend)
		{
			NPC npc = null;
			if (!string.IsNullOrEmpty(npcToRecommend))
			{
				npc = NPCManager.GetNPC(npcToRecommend);
			}
			if (!(npc != null))
			{
				this.NPC.PlayVO(EVOLineType.Thanks);
				this.NPC.dialogueHandler.ShowWorldspaceDialogue(this.dialogueDatabase.GetLine(EDialogueModule.Customer, "deal_completed"), 5f);
				this.NPC.Avatar.EmotionManager.AddEmotionOverride("Cheery", "contract_done", 10f, 0);
				return;
			}
			if (npc is Dealer)
			{
				this.RecommendDealer(npc as Dealer);
				return;
			}
			if (npc is Supplier)
			{
				this.RecommendSupplier(npc as Supplier);
				return;
			}
			this.RecommendCustomer(npc.GetComponent<Customer>());
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x000B6468 File Offset: 0x000B4668
		private void RecommendDealer(Dealer dealer)
		{
			Customer.<>c__DisplayClass182_0 CS$<>8__locals1 = new Customer.<>c__DisplayClass182_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.dealer = dealer;
			if (CS$<>8__locals1.dealer == null)
			{
				Console.LogWarning("Dealer is null!", null);
				return;
			}
			Console.Log(string.Concat(new string[]
			{
				"Customer ",
				this.NPC.fullName,
				" recommended dealer ",
				CS$<>8__locals1.dealer.fullName,
				" to player"
			}), null);
			CS$<>8__locals1.alreadyRecommended = CS$<>8__locals1.dealer.HasBeenRecommended;
			CS$<>8__locals1.dealer.MarkAsRecommended();
			float num;
			if (Player.GetClosestPlayer(base.transform.position, out num, null) == Player.Local)
			{
				Customer.<>c__DisplayClass182_1 CS$<>8__locals2 = new Customer.<>c__DisplayClass182_1();
				CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
				string dialogueText = this.dialogueDatabase.GetLine(EDialogueModule.Customer, "post_deal_recommend_dealer").Replace("<NAME>", CS$<>8__locals2.CS$<>8__locals1.dealer.fullName);
				CS$<>8__locals2.container = new DialogueContainer();
				DialogueNodeData dialogueNodeData = new DialogueNodeData();
				dialogueNodeData.DialogueText = dialogueText;
				dialogueNodeData.choices = new DialogueChoiceData[0];
				dialogueNodeData.DialogueNodeLabel = "ENTRY";
				dialogueNodeData.VoiceLine = EVOLineType.Thanks;
				CS$<>8__locals2.container.DialogueNodeData.Add(dialogueNodeData);
				Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals2.<RecommendDealer>g__Wait|0());
			}
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x000B65C0 File Offset: 0x000B47C0
		private void RecommendSupplier(Supplier supplier)
		{
			Customer.<>c__DisplayClass183_0 CS$<>8__locals1 = new Customer.<>c__DisplayClass183_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.supplier = supplier;
			if (CS$<>8__locals1.supplier == null)
			{
				Console.LogWarning("Supplier is null!", null);
				return;
			}
			Console.Log(string.Concat(new string[]
			{
				"Customer ",
				this.NPC.fullName,
				" recommended supplier ",
				CS$<>8__locals1.supplier.fullName,
				" to player"
			}), null);
			CS$<>8__locals1.alreadyRecommended = CS$<>8__locals1.supplier.RelationData.Unlocked;
			CS$<>8__locals1.supplier.SendUnlocked();
			float num;
			if (Player.GetClosestPlayer(base.transform.position, out num, null) == Player.Local)
			{
				string supplierRecommendMessage = CS$<>8__locals1.supplier.SupplierRecommendMessage;
				CS$<>8__locals1.container = new DialogueContainer();
				DialogueNodeData dialogueNodeData = new DialogueNodeData();
				dialogueNodeData.DialogueText = supplierRecommendMessage;
				dialogueNodeData.choices = new DialogueChoiceData[0];
				dialogueNodeData.DialogueNodeLabel = "ENTRY";
				dialogueNodeData.VoiceLine = EVOLineType.Thanks;
				CS$<>8__locals1.container.DialogueNodeData.Add(dialogueNodeData);
				Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<RecommendSupplier>g__Wait|0());
			}
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x000B66E4 File Offset: 0x000B48E4
		private void RecommendCustomer(Customer friend)
		{
			Customer.<>c__DisplayClass184_0 CS$<>8__locals1 = new Customer.<>c__DisplayClass184_0();
			CS$<>8__locals1.<>4__this = this;
			if (friend == null)
			{
				Console.LogWarning("Friend is null!", null);
				return;
			}
			Console.Log(string.Concat(new string[]
			{
				"Customer ",
				this.NPC.fullName,
				" recommended friend ",
				friend.NPC.fullName,
				" to player"
			}), null);
			friend.SetHasBeenRecommended();
			float num;
			if (Player.GetClosestPlayer(base.transform.position, out num, null) == Player.Local)
			{
				string text = this.dialogueDatabase.GetLine(EDialogueModule.Customer, "post_deal_recommend").Replace("<NAME>", friend.NPC.fullName);
				text = text.Replace("they", friend.NPC.Avatar.GetThirdPersonAddress(false));
				text = text.Replace("them", friend.NPC.Avatar.GetThirdPersonPronoun(false));
				CS$<>8__locals1.container = new DialogueContainer();
				DialogueNodeData dialogueNodeData = new DialogueNodeData();
				dialogueNodeData.DialogueText = text;
				dialogueNodeData.choices = new DialogueChoiceData[0];
				dialogueNodeData.DialogueNodeLabel = "ENTRY";
				dialogueNodeData.VoiceLine = EVOLineType.Thanks;
				CS$<>8__locals1.container.DialogueNodeData.Add(dialogueNodeData);
				Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<RecommendCustomer>g__Wait|0());
			}
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x000B6839 File Offset: 0x000B4A39
		public virtual void CurrentContractEnded(EQuestState outcome)
		{
			if (outcome == EQuestState.Expired)
			{
				this.NPC.Avatar.EmotionManager.AddEmotionOverride("Annoyed", "contract_expired", 30f, 0);
			}
			this.ConfigureDealSignal(null, 0, false);
			this.CurrentContract = null;
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x000B6874 File Offset: 0x000B4A74
		public virtual float EvaluateDelivery(Contract contract, List<ItemInstance> providedItems, out float highestAddiction, out EDrugType mainTypeType, out int matchedProductCount)
		{
			highestAddiction = 0f;
			mainTypeType = EDrugType.Marijuana;
			using (List<ProductList.Entry>.Enumerator enumerator = contract.ProductList.entries.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ProductList.Entry entry = enumerator.Current;
					List<ItemInstance> list = (from x in providedItems
					where x.ID == entry.ProductID
					select x).ToList<ItemInstance>();
					List<ProductItemInstance> list2 = new List<ProductItemInstance>();
					for (int i = 0; i < list.Count; i++)
					{
						list2.Add(list[i] as ProductItemInstance);
					}
					list2 = (from x in list2
					orderby x.Quality descending
					select x).ToList<ProductItemInstance>();
					int num = entry.Quantity;
					int num2 = 0;
					while (num2 < list2.Count && num > 0)
					{
						mainTypeType = (list2[num2].Definition as ProductDefinition).DrugTypes[0].DrugType;
						float addictiveness = (list2[num2].Definition as ProductDefinition).GetAddictiveness();
						if (addictiveness > highestAddiction)
						{
							highestAddiction = addictiveness;
						}
						num--;
						num2++;
					}
				}
			}
			return contract.GetProductListMatch(providedItems, out matchedProductCount);
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x000B69DC File Offset: 0x000B4BDC
		[ServerRpc(RequireOwnership = false)]
		public void ChangeAddiction(float change)
		{
			this.RpcWriter___Server_ChangeAddiction_431000436(change);
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x000B69E8 File Offset: 0x000B4BE8
		private void ConsumeProduct(ItemInstance item)
		{
			Customer.<>c__DisplayClass188_0 CS$<>8__locals1 = new Customer.<>c__DisplayClass188_0();
			CS$<>8__locals1.item = item;
			CS$<>8__locals1.<>4__this = this;
			Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<ConsumeProduct>g__Wait|0());
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x000B6A1C File Offset: 0x000B4C1C
		protected virtual bool ShowOfferDealOption(bool enabled)
		{
			return (Player.Local.CrimeData.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.None || Player.Local.CrimeData.TimeSinceSighted >= 5f) && !(this.CurrentContract != null) && (enabled && !this.IsAwaitingDelivery && this.NPC.RelationData.Unlocked) && !this.NPC.behaviour.RequestProductBehaviour.Active;
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x000B6A9C File Offset: 0x000B4C9C
		protected virtual bool OfferDealValid(out string invalidReason)
		{
			invalidReason = string.Empty;
			if (this.TimeSinceLastDealCompleted < 360)
			{
				invalidReason = "Customer recently completed a deal";
				return false;
			}
			if (this.OfferedContractInfo != null)
			{
				invalidReason = "Customer already has a pending offer";
				return false;
			}
			if (this.TimeSinceInstantDealOffered < 360 && !this.pendingInstantDeal)
			{
				invalidReason = "Already recently offered";
				return false;
			}
			return true;
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x000B6AF8 File Offset: 0x000B4CF8
		protected virtual void InstantDealOffered()
		{
			float num = Mathf.Clamp01((float)this.TimeSinceLastDealCompleted / 1440f) * 0.5f;
			float num2 = this.NPC.RelationData.NormalizedRelationDelta * 0.3f;
			float num3 = this.CurrentAddiction * 0.2f;
			float num4 = num + num2 + num3;
			this.TimeSinceInstantDealOffered = 0;
			if (Random.Range(0f, 1f) < num4 || this.pendingInstantDeal)
			{
				this.NPC.PlayVO(EVOLineType.Acknowledge);
				this.pendingInstantDeal = true;
				this.NPC.dialogueHandler.SkipNextDialogueBehaviourEnd();
				Singleton<HandoverScreen>.Instance.Open(null, this, HandoverScreen.EMode.Offer, new Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float>(this.<InstantDealOffered>g__HandoverClosed|191_0), new Func<List<ItemInstance>, float, float>(this.GetOfferSuccessChance));
				return;
			}
			this.NPC.PlayVO(EVOLineType.No);
			this.NPC.dialogueHandler.ShowWorldspaceDialogue_5s(this.dialogueDatabase.GetLine(EDialogueModule.Customer, "offer_reject"));
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x000B6BE0 File Offset: 0x000B4DE0
		public float GetOfferSuccessChance(List<ItemInstance> items, float askingPrice)
		{
			float adjustedWeeklySpend = this.CustomerData.GetAdjustedWeeklySpend(this.NPC.RelationData.RelationDelta / 5f);
			List<EDay> orderDays = this.CustomerData.GetOrderDays(this.CurrentAddiction, this.NPC.RelationData.RelationDelta / 5f);
			float num = adjustedWeeklySpend / (float)orderDays.Count;
			float num2 = 0f;
			int num3 = 0;
			for (int i = 0; i < items.Count; i++)
			{
				if (items[i] is ProductItemInstance)
				{
					ProductItemInstance productItemInstance = items[i] as ProductItemInstance;
					if (!(productItemInstance.AppliedPackaging == null))
					{
						float productEnjoyment = this.GetProductEnjoyment(items[i].Definition as ProductDefinition, productItemInstance.Quality);
						float num4 = Mathf.InverseLerp(-1f, 1f, productEnjoyment);
						num2 += num4 * (float)productItemInstance.Quantity * (float)productItemInstance.Amount;
						num3 += productItemInstance.Quantity * productItemInstance.Amount;
					}
				}
			}
			if (num3 == 0)
			{
				return 0f;
			}
			float num5 = num2 / (float)num3;
			float price = askingPrice / (float)num3;
			float num6 = 0f;
			for (int j = 0; j < items.Count; j++)
			{
				if (items[j] is ProductItemInstance)
				{
					ProductItemInstance productItemInstance2 = items[j] as ProductItemInstance;
					if (!(productItemInstance2.AppliedPackaging == null))
					{
						float valueProposition = Customer.GetValueProposition(productItemInstance2.Definition as ProductDefinition, price);
						num6 += valueProposition * (float)productItemInstance2.Amount * (float)productItemInstance2.Quantity;
					}
				}
			}
			float f = num6 / (float)num3;
			float num7 = askingPrice / num;
			float item = 1f;
			if (num7 > 1f)
			{
				float num8 = Mathf.Sqrt(num7);
				item = Mathf.Clamp(1f - num8 / 4f, 0.01f, 1f);
			}
			float item2 = num5 + this.CurrentAddiction * 0.25f;
			float item3 = Mathf.Pow(f, 1.5f);
			List<float> list = new List<float>
			{
				item2,
				item3,
				item
			};
			list.Sort();
			if (list[0] < 0.01f)
			{
				return 0f;
			}
			if (num7 > 3f)
			{
				return 0f;
			}
			return list[0] * 0.7f + list[1] * 0.2f + list[2] * 0.1f;
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x000B6E50 File Offset: 0x000B5050
		protected virtual bool ShouldTryApproachPlayer()
		{
			if (!this.NPC.RelationData.Unlocked)
			{
				return false;
			}
			if (this.CurrentContract != null)
			{
				return false;
			}
			if (this.OfferedContractInfo != null)
			{
				return false;
			}
			if (this.TimeSinceLastDealCompleted < 1440)
			{
				return false;
			}
			if (this.minsSinceUnlocked < 30)
			{
				return false;
			}
			if (!this.NPC.IsConscious)
			{
				return false;
			}
			if (this.AssignedDealer != null)
			{
				return false;
			}
			if (this.NPC.behaviour.RequestProductBehaviour.Active)
			{
				return false;
			}
			if (this.NPC.dialogueHandler.IsPlaying)
			{
				return false;
			}
			if (this.CurrentAddiction < 0.33f)
			{
				return false;
			}
			if ((float)this.TimeSincePlayerApproached < Mathf.Lerp(4320f, 2160f, this.CurrentAddiction))
			{
				return false;
			}
			if (this.OrderableProducts.Count == 0)
			{
				return false;
			}
			float num;
			if (Player.GetClosestPlayer(base.transform.position, out num, null) == null)
			{
				return false;
			}
			if (num < 20f)
			{
				return false;
			}
			for (int i = 0; i < Customer.UnlockedCustomers.Count; i++)
			{
				if (Customer.UnlockedCustomers[i].NPC.behaviour.RequestProductBehaviour.Active)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x000B6F90 File Offset: 0x000B5190
		[Button]
		public void RequestProduct()
		{
			this.RequestProduct(Player.GetRandomPlayer(true, true));
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x000B6FA0 File Offset: 0x000B51A0
		public void RequestProduct(Player target)
		{
			Console.Log(this.NPC.fullName + " is requesting product from " + target.PlayerName, null);
			this.TimeSincePlayerApproached = 0;
			this.NPC.behaviour.RequestProductBehaviour.AssignTarget(target.NetworkObject);
			this.NPC.behaviour.RequestProductBehaviour.Enable_Networked(null);
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x000B7008 File Offset: 0x000B5208
		public void PlayerRejectedProductRequest()
		{
			this.NPC.PlayVO(EVOLineType.Annoyed);
			this.NPC.Avatar.EmotionManager.AddEmotionOverride("Annoyed", "product_rejected", 30f, 1);
			this.NPC.dialogueHandler.ShowWorldspaceDialogue(this.dialogueDatabase.GetLine(EDialogueModule.Customer, "request_product_rejected"), 5f);
			if (this.NPC.responses is NPCResponses_Civilian && this.NPC.Aggression > 0.1f)
			{
				float num = Mathf.Clamp(this.NPC.Aggression, 0f, 0.7f);
				num -= this.NPC.RelationData.NormalizedRelationDelta * 0.3f;
				num += this.CurrentAddiction * 0.2f;
				if (Random.Range(0f, 1f) < num)
				{
					float num2;
					this.NPC.behaviour.CombatBehaviour.SetTarget(null, Player.GetClosestPlayer(base.transform.position, out num2, null).NetworkObject);
					this.NPC.behaviour.CombatBehaviour.Enable_Networked(null);
				}
			}
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x000B7130 File Offset: 0x000B5330
		[ServerRpc(RequireOwnership = false)]
		public void RejectProductRequestOffer()
		{
			this.RpcWriter___Server_RejectProductRequestOffer_2166136261();
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x000B7144 File Offset: 0x000B5344
		[ObserversRpc(RunLocally = true)]
		private void RejectProductRequestOffer_Local()
		{
			this.RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261();
			this.RpcLogic___RejectProductRequestOffer_Local_2166136261();
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x000B715D File Offset: 0x000B535D
		public void AssignDealer(Dealer dealer)
		{
			this.AssignedDealer = dealer;
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x000B7166 File Offset: 0x000B5366
		public virtual string GetSaveString()
		{
			return this.GetCustomerData().GetJson(true);
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x000B7174 File Offset: 0x000B5374
		public CustomerData GetCustomerData()
		{
			string[] array = new string[this.OrderableProducts.Count];
			for (int i = 0; i < this.OrderableProducts.Count; i++)
			{
				array[i] = this.OrderableProducts[i].ID;
			}
			float[] array2 = new float[this.currentAffinityData.ProductAffinities.Count];
			for (int j = 0; j < this.currentAffinityData.ProductAffinities.Count; j++)
			{
				array2[j] = this.currentAffinityData.ProductAffinities[j].Affinity;
			}
			return new CustomerData(this.CurrentAddiction, array, array2, this.TimeSinceLastDealCompleted, this.TimeSinceLastDealOffered, this.OfferedDeals, this.CompletedDeliveries, this.OfferedContractInfo != null, this.OfferedContractInfo, this.OfferedContractTime, this.TimeSincePlayerApproached, this.TimeSinceInstantDealOffered, this.HasBeenRecommended);
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x00057BE8 File Offset: 0x00055DE8
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return new List<string>();
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x000B7252 File Offset: 0x000B5452
		[TargetRpc]
		private void ReceiveCustomerData(NetworkConnection conn, CustomerData data)
		{
			this.RpcWriter___Target_ReceiveCustomerData_2280244125(conn, data);
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x000B7264 File Offset: 0x000B5464
		public virtual void Load(CustomerData data)
		{
			this.CurrentAddiction = data.Dependence;
			for (int i = 0; i < this.currentAffinityData.ProductAffinities.Count; i++)
			{
				if (i >= this.currentAffinityData.ProductAffinities.Count)
				{
					Console.LogWarning("Product affinities array is too short", null);
					break;
				}
				if (data.ProductAffinities.Length <= i || float.IsNaN(data.ProductAffinities[i]))
				{
					Console.LogWarning("Product affinity is NaN", null);
				}
				else
				{
					this.currentAffinityData.ProductAffinities[i].Affinity = data.ProductAffinities[i];
				}
			}
			this.TimeSinceLastDealCompleted = data.TimeSinceLastDealCompleted;
			this.TimeSinceLastDealOffered = data.TimeSinceLastDealOffered;
			this.OfferedDeals = data.OfferedDeals;
			this.CompletedDeliveries = data.CompletedDeals;
			int timeSincePlayerApproached = data.TimeSincePlayerApproached;
			this.TimeSincePlayerApproached = data.TimeSincePlayerApproached;
			int timeSinceInstantDealOffered = data.TimeSinceInstantDealOffered;
			this.TimeSinceInstantDealOffered = data.TimeSinceInstantDealOffered;
			bool hasBeenRecommended = data.HasBeenRecommended;
			this.HasBeenRecommended = data.HasBeenRecommended;
			if (data.IsContractOffered && data.OfferedContract != null)
			{
				this.OfferedContractInfo = data.OfferedContract;
				this.OfferedContractTime = data.OfferedContractTime;
				this.SetUpResponseCallbacks();
			}
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x000B7394 File Offset: 0x000B5594
		protected virtual bool IsReadyForHandover(bool enabled)
		{
			return (Player.Local.CrimeData.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.None || Player.Local.CrimeData.TimeSinceSighted >= 5f) && enabled && this.IsAwaitingDelivery;
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x000B73CC File Offset: 0x000B55CC
		protected virtual bool IsHandoverChoiceValid(out string invalidReason)
		{
			invalidReason = string.Empty;
			if (this.CurrentContract == null)
			{
				return false;
			}
			if (this.AssignedDealer != null && (this.AssignedDealer.ActiveContracts.Contains(this.CurrentContract) || this.CurrentContract.Dealer != null))
			{
				invalidReason = "Customer is waiting for a dealer";
				return false;
			}
			return true;
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x000B7433 File Offset: 0x000B5633
		public void HandoverChosen()
		{
			this.NPC.dialogueHandler.SkipNextDialogueBehaviourEnd();
			Singleton<HandoverScreen>.Instance.Open(this.CurrentContract, this, HandoverScreen.EMode.Contract, delegate(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float price)
			{
				if (outcome == HandoverScreen.EHandoverOutcome.Finalize)
				{
					bool flag;
					this.OfferDealItems(items, true, out flag);
					return;
				}
				this.EndWait();
			}, null);
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x000B7464 File Offset: 0x000B5664
		protected virtual bool ShowDirectApproachOption(bool enabled)
		{
			return (Player.Local.CrimeData.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.None || Player.Local.CrimeData.TimeSinceSighted >= 5f) && (enabled && this.customerData.CanBeDirectlyApproached && !this.IsAwaitingDelivery) && !this.NPC.RelationData.Unlocked;
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x000B74C8 File Offset: 0x000B56C8
		public virtual bool IsUnlockable()
		{
			return !this.NPC.RelationData.Unlocked && (GameManager.IS_TUTORIAL || Singleton<Map>.Instance.GetRegionData(this.NPC.Region).IsUnlocked) && this.NPC.RelationData.IsMutuallyKnown();
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x000B7524 File Offset: 0x000B5724
		protected virtual bool SampleOptionValid(out string invalidReason)
		{
			if (!GameManager.IS_TUTORIAL)
			{
				MapRegionData regionData = Singleton<Map>.Instance.GetRegionData(this.NPC.Region);
				if (!regionData.IsUnlocked)
				{
					invalidReason = "'" + regionData.Name + "' region must be unlocked";
					return false;
				}
			}
			if (!this.NPC.RelationData.IsMutuallyKnown())
			{
				invalidReason = "Unlock one of " + this.NPC.FirstName + "'s connections first";
				return false;
			}
			if (this.GetSampleRequestSuccessChance() == 0f)
			{
				invalidReason = "Mutual relationship too low";
				return false;
			}
			if (this.sampleOfferedToday)
			{
				invalidReason = "Sample already offered today";
				return false;
			}
			invalidReason = string.Empty;
			return true;
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x000B75D0 File Offset: 0x000B57D0
		public bool KnownAndRecommended()
		{
			return (GameManager.IS_TUTORIAL || Singleton<Map>.Instance.GetRegionData(this.NPC.Region).IsUnlocked) && this.HasBeenRecommended && this.NPC.RelationData.IsMutuallyKnown();
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x000B7624 File Offset: 0x000B5824
		public void SampleOffered()
		{
			if (this.awaitingSample)
			{
				this.SampleAccepted();
				return;
			}
			float sampleRequestSuccessChance = this.GetSampleRequestSuccessChance();
			if (Random.Range(0f, 1f) <= sampleRequestSuccessChance)
			{
				this.SampleAccepted();
				return;
			}
			this.DirectApproachRejected();
			this.sampleOfferedToday = true;
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x000B7670 File Offset: 0x000B5870
		protected virtual float GetSampleRequestSuccessChance()
		{
			if (this.NPC.RelationData.Unlocked)
			{
				return 1f;
			}
			if (this.NPC.RelationData.IsMutuallyKnown())
			{
				return 1f;
			}
			if (this.customerData.GuaranteeFirstSampleSuccess)
			{
				return 1f;
			}
			if (NetworkSingleton<GameManager>.Instance.IsTutorial)
			{
				return 1f;
			}
			return Mathf.InverseLerp(this.customerData.MinMutualRelationRequirement, this.customerData.MaxMutualRelationRequirement, this.NPC.RelationData.GetAverageMutualRelationship());
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x000B7700 File Offset: 0x000B5900
		protected virtual void SampleAccepted()
		{
			this.awaitingSample = true;
			this.NPC.dialogueHandler.SkipNextDialogueBehaviourEnd();
			this.NPC.PlayVO(EVOLineType.Acknowledge);
			Singleton<HandoverScreen>.Instance.Open(null, this, HandoverScreen.EMode.Sample, new Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float>(this.ProcessSample), new Func<List<ItemInstance>, float, float>(this.GetSampleSuccess));
		}

		// Token: 0x06002C44 RID: 11332 RVA: 0x000B7758 File Offset: 0x000B5958
		private float GetSampleSuccess(List<ItemInstance> items, float price)
		{
			float num = -1000f;
			foreach (ItemInstance itemInstance in items)
			{
				if (itemInstance is ProductItemInstance)
				{
					ProductItemInstance productItemInstance = itemInstance as ProductItemInstance;
					float productEnjoyment = this.GetProductEnjoyment(itemInstance.Definition as ProductDefinition, productItemInstance.Quality);
					if (productEnjoyment > num)
					{
						num = productEnjoyment;
					}
				}
			}
			float num2 = this.NPC.RelationData.RelationDelta / 5f;
			if (num2 >= 0.5f)
			{
				num += Mathf.Lerp(0f, 0.2f, (num2 - 0.5f) * 2f);
			}
			num += Mathf.Lerp(0f, 0.2f, this.CurrentAddiction);
			float num3 = this.NPC.RelationData.GetAverageMutualRelationship() / 5f;
			if (num3 > 0.5f)
			{
				num += Mathf.Lerp(0f, 0.2f, (num3 - 0.5f) * 2f);
			}
			num = Mathf.Clamp01(num);
			if (num <= 0f)
			{
				return 0f;
			}
			return NetworkSingleton<ProductManager>.Instance.SampleSuccessCurve.Evaluate(num);
		}

		// Token: 0x06002C45 RID: 11333 RVA: 0x000B7894 File Offset: 0x000B5A94
		private void ProcessSample(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float price)
		{
			if (outcome == HandoverScreen.EHandoverOutcome.Cancelled)
			{
				base.Invoke("EndWait", 1.5f);
				return;
			}
			Singleton<HandoverScreen>.Instance.ClearCustomerSlots(false);
			this.awaitingSample = false;
			this.ProcessSampleServerSide(items);
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x000B78C4 File Offset: 0x000B5AC4
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void ProcessSampleServerSide(List<ItemInstance> items)
		{
			this.RpcWriter___Server_ProcessSampleServerSide_3704012609(items);
			this.RpcLogic___ProcessSampleServerSide_3704012609(items);
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x000B78E8 File Offset: 0x000B5AE8
		[ObserversRpc(RunLocally = true)]
		private void ProcessSampleClient()
		{
			this.RpcWriter___Observers_ProcessSampleClient_2166136261();
			this.RpcLogic___ProcessSampleClient_2166136261();
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x000B7904 File Offset: 0x000B5B04
		private void SampleConsumed()
		{
			this.NPC.behaviour.ConsumeProductBehaviour.onConsumeDone.RemoveListener(new UnityAction(this.SampleConsumed));
			this.NPC.behaviour.GenericDialogueBehaviour.SendEnable();
			if (this.consumedSample == null)
			{
				Console.LogWarning("Consumed sample is null", null);
				return;
			}
			float sampleSuccess = this.GetSampleSuccess(new List<ItemInstance>
			{
				this.consumedSample
			}, 0f);
			if (Random.Range(0f, 1f) <= sampleSuccess || NetworkSingleton<GameManager>.Instance.IsTutorial || this.customerData.GuaranteeFirstSampleSuccess)
			{
				NetworkSingleton<LevelManager>.Instance.AddXP(50);
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("SuccessfulSampleCount", (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("SuccessfulSampleCount") + 1f).ToString(), true);
				this.SampleWasSufficient();
			}
			else
			{
				this.SampleWasInsufficient();
				float value = NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("SampleRejectionCount");
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("SampleRejectionCount", (value + 1f).ToString(), true);
			}
			this.consumedSample = null;
			base.Invoke("EndWait", 1.5f);
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x000B7A35 File Offset: 0x000B5C35
		private void EndWait()
		{
			if (this.NPC.dialogueHandler.IsPlaying)
			{
				return;
			}
			if (Singleton<HandoverScreen>.Instance.CurrentCustomer == this)
			{
				return;
			}
			this.NPC.behaviour.GenericDialogueBehaviour.SendDisable();
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x000B7A74 File Offset: 0x000B5C74
		protected virtual void DirectApproachRejected()
		{
			if (Random.Range(0f, 1f) <= this.customerData.CallPoliceChance)
			{
				this.NPC.PlayVO(EVOLineType.Angry);
				this.NPC.dialogueHandler.ShowWorldspaceDialogue(this.dialogueDatabase.GetLine(EDialogueModule.Customer, "sample_offer_rejected_police"), 5f);
				this.NPC.actions.SetCallPoliceBehaviourCrime(new AttemptingToSell());
				this.NPC.actions.CallPolice_Networked(Player.Local);
				return;
			}
			this.NPC.PlayVO(EVOLineType.Annoyed);
			this.NPC.dialogueHandler.ShowWorldspaceDialogue(this.dialogueDatabase.GetLine(EDialogueModule.Customer, "sample_offer_rejected"), 5f);
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x000B7B30 File Offset: 0x000B5D30
		[ObserversRpc]
		private void SampleWasSufficient()
		{
			this.RpcWriter___Observers_SampleWasSufficient_2166136261();
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x000B7B44 File Offset: 0x000B5D44
		[ObserversRpc]
		private void SampleWasInsufficient()
		{
			this.RpcWriter___Observers_SampleWasInsufficient_2166136261();
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x000B7B58 File Offset: 0x000B5D58
		public float GetProductEnjoyment(ProductDefinition product, EQuality quality)
		{
			float num = 0f;
			for (int j = 0; j < product.DrugTypes.Count; j++)
			{
				num += this.currentAffinityData.GetAffinity(product.DrugTypes[j].DrugType) * 0.3f;
			}
			float num2 = 0f;
			int i;
			Predicate<Property> <>9__0;
			int i2;
			for (i = 0; i < this.customerData.PreferredProperties.Count; i = i2 + 1)
			{
				List<Property> properties = product.Properties;
				Predicate<Property> match;
				if ((match = <>9__0) == null)
				{
					match = (<>9__0 = ((Property x) => x == this.customerData.PreferredProperties[i]));
				}
				if (properties.Find(match) != null)
				{
					num2 += 1f / (float)this.customerData.PreferredProperties.Count;
				}
				i2 = i;
			}
			num += num2 * 0.4f;
			float qualityScalar = CustomerData.GetQualityScalar(quality);
			float qualityScalar2 = CustomerData.GetQualityScalar(this.customerData.Standards.GetCorrespondingQuality());
			float num3 = qualityScalar - qualityScalar2;
			float num4;
			if (num3 >= 0.25f)
			{
				num4 = 1f;
			}
			else if (num3 >= 0f)
			{
				num4 = 0.5f;
			}
			else if (num3 >= -0.25f)
			{
				num4 = -0.5f;
			}
			else
			{
				num4 = -1f;
			}
			num += num4 * 0.3f;
			float a = -0.6f;
			float b = 1f;
			return Mathf.InverseLerp(a, b, num);
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x000B7CD0 File Offset: 0x000B5ED0
		public List<EDrugType> GetOrderedDrugTypes()
		{
			List<EDrugType> list = new List<EDrugType>();
			for (int i = 0; i < this.currentAffinityData.ProductAffinities.Count; i++)
			{
				list.Add(this.currentAffinityData.ProductAffinities[i].DrugType);
			}
			return (from x in list
			orderby this.currentAffinityData.ProductAffinities.Find((ProductTypeAffinity y) => y.DrugType == x).Affinity descending
			select x).ToList<EDrugType>();
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x000B7D34 File Offset: 0x000B5F34
		[ServerRpc(RequireOwnership = false)]
		public void AdjustAffinity(EDrugType drugType, float change)
		{
			this.RpcWriter___Server_AdjustAffinity_3036964899(drugType, change);
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x000B7D4F File Offset: 0x000B5F4F
		[Button]
		public void AutocreateCustomerSettings()
		{
			if (this.customerData != null)
			{
				Console.LogWarning("Customer data already exists", null);
				return;
			}
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x000B7E5C File Offset: 0x000B605C
		[CompilerGenerated]
		private void <Start>g__RegisterLoadEvent|133_0()
		{
			this.SetUpResponseCallbacks();
			MSGConversation msgconversation = this.NPC.MSGConversation;
			msgconversation.onLoaded = (Action)Delegate.Combine(msgconversation.onLoaded, new Action(this.SetUpResponseCallbacks));
			MSGConversation msgconversation2 = this.NPC.MSGConversation;
			msgconversation2.onResponsesShown = (Action)Delegate.Combine(msgconversation2.onResponsesShown, new Action(this.SetUpResponseCallbacks));
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x000B7EC8 File Offset: 0x000B60C8
		[CompilerGenerated]
		private void <InstantDealOffered>g__HandoverClosed|191_0(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float askingPrice)
		{
			this.TimeSinceInstantDealOffered = 0;
			if (outcome == HandoverScreen.EHandoverOutcome.Cancelled)
			{
				this.EndWait();
				return;
			}
			this.pendingInstantDeal = false;
			float offerSuccessChance = this.GetOfferSuccessChance(items, askingPrice);
			if (Random.value <= offerSuccessChance)
			{
				Singleton<HandoverScreen>.Instance.ClearCustomerSlots(false);
				Contract contract = new Contract();
				ProductList productList = new ProductList();
				for (int i = 0; i < items.Count; i++)
				{
					if (items[i] is ProductItemInstance)
					{
						productList.entries.Add(new ProductList.Entry
						{
							ProductID = items[i].ID,
							Quantity = items[i].Quantity,
							Quality = this.CustomerData.Standards.GetCorrespondingQuality()
						});
					}
				}
				contract.SilentlyInitializeContract("Offer", string.Empty, null, string.Empty, base.NetworkObject, askingPrice, productList, string.Empty, new QuestWindowConfig(), 0, NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.GetDateTime());
				this.ProcessHandover(HandoverScreen.EHandoverOutcome.Finalize, contract, items, true, false);
			}
			else
			{
				Singleton<HandoverScreen>.Instance.ClearCustomerSlots(true);
				this.NPC.dialogueHandler.ShowWorldspaceDialogue_5s(this.dialogueDatabase.GetLine(EDialogueModule.Customer, "sample_insufficient"));
				this.NPC.PlayVO(EVOLineType.Annoyed);
			}
			base.Invoke("EndWait", 1.5f);
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x000B806C File Offset: 0x000B626C
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Economy.CustomerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Economy.CustomerAssembly-CSharp.dll_Excuted = true;
			this.syncVar___<HasBeenRecommended>k__BackingField = new SyncVar<bool>(this, 1U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.<HasBeenRecommended>k__BackingField);
			this.syncVar___<CurrentAddiction>k__BackingField = new SyncVar<float>(this, 0U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.<CurrentAddiction>k__BackingField);
			base.RegisterObserversRpc(0U, new ClientRpcDelegate(this.RpcReader___Observers_ConfigureDealSignal_338960014));
			base.RegisterTargetRpc(1U, new ClientRpcDelegate(this.RpcReader___Target_ConfigureDealSignal_338960014));
			base.RegisterObserversRpc(2U, new ClientRpcDelegate(this.RpcReader___Observers_SetOfferedContract_4277245194));
			base.RegisterServerRpc(3U, new ServerRpcDelegate(this.RpcReader___Server_ExpireOffer_2166136261));
			base.RegisterServerRpc(4U, new ServerRpcDelegate(this.RpcReader___Server_SendSetUpResponseCallbacks_2166136261));
			base.RegisterObserversRpc(5U, new ClientRpcDelegate(this.RpcReader___Observers_SetUpResponseCallbacks_2166136261));
			base.RegisterServerRpc(6U, new ServerRpcDelegate(this.RpcReader___Server_ProcessCounterOfferServerSide_900355577));
			base.RegisterObserversRpc(7U, new ClientRpcDelegate(this.RpcReader___Observers_SetContractIsCounterOffer_2166136261));
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.RpcReader___Server_SendContractAccepted_507093020));
			base.RegisterObserversRpc(9U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveContractAccepted_2166136261));
			base.RegisterObserversRpc(10U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveContractRejected_2166136261));
			base.RegisterServerRpc(11U, new ServerRpcDelegate(this.RpcReader___Server_ProcessHandoverServerSide_3760244802));
			base.RegisterObserversRpc(12U, new ClientRpcDelegate(this.RpcReader___Observers_ProcessHandoverClient_537707335));
			base.RegisterServerRpc(13U, new ServerRpcDelegate(this.RpcReader___Server_ChangeAddiction_431000436));
			base.RegisterServerRpc(14U, new ServerRpcDelegate(this.RpcReader___Server_RejectProductRequestOffer_2166136261));
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_RejectProductRequestOffer_Local_2166136261));
			base.RegisterTargetRpc(16U, new ClientRpcDelegate(this.RpcReader___Target_ReceiveCustomerData_2280244125));
			base.RegisterServerRpc(17U, new ServerRpcDelegate(this.RpcReader___Server_ProcessSampleServerSide_3704012609));
			base.RegisterObserversRpc(18U, new ClientRpcDelegate(this.RpcReader___Observers_ProcessSampleClient_2166136261));
			base.RegisterObserversRpc(19U, new ClientRpcDelegate(this.RpcReader___Observers_SampleWasSufficient_2166136261));
			base.RegisterObserversRpc(20U, new ClientRpcDelegate(this.RpcReader___Observers_SampleWasInsufficient_2166136261));
			base.RegisterServerRpc(21U, new ServerRpcDelegate(this.RpcReader___Server_AdjustAffinity_3036964899));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.Economy.Customer));
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x000B82EC File Offset: 0x000B64EC
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Economy.CustomerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Economy.CustomerAssembly-CSharp.dll_Excuted = true;
			this.syncVar___<HasBeenRecommended>k__BackingField.SetRegistered();
			this.syncVar___<CurrentAddiction>k__BackingField.SetRegistered();
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x000B8315 File Offset: 0x000B6515
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x000B8324 File Offset: 0x000B6524
		private void RpcWriter___Observers_ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active)
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
			writer.WriteInt32(startTime, AutoPackType.Packed);
			writer.WriteBoolean(active);
			base.SendObserversRpc(0U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x000B83EC File Offset: 0x000B65EC
		private void RpcLogic___ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active)
		{
			this.DealSignal.SetStartTime(startTime);
			this.DealSignal.gameObject.SetActive(active);
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x000B840C File Offset: 0x000B660C
		private void RpcReader___Observers_ConfigureDealSignal_338960014(PooledReader PooledReader0, Channel channel)
		{
			int startTime = PooledReader0.ReadInt32(AutoPackType.Packed);
			bool active = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ConfigureDealSignal_338960014(null, startTime, active);
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x000B8460 File Offset: 0x000B6660
		private void RpcWriter___Target_ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active)
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
			writer.WriteInt32(startTime, AutoPackType.Packed);
			writer.WriteBoolean(active);
			base.SendTargetRpc(1U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x000B8528 File Offset: 0x000B6728
		private void RpcReader___Target_ConfigureDealSignal_338960014(PooledReader PooledReader0, Channel channel)
		{
			int startTime = PooledReader0.ReadInt32(AutoPackType.Packed);
			bool active = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ConfigureDealSignal_338960014(base.LocalConnection, startTime, active);
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x000B8578 File Offset: 0x000B6778
		private void RpcWriter___Observers_SetOfferedContract_4277245194(ContractInfo info, GameDateTime offerTime)
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
			writer.Write___ScheduleOne.Quests.ContractInfoFishNet.Serializing.Generated(info);
			writer.Write___ScheduleOne.GameTime.GameDateTimeFishNet.Serializing.Generated(offerTime);
			base.SendObserversRpc(2U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x000B863B File Offset: 0x000B683B
		private void RpcLogic___SetOfferedContract_4277245194(ContractInfo info, GameDateTime offerTime)
		{
			this.OfferedContractInfo = info;
			this.OfferedContractTime = offerTime;
			this.TimeSinceLastDealOffered = 0;
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x000B8654 File Offset: 0x000B6854
		private void RpcReader___Observers_SetOfferedContract_4277245194(PooledReader PooledReader0, Channel channel)
		{
			ContractInfo info = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Quests.ContractInfoFishNet.Serializing.Generateds(PooledReader0);
			GameDateTime offerTime = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.GameTime.GameDateTimeFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetOfferedContract_4277245194(info, offerTime);
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x000B8698 File Offset: 0x000B6898
		private void RpcWriter___Server_ExpireOffer_2166136261()
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
			base.SendServerRpc(3U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x000B8734 File Offset: 0x000B6934
		public virtual void RpcLogic___ExpireOffer_2166136261()
		{
			if (this.OfferedContractInfo == null)
			{
				return;
			}
			this.NPC.MSGConversation.SendMessageChain(this.NPC.dialogueHandler.Database.GetChain(EDialogueModule.Customer, "offer_expired").GetMessageChain(), 0f, true, true);
			this.NPC.MSGConversation.ClearResponses(true);
			this.OfferedContractInfo = null;
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x000B879C File Offset: 0x000B699C
		private void RpcReader___Server_ExpireOffer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___ExpireOffer_2166136261();
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x000B87CC File Offset: 0x000B69CC
		private void RpcWriter___Server_SendSetUpResponseCallbacks_2166136261()
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
			base.SendServerRpc(4U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x000B8866 File Offset: 0x000B6A66
		private void RpcLogic___SendSetUpResponseCallbacks_2166136261()
		{
			this.SetUpResponseCallbacks();
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x000B8870 File Offset: 0x000B6A70
		private void RpcReader___Server_SendSetUpResponseCallbacks_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendSetUpResponseCallbacks_2166136261();
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x000B88A0 File Offset: 0x000B6AA0
		private void RpcWriter___Observers_SetUpResponseCallbacks_2166136261()
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
			base.SendObserversRpc(5U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x000B894C File Offset: 0x000B6B4C
		private void RpcLogic___SetUpResponseCallbacks_2166136261()
		{
			if (this.NPC.MSGConversation == null)
			{
				return;
			}
			for (int i = 0; i < this.NPC.MSGConversation.currentResponses.Count; i++)
			{
				if (this.NPC.MSGConversation.currentResponses[i].label == "ACCEPT_CONTRACT")
				{
					this.NPC.MSGConversation.currentResponses[i].disableDefaultResponseBehaviour = true;
					this.NPC.MSGConversation.currentResponses[i].callback = new Action(this.AcceptContractClicked);
				}
				else if (this.NPC.MSGConversation.currentResponses[i].label == "REJECT_CONTRACT")
				{
					this.NPC.MSGConversation.currentResponses[i].callback = new Action(this.ContractRejected);
				}
				else if (this.NPC.MSGConversation.currentResponses[i].label == "COUNTEROFFER")
				{
					this.NPC.MSGConversation.currentResponses[i].callback = new Action(this.CounterOfferClicked);
					this.NPC.MSGConversation.currentResponses[i].disableDefaultResponseBehaviour = true;
				}
			}
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x000B8ABC File Offset: 0x000B6CBC
		private void RpcReader___Observers_SetUpResponseCallbacks_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetUpResponseCallbacks_2166136261();
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x000B8AE8 File Offset: 0x000B6CE8
		private void RpcWriter___Server_ProcessCounterOfferServerSide_900355577(string productID, int quantity, float price)
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
			writer.WriteString(productID);
			writer.WriteInt32(quantity, AutoPackType.Packed);
			writer.WriteSingle(price, AutoPackType.Unpacked);
			base.SendServerRpc(6U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x000B8BB4 File Offset: 0x000B6DB4
		private void RpcLogic___ProcessCounterOfferServerSide_900355577(string productID, int quantity, float price)
		{
			ProductDefinition item = Registry.GetItem<ProductDefinition>(productID);
			if (item == null)
			{
				Console.LogError("Product is null!", null);
				return;
			}
			if (this.EvaluateCounteroffer(item, quantity, price))
			{
				NetworkSingleton<LevelManager>.Instance.AddXP(5);
				DialogueChain chain = this.dialogueDatabase.GetChain(EDialogueModule.Customer, "counteroffer_accepted");
				this.NPC.MSGConversation.SendMessageChain(chain.GetMessageChain(), 1f, false, true);
				this.OfferedContractInfo.Payment = price;
				this.OfferedContractInfo.Products.entries[0].ProductID = item.ID;
				this.OfferedContractInfo.Products.entries[0].Quantity = quantity;
				this.SetContractIsCounterOffer();
				List<Response> list = new List<Response>();
				list.Add(new Response("[Schedule Deal]", "ACCEPT_CONTRACT", new Action(this.AcceptContractClicked), true));
				list.Add(new Response("Nevermind", "REJECT_CONTRACT", new Action(this.ContractRejected), false));
				this.NPC.MSGConversation.ShowResponses(list, 1f, true);
			}
			else
			{
				DialogueChain chain2 = this.dialogueDatabase.GetChain(EDialogueModule.Customer, "counteroffer_rejected");
				this.NPC.MSGConversation.SendMessageChain(chain2.GetMessageChain(), 0.8f, false, true);
				this.OfferedContractInfo = null;
				this.NPC.MSGConversation.ClearResponses(true);
			}
			this.HasChanged = true;
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x000B8D28 File Offset: 0x000B6F28
		private void RpcReader___Server_ProcessCounterOfferServerSide_900355577(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string productID = PooledReader0.ReadString();
			int quantity = PooledReader0.ReadInt32(AutoPackType.Packed);
			float price = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___ProcessCounterOfferServerSide_900355577(productID, quantity, price);
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x000B8D88 File Offset: 0x000B6F88
		private void RpcWriter___Observers_SetContractIsCounterOffer_2166136261()
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
			base.SendObserversRpc(7U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x000B8E31 File Offset: 0x000B7031
		private void RpcLogic___SetContractIsCounterOffer_2166136261()
		{
			if (this.OfferedContractInfo != null)
			{
				this.OfferedContractInfo.IsCounterOffer = true;
			}
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x000B8E48 File Offset: 0x000B7048
		private void RpcReader___Observers_SetContractIsCounterOffer_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetContractIsCounterOffer_2166136261();
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x000B8E74 File Offset: 0x000B7074
		private void RpcWriter___Server_SendContractAccepted_507093020(EDealWindow window, bool trackContract)
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
			writer.Write___ScheduleOne.Economy.EDealWindowFishNet.Serializing.Generated(window);
			writer.WriteBoolean(trackContract);
			base.SendServerRpc(8U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x000B8F28 File Offset: 0x000B7128
		private void RpcLogic___SendContractAccepted_507093020(EDealWindow window, bool trackContract)
		{
			this.ContractAccepted(window, trackContract);
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x000B8F34 File Offset: 0x000B7134
		private void RpcReader___Server_SendContractAccepted_507093020(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			EDealWindow window = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Economy.EDealWindowFishNet.Serializing.Generateds(PooledReader0);
			bool trackContract = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendContractAccepted_507093020(window, trackContract);
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x000B8F78 File Offset: 0x000B7178
		private void RpcWriter___Observers_ReceiveContractAccepted_2166136261()
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
			base.SendObserversRpc(9U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x000B9021 File Offset: 0x000B7221
		private void RpcLogic___ReceiveContractAccepted_2166136261()
		{
			this.OfferedContractInfo = null;
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x000B902C File Offset: 0x000B722C
		private void RpcReader___Observers_ReceiveContractAccepted_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ReceiveContractAccepted_2166136261();
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x000B9058 File Offset: 0x000B7258
		private void RpcWriter___Observers_ReceiveContractRejected_2166136261()
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
			base.SendObserversRpc(10U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x000B9021 File Offset: 0x000B7221
		private void RpcLogic___ReceiveContractRejected_2166136261()
		{
			this.OfferedContractInfo = null;
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x000B9104 File Offset: 0x000B7304
		private void RpcReader___Observers_ReceiveContractRejected_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ReceiveContractRejected_2166136261();
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x000B9130 File Offset: 0x000B7330
		private void RpcWriter___Server_ProcessHandoverServerSide_3760244802(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealer)
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
			writer.Write___ScheduleOne.UI.Handover.HandoverScreen/EHandoverOutcomeFishNet.Serializing.Generated(outcome);
			writer.Write___System.Collections.Generic.List`1<ScheduleOne.ItemFramework.ItemInstance>FishNet.Serializing.Generated(items);
			writer.WriteBoolean(handoverByPlayer);
			writer.WriteSingle(totalPayment, AutoPackType.Unpacked);
			writer.Write___ScheduleOne.Product.ProductListFishNet.Serializing.Generated(productList);
			writer.WriteSingle(satisfaction, AutoPackType.Unpacked);
			writer.WriteNetworkObject(dealer);
			base.SendServerRpc(11U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x000B9230 File Offset: 0x000B7430
		private void RpcLogic___ProcessHandoverServerSide_3760244802(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealer)
		{
			int completedDeliveries = this.CompletedDeliveries;
			this.CompletedDeliveries = completedDeliveries + 1;
			base.Invoke("EndWait", 1.5f);
			if (handoverByPlayer)
			{
				List<string> list = new List<string>();
				List<int> list2 = new List<int>();
				foreach (ProductList.Entry entry in productList.entries)
				{
					list.Add(entry.ProductID);
					list2.Add(entry.Quantity);
				}
				for (int i = 0; i < list.Count; i++)
				{
					NetworkSingleton<DailySummary>.Instance.AddSoldItem(list[i], list2[i]);
				}
				NetworkSingleton<DailySummary>.Instance.AddPlayerMoney(totalPayment);
				NetworkSingleton<LevelManager>.Instance.AddXP(20);
			}
			else
			{
				NetworkSingleton<LevelManager>.Instance.AddXP(10);
				NetworkSingleton<DailySummary>.Instance.AddDealerMoney(totalPayment);
				if (dealer != null)
				{
					dealer.GetComponent<Dealer>().CompletedDeal();
					dealer.GetComponent<Dealer>().SubmitPayment(totalPayment);
				}
			}
			NetworkSingleton<MoneyManager>.Instance.ChangeLifetimeEarnings(totalPayment);
			if (this.CurrentContract != null)
			{
				this.CurrentContract.Complete(true);
			}
			foreach (ItemInstance item in items)
			{
				this.NPC.Inventory.InsertItem(item, true);
			}
			if (items.Count > 0)
			{
				this.ConsumeProduct(items[0]);
			}
			if (this.NPC.RelationData.NormalizedRelationDelta >= 0.5f)
			{
				Mathf.Lerp(0.33f, 1f, Mathf.InverseLerp(0.5f, 1f, this.NPC.RelationData.NormalizedRelationDelta));
			}
			NPC npc = null;
			if (this.NPC.RelationData.NormalizedRelationDelta >= 0.6f)
			{
				npc = this.NPC.RelationData.GetLockedDealers(true).FirstOrDefault<NPC>();
			}
			NPC npc2 = null;
			if (this.NPC.RelationData.NormalizedRelationDelta >= 0.6f)
			{
				npc2 = this.NPC.RelationData.GetLockedSuppliers().FirstOrDefault<NPC>();
			}
			string npcToRecommend = string.Empty;
			if (GameManager.IS_TUTORIAL && NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Completed_Contracts_Count") >= 2.9f)
			{
				npcToRecommend = "chelsey_milson";
			}
			else if (npc2 != null)
			{
				npcToRecommend = npc2.ID;
			}
			else if (npc != null)
			{
				npcToRecommend = npc.ID;
			}
			this.ProcessHandoverClient(satisfaction, handoverByPlayer, npcToRecommend);
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x000B94DC File Offset: 0x000B76DC
		private void RpcReader___Server_ProcessHandoverServerSide_3760244802(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			HandoverScreen.EHandoverOutcome outcome = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.UI.Handover.HandoverScreen/EHandoverOutcomeFishNet.Serializing.Generateds(PooledReader0);
			List<ItemInstance> items = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<ScheduleOne.ItemFramework.ItemInstance>FishNet.Serializing.Generateds(PooledReader0);
			bool handoverByPlayer = PooledReader0.ReadBoolean();
			float totalPayment = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			ProductList productList = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.ProductListFishNet.Serializing.Generateds(PooledReader0);
			float satisfaction = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			NetworkObject dealer = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___ProcessHandoverServerSide_3760244802(outcome, items, handoverByPlayer, totalPayment, productList, satisfaction, dealer);
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x000B9580 File Offset: 0x000B7780
		private void RpcWriter___Observers_ProcessHandoverClient_537707335(float satisfaction, bool handoverByPlayer, string npcToRecommend)
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
			writer.WriteSingle(satisfaction, AutoPackType.Unpacked);
			writer.WriteBoolean(handoverByPlayer);
			writer.WriteString(npcToRecommend);
			base.SendObserversRpc(12U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x000B9658 File Offset: 0x000B7858
		private void RpcLogic___ProcessHandoverClient_537707335(float satisfaction, bool handoverByPlayer, string npcToRecommend)
		{
			this.TimeSinceLastDealCompleted = 0;
			if (satisfaction >= 0.5f)
			{
				this.ContractWellReceived(npcToRecommend);
			}
			else if (satisfaction < 0.3f)
			{
				this.NPC.PlayVO(EVOLineType.Annoyed);
			}
			if (this.onDealCompleted != null)
			{
				this.onDealCompleted.Invoke();
			}
			this.CurrentContract = null;
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x000B96AC File Offset: 0x000B78AC
		private void RpcReader___Observers_ProcessHandoverClient_537707335(PooledReader PooledReader0, Channel channel)
		{
			float satisfaction = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			bool handoverByPlayer = PooledReader0.ReadBoolean();
			string npcToRecommend = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ProcessHandoverClient_537707335(satisfaction, handoverByPlayer, npcToRecommend);
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x000B9704 File Offset: 0x000B7904
		private void RpcWriter___Server_ChangeAddiction_431000436(float change)
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
			writer.WriteSingle(change, AutoPackType.Unpacked);
			base.SendServerRpc(13U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x000B97B0 File Offset: 0x000B79B0
		public void RpcLogic___ChangeAddiction_431000436(float change)
		{
			this.CurrentAddiction = Mathf.Clamp(this.CurrentAddiction + change, this.customerData.BaseAddiction, 1f);
			this.HasChanged = true;
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x000B97DC File Offset: 0x000B79DC
		private void RpcReader___Server_ChangeAddiction_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			float change = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___ChangeAddiction_431000436(change);
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x000B9814 File Offset: 0x000B7A14
		private void RpcWriter___Server_RejectProductRequestOffer_2166136261()
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
			base.SendServerRpc(14U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x000B98B0 File Offset: 0x000B7AB0
		public void RpcLogic___RejectProductRequestOffer_2166136261()
		{
			this.RejectProductRequestOffer_Local();
			if (this.NPC.responses is NPCResponses_Civilian && this.NPC.Aggression > 0.1f)
			{
				float num = Mathf.Clamp(this.NPC.Aggression, 0f, 0.7f);
				num -= this.NPC.RelationData.NormalizedRelationDelta * 0.3f;
				num += this.CurrentAddiction * 0.2f;
				if (Random.Range(0f, 1f) < num)
				{
					float num2;
					this.NPC.behaviour.CombatBehaviour.SetTarget(null, Player.GetClosestPlayer(base.transform.position, out num2, null).NetworkObject);
					this.NPC.behaviour.CombatBehaviour.Enable_Networked(null);
				}
			}
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x000B9988 File Offset: 0x000B7B88
		private void RpcReader___Server_RejectProductRequestOffer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___RejectProductRequestOffer_2166136261();
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x000B99A8 File Offset: 0x000B7BA8
		private void RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261()
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
			base.SendObserversRpc(15U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x000B9A54 File Offset: 0x000B7C54
		private void RpcLogic___RejectProductRequestOffer_Local_2166136261()
		{
			this.NPC.PlayVO(EVOLineType.Annoyed);
			this.NPC.Avatar.EmotionManager.AddEmotionOverride("Annoyed", "product_request_fail", 30f, 1);
			this.NPC.dialogueHandler.ShowWorldspaceDialogue(this.dialogueDatabase.GetLine(EDialogueModule.Customer, "counteroffer_rejected"), 5f);
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x000B9ABC File Offset: 0x000B7CBC
		private void RpcReader___Observers_RejectProductRequestOffer_Local_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___RejectProductRequestOffer_Local_2166136261();
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x000B9AE8 File Offset: 0x000B7CE8
		private void RpcWriter___Target_ReceiveCustomerData_2280244125(NetworkConnection conn, CustomerData data)
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
			writer.Write___ScheduleOne.Persistence.Datas.CustomerDataFishNet.Serializing.Generated(data);
			base.SendTargetRpc(16U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x000B9B9D File Offset: 0x000B7D9D
		private void RpcLogic___ReceiveCustomerData_2280244125(NetworkConnection conn, CustomerData data)
		{
			this.Load(data);
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x000B9BA8 File Offset: 0x000B7DA8
		private void RpcReader___Target_ReceiveCustomerData_2280244125(PooledReader PooledReader0, Channel channel)
		{
			CustomerData data = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Persistence.Datas.CustomerDataFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveCustomerData_2280244125(base.LocalConnection, data);
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x000B9BE0 File Offset: 0x000B7DE0
		private void RpcWriter___Server_ProcessSampleServerSide_3704012609(List<ItemInstance> items)
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
			writer.Write___System.Collections.Generic.List`1<ScheduleOne.ItemFramework.ItemInstance>FishNet.Serializing.Generated(items);
			base.SendServerRpc(17U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x000B9C88 File Offset: 0x000B7E88
		private void RpcLogic___ProcessSampleServerSide_3704012609(List<ItemInstance> items)
		{
			this.consumedSample = (items[0] as ProductItemInstance);
			this.NPC.behaviour.ConsumeProductBehaviour.onConsumeDone.AddListener(new UnityAction(this.SampleConsumed));
			this.NPC.behaviour.ConsumeProduct(this.consumedSample);
			this.ProcessSampleClient();
			this.EndWait();
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x000B9CF0 File Offset: 0x000B7EF0
		private void RpcReader___Server_ProcessSampleServerSide_3704012609(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			List<ItemInstance> items = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<ScheduleOne.ItemFramework.ItemInstance>FishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___ProcessSampleServerSide_3704012609(items);
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x000B9D30 File Offset: 0x000B7F30
		private void RpcWriter___Observers_ProcessSampleClient_2166136261()
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
			base.SendObserversRpc(18U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x000B9DDC File Offset: 0x000B7FDC
		private void RpcLogic___ProcessSampleClient_2166136261()
		{
			if (this.NPC.behaviour.ConsumeProductBehaviour.Enabled)
			{
				return;
			}
			if (this.sampleOfferedToday)
			{
				return;
			}
			this.sampleOfferedToday = true;
			this.NPC.dialogueHandler.ShowWorldspaceDialogue(this.dialogueDatabase.GetLine(EDialogueModule.Customer, "sample_consume_wait"), 5f);
			this.NPC.SetAnimationTrigger("GrabItem");
			this.NPC.PlayVO(EVOLineType.Think);
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x000B9E54 File Offset: 0x000B8054
		private void RpcReader___Observers_ProcessSampleClient_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ProcessSampleClient_2166136261();
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x000B9E80 File Offset: 0x000B8080
		private void RpcWriter___Observers_SampleWasSufficient_2166136261()
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
			base.SendObserversRpc(19U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002C95 RID: 11413 RVA: 0x000B9F2C File Offset: 0x000B812C
		private void RpcLogic___SampleWasSufficient_2166136261()
		{
			this.NPC.PlayVO(EVOLineType.Thanks);
			this.NPC.dialogueHandler.ShowWorldspaceDialogue(this.dialogueDatabase.GetLine(EDialogueModule.Customer, "sample_sufficient"), 5f);
			this.NPC.Avatar.EmotionManager.AddEmotionOverride("Cheery", "sample_provided", 10f, 0);
			if (!this.NPC.RelationData.Unlocked)
			{
				this.NPC.RelationData.Unlock(NPCRelationData.EUnlockType.DirectApproach, true);
			}
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x000B9FB4 File Offset: 0x000B81B4
		private void RpcReader___Observers_SampleWasSufficient_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SampleWasSufficient_2166136261();
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x000B9FD4 File Offset: 0x000B81D4
		private void RpcWriter___Observers_SampleWasInsufficient_2166136261()
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
			base.SendObserversRpc(20U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x000BA080 File Offset: 0x000B8280
		private void RpcLogic___SampleWasInsufficient_2166136261()
		{
			this.NPC.PlayVO(EVOLineType.Annoyed);
			this.NPC.dialogueHandler.ShowWorldspaceDialogue(this.dialogueDatabase.GetLine(EDialogueModule.Customer, "sample_insufficient"), 5f);
			this.NPC.Avatar.EmotionManager.AddEmotionOverride("Annoyed", "sample_insufficient", 5f, 0);
			if (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("SampleRejectionCount") < 1f && NetworkSingleton<ProductManager>.Instance.onFirstSampleRejection != null)
			{
				NetworkSingleton<ProductManager>.Instance.onFirstSampleRejection.Invoke();
			}
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x000BA118 File Offset: 0x000B8318
		private void RpcReader___Observers_SampleWasInsufficient_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SampleWasInsufficient_2166136261();
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x000BA138 File Offset: 0x000B8338
		private void RpcWriter___Server_AdjustAffinity_3036964899(EDrugType drugType, float change)
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
			writer.Write___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generated(drugType);
			writer.WriteSingle(change, AutoPackType.Unpacked);
			base.SendServerRpc(21U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002C9B RID: 11419 RVA: 0x000BA1F4 File Offset: 0x000B83F4
		public void RpcLogic___AdjustAffinity_3036964899(EDrugType drugType, float change)
		{
			ProductTypeAffinity productTypeAffinity = this.currentAffinityData.ProductAffinities.Find((ProductTypeAffinity x) => x.DrugType == drugType);
			productTypeAffinity.Affinity = Mathf.Clamp(productTypeAffinity.Affinity + change, -1f, 1f);
			this.HasChanged = true;
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x000BA250 File Offset: 0x000B8450
		private void RpcReader___Server_AdjustAffinity_3036964899(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			EDrugType drugType = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generateds(PooledReader0);
			float change = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___AdjustAffinity_3036964899(drugType, change);
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06002C9D RID: 11421 RVA: 0x000BA297 File Offset: 0x000B8497
		// (set) Token: 0x06002C9E RID: 11422 RVA: 0x000BA29F File Offset: 0x000B849F
		public float SyncAccessor_<CurrentAddiction>k__BackingField
		{
			get
			{
				return this.<CurrentAddiction>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<CurrentAddiction>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<CurrentAddiction>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x000BA2DC File Offset: 0x000B84DC
		public virtual bool Customer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 == 1U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_<HasBeenRecommended>k__BackingField(this.syncVar___<HasBeenRecommended>k__BackingField.GetValue(true), true);
					return true;
				}
				bool value = PooledReader0.ReadBoolean();
				this.sync___set_value_<HasBeenRecommended>k__BackingField(value, Boolean2);
				return true;
			}
			else
			{
				if (UInt321 != 0U)
				{
					return false;
				}
				if (PooledReader0 == null)
				{
					this.sync___set_value_<CurrentAddiction>k__BackingField(this.syncVar___<CurrentAddiction>k__BackingField.GetValue(true), true);
					return true;
				}
				float value2 = PooledReader0.ReadSingle(AutoPackType.Unpacked);
				this.sync___set_value_<CurrentAddiction>k__BackingField(value2, Boolean2);
				return true;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06002CA0 RID: 11424 RVA: 0x000BA377 File Offset: 0x000B8577
		// (set) Token: 0x06002CA1 RID: 11425 RVA: 0x000BA37F File Offset: 0x000B857F
		public bool SyncAccessor_<HasBeenRecommended>k__BackingField
		{
			get
			{
				return this.<HasBeenRecommended>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<HasBeenRecommended>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<HasBeenRecommended>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x000BA3BC File Offset: 0x000B85BC
		protected virtual void dll()
		{
			bool availableInDemo = this.AvailableInDemo;
			this.NPC = base.GetComponent<NPC>();
			this.CurrentAddiction = this.customerData.BaseAddiction;
			CustomerData customerData = this.customerData;
			customerData.onChanged = (Action)Delegate.Combine(customerData.onChanged, new Action(delegate()
			{
				this.HasChanged = true;
			}));
			this.currentAffinityData = new CustomerAffinityData();
			this.customerData.DefaultAffinityData.CopyTo(this.currentAffinityData);
			this.NPC.ConversationCategories.Add(EConversationCategory.Customer);
			this.InitializeSaveable();
		}

		// Token: 0x04001F7C RID: 8060
		public static Action<Customer> onCustomerUnlocked;

		// Token: 0x04001F7D RID: 8061
		public static List<Customer> UnlockedCustomers = new List<Customer>();

		// Token: 0x04001F7E RID: 8062
		public const float AFFINITY_MAX_EFFECT = 0.3f;

		// Token: 0x04001F7F RID: 8063
		public const float PROPERTY_MAX_EFFECT = 0.4f;

		// Token: 0x04001F80 RID: 8064
		public const float QUALITY_MAX_EFFECT = 0.3f;

		// Token: 0x04001F81 RID: 8065
		public const float DEAL_REJECTED_RELATIONSHIP_CHANGE = -0.5f;

		// Token: 0x04001F82 RID: 8066
		public bool DEBUG;

		// Token: 0x04001F83 RID: 8067
		public const float APPROACH_MIN_ADDICTION = 0.33f;

		// Token: 0x04001F84 RID: 8068
		public const float APPROACH_CHANCE_PER_DAY_MAX = 0.5f;

		// Token: 0x04001F85 RID: 8069
		public const float APPROACH_MIN_COOLDOWN = 2160f;

		// Token: 0x04001F86 RID: 8070
		public const float APPROACH_MAX_COOLDOWN = 4320f;

		// Token: 0x04001F87 RID: 8071
		public const int DEAL_COOLDOWN = 600;

		// Token: 0x04001F88 RID: 8072
		public static string[] PlayerAcceptMessages = new string[]
		{
			"Yes",
			"Sure thing",
			"Yep",
			"Deal",
			"Alright"
		};

		// Token: 0x04001F89 RID: 8073
		public static string[] PlayerRejectMessages = new string[]
		{
			"No",
			"Not right now",
			"No, sorry"
		};

		// Token: 0x04001F8A RID: 8074
		public const int DEAL_ATTENDANCE_TOLERANCE = 10;

		// Token: 0x04001F8B RID: 8075
		public const int MIN_TRAVEL_TIME = 15;

		// Token: 0x04001F8C RID: 8076
		public const int MAX_TRAVEL_TIME = 360;

		// Token: 0x04001F8D RID: 8077
		public const int OFFER_EXPIRY_TIME_MINS = 600;

		// Token: 0x04001F8E RID: 8078
		public const float MIN_ORDER_APPEAL = 0.05f;

		// Token: 0x04001F8F RID: 8079
		public const float ADDICTION_DRAIN_PER_DAY = 0.0625f;

		// Token: 0x04001F90 RID: 8080
		public const bool SAMPLE_REQUIRES_RECOMMENDATION = false;

		// Token: 0x04001F91 RID: 8081
		public const float MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION = 0.5f;

		// Token: 0x04001F92 RID: 8082
		public const float RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION = 0.6f;

		// Token: 0x04001F93 RID: 8083
		public const float RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION = 0.6f;

		// Token: 0x04001F95 RID: 8085
		private ContractInfo offeredContractInfo;

		// Token: 0x04001FA2 RID: 8098
		public NPCSignal_WaitForDelivery DealSignal;

		// Token: 0x04001FA3 RID: 8099
		[Header("Settings")]
		public bool AvailableInDemo = true;

		// Token: 0x04001FA4 RID: 8100
		[SerializeField]
		protected CustomerData customerData;

		// Token: 0x04001FA5 RID: 8101
		public DeliveryLocation DefaultDeliveryLocation;

		// Token: 0x04001FA6 RID: 8102
		public bool CanRecommendFriends = true;

		// Token: 0x04001FA7 RID: 8103
		[Header("Events")]
		public UnityEvent onUnlocked;

		// Token: 0x04001FA8 RID: 8104
		public UnityEvent onDealCompleted;

		// Token: 0x04001FA9 RID: 8105
		public UnityEvent<Contract> onContractAssigned;

		// Token: 0x04001FAA RID: 8106
		private bool awaitingSample;

		// Token: 0x04001FAB RID: 8107
		private DialogueController.DialogueChoice sampleChoice;

		// Token: 0x04001FAC RID: 8108
		private DialogueController.DialogueChoice completeContractChoice;

		// Token: 0x04001FAD RID: 8109
		private DialogueController.DialogueChoice offerDealChoice;

		// Token: 0x04001FAE RID: 8110
		private DialogueController.GreetingOverride awaitingDealGreeting;

		// Token: 0x04001FAF RID: 8111
		private int minsSinceUnlocked = 10000;

		// Token: 0x04001FB0 RID: 8112
		private bool sampleOfferedToday;

		// Token: 0x04001FB2 RID: 8114
		private CustomerAffinityData currentAffinityData;

		// Token: 0x04001FB3 RID: 8115
		private bool pendingInstantDeal;

		// Token: 0x04001FB7 RID: 8119
		private ProductItemInstance consumedSample;

		// Token: 0x04001FB8 RID: 8120
		public SyncVar<float> syncVar___<CurrentAddiction>k__BackingField;

		// Token: 0x04001FB9 RID: 8121
		public SyncVar<bool> syncVar___<HasBeenRecommended>k__BackingField;

		// Token: 0x04001FBA RID: 8122
		private bool dll_Excuted;

		// Token: 0x04001FBB RID: 8123
		private bool dll_Excuted;

		// Token: 0x02000653 RID: 1619
		[Serializable]
		public class ScheduleGroupPair
		{
			// Token: 0x04001FBC RID: 8124
			public GameObject NormalScheduleGroup;

			// Token: 0x04001FBD RID: 8125
			public GameObject CurfewScheduleGroup;
		}

		// Token: 0x02000654 RID: 1620
		[Serializable]
		public class CustomerPreference
		{
			// Token: 0x04001FBE RID: 8126
			public EDrugType DrugType;

			// Token: 0x04001FBF RID: 8127
			[Header("Optionally, a specific product")]
			public ProductDefinition Definition;

			// Token: 0x04001FC0 RID: 8128
			public EQuality MinimumQuality;
		}

		// Token: 0x02000655 RID: 1621
		public enum ESampleFeedback
		{
			// Token: 0x04001FC2 RID: 8130
			WrongProduct,
			// Token: 0x04001FC3 RID: 8131
			WrongQuality,
			// Token: 0x04001FC4 RID: 8132
			Correct
		}
	}
}
