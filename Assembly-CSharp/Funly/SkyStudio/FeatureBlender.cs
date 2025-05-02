using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x0200019E RID: 414
	public abstract class FeatureBlender : MonoBehaviour, IFeatureBlender
	{
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000869 RID: 2153
		protected abstract string featureKey { get; }

		// Token: 0x0600086A RID: 2154
		protected abstract void BlendBoth(ProfileBlendingState state, BlendingHelper helper);

		// Token: 0x0600086B RID: 2155
		protected abstract void BlendIn(ProfileBlendingState state, BlendingHelper helper);

		// Token: 0x0600086C RID: 2156
		protected abstract void BlendOut(ProfileBlendingState state, BlendingHelper helper);

		// Token: 0x0600086D RID: 2157 RVA: 0x00026B83 File Offset: 0x00024D83
		protected virtual ProfileFeatureBlendingMode BlendingMode(ProfileBlendingState state, BlendingHelper helper)
		{
			return helper.GetFeatureAnimationMode(this.featureKey);
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00026B94 File Offset: 0x00024D94
		public virtual void Blend(ProfileBlendingState state, BlendingHelper helper)
		{
			switch (this.BlendingMode(state, helper))
			{
			case ProfileFeatureBlendingMode.Normal:
				this.BlendBoth(state, helper);
				return;
			case ProfileFeatureBlendingMode.FadeFeatureOut:
				this.BlendOut(state, helper);
				return;
			case ProfileFeatureBlendingMode.FadeFeatureIn:
				this.BlendIn(state, helper);
				return;
			default:
				return;
			}
		}
	}
}
