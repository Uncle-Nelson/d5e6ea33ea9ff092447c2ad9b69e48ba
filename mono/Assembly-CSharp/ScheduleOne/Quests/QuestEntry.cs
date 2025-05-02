using System;
using System.Linq;
using System.Runtime.CompilerServices;
using FishNet.Serializing.Helping;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Map;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI;
using ScheduleOne.UI.Compass;
using ScheduleOne.UI.Phone;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Quests
{
	// Token: 0x020002DE RID: 734
	[Serializable]
	public class QuestEntry : MonoBehaviour
	{
		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x00047F71 File Offset: 0x00046171
		// (set) Token: 0x06001024 RID: 4132 RVA: 0x00047F79 File Offset: 0x00046179
		[CodegenExclude]
		public Quest ParentQuest { get; private set; }

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x00047F82 File Offset: 0x00046182
		[CodegenExclude]
		public string Title
		{
			get
			{
				return this.EntryTitle;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x00047F8A File Offset: 0x0004618A
		[CodegenExclude]
		public EQuestState State
		{
			get
			{
				return this.state;
			}
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00047F94 File Offset: 0x00046194
		protected virtual void Awake()
		{
			this.ParentQuest = base.GetComponentInParent<Quest>();
			this.ParentQuest.onQuestEnd.AddListener(new UnityAction<EQuestState>(delegate(EQuestState <p0>)
			{
				this.DestroyPoI();
			}));
			this.ParentQuest.onTrackChange.AddListener(new UnityAction<bool>(delegate(bool b)
			{
				this.UpdatePoI();
			}));
			if (this.AutoComplete)
			{
				StateMachine.OnStateChange = (Action)Delegate.Combine(StateMachine.OnStateChange, new Action(this.EvaluateConditions));
			}
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x00048010 File Offset: 0x00046210
		protected virtual void Start()
		{
			if (this.AutoCreatePoI && this.PoI == null)
			{
				this.CreatePoI();
			}
			if (!this.ParentQuest.Entries.Contains(this))
			{
				Console.LogError(string.Concat(new string[]
				{
					"Parent quest '",
					this.ParentQuest.GetQuestTitle(),
					"' does not contain entry '",
					this.EntryTitle,
					"'."
				}), null);
			}
			if (this.ParentQuest.hudUIExists)
			{
				this.CreateEntryUI();
			}
			else
			{
				Quest parentQuest = this.ParentQuest;
				parentQuest.onHudUICreated = (Action)Delegate.Combine(parentQuest.onHudUICreated, new Action(this.CreateEntryUI));
			}
			this.CreateCompassElement();
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x000480CF File Offset: 0x000462CF
		private void OnValidate()
		{
			this.UpdateName();
			if (this.EntryAddedIn == null || this.EntryAddedIn == string.Empty)
			{
				this.EntryAddedIn = Application.version;
			}
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x000480FC File Offset: 0x000462FC
		public virtual void MinPass()
		{
			if (this.AutoUpdatePoILocation && this.PoI != null)
			{
				this.PoI.transform.position = this.PoILocation.position;
				this.PoI.UpdatePosition();
			}
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0004813A File Offset: 0x0004633A
		public void SetData(QuestEntryData data)
		{
			this.EntryTitle = data.Name;
			this.SetState(data.State, false);
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00048155 File Offset: 0x00046355
		public void Begin()
		{
			this.SetState(EQuestState.Active, true);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0004815F File Offset: 0x0004635F
		public void Complete()
		{
			this.SetState(EQuestState.Completed, true);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x00048169 File Offset: 0x00046369
		public void SetActive(bool network = true)
		{
			this.SetState(EQuestState.Active, network);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x00048174 File Offset: 0x00046374
		public virtual void SetState(EQuestState newState, bool network = true)
		{
			EQuestState equestState = this.state;
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			this.state = newState;
			if (newState == EQuestState.Active && equestState != EQuestState.Active)
			{
				if (this.onStart != null)
				{
					this.onStart.Invoke();
				}
				TimeManager instance2 = NetworkSingleton<TimeManager>.Instance;
				instance2.onMinutePass = (Action)Delegate.Combine(instance2.onMinutePass, new Action(this.MinPass));
			}
			if (newState != EQuestState.Active && equestState == EQuestState.Active && this.onEnd != null)
			{
				this.onEnd.Invoke();
			}
			if (newState == EQuestState.Completed && equestState != EQuestState.Completed)
			{
				if (this.onComplete != null)
				{
					this.onComplete.Invoke();
				}
				if (equestState == EQuestState.Active)
				{
					if (this.onInitialComplete != null)
					{
						this.onInitialComplete.Invoke();
					}
					NetworkSingleton<QuestManager>.Instance.PlayCompleteQuestEntrySound();
				}
				if (this.CompleteParentQuest)
				{
					this.ParentQuest.Complete(network);
				}
			}
			if (this.PoI != null)
			{
				this.PoI.gameObject.SetActive(this.ShouldShowPoI());
			}
			this.ParentQuest.UpdateHUDUI();
			this.UpdateCompassElement();
			if (network)
			{
				int entryIndex = this.ParentQuest.Entries.ToList<QuestEntry>().IndexOf(this);
				NetworkSingleton<QuestManager>.Instance.SendQuestEntryState(this.ParentQuest.GUID.ToString(), entryIndex, newState);
			}
			this.UpdateName();
			StateMachine.ChangeState();
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x000482E2 File Offset: 0x000464E2
		protected virtual bool ShouldShowPoI()
		{
			return this.State == EQuestState.Active && this.ParentQuest.IsTracked;
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x000482FA File Offset: 0x000464FA
		protected virtual void UpdatePoI()
		{
			if (this.PoI != null)
			{
				this.PoI.gameObject.SetActive(this.ShouldShowPoI());
			}
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00048320 File Offset: 0x00046520
		public void SetPoILocation(Vector3 location)
		{
			this.PoILocation.position = location;
			if (this.PoI != null)
			{
				this.PoI.transform.position = location;
				this.PoI.UpdatePosition();
			}
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00048358 File Offset: 0x00046558
		public void CreatePoI()
		{
			if (this.PoI != null)
			{
				Console.LogWarning("PoI already exists for quest entry " + this.EntryTitle, null);
				return;
			}
			if (this.ParentQuest == null)
			{
				Console.LogWarning("Parent quest is null for quest entry " + this.EntryTitle, null);
				return;
			}
			if (this.PoILocation == null)
			{
				Console.LogWarning("PoI location is null for quest entry " + this.EntryTitle, null);
				return;
			}
			this.PoI = Object.Instantiate<GameObject>(this.ParentQuest.PoIPrefab, base.transform).GetComponent<POI>();
			this.PoI.transform.position = this.PoILocation.position;
			this.PoI.SetMainText(this.Title);
			this.PoI.UpdatePosition();
			this.PoI.gameObject.SetActive(this.ShouldShowPoI());
			if (this.PoI.IconContainer != null)
			{
				this.<CreatePoI>g__CreateUI|36_0();
				return;
			}
			this.PoI.onUICreated.AddListener(new UnityAction(this.<CreatePoI>g__CreateUI|36_0));
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x00048478 File Offset: 0x00046678
		public void DestroyPoI()
		{
			if (this.PoI != null)
			{
				Object.Destroy(this.PoI.gameObject);
				this.PoI = null;
			}
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x000484A0 File Offset: 0x000466A0
		public void CreateCompassElement()
		{
			if (this.compassElement != null)
			{
				Console.LogWarning("Compass element already exists for quest: " + this.Title, null);
				return;
			}
			this.compassElement = Singleton<CompassManager>.Instance.AddElement(this.PoILocation, this.ParentQuest.IconPrefab, this.state == EQuestState.Active);
			this.UpdateCompassElement();
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x000484FC File Offset: 0x000466FC
		public void UpdateCompassElement()
		{
			if (this.compassElement == null)
			{
				return;
			}
			this.compassElement.Transform = this.PoILocation;
			this.compassElement.Visible = (this.ParentQuest.QuestState == EQuestState.Active && this.ParentQuest.IsTracked && this.state == EQuestState.Active && this.PoILocation != null);
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00048561 File Offset: 0x00046761
		public QuestEntryData GetSaveData()
		{
			return new QuestEntryData(this.EntryTitle, this.state);
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00048574 File Offset: 0x00046774
		private void UpdateName()
		{
			base.name = this.EntryTitle + " (" + this.state.ToString() + ")";
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x000485A2 File Offset: 0x000467A2
		private void EvaluateConditions()
		{
			if (this.State != EQuestState.Active)
			{
				return;
			}
			if (this.AutoCompleteConditions.Evaluate())
			{
				this.SetState(EQuestState.Completed, true);
			}
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x000485C3 File Offset: 0x000467C3
		public void SetEntryTitle(string newTitle)
		{
			this.EntryTitle = newTitle;
			this.ParentQuest.UpdateHUDUI();
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x000485D8 File Offset: 0x000467D8
		protected virtual void CreateEntryUI()
		{
			if (!this.ParentQuest.hudUIExists)
			{
				Console.LogWarning("Quest HUD UI does not exist for quest " + this.ParentQuest.GetQuestTitle(), null);
				return;
			}
			this.entryUI = Object.Instantiate<QuestEntryHUDUI>(PlayerSingleton<JournalApp>.Instance.QuestEntryHUDUIPrefab, this.ParentQuest.hudUI.EntryContainer).GetComponent<QuestEntryHUDUI>();
			this.entryUI.Initialize(this);
			this.UpdateEntryUI();
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0004864A File Offset: 0x0004684A
		public virtual void UpdateEntryUI()
		{
			this.entryUI.UpdateUI();
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x000486C4 File Offset: 0x000468C4
		[CompilerGenerated]
		private void <CreatePoI>g__CreateUI|36_0()
		{
			if (this.PoI != null)
			{
				Console.LogWarning("PoI already exists for quest entry " + this.EntryTitle, null);
				return;
			}
			if (this.ParentQuest == null)
			{
				Console.LogWarning("Parent quest is null for quest entry " + this.EntryTitle, null);
				return;
			}
			Object.Instantiate<GameObject>(this.ParentQuest.IconPrefab.gameObject, this.PoI.IconContainer).GetComponent<RectTransform>().sizeDelta = new Vector2(20f, 20f);
		}

		// Token: 0x040010B5 RID: 4277
		[Header("Naming")]
		[SerializeField]
		protected string EntryTitle = string.Empty;

		// Token: 0x040010B6 RID: 4278
		[SerializeField]
		protected EQuestState state;

		// Token: 0x040010B7 RID: 4279
		[Header("Settings")]
		public bool AutoComplete;

		// Token: 0x040010B8 RID: 4280
		public Conditions AutoCompleteConditions;

		// Token: 0x040010B9 RID: 4281
		public bool CompleteParentQuest;

		// Token: 0x040010BA RID: 4282
		public string EntryAddedIn = "0.0.1";

		// Token: 0x040010BB RID: 4283
		[Header("PoI Settings")]
		public bool AutoCreatePoI = true;

		// Token: 0x040010BC RID: 4284
		public Transform PoILocation;

		// Token: 0x040010BD RID: 4285
		public bool AutoUpdatePoILocation;

		// Token: 0x040010BE RID: 4286
		public POI PoI;

		// Token: 0x040010BF RID: 4287
		public UnityEvent onStart = new UnityEvent();

		// Token: 0x040010C0 RID: 4288
		public UnityEvent onEnd = new UnityEvent();

		// Token: 0x040010C1 RID: 4289
		public UnityEvent onComplete = new UnityEvent();

		// Token: 0x040010C2 RID: 4290
		public UnityEvent onInitialComplete = new UnityEvent();

		// Token: 0x040010C3 RID: 4291
		private CompassManager.Element compassElement;

		// Token: 0x040010C4 RID: 4292
		private QuestEntryHUDUI entryUI;
	}
}
