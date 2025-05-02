using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppVLB
{
	// Token: 0x02000091 RID: 145
	[OriginalName("Assembly-CSharp.dll", "VLB", "DynamicOcclusionUpdateRate")]
	[Flags]
	public enum DynamicOcclusionUpdateRate
	{
		// Token: 0x0400060C RID: 1548
		Never = 1,
		// Token: 0x0400060D RID: 1549
		OnEnable = 2,
		// Token: 0x0400060E RID: 1550
		OnBeamMove = 4,
		// Token: 0x0400060F RID: 1551
		EveryXFrames = 8,
		// Token: 0x04000610 RID: 1552
		OnBeamMoveAndEveryXFrames = 12
	}
}
