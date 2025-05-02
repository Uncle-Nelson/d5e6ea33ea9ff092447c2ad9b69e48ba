using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001A6 RID: 422
	[Serializable]
	public class NumberKeyframeGroup : KeyframeGroup<NumberKeyframe>
	{
		// Token: 0x06000898 RID: 2200 RVA: 0x000271AE File Offset: 0x000253AE
		public NumberKeyframeGroup(string name, float min, float max) : base(name)
		{
			this.minValue = min;
			this.maxValue = max;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x000271C5 File Offset: 0x000253C5
		public NumberKeyframeGroup(string name, float min, float max, NumberKeyframe frame) : base(name)
		{
			this.minValue = min;
			this.maxValue = max;
			base.AddKeyFrame(frame);
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x000271E4 File Offset: 0x000253E4
		public float GetFirstValue()
		{
			return base.GetKeyframe(0).value;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x000271F2 File Offset: 0x000253F2
		public float ValueToPercent(float value)
		{
			return Mathf.Abs((value - this.minValue) / (this.maxValue - this.minValue));
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0002720F File Offset: 0x0002540F
		public float ValuePercentAtTime(float time)
		{
			return this.ValueToPercent(this.NumericValueAtTime(time));
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0002721E File Offset: 0x0002541E
		public float PercentToValue(float percent)
		{
			return Mathf.Clamp(this.minValue + (this.maxValue - this.minValue) * percent, this.minValue, this.maxValue);
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00027248 File Offset: 0x00025448
		public float NumericValueAtTime(float time)
		{
			time -= (float)((int)time);
			if (this.keyframes.Count == 0)
			{
				Debug.LogError("Keyframe group has no keyframes: " + base.name);
				return this.minValue;
			}
			if (this.keyframes.Count == 1)
			{
				return base.GetKeyframe(0).value;
			}
			int index;
			int index2;
			base.GetSurroundingKeyFrames(time, out index, out index2);
			NumberKeyframe keyframe = base.GetKeyframe(index);
			NumberKeyframe keyframe2 = base.GetKeyframe(index2);
			return base.InterpolateFloat(keyframe.interpolationCurve, keyframe.interpolationDirection, time, keyframe.time, keyframe2.time, keyframe.value, keyframe2.value, this.minValue, this.maxValue);
		}

		// Token: 0x04000960 RID: 2400
		public float minValue;

		// Token: 0x04000961 RID: 2401
		public float maxValue;
	}
}
