using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000423 RID: 1059
	public class ToggleableItemData : GridItemData
	{
		// Token: 0x06001598 RID: 5528 RVA: 0x00060094 File Offset: 0x0005E294
		public ToggleableItemData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, bool isOn) : base(guid, item, loadOrder, grid, originCoordinate, rotation)
		{
			this.IsOn = isOn;
		}

		// Token: 0x0400142F RID: 5167
		public bool IsOn;
	}
}
