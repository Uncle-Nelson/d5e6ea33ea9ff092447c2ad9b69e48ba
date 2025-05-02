using System;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x020003CB RID: 971
	public class StorageSurfaceItemLoader : SurfaceItemLoader
	{
		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x0005EF3D File Offset: 0x0005D13D
		public override string ItemType
		{
			get
			{
				return typeof(StorageSurfaceItemData).Name;
			}
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x0005EF50 File Offset: 0x0005D150
		public override void Load(string mainPath)
		{
			SurfaceItem surfaceItem = base.LoadAndCreate(mainPath);
			if (surfaceItem == null)
			{
				Console.LogWarning("Failed to load surface item", null);
				return;
			}
			SurfaceStorageEntity surfaceStorageEntity = surfaceItem as SurfaceStorageEntity;
			if (surfaceStorageEntity == null)
			{
				Console.LogWarning("Failed to cast surface item to storage entity", null);
				return;
			}
			StorageSurfaceItemData data = base.GetData<StorageSurfaceItemData>(mainPath);
			if (data == null)
			{
				Console.LogWarning("Failed to load storage surface item data", null);
				return;
			}
			for (int i = 0; i < data.Contents.Items.Length; i++)
			{
				ItemInstance instance = ItemDeserializer.LoadItem(data.Contents.Items[i]);
				if (surfaceStorageEntity.StorageEntity.ItemSlots.Count > i)
				{
					surfaceStorageEntity.StorageEntity.ItemSlots[i].SetStoredItem(instance, false);
				}
			}
		}
	}
}
