using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Packaging;
using ScheduleOne.Product;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008BD RID: 2237
	public class CocaineStationItem : StationItem
	{
		// Token: 0x06003CF0 RID: 15600 RVA: 0x001006A8 File Offset: 0x000FE8A8
		public override void Initialize(StorableItemDefinition itemDefinition)
		{
			base.Initialize(itemDefinition);
			CocaineInstance cocaineInstance = ((CocaineDefinition)itemDefinition).GetDefaultInstance(1) as CocaineInstance;
			foreach (FilledPackagingVisuals visuals2 in this.Visuals)
			{
				cocaineInstance.SetupPackagingVisuals(visuals2);
			}
		}

		// Token: 0x04002BC4 RID: 11204
		public FilledPackagingVisuals[] Visuals;
	}
}
