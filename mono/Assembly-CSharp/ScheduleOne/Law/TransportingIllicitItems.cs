using System;

namespace ScheduleOne.Law
{
	// Token: 0x020005C0 RID: 1472
	[Serializable]
	public class TransportingIllicitItems : Crime
	{
		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x00093679 File Offset: 0x00091879
		// (set) Token: 0x06002471 RID: 9329 RVA: 0x00093681 File Offset: 0x00091881
		public override string CrimeName { get; protected set; } = "Transporting illicit items";
	}
}
