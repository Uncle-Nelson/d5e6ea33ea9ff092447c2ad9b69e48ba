using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x0200014E RID: 334
	public static class SpotLightHelper
	{
		// Token: 0x06000649 RID: 1609 RVA: 0x0001CB04 File Offset: 0x0001AD04
		public static float GetIntensity(Light light)
		{
			if (!(light != null))
			{
				return 0f;
			}
			return light.intensity;
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0001CB1B File Offset: 0x0001AD1B
		public static float GetSpotAngle(Light light)
		{
			if (!(light != null))
			{
				return 0f;
			}
			return light.spotAngle;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0001CB32 File Offset: 0x0001AD32
		public static float GetFallOffEnd(Light light)
		{
			if (!(light != null))
			{
				return 0f;
			}
			return light.range;
		}
	}
}
