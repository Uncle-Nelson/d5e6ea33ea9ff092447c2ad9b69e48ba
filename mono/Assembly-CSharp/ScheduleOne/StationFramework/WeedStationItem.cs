using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Packaging;
using ScheduleOne.Product;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008D8 RID: 2264
	public class WeedStationItem : StationItem
	{
		// Token: 0x06003D62 RID: 15714 RVA: 0x00101AC0 File Offset: 0x000FFCC0
		public override void Initialize(StorableItemDefinition itemDefinition)
		{
			base.Initialize(itemDefinition);
			WeedInstance weedInstance = ((WeedDefinition)itemDefinition).GetDefaultInstance(1) as WeedInstance;
			foreach (FilledPackagingVisuals visuals2 in this.Visuals)
			{
				weedInstance.SetupPackagingVisuals(visuals2);
			}
		}

		// Token: 0x04002C32 RID: 11314
		public FilledPackagingVisuals[] Visuals;
	}
}
