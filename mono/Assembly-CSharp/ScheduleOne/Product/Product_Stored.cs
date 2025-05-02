using System;
using ScheduleOne.Packaging;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000902 RID: 2306
	public class Product_Stored : StoredItem
	{
		// Token: 0x06003EAD RID: 16045 RVA: 0x00108A39 File Offset: 0x00106C39
		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			base.InitializeStoredItem(_item, grid, _originCoordinate, _rotation);
			(_item as ProductItemInstance).SetupPackagingVisuals(this.Visuals);
		}

		// Token: 0x04002CE7 RID: 11495
		public FilledPackagingVisuals Visuals;
	}
}
