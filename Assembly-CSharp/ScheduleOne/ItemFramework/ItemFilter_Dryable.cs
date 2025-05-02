using System;
using ScheduleOne.Product;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000940 RID: 2368
	public class ItemFilter_Dryable : ItemFilter
	{
		// Token: 0x06004025 RID: 16421 RVA: 0x0010E295 File Offset: 0x0010C495
		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return ItemFilter_Dryable.IsItemDryable(instance) && base.DoesItemMatchFilter(instance);
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x0010E2A8 File Offset: 0x0010C4A8
		public static bool IsItemDryable(ItemInstance instance)
		{
			if (instance == null)
			{
				return false;
			}
			ProductItemInstance productItemInstance = instance as ProductItemInstance;
			return (productItemInstance != null && (productItemInstance.Definition as ProductDefinition).DrugType == EDrugType.Marijuana && productItemInstance.AppliedPackaging == null && productItemInstance.Quality < EQuality.Heavenly) || (instance.ID == "cocaleaf" && (instance as QualityItemInstance).Quality < EQuality.Heavenly);
		}
	}
}
