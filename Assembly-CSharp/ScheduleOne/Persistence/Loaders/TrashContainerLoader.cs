using System;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x020003CF RID: 975
	public class TrashContainerLoader : GridItemLoader
	{
		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x0600152B RID: 5419 RVA: 0x0005F1E0 File Offset: 0x0005D3E0
		public override string ItemType
		{
			get
			{
				return typeof(TrashContainerData).Name;
			}
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0005F1F4 File Offset: 0x0005D3F4
		public override void Load(string mainPath)
		{
			GridItem gridItem = base.LoadAndCreate(mainPath);
			if (gridItem == null)
			{
				Console.LogWarning("Failed to load grid item", null);
				return;
			}
			TrashContainerData data = base.GetData<TrashContainerData>(mainPath);
			if (data == null)
			{
				Console.LogWarning("Failed to load toggleableitem data", null);
				return;
			}
			TrashContainerItem trashContainerItem = gridItem as TrashContainerItem;
			if (trashContainerItem != null)
			{
				trashContainerItem.Container.Content.LoadFromData(data.ContentData);
			}
		}
	}
}
