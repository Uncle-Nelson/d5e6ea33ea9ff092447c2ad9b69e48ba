using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001A2 RID: 418
	[Serializable]
	public class BoolKeyframeGroup : KeyframeGroup<BoolKeyframe>
	{
		// Token: 0x06000872 RID: 2162 RVA: 0x00026C10 File Offset: 0x00024E10
		public BoolKeyframeGroup(string name) : base(name)
		{
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00026C19 File Offset: 0x00024E19
		public BoolKeyframeGroup(string name, BoolKeyframe keyframe) : base(name)
		{
			base.AddKeyFrame(keyframe);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00026C2C File Offset: 0x00024E2C
		public bool BoolForTime(float time)
		{
			if (this.keyframes.Count == 0)
			{
				Debug.LogError("Can't sample bool without any keyframes");
				return false;
			}
			if (this.keyframes.Count == 1)
			{
				return this.keyframes[0].value;
			}
			if (time < this.keyframes[0].time)
			{
				return this.keyframes[this.keyframes.Count - 1].value;
			}
			int index = 0;
			int num = 1;
			while (num < this.keyframes.Count && this.keyframes[num].time <= time)
			{
				index = num;
				num++;
			}
			return this.keyframes[index].value;
		}
	}
}
