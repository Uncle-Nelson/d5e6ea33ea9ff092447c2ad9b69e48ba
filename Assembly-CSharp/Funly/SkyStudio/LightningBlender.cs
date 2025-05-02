using System;

namespace Funly.SkyStudio
{
	// Token: 0x02000196 RID: 406
	public class LightningBlender : FeatureBlender
	{
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x000262C8 File Offset: 0x000244C8
		protected override string featureKey
		{
			get
			{
				return "LightningFeature";
			}
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x000262D0 File Offset: 0x000244D0
		protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendColor("LightningTintColorKey");
			helper.BlendNumber("ThunderSoundVolumeKey");
			helper.BlendNumber("ThunderSoundDelayKey");
			helper.BlendNumber("LightningProbabilityKey");
			helper.BlendNumber("LightningStrikeCoolDown");
			helper.BlendNumber("LightningIntensityKey");
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0002631F File Offset: 0x0002451F
		protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumberIn("ThunderSoundVolumeKey", 0f);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00026331 File Offset: 0x00024531
		protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumberOut("ThunderSoundVolumeKey", 0f);
		}
	}
}
