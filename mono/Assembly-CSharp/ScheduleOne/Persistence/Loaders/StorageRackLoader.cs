using System;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x020003CA RID: 970
	public class StorageRackLoader : GridItemLoader
	{
		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x0005EE75 File Offset: 0x0005D075
		public override string ItemType
		{
			get
			{
				return typeof(PlaceableStorageData).Name;
			}
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x0005EE88 File Offset: 0x0005D088
		public override void Load(string mainPath)
		{
			GridItem gridItem = base.LoadAndCreate(mainPath);
			if (gridItem == null)
			{
				Console.LogWarning("Failed to load grid item", null);
				return;
			}
			PlaceableStorageEntity placeableStorageEntity = gridItem as PlaceableStorageEntity;
			if (placeableStorageEntity == null)
			{
				Console.LogWarning("Failed to cast grid item to rack", null);
				return;
			}
			PlaceableStorageData data = base.GetData<PlaceableStorageData>(mainPath);
			if (data == null)
			{
				Console.LogWarning("Failed to load storage rack data", null);
				return;
			}
			for (int i = 0; i < data.Contents.Items.Length; i++)
			{
				ItemInstance instance = ItemDeserializer.LoadItem(data.Contents.Items[i]);
				if (placeableStorageEntity.StorageEntity.ItemSlots.Count > i)
				{
					placeableStorageEntity.StorageEntity.ItemSlots[i].SetStoredItem(instance, false);
				}
			}
		}
	}
}
