using System;

namespace Funly.SkyStudio
{
	// Token: 0x020001B2 RID: 434
	[Serializable]
	public class ProfileFeatureDefinition
	{
		// Token: 0x060008BF RID: 2239 RVA: 0x0002767C File Offset: 0x0002587C
		public static ProfileFeatureDefinition CreateShaderFeature(string featureKey, string shaderKeyword, bool value, string name, string dependsOnFeature, bool dependsOnValue, string tooltip)
		{
			return new ProfileFeatureDefinition
			{
				featureType = ProfileFeatureDefinition.FeatureType.ShaderKeyword,
				featureKey = featureKey,
				shaderKeyword = shaderKeyword,
				name = name,
				value = value,
				tooltip = tooltip,
				dependsOnFeature = dependsOnFeature,
				dependsOnValue = dependsOnValue
			};
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x000276CC File Offset: 0x000258CC
		public static ProfileFeatureDefinition CreateShaderFeatureDropdown(string[] featureKeys, string[] shaderKeywords, string[] labels, int selectedIndex, string name, string dependsOnFeature, bool dependsOnValue, string tooltip)
		{
			return new ProfileFeatureDefinition
			{
				featureType = ProfileFeatureDefinition.FeatureType.ShaderKeywordDropdown,
				featureKeys = featureKeys,
				shaderKeywords = shaderKeywords,
				dropdownLabels = labels,
				name = name,
				dropdownSelectedIndex = selectedIndex,
				tooltip = tooltip,
				dependsOnFeature = dependsOnFeature,
				dependsOnValue = dependsOnValue
			};
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00027721 File Offset: 0x00025921
		public static ProfileFeatureDefinition CreateBooleanFeature(string featureKey, bool value, string name, string dependsOnFeature, bool dependsOnValue, string tooltip)
		{
			return new ProfileFeatureDefinition
			{
				featureType = ProfileFeatureDefinition.FeatureType.BooleanValue,
				featureKey = featureKey,
				name = name,
				value = value,
				tooltip = tooltip
			};
		}

		// Token: 0x04000977 RID: 2423
		public string featureKey;

		// Token: 0x04000978 RID: 2424
		public string[] featureKeys;

		// Token: 0x04000979 RID: 2425
		public ProfileFeatureDefinition.FeatureType featureType;

		// Token: 0x0400097A RID: 2426
		public string shaderKeyword;

		// Token: 0x0400097B RID: 2427
		public string[] shaderKeywords;

		// Token: 0x0400097C RID: 2428
		public string[] dropdownLabels;

		// Token: 0x0400097D RID: 2429
		public int dropdownSelectedIndex;

		// Token: 0x0400097E RID: 2430
		public string name;

		// Token: 0x0400097F RID: 2431
		public bool value;

		// Token: 0x04000980 RID: 2432
		public string tooltip;

		// Token: 0x04000981 RID: 2433
		public string dependsOnFeature;

		// Token: 0x04000982 RID: 2434
		public bool dependsOnValue;

		// Token: 0x04000983 RID: 2435
		public bool isShaderKeywordFeature;

		// Token: 0x020001B3 RID: 435
		public enum FeatureType
		{
			// Token: 0x04000985 RID: 2437
			ShaderKeyword,
			// Token: 0x04000986 RID: 2438
			BooleanValue,
			// Token: 0x04000987 RID: 2439
			ShaderKeywordDropdown
		}
	}
}
