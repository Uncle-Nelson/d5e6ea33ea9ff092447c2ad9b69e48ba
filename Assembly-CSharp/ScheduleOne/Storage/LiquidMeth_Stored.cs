using System;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x0200089F RID: 2207
	public class LiquidMeth_Stored : StoredItem
	{
		// Token: 0x06003B99 RID: 15257 RVA: 0x000FAC14 File Offset: 0x000F8E14
		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			base.InitializeStoredItem(_item, grid, _originCoordinate, _rotation);
			LiquidMethDefinition def = _item.Definition as LiquidMethDefinition;
			if (this.Visuals != null)
			{
				this.Visuals.Setup(def);
			}
		}

		// Token: 0x04002B31 RID: 11057
		public LiquidMethVisuals Visuals;
	}
}
