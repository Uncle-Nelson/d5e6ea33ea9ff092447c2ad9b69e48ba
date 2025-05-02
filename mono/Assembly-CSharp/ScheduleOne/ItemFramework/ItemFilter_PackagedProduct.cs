using System;
using System.Collections.Generic;
using ScheduleOne.Product;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000944 RID: 2372
	public class ItemFilter_PackagedProduct : ItemFilter_Category
	{
		// Token: 0x0600402D RID: 16429 RVA: 0x0010E3ED File Offset: 0x0010C5ED
		public ItemFilter_PackagedProduct() : base(new List<EItemCategory>
		{
			EItemCategory.Product
		})
		{
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x0010E404 File Offset: 0x0010C604
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			ProductItemInstance productItemInstance = instance as ProductItemInstance;
			return productItemInstance != null && !(productItemInstance.AppliedPackaging == null) && base.DoesItemMatchFilter(instance);
		}
	}
}
