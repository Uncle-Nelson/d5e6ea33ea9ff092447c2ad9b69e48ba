using System;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	// Token: 0x020001FE RID: 510
	[Serializable]
	public class BlendshapeEmotionValue
	{
		// Token: 0x04000C19 RID: 3097
		public CharacterBlendShapeType BlendType;

		// Token: 0x04000C1A RID: 3098
		[Range(-100f, 100f)]
		public float BlendValue;

		// Token: 0x04000C1B RID: 3099
		public AnimationCurve BlendAnimationCurve = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 0f)
		});
	}
}
