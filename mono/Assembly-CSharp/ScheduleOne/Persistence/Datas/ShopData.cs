using System;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000435 RID: 1077
	public class ShopData : SaveData
	{
		// Token: 0x060015AF RID: 5551 RVA: 0x000603C7 File Offset: 0x0005E5C7
		public ShopData(string shopCode, StringIntPair[] itemStockQuantities)
		{
			this.ShopCode = shopCode;
			this.ItemStockQuantities = itemStockQuantities;
		}

		// Token: 0x04001468 RID: 5224
		public string ShopCode;

		// Token: 0x04001469 RID: 5225
		public StringIntPair[] ItemStockQuantities;
	}
}
