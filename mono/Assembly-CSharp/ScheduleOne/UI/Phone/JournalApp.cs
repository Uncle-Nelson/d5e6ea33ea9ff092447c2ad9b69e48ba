using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Quests;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000A8E RID: 2702
	public class JournalApp : App<JournalApp>
	{
		// Token: 0x060048AC RID: 18604 RVA: 0x00130B8F File Offset: 0x0012ED8F
		protected override void Awake()
		{
			base.Awake();
		}

		// Token: 0x060048AD RID: 18605 RVA: 0x00130B97 File Offset: 0x0012ED97
		protected override void Start()
		{
			base.Start();
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
		}

		// Token: 0x060048AE RID: 18606 RVA: 0x00130BC6 File Offset: 0x0012EDC6
		public override void SetOpen(bool open)
		{
			base.SetOpen(open);
			if (!open && this.currentDetailsPanel != null)
			{
				this.currentDetailsPanelQuest.DestroyDetailDisplay();
				this.currentDetailsPanel = null;
				this.currentDetailsPanelQuest = null;
			}
		}

		// Token: 0x060048AF RID: 18607 RVA: 0x00130BFC File Offset: 0x0012EDFC
		protected override void Update()
		{
			base.Update();
			if (base.isOpen)
			{
				this.RefreshDetailsPanel();
				this.NoTasksLabel.enabled = (Quest.ActiveQuests.Count == 0);
				this.NoDetailsLabel.enabled = (this.currentDetailsPanel == null);
			}
		}

		// Token: 0x060048B0 RID: 18608 RVA: 0x00130C4C File Offset: 0x0012EE4C
		private void RefreshDetailsPanel()
		{
			if (Quest.HoveredQuest != null)
			{
				if (this.currentDetailsPanelQuest != Quest.HoveredQuest)
				{
					if (this.currentDetailsPanel != null)
					{
						this.currentDetailsPanelQuest.DestroyDetailDisplay();
						this.currentDetailsPanel = null;
						this.currentDetailsPanelQuest = null;
					}
					this.currentDetailsPanel = Quest.HoveredQuest.CreateDetailDisplay(this.DetailsPanelContainer);
					this.currentDetailsPanelQuest = Quest.HoveredQuest;
					return;
				}
			}
			else if (this.currentDetailsPanel != null)
			{
				this.currentDetailsPanelQuest.DestroyDetailDisplay();
				this.currentDetailsPanel = null;
				this.currentDetailsPanelQuest = null;
			}
		}

		// Token: 0x060048B1 RID: 18609 RVA: 0x00130CE8 File Offset: 0x0012EEE8
		protected override void OnDestroy()
		{
			base.OnDestroy();
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			}
		}

		// Token: 0x060048B2 RID: 18610 RVA: 0x00130D1E File Offset: 0x0012EF1E
		protected virtual void MinPass()
		{
			bool isOpen = base.isOpen;
		}

		// Token: 0x040035BC RID: 13756
		[Header("References")]
		public RectTransform EntryContainer;

		// Token: 0x040035BD RID: 13757
		public Text NoTasksLabel;

		// Token: 0x040035BE RID: 13758
		public Text NoDetailsLabel;

		// Token: 0x040035BF RID: 13759
		public RectTransform DetailsPanelContainer;

		// Token: 0x040035C0 RID: 13760
		[Header("Entry prefabs")]
		public GameObject GenericEntry;

		// Token: 0x040035C1 RID: 13761
		[Header("Details panel prefabs")]
		public GameObject GenericDetailsPanel;

		// Token: 0x040035C2 RID: 13762
		[Header("Quest Entry prefab")]
		public GameObject GenericQuestEntry;

		// Token: 0x040035C3 RID: 13763
		[Header("HUD entry prefabs")]
		public QuestHUDUI QuestHUDUIPrefab;

		// Token: 0x040035C4 RID: 13764
		public QuestEntryHUDUI QuestEntryHUDUIPrefab;

		// Token: 0x040035C5 RID: 13765
		protected Quest currentDetailsPanelQuest;

		// Token: 0x040035C6 RID: 13766
		protected RectTransform currentDetailsPanel;
	}
}
