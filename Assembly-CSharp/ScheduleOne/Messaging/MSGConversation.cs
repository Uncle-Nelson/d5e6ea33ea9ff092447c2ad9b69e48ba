using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.UI;
using ScheduleOne.UI.Phone;
using ScheduleOne.UI.Phone.Messages;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.Messaging
{
	// Token: 0x0200054A RID: 1354
	[Serializable]
	public class MSGConversation : ISaveable
	{
		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x0600211C RID: 8476 RVA: 0x00088430 File Offset: 0x00086630
		// (set) Token: 0x0600211D RID: 8477 RVA: 0x00088438 File Offset: 0x00086638
		public bool IsSenderKnown { get; protected set; } = true;

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x0600211E RID: 8478 RVA: 0x00088441 File Offset: 0x00086641
		// (set) Token: 0x0600211F RID: 8479 RVA: 0x00088449 File Offset: 0x00086649
		public int index { get; protected set; }

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x00088452 File Offset: 0x00086652
		// (set) Token: 0x06002121 RID: 8481 RVA: 0x0008845A File Offset: 0x0008665A
		public bool isOpen { get; protected set; }

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06002122 RID: 8482 RVA: 0x00088463 File Offset: 0x00086663
		// (set) Token: 0x06002123 RID: 8483 RVA: 0x0008846B File Offset: 0x0008666B
		public bool rollingOut { get; protected set; }

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06002124 RID: 8484 RVA: 0x00088474 File Offset: 0x00086674
		// (set) Token: 0x06002125 RID: 8485 RVA: 0x0008847C File Offset: 0x0008667C
		public bool EntryVisible { get; protected set; } = true;

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06002126 RID: 8486 RVA: 0x00088485 File Offset: 0x00086685
		public bool AreResponsesActive
		{
			get
			{
				return this.currentResponses.Count > 0;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x00088495 File Offset: 0x00086695
		public string SaveFolderName
		{
			get
			{
				return "MessageConversation";
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06002128 RID: 8488 RVA: 0x00088495 File Offset: 0x00086695
		public string SaveFileName
		{
			get
			{
				return "MessageConversation";
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06002129 RID: 8489 RVA: 0x00046D4A File Offset: 0x00044F4A
		public Loader Loader
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x000141BA File Offset: 0x000123BA
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x0600212B RID: 8491 RVA: 0x0008849C File Offset: 0x0008669C
		// (set) Token: 0x0600212C RID: 8492 RVA: 0x000884A4 File Offset: 0x000866A4
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x000884AD File Offset: 0x000866AD
		// (set) Token: 0x0600212E RID: 8494 RVA: 0x000884B5 File Offset: 0x000866B5
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x000884BE File Offset: 0x000866BE
		// (set) Token: 0x06002130 RID: 8496 RVA: 0x000884C6 File Offset: 0x000866C6
		public bool HasChanged { get; set; }

		// Token: 0x06002131 RID: 8497 RVA: 0x000884D0 File Offset: 0x000866D0
		public MSGConversation(NPC _npc, string _contactName)
		{
			this.contactName = _contactName;
			this.sender = _npc;
			MessagesApp.Conversations.Insert(0, this);
			this.index = 0;
			NetworkSingleton<MessagingManager>.Instance.Register(_npc, this);
			this.InitializeSaveable();
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x00088599 File Offset: 0x00086799
		public void SetCategories(List<EConversationCategory> cat)
		{
			this.Categories = cat;
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x000885A2 File Offset: 0x000867A2
		public void MoveToTop()
		{
			MessagesApp.ActiveConversations.Remove(this);
			MessagesApp.ActiveConversations.Insert(0, this);
			this.index = 0;
			PlayerSingleton<MessagesApp>.Instance.RepositionEntries();
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x000885D0 File Offset: 0x000867D0
		protected void CreateUI()
		{
			if (this.uiCreated)
			{
				return;
			}
			this.uiCreated = true;
			PlayerSingleton<MessagesApp>.Instance.CreateConversationUI(this, out this.entry, out this.container);
			MessagesApp.ActiveConversations.Add(this);
			this.entryPreviewText = this.entry.Find("Preview").GetComponent<Text>();
			this.unreadDot = this.entry.Find("UnreadDot").GetComponent<RectTransform>();
			this.slider = this.entry.Find("Slider").GetComponent<Slider>();
			this.sliderFill = this.slider.fillRect.GetComponent<Image>();
			this.entry.Find("Button").GetComponent<Button>().onClick.AddListener(new UnityAction(this.EntryClicked));
			Button component = this.entry.Find("Hide").GetComponent<Button>();
			if (this.sender.ConversationCanBeHidden)
			{
				component.gameObject.SetActive(true);
				component.onClick.AddListener(new UnityAction(delegate()
				{
					this.SetEntryVisibility(false);
				}));
			}
			else
			{
				component.gameObject.SetActive(false);
			}
			this.scrollRectContainer = this.container.Find("ScrollContainer").GetComponent<RectTransform>();
			this.scrollRect = this.scrollRectContainer.Find("ScrollRect").GetComponent<ScrollRect>();
			this.bubbleContainer = this.scrollRect.transform.Find("Viewport/Content").GetComponent<RectTransform>();
			this.entryPreviewText.text = string.Empty;
			this.unreadDot.gameObject.SetActive(!this.read && this.messageHistory.Count > 0);
			this.responseContainer = this.container.Find("Responses").GetComponent<RectTransform>();
			this.senderInterface = this.container.Find("SenderInterface").GetComponent<MessageSenderInterface>();
			for (int i = 0; i < this.Sendables.Count; i++)
			{
				this.senderInterface.AddSendable(this.Sendables[i]);
			}
			this.RepositionEntry();
			this.SetResponseContainerVisible(false);
			this.SetOpen(false);
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x000887FB File Offset: 0x000869FB
		private void EnsureUIExists()
		{
			if (!this.uiCreated)
			{
				this.CreateUI();
			}
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x0008880C File Offset: 0x00086A0C
		protected void RefreshPreviewText()
		{
			if (this.bubbles.Count == 0)
			{
				this.entryPreviewText.text = string.Empty;
				return;
			}
			this.entryPreviewText.text = this.bubbles[this.bubbles.Count - 1].text;
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x0008885F File Offset: 0x00086A5F
		public void RepositionEntry()
		{
			if (this.entry == null)
			{
				return;
			}
			this.entry.SetSiblingIndex(MessagesApp.ActiveConversations.IndexOf(this));
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x00088888 File Offset: 0x00086A88
		public void SetIsKnown(bool known)
		{
			this.IsSenderKnown = known;
			if (this.entry != null)
			{
				this.entry.Find("Name").GetComponent<Text>().text = (this.IsSenderKnown ? this.contactName : "Unknown");
				this.entry.Find("IconMask/Icon").GetComponent<Image>().sprite = (this.IsSenderKnown ? this.sender.MugshotSprite : PlayerSingleton<MessagesApp>.Instance.BlankAvatarSprite);
			}
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x00088912 File Offset: 0x00086B12
		public void EntryClicked()
		{
			this.SetOpen(true);
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x0008891C File Offset: 0x00086B1C
		public void SetOpen(bool open)
		{
			this.isOpen = open;
			PlayerSingleton<MessagesApp>.Instance.homePage.gameObject.SetActive(!open);
			PlayerSingleton<MessagesApp>.Instance.dialoguePage.gameObject.SetActive(open);
			if (open)
			{
				PlayerSingleton<MessagesApp>.Instance.SetCurrentConversation(this);
				PlayerSingleton<MessagesApp>.Instance.relationshipContainer.gameObject.SetActive(false);
				PlayerSingleton<MessagesApp>.Instance.standardsContainer.gameObject.SetActive(false);
				float y = 0f;
				if (this.sender.ShowRelationshipInfo)
				{
					y = 20f;
					PlayerSingleton<MessagesApp>.Instance.relationshipScrollbar.value = this.sender.RelationData.NormalizedRelationDelta;
					PlayerSingleton<MessagesApp>.Instance.relationshipTooltip.text = RelationshipCategory.GetCategory(this.sender.RelationData.RelationDelta).ToString();
					PlayerSingleton<MessagesApp>.Instance.relationshipContainer.gameObject.SetActive(true);
					Customer customer;
					if (this.sender.TryGetComponent<Customer>(out customer))
					{
						PlayerSingleton<MessagesApp>.Instance.standardsStar.color = ItemQuality.GetColor(customer.CustomerData.Standards.GetCorrespondingQuality());
						PlayerSingleton<MessagesApp>.Instance.standardsTooltip.text = customer.CustomerData.Standards.GetName() + " standards.";
						PlayerSingleton<MessagesApp>.Instance.standardsContainer.gameObject.SetActive(true);
					}
				}
				PlayerSingleton<MessagesApp>.Instance.dialoguePageNameText.text = (this.IsSenderKnown ? this.contactName : "Unknown");
				PlayerSingleton<MessagesApp>.Instance.dialoguePageNameText.rectTransform.anchoredPosition = new Vector2(-PlayerSingleton<MessagesApp>.Instance.dialoguePageNameText.preferredWidth / 2f + 30f, y);
				PlayerSingleton<MessagesApp>.Instance.iconContainerRect.anchoredPosition = new Vector2(-PlayerSingleton<MessagesApp>.Instance.dialoguePageNameText.preferredWidth / 2f - 30f, PlayerSingleton<MessagesApp>.Instance.iconContainerRect.anchoredPosition.y);
				PlayerSingleton<MessagesApp>.Instance.iconImage.sprite = (this.IsSenderKnown ? this.sender.MugshotSprite : PlayerSingleton<MessagesApp>.Instance.BlankAvatarSprite);
				this.SetRead(true);
				this.CheckSendLoop();
				for (int i = 0; i < this.responseRects.Count; i++)
				{
					this.responseRects[i].gameObject.GetComponent<MessageBubble>().RefreshDisplayedText();
				}
				for (int j = 0; j < this.bubbles.Count; j++)
				{
					this.bubbles[j].autosetPosition = false;
					this.bubbles[j].RefreshDisplayedText();
				}
			}
			else
			{
				PlayerSingleton<MessagesApp>.Instance.SetCurrentConversation(null);
			}
			this.container.gameObject.SetActive(open);
			this.SetResponseContainerVisible(this.AreResponsesActive);
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x00088C00 File Offset: 0x00086E00
		protected virtual void RenderMessage(Message m)
		{
			MessageBubble component = Object.Instantiate<GameObject>(PlayerSingleton<MessagesApp>.Instance.messageBubblePrefab, this.bubbleContainer).GetComponent<MessageBubble>();
			component.SetupBubble(m.text, (m.sender == Message.ESenderType.Other) ? MessageBubble.Alignment.Left : MessageBubble.Alignment.Right, false);
			float num = 0f;
			for (int i = 0; i < this.bubbles.Count; i++)
			{
				num += this.bubbles[i].height;
				num += this.bubbles[i].spacingAbove;
			}
			bool flag = false;
			if (this.messageHistory.IndexOf(m) > 0 && this.messageHistory[this.messageHistory.IndexOf(m) - 1].sender == m.sender)
			{
				flag = true;
			}
			float num2 = MessageBubble.baseBubbleSpacing;
			if (!flag)
			{
				num2 *= 10f;
			}
			if (flag && this.messageHistory[this.messageHistory.IndexOf(m) - 1].endOfGroup)
			{
				num2 *= 20f;
			}
			component.container.anchoredPosition = new Vector2(component.container.anchoredPosition.x, -num - num2 - component.height / 2f);
			component.spacingAbove = num2;
			component.showTriangle = true;
			if (flag && !this.messageHistory[this.messageHistory.IndexOf(m) - 1].endOfGroup)
			{
				this.bubbles[this.bubbles.Count - 1].showTriangle = false;
			}
			this.bubbleContainer.sizeDelta = new Vector2(this.bubbleContainer.sizeDelta.x, num + component.height + num2 + MessageBubble.baseBubbleSpacing * 10f);
			this.scrollRect.verticalNormalizedPosition = 0f;
			this.bubbles.Add(component);
			if (m.sender == Message.ESenderType.Player && PlayerSingleton<MessagesApp>.Instance.isOpen && PlayerSingleton<Phone>.Instance.IsOpen)
			{
				PlayerSingleton<MessagesApp>.Instance.MessageSentSound.Play();
			}
			else if (PlayerSingleton<Phone>.Instance.IsOpen && PlayerSingleton<MessagesApp>.Instance.isOpen && (this.isOpen || PlayerSingleton<MessagesApp>.Instance.currentConversation == null))
			{
				PlayerSingleton<MessagesApp>.Instance.MessageReceivedSound.Play();
			}
			if (this.onMessageRendered != null)
			{
				this.onMessageRendered();
			}
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x00088E52 File Offset: 0x00087052
		public void SetEntryVisibility(bool v)
		{
			if (!v && !this.sender.ConversationCanBeHidden)
			{
				return;
			}
			this.EntryVisible = v;
			this.entry.gameObject.SetActive(v);
			if (!v)
			{
				this.SetRead(true);
			}
			this.HasChanged = true;
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x00088E90 File Offset: 0x00087090
		public void SetRead(bool r)
		{
			this.read = r;
			if (this.read)
			{
				if (PlayerSingleton<MessagesApp>.Instance.unreadConversations.Contains(this))
				{
					PlayerSingleton<MessagesApp>.Instance.unreadConversations.Remove(this);
					PlayerSingleton<MessagesApp>.Instance.RefreshNotifications();
				}
			}
			else if (!PlayerSingleton<MessagesApp>.Instance.unreadConversations.Contains(this))
			{
				PlayerSingleton<MessagesApp>.Instance.unreadConversations.Add(this);
				PlayerSingleton<MessagesApp>.Instance.RefreshNotifications();
			}
			if (this.unreadDot != null)
			{
				this.unreadDot.gameObject.SetActive(!this.read);
			}
			this.HasChanged = true;
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x00088F38 File Offset: 0x00087138
		public void SendMessage(Message message, bool notify = true, bool network = true)
		{
			this.EnsureUIExists();
			if (message.messageId == -1)
			{
				message.messageId = Random.Range(int.MinValue, int.MaxValue);
			}
			if (this.messageHistory.Find((Message x) => x.messageId == message.messageId) != null)
			{
				return;
			}
			if (network)
			{
				NetworkSingleton<MessagingManager>.Instance.SendMessage(message, notify, this.sender.ID);
				return;
			}
			this.messageHistory.Add(message);
			if (this.messageHistory.Count > 10)
			{
				this.messageHistory.RemoveAt(0);
			}
			if (message.sender == Message.ESenderType.Other && notify)
			{
				this.SetEntryVisibility(true);
				if (!this.isOpen)
				{
					this.SetRead(false);
				}
				if (!this.isOpen || !PlayerSingleton<MessagesApp>.Instance.isOpen || !PlayerSingleton<Phone>.Instance.IsOpen)
				{
					Singleton<NotificationsManager>.Instance.SendNotification(this.IsSenderKnown ? this.contactName : "Unknown", message.text, PlayerSingleton<MessagesApp>.Instance.AppIcon, 5f, true);
				}
			}
			this.RenderMessage(message);
			this.RefreshPreviewText();
			this.MoveToTop();
			this.HasChanged = true;
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x00089088 File Offset: 0x00087288
		public void SendMessageChain(MessageChain messages, float initialDelay = 0f, bool notify = true, bool network = true)
		{
			MSGConversation.<>c__DisplayClass83_0 CS$<>8__locals1 = new MSGConversation.<>c__DisplayClass83_0();
			CS$<>8__locals1.messages = messages;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.notify = notify;
			this.EnsureUIExists();
			if (CS$<>8__locals1.messages.id == -1)
			{
				CS$<>8__locals1.messages.id = Random.Range(int.MinValue, int.MaxValue);
			}
			if (this.messageChainHistory.Find((MessageChain x) => x.id == CS$<>8__locals1.messages.id) != null)
			{
				return;
			}
			if (network)
			{
				NetworkSingleton<MessagingManager>.Instance.SendMessageChain(CS$<>8__locals1.messages, this.sender.ID, initialDelay, CS$<>8__locals1.notify);
				return;
			}
			this.messageChainHistory.Add(CS$<>8__locals1.messages);
			this.HasChanged = true;
			Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<SendMessageChain>g__Routine|1(CS$<>8__locals1.messages, initialDelay));
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x00089150 File Offset: 0x00087350
		public MSGConversationData GetSaveData()
		{
			List<TextMessageData> list = new List<TextMessageData>();
			for (int i = 0; i < this.messageHistory.Count; i++)
			{
				list.Add(this.messageHistory[i].GetSaveData());
			}
			List<TextResponseData> list2 = new List<TextResponseData>();
			for (int j = 0; j < this.currentResponses.Count; j++)
			{
				list2.Add(new TextResponseData(this.currentResponses[j].text, this.currentResponses[j].label));
			}
			return new MSGConversationData(MessagesApp.ActiveConversations.IndexOf(this), this.read, list.ToArray(), list2.ToArray(), !this.EntryVisible);
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x00089204 File Offset: 0x00087404
		public virtual string GetSaveString()
		{
			return this.GetSaveData().GetJson(true);
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x00089214 File Offset: 0x00087414
		public virtual void Load(MSGConversationData data)
		{
			this.EnsureUIExists();
			this.index = data.ConversationIndex;
			this.SetRead(data.Read);
			if (data.MessageHistory != null)
			{
				for (int i = 0; i < data.MessageHistory.Length; i++)
				{
					Message message = new Message(data.MessageHistory[i]);
					this.messageHistory.Add(message);
					if (this.messageHistory.Count > 10)
					{
						this.messageHistory.RemoveAt(0);
					}
					this.RenderMessage(message);
				}
			}
			else
			{
				Console.LogWarning("Message history null!", null);
			}
			if (data.ActiveResponses != null)
			{
				List<Response> list = new List<Response>();
				for (int j = 0; j < data.ActiveResponses.Length; j++)
				{
					list.Add(new Response(data.ActiveResponses[j].Text, data.ActiveResponses[j].Label, null, false));
				}
				if (list.Count > 0)
				{
					this.ShowResponses(list, 0f, true);
				}
			}
			else
			{
				Console.LogWarning("Message reponses null!", null);
			}
			this.RefreshPreviewText();
			this.HasChanged = false;
			bool isHidden = data.IsHidden;
			if (data.IsHidden)
			{
				this.SetEntryVisibility(false);
			}
			if (this.onLoaded != null)
			{
				this.onLoaded();
			}
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x00089344 File Offset: 0x00087544
		public void SetSliderValue(float value, Color color)
		{
			if (this.slider == null)
			{
				return;
			}
			this.slider.value = value;
			this.sliderFill.color = color;
			this.slider.gameObject.SetActive(value > 0f);
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x00089390 File Offset: 0x00087590
		public Response GetResponse(string label)
		{
			return this.currentResponses.Find((Response x) => x.label == label);
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x000893C4 File Offset: 0x000875C4
		public void ShowResponses(List<Response> _responses, float showResponseDelay = 0f, bool network = true)
		{
			MSGConversation.<>c__DisplayClass89_0 CS$<>8__locals1 = new MSGConversation.<>c__DisplayClass89_0();
			CS$<>8__locals1.showResponseDelay = showResponseDelay;
			CS$<>8__locals1.<>4__this = this;
			if (network)
			{
				NetworkSingleton<MessagingManager>.Instance.ShowResponses(this.sender.ID, _responses, CS$<>8__locals1.showResponseDelay);
				return;
			}
			this.EnsureUIExists();
			this.currentResponses = _responses;
			this.ClearResponseUI();
			for (int i = 0; i < _responses.Count; i++)
			{
				this.CreateResponseUI(_responses[i]);
			}
			if (CS$<>8__locals1.showResponseDelay == 0f)
			{
				this.SetResponseContainerVisible(true);
			}
			else
			{
				Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<ShowResponses>g__Routine|0());
			}
			this.HasChanged = true;
			if (this.onResponsesShown != null)
			{
				this.onResponsesShown();
			}
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00089478 File Offset: 0x00087678
		protected void CreateResponseUI(Response r)
		{
			this.EnsureUIExists();
			MessageBubble component = Object.Instantiate<GameObject>(PlayerSingleton<MessagesApp>.Instance.messageBubblePrefab, this.responseContainer).GetComponent<MessageBubble>();
			float num = 5f;
			float num2 = 25f;
			component.bubble_MinWidth = this.responseContainer.rect.width - num2 * 2f;
			component.bubble_MaxWidth = this.responseContainer.rect.width - num2 * 2f;
			component.autosetPosition = false;
			component.SetupBubble(r.text, MessageBubble.Alignment.Center, true);
			float num3 = num2;
			for (int i = 0; i < this.responseRects.Count; i++)
			{
				num3 += this.responseRects[i].gameObject.GetComponent<MessageBubble>().height;
				num3 += num;
			}
			component.container.anchoredPosition = new Vector2(0f, -num3 - 35f);
			this.responseRects.Add(component.container);
			component.button.interactable = true;
			bool network = !r.disableDefaultResponseBehaviour;
			component.button.onClick.AddListener(new UnityAction(delegate()
			{
				this.ResponseChosen(r, network);
			}));
			this.responseContainer.sizeDelta = new Vector2(this.responseContainer.sizeDelta.x, num3 + component.height + num2);
			this.responseContainer.anchoredPosition = new Vector2(0f, this.responseContainer.sizeDelta.y / 2f);
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x0008962C File Offset: 0x0008782C
		private void RefreshResponseContainer()
		{
			for (int i = 0; i < this.responseRects.Count; i++)
			{
				this.responseRects[i].gameObject.GetComponent<MessageBubble>().RefreshDisplayedText();
			}
			float num = 5f;
			float num2 = 25f;
			float num3 = num2;
			for (int j = 0; j < this.responseRects.Count; j++)
			{
				num3 += this.responseRects[j].gameObject.GetComponent<MessageBubble>().height;
				num3 += num;
			}
			this.responseContainer.sizeDelta = new Vector2(this.responseContainer.sizeDelta.x, num3 + num2);
			this.responseContainer.anchoredPosition = new Vector2(0f, this.responseContainer.sizeDelta.y / 2f);
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x00089704 File Offset: 0x00087904
		protected void ClearResponseUI()
		{
			for (int i = 0; i < this.responseRects.Count; i++)
			{
				Object.Destroy(this.responseRects[i].gameObject);
			}
			this.responseRects.Clear();
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00089748 File Offset: 0x00087948
		public void SetResponseContainerVisible(bool v)
		{
			if (v)
			{
				this.scrollRectContainer.offsetMin = new Vector2(0f, this.responseContainer.sizeDelta.y);
			}
			else
			{
				this.scrollRectContainer.offsetMin = new Vector2(0f, 0f);
			}
			this.responseContainer.gameObject.SetActive(v);
			this.bubbleContainer.anchoredPosition = new Vector2(this.bubbleContainer.anchoredPosition.x, Mathf.Clamp(this.bubbleContainer.anchoredPosition.y, 1100f, float.MaxValue));
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x000897EC File Offset: 0x000879EC
		public void ResponseChosen(Response r, bool network)
		{
			if (!this.AreResponsesActive)
			{
				return;
			}
			if (r.disableDefaultResponseBehaviour)
			{
				if (r.callback != null)
				{
					r.callback();
				}
				return;
			}
			if (network)
			{
				NetworkSingleton<MessagingManager>.Instance.SendResponse(this.currentResponses.IndexOf(r), this.sender.ID);
				return;
			}
			this.ClearResponses(false);
			this.RenderMessage(new Message(r.text, Message.ESenderType.Player, true, -1));
			this.HasChanged = true;
			this.MoveToTop();
			if (r.callback != null)
			{
				r.callback();
			}
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x0008987E File Offset: 0x00087A7E
		public void ClearResponses(bool network = false)
		{
			this.ClearResponseUI();
			this.SetResponseContainerVisible(false);
			this.currentResponses.Clear();
			if (network)
			{
				NetworkSingleton<MessagingManager>.Instance.ClearResponses(this.sender.ID);
			}
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x000898B0 File Offset: 0x00087AB0
		public SendableMessage CreateSendableMessage(string text)
		{
			SendableMessage sendableMessage = new SendableMessage(text, this);
			this.Sendables.Add(sendableMessage);
			if (this.uiCreated)
			{
				this.senderInterface.AddSendable(sendableMessage);
			}
			return sendableMessage;
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x000898E6 File Offset: 0x00087AE6
		public void SendPlayerMessage(int sendableIndex, int sentIndex, bool network)
		{
			if (network)
			{
				NetworkSingleton<MessagingManager>.Instance.SendPlayerMessage(sendableIndex, sentIndex, this.sender.ID);
				return;
			}
			this.Sendables[sendableIndex].Send(false, sentIndex);
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x00089918 File Offset: 0x00087B18
		public void RenderPlayerMessage(SendableMessage sendable)
		{
			Message m = new Message(sendable.Text, Message.ESenderType.Player, true, -1);
			this.RenderMessage(m);
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x0008993B File Offset: 0x00087B3B
		private void CheckSendLoop()
		{
			this.CanSendNewMessage();
			PlayerSingleton<MessagesApp>.Instance.StartCoroutine(this.<CheckSendLoop>g__Loop|99_0());
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x00089958 File Offset: 0x00087B58
		private bool CanSendNewMessage()
		{
			if (this.rollingOut)
			{
				return false;
			}
			if (this.AreResponsesActive)
			{
				return false;
			}
			return this.Sendables.FirstOrDefault((SendableMessage x) => x.ShouldShow()) != null;
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x000899B1 File Offset: 0x00087BB1
		[CompilerGenerated]
		private IEnumerator <CheckSendLoop>g__Loop|99_0()
		{
			while (this.isOpen)
			{
				if (this.CanSendNewMessage())
				{
					if (this.senderInterface.Visibility == MessageSenderInterface.EVisibility.Hidden)
					{
						this.senderInterface.SetVisibility(MessageSenderInterface.EVisibility.Docked);
					}
				}
				else if (this.senderInterface.Visibility != MessageSenderInterface.EVisibility.Hidden)
				{
					this.senderInterface.SetVisibility(MessageSenderInterface.EVisibility.Hidden);
				}
				this.scrollRect.GetComponent<RectTransform>().offsetMin = new Vector2(0f, (this.senderInterface.Visibility == MessageSenderInterface.EVisibility.Docked) ? 200f : 0f);
				yield return new WaitForEndOfFrame();
			}
			this.senderInterface.SetVisibility(MessageSenderInterface.EVisibility.Hidden);
			this.scrollRect.GetComponent<RectTransform>().offsetMin = new Vector2(0f, 0f);
			yield break;
		}

		// Token: 0x04001966 RID: 6502
		public const int MAX_MESSAGE_HISTORY = 10;

		// Token: 0x04001967 RID: 6503
		public string contactName = string.Empty;

		// Token: 0x04001968 RID: 6504
		public NPC sender;

		// Token: 0x0400196A RID: 6506
		public List<Message> messageHistory = new List<Message>();

		// Token: 0x0400196B RID: 6507
		public List<MessageChain> messageChainHistory = new List<MessageChain>();

		// Token: 0x0400196C RID: 6508
		public List<MessageBubble> bubbles = new List<MessageBubble>();

		// Token: 0x0400196D RID: 6509
		public List<SendableMessage> Sendables = new List<SendableMessage>();

		// Token: 0x0400196E RID: 6510
		public bool read = true;

		// Token: 0x04001973 RID: 6515
		public List<EConversationCategory> Categories = new List<EConversationCategory>();

		// Token: 0x04001974 RID: 6516
		public RectTransform entry;

		// Token: 0x04001975 RID: 6517
		protected RectTransform container;

		// Token: 0x04001976 RID: 6518
		protected RectTransform bubbleContainer;

		// Token: 0x04001977 RID: 6519
		protected RectTransform scrollRectContainer;

		// Token: 0x04001978 RID: 6520
		protected ScrollRect scrollRect;

		// Token: 0x04001979 RID: 6521
		protected Text entryPreviewText;

		// Token: 0x0400197A RID: 6522
		protected RectTransform unreadDot;

		// Token: 0x0400197B RID: 6523
		protected Slider slider;

		// Token: 0x0400197C RID: 6524
		protected Image sliderFill;

		// Token: 0x0400197D RID: 6525
		protected RectTransform responseContainer;

		// Token: 0x0400197E RID: 6526
		protected MessageSenderInterface senderInterface;

		// Token: 0x0400197F RID: 6527
		private bool uiCreated;

		// Token: 0x04001980 RID: 6528
		public Action onMessageRendered;

		// Token: 0x04001981 RID: 6529
		public Action onLoaded;

		// Token: 0x04001982 RID: 6530
		public Action onResponsesShown;

		// Token: 0x04001983 RID: 6531
		public List<Response> currentResponses = new List<Response>();

		// Token: 0x04001984 RID: 6532
		private List<RectTransform> responseRects = new List<RectTransform>();
	}
}
