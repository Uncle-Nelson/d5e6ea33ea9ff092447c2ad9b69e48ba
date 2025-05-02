using System;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Trash
{
	// Token: 0x0200082A RID: 2090
	public class TrashBag : TrashItem
	{
		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06003930 RID: 14640 RVA: 0x000F1F94 File Offset: 0x000F0194
		// (set) Token: 0x06003931 RID: 14641 RVA: 0x000F1F9C File Offset: 0x000F019C
		public TrashContent Content { get; private set; } = new TrashContent();

		// Token: 0x06003932 RID: 14642 RVA: 0x000F1FA5 File Offset: 0x000F01A5
		public void LoadContent(TrashContentData data)
		{
			this.Content.LoadFromData(data);
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x000F1FB4 File Offset: 0x000F01B4
		public override TrashItemData GetData()
		{
			return new TrashBagData(this.ID, base.GUID.ToString(), base.transform.position, base.transform.rotation, this.Content.GetData());
		}
	}
}
