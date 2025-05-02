using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000413 RID: 1043
	[Serializable]
	public class BrickPressData : GridItemData
	{
		// Token: 0x06001588 RID: 5512 RVA: 0x0005FDB3 File Offset: 0x0005DFB3
		public BrickPressData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet contents) : base(guid, item, loadOrder, grid, originCoordinate, rotation)
		{
			this.Contents = contents;
		}

		// Token: 0x040013FD RID: 5117
		public ItemSet Contents;
	}
}
