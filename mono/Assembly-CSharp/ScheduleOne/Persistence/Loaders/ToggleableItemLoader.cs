using System;
using ScheduleOne.EntityFramework;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x020003CD RID: 973
	public class ToggleableItemLoader : GridItemLoader
	{
		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001525 RID: 5413 RVA: 0x0005F0F8 File Offset: 0x0005D2F8
		public override string ItemType
		{
			get
			{
				return typeof(ToggleableItemData).Name;
			}
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0005F10C File Offset: 0x0005D30C
		public override void Load(string mainPath)
		{
			GridItem gridItem = base.LoadAndCreate(mainPath);
			if (gridItem == null)
			{
				Console.LogWarning("Failed to load grid item", null);
				return;
			}
			ToggleableItemData data = base.GetData<ToggleableItemData>(mainPath);
			if (data == null)
			{
				Console.LogWarning("Failed to load toggleableitem data", null);
				return;
			}
			ToggleableItem toggleableItem = gridItem as ToggleableItem;
			if (toggleableItem != null && data.IsOn)
			{
				toggleableItem.TurnOn(true);
			}
		}
	}
}
