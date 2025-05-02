using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200041B RID: 1051
	public class MixingStationData : GridItemData
	{
		// Token: 0x06001590 RID: 5520 RVA: 0x0005FF6C File Offset: 0x0005E16C
		public MixingStationData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet productContents, ItemSet mixerContents, ItemSet outputContents, MixOperation currentMixOperation, int currentMixTime) : base(guid, item, loadOrder, grid, originCoordinate, rotation)
		{
			this.ProductContents = productContents;
			this.MixerContents = mixerContents;
			this.OutputContents = outputContents;
			this.CurrentMixOperation = currentMixOperation;
			this.CurrentMixTime = currentMixTime;
		}

		// Token: 0x0400141B RID: 5147
		public ItemSet ProductContents;

		// Token: 0x0400141C RID: 5148
		public ItemSet MixerContents;

		// Token: 0x0400141D RID: 5149
		public ItemSet OutputContents;

		// Token: 0x0400141E RID: 5150
		public MixOperation CurrentMixOperation;

		// Token: 0x0400141F RID: 5151
		public int CurrentMixTime;
	}
}
