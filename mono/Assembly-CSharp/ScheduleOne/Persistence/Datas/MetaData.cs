using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000406 RID: 1030
	[Serializable]
	public class MetaData : SaveData
	{
		// Token: 0x0600157A RID: 5498 RVA: 0x0005FAF5 File Offset: 0x0005DCF5
		public MetaData(DateTimeData creationDate, DateTimeData lastPlayedDate, string creationVersion, string lastSaveVersion, bool playTutorial)
		{
			this.CreationDate = creationDate;
			this.LastPlayedDate = lastPlayedDate;
			this.CreationVersion = creationVersion;
			this.LastSaveVersion = lastSaveVersion;
			this.PlayTutorial = playTutorial;
		}

		// Token: 0x040013CE RID: 5070
		public DateTimeData CreationDate;

		// Token: 0x040013CF RID: 5071
		public DateTimeData LastPlayedDate;

		// Token: 0x040013D0 RID: 5072
		public string CreationVersion;

		// Token: 0x040013D1 RID: 5073
		public string LastSaveVersion;

		// Token: 0x040013D2 RID: 5074
		public bool PlayTutorial;
	}
}
