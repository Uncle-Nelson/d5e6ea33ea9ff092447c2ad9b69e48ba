using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003F8 RID: 1016
	[Serializable]
	public class DryingRackConfigurationData : SaveData
	{
		// Token: 0x0600156C RID: 5484 RVA: 0x0005F9E9 File Offset: 0x0005DBE9
		public DryingRackConfigurationData(QualityFieldData targetquality, ObjectFieldData destination)
		{
			this.TargetQuality = targetquality;
			this.Destination = destination;
		}

		// Token: 0x040013B8 RID: 5048
		public QualityFieldData TargetQuality;

		// Token: 0x040013B9 RID: 5049
		public ObjectFieldData Destination;
	}
}
