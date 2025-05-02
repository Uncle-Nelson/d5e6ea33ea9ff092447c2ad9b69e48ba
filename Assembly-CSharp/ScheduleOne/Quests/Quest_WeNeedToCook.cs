using System;
using FishNet;
using ScheduleOne.Economy;

namespace ScheduleOne.Quests
{
	// Token: 0x020002FC RID: 764
	public class Quest_WeNeedToCook : Quest
	{
		// Token: 0x06001103 RID: 4355 RVA: 0x0004C000 File Offset: 0x0004A200
		protected override void MinPass()
		{
			base.MinPass();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (base.QuestState == EQuestState.Inactive)
			{
				if (!this.MethSupplier.RelationData.Unlocked)
				{
					return;
				}
				Quest[] prerequisiteQuests = this.PrerequisiteQuests;
				for (int i = 0; i < prerequisiteQuests.Length; i++)
				{
					if (prerequisiteQuests[i].QuestState != EQuestState.Completed)
					{
						return;
					}
				}
				this.Begin(true);
			}
		}

		// Token: 0x04001124 RID: 4388
		public Quest[] PrerequisiteQuests;

		// Token: 0x04001125 RID: 4389
		public Supplier MethSupplier;
	}
}
