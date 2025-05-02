using System;

namespace ScheduleOne.Law
{
	// Token: 0x020005C6 RID: 1478
	[Serializable]
	public class Theft : Crime
	{
		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06002482 RID: 9346 RVA: 0x00093751 File Offset: 0x00091951
		// (set) Token: 0x06002483 RID: 9347 RVA: 0x00093759 File Offset: 0x00091959
		public override string CrimeName { get; protected set; } = "Theft";
	}
}
