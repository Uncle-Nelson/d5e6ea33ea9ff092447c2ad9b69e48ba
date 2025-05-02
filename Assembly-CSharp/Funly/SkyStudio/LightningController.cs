using System;
using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001DA RID: 474
	public class LightningController : MonoBehaviour, ISkyModule
	{
		// Token: 0x06000A7B RID: 2683 RVA: 0x0002E74A File Offset: 0x0002C94A
		private void Start()
		{
			if (!SystemInfo.supportsInstancing)
			{
				Debug.LogWarning("Can't render lightning since GPU instancing is not supported on this platform.");
				base.enabled = false;
				return;
			}
			this.ClearLightningRenderers();
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x0002E76B File Offset: 0x0002C96B
		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
			this.m_SkyProfile = skyProfile;
			this.m_TimeOfDay = timeOfDay;
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0002E77C File Offset: 0x0002C97C
		public void Update()
		{
			if (this.m_SkyProfile == null || !this.m_SkyProfile.IsFeatureEnabled("LightningFeature", true))
			{
				this.ClearLightningRenderers();
				return;
			}
			if (this.m_SkyProfile.lightningArtSet == null || this.m_SkyProfile.lightningArtSet.lightingStyleItems == null || this.m_SkyProfile.lightningArtSet.lightingStyleItems.Count == 0)
			{
				return;
			}
			if (this.m_SkyProfile.lightningArtSet.lightingStyleItems.Count != this.m_LightningRenderers.Count)
			{
				this.ClearLightningRenderers();
				this.CreateLightningRenderers();
			}
			for (int i = 0; i < this.m_SkyProfile.lightningArtSet.lightingStyleItems.Count; i++)
			{
				LightningArtItem artItem = this.m_SkyProfile.lightningArtSet.lightingStyleItems[i];
				this.m_LightningRenderers[i].UpdateForTimeOfDay(this.m_SkyProfile, this.m_TimeOfDay, artItem);
			}
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0002E874 File Offset: 0x0002CA74
		public void ClearLightningRenderers()
		{
			for (int i = 0; i < base.transform.childCount; i++)
			{
				Object.Destroy(base.transform.GetChild(i).gameObject);
			}
			this.m_LightningRenderers.Clear();
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0002E8B8 File Offset: 0x0002CAB8
		public void CreateLightningRenderers()
		{
			for (int i = 0; i < this.m_SkyProfile.lightningArtSet.lightingStyleItems.Count; i++)
			{
				LightningRenderer lightningRenderer = new GameObject("Lightning Renderer").AddComponent<LightningRenderer>();
				lightningRenderer.transform.parent = base.transform;
				this.m_LightningRenderers.Add(lightningRenderer);
			}
		}

		// Token: 0x04000B75 RID: 2933
		private SkyProfile m_SkyProfile;

		// Token: 0x04000B76 RID: 2934
		private float m_TimeOfDay;

		// Token: 0x04000B77 RID: 2935
		private List<LightningRenderer> m_LightningRenderers = new List<LightningRenderer>();
	}
}
