using System;

namespace Funly.SkyStudio
{
	// Token: 0x02000193 RID: 403
	public class CloudBlender : FeatureBlender
	{
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x000261B9 File Offset: 0x000243B9
		protected override string featureKey
		{
			get
			{
				return "CloudFeature";
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x000261C0 File Offset: 0x000243C0
		protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumber("CloudDensityKey");
			helper.BlendNumber("CloudTextureTiling");
			helper.BlendNumber("CloudSpeedKey");
			helper.BlendNumber("CloudDirectionKey");
			helper.BlendNumber("CloudFadeAmountKey");
			helper.BlendNumber("CloudFadePositionKey");
			helper.BlendNumber("CloudAlphaKey");
			helper.BlendColor("CloudColor1Key");
			helper.BlendColor("CloudColor2Key");
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00026230 File Offset: 0x00024430
		protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumberIn("CloudAlphaKey", 0f);
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00026242 File Offset: 0x00024442
		protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumberOut("CloudAlphaKey", 0f);
		}
	}
}
