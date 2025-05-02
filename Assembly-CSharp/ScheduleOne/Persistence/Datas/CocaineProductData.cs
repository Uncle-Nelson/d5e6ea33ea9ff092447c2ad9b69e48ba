using System;
using ScheduleOne.Product;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000429 RID: 1065
	[Serializable]
	public class CocaineProductData : ProductData
	{
		// Token: 0x0600159F RID: 5535 RVA: 0x00060165 File Offset: 0x0005E365
		public CocaineProductData(string name, string id, EDrugType drugType, string[] properties, CocaineAppearanceSettings appearanceSettings) : base(name, id, drugType, properties)
		{
			this.AppearanceSettings = appearanceSettings;
		}

		// Token: 0x0400143D RID: 5181
		public CocaineAppearanceSettings AppearanceSettings;
	}
}
