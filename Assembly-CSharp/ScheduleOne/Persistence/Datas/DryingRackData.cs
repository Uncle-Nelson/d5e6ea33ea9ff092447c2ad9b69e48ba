using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000417 RID: 1047
	public class DryingRackData : GridItemData
	{
		// Token: 0x0600158C RID: 5516 RVA: 0x0005FE90 File Offset: 0x0005E090
		public DryingRackData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet input, ItemSet output, DryingOperation[] dryingOperations) : base(guid, item, loadOrder, grid, originCoordinate, rotation)
		{
			this.Input = input;
			this.Output = output;
			this.DryingOperations = dryingOperations;
		}

		// Token: 0x0400140D RID: 5133
		public ItemSet Input;

		// Token: 0x0400140E RID: 5134
		public ItemSet Output;

		// Token: 0x0400140F RID: 5135
		public DryingOperation[] DryingOperations;
	}
}
