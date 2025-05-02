using System;

namespace ScheduleOne.Law
{
	// Token: 0x020005BE RID: 1470
	[Serializable]
	public class DrugTrafficking : Crime
	{
		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x00093631 File Offset: 0x00091831
		// (set) Token: 0x0600246B RID: 9323 RVA: 0x00093639 File Offset: 0x00091839
		public override string CrimeName { get; protected set; } = "Drug trafficking";
	}
}
