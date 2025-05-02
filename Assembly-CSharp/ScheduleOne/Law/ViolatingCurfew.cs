using System;

namespace ScheduleOne.Law
{
	// Token: 0x020005C1 RID: 1473
	[Serializable]
	public class ViolatingCurfew : Crime
	{
		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x0009369D File Offset: 0x0009189D
		// (set) Token: 0x06002474 RID: 9332 RVA: 0x000936A5 File Offset: 0x000918A5
		public override string CrimeName { get; protected set; } = "Violating curfew";
	}
}
