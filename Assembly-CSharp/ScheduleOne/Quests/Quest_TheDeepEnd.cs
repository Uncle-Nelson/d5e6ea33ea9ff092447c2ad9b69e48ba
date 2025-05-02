using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Map;
using ScheduleOne.Misc;
using ScheduleOne.NPCs.CharacterClasses;
using ScheduleOne.PlayerScripts;
using ScheduleOne.ScriptableObjects;
using ScheduleOne.UI;
using ScheduleOne.UI.Phone;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Quests
{
	// Token: 0x020002F5 RID: 757
	public class Quest_TheDeepEnd : Quest
	{
		// Token: 0x060010D9 RID: 4313 RVA: 0x0004B750 File Offset: 0x00049950
		protected override void Start()
		{
			base.Start();
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onHourPass = (Action)Delegate.Combine(instance.onHourPass, new Action(this.HourPass));
			TimeManager.onSleepStart = (Action)Delegate.Combine(TimeManager.onSleepStart, new Action(this.BeforeSleep));
			Singleton<SleepCanvas>.Instance.onSleepEndFade.AddListener(new UnityAction(this.SleepFadeOut));
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0004B7C4 File Offset: 0x000499C4
		public override void Begin(bool network = true)
		{
			base.Begin(network);
			this.SetupFirstMeeting();
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x0004B7D4 File Offset: 0x000499D4
		public void SetupFirstMeeting()
		{
			this.meetingSetup = true;
			this.Gate.ActivateIntercom();
			this.Switch.SwitchOn();
			this.Thomas.SetFirstMeetingEventActive(true);
			this.Thomas.dialogueHandler.onDialogueNodeDisplayed.AddListener(new UnityAction<string>(this.ThomasDialogueNodeDisplayed));
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0004B82C File Offset: 0x00049A2C
		private void ThomasDialogueNodeDisplayed(string nodeLabel)
		{
			if (nodeLabel == "THOMAS_INTRO_DONE")
			{
				Debug.Log("Intro meeting done!");
				this.Gate.SetEnterable(false);
				this.Thomas.InitialMeetingComplete();
				this.Entries[0].SetState(EQuestState.Completed, true);
				this.Entries[1].SetState(EQuestState.Active, true);
				this.PostMeetingTrigger.Trigger();
				base.StartCoroutine(this.<ThomasDialogueNodeDisplayed>g__Wait|13_0());
			}
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0004B8A8 File Offset: 0x00049AA8
		private void HourPass()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (Quest.GetQuest("Sink or Swim").QuestState != EQuestState.Completed)
			{
				return;
			}
			float value = NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Hours_Since_LoanSharks_Arrived");
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Hours_Since_LoanSharks_Arrived", (value + 1f).ToString(), true);
			if (this.Entries[0].State != EQuestState.Completed && value >= 36f && !this.Thomas.MeetingReminderSent)
			{
				this.Thomas.SendMeetingReminder();
				if (base.QuestState == EQuestState.Inactive)
				{
					this.Begin(true);
				}
			}
			if (this.Entries[0].State == EQuestState.Active && value >= 82f && !this.kidnapQueued)
			{
				this.kidnapQueued = true;
			}
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0004B96D File Offset: 0x00049B6D
		private void BeforeSleep()
		{
			if (this.kidnapQueued)
			{
				Singleton<SleepCanvas>.Instance.QueueSleepMessage("In the middle of the night, the door is kicked in and you are dragged into a vehicle trunk...", 3f);
			}
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0004B98B File Offset: 0x00049B8B
		private void SleepFadeOut()
		{
			if (this.kidnapQueued)
			{
				this.kidnapQueued = false;
				PlayerSingleton<PlayerMovement>.Instance.Teleport(this.MeetingTeleportPoint.position);
				Player.Local.transform.forward = this.MeetingTeleportPoint.forward;
			}
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x0004B9CB File Offset: 0x00049BCB
		public override void SetQuestEntryState(int entryIndex, EQuestState state, bool network = true)
		{
			base.SetQuestEntryState(entryIndex, state, network);
			if (this.Entries[0].State == EQuestState.Active && !this.meetingSetup)
			{
				this.SetupFirstMeeting();
			}
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0004B9F8 File Offset: 0x00049BF8
		[CompilerGenerated]
		private IEnumerator <ThomasDialogueNodeDisplayed>g__Wait|13_0()
		{
			yield return new WaitUntil(() => Player.Local.CurrentProperty == null);
			Singleton<CallInterface>.Instance.StartCall(this.PostMeetingCall, this.PostMeetingCall.CallerID, 0);
			yield break;
		}

		// Token: 0x04001102 RID: 4354
		public const float MEETING_REMINDER_TIME = 36f;

		// Token: 0x04001103 RID: 4355
		public const float KIDNAP_TIME = 82f;

		// Token: 0x04001104 RID: 4356
		private bool kidnapQueued;

		// Token: 0x04001105 RID: 4357
		private bool meetingSetup;

		// Token: 0x04001106 RID: 4358
		public Thomas Thomas;

		// Token: 0x04001107 RID: 4359
		public ManorGate Gate;

		// Token: 0x04001108 RID: 4360
		public ModularSwitch Switch;

		// Token: 0x04001109 RID: 4361
		public Transform MeetingTeleportPoint;

		// Token: 0x0400110A RID: 4362
		public PhoneCallData PostMeetingCall;

		// Token: 0x0400110B RID: 4363
		public SystemTriggerObject PostMeetingTrigger;
	}
}
