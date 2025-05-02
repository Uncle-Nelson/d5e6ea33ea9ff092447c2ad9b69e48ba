using System;

namespace VLB
{
	// Token: 0x02000105 RID: 261
	public enum RenderQueue
	{
		// Token: 0x040005AD RID: 1453
		Custom,
		// Token: 0x040005AE RID: 1454
		Background = 1000,
		// Token: 0x040005AF RID: 1455
		Geometry = 2000,
		// Token: 0x040005B0 RID: 1456
		AlphaTest = 2450,
		// Token: 0x040005B1 RID: 1457
		GeometryLast = 2500,
		// Token: 0x040005B2 RID: 1458
		Transparent = 3000,
		// Token: 0x040005B3 RID: 1459
		Overlay = 4000
	}
}
