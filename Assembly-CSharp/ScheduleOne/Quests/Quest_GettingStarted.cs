using System;
using ScheduleOne.Economy;
using ScheduleOne.NPCs.CharacterClasses;

namespace ScheduleOne.Quests
{
	// Token: 0x020002EE RID: 750
	public class Quest_GettingStarted : Quest
	{
		// Token: 0x060010C1 RID: 4289 RVA: 0x0004B1F3 File Offset: 0x000493F3
		protected override void MinPass()
		{
			base.MinPass();
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x0004B1FB File Offset: 0x000493FB
		public override void SetQuestState(EQuestState state, bool network = true)
		{
			base.SetQuestState(state, network);
		}

		// Token: 0x040010F3 RID: 4339
		public float CashAmount = 375f;

		// Token: 0x040010F4 RID: 4340
		public DeadDrop CashDrop;

		// Token: 0x040010F5 RID: 4341
		public UncleNelson Nelson;
	}
}
