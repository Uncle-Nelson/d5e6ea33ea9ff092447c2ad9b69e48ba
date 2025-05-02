using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200043A RID: 1082
	[Serializable]
	public class TrashData : SaveData
	{
		// Token: 0x060015B6 RID: 5558 RVA: 0x00060490 File Offset: 0x0005E690
		public TrashData(TrashItemData[] trash)
		{
			this.Items = trash;
		}

		// Token: 0x04001473 RID: 5235
		public TrashItemData[] Items;
	}
}
