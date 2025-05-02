using System;

namespace ScheduleOne.Law
{
	// Token: 0x020005BF RID: 1471
	[Serializable]
	public class FailureToComply : Crime
	{
		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x0600246D RID: 9325 RVA: 0x00093655 File Offset: 0x00091855
		// (set) Token: 0x0600246E RID: 9326 RVA: 0x0009365D File Offset: 0x0009185D
		public override string CrimeName { get; protected set; } = "Failure to comply with police instruction";
	}
}
