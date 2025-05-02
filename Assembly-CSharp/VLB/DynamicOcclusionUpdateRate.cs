using System;

namespace VLB
{
	// Token: 0x02000108 RID: 264
	[Flags]
	public enum DynamicOcclusionUpdateRate
	{
		// Token: 0x040005BB RID: 1467
		Never = 1,
		// Token: 0x040005BC RID: 1468
		OnEnable = 2,
		// Token: 0x040005BD RID: 1469
		OnBeamMove = 4,
		// Token: 0x040005BE RID: 1470
		EveryXFrames = 8,
		// Token: 0x040005BF RID: 1471
		OnBeamMoveAndEveryXFrames = 12
	}
}
