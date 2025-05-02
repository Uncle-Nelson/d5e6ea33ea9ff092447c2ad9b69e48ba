using System;

namespace ScheduleOne.Law
{
	// Token: 0x020005C5 RID: 1477
	[Serializable]
	public class Vandalism : Crime
	{
		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600247F RID: 9343 RVA: 0x0009372D File Offset: 0x0009192D
		// (set) Token: 0x06002480 RID: 9344 RVA: 0x00093735 File Offset: 0x00091935
		public override string CrimeName { get; protected set; } = "Vandalism";
	}
}
