using System;
using ScheduleOne.Quests;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000432 RID: 1074
	[Serializable]
	public class QuestEntryData : SaveData
	{
		// Token: 0x060015A8 RID: 5544 RVA: 0x000602FC File Offset: 0x0005E4FC
		public QuestEntryData(string name, EQuestState state)
		{
			this.Name = name;
			this.State = state;
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x0005F51C File Offset: 0x0005D71C
		public QuestEntryData()
		{
		}

		// Token: 0x0400145F RID: 5215
		public string Name;

		// Token: 0x04001460 RID: 5216
		public EQuestState State;
	}
}
