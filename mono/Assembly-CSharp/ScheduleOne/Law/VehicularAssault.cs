using System;

namespace ScheduleOne.Law
{
	// Token: 0x020005BD RID: 1469
	[Serializable]
	public class VehicularAssault : Crime
	{
		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06002467 RID: 9319 RVA: 0x0009360D File Offset: 0x0009180D
		// (set) Token: 0x06002468 RID: 9320 RVA: 0x00093615 File Offset: 0x00091815
		public override string CrimeName { get; protected set; } = "Vehicular assault";
	}
}
