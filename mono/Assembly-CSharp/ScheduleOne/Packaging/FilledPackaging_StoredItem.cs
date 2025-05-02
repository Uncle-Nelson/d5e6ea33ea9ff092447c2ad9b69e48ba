using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	// Token: 0x0200088B RID: 2187
	public class FilledPackaging_StoredItem : StoredItem
	{
		// Token: 0x06003B33 RID: 15155 RVA: 0x000F9068 File Offset: 0x000F7268
		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			base.InitializeStoredItem(_item, grid, _originCoordinate, _rotation);
			(base.item as ProductItemInstance).SetupPackagingVisuals(this.Visuals);
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x000F908C File Offset: 0x000F728C
		public override GameObject CreateGhostModel(ItemInstance _item, Transform parent)
		{
			GameObject gameObject = base.CreateGhostModel(_item, parent);
			(_item as ProductItemInstance).SetupPackagingVisuals(gameObject.GetComponent<FilledPackaging_StoredItem>().Visuals);
			return gameObject;
		}

		// Token: 0x04002ABA RID: 10938
		public FilledPackagingVisuals Visuals;
	}
}
