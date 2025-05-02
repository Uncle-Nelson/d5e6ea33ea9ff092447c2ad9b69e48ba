using System;

namespace ScheduleOne.Law
{
	// Token: 0x020005C4 RID: 1476
	[Serializable]
	public class DeadlyAssault : Crime
	{
		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x0600247C RID: 9340 RVA: 0x00093709 File Offset: 0x00091909
		// (set) Token: 0x0600247D RID: 9341 RVA: 0x00093711 File Offset: 0x00091911
		public override string CrimeName { get; protected set; } = "Assault with a deadly weapon";
	}
}
