using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x02000444 RID: 1092
	public class IntegerItemLoader : ItemLoader
	{
		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060015C7 RID: 5575 RVA: 0x0006079F File Offset: 0x0005E99F
		public override string ItemType
		{
			get
			{
				return typeof(IntegerItemData).Name;
			}
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x000607B0 File Offset: 0x0005E9B0
		public override ItemInstance LoadItem(string itemString)
		{
			IntegerItemData integerItemData = base.LoadData<IntegerItemData>(itemString);
			if (integerItemData == null)
			{
				Console.LogWarning("Failed loading item data from " + itemString, null);
				return null;
			}
			if (integerItemData.ID == string.Empty)
			{
				return null;
			}
			ItemDefinition item = Registry.GetItem(integerItemData.ID);
			if (item == null)
			{
				Console.LogWarning("Failed to find item definition for " + integerItemData.ID, null);
				return null;
			}
			return new IntegerItemInstance(item, integerItemData.Quantity, integerItemData.Value);
		}
	}
}
