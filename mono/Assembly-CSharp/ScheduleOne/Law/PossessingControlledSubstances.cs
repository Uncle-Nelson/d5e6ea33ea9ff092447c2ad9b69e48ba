using System;

namespace ScheduleOne.Law
{
	// Token: 0x020005B8 RID: 1464
	[Serializable]
	public class PossessingControlledSubstances : Crime
	{
		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06002458 RID: 9304 RVA: 0x00093559 File Offset: 0x00091759
		// (set) Token: 0x06002459 RID: 9305 RVA: 0x00093561 File Offset: 0x00091761
		public override string CrimeName { get; protected set; } = "Possession of controlled substances";
	}
}
