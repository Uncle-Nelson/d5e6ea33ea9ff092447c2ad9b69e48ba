using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Map;

namespace ScheduleOne.Doors
{
	// Token: 0x02000686 RID: 1670
	public class DarkMarketRollerDoors : SensorRollerDoors
	{
		// Token: 0x06002E49 RID: 11849 RVA: 0x000C23CF File Offset: 0x000C05CF
		protected override bool CanOpen()
		{
			return NetworkSingleton<DarkMarket>.Instance.IsOpen;
		}
	}
}
