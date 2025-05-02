using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001A3 RID: 419
	[Serializable]
	public class ColorKeyframeGroup : KeyframeGroup<ColorKeyframe>
	{
		// Token: 0x06000875 RID: 2165 RVA: 0x00026CE3 File Offset: 0x00024EE3
		public ColorKeyframeGroup(string name) : base(name)
		{
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00026CEC File Offset: 0x00024EEC
		public ColorKeyframeGroup(string name, ColorKeyframe frame) : base(name)
		{
			base.AddKeyFrame(frame);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00026CFC File Offset: 0x00024EFC
		public Color ColorForTime(float time)
		{
			time -= (float)((int)time);
			if (this.keyframes.Count == 0)
			{
				Debug.LogError("Can't return color since there aren't any keyframes.");
				return Color.white;
			}
			if (this.keyframes.Count == 1)
			{
				return base.GetKeyframe(0).color;
			}
			int index;
			int index2;
			base.GetSurroundingKeyFrames(time, out index, out index2);
			ColorKeyframe keyframe = base.GetKeyframe(index);
			ColorKeyframe keyframe2 = base.GetKeyframe(index2);
			float t = KeyframeGroup<ColorKeyframe>.ProgressBetweenSurroundingKeyframes(time, keyframe, keyframe2);
			float t2 = base.CurveAdjustedBlendingTime(keyframe.interpolationCurve, t);
			return Color.Lerp(keyframe.color, keyframe2.color, t2);
		}
	}
}
