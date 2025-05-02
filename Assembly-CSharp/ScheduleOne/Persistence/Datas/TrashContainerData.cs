using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000425 RID: 1061
	public class TrashContainerData : GridItemData
	{
		// Token: 0x0600159A RID: 5530 RVA: 0x000600C6 File Offset: 0x0005E2C6
		public TrashContainerData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, TrashContentData contentData) : base(guid, item, loadOrder, grid, originCoordinate, rotation)
		{
			this.ContentData = contentData;
		}

		// Token: 0x04001431 RID: 5169
		public TrashContentData ContentData;
	}
}
