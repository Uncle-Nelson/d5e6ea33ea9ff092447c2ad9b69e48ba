using System;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Map
{
	// Token: 0x02000C15 RID: 3093
	public class DarkMarketAccessZone : TimedAccessZone
	{
		// Token: 0x060056F3 RID: 22259 RVA: 0x0016D9F2 File Offset: 0x0016BBF2
		protected override bool GetIsOpen()
		{
			return NetworkSingleton<DarkMarket>.Instance.IsOpen && NetworkSingleton<DarkMarket>.Instance.Unlocked && base.GetIsOpen();
		}
	}
}
