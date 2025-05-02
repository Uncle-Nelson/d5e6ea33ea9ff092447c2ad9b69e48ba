using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Packaging;
using ScheduleOne.Product;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008CD RID: 2253
	public class MethStationItem : StationItem
	{
		// Token: 0x06003D2F RID: 15663 RVA: 0x00100FAC File Offset: 0x000FF1AC
		public override void Initialize(StorableItemDefinition itemDefinition)
		{
			base.Initialize(itemDefinition);
			MethInstance methInstance = ((MethDefinition)itemDefinition).GetDefaultInstance(1) as MethInstance;
			foreach (FilledPackagingVisuals visuals2 in this.Visuals)
			{
				methInstance.SetupPackagingVisuals(visuals2);
			}
		}

		// Token: 0x04002BFC RID: 11260
		public FilledPackagingVisuals[] Visuals;
	}
}
