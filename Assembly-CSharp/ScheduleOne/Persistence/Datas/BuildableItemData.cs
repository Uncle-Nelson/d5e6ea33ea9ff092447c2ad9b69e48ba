using System;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000414 RID: 1044
	[Serializable]
	public class BuildableItemData : SaveData
	{
		// Token: 0x06001589 RID: 5513 RVA: 0x0005FDCC File Offset: 0x0005DFCC
		public BuildableItemData(Guid guid, ItemInstance item, int loadOrder)
		{
			this.GUID = guid.ToString();
			this.ItemString = item.GetItemData().GetJson(true);
			this.LoadOrder = loadOrder;
		}

		// Token: 0x040013FE RID: 5118
		public string GUID;

		// Token: 0x040013FF RID: 5119
		public string ItemString;

		// Token: 0x04001400 RID: 5120
		public int LoadOrder;
	}
}
