using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x0200019D RID: 413
	public class BlendSkyProfiles : MonoBehaviour
	{
		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x000267CD File Offset: 0x000249CD
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x000267D5 File Offset: 0x000249D5
		public SkyProfile fromProfile { get; private set; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x000267DE File Offset: 0x000249DE
		// (set) Token: 0x0600085F RID: 2143 RVA: 0x000267E6 File Offset: 0x000249E6
		public SkyProfile toProfile { get; private set; }

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x000267EF File Offset: 0x000249EF
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x000267F7 File Offset: 0x000249F7
		public SkyProfile blendedProfile { get; private set; }

		// Token: 0x06000862 RID: 2146 RVA: 0x00026800 File Offset: 0x00024A00
		public SkyProfile StartBlending(TimeOfDayController controller, SkyProfile fromProfile, SkyProfile toProfile, float duration)
		{
			if (controller == null)
			{
				Debug.LogWarning("Can't transition with null TimeOfDayController");
				return null;
			}
			if (fromProfile == null)
			{
				Debug.LogWarning("Can't transition to null 'from' sky profile.");
				return null;
			}
			if (toProfile == null)
			{
				Debug.LogWarning("Can't transition to null 'to' sky profile");
				return null;
			}
			if (!fromProfile.IsFeatureEnabled("GradientSkyFeature", true) || !toProfile.IsFeatureEnabled("GradientSkyFeature", true))
			{
				Debug.LogWarning("Sky Studio doesn't currently support automatic transition blending with cubemap backgrounds.");
			}
			this.m_TimeOfDayController = controller;
			this.fromProfile = fromProfile;
			this.toProfile = toProfile;
			this.m_StartTime = Time.time;
			this.m_EndTime = this.m_StartTime + duration;
			this.blendedProfile = Object.Instantiate<SkyProfile>(fromProfile);
			this.blendedProfile.skyboxMaterial = fromProfile.skyboxMaterial;
			this.m_TimeOfDayController.skyProfile = this.blendedProfile;
			this.m_State = new ProfileBlendingState(this.blendedProfile, fromProfile, toProfile, 0f, 0f, 0f, this.m_TimeOfDayController.timeOfDay);
			this.blendingHelper = new BlendingHelper(this.m_State);
			this.UpdateBlendedProfile();
			return this.blendedProfile;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00026919 File Offset: 0x00024B19
		public void CancelBlending()
		{
			this.TearDownBlending();
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00026921 File Offset: 0x00024B21
		public void TearDownBlending()
		{
			if (this.m_TimeOfDayController == null)
			{
				return;
			}
			this.m_TimeOfDayController = null;
			this.blendedProfile = null;
			base.enabled = false;
			Object.Destroy(base.gameObject);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00026952 File Offset: 0x00024B52
		private void Update()
		{
			if (this.blendedProfile == null)
			{
				return;
			}
			this.UpdateBlendedProfile();
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0002696C File Offset: 0x00024B6C
		private void UpdateBlendedProfile()
		{
			if (this.m_TimeOfDayController == null)
			{
				return;
			}
			float num = this.m_EndTime - this.m_StartTime;
			float num2 = Time.time - this.m_StartTime;
			this.m_State.progress = num2 / num;
			this.m_State.inProgress = this.PercentForMode(ProfileFeatureBlendingMode.FadeFeatureIn, this.m_State.progress);
			this.m_State.outProgress = this.PercentForMode(ProfileFeatureBlendingMode.FadeFeatureOut, this.m_State.progress);
			this.blendingHelper.UpdateState(this.m_State);
			if (this.m_State.progress > 0.5f && this.m_IsBlendingFirstHalf)
			{
				this.m_IsBlendingFirstHalf = false;
				this.blendedProfile = Object.Instantiate<SkyProfile>(this.toProfile);
				this.m_State.blendedProfile = this.blendedProfile;
				this.m_TimeOfDayController.skyProfile = this.blendedProfile;
			}
			this.blendingHelper.UpdateState(this.m_State);
			foreach (FeatureBlender featureBlender in new FeatureBlender[]
			{
				this.skyBlender,
				this.sunBlender,
				this.moonBlender,
				this.cloudBlender,
				this.starLayer1Blender,
				this.starLayer2Blender,
				this.starLayer3Blender,
				this.rainBlender,
				this.rainSplashBlender,
				this.lightningBlender,
				this.fogBlender
			})
			{
				if (!(featureBlender == null))
				{
					featureBlender.Blend(this.m_State, this.blendingHelper);
				}
			}
			this.m_TimeOfDayController.skyProfile = this.blendedProfile;
			if (this.m_State.progress >= 1f)
			{
				this.onBlendComplete(this);
				this.TearDownBlending();
			}
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00026B33 File Offset: 0x00024D33
		private float PercentForMode(ProfileFeatureBlendingMode mode, float percent)
		{
			if (mode == ProfileFeatureBlendingMode.FadeFeatureOut)
			{
				return Mathf.Clamp01(percent * 2f);
			}
			if (mode == ProfileFeatureBlendingMode.FadeFeatureIn)
			{
				return Mathf.Clamp01((percent - 0.5f) * 2f);
			}
			return percent;
		}

		// Token: 0x0400093F RID: 2367
		[Tooltip("Called when blending finishes.")]
		public Action<BlendSkyProfiles> onBlendComplete;

		// Token: 0x04000940 RID: 2368
		[HideInInspector]
		private float m_StartTime = -1f;

		// Token: 0x04000941 RID: 2369
		[HideInInspector]
		private float m_EndTime = -1f;

		// Token: 0x04000942 RID: 2370
		[Tooltip("Blender used for basic sky background properties.")]
		public FeatureBlender skyBlender;

		// Token: 0x04000943 RID: 2371
		[Tooltip("Blender used for the sun properties.")]
		public FeatureBlender sunBlender;

		// Token: 0x04000944 RID: 2372
		[Tooltip("Blender used moon properties.")]
		public FeatureBlender moonBlender;

		// Token: 0x04000945 RID: 2373
		[Tooltip("Blender used cloud properties.")]
		public FeatureBlender cloudBlender;

		// Token: 0x04000946 RID: 2374
		[Tooltip("Blender used star layer 1 properties.")]
		public FeatureBlender starLayer1Blender;

		// Token: 0x04000947 RID: 2375
		[Tooltip("Blender used star layer 2 properties.")]
		public FeatureBlender starLayer2Blender;

		// Token: 0x04000948 RID: 2376
		[Tooltip("Blender used star layer 3 properties.")]
		public FeatureBlender starLayer3Blender;

		// Token: 0x04000949 RID: 2377
		[Tooltip("Blender used by the rain downfall feature.")]
		public FeatureBlender rainBlender;

		// Token: 0x0400094A RID: 2378
		[Tooltip("Blender used by the rain splash feature.")]
		public FeatureBlender rainSplashBlender;

		// Token: 0x0400094B RID: 2379
		[Tooltip("Blender used for lightning feature properties.")]
		public FeatureBlender lightningBlender;

		// Token: 0x0400094C RID: 2380
		[Tooltip("Blender used for fog properties.")]
		public FeatureBlender fogBlender;

		// Token: 0x0400094D RID: 2381
		private bool m_IsBlendingFirstHalf = true;

		// Token: 0x0400094E RID: 2382
		private ProfileBlendingState m_State;

		// Token: 0x0400094F RID: 2383
		private TimeOfDayController m_TimeOfDayController;

		// Token: 0x04000950 RID: 2384
		private BlendingHelper blendingHelper;
	}
}
