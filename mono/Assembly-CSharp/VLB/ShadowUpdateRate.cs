using System;

namespace VLB
{
	// Token: 0x0200010A RID: 266
	[Flags]
	public enum ShadowUpdateRate
	{
		// Token: 0x040005C5 RID: 1477
		Never = 1,
		// Token: 0x040005C6 RID: 1478
		OnEnable = 2,
		// Token: 0x040005C7 RID: 1479
		OnBeamMove = 4,
		// Token: 0x040005C8 RID: 1480
		EveryXFrames = 8,
		// Token: 0x040005C9 RID: 1481
		OnBeamMoveAndEveryXFrames = 12
	}
}
