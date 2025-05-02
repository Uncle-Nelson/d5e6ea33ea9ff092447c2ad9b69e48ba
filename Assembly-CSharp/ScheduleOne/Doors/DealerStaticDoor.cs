using System;
using ScheduleOne.Economy;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x02000687 RID: 1671
	public class DealerStaticDoor : StaticDoor
	{
		// Token: 0x06002E4B RID: 11851 RVA: 0x000C23E4 File Offset: 0x000C05E4
		protected override bool IsKnockValid(out string message)
		{
			if (this.Building.OccupantCount == 0 && Vector3.Distance(base.transform.position, this.Dealer.transform.position) > 2f)
			{
				message = this.Dealer.FirstName + " is out dealing";
				return false;
			}
			return base.IsKnockValid(out message);
		}

		// Token: 0x040020D3 RID: 8403
		public Dealer Dealer;
	}
}
