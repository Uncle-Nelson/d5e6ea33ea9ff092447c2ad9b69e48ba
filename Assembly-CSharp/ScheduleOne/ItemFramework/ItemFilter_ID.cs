using System;
using System.Collections.Generic;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000941 RID: 2369
	public class ItemFilter_ID : ItemFilter
	{
		// Token: 0x06004027 RID: 16423 RVA: 0x0010E312 File Offset: 0x0010C512
		public ItemFilter_ID(List<string> ids)
		{
			this.IDs = ids;
		}

		// Token: 0x06004028 RID: 16424 RVA: 0x0010E333 File Offset: 0x0010C533
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			if (instance == null)
			{
				return false;
			}
			if (this.IsWhitelist)
			{
				if (!this.IDs.Contains(instance.ID))
				{
					return false;
				}
			}
			else if (this.IDs.Contains(instance.ID))
			{
				return false;
			}
			return base.DoesItemMatchFilter(instance);
		}

		// Token: 0x04002E17 RID: 11799
		public bool IsWhitelist = true;

		// Token: 0x04002E18 RID: 11800
		public List<string> IDs = new List<string>();
	}
}
