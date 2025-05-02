using System;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Quests
{
	// Token: 0x020002FD RID: 765
	[Serializable]
	public class QuestStateSetter
	{
		// Token: 0x06001105 RID: 4357 RVA: 0x0004C060 File Offset: 0x0004A260
		public void Execute()
		{
			Quest quest = Quest.GetQuest(this.QuestName);
			if (quest == null)
			{
				Console.LogWarning("Failed to find quest with name: " + this.QuestName, null);
				return;
			}
			if (this.SetQuestState)
			{
				NetworkSingleton<QuestManager>.Instance.SendQuestAction(quest.GUID.ToString(), this.QuestState);
			}
			if (this.SetQuestEntryState)
			{
				NetworkSingleton<QuestManager>.Instance.SendQuestEntryState(quest.GUID.ToString(), this.QuestEntryIndex, this.QuestEntryState);
			}
		}

		// Token: 0x04001126 RID: 4390
		public string QuestName;

		// Token: 0x04001127 RID: 4391
		public bool SetQuestState;

		// Token: 0x04001128 RID: 4392
		public QuestManager.EQuestAction QuestState;

		// Token: 0x04001129 RID: 4393
		public bool SetQuestEntryState;

		// Token: 0x0400112A RID: 4394
		public int QuestEntryIndex;

		// Token: 0x0400112B RID: 4395
		public EQuestState QuestEntryState;
	}
}
