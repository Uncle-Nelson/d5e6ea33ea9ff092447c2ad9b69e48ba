using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200041D RID: 1053
	[Serializable]
	public class PlaceableStorageData : GridItemData
	{
		// Token: 0x06001592 RID: 5522 RVA: 0x0005FFBE File Offset: 0x0005E1BE
		public PlaceableStorageData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet contents) : base(guid, item, loadOrder, grid, originCoordinate, rotation)
		{
			this.Contents = contents;
		}

		// Token: 0x04001421 RID: 5153
		public ItemSet Contents;
	}
}
