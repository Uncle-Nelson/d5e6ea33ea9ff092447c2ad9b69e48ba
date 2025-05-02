using System;
using ScheduleOne.NPCs.Relation;

namespace ScheduleOne.Quests
{
	// Token: 0x020002E8 RID: 744
	public class Quest_Connections : Quest
	{
		// Token: 0x060010AD RID: 4269 RVA: 0x0004ADDC File Offset: 0x00048FDC
		public override void Begin(bool network = true)
		{
			base.Begin(network);
			foreach (QuestEntry questEntry in this.Entries)
			{
				if (questEntry.GetComponent<NPCUnlockTracker>().Npc.RelationData.Unlocked)
				{
					questEntry.SetState(EQuestState.Completed, true);
				}
				else
				{
					questEntry.SetState(EQuestState.Active, true);
				}
			}
		}
	}
}
