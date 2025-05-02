using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Storage
{
	// Token: 0x020008AC RID: 2220
	[RequireComponent(typeof(StorageEntity))]
	public class StorageEntityVisualizer : StorageVisualizer
	{
		// Token: 0x06003C54 RID: 15444 RVA: 0x000FE378 File Offset: 0x000FC578
		protected virtual void Start()
		{
			this.storageEntity = base.GetComponent<StorageEntity>();
			this.storageEntity.onContentsChanged.AddListener(new UnityAction(base.QueueRefresh));
			for (int i = 0; i < this.storageEntity.ItemSlots.Count; i++)
			{
				base.AddSlot(this.storageEntity.ItemSlots[i], false);
			}
			if (this.storageEntity.ItemCount > 0)
			{
				base.QueueRefresh();
			}
		}

		// Token: 0x04002B69 RID: 11113
		private StorageEntity storageEntity;
	}
}
