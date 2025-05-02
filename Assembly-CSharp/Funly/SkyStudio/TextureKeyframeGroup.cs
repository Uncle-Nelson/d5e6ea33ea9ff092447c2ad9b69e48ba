using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001A8 RID: 424
	[Serializable]
	public class TextureKeyframeGroup : KeyframeGroup<TextureKeyframe>
	{
		// Token: 0x060008A2 RID: 2210 RVA: 0x000273C4 File Offset: 0x000255C4
		public TextureKeyframeGroup(string name, TextureKeyframe keyframe) : base(name)
		{
			base.AddKeyFrame(keyframe);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x000273D4 File Offset: 0x000255D4
		public Texture TextureForTime(float time)
		{
			if (this.keyframes.Count == 0)
			{
				Debug.LogError("Can't return texture without any keyframes");
				return null;
			}
			if (this.keyframes.Count == 1)
			{
				return base.GetKeyframe(0).texture;
			}
			int index;
			int num;
			base.GetSurroundingKeyFrames(time, out index, out num);
			return base.GetKeyframe(index).texture;
		}
	}
}
