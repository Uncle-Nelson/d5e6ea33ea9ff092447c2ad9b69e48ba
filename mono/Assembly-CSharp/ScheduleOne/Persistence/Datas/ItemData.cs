using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003E6 RID: 998
	[Serializable]
	public class ItemData : SaveData
	{
		// Token: 0x06001559 RID: 5465 RVA: 0x0005F8A9 File Offset: 0x0005DAA9
		public ItemData(string iD, int quantity)
		{
			this.ID = iD;
			this.Quantity = quantity;
		}

		// Token: 0x0400139D RID: 5021
		public string ID;

		// Token: 0x0400139E RID: 5022
		public int Quantity;
	}
}
