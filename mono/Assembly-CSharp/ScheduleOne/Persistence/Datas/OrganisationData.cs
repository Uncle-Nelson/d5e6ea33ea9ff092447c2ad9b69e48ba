using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000426 RID: 1062
	[Serializable]
	public class OrganisationData : SaveData
	{
		// Token: 0x0600159B RID: 5531 RVA: 0x000600DF File Offset: 0x0005E2DF
		public OrganisationData(string name, float netWorth)
		{
			this.Name = name;
			this.NetWorth = netWorth;
		}

		// Token: 0x04001432 RID: 5170
		public string Name;

		// Token: 0x04001433 RID: 5171
		public float NetWorth;
	}
}
