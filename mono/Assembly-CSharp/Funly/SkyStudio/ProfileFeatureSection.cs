using System;

namespace Funly.SkyStudio
{
	// Token: 0x020001BA RID: 442
	[Serializable]
	public class ProfileFeatureSection
	{
		// Token: 0x060008D3 RID: 2259 RVA: 0x000279ED File Offset: 0x00025BED
		public ProfileFeatureSection(string sectionTitle, string sectionKey, ProfileFeatureDefinition[] featureDefinitions)
		{
			this.sectionTitle = sectionTitle;
			this.sectionKey = sectionKey;
			this.featureDefinitions = featureDefinitions;
		}

		// Token: 0x040009D6 RID: 2518
		public string sectionTitle;

		// Token: 0x040009D7 RID: 2519
		public string sectionKey;

		// Token: 0x040009D8 RID: 2520
		public string sectionIcon;

		// Token: 0x040009D9 RID: 2521
		public ProfileFeatureDefinition[] featureDefinitions;
	}
}
