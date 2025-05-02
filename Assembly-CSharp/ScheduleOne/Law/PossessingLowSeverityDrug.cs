using System;

namespace ScheduleOne.Law
{
	// Token: 0x020005B9 RID: 1465
	[Serializable]
	public class PossessingLowSeverityDrug : Crime
	{
		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x0009357D File Offset: 0x0009177D
		// (set) Token: 0x0600245C RID: 9308 RVA: 0x00093585 File Offset: 0x00091785
		public override string CrimeName { get; protected set; } = "Possession of low-severity drug";
	}
}
