using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Messaging;
using ScheduleOne.Money;
using ScheduleOne.NPCs.Schedules;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Datas.Characters;
using ScheduleOne.Product;
using ScheduleOne.Quests;
using ScheduleOne.UI.Handover;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004DB RID: 1243
	public class Thomas : NPC
	{
		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001B92 RID: 7058 RVA: 0x00072C93 File Offset: 0x00070E93
		// (set) Token: 0x06001B93 RID: 7059 RVA: 0x00072C9B File Offset: 0x00070E9B
		public bool MeetingReminderSent { get; protected set; }

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x00072CA4 File Offset: 0x00070EA4
		// (set) Token: 0x06001B95 RID: 7061 RVA: 0x00072CAC File Offset: 0x00070EAC
		public bool HandoverReminderSent { get; protected set; }

		// Token: 0x06001B96 RID: 7062 RVA: 0x00072CB5 File Offset: 0x00070EB5
		protected override void Start()
		{
			base.Start();
			this.dialogueHandler.onDialogueChoiceChosen.AddListener(new UnityAction<string>(this.DialogueChoiceCallback));
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x00072CD9 File Offset: 0x00070ED9
		public void SetFirstMeetingEventActive(bool active)
		{
			this.FirstMeetingEvent.gameObject.SetActive(active);
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x00072CEC File Offset: 0x00070EEC
		public void SetHandoverEventActive(bool active)
		{
			this.HandoverEvent.gameObject.SetActive(active);
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x00072D00 File Offset: 0x00070F00
		public void SendMeetingReminder()
		{
			if (this.MeetingReminderSent)
			{
				Console.LogWarning("Reminder message already sent", null);
				return;
			}
			this.MeetingReminderSent = true;
			base.HasChanged = true;
			Message message = new Message();
			message.text = "Either you haven't read our note or are choosing to ignore it - for your sake I'll assume the former. We have business to discuss at Hyland Manor ASAP. - TB";
			message.sender = Message.ESenderType.Other;
			message.endOfGroup = true;
			base.MSGConversation.SetIsKnown(false);
			base.MSGConversation.SendMessage(message, true, true);
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x00072D68 File Offset: 0x00070F68
		public void SendHandoverReminder()
		{
			if (this.HandoverReminderSent)
			{
				Console.LogWarning("Reminder message already sent", null);
				return;
			}
			Debug.Log("Sending reminder");
			this.HandoverReminderSent = true;
			base.HasChanged = true;
			Message message = new Message();
			message.text = "You haven't yet made this week's delivery. There are 24 hours left. Don't make this difficult. - TB";
			message.sender = Message.ESenderType.Other;
			message.endOfGroup = true;
			base.MSGConversation.SendMessage(message, true, true);
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x00072DCE File Offset: 0x00070FCE
		public void InitialMeetingComplete()
		{
			base.MSGConversation.SetIsKnown(true);
			this.SetFirstMeetingEventActive(false);
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x00072DE4 File Offset: 0x00070FE4
		private void DialogueChoiceCallback(string choiceLabel)
		{
			if (choiceLabel == "BEGIN_HANDOVER")
			{
				ProductList productList = new ProductList();
				productList.entries.Add(new ProductList.Entry
				{
					ProductID = "ogkush",
					Quantity = 15,
					Quality = EQuality.Trash
				});
				Contract contract = new GameObject("CartelContract").AddComponent<Contract>();
				contract.transform.SetParent(base.transform);
				contract.SilentlyInitializeContract("Cartel Contract", "Deliver the goods to the cartel", new QuestEntryData[0], string.Empty, base.NetworkObject, 100f, productList, string.Empty, new QuestWindowConfig(), 0, NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.GetDateTime());
				Singleton<HandoverScreen>.Instance.Open(contract, base.GetComponent<Customer>(), HandoverScreen.EMode.Contract, new Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float>(this.ProcessItemHandover), null);
			}
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x00072EB0 File Offset: 0x000710B0
		private void ProcessItemHandover(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float price)
		{
			if (outcome == HandoverScreen.EHandoverOutcome.Cancelled)
			{
				return;
			}
			Singleton<HandoverScreen>.Instance.ClearCustomerSlots(false);
			this.SetHandoverEventActive(false);
			this.HandoverReminderSent = false;
			base.HasChanged = true;
			NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(100f, true, false);
			if (this.onCartelContractReceived != null)
			{
				this.onCartelContractReceived.Invoke();
			}
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x00072F05 File Offset: 0x00071105
		public override string GetSaveString()
		{
			return new ThomasData(this.ID, this.MeetingReminderSent, this.HandoverReminderSent).GetJson(true);
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x00072F24 File Offset: 0x00071124
		public override void Load(NPCData data, string containerPath)
		{
			base.Load(data, containerPath);
			string text;
			if (((ISaveable)this).TryLoadFile(containerPath, "NPC", out text))
			{
				ThomasData thomasData = null;
				try
				{
					thomasData = JsonUtility.FromJson<ThomasData>(text);
				}
				catch (Exception ex)
				{
					Console.LogWarning("Failed to deserialize character data: " + ex.Message, null);
					return;
				}
				this.MeetingReminderSent = thomasData.MeetingReminderSent;
				this.HandoverReminderSent = thomasData.HandoverReminderSent;
			}
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x00072F98 File Offset: 0x00071198
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.ThomasAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.ThomasAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x00072FB1 File Offset: 0x000711B1
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.ThomasAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.ThomasAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x00072FCA File Offset: 0x000711CA
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x00072FD8 File Offset: 0x000711D8
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400170E RID: 5902
		public const int CARTEL_CONTRACT_QUANTITY = 15;

		// Token: 0x0400170F RID: 5903
		public const float CARTEL_CONTRACT_PAYMENT = 100f;

		// Token: 0x04001710 RID: 5904
		public NPCEvent_LocationDialogue FirstMeetingEvent;

		// Token: 0x04001711 RID: 5905
		public NPCEvent_LocationDialogue HandoverEvent;

		// Token: 0x04001712 RID: 5906
		public UnityEvent onCartelContractReceived;

		// Token: 0x04001715 RID: 5909
		private bool dll_Excuted;

		// Token: 0x04001716 RID: 5910
		private bool dll_Excuted;
	}
}
