using System;
using System.Collections.Generic;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200093E RID: 2366
	public class ItemFilter_Category : ItemFilter
	{
		// Token: 0x0600401E RID: 16414 RVA: 0x0010E1EE File Offset: 0x0010C3EE
		public ItemFilter_Category(List<EItemCategory> acceptedCategories)
		{
			this.AcceptedCategories = acceptedCategories;
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x0010E208 File Offset: 0x0010C408
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return this.AcceptedCategories.Contains(instance.Category) && base.DoesItemMatchFilter(instance);
		}

		// Token: 0x04002E15 RID: 11797
		public List<EItemCategory> AcceptedCategories = new List<EItemCategory>();
	}
}
