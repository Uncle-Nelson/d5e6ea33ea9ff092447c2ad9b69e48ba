using System;
using ScheduleOne.EntityFramework;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x020003BF RID: 959
	public class LabelledSurfaceItemLoader : SurfaceItemLoader
	{
		// Token: 0x170003DF RID: 991
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x0005E47C File Offset: 0x0005C67C
		public override string ItemType
		{
			get
			{
				return typeof(LabelledSurfaceItemData).Name;
			}
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x0005E498 File Offset: 0x0005C698
		public override void Load(string mainPath)
		{
			SurfaceItem surfaceItem = base.LoadAndCreate(mainPath);
			if (surfaceItem == null)
			{
				Console.LogWarning("Failed to load surface item", null);
				return;
			}
			LabelledSurfaceItemData data = base.GetData<LabelledSurfaceItemData>(mainPath);
			if (data == null)
			{
				Console.LogWarning("Failed to load LabelledSurfaceItemData", null);
				return;
			}
			LabelledSurfaceItem labelledSurfaceItem = surfaceItem as LabelledSurfaceItem;
			if (labelledSurfaceItem != null)
			{
				labelledSurfaceItem.SetMessage(null, data.Message);
			}
		}
	}
}
