using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000192 RID: 402
	public class BlendingHelper
	{
		// Token: 0x0600081C RID: 2076 RVA: 0x00025E73 File Offset: 0x00024073
		public BlendingHelper(ProfileBlendingState state)
		{
			this.m_State = state;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00025E82 File Offset: 0x00024082
		public void UpdateState(ProfileBlendingState state)
		{
			this.m_State = state;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00025E8C File Offset: 0x0002408C
		public Color ProfileColorForKey(SkyProfile profile, string key)
		{
			float time = (profile == this.m_State.toProfile) ? 0f : this.m_State.timeOfDay;
			return profile.GetGroup<ColorKeyframeGroup>(key).ColorForTime(time);
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00025ECC File Offset: 0x000240CC
		public float ProfileNumberForKey(SkyProfile profile, string key)
		{
			float time = (profile == this.m_State.toProfile) ? 0f : this.m_State.timeOfDay;
			return profile.GetGroup<NumberKeyframeGroup>(key).NumericValueAtTime(time);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00025F0C File Offset: 0x0002410C
		public SpherePoint ProfileSpherePointForKey(SkyProfile profile, string key)
		{
			float time = (profile == this.m_State.toProfile) ? 0f : this.m_State.timeOfDay;
			return profile.GetGroup<SpherePointKeyframeGroup>(key).SpherePointForTime(time);
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00025F4C File Offset: 0x0002414C
		public void BlendColor(string key)
		{
			this.BlendColor(key, this.ProfileColorForKey(this.m_State.fromProfile, key), this.ProfileColorForKey(this.m_State.toProfile, key), this.m_State.progress);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00025F84 File Offset: 0x00024184
		public void BlendColorOut(string key)
		{
			this.BlendColor(key, this.ProfileColorForKey(this.m_State.fromProfile, key), this.ProfileColorForKey(this.m_State.fromProfile, key).Clear(), this.m_State.outProgress);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00025FC1 File Offset: 0x000241C1
		public void BlendColorIn(string key)
		{
			this.BlendColor(key, this.ProfileColorForKey(this.m_State.toProfile, key).Clear(), this.ProfileColorForKey(this.m_State.toProfile, key), this.m_State.inProgress);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00025FFE File Offset: 0x000241FE
		public void BlendColor(string key, Color from, Color to, float progress)
		{
			this.m_State.blendedProfile.GetGroup<ColorKeyframeGroup>(key).keyframes[0].color = Color.LerpUnclamped(from, to, progress);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0002602A File Offset: 0x0002422A
		public void BlendNumber(string key)
		{
			this.BlendNumber(key, this.ProfileNumberForKey(this.m_State.fromProfile, key), this.ProfileNumberForKey(this.m_State.toProfile, key), this.m_State.progress);
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00026062 File Offset: 0x00024262
		public void BlendNumberOut(string key, float toValue = 0f)
		{
			this.BlendNumber(key, this.ProfileNumberForKey(this.m_State.fromProfile, key), toValue, this.m_State.outProgress);
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00026089 File Offset: 0x00024289
		public void BlendNumberIn(string key, float fromValue = 0f)
		{
			this.BlendNumber(key, fromValue, this.ProfileNumberForKey(this.m_State.toProfile, key), this.m_State.inProgress);
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x000260B0 File Offset: 0x000242B0
		public void BlendNumber(string key, float from, float to, float progress)
		{
			this.m_State.blendedProfile.GetGroup<NumberKeyframeGroup>(key).keyframes[0].value = Mathf.Lerp(from, to, progress);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x000260DC File Offset: 0x000242DC
		public void BlendSpherePoint(string key)
		{
			this.BlendSpherePoint(key, this.ProfileSpherePointForKey(this.m_State.fromProfile, "MoonPositionKey"), this.ProfileSpherePointForKey(this.m_State.toProfile, "MoonPositionKey"), this.m_State.progress);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0002611C File Offset: 0x0002431C
		public void BlendSpherePoint(string key, SpherePoint from, SpherePoint to, float progress)
		{
			Vector3 vector = Vector3.Slerp(from.GetWorldDirection(), to.GetWorldDirection(), progress);
			this.m_State.blendedProfile.GetGroup<SpherePointKeyframeGroup>(key).keyframes[0].spherePoint = new SpherePoint(vector.normalized);
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0002616C File Offset: 0x0002436C
		public ProfileFeatureBlendingMode GetFeatureAnimationMode(string featureKey)
		{
			bool flag = this.m_State.fromProfile.IsFeatureEnabled(featureKey, true);
			bool flag2 = this.m_State.toProfile.IsFeatureEnabled(featureKey, true);
			if (flag && flag2)
			{
				return ProfileFeatureBlendingMode.Normal;
			}
			if (flag && !flag2)
			{
				return ProfileFeatureBlendingMode.FadeFeatureOut;
			}
			if (!flag && flag2)
			{
				return ProfileFeatureBlendingMode.FadeFeatureIn;
			}
			return ProfileFeatureBlendingMode.None;
		}

		// Token: 0x0400093A RID: 2362
		private ProfileBlendingState m_State;
	}
}
