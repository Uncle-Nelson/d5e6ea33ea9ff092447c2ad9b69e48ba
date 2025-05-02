using System;

namespace Funly.SkyStudio
{
	// Token: 0x02000195 RID: 405
	public class FogBlender : FeatureBlender
	{
		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x0002627A File Offset: 0x0002447A
		protected override string featureKey
		{
			get
			{
				return "FogFeature";
			}
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00026281 File Offset: 0x00024481
		protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumber("FogDensityKey");
			helper.BlendNumber("FogLengthKey");
			helper.BlendColor("FogColorKey");
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x000262A4 File Offset: 0x000244A4
		protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumberIn("FogDensityKey", 0f);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000262B6 File Offset: 0x000244B6
		protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumberOut("FogDensityKey", 0f);
		}
	}
}
