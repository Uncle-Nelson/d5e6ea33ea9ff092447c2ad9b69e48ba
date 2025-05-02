using System;

namespace Funly.SkyStudio
{
	// Token: 0x02000198 RID: 408
	public class RainBlender : FeatureBlender
	{
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x000263D5 File Offset: 0x000245D5
		protected override string featureKey
		{
			get
			{
				return "RainFeature";
			}
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x000263DC File Offset: 0x000245DC
		protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumber("RainSoundVolume");
			helper.BlendNumber("RainNearIntensityKey");
			helper.BlendNumber("RainNearSpeedKey");
			helper.BlendNumber("RainNearTextureTiling");
			helper.BlendNumber("RainFarIntensityKey");
			helper.BlendNumber("RainFarSpeedKey");
			helper.BlendNumber("RainFarTextureTiling");
			helper.BlendColor("RainTintColorKey");
			helper.BlendNumber("RainWindTurbulenceKey");
			helper.BlendNumber("RainWindTurbulenceSpeedKey");
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00026457 File Offset: 0x00024657
		protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumberIn("RainSoundVolume", 0f);
			helper.BlendNumberIn("RainNearIntensityKey", 0f);
			helper.BlendNumberIn("RainFarIntensityKey", 0f);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00026489 File Offset: 0x00024689
		protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumberOut("RainSoundVolume", 0f);
			helper.BlendNumberOut("RainNearIntensityKey", 0f);
			helper.BlendNumberOut("RainFarIntensityKey", 0f);
		}
	}
}
