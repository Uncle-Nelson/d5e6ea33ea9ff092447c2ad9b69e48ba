using System;

namespace Funly.SkyStudio
{
	// Token: 0x02000199 RID: 409
	public class RainSplashBlender : FeatureBlender
	{
		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x000264BB File Offset: 0x000246BB
		protected override string featureKey
		{
			get
			{
				return "RainSplashFeature";
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x000264C4 File Offset: 0x000246C4
		protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumber("RainSplashMaxConcurrentKey");
			helper.BlendNumber("RainSplashAreaStartKey");
			helper.BlendNumber("RainSplashAreaLengthKey");
			helper.BlendNumber("RainSplashScaleKey");
			helper.BlendNumber("RainSplashScaleVarienceKey");
			helper.BlendNumber("RainSplashIntensityKey");
			helper.BlendNumber("RainSplashSurfaceOffsetKey");
			helper.BlendColor("RainSplashTintColorKey");
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00026529 File Offset: 0x00024729
		protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumberIn("RainSplashIntensityKey", 0f);
			helper.BlendNumberIn("RainSplashMaxConcurrentKey", 0f);
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0002654B File Offset: 0x0002474B
		protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumberOut("RainSplashIntensityKey", 0f);
			helper.BlendNumberOut("RainSplashMaxConcurrentKey", 0f);
		}
	}
}
