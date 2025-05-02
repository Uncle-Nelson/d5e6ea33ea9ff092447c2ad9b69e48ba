using System;
using FishNet;
using ScheduleOne.Economy;

namespace ScheduleOne.Quests
{
	// Token: 0x020002F3 RID: 755
	public class Quest_SecuringSupplies : Quest
	{
		// Token: 0x060010CD RID: 4301 RVA: 0x0004B42D File Offset: 0x0004962D
		protected override void MinPass()
		{
			base.MinPass();
			if (InstanceFinder.IsServer)
			{
				EQuestState questState = base.QuestState;
			}
		}

		// Token: 0x040010FC RID: 4348
		public Supplier Supplier;
	}
}
