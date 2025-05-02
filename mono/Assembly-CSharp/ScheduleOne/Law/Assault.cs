using System;

namespace ScheduleOne.Law
{
	// Token: 0x020005C3 RID: 1475
	[Serializable]
	public class Assault : Crime
	{
		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06002479 RID: 9337 RVA: 0x000936E5 File Offset: 0x000918E5
		// (set) Token: 0x0600247A RID: 9338 RVA: 0x000936ED File Offset: 0x000918ED
		public override string CrimeName { get; protected set; } = "Assault";
	}
}
