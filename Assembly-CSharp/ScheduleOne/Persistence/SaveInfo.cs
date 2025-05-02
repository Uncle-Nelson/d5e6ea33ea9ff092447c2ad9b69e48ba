using System;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence
{
	// Token: 0x0200037C RID: 892
	public class SaveInfo
	{
		// Token: 0x06001438 RID: 5176 RVA: 0x0005A5D8 File Offset: 0x000587D8
		public SaveInfo(string savePath, int saveSlotNumber, string organisationName, DateTime dateCreated, DateTime dateLastPlayed, float networth, string saveVersion, MetaData metaData)
		{
			this.SavePath = savePath;
			this.SaveSlotNumber = saveSlotNumber;
			this.OrganisationName = organisationName;
			this.DateCreated = dateCreated;
			this.DateLastPlayed = dateLastPlayed;
			this.Networth = networth;
			this.SaveVersion = saveVersion;
			this.MetaData = metaData;
		}

		// Token: 0x04001312 RID: 4882
		public string SavePath;

		// Token: 0x04001313 RID: 4883
		public int SaveSlotNumber;

		// Token: 0x04001314 RID: 4884
		public string OrganisationName;

		// Token: 0x04001315 RID: 4885
		public DateTime DateCreated;

		// Token: 0x04001316 RID: 4886
		public DateTime DateLastPlayed;

		// Token: 0x04001317 RID: 4887
		public float Networth;

		// Token: 0x04001318 RID: 4888
		public string SaveVersion;

		// Token: 0x04001319 RID: 4889
		public MetaData MetaData;
	}
}
