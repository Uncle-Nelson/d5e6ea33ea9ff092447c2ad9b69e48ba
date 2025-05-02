using System;

namespace ScheduleOne.Law
{
	// Token: 0x020005C8 RID: 1480
	[Serializable]
	public class DischargeFirearm : Crime
	{
		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06002488 RID: 9352 RVA: 0x00093799 File Offset: 0x00091999
		// (set) Token: 0x06002489 RID: 9353 RVA: 0x000937A1 File Offset: 0x000919A1
		public override string CrimeName { get; protected set; } = "Discharge of a firearm in a public place";
	}
}
