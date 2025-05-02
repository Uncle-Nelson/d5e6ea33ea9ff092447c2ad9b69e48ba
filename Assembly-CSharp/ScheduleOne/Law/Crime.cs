using System;

namespace ScheduleOne.Law
{
	// Token: 0x020005B7 RID: 1463
	[Serializable]
	public class Crime
	{
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06002455 RID: 9301 RVA: 0x00093535 File Offset: 0x00091735
		// (set) Token: 0x06002456 RID: 9302 RVA: 0x0009353D File Offset: 0x0009173D
		public virtual string CrimeName { get; protected set; } = "Crime";
	}
}
