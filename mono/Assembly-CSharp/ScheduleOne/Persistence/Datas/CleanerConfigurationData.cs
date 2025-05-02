using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003F7 RID: 1015
	[Serializable]
	public class CleanerConfigurationData : SaveData
	{
		// Token: 0x0600156B RID: 5483 RVA: 0x0005F9D3 File Offset: 0x0005DBD3
		public CleanerConfigurationData(ObjectFieldData bed, ObjectListFieldData bins)
		{
			this.Bed = bed;
			this.Bins = bins;
		}

		// Token: 0x040013B6 RID: 5046
		public ObjectFieldData Bed;

		// Token: 0x040013B7 RID: 5047
		public ObjectListFieldData Bins;
	}
}
