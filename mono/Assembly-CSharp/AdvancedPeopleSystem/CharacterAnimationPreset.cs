using System;
using System.Collections.Generic;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	// Token: 0x02000218 RID: 536
	[Serializable]
	public class CharacterAnimationPreset
	{
		// Token: 0x04000CA1 RID: 3233
		public string name;

		// Token: 0x04000CA2 RID: 3234
		public List<BlendshapeEmotionValue> blendshapes = new List<BlendshapeEmotionValue>();

		// Token: 0x04000CA3 RID: 3235
		public bool UseGlobalBlendCurve = true;

		// Token: 0x04000CA4 RID: 3236
		public AnimationCurve GlobalBlendAnimationCurve = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(0.5f, 1f),
			new Keyframe(1f, 0f)
		});

		// Token: 0x04000CA5 RID: 3237
		[HideInInspector]
		public float AnimationPlayDuration = 1f;

		// Token: 0x04000CA6 RID: 3238
		[HideInInspector]
		public float weightPower = 1f;

		// Token: 0x04000CA7 RID: 3239
		[Header("May decrease performance")]
		public bool applyToAllCharacterMeshes;
	}
}
