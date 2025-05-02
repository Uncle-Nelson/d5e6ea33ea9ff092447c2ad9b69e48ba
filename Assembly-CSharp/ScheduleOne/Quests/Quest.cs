using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Levelling;
using ScheduleOne.Map;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using ScheduleOne.UI.Compass;
using ScheduleOne.UI.Phone;
using ScheduleOne.UI.Phone.Map;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.Quests
{
	// Token: 0x020002DB RID: 731
	[Serializable]
	public class Quest : MonoBehaviour, IGUIDRegisterable, ISaveable
	{
		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x00046C39 File Offset: 0x00044E39
		// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x00046C41 File Offset: 0x00044E41
		public EQuestState QuestState { get; protected set; }

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x00046C4A File Offset: 0x00044E4A
		// (set) Token: 0x06000FDB RID: 4059 RVA: 0x00046C52 File Offset: 0x00044E52
		public Guid GUID { get; protected set; }

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00046C5B File Offset: 0x00044E5B
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x00046C63 File Offset: 0x00044E63
		public bool IsTracked { get; protected set; }

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x00046C6C File Offset: 0x00044E6C
		public int ActiveEntryCount
		{
			get
			{
				return this.Entries.Count((QuestEntry x) => x.State == EQuestState.Active);
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x00046C98 File Offset: 0x00044E98
		public string Title
		{
			get
			{
				return this.GetQuestTitle();
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x00046CA0 File Offset: 0x00044EA0
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x00046CA8 File Offset: 0x00044EA8
		public bool Expires { get; protected set; }

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00046CB1 File Offset: 0x00044EB1
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x00046CB9 File Offset: 0x00044EB9
		public GameDateTime Expiry { get; protected set; }

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00046CC2 File Offset: 0x00044EC2
		public bool hudUIExists
		{
			get
			{
				return this.hudUI != null;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x00046CD0 File Offset: 0x00044ED0
		// (set) Token: 0x06000FE6 RID: 4070 RVA: 0x00046CD8 File Offset: 0x00044ED8
		public QuestHUDUI hudUI { get; private set; }

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x00046CE4 File Offset: 0x00044EE4
		public string SaveFolderName
		{
			get
			{
				return "Quest_" + this.GUID.ToString().Substring(0, 6);
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x00046D18 File Offset: 0x00044F18
		public string SaveFileName
		{
			get
			{
				return "Quest_" + this.GUID.ToString().Substring(0, 6);
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x00046D4A File Offset: 0x00044F4A
		public Loader Loader
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x000141BA File Offset: 0x000123BA
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x00046D4D File Offset: 0x00044F4D
		// (set) Token: 0x06000FEC RID: 4076 RVA: 0x00046D55 File Offset: 0x00044F55
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000FED RID: 4077 RVA: 0x00046D5E File Offset: 0x00044F5E
		// (set) Token: 0x06000FEE RID: 4078 RVA: 0x00046D66 File Offset: 0x00044F66
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000FEF RID: 4079 RVA: 0x00046D6F File Offset: 0x00044F6F
		// (set) Token: 0x06000FF0 RID: 4080 RVA: 0x00046D77 File Offset: 0x00044F77
		public bool HasChanged { get; set; }

		// Token: 0x06000FF1 RID: 4081 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void Awake()
		{
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x00046D80 File Offset: 0x00044F80
		protected virtual void Start()
		{
			if (this.autoInitialize)
			{
				if (Player.Local != null)
				{
					this.<Start>g__Initialize|88_0();
				}
				else
				{
					Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(this.<Start>g__Initialize|88_0));
				}
			}
			if (this.AutoCompleteOnAllEntriesComplete)
			{
				for (int i = 0; i < this.Entries.Count; i++)
				{
					this.Entries[i].onComplete.AddListener(new UnityAction(this.CheckAutoComplete));
				}
			}
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00046E0C File Offset: 0x0004500C
		public virtual void InitializeQuest(string title, string description, QuestEntryData[] entries, string guid)
		{
			if (guid == string.Empty)
			{
				guid = Guid.NewGuid().ToString();
			}
			if (entries.Length == 0 && this.Entries.Count == 0)
			{
				Console.LogWarning(title + " quest has no entries!", null);
			}
			base.gameObject.name = title;
			for (int i = 0; i < entries.Length; i++)
			{
				GameObject gameObject = new GameObject(entries[i].Name);
				gameObject.transform.SetParent(base.transform);
				QuestEntry questEntry = gameObject.AddComponent<QuestEntry>();
				this.Entries.Add(questEntry);
				questEntry.SetData(entries[i]);
			}
			this.GUID = new Guid(guid);
			GUIDManager.RegisterObject(this);
			this.title = title;
			this.Description = description;
			this.HasChanged = true;
			Quest.Quests.Add(this);
			this.InitializeSaveable();
			this.SetupJournalEntry();
			this.SetupHudUI();
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00046F1E File Offset: 0x0004511E
		public void ConfigureExpiry(bool expires, GameDateTime expiry)
		{
			this.Expires = expires;
			this.Expiry = expiry;
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00046F30 File Offset: 0x00045130
		public virtual void Begin(bool network = true)
		{
			if (this.QuestState == EQuestState.Active)
			{
				return;
			}
			this.SetQuestState(EQuestState.Active, false);
			if (this.AutoStartFirstEntry && this.Entries.Count > 0)
			{
				this.Entries[0].SetState(EQuestState.Active, network);
			}
			if (this.TrackOnBegin)
			{
				this.SetIsTracked(true);
			}
			this.UpdateHUDUI();
			if (network)
			{
				NetworkSingleton<QuestManager>.Instance.SendQuestAction(this.GUID.ToString(), QuestManager.EQuestAction.Begin);
			}
			if (this.onQuestBegin != null)
			{
				this.onQuestBegin.Invoke();
			}
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00046FC4 File Offset: 0x000451C4
		public virtual void Complete(bool network = true)
		{
			if (this.QuestState == EQuestState.Completed)
			{
				return;
			}
			int num = 2;
			if (this.CompletionXP > 0 && InstanceFinder.IsServer && !Singleton<LoadManager>.Instance.IsLoading)
			{
				Console.Log("Adding XP for quest: " + this.Title, null);
				NetworkSingleton<LevelManager>.Instance.AddXP(this.CompletionXP);
			}
			this.SetQuestState(EQuestState.Completed, false);
			if (this.PlayQuestCompleteSound)
			{
				NetworkSingleton<QuestManager>.Instance.PlayCompleteQuestSound();
			}
			this.End();
			if (network)
			{
				NetworkSingleton<QuestManager>.Instance.SendQuestAction(this.GUID.ToString(), QuestManager.EQuestAction.Success);
			}
			if (this.onComplete != null)
			{
				this.onComplete.Invoke();
			}
			if (num != 2 && !Singleton<LoadManager>.Instance.IsLoading && this.onInitialComplete != null)
			{
				this.onInitialComplete.Invoke();
			}
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00047098 File Offset: 0x00045298
		public virtual void Fail(bool network = true)
		{
			this.SetQuestState(EQuestState.Failed, false);
			this.End();
			if (network)
			{
				NetworkSingleton<QuestManager>.Instance.SendQuestAction(this.GUID.ToString(), QuestManager.EQuestAction.Fail);
			}
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x000470D8 File Offset: 0x000452D8
		public virtual void Expire(bool network = true)
		{
			if (this.QuestState == EQuestState.Expired)
			{
				return;
			}
			this.SetQuestState(EQuestState.Expired, false);
			if (this.ShouldSendExpiredNotification)
			{
				this.SendExpiredNotification();
			}
			this.End();
			if (network)
			{
				NetworkSingleton<QuestManager>.Instance.SendQuestAction(this.GUID.ToString(), QuestManager.EQuestAction.Expire);
			}
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00047130 File Offset: 0x00045330
		public virtual void Cancel(bool network = true)
		{
			this.SetQuestState(EQuestState.Cancelled, false);
			this.End();
			if (network)
			{
				NetworkSingleton<QuestManager>.Instance.SendQuestAction(this.GUID.ToString(), QuestManager.EQuestAction.Cancel);
			}
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00047170 File Offset: 0x00045370
		public virtual void End()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			Quest.ActiveQuests.Remove(this);
			this.DestroyDetailDisplay();
			this.DestroyJournalEntry();
			if (this.onQuestEnd != null)
			{
				this.onQuestEnd.Invoke(this.QuestState);
			}
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x000471D8 File Offset: 0x000453D8
		public virtual void SetQuestState(EQuestState state, bool network = true)
		{
			this.QuestState = state;
			this.HasChanged = true;
			StateMachine.ChangeState();
			if (this.hudUI != null)
			{
				this.hudUI.gameObject.SetActive(this.IsTracked && (this.QuestState == EQuestState.Active || this.QuestState == EQuestState.Completed));
			}
			if (this.journalEntry != null)
			{
				this.journalEntry.gameObject.SetActive(this.ShouldShowJournalEntry());
			}
			for (int i = 0; i < this.Entries.Count; i++)
			{
				this.Entries[i].UpdateCompassElement();
			}
			if (state == EQuestState.Active && this.onActiveState != null)
			{
				this.onActiveState.Invoke();
			}
			if (network)
			{
				NetworkSingleton<QuestManager>.Instance.SendQuestState(this.GUID.ToString(), state);
			}
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x000472BA File Offset: 0x000454BA
		protected virtual bool ShouldShowJournalEntry()
		{
			return this.QuestState == EQuestState.Active;
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x000472C8 File Offset: 0x000454C8
		public virtual void SetQuestEntryState(int entryIndex, EQuestState state, bool network = true)
		{
			if (entryIndex < 0 || entryIndex >= this.Entries.Count)
			{
				Console.LogWarning("Invalid entry index: " + entryIndex.ToString(), null);
				return;
			}
			this.HasChanged = true;
			this.Entries[entryIndex].SetState(state, network);
			if (state == EQuestState.Completed)
			{
				this.BopHUDUI();
			}
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00047324 File Offset: 0x00045524
		protected virtual void MinPass()
		{
			if (this.Expires)
			{
				bool flag = this.GetMinsUntilExpiry() <= 120;
				if (this.entryTimeLabel != null)
				{
					this.entryTimeLabel.text = this.GetExpiryText();
				}
				if (this.criticalTimeBackground != null)
				{
					this.criticalTimeBackground.enabled = flag;
				}
				this.UpdateHUDUI();
				this.CheckExpiry();
				if (this.ShouldSendExpiryReminder && flag && !this.expiryReminderSent)
				{
					this.SendExpiryReminder();
					this.expiryReminderSent = true;
				}
			}
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x000473AB File Offset: 0x000455AB
		protected virtual void CheckExpiry()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.Expires)
			{
				return;
			}
			if (this.GetMinsUntilExpiry() <= 0 && this.CanExpire())
			{
				this.Expire(true);
			}
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x000473D8 File Offset: 0x000455D8
		private void CheckAutoComplete()
		{
			bool flag = true;
			for (int i = 0; i < this.Entries.Count; i++)
			{
				if (this.Entries[i].State != EQuestState.Completed)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				this.Complete(true);
			}
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x000022C9 File Offset: 0x000004C9
		protected virtual bool CanExpire()
		{
			return true;
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0004741F File Offset: 0x0004561F
		protected virtual void SendExpiryReminder()
		{
			Singleton<NotificationsManager>.Instance.SendNotification("<color=#FFB43C>Quest Expiring Soon</color>", this.title, PlayerSingleton<JournalApp>.Instance.AppIcon, 5f, true);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00047446 File Offset: 0x00045646
		protected virtual void SendExpiredNotification()
		{
			Singleton<NotificationsManager>.Instance.SendNotification("<color=#FF6455>Quest Expired</color>", this.title, PlayerSingleton<JournalApp>.Instance.AppIcon, 5f, true);
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0004746D File Offset: 0x0004566D
		public void SetGUID(Guid guid)
		{
			this.GUID = guid;
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0004747C File Offset: 0x0004567C
		public void SetSubtitle(string subtitle)
		{
			this.Subtitle = subtitle;
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00047488 File Offset: 0x00045688
		public virtual void SetIsTracked(bool tracked)
		{
			this.IsTracked = tracked;
			if (this.hudUI != null)
			{
				this.hudUI.gameObject.SetActive(tracked && this.QuestState == EQuestState.Active);
			}
			if (this.journalEntry != null)
			{
				this.trackedRect.gameObject.SetActive(tracked);
				this.journalEntry.GetComponent<Image>().color = (this.IsTracked ? new Color32(75, 75, 75, byte.MaxValue) : new Color32(150, 150, 150, byte.MaxValue));
			}
			this.HasChanged = true;
			for (int i = 0; i < this.Entries.Count; i++)
			{
				this.Entries[i].UpdateCompassElement();
			}
			if (this.onTrackChange != null)
			{
				this.onTrackChange.Invoke(tracked);
			}
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00047574 File Offset: 0x00045774
		public virtual void SetupJournalEntry()
		{
			this.journalEntry = Object.Instantiate<GameObject>(PlayerSingleton<JournalApp>.Instance.GenericEntry, PlayerSingleton<JournalApp>.Instance.EntryContainer).GetComponent<RectTransform>();
			this.journalEntry.Find("Title").GetComponent<Text>().text = this.title;
			this.entryTitleRect = this.journalEntry.Find("Title").GetComponent<RectTransform>();
			this.trackedRect = this.journalEntry.Find("Tracked").GetComponent<RectTransform>();
			this.SetIsTracked(this.IsTracked);
			this.journalEntry.Find("Expiry").gameObject.SetActive(this.Expires);
			this.entryTimeLabel = this.journalEntry.Find("Expiry/Time").GetComponent<Text>();
			this.criticalTimeBackground = this.journalEntry.Find("Expiry/Critical").GetComponent<Image>();
			this.journalEntry.GetComponent<Button>().onClick.AddListener(new UnityAction(this.JournalEntryClicked));
			EventTrigger component = this.journalEntry.GetComponent<EventTrigger>();
			EventTrigger.Entry entry = new EventTrigger.Entry();
			entry.eventID = 0;
			entry.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData data)
			{
				this.JournalEntryHoverStart();
			}));
			component.triggers.Add(entry);
			Object.Instantiate<RectTransform>(this.IconPrefab, this.journalEntry.Find("IconContainer")).GetComponent<RectTransform>().sizeDelta = new Vector2(25f, 25f);
			this.journalEntry.gameObject.SetActive(false);
			if (this.Expires)
			{
				this.entryTimeLabel.text = this.GetExpiryText();
			}
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00047716 File Offset: 0x00045916
		private void DestroyJournalEntry()
		{
			if (this.journalEntry == null)
			{
				return;
			}
			Object.Destroy(this.journalEntry.gameObject);
			this.journalEntry = null;
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0004773E File Offset: 0x0004593E
		private void JournalEntryClicked()
		{
			this.SetIsTracked(!this.IsTracked);
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0004774F File Offset: 0x0004594F
		private void JournalEntryHoverStart()
		{
			Quest.HoveredQuest = this;
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x00047758 File Offset: 0x00045958
		public int GetMinsUntilExpiry()
		{
			int totalMinSum = NetworkSingleton<TimeManager>.Instance.GetTotalMinSum();
			int num = this.Expiry.GetMinSum() - totalMinSum;
			if (num > 0)
			{
				return num;
			}
			return 0;
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00047788 File Offset: 0x00045988
		public string GetExpiryText()
		{
			int minsUntilExpiry = this.GetMinsUntilExpiry();
			if (minsUntilExpiry >= 60)
			{
				return Mathf.RoundToInt((float)minsUntilExpiry / 60f).ToString() + " hrs";
			}
			return minsUntilExpiry.ToString() + " min";
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x000477D4 File Offset: 0x000459D4
		public virtual QuestHUDUI SetupHudUI()
		{
			if (this.hudUI != null)
			{
				return this.hudUI;
			}
			this.hudUI = Object.Instantiate<QuestHUDUI>(PlayerSingleton<JournalApp>.Instance.QuestHUDUIPrefab, Singleton<HUD>.Instance.QuestEntryContainer).GetComponent<QuestHUDUI>();
			this.hudUI.Initialize(this);
			if (this.onHudUICreated != null)
			{
				this.onHudUICreated();
			}
			this.hudUI.gameObject.SetActive(this.IsTracked && this.QuestState == EQuestState.Active);
			return this.hudUI;
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00047863 File Offset: 0x00045A63
		public void UpdateHUDUI()
		{
			QuestHUDUI hudUI = this.hudUI;
			if (hudUI == null)
			{
				return;
			}
			hudUI.UpdateUI();
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x00047875 File Offset: 0x00045A75
		public void BopHUDUI()
		{
			if (this.hudUI == null)
			{
				return;
			}
			this.hudUI.BopIcon();
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00047891 File Offset: 0x00045A91
		public virtual string GetQuestTitle()
		{
			return this.title;
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0004789C File Offset: 0x00045A9C
		public QuestEntry GetFirstActiveEntry()
		{
			for (int i = 0; i < this.Entries.Count; i++)
			{
				if (this.Entries[i].State == EQuestState.Active)
				{
					return this.Entries[i];
				}
			}
			return null;
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x000478E1 File Offset: 0x00045AE1
		private void DestroyHudUI()
		{
			if (this.hudUI != null)
			{
				Object.Destroy(this.hudUI.gameObject);
			}
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00047904 File Offset: 0x00045B04
		public virtual RectTransform CreateDetailDisplay(RectTransform parent)
		{
			if (this.detailPanel != null)
			{
				Console.LogWarning("Detail panel already exists!", null);
				return null;
			}
			if (!PlayerSingleton<JournalApp>.InstanceExists)
			{
				Console.LogWarning("Journal app does not exist!", null);
				return null;
			}
			this.detailPanel = Object.Instantiate<GameObject>(PlayerSingleton<JournalApp>.Instance.GenericDetailsPanel, parent).GetComponent<RectTransform>();
			this.detailPanel.Find("Title").GetComponent<Text>().text = this.title;
			this.detailPanel.Find("Description").GetComponent<Text>().text = this.Description;
			float preferredHeight = this.detailPanel.Find("Description").GetComponent<Text>().preferredHeight;
			this.detailPanel.Find("OuterContainer").GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, -45f - preferredHeight);
			RectTransform component = this.detailPanel.Find("OuterContainer/Entries").GetComponent<RectTransform>();
			int num = 0;
			for (int i = 0; i < this.Entries.Count; i++)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(PlayerSingleton<JournalApp>.Instance.GenericQuestEntry, component).gameObject;
				gameObject.transform.Find("Title").GetComponent<Text>().text = this.Entries[i].Title;
				gameObject.transform.Find("State").GetComponent<Text>().text = this.Entries[i].State.ToString();
				gameObject.transform.Find("State").GetComponent<Text>().color = ((this.Entries[i].State == EQuestState.Active) ? new Color32(50, 50, 50, byte.MaxValue) : new Color32(150, 150, 150, byte.MaxValue));
				gameObject.gameObject.SetActive(this.Entries[i].State > EQuestState.Inactive);
				if (gameObject.gameObject.activeSelf)
				{
					num++;
				}
			}
			this.detailPanel.Find("OuterContainer/Contents").GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, -40f - (float)num * 35f);
			POI x = null;
			QuestEntry firstActiveEntry = this.GetFirstActiveEntry();
			if (firstActiveEntry != null)
			{
				x = firstActiveEntry.PoI;
			}
			GameObject gameObject2 = this.detailPanel.Find("OuterContainer/Contents/ShowOnMap").gameObject;
			gameObject2.SetActive(x != null && !GameManager.IS_TUTORIAL);
			gameObject2.GetComponent<Button>().onClick.AddListener(new UnityAction(this.<CreateDetailDisplay>g__ShowOnMap|122_0));
			return this.detailPanel;
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00047BC2 File Offset: 0x00045DC2
		public void DestroyDetailDisplay()
		{
			if (this.detailPanel != null)
			{
				Object.Destroy(this.detailPanel.gameObject);
			}
			this.detailPanel = null;
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00047BEC File Offset: 0x00045DEC
		public virtual string GetSaveString()
		{
			List<QuestEntryData> list = new List<QuestEntryData>();
			for (int i = 0; i < this.Entries.Count; i++)
			{
				list.Add(this.Entries[i].GetSaveData());
			}
			return new QuestData(this.GUID.ToString(), this.QuestState, this.IsTracked, this.title, this.Description, this.Expires, new GameDateTimeData(this.Expiry), list.ToArray()).GetJson(true);
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00047C7C File Offset: 0x00045E7C
		public virtual void Load(QuestData data)
		{
			this.SetQuestState(data.State, true);
			if (data.IsTracked)
			{
				this.SetIsTracked(true);
			}
			for (int i = 0; i < data.Entries.Length; i++)
			{
				int num = i;
				float versionNumber = SaveManager.GetVersionNumber(data.GameVersion);
				if (SaveManager.GetVersionNumber(Application.version) > versionNumber)
				{
					int num2 = i;
					int num3 = 0;
					while (num3 < num2 && num3 < this.Entries.Count)
					{
						if (SaveManager.GetVersionNumber(this.Entries[num3].EntryAddedIn) > versionNumber)
						{
							Console.Log("Increasing index for quest entry: " + this.Entries[num3].Title, null);
							num++;
							num2++;
						}
						num3++;
					}
				}
				this.SetQuestEntryState(num, data.Entries[i].State, true);
			}
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00047D54 File Offset: 0x00045F54
		public static Quest GetQuest(string questName)
		{
			return Quest.Quests.FirstOrDefault((Quest x) => x.title.ToLower() == questName.ToLower());
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00047E24 File Offset: 0x00046024
		[CompilerGenerated]
		private void <Start>g__Initialize|88_0()
		{
			Player.onLocalPlayerSpawned = (Action)Delegate.Remove(Player.onLocalPlayerSpawned, new Action(this.<Start>g__Initialize|88_0));
			if (!GUIDManager.IsGUIDValid(this.StaticGUID))
			{
				Console.LogWarning("Invalid GUID for quest: " + this.title + " Generating random GUID", null);
				this.StaticGUID = GUIDManager.GenerateUniqueGUID().ToString();
			}
			QuestEntryData[] entries = new QuestEntryData[0];
			this.InitializeQuest(this.title, this.Description, entries, this.StaticGUID);
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00047EBC File Offset: 0x000460BC
		[CompilerGenerated]
		private void <CreateDetailDisplay>g__ShowOnMap|122_0()
		{
			POI poi = null;
			QuestEntry firstActiveEntry = this.GetFirstActiveEntry();
			if (firstActiveEntry != null)
			{
				poi = firstActiveEntry.PoI;
			}
			if (poi != null && poi.UI != null && PlayerSingleton<MapApp>.InstanceExists && PlayerSingleton<JournalApp>.InstanceExists)
			{
				PlayerSingleton<MapApp>.Instance.FocusPosition(poi.UI.anchoredPosition);
				PlayerSingleton<JournalApp>.Instance.SetOpen(false);
				PlayerSingleton<MapApp>.Instance.SkipFocusPlayer = true;
				PlayerSingleton<MapApp>.Instance.SetOpen(true);
			}
		}

		// Token: 0x04001083 RID: 4227
		public const int MAX_HUD_ENTRY_LABELS = 10;

		// Token: 0x04001084 RID: 4228
		public const int CriticalExpiryThreshold = 120;

		// Token: 0x04001085 RID: 4229
		public static List<Quest> Quests = new List<Quest>();

		// Token: 0x04001086 RID: 4230
		public static Quest HoveredQuest = null;

		// Token: 0x04001087 RID: 4231
		public static List<Quest> ActiveQuests = new List<Quest>();

		// Token: 0x0400108B RID: 4235
		[Header("Basic Settings")]
		[SerializeField]
		protected string title = string.Empty;

		// Token: 0x0400108C RID: 4236
		public string Subtitle = string.Empty;

		// Token: 0x0400108D RID: 4237
		public Action onSubtitleChanged;

		// Token: 0x0400108E RID: 4238
		[TextArea(3, 10)]
		public string Description = string.Empty;

		// Token: 0x0400108F RID: 4239
		public string StaticGUID = string.Empty;

		// Token: 0x04001090 RID: 4240
		public bool TrackOnBegin;

		// Token: 0x04001091 RID: 4241
		public EExpiryVisibility ExpiryVisibility;

		// Token: 0x04001092 RID: 4242
		public bool AutoCompleteOnAllEntriesComplete;

		// Token: 0x04001093 RID: 4243
		public bool PlayQuestCompleteSound = true;

		// Token: 0x04001094 RID: 4244
		public int CompletionXP;

		// Token: 0x04001097 RID: 4247
		[Header("Entries")]
		public bool AutoStartFirstEntry = true;

		// Token: 0x04001098 RID: 4248
		public List<QuestEntry> Entries = new List<QuestEntry>();

		// Token: 0x04001099 RID: 4249
		[Header("UI")]
		public RectTransform IconPrefab;

		// Token: 0x0400109A RID: 4250
		[Header("PoI Settings")]
		public GameObject PoIPrefab;

		// Token: 0x0400109B RID: 4251
		[Header("Events")]
		public UnityEvent onQuestBegin;

		// Token: 0x0400109C RID: 4252
		public UnityEvent<EQuestState> onQuestEnd;

		// Token: 0x0400109D RID: 4253
		public UnityEvent onActiveState;

		// Token: 0x0400109E RID: 4254
		public UnityEvent<bool> onTrackChange;

		// Token: 0x0400109F RID: 4255
		public UnityEvent onComplete;

		// Token: 0x040010A0 RID: 4256
		public UnityEvent onInitialComplete;

		// Token: 0x040010A1 RID: 4257
		[Header("Reminders")]
		public bool ShouldSendExpiryReminder = true;

		// Token: 0x040010A2 RID: 4258
		public bool ShouldSendExpiredNotification = true;

		// Token: 0x040010A3 RID: 4259
		protected RectTransform journalEntry;

		// Token: 0x040010A4 RID: 4260
		protected RectTransform entryTitleRect;

		// Token: 0x040010A5 RID: 4261
		protected RectTransform trackedRect;

		// Token: 0x040010A6 RID: 4262
		protected Text entryTimeLabel;

		// Token: 0x040010A7 RID: 4263
		protected Image criticalTimeBackground;

		// Token: 0x040010A8 RID: 4264
		protected RectTransform detailPanel;

		// Token: 0x040010AA RID: 4266
		public Action onHudUICreated;

		// Token: 0x040010AB RID: 4267
		private bool expiryReminderSent;

		// Token: 0x040010AC RID: 4268
		private CompassManager.Element compassElement;

		// Token: 0x040010B0 RID: 4272
		protected bool autoInitialize = true;
	}
}
