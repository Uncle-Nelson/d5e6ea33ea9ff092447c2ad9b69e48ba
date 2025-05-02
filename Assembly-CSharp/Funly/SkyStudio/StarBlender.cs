using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x0200019B RID: 411
	public class StarBlender : FeatureBlender
	{
		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x00026628 File Offset: 0x00024828
		protected override string featureKey
		{
			get
			{
				return "StarLayer" + this.starLayer.ToString() + "Feature";
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00026644 File Offset: 0x00024844
		protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendColor(this.PropertyKeyForLayer("Star1ColorKey"));
			helper.BlendNumber(this.PropertyKeyForLayer("Star1SizeKey"));
			helper.BlendNumber(this.PropertyKeyForLayer("Star1RotationSpeed"));
			helper.BlendNumber(this.PropertyKeyForLayer("Star1TwinkleAmountKey"));
			helper.BlendNumber(this.PropertyKeyForLayer("Star1TwinkleSpeedKey"));
			helper.BlendNumber(this.PropertyKeyForLayer("Star1EdgeFeathering"));
			helper.BlendNumber(this.PropertyKeyForLayer("Star1ColorIntensityKey"));
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x000266C8 File Offset: 0x000248C8
		protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumberIn(this.PropertyKeyForLayer("Star1SizeKey"), 0f);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000266E0 File Offset: 0x000248E0
		protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
			helper.BlendNumberOut(this.PropertyKeyForLayer("Star1SizeKey"), 0f);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000266F8 File Offset: 0x000248F8
		private string PropertyKeyForLayer(string key)
		{
			return key.Replace("Star1", "Star" + this.starLayer.ToString());
		}

		// Token: 0x0400093B RID: 2363
		[Range(1f, 3f)]
		public int starLayer;
	}
}
