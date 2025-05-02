using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000418 RID: 1048
	[Serializable]
	public class GridItemData : BuildableItemData
	{
		// Token: 0x0600158D RID: 5517 RVA: 0x0005FEBC File Offset: 0x0005E0BC
		public GridItemData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation) : base(guid, item, loadOrder)
		{
			this.GridGUID = grid.GUID.ToString();
			this.OriginCoordinate = originCoordinate;
			this.Rotation = rotation;
		}

		// Token: 0x04001410 RID: 5136
		public string GridGUID;

		// Token: 0x04001411 RID: 5137
		public Vector2 OriginCoordinate;

		// Token: 0x04001412 RID: 5138
		public int Rotation;
	}
}
