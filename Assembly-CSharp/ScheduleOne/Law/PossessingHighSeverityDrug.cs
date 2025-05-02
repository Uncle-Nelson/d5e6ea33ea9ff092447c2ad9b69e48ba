using System;

namespace ScheduleOne.Law
{
	// Token: 0x020005BB RID: 1467
	[Serializable]
	public class PossessingHighSeverityDrug : Crime
	{
		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06002461 RID: 9313 RVA: 0x000935C5 File Offset: 0x000917C5
		// (set) Token: 0x06002462 RID: 9314 RVA: 0x000935CD File Offset: 0x000917CD
		public override string CrimeName { get; protected set; } = "Possession of high-severity drug";
	}
}
