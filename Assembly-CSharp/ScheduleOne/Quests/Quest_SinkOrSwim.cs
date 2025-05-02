using System;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Persistence;
using ScheduleOne.UI;
using ScheduleOne.Variables;
using ScheduleOne.Vehicles;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Quests
{
	// Token: 0x020002F4 RID: 756
	public class Quest_SinkOrSwim : Quest
	{
		// Token: 0x060010CF RID: 4303 RVA: 0x0004B443 File Offset: 0x00049643
		protected override void Awake()
		{
			base.Awake();
			this.LoanSharkGraves.gameObject.SetActive(false);
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0004B45C File Offset: 0x0004965C
		protected override void Start()
		{
			base.Start();
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onHourPass = (Action)Delegate.Combine(instance.onHourPass, new Action(this.HourPass));
			Singleton<SleepCanvas>.Instance.onSleepEndFade.AddListener(new UnityAction(this.SleepStart));
			Singleton<SleepCanvas>.Instance.onSleepEndFade.AddListener(new UnityAction(this.CheckArrival));
			Singleton<LoadManager>.Instance.onLoadComplete.RemoveListener(new UnityAction(this.UpdateName));
			Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(this.UpdateName));
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0004B1F3 File Offset: 0x000493F3
		protected override void MinPass()
		{
			base.MinPass();
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x0004B501 File Offset: 0x00049701
		private void HourPass()
		{
			if (this.Entries[0].State == EQuestState.Active)
			{
				this.UpdateName();
			}
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x0004B520 File Offset: 0x00049720
		private void SleepStart()
		{
			if (this.Entries[0].State == EQuestState.Active)
			{
				float value = NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Days_Since_Tutorial_Completed");
				int num = 4 - (int)value;
				if (num == -1)
				{
					Singleton<SleepCanvas>.Instance.QueueSleepMessage("In the midst of night gunshots ring out nearby, but you are not the target. The rest of the night is quiet.", 5f);
					return;
				}
				if (num == 0)
				{
					Singleton<SleepCanvas>.Instance.QueueSleepMessage("The loan sharks are arriving tonight.", 4f);
					return;
				}
				if (num == 1)
				{
					Singleton<SleepCanvas>.Instance.QueueSleepMessage(num.ToString() + " day until the loan sharks arrive", 3f);
					return;
				}
				Singleton<SleepCanvas>.Instance.QueueSleepMessage(num.ToString() + " days until the loan sharks arrive", 3f);
			}
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0004B5CF File Offset: 0x000497CF
		private void SpawnLoanSharkVehicle()
		{
			NetworkSingleton<VehicleManager>.Instance.SpawnLoanSharkVehicle(this.LoanSharkVehiclePosition.position, this.LoanSharkVehiclePosition.rotation);
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0004B5F4 File Offset: 0x000497F4
		private void CheckArrival()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (NetworkSingleton<VariableDatabase>.Instance.GetValue<bool>("Loan_Sharks_Arrived"))
			{
				return;
			}
			if (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Days_Since_Tutorial_Completed") > 4f)
			{
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Loan_Sharks_Arrived", true.ToString(), true);
				this.SpawnLoanSharkVehicle();
				this.LoanSharkGraves.gameObject.SetActive(true);
				this.Entries[this.Entries.Count - 1].SetState(EQuestState.Completed, true);
			}
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x0004B680 File Offset: 0x00049880
		public override void SetQuestState(EQuestState state, bool network = true)
		{
			base.SetQuestState(state, network);
			this.LoanSharkGraves.gameObject.SetActive(state == EQuestState.Completed);
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x0004B6A0 File Offset: 0x000498A0
		private void UpdateName()
		{
			float value = NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Days_Since_Tutorial_Completed");
			int num = 4 - (int)value;
			string str;
			if (num == -1)
			{
				str = string.Empty;
			}
			else if (num == 0)
			{
				str = "(arriving tonight)";
			}
			else if (num == 1)
			{
				str = "(" + num.ToString() + " day remaining)";
			}
			else
			{
				str = "(" + num.ToString() + " days remaining)";
			}
			this.Entries[0].SetEntryTitle(this.QuestName + " " + str);
		}

		// Token: 0x040010FD RID: 4349
		public const int DAYS_TO_COMPLETE = 4;

		// Token: 0x040010FE RID: 4350
		public string QuestName = "Make at least $1,000 to pay off the sharks";

		// Token: 0x040010FF RID: 4351
		public int NelsonCallTime = 1215;

		// Token: 0x04001100 RID: 4352
		public Transform LoanSharkVehiclePosition;

		// Token: 0x04001101 RID: 4353
		public GameObject LoanSharkGraves;
	}
}
