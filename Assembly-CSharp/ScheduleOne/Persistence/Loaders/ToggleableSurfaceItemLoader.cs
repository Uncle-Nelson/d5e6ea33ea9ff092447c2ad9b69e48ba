using System;
using ScheduleOne.EntityFramework;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x020003CE RID: 974
	public class ToggleableSurfaceItemLoader : SurfaceItemLoader
	{
		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001528 RID: 5416 RVA: 0x0005F16C File Offset: 0x0005D36C
		public override string ItemType
		{
			get
			{
				return typeof(ToggleableSurfaceItemData).Name;
			}
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0005F180 File Offset: 0x0005D380
		public override void Load(string mainPath)
		{
			SurfaceItem surfaceItem = base.LoadAndCreate(mainPath);
			if (surfaceItem == null)
			{
				Console.LogWarning("Failed to load grid item", null);
				return;
			}
			ToggleableSurfaceItemData data = base.GetData<ToggleableSurfaceItemData>(mainPath);
			if (data == null)
			{
				Console.LogWarning("Failed to load ToggleableSurfaceItemData", null);
				return;
			}
			ToggleableSurfaceItem toggleableSurfaceItem = surfaceItem as ToggleableSurfaceItem;
			if (toggleableSurfaceItem != null && data.IsOn)
			{
				toggleableSurfaceItem.TurnOn(true);
			}
		}
	}
}
