using System;
using ScheduleOne.Product;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200042C RID: 1068
	[Serializable]
	public class WeedProductData : ProductData
	{
		// Token: 0x060015A2 RID: 5538 RVA: 0x000601B4 File Offset: 0x0005E3B4
		public WeedProductData(string name, string id, EDrugType drugType, string[] properties, WeedAppearanceSettings appearanceSettings) : base(name, id, drugType, properties)
		{
			this.AppearanceSettings = appearanceSettings;
		}

		// Token: 0x04001443 RID: 5187
		public WeedAppearanceSettings AppearanceSettings;
	}
}
