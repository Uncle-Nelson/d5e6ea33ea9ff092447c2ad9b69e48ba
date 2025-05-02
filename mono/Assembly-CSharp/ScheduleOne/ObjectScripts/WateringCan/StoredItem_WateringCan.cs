using System;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x02000BF8 RID: 3064
	public class StoredItem_WateringCan : StoredItem
	{
		// Token: 0x06005658 RID: 22104 RVA: 0x0016B5A4 File Offset: 0x001697A4
		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			base.InitializeStoredItem(_item, grid, _originCoordinate, _rotation);
			WateringCanInstance wateringCanInstance = _item as WateringCanInstance;
			if (wateringCanInstance == null)
			{
				return;
			}
			this.Visuals.SetFillLevel(wateringCanInstance.CurrentFillAmount / 15f);
		}

		// Token: 0x04003FB9 RID: 16313
		public WateringCanVisuals Visuals;
	}
}
