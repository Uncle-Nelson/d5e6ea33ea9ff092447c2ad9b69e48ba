using System;

namespace Funly.SkyStudio
{
	// Token: 0x020001AF RID: 431
	[Serializable]
	public class NumberKeyframe : BaseKeyframe
	{
		// Token: 0x060008B9 RID: 2233 RVA: 0x0002756A File Offset: 0x0002576A
		public NumberKeyframe(float time, float value) : base(time)
		{
			this.value = value;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x0002757A File Offset: 0x0002577A
		public NumberKeyframe(NumberKeyframe keyframe) : base(keyframe.time)
		{
			this.value = keyframe.value;
			base.interpolationCurve = keyframe.interpolationCurve;
			base.interpolationDirection = keyframe.interpolationDirection;
		}

		// Token: 0x04000974 RID: 2420
		public float value;
	}
}
