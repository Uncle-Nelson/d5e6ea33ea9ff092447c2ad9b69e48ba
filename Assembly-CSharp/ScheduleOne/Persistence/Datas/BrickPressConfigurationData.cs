using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003F3 RID: 1011
	[Serializable]
	public class BrickPressConfigurationData : SaveData
	{
		// Token: 0x06001567 RID: 5479 RVA: 0x0005F989 File Offset: 0x0005DB89
		public BrickPressConfigurationData(ObjectFieldData destination)
		{
			this.Destination = destination;
		}

		// Token: 0x040013B0 RID: 5040
		public ObjectFieldData Destination;
	}
}
