using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200041C RID: 1052
	[Serializable]
	public class PackagingStationData : GridItemData
	{
		// Token: 0x06001591 RID: 5521 RVA: 0x0005FFA5 File Offset: 0x0005E1A5
		public PackagingStationData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet contents) : base(guid, item, loadOrder, grid, originCoordinate, rotation)
		{
			this.Contents = contents;
		}

		// Token: 0x04001420 RID: 5152
		public ItemSet Contents;
	}
}
