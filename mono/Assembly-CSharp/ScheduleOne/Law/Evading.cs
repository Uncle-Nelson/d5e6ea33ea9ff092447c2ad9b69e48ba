using System;

namespace ScheduleOne.Law
{
	// Token: 0x020005BC RID: 1468
	[Serializable]
	public class Evading : Crime
	{
		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06002464 RID: 9316 RVA: 0x000935E9 File Offset: 0x000917E9
		// (set) Token: 0x06002465 RID: 9317 RVA: 0x000935F1 File Offset: 0x000917F1
		public override string CrimeName { get; protected set; } = "Evading arrest";
	}
}
