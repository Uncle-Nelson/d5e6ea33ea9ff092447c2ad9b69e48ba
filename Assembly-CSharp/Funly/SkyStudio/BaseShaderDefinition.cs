using System;
using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001C4 RID: 452
	[Serializable]
	public abstract class BaseShaderDefinition : IProfileDefinition
	{
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x00027A93 File Offset: 0x00025C93
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x00027A9B File Offset: 0x00025C9B
		public string shaderName { get; protected set; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00027AA4 File Offset: 0x00025CA4
		public ProfileGroupSection[] groups
		{
			get
			{
				ProfileGroupSection[] result;
				if ((result = this.m_ProfileDefinitions) == null)
				{
					result = (this.m_ProfileDefinitions = this.ProfileDefinitionTable());
				}
				return result;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x00027ACC File Offset: 0x00025CCC
		public ProfileFeatureSection[] features
		{
			get
			{
				ProfileFeatureSection[] result;
				if ((result = this.m_ProfileFeatures) == null)
				{
					result = (this.m_ProfileFeatures = this.ProfileFeatureSection());
				}
				return result;
			}
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00027AF4 File Offset: 0x00025CF4
		public ProfileFeatureDefinition GetFeatureDefinition(string featureKey)
		{
			if (this.m_KeyToFeature == null)
			{
				this.m_KeyToFeature = new Dictionary<string, ProfileFeatureDefinition>();
				ProfileFeatureSection[] features = this.features;
				for (int i = 0; i < features.Length; i++)
				{
					foreach (ProfileFeatureDefinition profileFeatureDefinition in features[i].featureDefinitions)
					{
						if (profileFeatureDefinition.featureType == ProfileFeatureDefinition.FeatureType.BooleanValue || profileFeatureDefinition.featureType == ProfileFeatureDefinition.FeatureType.ShaderKeyword)
						{
							this.m_KeyToFeature[profileFeatureDefinition.featureKey] = profileFeatureDefinition;
						}
						else if (profileFeatureDefinition.featureType == ProfileFeatureDefinition.FeatureType.ShaderKeywordDropdown)
						{
							foreach (string key in profileFeatureDefinition.featureKeys)
							{
								this.m_KeyToFeature[key] = profileFeatureDefinition;
							}
						}
					}
				}
			}
			if (featureKey == null)
			{
				return null;
			}
			if (!this.m_KeyToFeature.ContainsKey(featureKey))
			{
				return null;
			}
			return this.m_KeyToFeature[featureKey];
		}

		// Token: 0x060008E3 RID: 2275
		protected abstract ProfileFeatureSection[] ProfileFeatureSection();

		// Token: 0x060008E4 RID: 2276
		protected abstract ProfileGroupSection[] ProfileDefinitionTable();

		// Token: 0x04000A9E RID: 2718
		private ProfileGroupSection[] m_ProfileDefinitions;

		// Token: 0x04000A9F RID: 2719
		[SerializeField]
		private ProfileFeatureSection[] m_ProfileFeatures;

		// Token: 0x04000AA0 RID: 2720
		private Dictionary<string, ProfileFeatureDefinition> m_KeyToFeature;
	}
}
