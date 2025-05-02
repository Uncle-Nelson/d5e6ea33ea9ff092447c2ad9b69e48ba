using System;
using ScheduleOne.Economy;

namespace ScheduleOne.Quests
{
	// Token: 0x020002EF RID: 751
	public class Quest_MovingUp : Quest
	{
		// Token: 0x060010C4 RID: 4292 RVA: 0x0004B218 File Offset: 0x00049418
		protected override void MinPass()
		{
			base.MinPass();
			if (this.ReachCustomersEntry.State == EQuestState.Active)
			{
				int count = Customer.UnlockedCustomers.Count;
				this.ReachCustomersEntry.SetEntryTitle("Unlock 10 customers (" + count.ToString() + "/10)");
				if (count >= 10 && this.ReachCustomersEntry.State != EQuestState.Completed)
				{
					this.ReachCustomersEntry.Complete();
				}
			}
		}

		// Token: 0x040010F6 RID: 4342
		public QuestEntry ReachCustomersEntry;
	}
}
