using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Money
{
	// Token: 0x02000B8C RID: 2956
	public class CashSlot : HotbarSlot
	{
		// Token: 0x06004EC2 RID: 20162 RVA: 0x0014C59B File Offset: 0x0014A79B
		public override void ClearStoredInstance(bool _internal = false)
		{
			(base.ItemInstance as CashInstance).SetBalance(0f, true);
		}

		// Token: 0x06004EC3 RID: 20163 RVA: 0x000022C9 File Offset: 0x000004C9
		public override bool CanSlotAcceptCash()
		{
			return true;
		}

		// Token: 0x04003B77 RID: 15223
		public const float MAX_CASH_PER_SLOT = 1000f;
	}
}
