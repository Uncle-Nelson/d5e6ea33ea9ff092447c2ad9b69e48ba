using System;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003D7 RID: 983
	public class GameData : SaveData
	{
		// Token: 0x0600153C RID: 5436 RVA: 0x0005F5DC File Offset: 0x0005D7DC
		public GameData(string organisationName, int seed, GameSettings settings)
		{
			this.OrganisationName = organisationName;
			this.Seed = seed;
			this.Settings = settings;
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0005F5F9 File Offset: 0x0005D7F9
		public GameData()
		{
			this.OrganisationName = "Organisation";
			this.Seed = 0;
		}

		// Token: 0x04001384 RID: 4996
		public string OrganisationName;

		// Token: 0x04001385 RID: 4997
		public int Seed;

		// Token: 0x04001386 RID: 4998
		public GameSettings Settings;
	}
}
