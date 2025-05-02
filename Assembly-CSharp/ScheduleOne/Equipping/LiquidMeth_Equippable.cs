using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000917 RID: 2327
	public class LiquidMeth_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06003EFF RID: 16127 RVA: 0x00109E50 File Offset: 0x00108050
		public override void Equip(ItemInstance item)
		{
			base.Equip(item);
			LiquidMethDefinition def = item.Definition as LiquidMethDefinition;
			if (this.Visuals != null)
			{
				this.Visuals.Setup(def);
			}
		}

		// Token: 0x04002D33 RID: 11571
		public LiquidMethVisuals Visuals;
	}
}
