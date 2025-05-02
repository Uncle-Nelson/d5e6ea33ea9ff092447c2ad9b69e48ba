using System;
using System.Collections.Generic;
using System.Linq;
using EasyButtons;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Law;
using ScheduleOne.NPCs.Schedules;
using ScheduleOne.Persistence;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs
{
	// Token: 0x0200046E RID: 1134
	public class NPCScheduleManager : MonoBehaviour
	{
		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x060017F5 RID: 6133 RVA: 0x00069B3E File Offset: 0x00067D3E
		// (set) Token: 0x060017F6 RID: 6134 RVA: 0x00069B46 File Offset: 0x00067D46
		public bool ScheduleEnabled { get; protected set; }

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x00069B4F File Offset: 0x00067D4F
		// (set) Token: 0x060017F8 RID: 6136 RVA: 0x00069B57 File Offset: 0x00067D57
		public bool CurfewModeEnabled { get; protected set; }

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x00069B60 File Offset: 0x00067D60
		// (set) Token: 0x060017FA RID: 6138 RVA: 0x00069B68 File Offset: 0x00067D68
		public NPCAction ActiveAction { get; set; }

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x00069B71 File Offset: 0x00067D71
		// (set) Token: 0x060017FC RID: 6140 RVA: 0x00069B79 File Offset: 0x00067D79
		public List<NPCAction> PendingActions { get; set; } = new List<NPCAction>();

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x00069B82 File Offset: 0x00067D82
		// (set) Token: 0x060017FE RID: 6142 RVA: 0x00069B8A File Offset: 0x00067D8A
		public NPC Npc { get; protected set; }

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x00069B93 File Offset: 0x00067D93
		// (set) Token: 0x06001800 RID: 6144 RVA: 0x00069B9B File Offset: 0x00067D9B
		protected List<NPCAction> ActionsAwaitingStart { get; set; } = new List<NPCAction>();

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x00069BA4 File Offset: 0x00067DA4
		protected TimeManager Time
		{
			get
			{
				return NetworkSingleton<TimeManager>.Instance;
			}
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00069BAB File Offset: 0x00067DAB
		protected virtual void Awake()
		{
			this.Npc = base.GetComponentInParent<NPC>();
			this.SetCurfewModeEnabled(false);
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00069BC0 File Offset: 0x00067DC0
		protected virtual void Start()
		{
			this.InitializeActions();
			TimeManager time = this.Time;
			time.onTimeChanged = (Action)Delegate.Remove(time.onTimeChanged, new Action(this.EnforceState));
			TimeManager time2 = this.Time;
			time2.onTimeChanged = (Action)Delegate.Combine(time2.onTimeChanged, new Action(this.EnforceState));
			TimeManager time3 = this.Time;
			time3.onMinutePass = (Action)Delegate.Remove(time3.onMinutePass, new Action(this.MinPass));
			TimeManager time4 = this.Time;
			time4.onMinutePass = (Action)Delegate.Combine(time4.onMinutePass, new Action(this.MinPass));
			Player.onLocalPlayerSpawned = (Action)Delegate.Remove(Player.onLocalPlayerSpawned, new Action(this.LocalPlayerSpawned));
			Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(this.LocalPlayerSpawned));
			NetworkSingleton<CurfewManager>.Instance.onCurfewEnabled.AddListener(new UnityAction(this.CurfewEnabled));
			NetworkSingleton<CurfewManager>.Instance.onCurfewDisabled.AddListener(new UnityAction(this.CurfewDisabled));
			if (this.DEBUG_MODE)
			{
				int min = 1250;
				int max = 930;
				this.GetActionsTotallyOccurringWithinRange(min, max, true);
			}
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00069D07 File Offset: 0x00067F07
		private void LocalPlayerSpawned()
		{
			if (InstanceFinder.IsServer)
			{
				this.EnforceState(true);
			}
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x00033A28 File Offset: 0x00031C28
		private void OnValidate()
		{
			bool isPlaying = Application.isPlaying;
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00069D17 File Offset: 0x00067F17
		protected virtual void Update()
		{
			if (this.ActiveAction != null)
			{
				this.ActiveAction.ActiveUpdate();
			}
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00069D32 File Offset: 0x00067F32
		public void EnableSchedule()
		{
			this.ScheduleEnabled = true;
			this.MinPass();
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x00069D41 File Offset: 0x00067F41
		public void DisableSchedule()
		{
			this.ScheduleEnabled = false;
			this.MinPass();
			if (this.Npc.Movement.IsMoving)
			{
				this.Npc.Movement.Stop();
			}
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00069D74 File Offset: 0x00067F74
		[Button]
		public void InitializeActions()
		{
			List<NPCAction> list = base.gameObject.GetComponentsInChildren<NPCAction>(true).ToList<NPCAction>();
			list.Sort(delegate(NPCAction a, NPCAction b)
			{
				float num = (float)a.StartTime;
				float value = (float)b.StartTime;
				int num2 = num.CompareTo(value);
				if (num2 != 0)
				{
					return num2;
				}
				if (a.IsSignal)
				{
					return -1;
				}
				return 1;
			});
			if (!Application.isPlaying)
			{
				foreach (NPCAction npcaction in list)
				{
					npcaction.transform.name = npcaction.GetName() + " (" + npcaction.GetTimeDescription() + ")";
					npcaction.transform.SetAsLastSibling();
				}
			}
			this.ActionList = list;
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x00069E34 File Offset: 0x00068034
		protected virtual void MinPass()
		{
			if (!this.Npc.IsSpawned)
			{
				return;
			}
			if (!this.ScheduleEnabled)
			{
				if (this.ActiveAction != null)
				{
					this.ActiveAction.Interrupt();
				}
				return;
			}
			if (this.ActiveAction != null)
			{
				this.ActiveAction.ActiveMinPassed();
			}
			if (this.ActiveAction != null && !this.ActiveAction.gameObject.activeInHierarchy)
			{
				this.ActiveAction.End();
			}
			List<NPCAction> actionsOccurringAt = this.GetActionsOccurringAt(NetworkSingleton<TimeManager>.Instance.CurrentTime);
			bool debug_MODE = this.DEBUG_MODE;
			if (actionsOccurringAt.Count > 0)
			{
				NPCAction npcaction = actionsOccurringAt[0];
				if (this.ActiveAction != npcaction)
				{
					if (this.ActiveAction != null && npcaction.Priority > this.ActiveAction.Priority)
					{
						if (this.DEBUG_MODE)
						{
							Debug.Log("New active action: " + npcaction.GetName());
						}
						this.ActiveAction.Interrupt();
					}
					if (this.ActiveAction == null)
					{
						this.StartAction(npcaction);
					}
				}
			}
			foreach (NPCAction npcaction2 in actionsOccurringAt)
			{
				if (!npcaction2.HasStarted && !this.ActionsAwaitingStart.Contains(npcaction2))
				{
					this.ActionsAwaitingStart.Add(npcaction2);
				}
			}
			foreach (NPCAction npcaction3 in this.ActionsAwaitingStart.ToList<NPCAction>())
			{
				if (!NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(npcaction3.StartTime, npcaction3.GetEndTime()))
				{
					npcaction3.Skipped();
					this.ActionsAwaitingStart.Remove(npcaction3);
				}
			}
			this.lastProcessedTime = this.Time.CurrentTime;
			if (this.DEBUG_MODE)
			{
				Console.Log("Active action: " + ((this.ActiveAction != null) ? this.ActiveAction.GetName() : "None"), null);
			}
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x0006A060 File Offset: 0x00068260
		private List<NPCAction> GetActionsOccurringAt(int time)
		{
			List<NPCAction> list = new List<NPCAction>();
			foreach (NPCAction npcaction in this.ActionList)
			{
				if (!(npcaction == null) && npcaction.ShouldStart() && TimeManager.IsGivenTimeWithinRange(time, npcaction.StartTime, TimeManager.AddMinutesTo24HourTime(npcaction.GetEndTime(), -1)))
				{
					list.Add(npcaction);
				}
			}
			list = (from x in list
			orderby x.Priority descending
			select x).ToList<NPCAction>();
			return list;
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x0006A110 File Offset: 0x00068310
		private List<NPCAction> GetActionsTotallyOccurringWithinRange(int min, int max, bool checkShouldStart)
		{
			List<NPCAction> list = new List<NPCAction>();
			foreach (NPCAction npcaction in this.ActionList)
			{
				if ((!checkShouldStart || npcaction.ShouldStart()) && TimeManager.IsGivenTimeWithinRange(npcaction.StartTime, min, max) && TimeManager.IsGivenTimeWithinRange(npcaction.GetEndTime(), min, max))
				{
					list.Add(npcaction);
				}
			}
			list = (from x in list
			orderby x.Priority descending
			select x).ToList<NPCAction>();
			bool debug_MODE = this.DEBUG_MODE;
			return list;
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x0006A1C8 File Offset: 0x000683C8
		private void StartAction(NPCAction action)
		{
			if (this.ActiveAction != null)
			{
				Console.LogWarning("JumpToAction called but there is already an active action! Existing action should first be ended or interrupted!", null);
			}
			if (this.ActionsAwaitingStart.Contains(action))
			{
				this.ActionsAwaitingStart.Remove(action);
			}
			if (NetworkSingleton<TimeManager>.Instance.CurrentTime == action.StartTime)
			{
				action.Started();
				return;
			}
			if (action.HasStarted)
			{
				action.Resume();
				return;
			}
			action.LateStarted();
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x0006A237 File Offset: 0x00068437
		private void EnforceState()
		{
			this.EnforceState(Singleton<LoadManager>.Instance.IsLoading);
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x0006A24C File Offset: 0x0006844C
		public void EnforceState(bool initial = false)
		{
			this.ActionsAwaitingStart.Clear();
			int currentTime = NetworkSingleton<TimeManager>.Instance.CurrentTime;
			int minSumFrom24HourTime = TimeManager.GetMinSumFrom24HourTime(currentTime);
			if (this.DEBUG_MODE)
			{
				Debug.Log("Enforcing state. Last processed time: " + this.lastProcessedTime.ToString() + ", Current time: " + NetworkSingleton<TimeManager>.Instance.CurrentTime.ToString());
			}
			List<NPCAction> list = this.GetActionsTotallyOccurringWithinRange(this.lastProcessedTime, NetworkSingleton<TimeManager>.Instance.CurrentTime, true);
			List<NPCAction> actionsOccurringThisFrame = this.GetActionsOccurringAt(NetworkSingleton<TimeManager>.Instance.CurrentTime);
			list.RemoveAll((NPCAction x) => x.IsActive || actionsOccurringThisFrame.Contains(x));
			NPCAction npcaction = null;
			if (actionsOccurringThisFrame.Count > 0)
			{
				npcaction = actionsOccurringThisFrame[0];
			}
			if (this.ActiveAction != null && this.ActiveAction != npcaction)
			{
				this.ActiveAction.Interrupt();
			}
			Dictionary<NPCAction, float> skippedActionOrder = new Dictionary<NPCAction, float>();
			for (int i = 0; i < list.Count; i++)
			{
				float num;
				if (list[i].StartTime >= currentTime)
				{
					num = (float)(TimeManager.GetMinSumFrom24HourTime(list[i].StartTime) - minSumFrom24HourTime);
				}
				else
				{
					num = 1440f - (float)minSumFrom24HourTime + (float)TimeManager.GetMinSumFrom24HourTime(list[i].StartTime);
				}
				num -= 0.01f * (float)list[i].Priority;
				skippedActionOrder.Add(list[i], num);
			}
			list = (from x in list
			orderby skippedActionOrder[x]
			select x).ToList<NPCAction>();
			if (this.DEBUG_MODE)
			{
				Debug.Log("Ordered skipped actions: " + list.Count.ToString());
			}
			if (!initial)
			{
				for (int j = 0; j < list.Count; j++)
				{
					list[j].Skipped();
				}
			}
			if (npcaction != null)
			{
				npcaction.JumpTo();
			}
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x0006A454 File Offset: 0x00068654
		protected virtual void CurfewEnabled()
		{
			this.SetCurfewModeEnabled(true);
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x0006A45D File Offset: 0x0006865D
		protected virtual void CurfewDisabled()
		{
			this.SetCurfewModeEnabled(false);
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x0006A468 File Offset: 0x00068668
		public void SetCurfewModeEnabled(bool enabled)
		{
			for (int i = 0; i < this.EnabledDuringCurfew.Length; i++)
			{
				this.EnabledDuringCurfew[i].gameObject.SetActive(enabled);
			}
			for (int j = 0; j < this.EnabledDuringNoCurfew.Length; j++)
			{
				this.EnabledDuringNoCurfew[j].gameObject.SetActive(!enabled);
			}
		}

		// Token: 0x0400158C RID: 5516
		public bool DEBUG_MODE;

		// Token: 0x04001590 RID: 5520
		[Header("References")]
		public GameObject[] EnabledDuringCurfew;

		// Token: 0x04001591 RID: 5521
		public GameObject[] EnabledDuringNoCurfew;

		// Token: 0x04001592 RID: 5522
		public List<NPCAction> ActionList = new List<NPCAction>();

		// Token: 0x04001594 RID: 5524
		protected int lastProcessedTime;
	}
}
