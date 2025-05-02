using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Map;
using ScheduleOne.Misc;
using ScheduleOne.NPCs.CharacterClasses;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;
using ScheduleOne.UI;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Quests
{
	// Token: 0x020002F8 RID: 760
	public class Quest_UnfavourableAgreements : Quest
	{
		// Token: 0x060010EC RID: 4332 RVA: 0x0004BAC0 File Offset: 0x00049CC0
		protected override void Start()
		{
			base.Start();
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onHourPass = (Action)Delegate.Combine(instance.onHourPass, new Action(this.HourPass));
			this.Thomas.onCartelContractReceived.AddListener(new UnityAction(this.HandoverCompleted));
			Singleton<SleepCanvas>.Instance.onSleepEndFade.AddListener(new UnityAction(this.CheckHandoverExpiry));
			this.UpdateName();
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x0004BB36 File Offset: 0x00049D36
		public override void Begin(bool network = true)
		{
			base.Begin(network);
			this.ResetTimer(false);
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0004BB48 File Offset: 0x00049D48
		private void HourPass()
		{
			float num = NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Hours_Since_Cartel_Handover");
			float num2 = NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Hours_Until_CartelContract_Due");
			if (this.Entries[0].State == EQuestState.Active)
			{
				num += 1f;
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Hours_Since_Cartel_Handover", num.ToString(), true);
				num2 -= 1f;
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Hours_Until_CartelContract_Due", num2.ToString(), true);
				this.UpdateName();
			}
			if (!this.handoverSetup && num >= 12f)
			{
				this.SetupHandover();
			}
			if (!this.Thomas.HandoverReminderSent && num2 <= 24f)
			{
				this.Thomas.SendHandoverReminder();
			}
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x0004BC03 File Offset: 0x00049E03
		private void SetupHandover()
		{
			this.handoverSetup = true;
			Debug.Log("Setting up handover");
			this.Gate.ActivateIntercom();
			this.Switch.SwitchOn();
			this.Thomas.SetHandoverEventActive(true);
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0004BC38 File Offset: 0x00049E38
		private void CheckHandoverExpiry()
		{
			if (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Hours_Until_CartelContract_Due") <= 0f)
			{
				Singleton<SleepCanvas>.Instance.QueueSleepMessage("You have failed to make the weekly delivery. Benzies family goons break in during the night, taking your stock and leaving you nearly dead.", 5f);
				this.RV.Ransack();
				this.ResetTimer(false);
				Player.Local.Health.SetHealth(65f);
			}
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0004BC98 File Offset: 0x00049E98
		private void UpdateName()
		{
			int num = Mathf.FloorToInt(NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Hours_Until_CartelContract_Due") / 24f);
			string str;
			if (num == -1)
			{
				str = string.Empty;
			}
			else if (num == 0)
			{
				str = "(due today)";
			}
			else if (num == 1)
			{
				str = "(" + num.ToString() + " day)";
			}
			else
			{
				str = "(" + num.ToString() + " days)";
			}
			this.Entries[0].SetEntryTitle(this.QuestEntryTitle + " " + str);
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0004BD2D File Offset: 0x00049F2D
		private void HandoverCompleted()
		{
			this.ResetTimer(true);
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x0004BD38 File Offset: 0x00049F38
		public void ResetTimer(bool allowBuildup)
		{
			float num = Mathf.Floor((float)TimeManager.GetMinSumFrom24HourTime(NetworkSingleton<TimeManager>.Instance.CurrentTime) / 60f);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Hours_Since_Cartel_Handover", num.ToString(), true);
			float value = NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Hours_Until_CartelContract_Due");
			float num2 = 168f;
			if (allowBuildup)
			{
				num2 += value;
			}
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Hours_Until_CartelContract_Due", num2.ToString(), true);
			this.UpdateName();
		}

		// Token: 0x04001111 RID: 4369
		public const float WEEKLY_DELIVERY_HOURS = 168f;

		// Token: 0x04001112 RID: 4370
		public const float REMINDER_THRESHOLD = 144f;

		// Token: 0x04001113 RID: 4371
		public Thomas Thomas;

		// Token: 0x04001114 RID: 4372
		public ManorGate Gate;

		// Token: 0x04001115 RID: 4373
		public ModularSwitch Switch;

		// Token: 0x04001116 RID: 4374
		public RV RV;

		// Token: 0x04001117 RID: 4375
		public string QuestEntryTitle;

		// Token: 0x04001118 RID: 4376
		private bool handoverSetup;
	}
}
