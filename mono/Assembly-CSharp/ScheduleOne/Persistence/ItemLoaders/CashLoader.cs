using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x02000441 RID: 1089
	public class CashLoader : ItemLoader
	{
		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060015BE RID: 5566 RVA: 0x00060598 File Offset: 0x0005E798
		public override string ItemType
		{
			get
			{
				return typeof(CashData).Name;
			}
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x000605B4 File Offset: 0x0005E7B4
		public override ItemInstance LoadItem(string itemString)
		{
			CashData cashData = base.LoadData<CashData>(itemString);
			if (cashData == null)
			{
				Console.LogWarning("Failed loading item data from " + itemString, null);
				return null;
			}
			if (cashData.ID == string.Empty)
			{
				return null;
			}
			ItemDefinition item = Registry.GetItem(cashData.ID);
			if (item == null)
			{
				Console.LogWarning("Failed to find item definition for " + cashData.ID, null);
				return null;
			}
			CashInstance cashInstance = new CashInstance(item, cashData.Quantity);
			cashInstance.SetBalance(cashData.CashBalance, false);
			return cashInstance;
		}
	}
}
