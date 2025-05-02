using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008BB RID: 2235
	public class LiquidMeth_StationItem : StationItem
	{
		// Token: 0x06003CDD RID: 15581 RVA: 0x001000AC File Offset: 0x000FE2AC
		public override void Initialize(StorableItemDefinition itemDefinition)
		{
			base.Initialize(itemDefinition);
			LiquidMethDefinition liquidMethDefinition = itemDefinition as LiquidMethDefinition;
			if (this.Visuals != null)
			{
				this.Visuals.Setup(liquidMethDefinition);
			}
			base.GetModule<CookableModule>().LiquidColor = liquidMethDefinition.CookableLiquidColor;
			base.GetModule<CookableModule>().SolidColor = liquidMethDefinition.CookableSolidColor;
			base.GetModule<PourableModule>().LiquidColor = liquidMethDefinition.LiquidVolumeColor;
			base.GetModule<PourableModule>().PourParticlesColor = liquidMethDefinition.PourParticlesColor;
		}

		// Token: 0x04002BB0 RID: 11184
		public LiquidMethVisuals Visuals;
	}
}
