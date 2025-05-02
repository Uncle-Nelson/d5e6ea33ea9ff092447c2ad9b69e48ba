using System;

namespace ScheduleOne.Law
{
	// Token: 0x020005BA RID: 1466
	[Serializable]
	public class PossessingModerateSeverityDrug : Crime
	{
		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x0600245E RID: 9310 RVA: 0x000935A1 File Offset: 0x000917A1
		// (set) Token: 0x0600245F RID: 9311 RVA: 0x000935A9 File Offset: 0x000917A9
		public override string CrimeName { get; protected set; } = "Possession of moderate-severity drug";
	}
}
