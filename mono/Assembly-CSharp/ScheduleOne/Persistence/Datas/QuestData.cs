using System;
using ScheduleOne.Quests;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000431 RID: 1073
	[Serializable]
	public class QuestData : SaveData
	{
		// Token: 0x060015A7 RID: 5543 RVA: 0x000602AC File Offset: 0x0005E4AC
		public QuestData(string guid, EQuestState state, bool isTracked, string title, string desc, bool expires, GameDateTimeData expiry, QuestEntryData[] entries)
		{
			this.GUID = guid;
			this.State = state;
			this.IsTracked = isTracked;
			this.Title = title;
			this.Description = desc;
			this.Expires = expires;
			this.ExpiryDate = expiry;
			this.Entries = entries;
		}

		// Token: 0x04001457 RID: 5207
		public string GUID;

		// Token: 0x04001458 RID: 5208
		public EQuestState State;

		// Token: 0x04001459 RID: 5209
		public bool IsTracked;

		// Token: 0x0400145A RID: 5210
		public string Title;

		// Token: 0x0400145B RID: 5211
		public string Description;

		// Token: 0x0400145C RID: 5212
		public bool Expires;

		// Token: 0x0400145D RID: 5213
		public GameDateTimeData ExpiryDate;

		// Token: 0x0400145E RID: 5214
		public QuestEntryData[] Entries;
	}
}
