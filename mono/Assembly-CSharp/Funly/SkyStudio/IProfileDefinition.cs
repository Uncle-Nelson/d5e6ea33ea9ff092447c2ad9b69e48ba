using System;

namespace Funly.SkyStudio
{
	// Token: 0x020001C5 RID: 453
	public interface IProfileDefinition
	{
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060008E6 RID: 2278
		string shaderName { get; }

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060008E7 RID: 2279
		ProfileFeatureSection[] features { get; }

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060008E8 RID: 2280
		ProfileGroupSection[] groups { get; }

		// Token: 0x060008E9 RID: 2281
		ProfileFeatureDefinition GetFeatureDefinition(string featureKey);
	}
}
