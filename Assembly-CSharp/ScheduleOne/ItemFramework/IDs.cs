using System;
using System.Collections.Generic;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200093C RID: 2364
	public class IDs : ItemFilter
	{
		// Token: 0x0600401A RID: 16410 RVA: 0x0010E1BD File Offset: 0x0010C3BD
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return this.AcceptedIDs.Contains(instance.ID) && base.DoesItemMatchFilter(instance);
		}

		// Token: 0x04002E14 RID: 11796
		public List<string> AcceptedIDs = new List<string>();
	}
}
