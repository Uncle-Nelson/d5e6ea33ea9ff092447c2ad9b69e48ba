using System;
using FishNet;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;

namespace ScheduleOne.Quests
{
	// Token: 0x020002E6 RID: 742
	public class Quest_CleanCash : Quest
	{
		// Token: 0x060010A8 RID: 4264 RVA: 0x0004AC74 File Offset: 0x00048E74
		protected override void MinPass()
		{
			base.MinPass();
			if (base.QuestState == EQuestState.Inactive && InstanceFinder.IsServer && ATM.WeeklyDepositSum >= 10000f)
			{
				this.Begin(true);
			}
			if (base.QuestState == EQuestState.Completed)
			{
				return;
			}
			if (InstanceFinder.IsServer && this.BuyBusinessEntry.State == EQuestState.Active && Business.OwnedBusinesses.Count > 0)
			{
				this.BuyBusinessEntry.Complete();
			}
			if (this.GoToBusinessEntry.State == EQuestState.Active)
			{
				if (Business.OwnedBusinesses.Count > 0)
				{
					this.GoToBusinessEntry.transform.position = Business.OwnedBusinesses[0].PoI.transform.position;
				}
				if (Player.Local.CurrentBusiness != null)
				{
					this.GoToBusinessEntry.Complete();
				}
			}
		}

		// Token: 0x040010E5 RID: 4325
		public QuestEntry BuyBusinessEntry;

		// Token: 0x040010E6 RID: 4326
		public QuestEntry GoToBusinessEntry;
	}
}
