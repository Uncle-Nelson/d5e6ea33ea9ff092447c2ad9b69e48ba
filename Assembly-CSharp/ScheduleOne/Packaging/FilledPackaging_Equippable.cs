using System;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;

namespace ScheduleOne.Packaging
{
	// Token: 0x0200088A RID: 2186
	public class FilledPackaging_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06003B31 RID: 15153 RVA: 0x000F904E File Offset: 0x000F724E
		public override void Equip(ItemInstance item)
		{
			base.Equip(item);
			(item as ProductItemInstance).SetupPackagingVisuals(this.Visuals);
		}

		// Token: 0x04002AB9 RID: 10937
		public FilledPackagingVisuals Visuals;
	}
}
