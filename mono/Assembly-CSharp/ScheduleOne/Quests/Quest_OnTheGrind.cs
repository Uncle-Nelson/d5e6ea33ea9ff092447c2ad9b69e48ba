using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Variables;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x020002F1 RID: 753
	public class Quest_OnTheGrind : Quest
	{
		// Token: 0x060010C8 RID: 4296 RVA: 0x0004B344 File Offset: 0x00049544
		protected override void MinPass()
		{
			base.MinPass();
			int num = Mathf.RoundToInt(NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Completed_Contracts_Count"));
			if (this.CompleteDealsEntry.State == EQuestState.Active)
			{
				this.CompleteDealsEntry.SetEntryTitle("Complete 3 deals (" + num.ToString() + "/3)");
			}
		}

		// Token: 0x040010FA RID: 4346
		public QuestEntry CompleteDealsEntry;
	}
}
