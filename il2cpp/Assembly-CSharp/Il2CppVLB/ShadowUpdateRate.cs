using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppVLB
{
	// Token: 0x02000093 RID: 147
	[OriginalName("Assembly-CSharp.dll", "VLB", "ShadowUpdateRate")]
	[Flags]
	public enum ShadowUpdateRate
	{
		// Token: 0x04000616 RID: 1558
		Never = 1,
		// Token: 0x04000617 RID: 1559
		OnEnable = 2,
		// Token: 0x04000618 RID: 1560
		OnBeamMove = 4,
		// Token: 0x04000619 RID: 1561
		EveryXFrames = 8,
		// Token: 0x0400061A RID: 1562
		OnBeamMoveAndEveryXFrames = 12
	}
}
