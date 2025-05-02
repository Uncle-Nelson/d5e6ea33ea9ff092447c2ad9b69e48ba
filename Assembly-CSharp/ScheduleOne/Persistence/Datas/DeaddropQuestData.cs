using System;
using ScheduleOne.Quests;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000430 RID: 1072
	[Serializable]
	public class DeaddropQuestData : QuestData
	{
		// Token: 0x060015A6 RID: 5542 RVA: 0x00060284 File Offset: 0x0005E484
		public DeaddropQuestData(string guid, EQuestState state, bool isTracked, string title, string desc, bool isTimed, GameDateTimeData expiry, QuestEntryData[] entries, string deaddropGUID) : base(guid, state, isTracked, title, desc, isTimed, expiry, entries)
		{
			this.DeaddropGUID = deaddropGUID;
		}

		// Token: 0x04001456 RID: 5206
		public string DeaddropGUID;
	}
}
