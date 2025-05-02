using System;

namespace AdvancedPeopleSystem
{
	// Token: 0x020001FA RID: 506
	public enum CombinerState : byte
	{
		// Token: 0x04000C08 RID: 3080
		NotCombined,
		// Token: 0x04000C09 RID: 3081
		InProgressCombineMesh,
		// Token: 0x04000C0A RID: 3082
		InProgressBlendshapeTransfer,
		// Token: 0x04000C0B RID: 3083
		InProgressClear,
		// Token: 0x04000C0C RID: 3084
		Combined,
		// Token: 0x04000C0D RID: 3085
		UsedPreBuitMeshes
	}
}
