using System;

namespace Funly.SkyStudio
{
	// Token: 0x020001B9 RID: 441
	public class ProfileGroupSection
	{
		// Token: 0x060008D2 RID: 2258 RVA: 0x000279B8 File Offset: 0x00025BB8
		public ProfileGroupSection(string sectionTitle, string sectionKey, string sectionIcon, string dependsOnFeature, bool dependsOnValue, ProfileGroupDefinition[] groups)
		{
			this.sectionTitle = sectionTitle;
			this.sectionIcon = sectionIcon;
			this.sectionKey = sectionKey;
			this.groups = groups;
			this.dependsOnFeature = dependsOnFeature;
			this.dependsOnValue = dependsOnValue;
		}

		// Token: 0x040009D0 RID: 2512
		public string sectionTitle;

		// Token: 0x040009D1 RID: 2513
		public string sectionIcon;

		// Token: 0x040009D2 RID: 2514
		public string sectionKey;

		// Token: 0x040009D3 RID: 2515
		public string dependsOnFeature;

		// Token: 0x040009D4 RID: 2516
		public bool dependsOnValue;

		// Token: 0x040009D5 RID: 2517
		public ProfileGroupDefinition[] groups;
	}
}
