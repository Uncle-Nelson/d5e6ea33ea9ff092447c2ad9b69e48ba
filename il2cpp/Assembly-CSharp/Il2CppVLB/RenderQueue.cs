using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppVLB
{
	// Token: 0x0200008E RID: 142
	[OriginalName("Assembly-CSharp.dll", "VLB", "RenderQueue")]
	public enum RenderQueue
	{
		// Token: 0x040005FE RID: 1534
		Custom,
		// Token: 0x040005FF RID: 1535
		Background = 1000,
		// Token: 0x04000600 RID: 1536
		Geometry = 2000,
		// Token: 0x04000601 RID: 1537
		AlphaTest = 2450,
		// Token: 0x04000602 RID: 1538
		GeometryLast = 2500,
		// Token: 0x04000603 RID: 1539
		Transparent = 3000,
		// Token: 0x04000604 RID: 1540
		Overlay = 4000
	}
}
