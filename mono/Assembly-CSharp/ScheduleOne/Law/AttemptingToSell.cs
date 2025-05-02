using System;

namespace ScheduleOne.Law
{
	// Token: 0x020005C2 RID: 1474
	[Serializable]
	public class AttemptingToSell : Crime
	{
		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06002476 RID: 9334 RVA: 0x000936C1 File Offset: 0x000918C1
		// (set) Token: 0x06002477 RID: 9335 RVA: 0x000936C9 File Offset: 0x000918C9
		public override string CrimeName { get; protected set; } = "Attempting to sell illicit items";
	}
}
