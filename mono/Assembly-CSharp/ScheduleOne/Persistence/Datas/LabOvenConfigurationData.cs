using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003FA RID: 1018
	[Serializable]
	public class LabOvenConfigurationData : SaveData
	{
		// Token: 0x0600156E RID: 5486 RVA: 0x0005FA0E File Offset: 0x0005DC0E
		public LabOvenConfigurationData(ObjectFieldData destination)
		{
			this.Destination = destination;
		}

		// Token: 0x040013BB RID: 5051
		public ObjectFieldData Destination;
	}
}
