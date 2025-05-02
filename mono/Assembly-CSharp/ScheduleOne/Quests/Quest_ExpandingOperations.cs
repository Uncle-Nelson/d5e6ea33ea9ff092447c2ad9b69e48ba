using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.Variables;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x020002EB RID: 747
	public class Quest_ExpandingOperations : Quest
	{
		// Token: 0x060010B8 RID: 4280 RVA: 0x0004AFFC File Offset: 0x000491FC
		protected override void MinPass()
		{
			base.MinPass();
			if (base.QuestState == EQuestState.Active)
			{
				int num = Mathf.Clamp(Mathf.RoundToInt(NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Sweatshop_Pots")) - 2, 0, 2);
				this.SetUpGrowTentsEntry.SetEntryTitle("Set up 2 more grow tents (" + num.ToString() + "/2)");
				if (num >= 2 && this.SetUpGrowTentsEntry.State != EQuestState.Completed)
				{
					this.SetUpGrowTentsEntry.Complete();
				}
				int count = Customer.UnlockedCustomers.Count;
				this.ReachCustomersEntry.SetEntryTitle("Reach 10 customers (" + count.ToString() + "/10)");
				if (count >= 10 && this.ReachCustomersEntry.State != EQuestState.Completed)
				{
					this.ReachCustomersEntry.Complete();
				}
			}
		}

		// Token: 0x040010EB RID: 4331
		public QuestEntry SetUpGrowTentsEntry;

		// Token: 0x040010EC RID: 4332
		public QuestEntry ReachCustomersEntry;
	}
}
