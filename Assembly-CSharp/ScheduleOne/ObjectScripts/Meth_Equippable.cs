using System;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BB3 RID: 2995
	public class Meth_Equippable : Equippable_Viewmodel
	{
		// Token: 0x060050DC RID: 20700 RVA: 0x00154BE4 File Offset: 0x00152DE4
		public override void Equip(ItemInstance item)
		{
			base.Equip(item);
			MethInstance methInstance = item as MethInstance;
			if (methInstance != null)
			{
				this.Visuals.Setup(methInstance.Definition as MethDefinition);
			}
		}

		// Token: 0x04003CD4 RID: 15572
		public MethVisuals Visuals;
	}
}
