using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000421 RID: 1057
	public class StorageSurfaceItemData : SurfaceItemData
	{
		// Token: 0x06001596 RID: 5526 RVA: 0x00060058 File Offset: 0x0005E258
		public StorageSurfaceItemData(Guid guid, ItemInstance item, int loadOrder, string parentSurfaceGUID, Vector3 pos, Quaternion rot, ItemSet contents) : base(guid, item, loadOrder, parentSurfaceGUID, pos, rot)
		{
			this.Contents = contents;
		}

		// Token: 0x0400142B RID: 5163
		public ItemSet Contents;
	}
}
