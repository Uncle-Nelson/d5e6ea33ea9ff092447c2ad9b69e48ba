using System;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Variables;

namespace ScheduleOne.Quests
{
	// Token: 0x020002E9 RID: 745
	public class Quest_DownToBusiness : Quest
	{
		// Token: 0x060010AF RID: 4271 RVA: 0x0004AE58 File Offset: 0x00049058
		protected override void Awake()
		{
			base.Awake();
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0004AE60 File Offset: 0x00049060
		protected override void Start()
		{
			base.Start();
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onDayPass = (Action)Delegate.Combine(instance.onDayPass, new Action(this.DayPass));
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0004AE90 File Offset: 0x00049090
		private void DayPass()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (base.QuestState == EQuestState.Completed)
			{
				float num = NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Days_Since_Tutorial_Completed");
				num += 1f;
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Days_Since_Tutorial_Completed", num.ToString(), true);
			}
		}
	}
}
