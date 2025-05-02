using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003F9 RID: 1017
	[Serializable]
	public class ItemFieldData
	{
		// Token: 0x0600156D RID: 5485 RVA: 0x0005F9FF File Offset: 0x0005DBFF
		public ItemFieldData(string itemID)
		{
			this.ItemID = itemID;
		}

		// Token: 0x040013BA RID: 5050
		public string ItemID;
	}
}
