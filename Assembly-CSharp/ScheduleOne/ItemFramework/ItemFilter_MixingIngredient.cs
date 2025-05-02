using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Product;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000943 RID: 2371
	public class ItemFilter_MixingIngredient : ItemFilter
	{
		// Token: 0x0600402C RID: 16428 RVA: 0x0010E3A8 File Offset: 0x0010C5A8
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			if (instance == null)
			{
				return false;
			}
			ItemDefinition definition = instance.Definition;
			if (!(definition is PropertyItemDefinition))
			{
				return false;
			}
			PropertyItemDefinition item = definition as PropertyItemDefinition;
			return NetworkSingleton<ProductManager>.Instance.ValidMixIngredients.Contains(item) && base.DoesItemMatchFilter(instance);
		}
	}
}
