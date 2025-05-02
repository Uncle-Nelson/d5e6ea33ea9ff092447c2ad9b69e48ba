using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001AB RID: 427
	[Serializable]
	public class ColorKeyframe : BaseKeyframe
	{
		// Token: 0x060008B0 RID: 2224 RVA: 0x00027512 File Offset: 0x00025712
		public ColorKeyframe(Color c, float time) : base(time)
		{
			this.color = c;
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x0002752D File Offset: 0x0002572D
		public ColorKeyframe(ColorKeyframe keyframe) : base(keyframe.time)
		{
			this.color = keyframe.color;
			base.interpolationCurve = keyframe.interpolationCurve;
			base.interpolationDirection = keyframe.interpolationDirection;
		}

		// Token: 0x0400096B RID: 2411
		public Color color = Color.white;
	}
}
