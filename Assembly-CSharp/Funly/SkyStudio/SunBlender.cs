using System;

namespace Funly.SkyStudio
{
	// Token: 0x0200019C RID: 412
	public class SunBlender : FeatureBlender
	{
		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x0002671A File Offset: 0x0002491A
		protected override string featureKey
		{
			get
			{
				return "SunFeature";
			}
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00026724 File Offset: 0x00024924
		protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendColor("SunColorKey");
			helper.BlendNumber("SunSizeKey");
			helper.BlendNumber("SunEdgeFeatheringKey");
			helper.BlendNumber("SunColorIntensityKey");
			helper.BlendNumber("SunAlphaKey");
			helper.BlendColor("SunLightColorKey");
			helper.BlendNumber("SunLightIntensityKey");
			helper.BlendSpherePoint("SunPositionKey");
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00026789 File Offset: 0x00024989
		protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumberIn("SunAlphaKey", 0f);
			helper.BlendNumberIn("SunLightIntensityKey", 0f);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x000267AB File Offset: 0x000249AB
		protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumberOut("SunAlphaKey", 0f);
			helper.BlendNumberOut("SunLightIntensityKey", 0f);
		}
	}
}
