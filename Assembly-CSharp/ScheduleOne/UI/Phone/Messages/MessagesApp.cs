using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Messaging;
using ScheduleOne.Persistence;
using ScheduleOne.UI.Tooltips;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Messages
{
	// Token: 0x02000AC3 RID: 2755
	public class MessagesApp : App<MessagesApp>
	{
		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06004A1A RID: 18970 RVA: 0x00136C4A File Offset: 0x00134E4A
		// (set) Token: 0x06004A1B RID: 18971 RVA: 0x00136C52 File Offset: 0x00134E52
		public MSGConversation currentConversation { get; private set; }

		// Token: 0x06004A1C RID: 18972 RVA: 0x00136C5C File Offset: 0x00134E5C
		protected override void Start()
		{
			base.Start();
			Singleton<LoadManager>.Instance.onLoadComplete.RemoveListener(new UnityAction(this.Loaded));
			Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(this.Loaded));
			Singleton<LoadManager>.Instance.onPreSceneChange.RemoveListener(new UnityAction(this.Clean));
			Singleton<LoadManager>.Instance.onPreSceneChange.AddListener(new UnityAction(this.Clean));
			this.dialoguePage.gameObject.SetActive(false);
		}

		// Token: 0x06004A1D RID: 18973 RVA: 0x00136CEC File Offset: 0x00134EEC
		protected override void Update()
		{
			base.Update();
		}

		// Token: 0x06004A1E RID: 18974 RVA: 0x00136CF4 File Offset: 0x00134EF4
		private void Loaded()
		{
			MessagesApp.ActiveConversations = (from x in MessagesApp.ActiveConversations
			orderby x.index
			select x).ToList<MSGConversation>();
			this.RepositionEntries();
		}

		// Token: 0x06004A1F RID: 18975 RVA: 0x00136D2F File Offset: 0x00134F2F
		private void Clean()
		{
			MessagesApp.Conversations.Clear();
			MessagesApp.ActiveConversations.Clear();
		}

		// Token: 0x06004A20 RID: 18976 RVA: 0x00136D48 File Offset: 0x00134F48
		public void CreateConversationUI(MSGConversation c, out RectTransform entry, out RectTransform container)
		{
			entry = Object.Instantiate<GameObject>(this.conversationEntryPrefab, this.conversationEntryContainer).GetComponent<RectTransform>();
			entry.Find("Name").GetComponent<Text>().text = (c.IsSenderKnown ? c.contactName : "Unknown");
			entry.Find("IconMask/Icon").GetComponent<Image>().sprite = (c.IsSenderKnown ? c.sender.MugshotSprite : this.BlankAvatarSprite);
			entry.SetAsLastSibling();
			if (c.Categories != null && c.Categories.Count > 0)
			{
				MessagesApp.CategoryInfo categoryInfo = this.GetCategoryInfo(c.Categories[0]);
				RectTransform component = entry.Find("Category").GetComponent<RectTransform>();
				Text component2 = component.Find("Label").GetComponent<Text>();
				component2.text = categoryInfo.Name[0].ToString();
				LayoutRebuilder.ForceRebuildLayoutImmediate(component2.rectTransform);
				component.GetComponent<Image>().color = categoryInfo.Color;
				component.anchoredPosition = new Vector2(225f + entry.Find("Name").GetComponent<Text>().preferredWidth, component.anchoredPosition.y);
				component.gameObject.SetActive(true);
			}
			else
			{
				entry.Find("Category").gameObject.SetActive(false);
			}
			container = Object.Instantiate<GameObject>(this.conversationContainerPrefab, this.conversationContainer).GetComponent<RectTransform>();
			this.RepositionEntries();
		}

		// Token: 0x06004A21 RID: 18977 RVA: 0x00136ECC File Offset: 0x001350CC
		public void RepositionEntries()
		{
			for (int i = 0; i < MessagesApp.ActiveConversations.Count; i++)
			{
				MessagesApp.ActiveConversations[i].RepositionEntry();
			}
			for (int j = 0; j < MessagesApp.ActiveConversations.Count; j++)
			{
				MessagesApp.ActiveConversations[j].RepositionEntry();
			}
		}

		// Token: 0x06004A22 RID: 18978 RVA: 0x00136F23 File Offset: 0x00135123
		public void ReturnButtonClicked()
		{
			if (this.currentConversation != null)
			{
				this.currentConversation.SetOpen(false);
			}
		}

		// Token: 0x06004A23 RID: 18979 RVA: 0x00136F39 File Offset: 0x00135139
		public void RefreshNotifications()
		{
			base.SetNotificationCount(this.unreadConversations.Count);
			Singleton<HUD>.Instance.UnreadMessagesPrompt.gameObject.SetActive(this.unreadConversations.Count > 0);
		}

		// Token: 0x06004A24 RID: 18980 RVA: 0x00136F6E File Offset: 0x0013516E
		public override void Exit(ExitAction exit)
		{
			if (!base.isOpen || exit.used)
			{
				base.Exit(exit);
				return;
			}
			if (this.currentConversation != null)
			{
				this.currentConversation.SetOpen(false);
				exit.used = true;
			}
			base.Exit(exit);
		}

		// Token: 0x06004A25 RID: 18981 RVA: 0x00136FAC File Offset: 0x001351AC
		public void SetCurrentConversation(MSGConversation conversation)
		{
			if (conversation == this.currentConversation)
			{
				return;
			}
			MSGConversation currentConversation = this.currentConversation;
			this.currentConversation = conversation;
			if (currentConversation != null)
			{
				currentConversation.SetOpen(false);
			}
		}

		// Token: 0x06004A26 RID: 18982 RVA: 0x00136FDC File Offset: 0x001351DC
		public MessagesApp.CategoryInfo GetCategoryInfo(EConversationCategory category)
		{
			return this.categoryInfos.Find((MessagesApp.CategoryInfo x) => x.Category == category);
		}

		// Token: 0x06004A27 RID: 18983 RVA: 0x00137010 File Offset: 0x00135210
		public void FilterByCategory(int category)
		{
			for (int i = 0; i < this.CategoryButtons.Length; i++)
			{
				this.CategoryButtons[i].interactable = true;
			}
			for (int j = 0; j < MessagesApp.ActiveConversations.Count; j++)
			{
				MessagesApp.ActiveConversations[j].entry.gameObject.SetActive(MessagesApp.ActiveConversations[j].Categories.Contains((EConversationCategory)category));
			}
			this.ClearFilterButton.gameObject.SetActive(true);
		}

		// Token: 0x06004A28 RID: 18984 RVA: 0x00137094 File Offset: 0x00135294
		public void ClearFilter()
		{
			for (int i = 0; i < MessagesApp.ActiveConversations.Count; i++)
			{
				MessagesApp.ActiveConversations[i].entry.gameObject.SetActive(true);
			}
			for (int j = 0; j < this.CategoryButtons.Length; j++)
			{
				this.CategoryButtons[j].interactable = true;
			}
			this.ClearFilterButton.gameObject.SetActive(false);
		}

		// Token: 0x04003747 RID: 14151
		public static List<MSGConversation> Conversations = new List<MSGConversation>();

		// Token: 0x04003748 RID: 14152
		public static List<MSGConversation> ActiveConversations = new List<MSGConversation>();

		// Token: 0x04003749 RID: 14153
		public List<MessagesApp.CategoryInfo> categoryInfos;

		// Token: 0x0400374A RID: 14154
		[Header("References")]
		[SerializeField]
		protected RectTransform conversationEntryContainer;

		// Token: 0x0400374B RID: 14155
		[SerializeField]
		protected RectTransform conversationContainer;

		// Token: 0x0400374C RID: 14156
		public GameObject homePage;

		// Token: 0x0400374D RID: 14157
		public GameObject dialoguePage;

		// Token: 0x0400374E RID: 14158
		public Text dialoguePageNameText;

		// Token: 0x0400374F RID: 14159
		public RectTransform relationshipContainer;

		// Token: 0x04003750 RID: 14160
		public Scrollbar relationshipScrollbar;

		// Token: 0x04003751 RID: 14161
		public Tooltip relationshipTooltip;

		// Token: 0x04003752 RID: 14162
		public RectTransform standardsContainer;

		// Token: 0x04003753 RID: 14163
		public Image standardsStar;

		// Token: 0x04003754 RID: 14164
		public Tooltip standardsTooltip;

		// Token: 0x04003755 RID: 14165
		public RectTransform iconContainerRect;

		// Token: 0x04003756 RID: 14166
		public Image iconImage;

		// Token: 0x04003757 RID: 14167
		public Sprite BlankAvatarSprite;

		// Token: 0x04003758 RID: 14168
		public DealWindowSelector DealWindowSelector;

		// Token: 0x04003759 RID: 14169
		public PhoneShopInterface PhoneShopInterface;

		// Token: 0x0400375A RID: 14170
		public CounterofferInterface CounterofferInterface;

		// Token: 0x0400375B RID: 14171
		public RectTransform ClearFilterButton;

		// Token: 0x0400375C RID: 14172
		public Button[] CategoryButtons;

		// Token: 0x0400375D RID: 14173
		public AudioSourceController MessageReceivedSound;

		// Token: 0x0400375E RID: 14174
		public AudioSourceController MessageSentSound;

		// Token: 0x0400375F RID: 14175
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject conversationEntryPrefab;

		// Token: 0x04003760 RID: 14176
		[SerializeField]
		protected GameObject conversationContainerPrefab;

		// Token: 0x04003761 RID: 14177
		public GameObject messageBubblePrefab;

		// Token: 0x04003762 RID: 14178
		public List<MSGConversation> unreadConversations = new List<MSGConversation>();

		// Token: 0x02000AC4 RID: 2756
		[Serializable]
		public class CategoryInfo
		{
			// Token: 0x04003764 RID: 14180
			public EConversationCategory Category;

			// Token: 0x04003765 RID: 14181
			public string Name;

			// Token: 0x04003766 RID: 14182
			public Color Color;
		}
	}
}
