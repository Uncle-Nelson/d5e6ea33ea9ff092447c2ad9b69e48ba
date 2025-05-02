using System;

namespace Funly.SkyStudio
{
	// Token: 0x02000197 RID: 407
	public class MoonBlender : FeatureBlender
	{
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x00026343 File Offset: 0x00024543
		protected override string featureKey
		{
			get
			{
				return "MoonFeature";
			}
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0002634C File Offset: 0x0002454C
		protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendColor("MoonColorKey");
			helper.BlendNumber("MoonSizeKey");
			helper.BlendNumber("MoonEdgeFeatheringKey");
			helper.BlendNumber("MoonColorIntensityKey");
			helper.BlendNumber("MoonAlphaKey");
			helper.BlendColor("MoonLightColorKey");
			helper.BlendNumber("MoonLightIntensityKey");
			helper.BlendSpherePoint("MoonPositionKey");
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x000263B1 File Offset: 0x000245B1
		protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumberIn("MoonAlphaKey", 0f);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000263C3 File Offset: 0x000245C3
		protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumberOut("MoonAlphaKey", 0f);
		}
	}
}
