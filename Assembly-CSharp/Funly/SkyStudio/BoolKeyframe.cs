using System;

namespace Funly.SkyStudio
{
	// Token: 0x020001AA RID: 426
	[Serializable]
	public class BoolKeyframe : BaseKeyframe
	{
		// Token: 0x060008AE RID: 2222 RVA: 0x000274D0 File Offset: 0x000256D0
		public BoolKeyframe(float time, bool value) : base(time)
		{
			this.value = value;
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x000274E0 File Offset: 0x000256E0
		public BoolKeyframe(BoolKeyframe keyframe) : base(keyframe.time)
		{
			this.value = keyframe.value;
			base.interpolationCurve = keyframe.interpolationCurve;
			base.interpolationDirection = keyframe.interpolationDirection;
		}

		// Token: 0x0400096A RID: 2410
		public bool value;
	}
}
