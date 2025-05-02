using System;

namespace ScheduleOne.Combat
{
	// Token: 0x02000739 RID: 1849
	public interface IDamageable
	{
		// Token: 0x0600320A RID: 12810
		void SendImpact(Impact impact);

		// Token: 0x0600320B RID: 12811
		void ReceiveImpact(Impact impact);
	}
}
