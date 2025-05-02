using System;
using System.Collections.Generic;
using ScheduleOne.Product;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000945 RID: 2373
	public class ItemFilter_UnpackagedProduct : ItemFilter_Category
	{
		// Token: 0x0600402F RID: 16431 RVA: 0x0010E3ED File Offset: 0x0010C5ED
		public ItemFilter_UnpackagedProduct() : base(new List<EItemCategory>
		{
			EItemCategory.Product
		})
		{
		}

		// Token: 0x06004030 RID: 16432 RVA: 0x0010E434 File Offset: 0x0010C634
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			ProductItemInstance productItemInstance = instance as ProductItemInstance;
			return productItemInstance != null && !(productItemInstance.AppliedPackaging != null) && base.DoesItemMatchFilter(instance);
		}
	}
}
