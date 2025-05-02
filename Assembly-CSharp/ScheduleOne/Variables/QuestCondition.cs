using System;
using ScheduleOne.Quests;

namespace ScheduleOne.Variables
{
	// Token: 0x02000290 RID: 656
	[Serializable]
	public class QuestCondition
	{
		// Token: 0x06000D8D RID: 3469 RVA: 0x0003C738 File Offset: 0x0003A938
		public bool Evaluate()
		{
			Quest quest = Quest.GetQuest(this.QuestName);
			if (quest == null)
			{
				Console.LogError("Quest " + this.QuestName + " not found", null);
				return false;
			}
			if (this.CheckQuestState && quest.QuestState != this.QuestState)
			{
				return false;
			}
			if (this.CheckQuestEntryState)
			{
				if (quest.Entries.Count <= this.QuestEntryIndex)
				{
					Console.LogError("Quest " + this.QuestName + " does not have entry " + this.QuestEntryIndex.ToString(), null);
					return false;
				}
				if (quest.Entries[this.QuestEntryIndex].State != this.QuestEntryState)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04000E34 RID: 3636
		public bool CheckQuestState = true;

		// Token: 0x04000E35 RID: 3637
		public string QuestName = "Quest name";

		// Token: 0x04000E36 RID: 3638
		public EQuestState QuestState = EQuestState.Active;

		// Token: 0x04000E37 RID: 3639
		public bool CheckQuestEntryState;

		// Token: 0x04000E38 RID: 3640
		public int QuestEntryIndex;

		// Token: 0x04000E39 RID: 3641
		public EQuestState QuestEntryState = EQuestState.Active;
	}
}
