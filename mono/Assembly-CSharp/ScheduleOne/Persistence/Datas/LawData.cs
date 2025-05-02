using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003F0 RID: 1008
	public class LawData : SaveData
	{
		// Token: 0x06001563 RID: 5475 RVA: 0x0005F938 File Offset: 0x0005DB38
		public LawData(float internalLawIntensity)
		{
			this.InternalLawIntensity = internalLawIntensity;
		}

		// Token: 0x040013A8 RID: 5032
		public float InternalLawIntensity;
	}
}
