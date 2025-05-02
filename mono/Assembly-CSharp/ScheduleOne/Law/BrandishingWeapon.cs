using System;

namespace ScheduleOne.Law
{
	// Token: 0x020005C7 RID: 1479
	[Serializable]
	public class BrandishingWeapon : Crime
	{
		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06002485 RID: 9349 RVA: 0x00093775 File Offset: 0x00091975
		// (set) Token: 0x06002486 RID: 9350 RVA: 0x0009377D File Offset: 0x0009197D
		public override string CrimeName { get; protected set; } = "Brandishing a weapon";
	}
}
