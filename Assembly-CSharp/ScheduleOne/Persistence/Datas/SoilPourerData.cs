using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000420 RID: 1056
	public class SoilPourerData : GridItemData
	{
		// Token: 0x06001595 RID: 5525 RVA: 0x0006003F File Offset: 0x0005E23F
		public SoilPourerData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, string soilID) : base(guid, item, loadOrder, grid, originCoordinate, rotation)
		{
			this.SoilID = soilID;
		}

		// Token: 0x0400142A RID: 5162
		public string SoilID;
	}
}
