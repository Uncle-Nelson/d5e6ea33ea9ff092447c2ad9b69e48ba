using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001B1 RID: 433
	[Serializable]
	public class TextureKeyframe : BaseKeyframe
	{
		// Token: 0x060008BD RID: 2237 RVA: 0x0002763A File Offset: 0x0002583A
		public TextureKeyframe(Texture texture, float time) : base(time)
		{
			this.texture = texture;
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x0002764A File Offset: 0x0002584A
		public TextureKeyframe(TextureKeyframe keyframe) : base(keyframe.time)
		{
			this.texture = keyframe.texture;
			base.interpolationCurve = keyframe.interpolationCurve;
			base.interpolationDirection = keyframe.interpolationDirection;
		}

		// Token: 0x04000976 RID: 2422
		public Texture texture;
	}
}
