using System;
using System.Collections.Generic;

namespace AdvancedPeopleSystem
{
	// Token: 0x020001FF RID: 511
	public class CurrentBlendshapeAnimation
	{
		// Token: 0x04000C1C RID: 3100
		public CharacterAnimationPreset preset;

		// Token: 0x04000C1D RID: 3101
		public List<BlendshapeEmotionValue> blendShapesTemp = new List<BlendshapeEmotionValue>();

		// Token: 0x04000C1E RID: 3102
		public float timer;
	}
}
