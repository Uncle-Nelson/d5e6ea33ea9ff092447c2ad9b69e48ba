using System;
using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001DE RID: 478
	public class RainSplashController : MonoBehaviour, ISkyModule
	{
		// Token: 0x06000A9C RID: 2716 RVA: 0x0002F269 File Offset: 0x0002D469
		private void Start()
		{
			if (!SystemInfo.supportsInstancing)
			{
				Debug.LogWarning("Can't render rain splashes since GPU instancing is not supported on this platform.");
				base.enabled = false;
				return;
			}
			this.ClearSplashRenderers();
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0002F28A File Offset: 0x0002D48A
		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
			this.m_SkyProfile = skyProfile;
			this.m_TimeOfDay = timeOfDay;
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0002F29C File Offset: 0x0002D49C
		private void Update()
		{
			if (this.m_SkyProfile == null || !this.m_SkyProfile.IsFeatureEnabled("RainSplashFeature", true))
			{
				this.ClearSplashRenderers();
				return;
			}
			if (this.m_SkyProfile.rainSplashArtSet == null || this.m_SkyProfile.rainSplashArtSet.rainSplashArtItems == null || this.m_SkyProfile.rainSplashArtSet.rainSplashArtItems.Count == 0)
			{
				this.ClearSplashRenderers();
				return;
			}
			if (this.m_SkyProfile.rainSplashArtSet.rainSplashArtItems.Count != this.m_SplashRenderers.Count)
			{
				this.ClearSplashRenderers();
				this.CreateSplashRenderers();
			}
			for (int i = 0; i < this.m_SkyProfile.rainSplashArtSet.rainSplashArtItems.Count; i++)
			{
				RainSplashArtItem style = this.m_SkyProfile.rainSplashArtSet.rainSplashArtItems[i];
				this.m_SplashRenderers[i].UpdateForTimeOfDay(this.m_SkyProfile, this.m_TimeOfDay, style);
			}
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0002F398 File Offset: 0x0002D598
		public void ClearSplashRenderers()
		{
			for (int i = 0; i < base.transform.childCount; i++)
			{
				Object.Destroy(base.transform.GetChild(i).gameObject);
			}
			this.m_SplashRenderers.Clear();
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0002F3DC File Offset: 0x0002D5DC
		public void CreateSplashRenderers()
		{
			for (int i = 0; i < this.m_SkyProfile.rainSplashArtSet.rainSplashArtItems.Count; i++)
			{
				RainSplashRenderer rainSplashRenderer = new GameObject("Rain Splash Renderer").AddComponent<RainSplashRenderer>();
				rainSplashRenderer.transform.parent = base.transform;
				this.m_SplashRenderers.Add(rainSplashRenderer);
			}
		}

		// Token: 0x04000B8A RID: 2954
		private SkyProfile m_SkyProfile;

		// Token: 0x04000B8B RID: 2955
		private float m_TimeOfDay;

		// Token: 0x04000B8C RID: 2956
		private List<RainSplashRenderer> m_SplashRenderers = new List<RainSplashRenderer>();
	}
}
