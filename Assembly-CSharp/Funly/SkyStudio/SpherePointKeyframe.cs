using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001B0 RID: 432
	[Serializable]
	public class SpherePointKeyframe : BaseKeyframe
	{
		// Token: 0x060008BB RID: 2235 RVA: 0x000275AC File Offset: 0x000257AC
		public SpherePointKeyframe(SpherePoint spherePoint, float time) : base(time)
		{
			if (spherePoint == null)
			{
				Debug.LogError("Passed null sphere point, created empty point");
				this.spherePoint = new SpherePoint(0f, 0f);
			}
			else
			{
				this.spherePoint = spherePoint;
			}
			base.interpolationDirection = InterpolationDirection.Auto;
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x000275E8 File Offset: 0x000257E8
		public SpherePointKeyframe(SpherePointKeyframe keyframe) : base(keyframe.time)
		{
			this.spherePoint = new SpherePoint(keyframe.spherePoint.horizontalRotation, keyframe.spherePoint.verticalRotation);
			base.interpolationCurve = keyframe.interpolationCurve;
			base.interpolationDirection = keyframe.interpolationDirection;
		}

		// Token: 0x04000975 RID: 2421
		public SpherePoint spherePoint;
	}
}
