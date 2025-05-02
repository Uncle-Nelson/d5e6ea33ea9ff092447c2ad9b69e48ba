using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000140 RID: 320
	[OriginalName("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CombinerState")]
	public enum CombinerState : byte
	{
		// Token: 0x040011CE RID: 4558
		NotCombined,
		// Token: 0x040011CF RID: 4559
		InProgressCombineMesh,
		// Token: 0x040011D0 RID: 4560
		InProgressBlendshapeTransfer,
		// Token: 0x040011D1 RID: 4561
		InProgressClear,
		// Token: 0x040011D2 RID: 4562
		Combined,
		// Token: 0x040011D3 RID: 4563
		UsedPreBuitMeshes
	}
}
